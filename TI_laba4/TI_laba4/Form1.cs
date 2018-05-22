using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace TI_laba4
{
    public partial class Form1 : Form
    {
        public byte[] textByte;
        private BigInteger[] textArray;
        private BigInteger[] str = new BigInteger[1];
        static byte[] bytes;

        public Form1()
        {
            InitializeComponent();
        }

        private static BigInteger fastExp(BigInteger D, BigInteger qp, BigInteger z)
        {
            BigInteger Mqp, a1, z1;

            a1 = D;
            z1 = z;
            Mqp = 1;
            while (z1 != 0)
            {
                while ((z1 % 2) == 0)
                {
                    z1 = z1 / 2;
                    a1 = (a1 * a1) % qp;
                }
                z1 -= 1;
                Mqp = (Mqp * a1) % qp;
            }

            return Mqp;
        }

        private BigInteger EuclidAlg(BigInteger a, BigInteger b)
        {
            int[] outputarr = new int[3];
            BigInteger d0 = a, d1 = b, x0 = 1, x1 = 0, y0 = 0, y1 = 1, q, x2, y2, d2;
            while (d1 > 1)
            {
                q = d0 / d1;
                d2 = d0 % d1;
                x2 = x0 - q * x1;
                y2 = y0 - q * y1;
                d0 = d1;
                d1 = d2;
                x0 = x1;
                x1 = x2;
                y0 = y1;
                y1 = y2;
            }
            if (y1 < 0)
            {
                y1 += a;
            }
            return y1;
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();

            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.Filter = "ALL Files|*.*";
            if (openFile1.ShowDialog() == DialogResult.OK && openFile1.FileName.Length > 0)
            {

                textByte = File.ReadAllBytes(openFile1.FileName);
                textArray = new BigInteger[textByte.Length];
                textArray = textByte.Select(x => (BigInteger)x).ToArray();
                inputTextBox.Text = binaryToString(textByte);

            }
        }

        private string binaryToString(byte[] bytes)
        {
            StringBuilder context = new StringBuilder();
            foreach (byte b in bytes)
                context.Append(Convert.ToString(b) + " ");
            return context.ToString();
        }

        private void getPtextBox_DoubleClick(object sender, EventArgs e)
        {
            getPtextBox.Clear();
        }

        private void getQtextBox_DoubleClick(object sender, EventArgs e)
        {
            getQtextBox.Clear();
        }

        private void getDtextBox_DoubleClick(object sender, EventArgs e)
        {
            getDtextBox.Clear();
        }

        private bool getSignature(BigInteger p, BigInteger q, BigInteger d, string hash)
        {
            BigInteger r, fi, eps, s;
            //BigInteger[] cipher;

            r = p * q;
            fi = (p - 1) * (q - 1);
            eps = EuclidAlg(fi, d);

            if ((r < BigInteger.Pow(2, 160)) || !WorkWithBigInt.IsPrime(p, 4) || !WorkWithBigInt.IsPrime(q, 4) || (BigInteger.GreatestCommonDivisor(d, fi) != 1))
            {
                MessageBox.Show("Error");
                return true;
            }
            else
            {

                getEpstextBox.Text = eps.ToString();
                getRtextBox.Text = r.ToString();

                BigInteger temp = BigInteger.Parse(hash);
                s = BigInteger.ModPow(temp, d, r);
                inputTextBox.Text = s.ToString();

                return false;
            }

        }

        private void signDokument()
        {
            BigInteger q, p, d;
            uint[] arr = Sha_1.getHashWithSHA_1(textByte);
            string hash = "";
            BigInteger hash1;

            p = BigInteger.Parse(getPtextBox.Text);
            q = BigInteger.Parse(getQtextBox.Text);
            d = BigInteger.Parse(getDtextBox.Text);

            hash += Convert.ToString(arr[0], 16) + Convert.ToString(arr[1], 16) + Convert.ToString(arr[2], 16);
            hash += Convert.ToString(arr[3], 16) + Convert.ToString(arr[4], 16);
            hash1 = BigInteger.Parse("0" + hash, System.Globalization.NumberStyles.AllowHexSpecifier);

            sixHashValueTextBox.Text = hash;
            decHashValueTextBox.Text = hash1.ToString();

            if (getSignature(p, q, d, decHashValueTextBox.Text) == false)
            {
                
                StreamWriter textFile = new StreamWriter(@"C:\БГУИР\2 КУРС\ТИ_2017\ЛАБЫ\TI_laba4\signature.txt");

                textFile.WriteLine(inputTextBox.Text);

                textFile.Close();
            }
        }

        private byte[] stringToBinary(string result)
        {
            int j = 0;

            byte[] byteskey = new byte[result.Length / 8];
            for (int i = 0; i < result.Length; i += 8)
            {
                byteskey[j] = Convert.ToByte(result.Substring(i, 8),2);
                j++;
            }
            return byteskey;
        }

        private void getSolutionButton_Click(object sender, EventArgs e)
        {
            label3.Text = "Подпись";

            if ((getQtextBox.Text == "") || (getPtextBox.Text == "") || (getDtextBox.Text == ""))
            {
                MessageBox.Show(" Error ");
                return;
            }
            else
            {
                signDokument();
            }

        }

        private string checkSignedDocument()
        {
            BigInteger eps, r;
            string newhash = "";
            BigInteger signature, hash;
            uint[] arr = Sha_1.getHashWithSHA_1(textByte);
            newhash += Convert.ToString(arr[0],16) + Convert.ToString(arr[1],16) + Convert.ToString(arr[2],16);
            newhash += Convert.ToString(arr[3],16) + Convert.ToString(arr[4],16);

            hash = BigInteger.Parse("0" + newhash, System.Globalization.NumberStyles.AllowHexSpecifier);

            decHashValueTextBox.Text = hash.ToString();
            sixHashValueTextBox.Text = newhash;

            eps = BigInteger.Parse(getEpstextBox.Text);
            r = BigInteger.Parse(getRtextBox.Text);

            StreamReader textFile = new StreamReader(@"C:\БГУИР\2 КУРС\ТИ_2017\ЛАБЫ\TI_laba4\signature.txt");

            signature = BigInteger.Parse(textFile.ReadLine());

            textFile.Close();

            hash = BigInteger.ModPow(signature, eps, r);

            inputTextBox.Text = hash.ToString();

            return hash.ToString();
        }

        private void checkResultButton_Click(object sender, EventArgs e)
        {
            string decHash;
            label3.Text = "hash полученного документа";

            decHash=checkSignedDocument();
            
            if (decHashValueTextBox.Text==decHash)
            {
                MessageBox.Show("Прошла проверку","Подпись");
            }
            else
            {
                MessageBox.Show("Не прошла проверку","Подпись");
            }

        }

    }
}
