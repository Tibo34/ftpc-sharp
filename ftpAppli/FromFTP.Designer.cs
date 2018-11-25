namespace ftpAppli
{
    partial class ConnexionFTP
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.portLab = new System.Windows.Forms.Label();
            this.hot = new System.Windows.Forms.Label();
            this.identifiant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portValue = new System.Windows.Forms.TextBox();
            this.hoteValue = new System.Windows.Forms.TextBox();
            this.idValue = new System.Windows.Forms.TextBox();
            this.mdpValue = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.portLab, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hot, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.identifiant, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.portValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hoteValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.idValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mdpValue, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(195, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // portLab
            // 
            this.portLab.AutoSize = true;
            this.portLab.Location = new System.Drawing.Point(3, 0);
            this.portLab.Name = "portLab";
            this.portLab.Size = new System.Drawing.Size(33, 17);
            this.portLab.TabIndex = 0;
            this.portLab.Text = "port";
            // 
            // hot
            // 
            this.hot.AutoSize = true;
            this.hot.Location = new System.Drawing.Point(3, 38);
            this.hot.Name = "hot";
            this.hot.Size = new System.Drawing.Size(38, 17);
            this.hot.TabIndex = 1;
            this.hot.Text = "Hote";
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.Location = new System.Drawing.Point(3, 76);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(69, 17);
            this.identifiant.TabIndex = 2;
            this.identifiant.Text = "identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "mot de passe";
            // 
            // portValue
            // 
            this.portValue.Location = new System.Drawing.Point(99, 3);
            this.portValue.Name = "portValue";
            this.portValue.Size = new System.Drawing.Size(91, 22);
            this.portValue.TabIndex = 4;
            // 
            // hoteValue
            // 
            this.hoteValue.Location = new System.Drawing.Point(99, 41);
            this.hoteValue.Name = "hoteValue";
            this.hoteValue.Size = new System.Drawing.Size(91, 22);
            this.hoteValue.TabIndex = 5;
            // 
            // idValue
            // 
            this.idValue.Location = new System.Drawing.Point(99, 79);
            this.idValue.Name = "idValue";
            this.idValue.Size = new System.Drawing.Size(91, 22);
            this.idValue.TabIndex = 6;
            // 
            // mdpValue
            // 
            this.mdpValue.Location = new System.Drawing.Point(99, 117);
            this.mdpValue.Name = "mdpValue";
            this.mdpValue.Size = new System.Drawing.Size(91, 22);
            this.mdpValue.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(234, 261);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(124, 70);
            this.submit.TabIndex = 1;
            this.submit.Text = "Enregistrer";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.SaveFTP);
            // 
            // ConnexionFTP
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConnexionFTP";
            this.Text = "Serveur FTP";
            this.Click += new System.EventHandler(this.SaveFTP);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label portLab;
        private System.Windows.Forms.Label hot;
        private System.Windows.Forms.Label identifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portValue;
        private System.Windows.Forms.TextBox hoteValue;
        private System.Windows.Forms.TextBox idValue;
        private System.Windows.Forms.TextBox mdpValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button submit;
    }
}