
namespace PIM4.Apresentacao.GestaoView.AdmModelo
{
    partial class AdmFuncionario
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
            this.dataGridViewAdm = new System.Windows.Forms.DataGridView();
            this.btnStaReserv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdm
            // 
            this.dataGridViewAdm.AllowUserToAddRows = false;
            this.dataGridViewAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdm.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewAdm.Name = "dataGridViewAdm";
            this.dataGridViewAdm.RowHeadersWidth = 51;
            this.dataGridViewAdm.RowTemplate.Height = 29;
            this.dataGridViewAdm.Size = new System.Drawing.Size(920, 280);
            this.dataGridViewAdm.TabIndex = 0;
            // 
            // btnStaReserv
            // 
            this.btnStaReserv.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStaReserv.Location = new System.Drawing.Point(12, 354);
            this.btnStaReserv.Name = "btnStaReserv";
            this.btnStaReserv.Size = new System.Drawing.Size(920, 46);
            this.btnStaReserv.TabIndex = 1;
            this.btnStaReserv.Text = "Status reservas";
            this.btnStaReserv.UseVisualStyleBackColor = true;
            this.btnStaReserv.Click += new System.EventHandler(this.btnStaReserv_Click);
            // 
            // AdmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 423);
            this.Controls.Add(this.btnStaReserv);
            this.Controls.Add(this.dataGridViewAdm);
            this.Name = "AdmFuncionario";
            this.Text = "AdmFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdm;
        private System.Windows.Forms.Button btnStaReserv;
    }
}