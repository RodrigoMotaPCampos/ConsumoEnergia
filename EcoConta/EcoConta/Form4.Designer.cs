namespace EcoConta
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
            txtDocumento = new TextBox();
            btnBuscar_Click = new Button();
            txtResultado = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtResultado).BeginInit();
            SuspendLayout();
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(214, 76);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(183, 27);
            txtDocumento.TabIndex = 0;
            txtDocumento.Text = "Insira seu Documento";
            txtDocumento.TextAlign = HorizontalAlignment.Center;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // btnBuscar_Click
            // 
            btnBuscar_Click.BackColor = Color.Cyan;
            btnBuscar_Click.FlatStyle = FlatStyle.Popup;
            btnBuscar_Click.Location = new Point(451, 74);
            btnBuscar_Click.Name = "btnBuscar_Click";
            btnBuscar_Click.Size = new Size(94, 29);
            btnBuscar_Click.TabIndex = 1;
            btnBuscar_Click.Text = "Buscar";
            btnBuscar_Click.UseVisualStyleBackColor = false;
            btnBuscar_Click.Click += btnBuscar_Click_Click;
            // 
            // txtResultado
            // 
            txtResultado.AllowUserToOrderColumns = true;
            txtResultado.BackgroundColor = SystemColors.Control;
            txtResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txtResultado.GridColor = Color.Cyan;
            txtResultado.Location = new Point(214, 148);
            txtResultado.Name = "txtResultado";
            txtResultado.RowHeadersWidth = 51;
            txtResultado.Size = new Size(331, 222);
            txtResultado.TabIndex = 2;
            txtResultado.CellContentClick += txtResultado_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 40);
            label1.TabIndex = 3;
            label1.Text = "Consultar Conta";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(btnBuscar_Click);
            Controls.Add(txtDocumento);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)txtResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDocumento;
        private Button btnBuscar_Click;
        private DataGridView txtResultado;
        private Label label1;
    }
}