
namespace PIM4.Apresentacao.GestaoView
{
    partial class Financeiro
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPagar.Location = new System.Drawing.Point(63, 54);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(164, 112);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Contas a Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReceber.Location = new System.Drawing.Point(289, 54);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(164, 112);
            this.btnReceber.TabIndex = 1;
            this.btnReceber.Text = "Contas a Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.button1_Click);
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 243);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.btnPagar);
            this.Name = "Financeiro";
            this.Text = "Financeiro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnReceber;
    }
}