
namespace PIM4.Apresentacao.GestaoView.FinanceiroModelo
{
    partial class RelatoriosContPag
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridViewCP = new System.Windows.Forms.DataGridView();
            this.btnTodosLancamentos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(42, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(286, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Relatórios de contas a Pagar";
            // 
            // dataGridViewCP
            // 
            this.dataGridViewCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCP.Location = new System.Drawing.Point(42, 89);
            this.dataGridViewCP.Name = "dataGridViewCP";
            this.dataGridViewCP.RowHeadersWidth = 51;
            this.dataGridViewCP.RowTemplate.Height = 29;
            this.dataGridViewCP.Size = new System.Drawing.Size(846, 203);
            this.dataGridViewCP.TabIndex = 1;
            // 
            // btnTodosLancamentos
            // 
            this.btnTodosLancamentos.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTodosLancamentos.Location = new System.Drawing.Point(42, 311);
            this.btnTodosLancamentos.Name = "btnTodosLancamentos";
            this.btnTodosLancamentos.Size = new System.Drawing.Size(846, 35);
            this.btnTodosLancamentos.TabIndex = 2;
            this.btnTodosLancamentos.Text = "Todos os Lançamentos";
            this.btnTodosLancamentos.UseVisualStyleBackColor = true;
            this.btnTodosLancamentos.Click += new System.EventHandler(this.btnTodosLancamentos_Click);
            // 
            // RelatoriosContPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.btnTodosLancamentos);
            this.Controls.Add(this.dataGridViewCP);
            this.Controls.Add(this.lblTitulo);
            this.Name = "RelatoriosContPag";
            this.Text = "RelatoriosContPag";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridViewCP;
        private System.Windows.Forms.Button btnTodosLancamentos;
    }
}