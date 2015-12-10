namespace Vokabel_Trainer
{
    partial class StatisticsForm
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
            this.lblUsedCorrect = new System.Windows.Forms.Label();
            this.lblUsedIncorrect = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsedCorrect
            // 
            this.lblUsedCorrect.AutoSize = true;
            this.lblUsedCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedCorrect.Location = new System.Drawing.Point(41, 49);
            this.lblUsedCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsedCorrect.Name = "lblUsedCorrect";
            this.lblUsedCorrect.Size = new System.Drawing.Size(178, 20);
            this.lblUsedCorrect.TabIndex = 1;
            this.lblUsedCorrect.Text = "Wörter richtig übersetzt:";
            // 
            // lblUsedIncorrect
            // 
            this.lblUsedIncorrect.AutoSize = true;
            this.lblUsedIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedIncorrect.Location = new System.Drawing.Point(41, 110);
            this.lblUsedIncorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsedIncorrect.Name = "lblUsedIncorrect";
            this.lblUsedIncorrect.Size = new System.Drawing.Size(178, 20);
            this.lblUsedIncorrect.TabIndex = 2;
            this.lblUsedIncorrect.Text = "Wörter falsch übersetzt:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(128, 172);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 60);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 268);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUsedIncorrect);
            this.Controls.Add(this.lblUsedCorrect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StatisticsForm";
            this.Text = "Statistiken";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsedCorrect;
        private System.Windows.Forms.Label lblUsedIncorrect;
        private System.Windows.Forms.Button btnBack;
    }
}