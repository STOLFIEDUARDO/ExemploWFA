namespace ExemploWFA
{
    partial class Exemplo02
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelValorHora = new System.Windows.Forms.Label();
            this.labelQntHoras = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtQntHoras = new System.Windows.Forms.TextBox();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.rbFemea = new System.Windows.Forms.RadioButton();
            this.cbUnidadeFederativa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Teal;
            this.labelNome.Location = new System.Drawing.Point(13, 13);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(39, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelValorHora
            // 
            this.labelValorHora.AutoSize = true;
            this.labelValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorHora.ForeColor = System.Drawing.Color.Teal;
            this.labelValorHora.Location = new System.Drawing.Point(13, 85);
            this.labelValorHora.Name = "labelValorHora";
            this.labelValorHora.Size = new System.Drawing.Size(67, 13);
            this.labelValorHora.TabIndex = 1;
            this.labelValorHora.Text = "Valor Hora";
            // 
            // labelQntHoras
            // 
            this.labelQntHoras.AutoSize = true;
            this.labelQntHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQntHoras.ForeColor = System.Drawing.Color.Teal;
            this.labelQntHoras.Location = new System.Drawing.Point(13, 151);
            this.labelQntHoras.Name = "labelQntHoras";
            this.labelQntHoras.Size = new System.Drawing.Size(127, 13);
            this.labelQntHoras.TabIndex = 2;
            this.labelQntHoras.Text = "Quantidade de Horas";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(97, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(16, 113);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(97, 20);
            this.txtValorHora.TabIndex = 4;
            // 
            // txtQntHoras
            // 
            this.txtQntHoras.Location = new System.Drawing.Point(16, 179);
            this.txtQntHoras.Name = "txtQntHoras";
            this.txtQntHoras.Size = new System.Drawing.Size(97, 20);
            this.txtQntHoras.TabIndex = 5;
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMacho.ForeColor = System.Drawing.Color.Teal;
            this.rbMacho.Location = new System.Drawing.Point(13, 206);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(63, 17);
            this.rbMacho.TabIndex = 6;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // rbFemea
            // 
            this.rbFemea.AutoSize = true;
            this.rbFemea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemea.ForeColor = System.Drawing.Color.Teal;
            this.rbFemea.Location = new System.Drawing.Point(78, 206);
            this.rbFemea.Name = "rbFemea";
            this.rbFemea.Size = new System.Drawing.Size(62, 17);
            this.rbFemea.TabIndex = 7;
            this.rbFemea.TabStop = true;
            this.rbFemea.Text = "Femea";
            this.rbFemea.UseVisualStyleBackColor = true;
            // 
            // cbUnidadeFederativa
            // 
            this.cbUnidadeFederativa.FormattingEnabled = true;
            this.cbUnidadeFederativa.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbUnidadeFederativa.Location = new System.Drawing.Point(16, 261);
            this.cbUnidadeFederativa.Name = "cbUnidadeFederativa";
            this.cbUnidadeFederativa.Size = new System.Drawing.Size(121, 21);
            this.cbUnidadeFederativa.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(13, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unidade Federativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(200, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Logradouro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(200, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(200, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(203, 40);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(203, 113);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(100, 20);
            this.txtLogradouro.TabIndex = 14;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(203, 179);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(206, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(203, 262);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 17;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(391, 39);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(334, 94);
            this.txtComplemento.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(388, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Complemento";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(391, 179);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(109, 30);
            this.btCadastrar.TabIndex = 20;
            this.btCadastrar.Text = "Cadastrar ";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(16, 323);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(121, 20);
            this.dtpDataNascimento.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Data de Nascimento";
            // 
            // Exemplo02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(764, 412);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUnidadeFederativa);
            this.Controls.Add(this.rbFemea);
            this.Controls.Add(this.rbMacho);
            this.Controls.Add(this.txtQntHoras);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelQntHoras);
            this.Controls.Add(this.labelValorHora);
            this.Controls.Add(this.labelNome);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Exemplo02";
            this.Text = "Exemplo02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelValorHora;
        private System.Windows.Forms.Label labelQntHoras;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.TextBox txtQntHoras;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.RadioButton rbFemea;
        private System.Windows.Forms.ComboBox cbUnidadeFederativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label7;
    }
}