
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
            this.lblId_res = new System.Windows.Forms.Label();
            this.txtId_res = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dataGridViewContReceb = new System.Windows.Forms.DataGridView();
            this.btnListReserva = new System.Windows.Forms.Button();
            this.btnListPagos = new System.Windows.Forms.Button();
            this.btnListaDevedores = new System.Windows.Forms.Button();
            this.btnTotPago = new System.Windows.Forms.Button();
            this.btnEmAberto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContReceb)).BeginInit();
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
            // lblId_res
            // 
            this.lblId_res.AutoSize = true;
            this.lblId_res.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId_res.Location = new System.Drawing.Point(29, 76);
            this.lblId_res.Name = "lblId_res";
            this.lblId_res.Size = new System.Drawing.Size(97, 21);
            this.lblId_res.TabIndex = 1;
            this.lblId_res.Text = "ID Reserva";
            // 
            // txtId_res
            // 
            this.txtId_res.Location = new System.Drawing.Point(132, 76);
            this.txtId_res.Name = "txtId_res";
            this.txtId_res.Size = new System.Drawing.Size(84, 27);
            this.txtId_res.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(222, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(196, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Confirmar Pagamento";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(29, 110);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 21);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // dataGridViewContReceb
            // 
            this.dataGridViewContReceb.AllowUserToOrderColumns = true;
            this.dataGridViewContReceb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContReceb.Location = new System.Drawing.Point(29, 153);
            this.dataGridViewContReceb.Name = "dataGridViewContReceb";
            this.dataGridViewContReceb.RowHeadersWidth = 51;
            this.dataGridViewContReceb.RowTemplate.Height = 29;
            this.dataGridViewContReceb.Size = new System.Drawing.Size(692, 188);
            this.dataGridViewContReceb.TabIndex = 5;
            // 
            // btnListReserva
            // 
            this.btnListReserva.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListReserva.Location = new System.Drawing.Point(29, 361);
            this.btnListReserva.Name = "btnListReserva";
            this.btnListReserva.Size = new System.Drawing.Size(692, 29);
            this.btnListReserva.TabIndex = 6;
            this.btnListReserva.Text = "Lista de Reservas";
            this.btnListReserva.UseVisualStyleBackColor = true;
            this.btnListReserva.Click += new System.EventHandler(this.btnListReserva_Click);
            // 
            // btnListPagos
            // 
            this.btnListPagos.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListPagos.Location = new System.Drawing.Point(29, 396);
            this.btnListPagos.Name = "btnListPagos";
            this.btnListPagos.Size = new System.Drawing.Size(692, 29);
            this.btnListPagos.TabIndex = 7;
            this.btnListPagos.Text = "Lista de Pagos";
            this.btnListPagos.UseVisualStyleBackColor = true;
            this.btnListPagos.Click += new System.EventHandler(this.btnListPagos_Click);
            // 
            // btnListaDevedores
            // 
            this.btnListaDevedores.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListaDevedores.Location = new System.Drawing.Point(29, 432);
            this.btnListaDevedores.Name = "btnListaDevedores";
            this.btnListaDevedores.Size = new System.Drawing.Size(692, 29);
            this.btnListaDevedores.TabIndex = 8;
            this.btnListaDevedores.Text = "Lista de Devedores";
            this.btnListaDevedores.UseVisualStyleBackColor = true;
            this.btnListaDevedores.Click += new System.EventHandler(this.btnListaDevedores_Click);
            // 
            // btnTotPago
            // 
            this.btnTotPago.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTotPago.Location = new System.Drawing.Point(29, 468);
            this.btnTotPago.Name = "btnTotPago";
            this.btnTotPago.Size = new System.Drawing.Size(692, 29);
            this.btnTotPago.TabIndex = 9;
            this.btnTotPago.Text = "Total Pago";
            this.btnTotPago.UseVisualStyleBackColor = true;
            this.btnTotPago.Click += new System.EventHandler(this.btnTotPago_Click);
            // 
            // btnEmAberto
            // 
            this.btnEmAberto.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmAberto.Location = new System.Drawing.Point(29, 503);
            this.btnEmAberto.Name = "btnEmAberto";
            this.btnEmAberto.Size = new System.Drawing.Size(692, 29);
            this.btnEmAberto.TabIndex = 10;
            this.btnEmAberto.Text = "Total em Aberto";
            this.btnEmAberto.UseVisualStyleBackColor = true;
            this.btnEmAberto.Click += new System.EventHandler(this.btnEmAberto_Click);
            // 
            // ContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 548);
            this.Controls.Add(this.btnEmAberto);
            this.Controls.Add(this.btnTotPago);
            this.Controls.Add(this.btnListaDevedores);
            this.Controls.Add(this.btnListPagos);
            this.Controls.Add(this.btnListReserva);
            this.Controls.Add(this.dataGridViewContReceb);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtId_res);
            this.Controls.Add(this.lblId_res);
            this.Controls.Add(this.lblContReceber);
            this.Name = "ContaReceber";
            this.Text = "ContaReceber";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContReceb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContReceber;
        private System.Windows.Forms.Label lblId_res;
        private System.Windows.Forms.TextBox txtId_res;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataGridViewContReceb;
        private System.Windows.Forms.Button btnListReserva;
        private System.Windows.Forms.Button btnListPagos;
        private System.Windows.Forms.Button btnListaDevedores;
        private System.Windows.Forms.Button btnTotPago;
        private System.Windows.Forms.Button btnEmAberto;
    }
}