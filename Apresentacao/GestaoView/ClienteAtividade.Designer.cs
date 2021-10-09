
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
            this.btnAngedarAtv = new System.Windows.Forms.Button();
            this.btnControleVagas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroCli
            // 
            this.btnCadastroCli.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroCli.Location = new System.Drawing.Point(57, 78);
            this.btnCadastroCli.Name = "btnCadastroCli";
            this.btnCadastroCli.Size = new System.Drawing.Size(160, 71);
            this.btnCadastroCli.TabIndex = 0;
            this.btnCadastroCli.Text = "Cadastro de Cliente";
            this.btnCadastroCli.UseVisualStyleBackColor = true;
            this.btnCadastroCli.Click += new System.EventHandler(this.btnCadastroCli_Click);
            // 
            // btnAgendaQuartos
            // 
            this.btnAgendaQuartos.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgendaQuartos.Location = new System.Drawing.Point(257, 78);
            this.btnAgendaQuartos.Name = "btnAgendaQuartos";
            this.btnAgendaQuartos.Size = new System.Drawing.Size(151, 70);
            this.btnAgendaQuartos.TabIndex = 1;
            this.btnAgendaQuartos.Text = "Agendamento de Quartos";
            this.btnAgendaQuartos.UseVisualStyleBackColor = true;
            // 
            // btnAngedarAtv
            // 
            this.btnAngedarAtv.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAngedarAtv.Location = new System.Drawing.Point(57, 196);
            this.btnAngedarAtv.Name = "btnAngedarAtv";
            this.btnAngedarAtv.Size = new System.Drawing.Size(160, 77);
            this.btnAngedarAtv.TabIndex = 2;
            this.btnAngedarAtv.Text = "Agendamento de Atividade";
            this.btnAngedarAtv.UseVisualStyleBackColor = true;
            // 
            // btnControleVagas
            // 
            this.btnControleVagas.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnControleVagas.Location = new System.Drawing.Point(257, 196);
            this.btnControleVagas.Name = "btnControleVagas";
            this.btnControleVagas.Size = new System.Drawing.Size(151, 76);
            this.btnControleVagas.TabIndex = 3;
            this.btnControleVagas.Text = "Controle de Vagas";
            this.btnControleVagas.UseVisualStyleBackColor = true;
            // 
            // ClienteAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 342);
            this.Controls.Add(this.btnControleVagas);
            this.Controls.Add(this.btnAngedarAtv);
            this.Controls.Add(this.btnAgendaQuartos);
            this.Controls.Add(this.btnCadastroCli);
            this.Name = "ClienteAtividade";
            this.Text = "ClienteAtividade";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCli;
        private System.Windows.Forms.Button btnAgendaQuartos;
        private System.Windows.Forms.Button btnAngedarAtv;
        private System.Windows.Forms.Button btnControleVagas;
    }
}