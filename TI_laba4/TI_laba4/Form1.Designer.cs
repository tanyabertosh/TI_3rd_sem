namespace TI_laba4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.decHashValueTextBox = new System.Windows.Forms.RichTextBox();
            this.getPtextBox = new System.Windows.Forms.TextBox();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.getQtextBox = new System.Windows.Forms.TextBox();
            this.getEpstextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.getSolutionButton = new System.Windows.Forms.Button();
            this.sixHashValueTextBox = new System.Windows.Forms.RichTextBox();
            this.checkResultButton = new System.Windows.Forms.Button();
            this.getDtextBox = new System.Windows.Forms.TextBox();
            this.getRtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(54, 265);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(385, 208);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "";
            // 
            // decHashValueTextBox
            // 
            this.decHashValueTextBox.Location = new System.Drawing.Point(54, 51);
            this.decHashValueTextBox.Name = "decHashValueTextBox";
            this.decHashValueTextBox.Size = new System.Drawing.Size(385, 66);
            this.decHashValueTextBox.TabIndex = 1;
            this.decHashValueTextBox.Text = "";
            // 
            // getPtextBox
            // 
            this.getPtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getPtextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.getPtextBox.Location = new System.Drawing.Point(631, 141);
            this.getPtextBox.Name = "getPtextBox";
            this.getPtextBox.Size = new System.Drawing.Size(304, 34);
            this.getPtextBox.TabIndex = 2;
            this.getPtextBox.Text = "Введите p";
            this.getPtextBox.DoubleClick += new System.EventHandler(this.getPtextBox_DoubleClick);
            // 
            // loadFileButton
            // 
            this.loadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFileButton.Location = new System.Drawing.Point(697, 51);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(238, 46);
            this.loadFileButton.TabIndex = 3;
            this.loadFileButton.Text = "Загрузить файл";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // getQtextBox
            // 
            this.getQtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getQtextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.getQtextBox.Location = new System.Drawing.Point(631, 181);
            this.getQtextBox.Name = "getQtextBox";
            this.getQtextBox.Size = new System.Drawing.Size(304, 34);
            this.getQtextBox.TabIndex = 4;
            this.getQtextBox.Text = "Введите q";
            this.getQtextBox.DoubleClick += new System.EventHandler(this.getQtextBox_DoubleClick);
            // 
            // getEpstextBox
            // 
            this.getEpstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getEpstextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.getEpstextBox.Location = new System.Drawing.Point(631, 261);
            this.getEpstextBox.Name = "getEpstextBox";
            this.getEpstextBox.Size = new System.Drawing.Size(304, 34);
            this.getEpstextBox.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // getSolutionButton
            // 
            this.getSolutionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getSolutionButton.Location = new System.Drawing.Point(697, 427);
            this.getSolutionButton.Name = "getSolutionButton";
            this.getSolutionButton.Size = new System.Drawing.Size(238, 46);
            this.getSolutionButton.TabIndex = 6;
            this.getSolutionButton.Text = "Вычислить";
            this.getSolutionButton.UseVisualStyleBackColor = true;
            this.getSolutionButton.Click += new System.EventHandler(this.getSolutionButton_Click);
            // 
            // sixHashValueTextBox
            // 
            this.sixHashValueTextBox.Location = new System.Drawing.Point(54, 141);
            this.sixHashValueTextBox.Name = "sixHashValueTextBox";
            this.sixHashValueTextBox.Size = new System.Drawing.Size(385, 66);
            this.sixHashValueTextBox.TabIndex = 7;
            this.sixHashValueTextBox.Text = "";
            // 
            // checkResultButton
            // 
            this.checkResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkResultButton.Location = new System.Drawing.Point(697, 366);
            this.checkResultButton.Name = "checkResultButton";
            this.checkResultButton.Size = new System.Drawing.Size(238, 46);
            this.checkResultButton.TabIndex = 8;
            this.checkResultButton.Text = "Проверить";
            this.checkResultButton.UseVisualStyleBackColor = true;
            this.checkResultButton.Click += new System.EventHandler(this.checkResultButton_Click);
            // 
            // getDtextBox
            // 
            this.getDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getDtextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.getDtextBox.Location = new System.Drawing.Point(631, 221);
            this.getDtextBox.Name = "getDtextBox";
            this.getDtextBox.Size = new System.Drawing.Size(304, 34);
            this.getDtextBox.TabIndex = 9;
            this.getDtextBox.Text = "Введите d";
            this.getDtextBox.DoubleClick += new System.EventHandler(this.getDtextBox_DoubleClick);
            // 
            // getRtextBox
            // 
            this.getRtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getRtextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.getRtextBox.Location = new System.Drawing.Point(631, 302);
            this.getRtextBox.Name = "getRtextBox";
            this.getRtextBox.Size = new System.Drawing.Size(304, 34);
            this.getRtextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(579, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(579, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Подпись";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "hash";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TI_laba4.Properties.Resources.soft_color_flower;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 552);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getRtextBox);
            this.Controls.Add(this.getDtextBox);
            this.Controls.Add(this.checkResultButton);
            this.Controls.Add(this.sixHashValueTextBox);
            this.Controls.Add(this.getSolutionButton);
            this.Controls.Add(this.getEpstextBox);
            this.Controls.Add(this.getQtextBox);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.getPtextBox);
            this.Controls.Add(this.decHashValueTextBox);
            this.Controls.Add(this.inputTextBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox decHashValueTextBox;
        private System.Windows.Forms.TextBox getPtextBox;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.TextBox getQtextBox;
        private System.Windows.Forms.TextBox getEpstextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button getSolutionButton;
        private System.Windows.Forms.RichTextBox sixHashValueTextBox;
        private System.Windows.Forms.Button checkResultButton;
        private System.Windows.Forms.TextBox getDtextBox;
        private System.Windows.Forms.TextBox getRtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

