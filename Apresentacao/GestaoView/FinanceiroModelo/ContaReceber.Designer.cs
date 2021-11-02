
namespace PIM4.Apresentacao.GestaoView.FinanceiroModelo
{
    partial class ContaReceber
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
            this.lblContReceber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContReceber
            // 
            this.lblContReceber.AutoSize = true;
            this.lblContReceber.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContReceber.Location = new System.Drawing.Point(29, 24);
            this.lblContReceber.Name = "lblContReceber";
            this.lblContReceber.Size = new System.Drawing.Size(296, 26);
            this.lblContReceber.TabIndex = 0;
            this.lblContReceber.Text = "Modulos de Conta a Receber";
            // 
            // ContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContReceber);
            this.Name = "ContaReceber";
            this.Text = "ContaReceber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContReceber;
    }
}