namespace youtube_prac6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.pbxCancel = new System.Windows.Forms.PictureBox();
            this.grpCalculatorInputs = new System.Windows.Forms.GroupBox();
            this.nudBaseFee = new System.Windows.Forms.NumericUpDown();
            this.nudSessionRate = new System.Windows.Forms.NumericUpDown();
            this.nudNumSessions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancel)).BeginInit();
            this.grpCalculatorInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSessionRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(183, 62);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(220, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Gym Fee Calculator";
            // 
            // pbxCancel
            // 
            this.pbxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCancel.Image = global::youtube_prac6.Properties.Resources.icons8_cancel_50;
            this.pbxCancel.Location = new System.Drawing.Point(577, 12);
            this.pbxCancel.Name = "pbxCancel";
            this.pbxCancel.Size = new System.Drawing.Size(54, 19);
            this.pbxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCancel.TabIndex = 1;
            this.pbxCancel.TabStop = false;
            this.pbxCancel.Click += new System.EventHandler(this.pbxCancel_Click);
            // 
            // grpCalculatorInputs
            // 
            this.grpCalculatorInputs.Controls.Add(this.btnCalculate);
            this.grpCalculatorInputs.Controls.Add(this.label3);
            this.grpCalculatorInputs.Controls.Add(this.label2);
            this.grpCalculatorInputs.Controls.Add(this.label1);
            this.grpCalculatorInputs.Controls.Add(this.nudNumSessions);
            this.grpCalculatorInputs.Controls.Add(this.nudSessionRate);
            this.grpCalculatorInputs.Controls.Add(this.nudBaseFee);
            this.grpCalculatorInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCalculatorInputs.Location = new System.Drawing.Point(65, 132);
            this.grpCalculatorInputs.Name = "grpCalculatorInputs";
            this.grpCalculatorInputs.Size = new System.Drawing.Size(467, 235);
            this.grpCalculatorInputs.TabIndex = 2;
            this.grpCalculatorInputs.TabStop = false;
            this.grpCalculatorInputs.Text = "Calculator Inputs";
            // 
            // nudBaseFee
            // 
            this.nudBaseFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudBaseFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudBaseFee.DecimalPlaces = 2;
            this.nudBaseFee.Location = new System.Drawing.Point(265, 41);
            this.nudBaseFee.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudBaseFee.Name = "nudBaseFee";
            this.nudBaseFee.Size = new System.Drawing.Size(120, 22);
            this.nudBaseFee.TabIndex = 0;
            // 
            // nudSessionRate
            // 
            this.nudSessionRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudSessionRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSessionRate.DecimalPlaces = 2;
            this.nudSessionRate.Location = new System.Drawing.Point(265, 83);
            this.nudSessionRate.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudSessionRate.Name = "nudSessionRate";
            this.nudSessionRate.Size = new System.Drawing.Size(120, 22);
            this.nudSessionRate.TabIndex = 1;
            // 
            // nudNumSessions
            // 
            this.nudNumSessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudNumSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNumSessions.Location = new System.Drawing.Point(265, 124);
            this.nudNumSessions.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudNumSessions.Name = "nudNumSessions";
            this.nudNumSessions.Size = new System.Drawing.Size(120, 22);
            this.nudNumSessions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monthly base fee (R) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Training session rate (R):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of sessions:";
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOutput.Enabled = false;
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(65, 373);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(467, 125);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(123, 176);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(201, 35);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(632, 510);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.grpCalculatorInputs);
            this.Controls.Add(this.pbxCancel);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Fee Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancel)).EndInit();
            this.grpCalculatorInputs.ResumeLayout(false);
            this.grpCalculatorInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSessionRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pbxCancel;
        private System.Windows.Forms.GroupBox grpCalculatorInputs;
        private System.Windows.Forms.NumericUpDown nudNumSessions;
        private System.Windows.Forms.NumericUpDown nudSessionRate;
        private System.Windows.Forms.NumericUpDown nudBaseFee;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

