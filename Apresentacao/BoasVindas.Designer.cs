
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
            this.lblInfra = new System.Windows.Forms.Label();
            this.btnControleMat = new System.Windows.Forms.Button();
            this.btnAlertaRecurso = new System.Windows.Forms.Button();
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
            this.lblGestao.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGestao.Location = new System.Drawing.Point(355, 61);
            this.lblGestao.Name = "lblGestao";
            this.lblGestao.Size = new System.Drawing.Size(105, 32);
            this.lblGestao.TabIndex = 1;
            this.lblGestao.Text = "Gestão ";
            // 
            // btnCliAtv
            // 
            this.btnCliAtv.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCliAtv.Location = new System.Drawing.Point(86, 135);
            this.btnCliAtv.Name = "btnCliAtv";
            this.btnCliAtv.Size = new System.Drawing.Size(175, 57);
            this.btnCliAtv.TabIndex = 2;
            this.btnCliAtv.Text = "Clientes/Atividades";
            this.btnCliAtv.UseVisualStyleBackColor = true;
            this.btnCliAtv.Click += new System.EventHandler(this.btnCliAtv_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdm.Location = new System.Drawing.Point(339, 135);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(141, 57);
            this.btnAdm.TabIndex = 3;
            this.btnAdm.Text = "Administrativo";
            this.btnAdm.UseVisualStyleBackColor = true;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinanceiro.Location = new System.Drawing.Point(555, 135);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(148, 55);
            this.btnFinanceiro.TabIndex = 4;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            // 
            // lblInfra
            // 
            this.lblInfra.AutoSize = true;
            this.lblInfra.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfra.Location = new System.Drawing.Point(323, 243);
            this.lblInfra.Name = "lblInfra";
            this.lblInfra.Size = new System.Drawing.Size(175, 32);
            this.lblInfra.TabIndex = 5;
            this.lblInfra.Text = "Infraestrutura";
            // 
            // btnControleMat
            // 
            this.btnControleMat.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnControleMat.Location = new System.Drawing.Point(86, 307);
            this.btnControleMat.Name = "btnControleMat";
            this.btnControleMat.Size = new System.Drawing.Size(175, 69);
            this.btnControleMat.TabIndex = 6;
            this.btnControleMat.Text = "Controle de entrada e saída de materiais";
            this.btnControleMat.UseVisualStyleBackColor = true;
            // 
            // btnAlertaRecurso
            // 
            this.btnAlertaRecurso.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlertaRecurso.Location = new System.Drawing.Point(339, 307);
            this.btnAlertaRecurso.Name = "btnAlertaRecurso";
            this.btnAlertaRecurso.Size = new System.Drawing.Size(141, 69);
            this.btnAlertaRecurso.TabIndex = 7;
            this.btnAlertaRecurso.Text = "Alerta de falta de recurso";
            this.btnAlertaRecurso.UseVisualStyleBackColor = true;
            // 
            // BoasVindas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlertaRecurso);
            this.Controls.Add(this.btnControleMat);
            this.Controls.Add(this.lblInfra);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.btnCliAtv);
            this.Controls.Add(this.lblGestao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BoasVindas";
            this.Text = "BoasVindas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGestao;
        private System.Windows.Forms.Button btnCliAtv;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Label lblInfra;
        private System.Windows.Forms.Button btnControleMat;
        private System.Windows.Forms.Button btnAlertaRecurso;
    }
}