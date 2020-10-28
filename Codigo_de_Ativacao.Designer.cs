namespace ExemploSAT
{
    partial class Codigo_de_Ativacao
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
            this.chkCodEmergencia = new System.Windows.Forms.CheckBox();
            this.txtCodEmergencia = new System.Windows.Forms.TextBox();
            this.lblCodAtivacao = new System.Windows.Forms.Label();
            this.lblNovoCodigo = new System.Windows.Forms.Label();
            this.txtCodAtivacao = new System.Windows.Forms.TextBox();
            this.txtNovoCodigo = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblConfCodigo = new System.Windows.Forms.Label();
            this.txtConfirmarCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkCodEmergencia
            // 
            this.chkCodEmergencia.AutoSize = true;
            this.chkCodEmergencia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCodEmergencia.Location = new System.Drawing.Point(34, 11);
            this.chkCodEmergencia.Name = "chkCodEmergencia";
            this.chkCodEmergencia.Size = new System.Drawing.Size(170, 20);
            this.chkCodEmergencia.TabIndex = 0;
            this.chkCodEmergencia.Text = "Usar código de emergência";
            this.chkCodEmergencia.UseVisualStyleBackColor = true;
            this.chkCodEmergencia.CheckedChanged += new System.EventHandler(this.chkCodEmergencia_CheckedChanged);
            // 
            // txtCodEmergencia
            // 
            this.txtCodEmergencia.Location = new System.Drawing.Point(34, 37);
            this.txtCodEmergencia.Name = "txtCodEmergencia";
            this.txtCodEmergencia.Size = new System.Drawing.Size(237, 20);
            this.txtCodEmergencia.TabIndex = 1;
            // 
            // lblCodAtivacao
            // 
            this.lblCodAtivacao.AutoSize = true;
            this.lblCodAtivacao.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAtivacao.Location = new System.Drawing.Point(26, 72);
            this.lblCodAtivacao.Name = "lblCodAtivacao";
            this.lblCodAtivacao.Size = new System.Drawing.Size(116, 16);
            this.lblCodAtivacao.TabIndex = 2;
            this.lblCodAtivacao.Text = "Código de Ativação:";
            // 
            // lblNovoCodigo
            // 
            this.lblNovoCodigo.AutoSize = true;
            this.lblNovoCodigo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoCodigo.Location = new System.Drawing.Point(26, 98);
            this.lblNovoCodigo.Name = "lblNovoCodigo";
            this.lblNovoCodigo.Size = new System.Drawing.Size(82, 16);
            this.lblNovoCodigo.TabIndex = 3;
            this.lblNovoCodigo.Text = "Novo Código:";
            // 
            // txtCodAtivacao
            // 
            this.txtCodAtivacao.Location = new System.Drawing.Point(142, 71);
            this.txtCodAtivacao.Name = "txtCodAtivacao";
            this.txtCodAtivacao.Size = new System.Drawing.Size(129, 20);
            this.txtCodAtivacao.TabIndex = 4;
            // 
            // txtNovoCodigo
            // 
            this.txtNovoCodigo.Location = new System.Drawing.Point(142, 97);
            this.txtNovoCodigo.Name = "txtNovoCodigo";
            this.txtNovoCodigo.Size = new System.Drawing.Size(129, 20);
            this.txtNovoCodigo.TabIndex = 5;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(120, 158);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 25);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblConfCodigo
            // 
            this.lblConfCodigo.AutoSize = true;
            this.lblConfCodigo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfCodigo.Location = new System.Drawing.Point(26, 124);
            this.lblConfCodigo.Name = "lblConfCodigo";
            this.lblConfCodigo.Size = new System.Drawing.Size(106, 16);
            this.lblConfCodigo.TabIndex = 8;
            this.lblConfCodigo.Text = "Confirmar Código:";
            // 
            // txtConfirmarCodigo
            // 
            this.txtConfirmarCodigo.Location = new System.Drawing.Point(142, 123);
            this.txtConfirmarCodigo.Name = "txtConfirmarCodigo";
            this.txtConfirmarCodigo.Size = new System.Drawing.Size(129, 20);
            this.txtConfirmarCodigo.TabIndex = 9;
            // 
            // Codigo_de_Ativacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 195);
            this.Controls.Add(this.txtConfirmarCodigo);
            this.Controls.Add(this.lblConfCodigo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtNovoCodigo);
            this.Controls.Add(this.txtCodAtivacao);
            this.Controls.Add(this.lblNovoCodigo);
            this.Controls.Add(this.lblCodAtivacao);
            this.Controls.Add(this.txtCodEmergencia);
            this.Controls.Add(this.chkCodEmergencia);
            this.Name = "Codigo_de_Ativacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Código de Ativação";
            this.Load += new System.EventHandler(this.Codigo_de_Ativacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCodEmergencia;
        private System.Windows.Forms.TextBox txtCodEmergencia;
        private System.Windows.Forms.Label lblCodAtivacao;
        private System.Windows.Forms.Label lblNovoCodigo;
        private System.Windows.Forms.TextBox txtCodAtivacao;
        private System.Windows.Forms.TextBox txtNovoCodigo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblConfCodigo;
        private System.Windows.Forms.TextBox txtConfirmarCodigo;
    }
}