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
            this.components = new System.ComponentModel.Container();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.btnImportarCsv = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(46, 37);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(537, 42);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem-vindo, [NOME_USUARIO]";
            this.lblBemVindo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnImportarCsv
            // 
            this.btnImportarCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarCsv.Location = new System.Drawing.Point(158, 534);
            this.btnImportarCsv.Name = "btnImportarCsv";
            this.btnImportarCsv.Size = new System.Drawing.Size(170, 104);
            this.btnImportarCsv.TabIndex = 1;
            this.btnImportarCsv.Text = "Importar Arquivo CSV";
            this.btnImportarCsv.UseVisualStyleBackColor = true;
            this.btnImportarCsv.Click += new System.EventHandler(this.btnImportarCsv_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(1225, 405);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(158, 91);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consultar Contratos";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem-vindo ao Sistema de Importação e Consulta de Contratos";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "📎 Importação de Arquivos CSV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 106);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecione um arquivo contendo os dados dos contratos. O sistema cuidará do resto " +
    "para você.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 108);
            this.label4.TabIndex = 6;
            this.label4.Text = "⚠️ Certifique-se de que o arquivo esteja no formato correto. Colunas obrigatórias" +
    ": Cliente, Valor, Vencimento.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(433, 80);
            this.label5.TabIndex = 7;
            this.label5.Text = "📥 Nenhum arquivo selecionado ainda. Clique em \"Importar Arquivo CSV\" para começa" +
    "r.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1220, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 106);
            this.label6.TabIndex = 8;
            this.label6.Text = "🔎 Consulte contratos importados de maneira inteligente";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1220, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(315, 106);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dica: quanto mais específico for o filtro, mais precisa será a sua consulta.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1826, 716);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}