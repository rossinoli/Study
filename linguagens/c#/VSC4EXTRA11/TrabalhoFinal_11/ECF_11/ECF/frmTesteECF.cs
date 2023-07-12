using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF
{
    public partial class frmTesteECF : Form
    {
        int IRetorno;
                
        public frmTesteECF()
        {
            InitializeComponent(); 
        }

        private void btnAbrirCupom_Click(object sender, EventArgs e)
        {
            IRetorno = ECF_Bematech.Bematech_FI_AbreCupom("111.111.111-11");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            IRetorno = ECF_Bematech.Bematech_FI_VendeItem("123456789", "Produto 1", "II", "I", "3", 2, "1,20", "%", "0");
        }

        private void btnFecharCupom_Click(object sender, EventArgs e)
        {
            IRetorno = ECF_Bematech.Bematech_FI_IniciaFechamentoCupom("D", "$", "1,00");
            IRetorno = ECF_Bematech.Bematech_FI_EfetuaFormaPagamento("Dinheiro", "12,00");
            IRetorno = ECF_Bematech.Bematech_FI_TerminaFechamentoCupom("OBRIGADO! VOLTE SEMPRE!");
        }

        private void btnLeituraX_Click(object sender, EventArgs e)
        {
            IRetorno = ECF_Bematech.Bematech_FI_LeituraX();
        }

        private void btnReducaoZ_Click(object sender, EventArgs e)
        {
            IRetorno = ECF_Bematech.Bematech_FI_ReducaoZ(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
        }

        private void btnSangria_Click(object sender, EventArgs e)
        {
            IRetorno = ECF_Bematech.Bematech_FI_Sangria("10,00");
        }

        private void btnSuprimento_Click(object sender, EventArgs e)
        {
            IRetorno = ECF_Bematech.Bematech_FI_Suprimento("100,00", "Dinheiro");
        }
       
    }
}
