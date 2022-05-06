
namespace Agendamento
{
    partial class frmCarro
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpfCarro = new System.Windows.Forms.TextBox();
            this.btnConsultarCpf = new System.Windows.Forms.Button();
            this.lnlName = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(34, 42);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(34, 71);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(228, 23);
            this.txtMarca.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(34, 120);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(34, 153);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(228, 23);
            this.txtModelo.TabIndex = 3;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(34, 198);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa";
            this.lblPlaca.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(34, 229);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(228, 23);
            this.txtPlaca.TabIndex = 5;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(34, 276);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(25, 15);
            this.lblKm.TabIndex = 6;
            this.lblKm.Text = "KM";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(34, 315);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(228, 23);
            this.txtKm.TabIndex = 7;
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.Location = new System.Drawing.Point(158, 360);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCarro.TabIndex = 8;
            this.btnCadastrarCarro.Text = "Cadastrar";
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPF";
            // 
            // txtCpfCarro
            // 
            this.txtCpfCarro.Location = new System.Drawing.Point(336, 71);
            this.txtCpfCarro.Name = "txtCpfCarro";
            this.txtCpfCarro.Size = new System.Drawing.Size(100, 23);
            this.txtCpfCarro.TabIndex = 10;
            // 
            // btnConsultarCpf
            // 
            this.btnConsultarCpf.Location = new System.Drawing.Point(483, 71);
            this.btnConsultarCpf.Name = "btnConsultarCpf";
            this.btnConsultarCpf.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCpf.TabIndex = 11;
            this.btnConsultarCpf.Text = "Consultar";
            this.btnConsultarCpf.UseVisualStyleBackColor = true;
            this.btnConsultarCpf.Click += new System.EventHandler(this.btnConsultarCpf_Click);
            // 
            // lnlName
            // 
            this.lnlName.AutoSize = true;
            this.lnlName.Location = new System.Drawing.Point(336, 120);
            this.lnlName.Name = "lnlName";
            this.lnlName.Size = new System.Drawing.Size(40, 15);
            this.lnlName.TabIndex = 16;
            this.lnlName.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(336, 153);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 23);
            this.txtNomeCliente.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnlName);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnConsultarCpf);
            this.Controls.Add(this.txtCpfCarro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarCarro);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Name = "frmCarro";
            this.Text = "Cadastro Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Button btnCadastrarCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpfCarro;
        private System.Windows.Forms.Button btnConsultarCpf;
        private System.Windows.Forms.Label lnlName;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button button1;
    }
}