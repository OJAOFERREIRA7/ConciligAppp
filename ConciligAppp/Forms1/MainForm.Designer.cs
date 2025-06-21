namespace ConciligAppp.Forms1
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.btnImportarCsv = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(118, 50);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(156, 13);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem-vindo, [NOME_USUARIO]";
            this.lblBemVindo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnImportarCsv
            // 
            this.btnImportarCsv.Location = new System.Drawing.Point(121, 187);
            this.btnImportarCsv.Name = "btnImportarCsv";
            this.btnImportarCsv.Size = new System.Drawing.Size(196, 167);
            this.btnImportarCsv.TabIndex = 1;
            this.btnImportarCsv.Text = "Importar Arquivo CSV";
            this.btnImportarCsv.UseVisualStyleBackColor = true;
            this.btnImportarCsv.Click += new System.EventHandler(this.btnImportarCsv_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(121, 383);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(196, 224);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consultar Contratos";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 695);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnImportarCsv);
            this.Controls.Add(this.lblBemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Button btnImportarCsv;
        private System.Windows.Forms.Button btnConsulta;
    }
}