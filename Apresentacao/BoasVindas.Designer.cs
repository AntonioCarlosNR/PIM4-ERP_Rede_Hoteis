
namespace PIM4.Apresentacao
{
    partial class BoasVindas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblGestao = new System.Windows.Forms.Label();
            this.btnCliAtv = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo ao Sistema de gerenciamento!!!";
            // 
            // lblGestao
            // 
            this.lblGestao.AutoSize = true;
            this.lblGestao.Font = new System.Drawing.Font("Calisto MT", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGestao.Location = new System.Drawing.Point(334, 92);
            this.lblGestao.Name = "lblGestao";
            this.lblGestao.Size = new System.Drawing.Size(128, 39);
            this.lblGestao.TabIndex = 1;
            this.lblGestao.Text = "Gestão ";
            // 
            // btnCliAtv
            // 
            this.btnCliAtv.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCliAtv.Location = new System.Drawing.Point(73, 196);
            this.btnCliAtv.Name = "btnCliAtv";
            this.btnCliAtv.Size = new System.Drawing.Size(175, 111);
            this.btnCliAtv.TabIndex = 2;
            this.btnCliAtv.Text = "Clientes/Atividades";
            this.btnCliAtv.UseVisualStyleBackColor = true;
            this.btnCliAtv.Click += new System.EventHandler(this.btnCliAtv_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdm.Location = new System.Drawing.Point(312, 196);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(170, 111);
            this.btnAdm.TabIndex = 3;
            this.btnAdm.Text = "Administrativo";
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinanceiro.Location = new System.Drawing.Point(544, 196);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(179, 111);
            this.btnFinanceiro.TabIndex = 4;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(312, 399);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(170, 29);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair do sistema";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // BoasVindas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.btnCliAtv);
            this.Controls.Add(this.lblGestao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BoasVindas";
            this.Text = "BoasVindas";
            this.Load += new System.EventHandler(this.BoasVindas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGestao;
        private System.Windows.Forms.Button btnCliAtv;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnSair;
    }
}