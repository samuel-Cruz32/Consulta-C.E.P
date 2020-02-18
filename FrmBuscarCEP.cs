using System;
using System.Windows.Forms;

namespace Consultar_C.E.P
{
    public partial class FrmBuscarCEP : Form
    {
        public FrmBuscarCEP()
        {
            InitializeComponent();
        }

        private void btnConsultarCEP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                using (var WS =  new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = WS.consultaCEP(txtCEP.Text.Trim());
                        txtEstado.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtBairro.Text = endereco.bairro;
                        txtRua.Text = endereco.end;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCEP.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtRua.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
           txtCEP.Text = string.Empty;
        }

        private void txtCEP_Click(object sender, EventArgs e)
        {
            txtCEP.Text = string.Empty;
        }
    }
}
