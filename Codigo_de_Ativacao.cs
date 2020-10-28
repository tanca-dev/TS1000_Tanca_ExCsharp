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
    public partial class Codigo_de_Ativacao : Form
    {

        Boolean st = false;
        IntPtr ptr, intptr_trocarCodigoDeAtivacao;
        TrocarCodigoDeAtivacao trocarCodigoDeAtivacao;

        public Codigo_de_Ativacao()
        {
            InitializeComponent();
        }

        public Codigo_de_Ativacao(string dll)
        {
            InitializeComponent();
            string SATDLL = dll;
            ptr = FuncoesDll.LoadLibrary(SATDLL);

            intptr_trocarCodigoDeAtivacao = FuncoesDll.GetProcAddress(ptr, "TrocarCodigoDeAtivacao");
            trocarCodigoDeAtivacao = (TrocarCodigoDeAtivacao)Marshal.GetDelegateForFunctionPointer
                                                                     (intptr_trocarCodigoDeAtivacao,
                                                                      typeof(TrocarCodigoDeAtivacao));
        }

        private void Codigo_de_Ativacao_Load(object sender, EventArgs e)
        {
            txtCodEmergencia.Enabled = false;
        }

        private void chkCodEmergencia_CheckedChanged(object sender, EventArgs e)
        {
            txtCodEmergencia.Enabled = !st;
            txtCodAtivacao.Enabled = st;
            st = !st;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string aux;
            int opcao = 0;

            Random num = new Random();
            int numSessao = num.Next(1, 999999);

            if (chkCodEmergencia.Checked)
            {
                opcao = 2;
                if (txtCodEmergencia.Text == "" || txtNovoCodigo.Text == "")
                {
                    MessageBox.Show("Preencha os dados do codigo de ativação e o novo código de ativação", "Erro", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    aux = Marshal.PtrToStringAnsi(trocarCodigoDeAtivacao(numSessao, txtCodEmergencia.Text, opcao, txtNovoCodigo.Text, txtConfirmarCodigo.Text));
                    MessageBox.Show(aux);
                }
            }
            else
            {
                opcao = 1;
                if (txtCodAtivacao.Text == "" || txtNovoCodigo.Text == "")
                {
                    MessageBox.Show("Preencha os dados do codigo de ativação e o novo código de ativação", "Erro", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    aux = Marshal.PtrToStringAnsi(trocarCodigoDeAtivacao(numSessao, txtCodAtivacao.Text, opcao, txtNovoCodigo.Text, txtConfirmarCodigo.Text));
                    MessageBox.Show(aux);
                }
            }
        }
    }
}