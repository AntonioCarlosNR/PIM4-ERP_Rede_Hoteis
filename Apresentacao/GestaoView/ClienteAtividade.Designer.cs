
namespace PIM4.Apresentacao.GestaoView
{
    partial class ClienteAtividade
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
            this.btnCadastroCli = new System.Windows.Forms.Button();
            this.btnAgendaQuartos = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroCli
            // 
            this.btnCadastroCli.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroCli.Location = new System.Drawing.Point(43, 73);
            this.btnCadastroCli.Name = "btnCadastroCli";
            this.btnCadastroCli.Size = new System.Drawing.Size(184, 160);
            this.btnCadastroCli.TabIndex = 0;
            this.btnCadastroCli.Text = "Cadastro de Cliente/Usuário";
            this.btnCadastroCli.UseVisualStyleBackColor = true;
            this.btnCadastroCli.Click += new System.EventHandler(this.btnCadastroCli_Click);
            // 
            // btnAgendaQuartos
            // 
            this.btnAgendaQuartos.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgendaQuartos.Location = new System.Drawing.Point(292, 73);
            this.btnAgendaQuartos.Name = "btnAgendaQuartos";
            this.btnAgendaQuartos.Size = new System.Drawing.Size(183, 160);
            this.btnAgendaQuartos.TabIndex = 1;
            this.btnAgendaQuartos.Text = "Agendamento de Quartos";
            this.btnAgendaQuartos.UseVisualStyleBackColor = true;
            this.btnAgendaQuartos.Click += new System.EventHandler(this.btnAgendaQuartos_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.Location = new System.Drawing.Point(82, 269);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(145, 29);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(292, 269);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(145, 29);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair do Sistema";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ClienteAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 332);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnAgendaQuartos);
            this.Controls.Add(this.btnCadastroCli);
            this.Name = "ClienteAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteAtividade";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCli;
        private System.Windows.Forms.Button btnAgendaQuartos;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSair;
    }
}