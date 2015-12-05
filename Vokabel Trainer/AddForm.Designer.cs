using System.Windows.Forms;
namespace Vokabel_Trainer
{
    partial class AddForm
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
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.tbAddGerman = new System.Windows.Forms.TextBox();
            this.btnAddVocab = new System.Windows.Forms.Button();
            this.lblAddGerman = new System.Windows.Forms.Label();
            this.tbAddEnglish = new System.Windows.Forms.TextBox();
            this.lblAddEnglish = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            this.FormClosing += new FormClosingEventHandler(AddForm_Closing);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.tbAddGerman);
            this.grpAdd.Controls.Add(this.btnAddVocab);
            this.grpAdd.Controls.Add(this.lblAddGerman);
            this.grpAdd.Controls.Add(this.tbAddEnglish);
            this.grpAdd.Controls.Add(this.lblAddEnglish);
            this.grpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdd.Location = new System.Drawing.Point(10, 11);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(720, 199);
            this.grpAdd.TabIndex = 0;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Vokabel hinzufügen";
            // 
            // tbAddGerman
            // 
            this.tbAddGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddGerman.Location = new System.Drawing.Point(298, 79);
            this.tbAddGerman.Name = "tbAddGerman";
            this.tbAddGerman.Size = new System.Drawing.Size(213, 26);
            this.tbAddGerman.TabIndex = 2;
            // 
            // btnAddVocab
            // 
            this.btnAddVocab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVocab.Location = new System.Drawing.Point(582, 62);
            this.btnAddVocab.Name = "btnAddVocab";
            this.btnAddVocab.Size = new System.Drawing.Size(120, 60);
            this.btnAddVocab.TabIndex = 3;
            this.btnAddVocab.Text = "Vokabel hinzufügen";
            this.btnAddVocab.UseVisualStyleBackColor = true;
            this.btnAddVocab.Click += new System.EventHandler(this.btnAddVocab_Click);
            // 
            // lblAddGerman
            // 
            this.lblAddGerman.AutoSize = true;
            this.lblAddGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGerman.Location = new System.Drawing.Point(294, 56);
            this.lblAddGerman.Name = "lblAddGerman";
            this.lblAddGerman.Size = new System.Drawing.Size(73, 20);
            this.lblAddGerman.TabIndex = 9;
            this.lblAddGerman.Text = "Deutsch:";
            // 
            // tbAddEnglish
            // 
            this.tbAddEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddEnglish.Location = new System.Drawing.Point(44, 79);
            this.tbAddEnglish.Name = "tbAddEnglish";
            this.tbAddEnglish.Size = new System.Drawing.Size(218, 26);
            this.tbAddEnglish.TabIndex = 1;
            // 
            // lblAddEnglish
            // 
            this.lblAddEnglish.AutoSize = true;
            this.lblAddEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEnglish.Location = new System.Drawing.Point(41, 56);
            this.lblAddEnglish.Name = "lblAddEnglish";
            this.lblAddEnglish.Size = new System.Drawing.Size(73, 20);
            this.lblAddEnglish.TabIndex = 8;
            this.lblAddEnglish.Text = "Englisch:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(315, 236);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 60);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInfo.Location = new System.Drawing.Point(592, 236);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(120, 60);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Tipps zur richtigen Vokabeleingabe";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 314);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpAdd);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddForm";
            this.Text = "Hinzufügen";
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.TextBox tbAddGerman;
        private System.Windows.Forms.Button btnAddVocab;
        private System.Windows.Forms.Label lblAddGerman;
        private System.Windows.Forms.TextBox tbAddEnglish;
        private System.Windows.Forms.Label lblAddEnglish;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInfo;
    }
}