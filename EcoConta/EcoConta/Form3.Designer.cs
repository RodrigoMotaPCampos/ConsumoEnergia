namespace EcoConta
{
    partial class Form3
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
            txtAnterior = new TextBox();
            txtAtual = new TextBox();
            rbtnResidencial = new RadioButton();
            rbtnComercial = new RadioButton();
            txtDocumento = new TextBox();
            btnSalvar_Click = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtAnterior
            // 
            txtAnterior.Location = new Point(278, 120);
            txtAnterior.Name = "txtAnterior";
            txtAnterior.Size = new Size(197, 27);
            txtAnterior.TabIndex = 0;
            txtAnterior.Text = "Leitura Anterior";
            txtAnterior.TextAlign = HorizontalAlignment.Center;
            txtAnterior.TextChanged += txtAnterior_TextChanged;
            // 
            // txtAtual
            // 
            txtAtual.Location = new Point(278, 171);
            txtAtual.Name = "txtAtual";
            txtAtual.Size = new Size(197, 27);
            txtAtual.TabIndex = 1;
            txtAtual.Text = "Leitura Atual";
            txtAtual.TextAlign = HorizontalAlignment.Center;
            txtAtual.TextChanged += txtAtual_TextChanged;
            // 
            // rbtnResidencial
            // 
            rbtnResidencial.AutoSize = true;
            rbtnResidencial.BackColor = Color.Transparent;
            rbtnResidencial.Location = new Point(246, 66);
            rbtnResidencial.Name = "rbtnResidencial";
            rbtnResidencial.Size = new Size(105, 24);
            rbtnResidencial.TabIndex = 2;
            rbtnResidencial.TabStop = true;
            rbtnResidencial.Text = "Residencial";
            rbtnResidencial.UseVisualStyleBackColor = false;
            rbtnResidencial.CheckedChanged += rbtnResidencial_CheckedChanged;
            // 
            // rbtnComercial
            // 
            rbtnComercial.AutoSize = true;
            rbtnComercial.BackColor = Color.Transparent;
            rbtnComercial.Location = new Point(433, 66);
            rbtnComercial.Name = "rbtnComercial";
            rbtnComercial.Size = new Size(97, 24);
            rbtnComercial.TabIndex = 3;
            rbtnComercial.TabStop = true;
            rbtnComercial.Text = "Comercial";
            rbtnComercial.UseVisualStyleBackColor = false;
            rbtnComercial.CheckedChanged += rbtnComercial_CheckedChanged;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(278, 224);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(197, 27);
            txtDocumento.TabIndex = 4;
            txtDocumento.Text = "Insira seu Documento";
            txtDocumento.TextAlign = HorizontalAlignment.Center;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // btnSalvar_Click
            // 
            btnSalvar_Click.BackColor = Color.Cyan;
            btnSalvar_Click.FlatStyle = FlatStyle.Popup;
            btnSalvar_Click.Location = new Point(289, 314);
            btnSalvar_Click.Name = "btnSalvar_Click";
            btnSalvar_Click.Size = new Size(169, 54);
            btnSalvar_Click.TabIndex = 5;
            btnSalvar_Click.Text = "Cadastrar";
            btnSalvar_Click.UseVisualStyleBackColor = false;
            btnSalvar_Click.Click += btnSalvar_Click_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 40);
            label1.TabIndex = 6;
            label1.Text = "Cadastro de Conta";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSalvar_Click);
            Controls.Add(txtDocumento);
            Controls.Add(rbtnComercial);
            Controls.Add(rbtnResidencial);
            Controls.Add(txtAtual);
            Controls.Add(txtAnterior);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnterior;
        private TextBox txtAtual;
        private RadioButton rbtnResidencial;
        private RadioButton rbtnComercial;
        private TextBox txtDocumento;
        private Button btnSalvar_Click;
        private Label label1;
    }
}