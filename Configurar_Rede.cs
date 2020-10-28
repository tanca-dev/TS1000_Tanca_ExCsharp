using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExemploSAT.Tela_Principal;

namespace ExemploSAT
{

    public partial class Configurar_Rede : Form
    {
        IntPtr ptr, intptr_ConfigurarInterfaceDeRede;
        string dados, dt;
        ConfigurarInterfaceDeRede configurarInterfaceDeRede;


        public Configurar_Rede()
        {
            InitializeComponent();
        }

        public Configurar_Rede(string dll)
        {
            InitializeComponent();
            string SATDLL = dll;
            ptr = FuncoesDll.LoadLibrary(SATDLL);

            intptr_ConfigurarInterfaceDeRede = FuncoesDll.GetProcAddress(ptr, "ConfigurarInterfaceDeRede");
            configurarInterfaceDeRede = (ConfigurarInterfaceDeRede)Marshal.GetDelegateForFunctionPointer
                                                                           (intptr_ConfigurarInterfaceDeRede,
                                                                           typeof(ConfigurarInterfaceDeRede));
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);

            if (txtCodAtivacao.Text == "")
            {
                MessageBox.Show("Preencha os dados do codigo de ativação", "Erro", MessageBoxButtons.OK);
                txtCodAtivacao.Focus();
                return;
            }
            dados = "<?xml version=\"1.0\" encoding=\"UTF - 8\"?><config>"
                    + "<tipoInter>ETHE</tipoInter>";

            switch (cbbInterface.SelectedIndex)
            {
                case 0:
                    if (txtIP.Text == "" || txtMaskRede.Text == "" || txtGateway.Text == "" || txtDNS1.Text == "" || txtDNS2.Text == "")
                    {
                        MessageBox.Show("Verifique os dados: IP, Máscara de rede, Gateway, DNS e DNS secundário", "Erro", MessageBoxButtons.OK);
                        txtIP.Focus();
                        return;
                    }
                    else
                    {
                        dados += "<tipoLan>IPFIX</tipoLan>"
                    + "<lanIP>" + txtIP.Text + "</lanIP>"
                    + "<lanMask>" + txtMaskRede.Text + "</lanMask>"
                    + "<lanGW>" + txtGateway.Text + "</lanGW>"
                    + "<lanDNS1>" + txtDNS1.Text + "</lanDNS1>"
                    + "<lanDNS2>" + txtDNS2.Text + "</lanDNS2>"
                    + "</config>";
                    }
                    break;
                case 1:

                    dados += "<tipoLan>DHCP</tipoLan>"
                           + "</config>";
                    break;
                default:
                    MessageBox.Show("Selecione o tipo de conexão");
                    return;
            }
            dt = Marshal.PtrToStringAnsi(configurarInterfaceDeRede(numSessao, txtCodAtivacao.Text, dados));
            MessageBox.Show(dt);
        }

        private void Configurar_Rede_Load(object sender, EventArgs e)
        {
            cbbInterface.SelectedIndex = 0;
            cbbTipoDeRede.SelectedIndex = 0;
            cbbProxy.SelectedIndex = 0;
        }
    }
}