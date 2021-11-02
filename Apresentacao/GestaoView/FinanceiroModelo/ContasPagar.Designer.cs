
namespace PIM4.Apresentacao.GestaoView.FinanceiroModelo
{
    partial class ContasPagar
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
            this.lblContPagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContPagar
            // 
            this.lblContPagar.AutoSize = true;
            this.lblContPagar.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContPagar.Location = new System.Drawing.Point(13, 22);
            this.lblContPagar.Name = "lblContPagar";
            this.lblContPagar.Size = new System.Drawing.Size(265, 26);
            this.lblContPagar.TabIndex = 0;
            this.lblContPagar.Text = "Moulo  de Contas a Pagar";
            // 
            // ContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContPagar);
            this.Name = "ContasPagar";
            this.Text = "ContasPagar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContPagar;
    }
}