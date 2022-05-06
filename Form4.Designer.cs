
namespace Agendamento
{
    partial class Form4
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
            this.lblDataHora = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblKmAgenda = new System.Windows.Forms.Label();
            this.txtKmAgenda = new System.Windows.Forms.TextBox();
            this.btnCadastrarAgenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(78, 54);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(31, 15);
            this.lblDataHora.TabIndex = 0;
            this.lblDataHora.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(78, 90);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(222, 23);
            this.txtData.TabIndex = 1;
            // 
            // lblKmAgenda
            // 
            this.lblKmAgenda.AutoSize = true;
            this.lblKmAgenda.Location = new System.Drawing.Point(78, 226);
            this.lblKmAgenda.Name = "lblKmAgenda";
            this.lblKmAgenda.Size = new System.Drawing.Size(25, 15);
            this.lblKmAgenda.TabIndex = 2;
            this.lblKmAgenda.Text = "KM";
            // 
            // txtKmAgenda
            // 
            this.txtKmAgenda.Location = new System.Drawing.Point(78, 274);
            this.txtKmAgenda.Name = "txtKmAgenda";
            this.txtKmAgenda.Size = new System.Drawing.Size(222, 23);
            this.txtKmAgenda.TabIndex = 3;
            // 
            // btnCadastrarAgenda
            // 
            this.btnCadastrarAgenda.Location = new System.Drawing.Point(130, 433);
            this.btnCadastrarAgenda.Name = "btnCadastrarAgenda";
            this.btnCadastrarAgenda.Size = new System.Drawing.Size(114, 23);
            this.btnCadastrarAgenda.TabIndex = 6;
            this.btnCadastrarAgenda.Text = "Cadastrar";
            this.btnCadastrarAgenda.UseVisualStyleBackColor = true;
            this.btnCadastrarAgenda.Click += new System.EventHandler(this.btnCadastrarAgenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(78, 179);
            this.txtHora.Name = "txtHora";
            this.txtHora.ShortcutsEnabled = false;
            this.txtHora.Size = new System.Drawing.Size(222, 23);
            this.txtHora.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(342, 374);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(78, 374);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(222, 23);
            this.txtPlaca.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 683);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarAgenda);
            this.Controls.Add(this.txtKmAgenda);
            this.Controls.Add(this.lblKmAgenda);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblDataHora);
            this.Name = "Form4";
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblKmAgenda;
        private System.Windows.Forms.TextBox txtKmAgenda;
        private System.Windows.Forms.Button btnCadastrarAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
    }
}