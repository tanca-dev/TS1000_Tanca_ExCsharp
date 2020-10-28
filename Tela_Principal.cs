using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


/*** AUTOR KAHYQUE ANDREOTTI ***/

namespace ExemploSAT
{
    public partial class Tela_Principal : Form
    {
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr AtivarSAT(int numSessao, int subCommand, string codAtivacao, string CNPJContribuinte, string cUF);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr ConfigurarInterfaceDeRede(int numSessao, string codAtivacao, string configuracao);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr TrocarCodigoDeAtivacao(int numSessao, string codAtivacao, int opcao, string cod, string codConf);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr DesbloquearSAT(int numSessao, string codAtivacao);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr BloquearSAT(int numSessao, string codAtivacao);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr ExtrairLogs(int numSessao, string codAtivacao);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr AtualizarSoftwareSAT(int numSessao, string codAtivacao);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr AssociarAssinatura(int numSessao, string codAtivacao, string CNPJVal, string assCNPJ);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr ConsultarNumeroSessao(int numeroSessao, int cNumeroDeSessao);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr ConsultarStatusOperacional(int numSessao, string codAtivacao);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr TesteFimAFim(int numSessao, string codAtivacao, string dados);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr ConsultarSAT(int numSessao);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr CancelarUltimaVenda(int numSessao, string codAtivacao, string chave, string dadosCancelamento);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr EnviarDadosVenda(int numSessao, string codAtivacao, string dadosVenda);
        // ok \\
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr Base64ToAscii();

        string venda;
        int chave;
        string aux;
        XDocument xml;

        IntPtr ptr, intptr_AtivarSAT, intptr_ConfigurarInterfaceDeRede, intptr_TrocarCodigoDeAtivacao, intptr_DesbloquearSAT,
               intptr_BloquearSAT, intptr_ExtrairLogs, intptr_AtualizarSoftware, intptr_AssociarAssinatura, intptr_ConsultarNumeroSessao, intptr_ConsultarStastusOperacional,
               intptr_TesteFimAFim, intptr_ConsultarSAT, intptr_CancelarUltimaVenda, intptr_EnviarDadosVenda;


