namespace EcoConta
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
            btnCadastroCliente_Click = new Button();
            btnCadastroConta_Click = new Button();
            btnConsulta_Click = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCadastroCliente_Click
            // 
            btnCadastroCliente_Click.BackColor = Color.Cyan;
            btnCadastroCliente_Click.FlatStyle = FlatStyle.Popup;
            btnCadastroCliente_Click.Location = new Point(38, 167);
            btnCadastroCliente_Click.Name = "btnCadastroCliente_Click";
            btnCadastroCliente_Click.Size = new Size(192, 57);
            btnCadastroCliente_Click.TabIndex = 0;
            btnCadastroCliente_Click.Text = "Cadastrar Cliente";
            btnCadastroCliente_Click.UseVisualStyleBackColor = false;
            btnCadastroCliente_Click.Click += btnCadastroCliente_Click_Click;
            // 
            // btnCadastroConta_Click
            // 
            btnCadastroConta_Click.BackColor = Color.Cyan;
            btnCadastroConta_Click.FlatStyle = FlatStyle.Popup;
            btnCadastroConta_Click.Location = new Point(295, 167);
            btnCadastroConta_Click.Name = "btnCadastroConta_Click";
            btnCadastroConta_Click.Size = new Size(192, 57);
            btnCadastroConta_Click.TabIndex = 1;
            btnCadastroConta_Click.Text = "Cadastrar Conta";
            btnCadastroConta_Click.UseVisualStyleBackColor = false;
            btnCadastroConta_Click.Click += btnCadastroConta_Click_Click;
            // 
            // btnConsulta_Click
            // 
            btnConsulta_Click.BackColor = Color.Cyan;
            btnConsulta_Click.FlatStyle = FlatStyle.Popup;
            btnConsulta_Click.Location = new Point(562, 167);
            btnConsulta_Click.Name = "btnConsulta_Click";
            btnConsulta_Click.Size = new Size(192, 57);
            btnConsulta_Click.TabIndex = 2;
            btnConsulta_Click.Text = "Consultar Conta";
            btnConsulta_Click.UseVisualStyleBackColor = false;
            btnConsulta_Click.Click += btnConsulta_Click_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 40);
            label1.TabIndex = 3;
            label1.Text = "EcoConta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 421);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Versão 1.0.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConsulta_Click);
            Controls.Add(btnCadastroConta_Click);
            Controls.Add(btnCadastroCliente_Click);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastroCliente_Click;
        private Button btnCadastroConta_Click;
        private Button btnConsulta_Click;
        private Label label1;
        private Label label2;
    }
}
