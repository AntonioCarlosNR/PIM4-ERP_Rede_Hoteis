﻿
namespace PIM4.Apresentacao.GestaoView.CliAtvModelo
{
    partial class AgendamentoQuartos
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
            this.lblNomeHospede = new System.Windows.Forms.Label();
            this.txtNomeHospede = new System.Windows.Forms.TextBox();
            this.lblQtdPessoas = new System.Windows.Forms.Label();
            this.txtQtdPessoas = new System.Windows.Forms.TextBox();
            this.dtcheckin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCheckout = new System.Windows.Forms.DateTimePicker();
            this.lblChechOut = new System.Windows.Forms.Label();
            this.btnAgendarQuarto = new System.Windows.Forms.Button();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomeHospede
            // 
            this.lblNomeHospede.AutoSize = true;
            this.lblNomeHospede.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeHospede.Location = new System.Drawing.Point(38, 53);
            this.lblNomeHospede.Name = "lblNomeHospede";
            this.lblNomeHospede.Size = new System.Drawing.Size(155, 21);
            this.lblNomeHospede.TabIndex = 0;
            this.lblNomeHospede.Text = "Nome do Hospede";
            this.lblNomeHospede.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeHospede
            // 
            this.txtNomeHospede.Location = new System.Drawing.Point(199, 51);
            this.txtNomeHospede.Name = "txtNomeHospede";
            this.txtNomeHospede.Size = new System.Drawing.Size(312, 27);
            this.txtNomeHospede.TabIndex = 1;
            // 
            // lblQtdPessoas
            // 
            this.lblQtdPessoas.AutoSize = true;
            this.lblQtdPessoas.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQtdPessoas.Location = new System.Drawing.Point(7, 112);
            this.lblQtdPessoas.Name = "lblQtdPessoas";
            this.lblQtdPessoas.Size = new System.Drawing.Size(186, 21);
            this.lblQtdPessoas.TabIndex = 2;
            this.lblQtdPessoas.Text = "Quantidade de pessoas";
            // 
            // txtQtdPessoas
            // 
            this.txtQtdPessoas.Location = new System.Drawing.Point(199, 112);
            this.txtQtdPessoas.Name = "txtQtdPessoas";
            this.txtQtdPessoas.Size = new System.Drawing.Size(65, 27);
            this.txtQtdPessoas.TabIndex = 3;
            // 
            // dtcheckin
            // 
            this.dtcheckin.Location = new System.Drawing.Point(199, 205);
            this.dtcheckin.Name = "dtcheckin";
            this.dtcheckin.Size = new System.Drawing.Size(312, 27);
            this.dtcheckin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CheckIn";
            // 
            // dtCheckout
            // 
            this.dtCheckout.Location = new System.Drawing.Point(199, 259);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(312, 27);
            this.dtCheckout.TabIndex = 6;
            // 
            // lblChechOut
            // 
            this.lblChechOut.AutoSize = true;
            this.lblChechOut.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChechOut.Location = new System.Drawing.Point(106, 259);
            this.lblChechOut.Name = "lblChechOut";
            this.lblChechOut.Size = new System.Drawing.Size(87, 21);
            this.lblChechOut.TabIndex = 7;
            this.lblChechOut.Text = "CheckOut";
            // 
            // btnAgendarQuarto
            // 
            this.btnAgendarQuarto.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgendarQuarto.Location = new System.Drawing.Point(199, 302);
            this.btnAgendarQuarto.Name = "btnAgendarQuarto";
            this.btnAgendarQuarto.Size = new System.Drawing.Size(312, 29);
            this.btnAgendarQuarto.TabIndex = 8;
            this.btnAgendarQuarto.Text = "Agendar Quarto";
            this.btnAgendarQuarto.UseVisualStyleBackColor = true;
            this.btnAgendarQuarto.Click += new System.EventHandler(this.btnAgendarQuarto_Click);
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorPagar.Location = new System.Drawing.Point(140, 162);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(53, 21);
            this.lblValorPagar.TabIndex = 9;
            this.lblValorPagar.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(199, 160);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(164, 27);
            this.txtValor.TabIndex = 10;
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuarto.Location = new System.Drawing.Point(270, 112);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(158, 21);
            this.lblQuarto.TabIndex = 11;
            this.lblQuarto.Text = "Numero do Quarto";
            // 
            // txtQuarto
            // 
            this.txtQuarto.Location = new System.Drawing.Point(434, 110);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(77, 27);
            this.txtQuarto.TabIndex = 12;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdCliente.Location = new System.Drawing.Point(399, 162);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(32, 21);
            this.lblIdCliente.TabIndex = 13;
            this.lblIdCliente.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(437, 160);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(74, 27);
            this.txtId.TabIndex = 14;
            // 
            // AgendamentoQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 379);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.txtQuarto);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.btnAgendarQuarto);
            this.Controls.Add(this.lblChechOut);
            this.Controls.Add(this.dtCheckout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtcheckin);
            this.Controls.Add(this.txtQtdPessoas);
            this.Controls.Add(this.lblQtdPessoas);
            this.Controls.Add(this.txtNomeHospede);
            this.Controls.Add(this.lblNomeHospede);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AgendamentoQuartos";
            this.Text = "AgendamentoQuartos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeHospede;
        private System.Windows.Forms.TextBox txtNomeHospede;
        private System.Windows.Forms.Label lblQtdPessoas;
        private System.Windows.Forms.TextBox txtQtdPessoas;
        private System.Windows.Forms.DateTimePicker dtcheckin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtCheckout;
        private System.Windows.Forms.Label lblChechOut;
        private System.Windows.Forms.Button btnAgendarQuarto;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtId;
    }
}