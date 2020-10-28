namespace ExemploSAT
{
    partial class Configurar_Rede
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
            this.lblCodigoAtivacao = new System.Windows.Forms.Label();
            this.txtCodAtivacao = new System.Windows.Forms.TextBox();
            this.lblConfigRedeSAT = new System.Windows.Forms.Label();
            this.cbbInterface = new System.Windows.Forms.ComboBox();
            this.lblInterface = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblMaskRede = new System.Windows.Forms.Label();
            this.txtMaskRede = new System.Windows.Forms.TextBox();
            this.lblGateway = new System.Windows.Forms.Label();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.lblDNS1 = new System.Windows.Forms.Label();
            this.txtDNS1 = new System.Windows.Forms.TextBox();
            this.lblDNS2 = new System.Windows.Forms.Label();
            this.txtDNS2 = new System.Windows.Forms.TextBox();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.txtSenhaProxy = new System.Windows.Forms.TextBox();
            this.lblSenhaProxy = new System.Windows.Forms.Label();
            this.txtUsuarioProxy = new System.Windows.Forms.TextBox();
            this.lblUsuarioProxy = new System.Windows.Forms.Label();
            this.txtPortaProxy = new System.Windows.Forms.TextBox();
            this.lblPortaProxy = new System.Windows.Forms.Label();
            this.txtIPProxy = new System.Windows.Forms.TextBox();
            this.lblIPProxy = new System.Windows.Forms.Label();
            this.lblProxy = new System.Windows.Forms.Label();
            this.lblTipoRede = new System.Windows.Forms.Label();
            this.cbbTipoDeRede = new System.Windows.Forms.ComboBox();
            this.cbbProxy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCodigoAtivacao
            // 
            this.lblCodigoAtivacao.AutoSize = true;
            this.lblCodigoAtivacao.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAtivacao.Location = new System.Drawing.Point(16, 43);
            this.lblCodigoAtivacao.Name = "lblCodigoAtivacao";
            this.lblCodigoAtivacao.Size = new System.Drawing.Size(134, 20);
            this.lblCodigoAtivacao.TabIndex = 0;
            this.lblCodigoAtivacao.Text = "Codigo de Ativação:";
            // 
            // txtCodAtivacao
            // 
            this.txtCodAtivacao.Location = new System.Drawing.Point(159, 45);
            this.txtCodAtivacao.Name = "txtCodAtivacao";
            this.txtCodAtivacao.Size = new System.Drawing.Size(155, 20);
            this.txtCodAtivacao.TabIndex = 1;
            this.txtCodAtivacao.Text = "12345678";
            // 
            // lblConfigRedeSAT
            // 
            this.lblConfigRedeSAT.AutoSize = true;
            this.lblConfigRedeSAT.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigRedeSAT.Location = new System.Drawing.Point(16, 86);
            this.lblConfigRedeSAT.Name = "lblConfigRedeSAT";
            this.lblConfigRedeSAT.Size = new System.Drawing.Size(148, 20);
            this.lblConfigRedeSAT.TabIndex = 2;
            this.lblConfigRedeSAT.Text = "Configurar Rede - SAT";
            // 
            // cbbInterface
            // 
            this.cbbInterface.FormattingEnabled = true;
            this.cbbInterface.Items.AddRange(new object[] {
            "IP Fixo",
            "DHCP"});
            this.cbbInterface.Location = new System.Drawing.Point(104, 121);
            this.cbbInterface.Name = "cbbInterface";
            this.cbbInterface.Size = new System.Drawing.Size(121, 21);
            this.cbbInterface.TabIndex = 3;
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterface.Location = new System.Drawing.Point(16, 122);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(65, 20);
            this.lblInterface.TabIndex = 4;
            this.lblInterface.Text = "Interface:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(16, 156);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(25, 20);
            this.lblIP.TabIndex = 5;
            this.lblIP.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(104, 155);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(121, 20);
            this.txtIP.TabIndex = 6;
            // 
            // lblMaskRede
            // 
            this.lblMaskRede.AutoSize = true;
            this.lblMaskRede.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaskRede.Location = new System.Drawing.Point(16, 188);
            this.lblMaskRede.Name = "lblMaskRede";
            this.lblMaskRede.Size = new System.Drawing.Size(84, 20);
            this.lblMaskRede.TabIndex = 7;
            this.lblMaskRede.Text = "Mask. Rede:";
            // 
            // txtMaskRede
            // 
            this.txtMaskRede.Location = new System.Drawing.Point(104, 187);
            this.txtMaskRede.Name = "txtMaskRede";
            this.txtMaskRede.Size = new System.Drawing.Size(121, 20);
            this.txtMaskRede.TabIndex = 8;
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateway.Location = new System.Drawing.Point(16, 220);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(65, 20);
            this.lblGateway.TabIndex = 9;
            this.lblGateway.Text = "Gateway:";
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(104, 219);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(121, 20);
            this.txtGateway.TabIndex = 10;
            // 
            // lblDNS1
            // 
            this.lblDNS1.AutoSize = true;
            this.lblDNS1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNS1.Location = new System.Drawing.Point(16, 252);
            this.lblDNS1.Name = "lblDNS1";
            this.lblDNS1.Size = new System.Drawing.Size(51, 20);
            this.lblDNS1.TabIndex = 11;
            this.lblDNS1.Text = "DNS 1:";
            // 
            // txtDNS1
            // 
            this.txtDNS1.Location = new System.Drawing.Point(104, 251);
            this.txtDNS1.Name = "txtDNS1";
            this.txtDNS1.Size = new System.Drawing.Size(121, 20);
            this.txtDNS1.TabIndex = 12;
            // 
            // lblDNS2
            // 
            this.lblDNS2.AutoSize = true;
            this.lblDNS2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNS2.Location = new System.Drawing.Point(16, 285);
            this.lblDNS2.Name = "lblDNS2";
            this.lblDNS2.Size = new System.Drawing.Size(51, 20);
            this.lblDNS2.TabIndex = 13;
            this.lblDNS2.Text = "DNS 2:";
            // 
            // txtDNS2
            // 
            this.txtDNS2.Location = new System.Drawing.Point(104, 284);
            this.txtDNS2.Name = "txtDNS2";
            this.txtDNS2.Size = new System.Drawing.Size(121, 20);
            this.txtDNS2.TabIndex = 14;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.Location = new System.Drawing.Point(192, 323);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(106, 43);
            this.btnConfigurar.TabIndex = 15;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // txtSenhaProxy
            // 
            this.txtSenhaProxy.Location = new System.Drawing.Point(360, 284);
            this.txtSenhaProxy.Name = "txtSenhaProxy";
            this.txtSenhaProxy.Size = new System.Drawing.Size(121, 20);
            this.txtSenhaProxy.TabIndex = 27;
            // 
            // lblSenhaProxy
            // 
            this.lblSenhaProxy.AutoSize = true;
            this.lblSenhaProxy.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaProxy.Location = new System.Drawing.Point(249, 285);
            this.lblSenhaProxy.Name = "lblSenhaProxy";
            this.lblSenhaProxy.Size = new System.Drawing.Size(92, 20);
            this.lblSenhaProxy.TabIndex = 26;
            this.lblSenhaProxy.Text = "Senha Proxy:";
            // 
            // txtUsuarioProxy
            // 
            this.txtUsuarioProxy.Location = new System.Drawing.Point(360, 251);
            this.txtUsuarioProxy.Name = "txtUsuarioProxy";
            this.txtUsuarioProxy.Size = new System.Drawing.Size(121, 20);
            this.txtUsuarioProxy.TabIndex = 25;
            // 
            // lblUsuarioProxy
            // 
            this.lblUsuarioProxy.AutoSize = true;
            this.lblUsuarioProxy.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioProxy.Location = new System.Drawing.Point(249, 252);
            this.lblUsuarioProxy.Name = "lblUsuarioProxy";
            this.lblUsuarioProxy.Size = new System.Drawing.Size(101, 20);
            this.lblUsuarioProxy.TabIndex = 24;
            this.lblUsuarioProxy.Text = "Usuário Proxy:";
            // 
            // txtPortaProxy
            // 
            this.txtPortaProxy.Location = new System.Drawing.Point(360, 219);
            this.txtPortaProxy.Name = "txtPortaProxy";
            this.txtPortaProxy.Size = new System.Drawing.Size(121, 20);
            this.txtPortaProxy.TabIndex = 23;
            // 
            // lblPortaProxy
            // 
            this.lblPortaProxy.AutoSize = true;
            this.lblPortaProxy.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortaProxy.Location = new System.Drawing.Point(249, 220);
            this.lblPortaProxy.Name = "lblPortaProxy";
            this.lblPortaProxy.Size = new System.Drawing.Size(106, 20);
            this.lblPortaProxy.TabIndex = 22;
            this.lblPortaProxy.Text = "Porta do Proxy:";
            // 
            // txtIPProxy
            // 
            this.txtIPProxy.Location = new System.Drawing.Point(360, 187);
            this.txtIPProxy.Name = "txtIPProxy";
            this.txtIPProxy.Size = new System.Drawing.Size(121, 20);
            this.txtIPProxy.TabIndex = 21;
            // 
            // lblIPProxy
            // 
            this.lblIPProxy.AutoSize = true;
            this.lblIPProxy.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPProxy.Location = new System.Drawing.Point(249, 188);
            this.lblIPProxy.Name = "lblIPProxy";
            this.lblIPProxy.Size = new System.Drawing.Size(65, 20);
            this.lblIPProxy.TabIndex = 20;
            this.lblIPProxy.Text = "IP Proxy:";
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxy.Location = new System.Drawing.Point(249, 156);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(49, 20);
            this.lblProxy.TabIndex = 18;
            this.lblProxy.Text = "Proxy:";
            // 
            // lblTipoRede
            // 
            this.lblTipoRede.AutoSize = true;
            this.lblTipoRede.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRede.Location = new System.Drawing.Point(249, 122);
            this.lblTipoRede.Name = "lblTipoRede";
            this.lblTipoRede.Size = new System.Drawing.Size(95, 20);
            this.lblTipoRede.TabIndex = 17;
            this.lblTipoRede.Text = "Tipo de Rede:";
            // 
            // cbbTipoDeRede
            // 
            this.cbbTipoDeRede.FormattingEnabled = true;
            this.cbbTipoDeRede.Items.AddRange(new object[] {
            "Ethernet"});
            this.cbbTipoDeRede.Location = new System.Drawing.Point(360, 121);
            this.cbbTipoDeRede.Name = "cbbTipoDeRede";
            this.cbbTipoDeRede.Size = new System.Drawing.Size(121, 21);
            this.cbbTipoDeRede.TabIndex = 28;
            // 
            // cbbProxy
            // 
            this.cbbProxy.FormattingEnabled = true;
            this.cbbProxy.Items.AddRange(new object[] {
            "Nenhum",
            "Com configuração",
            "Transparente"});
            this.cbbProxy.Location = new System.Drawing.Point(360, 155);
            this.cbbProxy.Name = "cbbProxy";
            this.cbbProxy.Size = new System.Drawing.Size(121, 21);
            this.cbbProxy.TabIndex = 29;
            // 
            // Configurar_Rede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 378);
            this.Controls.Add(this.cbbProxy);
            this.Controls.Add(this.cbbTipoDeRede);
            this.Controls.Add(this.txtSenhaProxy);
            this.Controls.Add(this.lblSenhaProxy);
            this.Controls.Add(this.txtUsuarioProxy);
            this.Controls.Add(this.lblUsuarioProxy);
            this.Controls.Add(this.txtPortaProxy);
            this.Controls.Add(this.lblPortaProxy);
            this.Controls.Add(this.txtIPProxy);
            this.Controls.Add(this.lblIPProxy);
            this.Controls.Add(this.lblProxy);
            this.Controls.Add(this.lblTipoRede);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.txtDNS2);
            this.Controls.Add(this.lblDNS2);
            this.Controls.Add(this.txtDNS1);
            this.Controls.Add(this.lblDNS1);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.txtMaskRede);
            this.Controls.Add(this.lblMaskRede);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblInterface);
            this.Controls.Add(this.cbbInterface);
            this.Controls.Add(this.lblConfigRedeSAT);
            this.Controls.Add(this.txtCodAtivacao);
            this.Controls.Add(this.lblCodigoAtivacao);
            this.Name = "Configurar_Rede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Rede";
            this.Load += new System.EventHandler(this.Configurar_Rede_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoAtivacao;
        private System.Windows.Forms.TextBox txtCodAtivacao;
        private System.Windows.Forms.Label lblConfigRedeSAT;
        private System.Windows.Forms.ComboBox cbbInterface;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblMaskRede;
        private System.Windows.Forms.TextBox txtMaskRede;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Label lblDNS1;
        private System.Windows.Forms.TextBox txtDNS1;
        private System.Windows.Forms.Label lblDNS2;
        private System.Windows.Forms.TextBox txtDNS2;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.TextBox txtSenhaProxy;
        private System.Windows.Forms.Label lblSenhaProxy;
        private System.Windows.Forms.TextBox txtUsuarioProxy;
        private System.Windows.Forms.Label lblUsuarioProxy;
        private System.Windows.Forms.TextBox txtPortaProxy;
        private System.Windows.Forms.Label lblPortaProxy;
        private System.Windows.Forms.TextBox txtIPProxy;
        private System.Windows.Forms.Label lblIPProxy;
        private System.Windows.Forms.Label lblProxy;
        private System.Windows.Forms.Label lblTipoRede;
        private System.Windows.Forms.ComboBox cbbTipoDeRede;
        private System.Windows.Forms.ComboBox cbbProxy;
    }
}