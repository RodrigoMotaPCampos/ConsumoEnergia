namespace EcoConta
{
    partial class CadastroCliente
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
            label1 = new Label();
            txtNome = new TextBox();
            txtDocumento = new TextBox();
            btnSalvar_Click = new Button();
            rbtnFisica = new RadioButton();
            rbtnJuridica = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(289, 134);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(289, 206);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(196, 27);
            txtDocumento.TabIndex = 2;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // btnSalvar_Click
            // 
            btnSalvar_Click.BackColor = Color.Cyan;
            btnSalvar_Click.FlatStyle = FlatStyle.Popup;
            btnSalvar_Click.Location = new Point(302, 303);
            btnSalvar_Click.Name = "btnSalvar_Click";
            btnSalvar_Click.Size = new Size(157, 60);
            btnSalvar_Click.TabIndex = 3;
            btnSalvar_Click.Text = "Cadastrar";
            btnSalvar_Click.UseVisualStyleBackColor = false;
            btnSalvar_Click.Click += btnSalvar_Click_Click;
            // 
            // rbtnFisica
            // 
            rbtnFisica.AutoSize = true;
            rbtnFisica.BackColor = Color.Transparent;
            rbtnFisica.Location = new Point(246, 86);
            rbtnFisica.Name = "rbtnFisica";
            rbtnFisica.Size = new Size(114, 24);
            rbtnFisica.TabIndex = 4;
            rbtnFisica.TabStop = true;
            rbtnFisica.Text = "Pessoa Fisica";
            rbtnFisica.UseVisualStyleBackColor = false;
            rbtnFisica.CheckedChanged += rbtnFisica_CheckedChanged;
            // 
            // rbtnJuridica
            // 
            rbtnJuridica.AutoSize = true;
            rbtnJuridica.BackColor = Color.Transparent;
            rbtnJuridica.Location = new Point(413, 86);
            rbtnJuridica.Name = "rbtnJuridica";
            rbtnJuridica.Size = new Size(128, 24);
            rbtnJuridica.TabIndex = 5;
            rbtnJuridica.TabStop = true;
            rbtnJuridica.Text = "Pessoa Juridica";
            rbtnJuridica.UseVisualStyleBackColor = false;
            rbtnJuridica.CheckedChanged += rbtnJuridica_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(193, 209);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 6;
            label2.Text = "Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(230, 134);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 6;
            label3.Text = "Nome:";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rbtnJuridica);
            Controls.Add(rbtnFisica);
            Controls.Add(btnSalvar_Click);
            Controls.Add(txtDocumento);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "CadastroCliente";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtDocumento;
        private Button btnSalvar_Click;
        private RadioButton rbtnFisica;
        private RadioButton rbtnJuridica;
        private Label label2;
        private Label label3;
    }
}