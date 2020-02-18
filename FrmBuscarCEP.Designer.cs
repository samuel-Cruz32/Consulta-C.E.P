namespace Consultar_C.E.P
{
    partial class FrmBuscarCEP
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarCEP));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarCEP = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.SystemColors.Info;
            this.txtCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCEP.Location = new System.Drawing.Point(21, 34);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(225, 26);
            this.txtCEP.TabIndex = 1;
            this.txtCEP.Text = "Digite apenas números";
            this.txtCEP.Click += new System.EventHandler(this.txtCEP_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.txtRua);
            this.gbResultado.Controls.Add(this.label5);
            this.gbResultado.Controls.Add(this.txtBairro);
            this.gbResultado.Controls.Add(this.label4);
            this.gbResultado.Controls.Add(this.txtCidade);
            this.gbResultado.Controls.Add(this.label3);
            this.gbResultado.Controls.Add(this.txtEstado);
            this.gbResultado.Controls.Add(this.label2);
            this.gbResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(12, 87);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(560, 261);
            this.gbResultado.TabIndex = 2;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado:";
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.LightGray;
            this.txtRua.Enabled = false;
            this.txtRua.Location = new System.Drawing.Point(9, 219);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(532, 26);
            this.txtRua.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rua:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.LightGray;
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(9, 163);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(532, 26);
            this.txtBairro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.LightGray;
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(9, 104);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(532, 26);
            this.txtCidade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cidade:";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.LightGray;
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(9, 47);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(532, 26);
            this.txtEstado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // btnConsultarCEP
            // 
            this.btnConsultarCEP.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarCEP.BackgroundImage = global::Consultar_C.E.P.Properties.Resources.busca_cep;
            this.btnConsultarCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarCEP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarCEP.FlatAppearance.BorderSize = 2;
            this.btnConsultarCEP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnConsultarCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCEP.Location = new System.Drawing.Point(367, 22);
            this.btnConsultarCEP.Name = "btnConsultarCEP";
            this.btnConsultarCEP.Size = new System.Drawing.Size(186, 49);
            this.btnConsultarCEP.TabIndex = 3;
            this.btnConsultarCEP.UseVisualStyleBackColor = false;
            this.btnConsultarCEP.Click += new System.EventHandler(this.btnConsultarCEP_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = global::Consultar_C.E.P.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(367, 378);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 31);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::Consultar_C.E.P.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(469, 378);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 31);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmBuscarCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultarCEP);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBuscarCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar CEPs";
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultarCEP;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

