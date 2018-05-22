using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TI_laba4
{
    class Sha_1
    {

        private static uint Shl(uint a, int n)
        {
            return (a << n) | (a >> 32 - n);
        }

        public static uint[] getHashWithSHA_1(byte[] bytearr)
        {

            uint[] arr = { 0x67452301, 0xEFCDAB89, 0x98BADCFE, 0x10325476, 0xC3D2E1F0 };
            uint a, b, c, d, e, temp;
            uint f = 0; uint k = 0;
            int j = 0;
            
            byte[] useIt = new byte[4];
            byte[] sourceArr = bytearr;
            byte[] getLength = new byte[8];

            if ((bytearr.Length % 64 == 0)&& bytearr.Length!=0)
            {
                Array.Resize(ref bytearr, bytearr.Length + 64);
                getLength = BitConverter.GetBytes((ulong)sourceArr.Length * 8);
                Array.Reverse(getLength);
                //Array.Resize(ref bytearr, bytearr.Length + 8);
                Array.ConstrainedCopy(getLength, 0, bytearr, bytearr.Length - 8, getLength.Length);

            }

            if ((bytearr.Length % 56 == 0)&& bytearr.Length != 0)
            {
                getLength = BitConverter.GetBytes((ulong)sourceArr.Length * 8);
                Array.Reverse(getLength);
                Array.Resize(ref bytearr, bytearr.Length + 8);
                Array.ConstrainedCopy(getLength, 0, bytearr, bytearr.Length - 8, getLength.Length);
            }


            if ((bytearr.Length % 64 != 0)|| bytearr.Length == 0)
            {
                //увеличили на 1
                Array.Resize(ref bytearr, bytearr.Length + 1);
                //заполнили последний элемент
                bytearr[bytearr.Length - 1] = 0x80;
                while (bytearr.Length % 64 != 0)
                {
                    //увеличили на 1
                    Array.Resize(ref bytearr, bytearr.Length + 1);
                    //заполнили последний элемент
                    bytearr[bytearr.Length - 1] = 0;
                    if (bytearr.Length % 56 == 0)
                    {
                        getLength = BitConverter.GetBytes((ulong)sourceArr.Length*8);
                        Array.Reverse(getLength);
                        Array.Resize(ref bytearr, bytearr.Length + 8);
                        Array.ConstrainedCopy(getLength, 0, bytearr, bytearr.Length - 8, getLength.Length);
                    }
                }
            }

            uint[] new_arr = new uint[80];

            for (int ind = 0; ind < bytearr.Length; ind += 64)
            {
                for (int i = 0; i < 16; i++)
                {
                    useIt[0] = bytearr[j]; useIt[1] = bytearr[j + 1];
                    useIt[2] = bytearr[j + 2]; useIt[3] = bytearr[j + 3];
                    Array.Reverse(useIt);
                    
                    new_arr[i] = BitConverter.ToUInt32(useIt, 0);
                    j += 4;
                }

                for (int i = 16; i < 80; i++)
                {
                    new_arr[i] = Shl((new_arr[i - 3] ^ new_arr[i - 8] ^ new_arr[i - 14] ^ new_arr[i - 16]),1);
                    
                }

                a = arr[0]; b = arr[1]; c = arr[2]; d = arr[3]; e = arr[4];

                for (int i = 0; i < 80; i++)
                {
                    if (i < 20)
                    {
                        f = (b & c) | ((~(b)) & d);
                        k = 0x5A827999;
                    }
                    else
                    {
                        if (i < 40)
                        {
                            f = b ^ c ^ d;
                            k = 0x6ED9EBA1;
                        }
                        else
                        {
                            if (i < 60)
                            {
                                f = (b & c) | (b & d) | (c & d);
                                k = 0x8F1BBCDC;
                            }
                            else
                            {
                                if (i < 80)
                                {
                                    f = b ^ c ^ d;
                                    k = 0xCA62C1D6;
                                }
                            }
                        }

                    }

                    temp = Shl(a, 5) + f + e + k + new_arr[i];
                    e = d;
                    d = c;
                    c = Shl(b, 30);
                    b = a;
                    a = temp;

                }

                arr[0] += a;
                arr[1] += b;
                arr[2] += c;
                arr[3] += d;
                arr[4] += e;

            }

            return arr;
        }


    }
}
