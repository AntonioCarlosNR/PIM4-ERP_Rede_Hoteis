
namespace PIM4.Apresentacao.GestaoView
{
    partial class Administrativo
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
            this.btnAmdFunc = new System.Windows.Forms.Button();
            this.btnInOut = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAmdFunc
            // 
            this.btnAmdFunc.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAmdFunc.Location = new System.Drawing.Point(42, 76);
            this.btnAmdFunc.Name = "btnAmdFunc";
            this.btnAmdFunc.Size = new System.Drawing.Size(186, 129);
            this.btnAmdFunc.TabIndex = 0;
            this.btnAmdFunc.Text = "Administração de funcionários";
            this.btnAmdFunc.UseVisualStyleBackColor = true;
            this.btnAmdFunc.Click += new System.EventHandler(this.btnAmdFunc_Click);
            // 
            // btnInOut
            // 
            this.btnInOut.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInOut.Location = new System.Drawing.Point(304, 76);
            this.btnInOut.Name = "btnInOut";
            this.btnInOut.Size = new System.Drawing.Size(186, 129);
            this.btnInOut.TabIndex = 1;
            this.btnInOut.Text = "CheckIn/CheckOut";
            this.btnInOut.UseVisualStyleBackColor = true;
            this.btnInOut.Click += new System.EventHandler(this.btnInOut_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.Location = new System.Drawing.Point(74, 267);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(154, 29);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(304, 267);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(154, 29);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair do Sistema";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 320);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnInOut);
            this.Controls.Add(this.btnAmdFunc);
            this.Name = "Administrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrativo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAmdFunc;
        private System.Windows.Forms.Button btnInOut;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSair;
    }
}