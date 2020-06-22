namespace PROG32356_assignment3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lengthGroupBox = new System.Windows.Forms.GroupBox();
            this.lengthConvertBtn = new System.Windows.Forms.Button();
            this.lengthOutput = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.meterBtn = new System.Windows.Forms.RadioButton();
            this.footBtn = new System.Windows.Forms.RadioButton();
            this.weightGroupBox = new System.Windows.Forms.GroupBox();
            this.weightConvertBtn = new System.Windows.Forms.Button();
            this.weightOutput = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.kiloBtn = new System.Windows.Forms.RadioButton();
            this.poundBtn = new System.Windows.Forms.RadioButton();
            this.tempGroupBox = new System.Windows.Forms.GroupBox();
            this.tempConvertBtn = new System.Windows.Forms.Button();
            this.tempOutput = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.fahrenBtn = new System.Windows.Forms.RadioButton();
            this.celsiusBtn = new System.Windows.Forms.RadioButton();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeConvertBtn = new System.Windows.Forms.Button();
            this.timeOutput = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.minBtn = new System.Windows.Forms.RadioButton();
            this.hourBtn = new System.Windows.Forms.RadioButton();
            this.lengthGroupBox.SuspendLayout();
            this.weightGroupBox.SuspendLayout();
            this.tempGroupBox.SuspendLayout();
            this.timeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lengthGroupBox
            // 
            this.lengthGroupBox.BackColor = System.Drawing.Color.MistyRose;
            this.lengthGroupBox.Controls.Add(this.lengthConvertBtn);
            this.lengthGroupBox.Controls.Add(this.lengthOutput);
            this.lengthGroupBox.Controls.Add(this.lengthTextBox);
            this.lengthGroupBox.Controls.Add(this.meterBtn);
            this.lengthGroupBox.Controls.Add(this.footBtn);
            this.lengthGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthGroupBox.Location = new System.Drawing.Point(16, 12);
            this.lengthGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.lengthGroupBox.Name = "lengthGroupBox";
            this.lengthGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.lengthGroupBox.Size = new System.Drawing.Size(267, 502);
            this.lengthGroupBox.TabIndex = 0;
            this.lengthGroupBox.TabStop = false;
            this.lengthGroupBox.Text = "LENGTH";
            // 
            // lengthConvertBtn
            // 
            this.lengthConvertBtn.Location = new System.Drawing.Point(81, 258);
            this.lengthConvertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.lengthConvertBtn.Name = "lengthConvertBtn";
            this.lengthConvertBtn.Size = new System.Drawing.Size(100, 28);
            this.lengthConvertBtn.TabIndex = 13;
            this.lengthConvertBtn.Text = "Convert";
            this.lengthConvertBtn.UseVisualStyleBackColor = true;
            this.lengthConvertBtn.Click += new System.EventHandler(this.LengthConvertBtn_Click);
            // 
            // lengthOutput
            // 
            this.lengthOutput.AutoSize = true;
            this.lengthOutput.Location = new System.Drawing.Point(27, 368);
            this.lengthOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthOutput.Name = "lengthOutput";
            this.lengthOutput.Size = new System.Drawing.Size(57, 20);
            this.lengthOutput.TabIndex = 9;
            this.lengthOutput.Text = "result";
            this.lengthOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lengthTextBox.Location = new System.Drawing.Point(31, 194);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lengthTextBox.MaxLength = 10;
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(207, 26);
            this.lengthTextBox.TabIndex = 8;
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // meterBtn
            // 
            this.meterBtn.AutoSize = true;
            this.meterBtn.Location = new System.Drawing.Point(31, 101);
            this.meterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.meterBtn.Name = "meterBtn";
            this.meterBtn.Size = new System.Drawing.Size(93, 24);
            this.meterBtn.TabIndex = 3;
            this.meterBtn.TabStop = true;
            this.meterBtn.Text = "METER";
            this.meterBtn.UseVisualStyleBackColor = true;
            // 
            // footBtn
            // 
            this.footBtn.AutoSize = true;
            this.footBtn.Location = new System.Drawing.Point(31, 64);
            this.footBtn.Margin = new System.Windows.Forms.Padding(4);
            this.footBtn.Name = "footBtn";
            this.footBtn.Size = new System.Drawing.Size(80, 24);
            this.footBtn.TabIndex = 2;
            this.footBtn.TabStop = true;
            this.footBtn.Text = "FOOT";
            this.footBtn.UseVisualStyleBackColor = true;
            // 
            // weightGroupBox
            // 
            this.weightGroupBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.weightGroupBox.Controls.Add(this.weightConvertBtn);
            this.weightGroupBox.Controls.Add(this.weightOutput);
            this.weightGroupBox.Controls.Add(this.weightTextBox);
            this.weightGroupBox.Controls.Add(this.kiloBtn);
            this.weightGroupBox.Controls.Add(this.poundBtn);
            this.weightGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightGroupBox.Location = new System.Drawing.Point(291, 12);
            this.weightGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.weightGroupBox.Name = "weightGroupBox";
            this.weightGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.weightGroupBox.Size = new System.Drawing.Size(267, 502);
            this.weightGroupBox.TabIndex = 1;
            this.weightGroupBox.TabStop = false;
            this.weightGroupBox.Text = "WEIGHT";
            // 
            // weightConvertBtn
            // 
            this.weightConvertBtn.Location = new System.Drawing.Point(87, 258);
            this.weightConvertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.weightConvertBtn.Name = "weightConvertBtn";
            this.weightConvertBtn.Size = new System.Drawing.Size(100, 28);
            this.weightConvertBtn.TabIndex = 14;
            this.weightConvertBtn.Text = "Convert";
            this.weightConvertBtn.UseVisualStyleBackColor = true;
            this.weightConvertBtn.Click += new System.EventHandler(this.WeightConvertBtn_Click);
            // 
            // weightOutput
            // 
            this.weightOutput.AutoSize = true;
            this.weightOutput.Location = new System.Drawing.Point(25, 368);
            this.weightOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightOutput.Name = "weightOutput";
            this.weightOutput.Size = new System.Drawing.Size(57, 20);
            this.weightOutput.TabIndex = 10;
            this.weightOutput.Text = "result";
            // 
            // weightTextBox
            // 
            this.weightTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.weightTextBox.Location = new System.Drawing.Point(29, 194);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.weightTextBox.MaxLength = 10;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(209, 26);
            this.weightTextBox.TabIndex = 9;
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kiloBtn
            // 
            this.kiloBtn.AutoSize = true;
            this.kiloBtn.Location = new System.Drawing.Point(29, 101);
            this.kiloBtn.Margin = new System.Windows.Forms.Padding(4);
            this.kiloBtn.Name = "kiloBtn";
            this.kiloBtn.Size = new System.Drawing.Size(126, 24);
            this.kiloBtn.TabIndex = 4;
            this.kiloBtn.TabStop = true;
            this.kiloBtn.Text = "KILOGRAM";
            this.kiloBtn.UseVisualStyleBackColor = true;
            // 
            // poundBtn
            // 
            this.poundBtn.AutoSize = true;
            this.poundBtn.Location = new System.Drawing.Point(29, 64);
            this.poundBtn.Margin = new System.Windows.Forms.Padding(4);
            this.poundBtn.Name = "poundBtn";
            this.poundBtn.Size = new System.Drawing.Size(96, 24);
            this.poundBtn.TabIndex = 5;
            this.poundBtn.TabStop = true;
            this.poundBtn.Text = "POUND";
            this.poundBtn.UseVisualStyleBackColor = true;
            // 
            // tempGroupBox
            // 
            this.tempGroupBox.BackColor = System.Drawing.Color.LightCyan;
            this.tempGroupBox.Controls.Add(this.tempConvertBtn);
            this.tempGroupBox.Controls.Add(this.tempOutput);
            this.tempGroupBox.Controls.Add(this.tempTextBox);
            this.tempGroupBox.Controls.Add(this.fahrenBtn);
            this.tempGroupBox.Controls.Add(this.celsiusBtn);
            this.tempGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempGroupBox.Location = new System.Drawing.Point(565, 12);
            this.tempGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.tempGroupBox.Name = "tempGroupBox";
            this.tempGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.tempGroupBox.Size = new System.Drawing.Size(267, 502);
            this.tempGroupBox.TabIndex = 1;
            this.tempGroupBox.TabStop = false;
            this.tempGroupBox.Text = "TEMPERATURE";
            // 
            // tempConvertBtn
            // 
            this.tempConvertBtn.Location = new System.Drawing.Point(83, 258);
            this.tempConvertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.tempConvertBtn.Name = "tempConvertBtn";
            this.tempConvertBtn.Size = new System.Drawing.Size(100, 28);
            this.tempConvertBtn.TabIndex = 15;
            this.tempConvertBtn.Text = "Convert";
            this.tempConvertBtn.UseVisualStyleBackColor = true;
            this.tempConvertBtn.Click += new System.EventHandler(this.TempConvertBtn_Click);
            // 
            // tempOutput
            // 
            this.tempOutput.AutoSize = true;
            this.tempOutput.Location = new System.Drawing.Point(31, 368);
            this.tempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempOutput.Name = "tempOutput";
            this.tempOutput.Size = new System.Drawing.Size(57, 20);
            this.tempOutput.TabIndex = 11;
            this.tempOutput.Text = "result";
            this.tempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tempTextBox
            // 
            this.tempTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tempTextBox.Location = new System.Drawing.Point(35, 194);
            this.tempTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tempTextBox.MaxLength = 10;
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(208, 26);
            this.tempTextBox.TabIndex = 10;
            this.tempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fahrenBtn
            // 
            this.fahrenBtn.AutoSize = true;
            this.fahrenBtn.Location = new System.Drawing.Point(35, 101);
            this.fahrenBtn.Margin = new System.Windows.Forms.Padding(4);
            this.fahrenBtn.Name = "fahrenBtn";
            this.fahrenBtn.Size = new System.Drawing.Size(147, 24);
            this.fahrenBtn.TabIndex = 6;
            this.fahrenBtn.TabStop = true;
            this.fahrenBtn.Text = "FAHRENHEIT";
            this.fahrenBtn.UseVisualStyleBackColor = true;
            // 
            // celsiusBtn
            // 
            this.celsiusBtn.AutoSize = true;
            this.celsiusBtn.Location = new System.Drawing.Point(35, 64);
            this.celsiusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.celsiusBtn.Name = "celsiusBtn";
            this.celsiusBtn.Size = new System.Drawing.Size(108, 24);
            this.celsiusBtn.TabIndex = 7;
            this.celsiusBtn.TabStop = true;
            this.celsiusBtn.Text = "CELSIUS";
            this.celsiusBtn.UseVisualStyleBackColor = true;
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.BackColor = System.Drawing.Color.Honeydew;
            this.timeGroupBox.Controls.Add(this.timeConvertBtn);
            this.timeGroupBox.Controls.Add(this.timeOutput);
            this.timeGroupBox.Controls.Add(this.timeTextBox);
            this.timeGroupBox.Controls.Add(this.minBtn);
            this.timeGroupBox.Controls.Add(this.hourBtn);
            this.timeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeGroupBox.Location = new System.Drawing.Point(840, 12);
            this.timeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.timeGroupBox.Size = new System.Drawing.Size(267, 502);
            this.timeGroupBox.TabIndex = 1;
            this.timeGroupBox.TabStop = false;
            this.timeGroupBox.Text = "TIME";
            // 
            // timeConvertBtn
            // 
            this.timeConvertBtn.Location = new System.Drawing.Point(96, 258);
            this.timeConvertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.timeConvertBtn.Name = "timeConvertBtn";
            this.timeConvertBtn.Size = new System.Drawing.Size(100, 28);
            this.timeConvertBtn.TabIndex = 16;
            this.timeConvertBtn.Text = "Convert";
            this.timeConvertBtn.UseVisualStyleBackColor = true;
            this.timeConvertBtn.Click += new System.EventHandler(this.TimeConvertBtn_Click);
            // 
            // timeOutput
            // 
            this.timeOutput.AutoSize = true;
            this.timeOutput.Location = new System.Drawing.Point(29, 368);
            this.timeOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(57, 20);
            this.timeOutput.TabIndex = 12;
            this.timeOutput.Text = "result";
            this.timeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeTextBox
            // 
            this.timeTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.timeTextBox.Location = new System.Drawing.Point(33, 194);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeTextBox.MaxLength = 10;
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(211, 26);
            this.timeTextBox.TabIndex = 11;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minBtn
            // 
            this.minBtn.AutoSize = true;
            this.minBtn.Location = new System.Drawing.Point(33, 64);
            this.minBtn.Margin = new System.Windows.Forms.Padding(4);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(99, 24);
            this.minBtn.TabIndex = 8;
            this.minBtn.TabStop = true;
            this.minBtn.Text = "MINUTE";
            this.minBtn.UseVisualStyleBackColor = true;
            // 
            // hourBtn
            // 
            this.hourBtn.AutoSize = true;
            this.hourBtn.Location = new System.Drawing.Point(33, 101);
            this.hourBtn.Margin = new System.Windows.Forms.Padding(4);
            this.hourBtn.Name = "hourBtn";
            this.hourBtn.Size = new System.Drawing.Size(84, 24);
            this.hourBtn.TabIndex = 9;
            this.hourBtn.TabStop = true;
            this.hourBtn.Text = "HOUR";
            this.hourBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1123, 527);
            this.Controls.Add(this.timeGroupBox);
            this.Controls.Add(this.tempGroupBox);
            this.Controls.Add(this.weightGroupBox);
            this.Controls.Add(this.lengthGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " Converter";
            this.lengthGroupBox.ResumeLayout(false);
            this.lengthGroupBox.PerformLayout();
            this.weightGroupBox.ResumeLayout(false);
            this.weightGroupBox.PerformLayout();
            this.tempGroupBox.ResumeLayout(false);
            this.tempGroupBox.PerformLayout();
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lengthGroupBox;
        private System.Windows.Forms.GroupBox weightGroupBox;
        private System.Windows.Forms.GroupBox tempGroupBox;
        private System.Windows.Forms.GroupBox timeGroupBox;
        private System.Windows.Forms.Label lengthOutput;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.RadioButton meterBtn;
        private System.Windows.Forms.RadioButton footBtn;
        private System.Windows.Forms.Label weightOutput;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.RadioButton kiloBtn;
        private System.Windows.Forms.RadioButton poundBtn;
        private System.Windows.Forms.Label tempOutput;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.RadioButton fahrenBtn;
        private System.Windows.Forms.RadioButton celsiusBtn;
        private System.Windows.Forms.Label timeOutput;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.RadioButton minBtn;
        private System.Windows.Forms.RadioButton hourBtn;
        private System.Windows.Forms.Button lengthConvertBtn;
        private System.Windows.Forms.Button weightConvertBtn;
        private System.Windows.Forms.Button tempConvertBtn;
        private System.Windows.Forms.Button timeConvertBtn;
    }
}

