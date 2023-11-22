namespace JogoAdivinhacaoForm
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
            dicaLabel = new Label();
            palpiteTextBox = new TextBox();
            verificarButton_Click = new Button();
            resultadoLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dicaLabel
            // 
            dicaLabel.AutoSize = true;
            dicaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dicaLabel.Location = new Point(70, 93);
            dicaLabel.Name = "dicaLabel";
            dicaLabel.Size = new Size(0, 25);
            dicaLabel.TabIndex = 0;
            dicaLabel.Click += lblDica_Click;
            // 
            // palpiteTextBox
            // 
            palpiteTextBox.Location = new Point(22, 134);
            palpiteTextBox.Name = "palpiteTextBox";
            palpiteTextBox.Size = new Size(100, 23);
            palpiteTextBox.TabIndex = 1;
            // 
            // verificarButton_Click
            // 
            verificarButton_Click.Location = new Point(31, 214);
            verificarButton_Click.Name = "verificarButton_Click";
            verificarButton_Click.Size = new Size(75, 41);
            verificarButton_Click.TabIndex = 2;
            verificarButton_Click.Text = "Conferir";
            verificarButton_Click.UseVisualStyleBackColor = true;
            verificarButton_Click.Click += button1_Click;
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultadoLabel.Location = new Point(70, 300);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(0, 25);
            resultadoLabel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(578, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(257, 15);
            label1.Name = "label1";
            label1.Size = new Size(292, 45);
            label1.TabIndex = 5;
            label1.Text = "Adivinhe o numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(resultadoLabel);
            Controls.Add(verificarButton_Click);
            Controls.Add(palpiteTextBox);
            Controls.Add(dicaLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblDica_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label dicaLabel;
        private TextBox palpiteTextBox;
        private Button verificarButton_Click;
        private Label resultadoLabel;
        private PictureBox pictureBox1;
        private Label label1;
    }
}