        AtivarSAT ativarSAT;
        ConfigurarInterfaceDeRede configurarInterfaceDeRede;
        TrocarCodigoDeAtivacao trocarCodigoDeAtivacao;
        DesbloquearSAT desbloquearSAT;
        BloquearSAT bloquearSAT;
        ExtrairLogs extrairLogs;
        AtualizarSoftwareSAT atualizarSoftware;
        AssociarAssinatura associarAssinatura;
        ConsultarNumeroSessao consultarNumeroSessao;
        ConsultarStatusOperacional consultarStatusOperacional;
        TesteFimAFim testeFimAFim;
        ConsultarSAT consultarSAT;
        CancelarUltimaVenda cancelarUltimaVenda;
        EnviarDadosVenda enviarDadosVenda;

        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void Tela_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza de que deseja sair do aplicativo ? ",
                                          "Sair", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                FuncoesDll.FreeLibrary(ptr);
            }   
        }

        public void MovimentaDados(string dados)
        {
            string[] ret;
            txtRetorno.Text = "";

            ret = dados.Split('|');
            foreach (var retorno in ret)
            {
                txtRetorno.Text = txtRetorno.Text + retorno + Environment.NewLine;
            }
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public void FuncoesDLL()
        {
            try
            {
                intptr_ConsultarSAT = FuncoesDll.GetProcAddress(ptr, "ConsultarSAT");
                consultarSAT = (ConsultarSAT)Marshal.GetDelegateForFunctionPointer(intptr_ConsultarSAT, typeof(ConsultarSAT));

                intptr_ConsultarStastusOperacional = FuncoesDll.GetProcAddress(ptr, "ConsultarStatusOperacional");
                consultarStatusOperacional = (ConsultarStatusOperacional)Marshal.GetDelegateForFunctionPointer
                                                                      (intptr_ConsultarStastusOperacional,
                                                                      typeof(ConsultarStatusOperacional));

                intptr_AtivarSAT = FuncoesDll.GetProcAddress(ptr, "AtivarSAT");
                ativarSAT = (AtivarSAT)Marshal.GetDelegateForFunctionPointer
                                                         (intptr_AtivarSAT,
                                                         typeof(AtivarSAT));

                intptr_AssociarAssinatura = FuncoesDll.GetProcAddress(ptr, "AssociarAssinatura");
                associarAssinatura = (AssociarAssinatura)Marshal.GetDelegateForFunctionPointer
                                                                            (intptr_AssociarAssinatura,
                                                                            typeof(AssociarAssinatura));

                intptr_TesteFimAFim = FuncoesDll.GetProcAddress(ptr, "TesteFimAFim");
                testeFimAFim = (TesteFimAFim)Marshal.GetDelegateForFunctionPointer
                                                                  (intptr_TesteFimAFim,
                                                                  typeof(TesteFimAFim));

                intptr_ExtrairLogs = FuncoesDll.GetProcAddress(ptr, "ExtrairLogs");
                extrairLogs = (ExtrairLogs)Marshal.GetDelegateForFunctionPointer
                                                               (intptr_ExtrairLogs,
                                                               typeof(ExtrairLogs));

                intptr_AtualizarSoftware = FuncoesDll.GetProcAddress(ptr, "AtualizarSoftwareSAT");
                atualizarSoftware = (AtualizarSoftwareSAT)Marshal.GetDelegateForFunctionPointer
                                                                                   (intptr_AtualizarSoftware,
                                                                                    typeof(AtualizarSoftwareSAT));

                intptr_DesbloquearSAT = FuncoesDll.GetProcAddress(ptr, "DesbloquearSAT");
                desbloquearSAT = (DesbloquearSAT)Marshal.GetDelegateForFunctionPointer
                                                                        (intptr_DesbloquearSAT,
                                                                        typeof(DesbloquearSAT));

                intptr_EnviarDadosVenda = FuncoesDll.GetProcAddress(ptr, "EnviarDadosVenda");
                enviarDadosVenda = (EnviarDadosVenda)Marshal.GetDelegateForFunctionPointer
                                                                  (intptr_EnviarDadosVenda,
                                                                  typeof(EnviarDadosVenda));

                intptr_CancelarUltimaVenda = FuncoesDll.GetProcAddress(ptr, "CancelarUltimaVenda");
                cancelarUltimaVenda = (CancelarUltimaVenda)Marshal.GetDelegateForFunctionPointer
                                                                  (intptr_CancelarUltimaVenda,
                                                                  typeof(CancelarUltimaVenda));

                intptr_BloquearSAT = FuncoesDll.GetProcAddress(ptr, "BloquearSAT");
                bloquearSAT = (BloquearSAT)Marshal.GetDelegateForFunctionPointer
                                                               (intptr_BloquearSAT,
                                                               typeof(BloquearSAT));

                intptr_ConsultarNumeroSessao = FuncoesDll.GetProcAddress(ptr, "ConsultarNumeroSessao");
                consultarNumeroSessao = (ConsultarNumeroSessao)Marshal.GetDelegateForFunctionPointer
                                                                       (intptr_ConsultarNumeroSessao,
                                                                        typeof(ConsultarNumeroSessao));

                MessageBox.Show("DLL carregada com sucesso");
                grpBoxFuncoes.Enabled = true;
                return;

            }
            catch
            {
                MessageBox.Show("DLL importada não é uma dll SAT", "Erro", MessageBoxButtons.OK);
                txtImportarDLL.Text = "";
                grpBoxFuncoes.Enabled = false;
                return;
            }
        }

        public bool validacao()
        {
            if (txtCodigoAtivacao.Text == "")
            {
                MessageBox.Show("Preencha os dados do codigo de ativação!", "Erro", MessageBoxButtons.OK);
                return false;
            }
            else if (txtImportarDLL.Text == "")
            {
                MessageBox.Show("Por favor importar a DLL");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void btnConfigurarRede_Click(object sender, EventArgs e)
        {
            if (txtImportarDLL.Text == "")
            {
                MessageBox.Show("Por favor importar a DLL");
                btnImportarDLL.Focus();
                return;
            }
            else if (Application.OpenForms.OfType<Configurar_Rede>().Count() > 0)
            {
                Application.OpenForms.OfType<Configurar_Rede>().First().Focus();
            }
            else
            {
                Configurar_Rede configRede = new Configurar_Rede(txtImportarDLL.Text);
                configRede.ShowDialog();
            }
        }

        private void btnTrocarCodigo_Click(object sender, EventArgs e)
        {
            if (txtImportarDLL.Text == "")
            {
                MessageBox.Show("Por favor importar a DLL");
                btnImportarDLL.Focus();
                return;
            }
            else if (Application.OpenForms.OfType<Codigo_de_Ativacao>().Count() > 0)
            {
                Application.OpenForms.OfType<Codigo_de_Ativacao>().First().Focus();
            }
            else
            {
                Codigo_de_Ativacao codAtivacao = new Codigo_de_Ativacao(txtImportarDLL.Text);
                codAtivacao.ShowDialog();
            }
        }

        private void btnXMLFimaFim_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            op.FilterIndex = 0;
            op.DefaultExt = "xml";
            if (op.ShowDialog() == DialogResult.OK)
            {
                if (!String.Equals(Path.GetExtension(op.FileName),".xml",StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("O tipo do arquivo selecionado não é suportado por este aplicativo. Você deve selecionar um arquivo XML.",
                                    "Tipo de arquivo inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("XML Carregada com sucesso");
                    txtXMLFimaFim.Text = op.FileName;
                }
            }
        }

        private void btnXMLVenda_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            op.FilterIndex = 0;
            op.DefaultExt = "xml";
            if (op.ShowDialog() == DialogResult.OK)
            {
                if (!String.Equals(Path.GetExtension(op.FileName),
                                   ".xml",
                                   StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("O tipo do arquivo selecionado não é suportado por este aplicativo. Você deve selecionar um arquivo XML.",
                                    "Tipo de arquivo inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("XML Carregado com sucesso");
                    txtXMLVenda.Text = op.FileName;
                }
            }
        }


        private void btnCFeCancelamento_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            op.FilterIndex = 0;
            op.DefaultExt = "xml";
            if (op.ShowDialog() == DialogResult.OK)
            {
                if (!String.Equals(Path.GetExtension(op.FileName),
                                   ".xml",
                                   StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("O tipo do arquivo selecionado não é suportado por este aplicativo. Você deve selecionar um arquivo XML.",
                                    "Tipo de arquivo inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("XML Carregado com sucesso");
                    txtXMLCancelamento.Text = op.FileName;
                }
            }
        }

        private void btnImportarDLL_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Selecionar DLL";
            op.DefaultExt = "dll";
            op.Filter = "dll files (*.dll)|*.dll|All files (*.*)|*.*";
            op.ShowDialog();

            txtImportarDLL.Text = op.FileName;
            string SATDLL = txtImportarDLL.Text;

            int tamanho = IntPtr.Size;

            tamanho.ToString();

            ptr = FuncoesDll.LoadLibrary(SATDLL);

            if ((tamanho == 4) && (ptr != IntPtr.Zero))
            {
                FuncoesDLL();
            }
            else if ((tamanho == 8) && (ptr != IntPtr.Zero))
            {
                FuncoesDLL();
            }
            else
            {
                MessageBox.Show("Erro ao importar DLL");
                grpBoxFuncoes.Enabled = false;
                return;
            }

        }

        private void btnConsultaSAT_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);

           if (validacao())
            {
                aux = Marshal.PtrToStringAnsi(consultarSAT(numSessao));
                MovimentaDados(Environment.NewLine + " * ConsultarSAT( )" + Environment.NewLine +
                                " * -> char* ConsultarSAT(int numSessao) *" + Environment.NewLine +
                                " * Parâmetros: numSessao - Parâmetro tipo numérico que informa o número da sessão." 
                                +Environment.NewLine + "_________________________________________________________" 
                                +Environment.NewLine + aux);
            }
            else
            {
                return;
            }

        }

        private void btnEstadoOperacional_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);
            
            if (validacao())
            {
                aux = Marshal.PtrToStringAnsi(consultarStatusOperacional(numSessao, txtCodigoAtivacao.Text));
                MovimentaDados(Environment.NewLine + " * ConsultarStatusOperacional( )" + Environment.NewLine +
                               " * -> char* ConsultarStatusOperacional(int numSessao char codigoDeAtivacao) *" + Environment.NewLine +
                               " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação." +Environment.NewLine+
                               "                 codigoDeAtivação - Senha definida pelo contribuinte no software de ativação."
                               +Environment.NewLine + "_________________________________________________________" 
                               +Environment.NewLine+ aux);

            }
            else
            {
                return;
            }
        }

        private void btnAtivarSAT_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);

           if (validacao())
           {
               aux = Marshal.PtrToStringAnsi(ativarSAT(numSessao, 1, txtCodigoAtivacao.Text, txtCNPJContribuinte.Text, "35"));
               MovimentaDados(Environment.NewLine+" * AtivarSAT( )"+Environment.NewLine+ 
                               " * -> char* AtivarSAT(int numeroSessao, int subComando, char codigoDeAtivacao, char CNPJ, int cUF"
                               +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                               +Environment.NewLine+" subComando - Identificador do tipo de Certificado." 
                               +Environment.NewLine+" codigoDeAtivacao - Senha definida pelo contirbuinte no software de ativação."
                               +Environment.NewLine+ " CNPJ - CNPJ do contribuinte, somente números."
                               +Environment.NewLine+" cUF - Código do Estado de Federação onde o SAT será ativado."
                               +Environment.NewLine+ "_________________________________________________________"
                               +Environment.NewLine+ aux);
           }
           else
           {
               return;
           }
            
        }

        private void btnVincularAC_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);

            if (txtCodigoAtivacao.Text == "" || txtCNPJSoftwareHouse.Text == "" || txtCodigoAC.Text == "" || txtCNPJContribuinte.Text == "")
            {
                MessageBox.Show("Preencha todos os dados!", "Erro", MessageBoxButtons.OK);
                txtCodigoAtivacao.Focus();
                return;
            }
            else if (txtImportarDLL.Text == "")
            {
                MessageBox.Show("Por favor importar a DLL");
                btnImportarDLL.Focus();
                return;
            }
            else
            {
                aux = Marshal.PtrToStringAnsi(associarAssinatura(numSessao, txtCodigoAtivacao.Text, txtCNPJSoftwareHouse.Text + txtCNPJContribuinte.Text, txtCodigoAC.Text));
                MovimentaDados(Environment.NewLine+ " * AssociarAssinatura( )"
                               +Environment.NewLine+ " * -> char*ConfigurarInterfaceDeRede(int numSessao, char codigoDeAtivacao, char dadosConfiguracao"
                               +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                               +Environment.NewLine+ " codigoDeAtivacao - Senha definida pelo contribuinte no software de ativação."
                               +Environment.NewLine+ " dadosConfiguracao: CNPJvalue - CNPJ da empresa desenvolvedora do aplicativo comercial + CNPJ do emitente."
                               +Environment.NewLine+ " assinaturaCNPJs - Assinatura digital conjunto - CNPJ SOFTWARE HOUSE + CNPJ DO ESTABELECIMENTO"
                               +Environment.NewLine+ "_________________________________________________________"
                               +Environment.NewLine+ aux);
            }
        }

        private void btnFimaFim_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);

            if (txtXMLFimaFim.Text == "")
            {
                MessageBox.Show("Por favor importar XML de teste fim a fim", "Erro", MessageBoxButtons.OK);
                btnXMLFimaFim.Focus();
                return;
            }
            xml = XDocument.Load(txtXMLFimaFim.Text);

            if (validacao())
            {
                aux = Marshal.PtrToStringAnsi(testeFimAFim(numSessao, txtCodigoAtivacao.Text, xml.ToString()));
                MovimentaDados(Environment.NewLine+ " * TesteFimAFim( )"
                               +Environment.NewLine+ " * -> char* TesteFimAFim(int numSessao, char codigoDeAtiavação, char dadosVenda"
                               +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                               +Environment.NewLine+ " codigoDeAtivacao - Senha definida pelo contribuinte no software de ativação."
                               +Environment.NewLine+ " dadosVenda - Refere-se aos dados de venda fictícios gerados pelo AC e utilizados para compor o CF-e SAT de teste."
                               +Environment.NewLine+ "_________________________________________________________"
                               +Environment.NewLine+ aux);

            }
            else
            {
                return;
            }

            
        }

        public void btnExtrairLOG_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);

            string[] retorno, spl;
            string arquivo, trad;

            if (validacao())
            {
                aux = Marshal.PtrToStringAnsi(consultarSAT(numSessao));

                spl = aux.Split('|');

                if (spl[1] == "08000")
                {
                    arquivo = "LOG-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".txt";

                    Random num2 = new Random();
                    int numSessao2 = num2.Next(1, 999999);

                    aux = Marshal.PtrToStringAnsi(extrairLogs(numSessao2, txtCodigoAtivacao.Text));
                    retorno = aux.Split('|');

                    trad = Base64Decode(retorno[5]);

                    System.IO.File.WriteAllText(@arquivo, retorno[1] + Environment.NewLine
                       + retorno[2] + Environment.NewLine
                       + retorno[3] + Environment.NewLine
                       + retorno[4] + Environment.NewLine
                       + trad);

                    MessageBox.Show("Tranferencia finalizada e salva na mesma pasta do .exe");
                }
                else
                {
                    MovimentaDados(Environment.NewLine+ " * ExtrairLogs( ) "
                                   +Environment.NewLine+ " * ExtrairLogs(int numSessao, char codigoDeAtivacao)"
                                   +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                                   +Environment.NewLine+ " codigoDeAtivacao - Senha definida pelo contribuinte no software de ativação."
                                   +Environment.NewLine+ "_________________________________________________________"
                                   +Environment.NewLine+ aux);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void btnAtualizarSoftware_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);
        
            if (validacao())
            {
                aux = Marshal.PtrToStringAnsi(atualizarSoftware(numSessao, txtCodigoAtivacao.Text));
                MovimentaDados(Environment.NewLine+ " * AtualizarSoftwareSAT( )"
                               +Environment.NewLine+ " * atualizarSoftware(int numSessao, char codigoDeAtivacao)"
                               +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                               +Environment.NewLine+ " codigoDeAtivacao - Senha definida pelo contribuinte no software de ativação."
                               +Environment.NewLine+ "_________________________________________________________"
                               +Environment.NewLine+ aux);
            }
            else
            {
                return;
            }
        }

        private void btnDesbloquearSAT_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);

            if (validacao())
            {
                aux = Marshal.PtrToStringAnsi(desbloquearSAT(numSessao, txtCodigoAtivacao.Text));
                MovimentaDados(Environment.NewLine+ " * DesbloquearSAT( )"
                               +Environment.NewLine+ " * desbloquearSAT(int numSessao, char codigoDeAtivacao"
                               +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                               +Environment.NewLine+ " codigoDeAtivacao - Senha definida pelo contribuinte no software de ativação."
                               +Environment.NewLine+ "_________________________________________________________"
                               +Environment.NewLine+ aux);
            }
            else
            {
                return;
            }
        }

        public void btnEfetuarVenda_Click(object sender, EventArgs e)
        {

            List<string> rett = new List<string>();
            string[] cfe;

            Random num = new Random();
            int numSessao = num.Next(1, 999999);


            if (txtXMLVenda.Text == "")
            {
                MessageBox.Show("Por favor importar XML de venda", "Erro", MessageBoxButtons.OK);
                btnXMLVenda.Focus();
                return;
            }
            else
            {
                xml = XDocument.Load(txtXMLVenda.Text);

                if (validacao())
                {
                    aux = Marshal.PtrToStringAnsi(enviarDadosVenda(numSessao, txtCodigoAtivacao.Text, xml.ToString()));

                    cfe = aux.Split('|');

                    if (cfe.Length <= 1)
                    {
                        MovimentaDados(aux);
                        return;
                    }

                    if (!cfe[1].Equals("06000"))
                    {
                        MovimentaDados(Environment.NewLine+ " * EnviarDadosVenda( )"
                                       +Environment.NewLine+ " * enviarDadosVenda(int numSessao, char codigoDeAtivacao, char dadosVenda)"
                                       +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                                       + Environment.NewLine + " codigoDeAtivacao - Senha definida pelo contribuinte no software de ativação."
                                       +Environment.NewLine+ " dadosVenda - Refere-se aos dados de venda gerados pelo AC e utilizados para compor o CF-e SAT."
                                       +Environment.NewLine+ "_________________________________________________________"
                                       +Environment.NewLine+ aux);
                        return;
                    }

                    rett.Add(cfe[8]);
                    MovimentaDados("Venda realizada com sucesso: " + Environment.NewLine + aux);

                    DialogResult dr = MessageBox.Show("Venda realizada com sucesso !" + Environment.NewLine +
                        cfe[8] + Environment.NewLine +
                        "Deseja cancelar esta venda ? ",
                                              "Resposta", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {

                        Random numCancel = new Random();
                        int NumSessao = numCancel.Next(1, 999999);

                        string xmlCancelamento = "  \r\n" +
                        "<CFeCanc>\r\n" +
                        "	<infCFe chCanc=\"--$--\">\r\n" +
                        "		<ide>\r\n" +
                        "			<CNPJ>"+txtCNPJSoftwareHouse.Text+"</CNPJ>\r\n" +
                        "			<signAC>"+txtCodigoAC.Text+"</signAC>\r\n" +
                        "			<numeroCaixa>001</numeroCaixa>\r\n" +
                        "		</ide>\r\n" +
                        "		<emit />\r\n" +
                        "		<dest/>\r\n" +
                        "		<total/>\r\n" +
                        "   	</infCFe>\r\n" +
                        "</CFeCanc>\r\n" +
                        "";

                        aux = Marshal.PtrToStringAnsi(cancelarUltimaVenda(NumSessao, txtCodigoAtivacao.Text, cfe[8], xmlCancelamento.Replace("--$--", cfe[8])));

                        cfe = aux.Split('|');

                        if (cfe.Length <= 1)
                        {
                            MovimentaDados(aux);
                            return;
                        }

                        if (!cfe[1].Equals("07000"))
                        {
                            MovimentaDados(Environment.NewLine+ " * CancelarUltimaVenda( )"
                                           +Environment.NewLine+ " * cancelarUltimaVenda(int numSessao, char codigoDeAtivacao, char chave, char dadosCancelamento"
                                           +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                                           +Environment.NewLine + " codigoDeAtivacao - Senha definida pelo contribuinte no software de ativação."
                                           +Environment.NewLine+ " chave - Chave de acesso do CF-e SAT a ser cancelado."
                                           +Environment.NewLine+ " dadosCancelamento - Refere-se aos dados da venda gerados pelo AC e utilizados para compor o CF-e SAT de cancelamento."
                                           +Environment.NewLine+ "_________________________________________________________"
                                           +Environment.NewLine+ aux);
                            return;
                        }

                        MessageBox.Show("Venda foi cancelada" + Environment.NewLine + cfe[8], "Resposta", MessageBoxButtons.OK);

                        MovimentaDados("Venda cancelada com sucesso: " + aux + cfe[8]);
                        return;
                    }
                }
            }
        }

        public void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);


            if (txtXMLCancelamento.Text == "")
            {
                MessageBox.Show("Por favor importar XML de cancelamento", "Erro", MessageBoxButtons.OK);
                btnCFeCancelamento.Focus();
                return;
            }
            else
            {
                xml = XDocument.Load(txtXMLCancelamento.Text);

                if (validacao())
                {
                    aux = Marshal.PtrToStringAnsi(cancelarUltimaVenda(numSessao, txtCodigoAtivacao.Text, aux, xml.ToString()));
                    MovimentaDados(Environment.NewLine+ " * CancelarUltimaVenda( )"
                                   +Environment.NewLine+ " * cancelaUltimaVenda(int numSessao, char codigoDeAtivacao, char chave, char dadosCancelamento)"
                                   +Environment.NewLine+ " Parâmetros: numSessao - Número aleatório gerado pelo AC para controle de comunicação."
                                   +Environment.NewLine+ " codigoDeAtivação - Senha definida pelo contribuinte no software de ativação."
                                   +Environment.NewLine+ " chave - Chave de acesso do CF-e SAT a ser cancelado."
                                   +Environment.NewLine+ " dadosCancelamento - Refere-se aos dados da venda gerados pelo AC e utilizados para compor o CF-e SAT de cancelamento."
                                   +Environment.NewLine+ "_________________________________________________________"
                                   +Environment.NewLine+ aux);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnBloquearSAT_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);

           if (validacao())
           {
                aux = Marshal.PtrToStringAnsi(bloquearSAT(numSessao, txtCodigoAtivacao.Text));
                MovimentaDados(Environment.NewLine+ " * BloquearSAT( )"
                               +Environment.NewLine+ " * bloquearSat(int numSessao, char codigoDeAtivacao"
                               +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                               +Environment.NewLine+ " codigoDeAtivacao - Senha definida pelo contribuinte no software de ativação."
                               +Environment.NewLine+ "_________________________________________________________"
                               +Environment.NewLine+ aux);
           }
           else
           {
                return;
           }
        }

        private void btnConsultaNumeroSessao_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numSessao = num.Next(1, 999999);

            if (validacao())
            {
                aux = Marshal.PtrToStringAnsi(consultarNumeroSessao(numSessao, 0));
                MovimentaDados(Environment.NewLine+ " * ConsultaNumeroSessao( )"
                               +Environment.NewLine+ " * consultaNumeroSessao(int numeroSessao, int cNumeroSessao"
                               +Environment.NewLine+ " * Parâmetros: numeroSessao - Número aleatório gerado pelo AC para controle de comunicação."
                               +Environment.NewLine+ " cNumeroSessao - Número de sessão a ser consultada no SAT CF-e."
                               +Environment.NewLine+ "_________________________________________________________"
                               +Environment.NewLine+ aux);
            }
            else
            {
                return;
            }
        }
    }
}
