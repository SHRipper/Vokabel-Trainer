namespace Vokabel_Trainer
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbCheckEnglish = new System.Windows.Forms.TextBox();
            this.tbCheckGerman = new System.Windows.Forms.TextBox();
            this.btnCheckVocab = new System.Windows.Forms.Button();
            this.lblWordEnglish = new System.Windows.Forms.Label();
            this.lblWordGerman = new System.Windows.Forms.Label();
            this.grpCheck = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnShowVocab = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.englischDeutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschEnglischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vokabelnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vokabelnBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpCheck.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCheckEnglish
            // 
            this.tbCheckEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheckEnglish.Location = new System.Drawing.Point(44, 76);
            this.tbCheckEnglish.Name = "tbCheckEnglish";
            this.tbCheckEnglish.Size = new System.Drawing.Size(218, 26);
            this.tbCheckEnglish.TabIndex = 0;
            // 
            // tbCheckGerman
            // 
            this.tbCheckGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheckGerman.Location = new System.Drawing.Point(298, 76);
            this.tbCheckGerman.Name = "tbCheckGerman";
            this.tbCheckGerman.Size = new System.Drawing.Size(213, 26);
            this.tbCheckGerman.TabIndex = 1;
            this.tbCheckGerman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheckGerman_KeyDown);
            // 
            // btnCheckVocab
            // 
            this.btnCheckVocab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckVocab.Location = new System.Drawing.Point(582, 13);
            this.btnCheckVocab.Name = "btnCheckVocab";
            this.btnCheckVocab.Size = new System.Drawing.Size(120, 60);
            this.btnCheckVocab.TabIndex = 2;
            this.btnCheckVocab.Text = "Überprüfen";
            this.btnCheckVocab.UseVisualStyleBackColor = true;
            this.btnCheckVocab.Click += new System.EventHandler(this.btnCheckVocab_Click);
            // 
            // lblWordEnglish
            // 
            this.lblWordEnglish.AutoSize = true;
            this.lblWordEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordEnglish.Location = new System.Drawing.Point(41, 53);
            this.lblWordEnglish.Name = "lblWordEnglish";
            this.lblWordEnglish.Size = new System.Drawing.Size(73, 20);
            this.lblWordEnglish.TabIndex = 4;
            this.lblWordEnglish.Text = "Englisch:";
            // 
            // lblWordGerman
            // 
            this.lblWordGerman.AutoSize = true;
            this.lblWordGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordGerman.Location = new System.Drawing.Point(295, 53);
            this.lblWordGerman.Name = "lblWordGerman";
            this.lblWordGerman.Size = new System.Drawing.Size(73, 20);
            this.lblWordGerman.TabIndex = 5;
            this.lblWordGerman.Text = "Deutsch:";
            // 
            // grpCheck
            // 
            this.grpCheck.Controls.Add(this.lblResult);
            this.grpCheck.Controls.Add(this.btnShowVocab);
            this.grpCheck.Controls.Add(this.button1);
            this.grpCheck.Controls.Add(this.tbCheckGerman);
            this.grpCheck.Controls.Add(this.lblWordGerman);
            this.grpCheck.Controls.Add(this.btnCheckVocab);
            this.grpCheck.Controls.Add(this.tbCheckEnglish);
            this.grpCheck.Controls.Add(this.lblWordEnglish);
            this.grpCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCheck.Location = new System.Drawing.Point(6, 93);
            this.grpCheck.Name = "grpCheck";
            this.grpCheck.Size = new System.Drawing.Size(720, 175);
            this.grpCheck.TabIndex = 10;
            this.grpCheck.TabStop = false;
            this.grpCheck.Text = "Vokabeln lernen";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(41, 129);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 8;
            // 
            // btnShowVocab
            // 
            this.btnShowVocab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowVocab.Location = new System.Drawing.Point(582, 109);
            this.btnShowVocab.Name = "btnShowVocab";
            this.btnShowVocab.Size = new System.Drawing.Size(120, 60);
            this.btnShowVocab.TabIndex = 3;
            this.btnShowVocab.Text = "Lösung anzeigen";
            this.btnShowVocab.UseVisualStyleBackColor = true;
            this.btnShowVocab.Click += new System.EventHandler(this.btnShowVocab_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, -26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Überprüfen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 42);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Übung starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.statistikenToolStripMenuItem,
            this.vokabelnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englischDeutschToolStripMenuItem,
            this.deutschEnglischToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 20);
            this.toolStripMenuItem1.Text = "Übungsmodus";
            // 
            // englischDeutschToolStripMenuItem
            // 
            this.englischDeutschToolStripMenuItem.Name = "englischDeutschToolStripMenuItem";
            this.englischDeutschToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englischDeutschToolStripMenuItem.Text = "Englisch -> Deutsch";
            this.englischDeutschToolStripMenuItem.Click += new System.EventHandler(this.englischDeutschToolStripMenuItem_Click);
            // 
            // deutschEnglischToolStripMenuItem
            // 
            this.deutschEnglischToolStripMenuItem.Name = "deutschEnglischToolStripMenuItem";
            this.deutschEnglischToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deutschEnglischToolStripMenuItem.Text = "Deutsch -> Englisch";
            this.deutschEnglischToolStripMenuItem.Click += new System.EventHandler(this.deutschEnglischToolStripMenuItem_Click);
            // 
            // statistikenToolStripMenuItem
            // 
            this.statistikenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistikAnzeigenToolStripMenuItem});
            this.statistikenToolStripMenuItem.Name = "statistikenToolStripMenuItem";
            this.statistikenToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.statistikenToolStripMenuItem.Text = "Statistiken";
            // 
            // statistikAnzeigenToolStripMenuItem
            // 
            this.statistikAnzeigenToolStripMenuItem.Name = "statistikAnzeigenToolStripMenuItem";
            this.statistikAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.statistikAnzeigenToolStripMenuItem.Text = "Statistik anzeigen";
            this.statistikAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.statistikAnzeigenToolStripMenuItem_Click);
            // 
            // vokabelnToolStripMenuItem
            // 
            this.vokabelnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vokabelnBearbeitenToolStripMenuItem});
            this.vokabelnToolStripMenuItem.Name = "vokabelnToolStripMenuItem";
            this.vokabelnToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.vokabelnToolStripMenuItem.Text = "Vokabeln";
            // 
            // vokabelnBearbeitenToolStripMenuItem
            // 
            this.vokabelnBearbeitenToolStripMenuItem.Name = "vokabelnBearbeitenToolStripMenuItem";
            this.vokabelnBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.vokabelnBearbeitenToolStripMenuItem.Text = "Bearbeiten";
            this.vokabelnBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.vokabelnBearbeitenToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 339);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpCheck);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Vokabel Trainer";
            this.Load += new System.EventHandler(this.frmVocalCheck_Load);
            this.grpCheck.ResumeLayout(false);
            this.grpCheck.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCheckEnglish;
        private System.Windows.Forms.TextBox tbCheckGerman;
        private System.Windows.Forms.Button btnCheckVocab;
        private System.Windows.Forms.Label lblWordEnglish;
        private System.Windows.Forms.Label lblWordGerman;
        private System.Windows.Forms.GroupBox grpCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnShowVocab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem englischDeutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschEnglischToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vokabelnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vokabelnBearbeitenToolStripMenuItem;
    }
}

