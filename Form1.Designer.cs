
namespace Agendamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnVeiculo = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.pcbSistema = new System.Windows.Forms.PictureBox();
            this.tltAgenda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.BackgroundImage = global::Agendamento.Properties.Resources.png_transparent_orange_car_illustration_compact_car_motors_corporation_orange_car_car_accident_van_car;
            this.btnVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVeiculo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVeiculo.Location = new System.Drawing.Point(21, 598);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(189, 185);
            this.btnVeiculo.TabIndex = 0;
            this.btnVeiculo.Text = "Veículo";
            this.btnVeiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tltAgenda.SetToolTip(this.btnVeiculo, "Veículo");
            this.btnVeiculo.UseVisualStyleBackColor = true;
            this.btnVeiculo.Click += new System.EventHandler(this.btnVeiculo_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = global::Agendamento.Properties.Resources._11_06_Como_manter_um_relacionamento_duradouro_com_seu_cliente_01_1080x675;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCliente.Location = new System.Drawing.Point(24, 400);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(186, 176);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tltAgenda.SetToolTip(this.btnCliente, "Cliente");
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgenda.BackgroundImage = global::Agendamento.Properties.Resources.confirmar_consulta;
            this.btnAgenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgenda.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgenda.Location = new System.Drawing.Point(25, 203);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(186, 176);
            this.btnAgenda.TabIndex = 4;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tltAgenda.SetToolTip(this.btnAgenda, "Agenda");
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Kohne Makina", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(379, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(581, 39);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "SISTEMA DE AGENDAMENTO DE REVISÕES";
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(300, 202);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.RowTemplate.Height = 25;
            this.dgvAgenda.Size = new System.Drawing.Size(1006, 581);
            this.dgvAgenda.TabIndex = 6;
            this.dgvAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellContentClick);
            // 
            // pcbSistema
            // 
            this.pcbSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbSistema.Image = global::Agendamento.Properties.Resources.webmotu_3082018527_AGENDARREVISAOMOBILE;
            this.pcbSistema.Location = new System.Drawing.Point(43, 12);
            this.pcbSistema.Name = "pcbSistema";
            this.pcbSistema.Size = new System.Drawing.Size(235, 177);
            this.pcbSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSistema.TabIndex = 7;
            this.pcbSistema.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1374, 804);
            this.Controls.Add(this.pcbSistema);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVeiculo;
        private System.Windows.Forms.ToolTip tltAgenda;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.PictureBox pcbSistema;
    }
}

