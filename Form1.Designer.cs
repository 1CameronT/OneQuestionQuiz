namespace OneQuestionQuiz
{
    partial class frmOneQuestionQuiz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdbDC = new System.Windows.Forms.RadioButton();
            this.rdbMarvel = new System.Windows.Forms.RadioButton();
            this.grbRadioButtons = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.grbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(25, 10);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(164, 13);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "What do I like more DC or Marvel";
            // 
            // rdbDC
            // 
            this.rdbDC.AutoSize = true;
            this.rdbDC.Location = new System.Drawing.Point(19, 21);
            this.rdbDC.Name = "rdbDC";
            this.rdbDC.Size = new System.Drawing.Size(40, 17);
            this.rdbDC.TabIndex = 8;
            this.rdbDC.TabStop = true;
            this.rdbDC.Text = "DC";
            this.rdbDC.UseVisualStyleBackColor = true;
            this.rdbDC.CheckedChanged += new System.EventHandler(this.rdbyes_CheckedChanged);
            // 
            // rdbMarvel
            // 
            this.rdbMarvel.AutoSize = true;
            this.rdbMarvel.Location = new System.Drawing.Point(19, 82);
            this.rdbMarvel.Name = "rdbMarvel";
            this.rdbMarvel.Size = new System.Drawing.Size(57, 17);
            this.rdbMarvel.TabIndex = 9;
            this.rdbMarvel.TabStop = true;
            this.rdbMarvel.Text = "Marvel";
            this.rdbMarvel.UseVisualStyleBackColor = true;
            this.rdbMarvel.CheckedChanged += new System.EventHandler(this.rdbno_CheckedChanged);
            // 
            // grbRadioButtons
            // 
            this.grbRadioButtons.Controls.Add(this.rdbMarvel);
            this.grbRadioButtons.Controls.Add(this.rdbDC);
            this.grbRadioButtons.Location = new System.Drawing.Point(21, 46);
            this.grbRadioButtons.Name = "grbRadioButtons";
            this.grbRadioButtons.Size = new System.Drawing.Size(235, 154);
            this.grbRadioButtons.TabIndex = 10;
            this.grbRadioButtons.TabStop = false;
            this.grbRadioButtons.Enter += new System.EventHandler(this.groupBox1_Enter_2);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(45, 203);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 10;
            // 
            // frmOneQuestionQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grbRadioButtons);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Name = "frmOneQuestionQuiz";
            this.Text = "One Question Quiz";
            this.grbRadioButtons.ResumeLayout(false);
            this.grbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdbDC;
        private System.Windows.Forms.RadioButton rdbMarvel;
        private System.Windows.Forms.GroupBox grbRadioButtons;
        private System.Windows.Forms.Label lblResult;
    }
}

