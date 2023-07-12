using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ECF
{
    public class ECF_Bematech
    {
        //Cupom Fiscal
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_AbreCupom(string CGC_CPF);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_VendeItem(string Codigo, string Descricao, string Aliquota, string TipoQuantidade, string Quantidade, int CasasDecimais, string ValorUnitario, string TipoDesconto, string Desconto);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_IniciaFechamentoCupom(string AcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_EfetuaFormaPagamento(string FormaPagamento, string ValorFormaPagamento);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_TerminaFechamentoCupom(string Mensagem);

        //Relatórios Fiscais
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_LeituraX();
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_ReducaoZ(string Data, string Hora);

        //Operações não Fiscais
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_Sangria(string Valor);
        [DllImport("BemaFi32.dll")]
        public static extern int Bematech_FI_Suprimento(string Valor, string FormaPagamento);

    }
}
