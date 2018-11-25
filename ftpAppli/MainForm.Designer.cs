namespace ftpAppli
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seveurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.Serveur = new System.Windows.Forms.TableLayoutPanel();
            this.port = new System.Windows.Forms.Label();
            this.hote = new System.Windows.Forms.Label();
            this.identifiant = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Serveur.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quit,
            this.seveurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Quit
            // 
            this.Quit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(64, 24);
            this.Quit.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.CloseApp);
            // 
            // seveurToolStripMenuItem
            // 
            this.seveurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuShow});
            this.seveurToolStripMenuItem.Name = "seveurToolStripMenuItem";
            this.seveurToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.seveurToolStripMenuItem.Text = "Seveur";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(216, 26);
            this.menuAdd.Text = "Ajouter";
            this.menuAdd.Click += new System.EventHandler(this.AddFTP);
            // 
            // menuShow
            // 
            this.menuShow.Name = "menuShow";
            this.menuShow.Size = new System.Drawing.Size(216, 26);
            this.menuShow.Text = "Consulter";
            this.menuShow.Click += new System.EventHandler(this.ConsulterFTP);
            // 
            // Serveur
            // 
            this.Serveur.ColumnCount = 4;
            this.Serveur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Serveur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Serveur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Serveur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Serveur.Controls.Add(this.port, 0, 0);
            this.Serveur.Controls.Add(this.hote, 1, 0);
            this.Serveur.Controls.Add(this.identifiant, 2, 0);
            this.Serveur.Controls.Add(this.mdp, 3, 0);
            this.Serveur.Location = new System.Drawing.Point(0, 31);
            this.Serveur.Name = "Serveur";
            this.Serveur.RowCount = 1;
            this.Serveur.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Serveur.Size = new System.Drawing.Size(800, 421);
            this.Serveur.TabIndex = 1;
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(3, 0);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(34, 17);
            this.port.TabIndex = 0;
            this.port.Text = "Port";
            // 
            // hote
            // 
            this.hote.AutoSize = true;
            this.hote.Location = new System.Drawing.Point(203, 0);
            this.hote.Name = "hote";
            this.hote.Size = new System.Drawing.Size(36, 17);
            this.hote.TabIndex = 1;
            this.hote.Text = "hote";
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.Location = new System.Drawing.Point(403, 0);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(69, 17);
            this.identifiant.TabIndex = 2;
            this.identifiant.Text = "identifiant";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(603, 0);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(97, 17);
            this.mdp.TabIndex = 3;
            this.mdp.Text = "mot de  passe";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Serveur);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Serveur.ResumeLayout(false);
            this.Serveur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seveurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuShow;
        private System.Windows.Forms.TableLayoutPanel Serveur;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.Label hote;
        private System.Windows.Forms.Label identifiant;
        private System.Windows.Forms.Label mdp;
    }
}