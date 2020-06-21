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
            this.lengthGroupBox.Location = new System.Drawing.Point(12, 10);
            this.lengthGroupBox.Name = "lengthGroupBox";
            this.lengthGroupBox.Size = new System.Drawing.Size(200, 408);
            this.lengthGroupBox.TabIndex = 0;
            this.lengthGroupBox.TabStop = false;
            this.lengthGroupBox.Text = "LENGTH";
            // 
            // lengthConvertBtn
            // 
            this.lengthConvertBtn.Location = new System.Drawing.Point(61, 210);
            this.lengthConvertBtn.Name = "lengthConvertBtn";
            this.lengthConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.lengthConvertBtn.TabIndex = 13;
            this.lengthConvertBtn.Text = "Convert";
            this.lengthConvertBtn.UseVisualStyleBackColor = true;
            // 
            // lengthOutput
            // 
            this.lengthOutput.AutoSize = true;
            this.lengthOutput.Location = new System.Drawing.Point(15, 299);
            this.lengthOutput.Name = "lengthOutput";
            this.lengthOutput.Size = new System.Drawing.Size(172, 17);
            this.lengthOutput.TabIndex = 9;
            this.lengthOutput.Text = "\"the output goes here\"";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lengthTextBox.Location = new System.Drawing.Point(23, 158);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(156, 23);
            this.lengthTextBox.TabIndex = 8;
            this.lengthTextBox.Text = "Enter numbers here";
            // 
            // meterBtn
            // 
            this.meterBtn.AutoSize = true;
            this.meterBtn.Location = new System.Drawing.Point(23, 82);
            this.meterBtn.Name = "meterBtn";
            this.meterBtn.Size = new System.Drawing.Size(79, 21);
            this.meterBtn.TabIndex = 3;
            this.meterBtn.TabStop = true;
            this.meterBtn.Text = "METER";
            this.meterBtn.UseVisualStyleBackColor = true;
            // 
            // footBtn
            // 
            this.footBtn.AutoSize = true;
            this.footBtn.Location = new System.Drawing.Point(23, 52);
            this.footBtn.Name = "footBtn";
            this.footBtn.Size = new System.Drawing.Size(69, 21);
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
            this.weightGroupBox.Location = new System.Drawing.Point(218, 10);
            this.weightGroupBox.Name = "weightGroupBox";
            this.weightGroupBox.Size = new System.Drawing.Size(200, 408);
            this.weightGroupBox.TabIndex = 1;
            this.weightGroupBox.TabStop = false;
            this.weightGroupBox.Text = "WEIGHT";
            // 
            // weightConvertBtn
            // 
            this.weightConvertBtn.Location = new System.Drawing.Point(65, 210);
            this.weightConvertBtn.Name = "weightConvertBtn";
            this.weightConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.weightConvertBtn.TabIndex = 14;
            this.weightConvertBtn.Text = "Convert";
            this.weightConvertBtn.UseVisualStyleBackColor = true;
            // 
            // weightOutput
            // 
            this.weightOutput.AutoSize = true;
            this.weightOutput.Location = new System.Drawing.Point(13, 299);
            this.weightOutput.Name = "weightOutput";
            this.weightOutput.Size = new System.Drawing.Size(172, 17);
            this.weightOutput.TabIndex = 10;
            this.weightOutput.Text = "\"the output goes here\"";
            this.weightOutput.Click += new System.EventHandler(this.weightOutput_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.weightTextBox.Location = new System.Drawing.Point(22, 158);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(158, 23);
            this.weightTextBox.TabIndex = 9;
            this.weightTextBox.Text = "Enter numbers here";
            // 
            // kiloBtn
            // 
            this.kiloBtn.AutoSize = true;
            this.kiloBtn.Location = new System.Drawing.Point(22, 82);
            this.kiloBtn.Name = "kiloBtn";
            this.kiloBtn.Size = new System.Drawing.Size(106, 21);
            this.kiloBtn.TabIndex = 4;
            this.kiloBtn.TabStop = true;
            this.kiloBtn.Text = "KILOGRAM";
            this.kiloBtn.UseVisualStyleBackColor = true;
            // 
            // poundBtn
            // 
            this.poundBtn.AutoSize = true;
            this.poundBtn.Location = new System.Drawing.Point(22, 52);
            this.poundBtn.Name = "poundBtn";
            this.poundBtn.Size = new System.Drawing.Size(81, 21);
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
            this.tempGroupBox.Location = new System.Drawing.Point(424, 10);
            this.tempGroupBox.Name = "tempGroupBox";
            this.tempGroupBox.Size = new System.Drawing.Size(200, 408);
            this.tempGroupBox.TabIndex = 1;
            this.tempGroupBox.TabStop = false;
            this.tempGroupBox.Text = "TEMPERATURE";
            // 
            // tempConvertBtn
            // 
            this.tempConvertBtn.Location = new System.Drawing.Point(62, 210);
            this.tempConvertBtn.Name = "tempConvertBtn";
            this.tempConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.tempConvertBtn.TabIndex = 15;
            this.tempConvertBtn.Text = "Convert";
            this.tempConvertBtn.UseVisualStyleBackColor = true;
            // 
            // tempOutput
            // 
            this.tempOutput.AutoSize = true;
            this.tempOutput.Location = new System.Drawing.Point(14, 299);
            this.tempOutput.Name = "tempOutput";
            this.tempOutput.Size = new System.Drawing.Size(172, 17);
            this.tempOutput.TabIndex = 11;
            this.tempOutput.Text = "\"the output goes here\"";
            this.tempOutput.Click += new System.EventHandler(this.tempOutput_Click);
            // 
            // tempTextBox
            // 
            this.tempTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tempTextBox.Location = new System.Drawing.Point(26, 158);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(157, 23);
            this.tempTextBox.TabIndex = 10;
            this.tempTextBox.Text = "Enter numbers here";
            // 
            // fahrenBtn
            // 
            this.fahrenBtn.AutoSize = true;
            this.fahrenBtn.Location = new System.Drawing.Point(26, 82);
            this.fahrenBtn.Name = "fahrenBtn";
            this.fahrenBtn.Size = new System.Drawing.Size(123, 21);
            this.fahrenBtn.TabIndex = 6;
            this.fahrenBtn.TabStop = true;
            this.fahrenBtn.Text = "FAHRENHEIT";
            this.fahrenBtn.UseVisualStyleBackColor = true;
            // 
            // celsiusBtn
            // 
            this.celsiusBtn.AutoSize = true;
            this.celsiusBtn.Location = new System.Drawing.Point(26, 52);
            this.celsiusBtn.Name = "celsiusBtn";
            this.celsiusBtn.Size = new System.Drawing.Size(90, 21);
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
            this.timeGroupBox.Location = new System.Drawing.Point(630, 10);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Size = new System.Drawing.Size(200, 408);
            this.timeGroupBox.TabIndex = 1;
            this.timeGroupBox.TabStop = false;
            this.timeGroupBox.Text = "TIME";
            // 
            // timeConvertBtn
            // 
            this.timeConvertBtn.Location = new System.Drawing.Point(72, 210);
            this.timeConvertBtn.Name = "timeConvertBtn";
            this.timeConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.timeConvertBtn.TabIndex = 16;
            this.timeConvertBtn.Text = "Convert";
            this.timeConvertBtn.UseVisualStyleBackColor = true;
            // 
            // timeOutput
            // 
            this.timeOutput.AutoSize = true;
            this.timeOutput.Location = new System.Drawing.Point(17, 299);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(172, 17);
            this.timeOutput.TabIndex = 12;
            this.timeOutput.Text = "\"the output goes here\"";
            this.timeOutput.Click += new System.EventHandler(this.timeOutput_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.timeTextBox.Location = new System.Drawing.Point(25, 158);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(159, 23);
            this.timeTextBox.TabIndex = 11;
            this.timeTextBox.Text = "Enter numbers here";
            // 
            // minBtn
            // 
            this.minBtn.AutoSize = true;
            this.minBtn.Location = new System.Drawing.Point(25, 52);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(84, 21);
            this.minBtn.TabIndex = 8;
            this.minBtn.TabStop = true;
            this.minBtn.Text = "MINUTE";
            this.minBtn.UseVisualStyleBackColor = true;
            // 
            // hourBtn
            // 
            this.hourBtn.AutoSize = true;
            this.hourBtn.Location = new System.Drawing.Point(25, 82);
            this.hourBtn.Name = "hourBtn";
            this.hourBtn.Size = new System.Drawing.Size(71, 21);
            this.hourBtn.TabIndex = 9;
            this.hourBtn.TabStop = true;
            this.hourBtn.Text = "HOUR";
            this.hourBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(842, 428);
            this.Controls.Add(this.timeGroupBox);
            this.Controls.Add(this.tempGroupBox);
            this.Controls.Add(this.weightGroupBox);
            this.Controls.Add(this.lengthGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

