using System.Windows.Forms;

namespace ExemploSAT
{
    partial class Tela_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.btnConsultaSAT = new System.Windows.Forms.Button();
            this.btnConfigurarRede = new System.Windows.Forms.Button();
            this.btnAtivarSAT = new System.Windows.Forms.Button();
            this.btnVincularAC = new System.Windows.Forms.Button();
            this.btnFimaFim = new System.Windows.Forms.Button();
            this.btnEstadoOperacional = new System.Windows.Forms.Button();
            this.btnExtrairLOG = new System.Windows.Forms.Button();
            this.btnTrocarCodigo = new System.Windows.Forms.Button();
            this.btnAtualizarSoftware = new System.Windows.Forms.Button();
            this.btnDesbloquearSAT = new System.Windows.Forms.Button();
            this.btnEfetuarVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnBloquearSAT = new System.Windows.Forms.Button();
            this.btnConsultaNumeroSessao = new System.Windows.Forms.Button();
            this.grpBoxRetorno = new System.Windows.Forms.GroupBox();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.grpBoxFuncoes = new System.Windows.Forms.GroupBox();
            this.lblImportarDLL = new System.Windows.Forms.Label();
            this.txtImportarDLL = new System.Windows.Forms.TextBox();
            this.btnImportarDLL = new System.Windows.Forms.Button();
            this.lblCodigoAtivacao = new System.Windows.Forms.Label();
            this.txtCodigoAtivacao = new System.Windows.Forms.TextBox();
            this.lblCNPJSoftwareHouse = new System.Windows.Forms.Label();
            this.txtCNPJSoftwareHouse = new System.Windows.Forms.TextBox();
            this.lblCNPJContribuinte = new System.Windows.Forms.Label();
            this.txtCNPJContribuinte = new System.Windows.Forms.TextBox();
            this.lblCodigoAC = new System.Windows.Forms.Label();
            this.txtCodigoAC = new System.Windows.Forms.TextBox();
            this.lblXMLFimaFim = new System.Windows.Forms.Label();
            this.txtXMLFimaFim = new System.Windows.Forms.TextBox();
            this.lblXMLVenda = new System.Windows.Forms.Label();
            this.txtXMLVenda = new System.Windows.Forms.TextBox();
            this.lblXMLCancelamento = new System.Windows.Forms.Label();
            this.txtXMLCancelamento = new System.Windows.Forms.TextBox();
            this.btnXMLFimaFim = new System.Windows.Forms.Button();
            this.btnXMLVenda = new System.Windows.Forms.Button();
            this.btnCFeCancelamento = new System.Windows.Forms.Button();
            this.groupBoxConfiguracoes = new System.Windows.Forms.GroupBox();
            this.grpBoxRetorno.SuspendLayout();
            this.grpBoxFuncoes.SuspendLayout();
            this.groupBoxConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultaSAT
            // 
            this.btnConsultaSAT.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaSAT.Location = new System.Drawing.Point(6, 21);
            this.btnConsultaSAT.Name = "btnConsultaSAT";
            this.btnConsultaSAT.Size = new System.Drawing.Size(115, 40);
            this.btnConsultaSAT.TabIndex = 19;
            this.btnConsultaSAT.Text = "Consultar SAT";
            this.btnConsultaSAT.UseVisualStyleBackColor = true;
            this.btnConsultaSAT.Click += new System.EventHandler(this.btnConsultaSAT_Click);
            // 
            // btnConfigurarRede
            // 
            this.btnConfigurarRede.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarRede.Location = new System.Drawing.Point(140, 21);
            this.btnConfigurarRede.Name = "btnConfigurarRede";
            this.btnConfigurarRede.Size = new System.Drawing.Size(115, 40);
            this.btnConfigurarRede.TabIndex = 20;
            this.btnConfigurarRede.Text = "Configurar Rede";
            this.btnConfigurarRede.UseVisualStyleBackColor = true;
            this.btnConfigurarRede.Click += new System.EventHandler(this.btnConfigurarRede_Click);
            // 
            // btnAtivarSAT
            // 
            this.btnAtivarSAT.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivarSAT.Location = new System.Drawing.Point(276, 21);
            this.btnAtivarSAT.Name = "btnAtivarSAT";
            this.btnAtivarSAT.Size = new System.Drawing.Size(115, 40);
            this.btnAtivarSAT.TabIndex = 21;
            this.btnAtivarSAT.Text = "Ativar SAT";
            this.btnAtivarSAT.UseVisualStyleBackColor = true;
            this.btnAtivarSAT.Click += new System.EventHandler(this.btnAtivarSAT_Click);
            // 
            // btnVincularAC
            // 
            this.btnVincularAC.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincularAC.Location = new System.Drawing.Point(140, 72);
            this.btnVincularAC.Name = "btnVincularAC";
            this.btnVincularAC.Size = new System.Drawing.Size(115, 40);
            this.btnVincularAC.TabIndex = 22;
            this.btnVincularAC.Text = "Vincular AC";
            this.btnVincularAC.UseVisualStyleBackColor = true;
            this.btnVincularAC.Click += new System.EventHandler(this.btnVincularAC_Click);
            // 
            // btnFimaFim
            // 
            this.btnFimaFim.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFimaFim.Location = new System.Drawing.Point(276, 125);
            this.btnFimaFim.Name = "btnFimaFim";
            this.btnFimaFim.Size = new System.Drawing.Size(115, 40);
            this.btnFimaFim.TabIndex = 23;
            this.btnFimaFim.Text = "        Teste           Fim a Fim";
            this.btnFimaFim.UseVisualStyleBackColor = true;
            this.btnFimaFim.Click += new System.EventHandler(this.btnFimaFim_Click);
            // 
            // btnEstadoOperacional
            // 
            this.btnEstadoOperacional.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoOperacional.Location = new System.Drawing.Point(6, 72);
            this.btnEstadoOperacional.Name = "btnEstadoOperacional";
            this.btnEstadoOperacional.Size = new System.Drawing.Size(115, 40);
            this.btnEstadoOperacional.TabIndex = 24;
            this.btnEstadoOperacional.Text = "Estado Operacional";
            this.btnEstadoOperacional.UseVisualStyleBackColor = true;
            this.btnEstadoOperacional.Click += new System.EventHandler(this.btnEstadoOperacional_Click);
            // 
            // btnExtrairLOG
            // 
            this.btnExtrairLOG.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrairLOG.Location = new System.Drawing.Point(276, 72);
            this.btnExtrairLOG.Name = "btnExtrairLOG";
            this.btnExtrairLOG.Size = new System.Drawing.Size(115, 40);
            this.btnExtrairLOG.TabIndex = 28;
            this.btnExtrairLOG.Text = "Extrair LOG";
            this.btnExtrairLOG.UseVisualStyleBackColor = true;
            this.btnExtrairLOG.Click += new System.EventHandler(this.btnExtrairLOG_Click);
            // 
            // btnTrocarCodigo
            // 
            this.btnTrocarCodigo.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarCodigo.Location = new System.Drawing.Point(6, 235);
            this.btnTrocarCodigo.Name = "btnTrocarCodigo";
            this.btnTrocarCodigo.Size = new System.Drawing.Size(115, 40);
            this.btnTrocarCodigo.TabIndex = 29;
            this.btnTrocarCodigo.Text = "Trocar Código";
            this.btnTrocarCodigo.UseVisualStyleBackColor = true;
            this.btnTrocarCodigo.Click += new System.EventHandler(this.btnTrocarCodigo_Click);
            // 
            // btnAtualizarSoftware
            // 
            this.btnAtualizarSoftware.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarSoftware.Location = new System.Drawing.Point(6, 177);
            this.btnAtualizarSoftware.Name = "btnAtualizarSoftware";
            this.btnAtualizarSoftware.Size = new System.Drawing.Size(115, 40);
            this.btnAtualizarSoftware.TabIndex = 30;
            this.btnAtualizarSoftware.Text = "Atualizar Software";
            this.btnAtualizarSoftware.UseVisualStyleBackColor = true;
            this.btnAtualizarSoftware.Click += new System.EventHandler(this.btnAtualizarSoftware_Click);
            // 
            // btnDesbloquearSAT
            // 
            this.btnDesbloquearSAT.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquearSAT.Location = new System.Drawing.Point(276, 177);
            this.btnDesbloquearSAT.Name = "btnDesbloquearSAT";
            this.btnDesbloquearSAT.Size = new System.Drawing.Size(115, 40);
            this.btnDesbloquearSAT.TabIndex = 31;
            this.btnDesbloquearSAT.Text = "Desbloquear SAT";
            this.btnDesbloquearSAT.UseVisualStyleBackColor = true;
            this.btnDesbloquearSAT.Click += new System.EventHandler(this.btnDesbloquearSAT_Click);
            // 
            // btnEfetuarVenda
            // 
            this.btnEfetuarVenda.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuarVenda.Location = new System.Drawing.Point(6, 125);
            this.btnEfetuarVenda.Name = "btnEfetuarVenda";
            this.btnEfetuarVenda.Size = new System.Drawing.Size(115, 40);
            this.btnEfetuarVenda.TabIndex = 32;
            this.btnEfetuarVenda.Text = "Efetuar Venda";
            this.btnEfetuarVenda.UseVisualStyleBackColor = true;
            this.btnEfetuarVenda.Click += new System.EventHandler(this.btnEfetuarVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.Location = new System.Drawing.Point(140, 125);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(115, 40);
            this.btnCancelarVenda.TabIndex = 33;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // btnBloquearSAT
            // 
            this.btnBloquearSAT.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquearSAT.Location = new System.Drawing.Point(140, 177);
            this.btnBloquearSAT.Name = "btnBloquearSAT";
            this.btnBloquearSAT.Size = new System.Drawing.Size(115, 40);
            this.btnBloquearSAT.TabIndex = 34;
            this.btnBloquearSAT.Text = "Bloquear SAT";
            this.btnBloquearSAT.UseVisualStyleBackColor = true;
            this.btnBloquearSAT.Click += new System.EventHandler(this.btnBloquearSAT_Click);
            // 
            // btnConsultaNumeroSessao
            // 
            this.btnConsultaNumeroSessao.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaNumeroSessao.Location = new System.Drawing.Point(276, 235);
            this.btnConsultaNumeroSessao.Name = "btnConsultaNumeroSessao";
            this.btnConsultaNumeroSessao.Size = new System.Drawing.Size(115, 40);
            this.btnConsultaNumeroSessao.TabIndex = 35;
            this.btnConsultaNumeroSessao.Text = "Consulta Nº Sessão";
            this.btnConsultaNumeroSessao.UseVisualStyleBackColor = true;
            this.btnConsultaNumeroSessao.Click += new System.EventHandler(this.btnConsultaNumeroSessao_Click);
            // 
            // grpBoxRetorno
            // 
            this.grpBoxRetorno.Controls.Add(this.txtRetorno);
            this.grpBoxRetorno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRetorno.Location = new System.Drawing.Point(426, 12);
            this.grpBoxRetorno.Name = "grpBoxRetorno";
            this.grpBoxRetorno.Size = new System.Drawing.Size(452, 590);
            this.grpBoxRetorno.TabIndex = 43;
            this.grpBoxRetorno.TabStop = false;
            this.grpBoxRetorno.Text = "Retorno";
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(12, 19);
            this.txtRetorno.Multiline = true;
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRetorno.Size = new System.Drawing.Size(434, 565);
            this.txtRetorno.TabIndex = 3;
            // 
            // grpBoxFuncoes
            // 
            this.grpBoxFuncoes.Controls.Add(this.btnConsultaSAT);
            this.grpBoxFuncoes.Controls.Add(this.btnConfigurarRede);
            this.grpBoxFuncoes.Controls.Add(this.btnAtivarSAT);
            this.grpBoxFuncoes.Controls.Add(this.btnConsultaNumeroSessao);
            this.grpBoxFuncoes.Controls.Add(this.btnVincularAC);
            this.grpBoxFuncoes.Controls.Add(this.btnBloquearSAT);
            this.grpBoxFuncoes.Controls.Add(this.btnFimaFim);
            this.grpBoxFuncoes.Controls.Add(this.btnCancelarVenda);
            this.grpBoxFuncoes.Controls.Add(this.btnEstadoOperacional);
            this.grpBoxFuncoes.Controls.Add(this.btnEfetuarVenda);
            this.grpBoxFuncoes.Controls.Add(this.btnExtrairLOG);
            this.grpBoxFuncoes.Controls.Add(this.btnDesbloquearSAT);
            this.grpBoxFuncoes.Controls.Add(this.btnTrocarCodigo);
            this.grpBoxFuncoes.Controls.Add(this.btnAtualizarSoftware);
            this.grpBoxFuncoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFuncoes.Location = new System.Drawing.Point(12, 309);
            this.grpBoxFuncoes.Name = "grpBoxFuncoes";
            this.grpBoxFuncoes.Size = new System.Drawing.Size(408, 293);
            this.grpBoxFuncoes.TabIndex = 45;
            this.grpBoxFuncoes.TabStop = false;
            this.grpBoxFuncoes.Text = "Funções";
            // 
            // lblImportarDLL
            // 
            this.lblImportarDLL.AutoSize = true;
            this.lblImportarDLL.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportarDLL.Location = new System.Drawing.Point(5, 33);
            this.lblImportarDLL.Name = "lblImportarDLL";
            this.lblImportarDLL.Size = new System.Drawing.Size(94, 20);
            this.lblImportarDLL.TabIndex = 28;
            this.lblImportarDLL.Text = "Importar DLL:";
            // 
            // txtImportarDLL
            // 
            this.txtImportarDLL.Location = new System.Drawing.Point(168, 31);
            this.txtImportarDLL.Name = "txtImportarDLL";
            this.txtImportarDLL.ReadOnly = true;
            this.txtImportarDLL.Size = new System.Drawing.Size(182, 22);
            this.txtImportarDLL.TabIndex = 29;
            // 
            // btnImportarDLL
            // 
            this.btnImportarDLL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarDLL.Location = new System.Drawing.Point(364, 33);
            this.btnImportarDLL.Name = "btnImportarDLL";
            this.btnImportarDLL.Size = new System.Drawing.Size(29, 20);
            this.btnImportarDLL.TabIndex = 30;
            this.btnImportarDLL.Text = "...";
            this.btnImportarDLL.UseVisualStyleBackColor = true;
            this.btnImportarDLL.Click += new System.EventHandler(this.btnImportarDLL_Click);
            // 
            // lblCodigoAtivacao
            // 
            this.lblCodigoAtivacao.AutoSize = true;
            this.lblCodigoAtivacao.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAtivacao.Location = new System.Drawing.Point(5, 65);
            this.lblCodigoAtivacao.Name = "lblCodigoAtivacao";
            this.lblCodigoAtivacao.Size = new System.Drawing.Size(134, 20);
            this.lblCodigoAtivacao.TabIndex = 31;
            this.lblCodigoAtivacao.Text = "Código de Ativação:";
            // 
            // txtCodigoAtivacao
            // 
            this.txtCodigoAtivacao.Location = new System.Drawing.Point(168, 65);
            this.txtCodigoAtivacao.Name = "txtCodigoAtivacao";
            this.txtCodigoAtivacao.Size = new System.Drawing.Size(182, 22);
            this.txtCodigoAtivacao.TabIndex = 32;
            this.txtCodigoAtivacao.Text = "12345678";
            // 
            // lblCNPJSoftwareHouse
            // 
            this.lblCNPJSoftwareHouse.AutoSize = true;
            this.lblCNPJSoftwareHouse.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJSoftwareHouse.Location = new System.Drawing.Point(5, 96);
            this.lblCNPJSoftwareHouse.Name = "lblCNPJSoftwareHouse";
            this.lblCNPJSoftwareHouse.Size = new System.Drawing.Size(148, 20);
            this.lblCNPJSoftwareHouse.TabIndex = 33;
            this.lblCNPJSoftwareHouse.Text = "CNPJ Software House:";
            // 
            // txtCNPJSoftwareHouse
            // 
            this.txtCNPJSoftwareHouse.Location = new System.Drawing.Point(168, 96);
            this.txtCNPJSoftwareHouse.Name = "txtCNPJSoftwareHouse";
            this.txtCNPJSoftwareHouse.Size = new System.Drawing.Size(182, 22);
            this.txtCNPJSoftwareHouse.TabIndex = 34;
            this.txtCNPJSoftwareHouse.Text = "16716114000172";
            // 
            // lblCNPJContribuinte
            // 
            this.lblCNPJContribuinte.AutoSize = true;
            this.lblCNPJContribuinte.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJContribuinte.Location = new System.Drawing.Point(5, 128);
            this.lblCNPJContribuinte.Name = "lblCNPJContribuinte";
            this.lblCNPJContribuinte.Size = new System.Drawing.Size(128, 20);
            this.lblCNPJContribuinte.TabIndex = 35;
            this.lblCNPJContribuinte.Text = "CNPJ Contribuinte:";
            // 
            // txtCNPJContribuinte
            // 
            this.txtCNPJContribuinte.Location = new System.Drawing.Point(168, 128);
            this.txtCNPJContribuinte.Name = "txtCNPJContribuinte";
            this.txtCNPJContribuinte.Size = new System.Drawing.Size(182, 22);
            this.txtCNPJContribuinte.TabIndex = 36;
            this.txtCNPJContribuinte.Text = "08723218000186";
            // 
            // lblCodigoAC
            // 
            this.lblCodigoAC.AutoSize = true;
            this.lblCodigoAC.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAC.Location = new System.Drawing.Point(5, 158);
            this.lblCodigoAC.Name = "lblCodigoAC";
            this.lblCodigoAC.Size = new System.Drawing.Size(80, 20);
            this.lblCodigoAC.TabIndex = 37;
            this.lblCodigoAC.Text = "Codigo AC:";
            // 
            // txtCodigoAC
            // 
            this.txtCodigoAC.Location = new System.Drawing.Point(168, 158);
            this.txtCodigoAC.Name = "txtCodigoAC";
            this.txtCodigoAC.Size = new System.Drawing.Size(182, 22);
            this.txtCodigoAC.TabIndex = 38;
            this.txtCodigoAC.Text = "SGR-SAT SISTEMA DE GESTAO E RETAGUARDA DO SAT";
            // 
            // lblXMLFimaFim
            // 
            this.lblXMLFimaFim.AutoSize = true;
            this.lblXMLFimaFim.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMLFimaFim.Location = new System.Drawing.Point(5, 189);
            this.lblXMLFimaFim.Name = "lblXMLFimaFim";
            this.lblXMLFimaFim.Size = new System.Drawing.Size(108, 20);
            this.lblXMLFimaFim.TabIndex = 39;
            this.lblXMLFimaFim.Text = "XML Fim a Fim:";
            // 
            // txtXMLFimaFim
            // 
            this.txtXMLFimaFim.Location = new System.Drawing.Point(168, 189);
            this.txtXMLFimaFim.Name = "txtXMLFimaFim";
            this.txtXMLFimaFim.ReadOnly = true;
            this.txtXMLFimaFim.Size = new System.Drawing.Size(182, 22);
            this.txtXMLFimaFim.TabIndex = 40;
            // 
            // lblXMLVenda
            // 
            this.lblXMLVenda.AutoSize = true;
            this.lblXMLVenda.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMLVenda.Location = new System.Drawing.Point(5, 224);
            this.lblXMLVenda.Name = "lblXMLVenda";
            this.lblXMLVenda.Size = new System.Drawing.Size(84, 20);
            this.lblXMLVenda.TabIndex = 41;
            this.lblXMLVenda.Text = "XML Venda:";
            // 
            // txtXMLVenda
            // 
            this.txtXMLVenda.Location = new System.Drawing.Point(168, 224);
            this.txtXMLVenda.Name = "txtXMLVenda";
            this.txtXMLVenda.ReadOnly = true;
            this.txtXMLVenda.Size = new System.Drawing.Size(182, 22);
            this.txtXMLVenda.TabIndex = 42;
            // 
            // lblXMLCancelamento
            // 
            this.lblXMLCancelamento.AutoSize = true;
            this.lblXMLCancelamento.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMLCancelamento.Location = new System.Drawing.Point(5, 258);
            this.lblXMLCancelamento.Name = "lblXMLCancelamento";
            this.lblXMLCancelamento.Size = new System.Drawing.Size(145, 20);
            this.lblXMLCancelamento.TabIndex = 43;
            this.lblXMLCancelamento.Text = "CFe p/ Cancelamento:";
            // 
            // txtXMLCancelamento
            // 
            this.txtXMLCancelamento.Location = new System.Drawing.Point(168, 258);
            this.txtXMLCancelamento.Name = "txtXMLCancelamento";
            this.txtXMLCancelamento.ReadOnly = true;
            this.txtXMLCancelamento.Size = new System.Drawing.Size(182, 22);
            this.txtXMLCancelamento.TabIndex = 44;
            // 
            // btnXMLFimaFim
            // 
            this.btnXMLFimaFim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLFimaFim.Location = new System.Drawing.Point(364, 191);
            this.btnXMLFimaFim.Name = "btnXMLFimaFim";
            this.btnXMLFimaFim.Size = new System.Drawing.Size(29, 20);
            this.btnXMLFimaFim.TabIndex = 45;
            this.btnXMLFimaFim.Text = "...";
            this.btnXMLFimaFim.UseVisualStyleBackColor = true;
            this.btnXMLFimaFim.Click += new System.EventHandler(this.btnXMLFimaFim_Click);
            // 
            // btnXMLVenda
            // 
            this.btnXMLVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLVenda.Location = new System.Drawing.Point(364, 226);
            this.btnXMLVenda.Name = "btnXMLVenda";
            this.btnXMLVenda.Size = new System.Drawing.Size(29, 20);
            this.btnXMLVenda.TabIndex = 46;
            this.btnXMLVenda.Text = "...";
            this.btnXMLVenda.UseVisualStyleBackColor = true;
            this.btnXMLVenda.Click += new System.EventHandler(this.btnXMLVenda_Click);
            // 
            // btnCFeCancelamento
            // 
            this.btnCFeCancelamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFeCancelamento.Location = new System.Drawing.Point(364, 260);
            this.btnCFeCancelamento.Name = "btnCFeCancelamento";
            this.btnCFeCancelamento.Size = new System.Drawing.Size(29, 20);
            this.btnCFeCancelamento.TabIndex = 47;
            this.btnCFeCancelamento.Text = "...";
            this.btnCFeCancelamento.UseVisualStyleBackColor = true;
            this.btnCFeCancelamento.Click += new System.EventHandler(this.btnCFeCancelamento_Click);
            // 
            // groupBoxConfiguracoes
            // 
            this.groupBoxConfiguracoes.Controls.Add(this.lblImportarDLL);
            this.groupBoxConfiguracoes.Controls.Add(this.btnCFeCancelamento);
            this.groupBoxConfiguracoes.Controls.Add(this.lblCNPJContribuinte);
            this.groupBoxConfiguracoes.Controls.Add(this.btnXMLVenda);
            this.groupBoxConfiguracoes.Controls.Add(this.txtCNPJContribuinte);
            this.groupBoxConfiguracoes.Controls.Add(this.txtCNPJSoftwareHouse);
            this.groupBoxConfiguracoes.Controls.Add(this.btnXMLFimaFim);
            this.groupBoxConfiguracoes.Controls.Add(this.lblCodigoAC);
            this.groupBoxConfiguracoes.Controls.Add(this.lblCNPJSoftwareHouse);
            this.groupBoxConfiguracoes.Controls.Add(this.txtXMLCancelamento);
            this.groupBoxConfiguracoes.Controls.Add(this.txtCodigoAC);
            this.groupBoxConfiguracoes.Controls.Add(this.txtCodigoAtivacao);
            this.groupBoxConfiguracoes.Controls.Add(this.lblXMLCancelamento);
            this.groupBoxConfiguracoes.Controls.Add(this.lblXMLFimaFim);
            this.groupBoxConfiguracoes.Controls.Add(this.lblCodigoAtivacao);
            this.groupBoxConfiguracoes.Controls.Add(this.txtXMLVenda);
            this.groupBoxConfiguracoes.Controls.Add(this.txtXMLFimaFim);
            this.groupBoxConfiguracoes.Controls.Add(this.txtImportarDLL);
            this.groupBoxConfiguracoes.Controls.Add(this.btnImportarDLL);
            this.groupBoxConfiguracoes.Controls.Add(this.lblXMLVenda);
            this.groupBoxConfiguracoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConfiguracoes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfiguracoes.Name = "groupBoxConfiguracoes";
            this.groupBoxConfiguracoes.Size = new System.Drawing.Size(408, 292);
            this.groupBoxConfiguracoes.TabIndex = 48;
            this.groupBoxConfiguracoes.TabStop = false;
            this.groupBoxConfiguracoes.Text = "Configurações";
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 618);
            this.Controls.Add(this.groupBoxConfiguracoes);
            this.Controls.Add(this.grpBoxFuncoes);
            this.Controls.Add(this.grpBoxRetorno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo  C#  SAT  -  T A N C A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tela_Principal_FormClosing);
            this.grpBoxRetorno.ResumeLayout(false);
            this.grpBoxRetorno.PerformLayout();
            this.grpBoxFuncoes.ResumeLayout(false);
            this.groupBoxConfiguracoes.ResumeLayout(false);
            this.groupBoxConfiguracoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsultaSAT;
        private System.Windows.Forms.Button btnAtivarSAT;
        private System.Windows.Forms.Button btnVincularAC;
        private System.Windows.Forms.Button btnFimaFim;
        private System.Windows.Forms.Button btnEstadoOperacional;
        private System.Windows.Forms.Button btnExtrairLOG;
        private System.Windows.Forms.Button btnTrocarCodigo;
        private System.Windows.Forms.Button btnAtualizarSoftware;
        private System.Windows.Forms.Button btnDesbloquearSAT;
        private System.Windows.Forms.Button btnEfetuarVenda;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnBloquearSAT;
        private System.Windows.Forms.Button btnConsultaNumeroSessao;
        private GroupBox grpBoxRetorno;
        private GroupBox grpBoxFuncoes;
        private Label lblImportarDLL;
        private TextBox txtImportarDLL;
        private Button btnImportarDLL;
        private Label lblCodigoAtivacao;
        private TextBox txtCodigoAtivacao;
        private Label lblCNPJSoftwareHouse;
        private TextBox txtCNPJSoftwareHouse;
        private Label lblCNPJContribuinte;
        private TextBox txtCNPJContribuinte;
        private Label lblCodigoAC;
        private TextBox txtCodigoAC;
        private Label lblXMLFimaFim;
        private TextBox txtXMLFimaFim;
        private Label lblXMLVenda;
        private TextBox txtXMLVenda;
        private Label lblXMLCancelamento;
        private TextBox txtXMLCancelamento;
        private Button btnXMLFimaFim;
        private Button btnXMLVenda;
        private Button btnCFeCancelamento;
        private GroupBox groupBoxConfiguracoes;
        private TextBox txtRetorno;
        public Button btnConfigurarRede;
    }
}

