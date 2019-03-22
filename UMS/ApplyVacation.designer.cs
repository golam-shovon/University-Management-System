namespace UMS
{
    partial class ApplyVacation
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.buttonApplyVacation = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many days do you want to apply vacation for ?";
            // 
            // numericUpDownDays
            // 
            this.numericUpDownDays.Location = new System.Drawing.Point(264, 166);
            this.numericUpDownDays.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownDays.Name = "numericUpDownDays";
            this.numericUpDownDays.Size = new System.Drawing.Size(172, 20);
            this.numericUpDownDays.TabIndex = 1;
            // 
            // buttonApplyVacation
            // 
            this.buttonApplyVacation.Location = new System.Drawing.Point(264, 214);
            this.buttonApplyVacation.Name = "buttonApplyVacation";
            this.buttonApplyVacation.Size = new System.Drawing.Size(172, 23);
            this.buttonApplyVacation.TabIndex = 2;
            this.buttonApplyVacation.Text = "Apply Vacation";
            this.buttonApplyVacation.UseVisualStyleBackColor = true;
            this.buttonApplyVacation.Click += new System.EventHandler(this.buttonApplyVacation_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(573, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "label2";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(116, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(576, 52);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(116, 23);
            this.buttonLogOut.TabIndex = 5;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // ApplyVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonApplyVacation);
            this.Controls.Add(this.numericUpDownDays);
            this.Controls.Add(this.label1);
            this.Name = "ApplyVacation";
            this.Text = "ApplyVacation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDays;
        private System.Windows.Forms.Button buttonApplyVacation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogOut;
    }
}