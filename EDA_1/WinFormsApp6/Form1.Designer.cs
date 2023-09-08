namespace WinFormsApp6
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
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            lblPerimetro = new Label();
            lblArea = new Label();
            btnCalcular = new Button();
            label7 = new Label();
            label8 = new Label();
            lblRPerimetro = new Label();
            lblRArea = new Label();
            btnRCalcular = new Button();
            txtRadio = new TextBox();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLadoC = new TextBox();
            txtLadoB = new TextBox();
            txtLadoA = new TextBox();
            lblTPerimetro = new Label();
            lblTArea = new Label();
            btnTCalcular = new Button();
            button4 = new Button();
            label5 = new Label();
            textLCuadrado = new TextBox();
            lblAreaLCuadrado = new Label();
            lblPerimetroLCuadrado = new Label();
            btnCC = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Circulo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(348, 22);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Rectangulo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 118);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "radio";
            label4.Click += label4_Click;
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(42, 209);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(75, 20);
            lblPerimetro.TabIndex = 6;
            lblPerimetro.Text = "perimetro";
            lblPerimetro.Click += label5_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(42, 229);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(38, 20);
            lblArea.TabIndex = 7;
            lblArea.Text = "area";
            lblArea.Click += label6_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(42, 267);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Circulo";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(362, 118);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 9;
            label7.Text = "Base";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 118);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 10;
            label8.Text = "Altura";
            // 
            // lblRPerimetro
            // 
            lblRPerimetro.AutoSize = true;
            lblRPerimetro.Location = new Point(362, 194);
            lblRPerimetro.Name = "lblRPerimetro";
            lblRPerimetro.Size = new Size(73, 20);
            lblRPerimetro.TabIndex = 13;
            lblRPerimetro.Text = "Perimetro";
            lblRPerimetro.Click += label9_Click;
            // 
            // lblRArea
            // 
            lblRArea.AutoSize = true;
            lblRArea.Location = new Point(362, 219);
            lblRArea.Name = "lblRArea";
            lblRArea.Size = new Size(40, 20);
            lblRArea.TabIndex = 14;
            lblRArea.Text = "Area";
            lblRArea.Click += label10_Click;
            // 
            // btnRCalcular
            // 
            btnRCalcular.Location = new Point(362, 242);
            btnRCalcular.Name = "btnRCalcular";
            btnRCalcular.Size = new Size(111, 29);
            btnRCalcular.TabIndex = 15;
            btnRCalcular.Text = "Rectangulo";
            btnRCalcular.UseVisualStyleBackColor = true;
            btnRCalcular.Click += button4_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(42, 157);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 27);
            txtRadio.TabIndex = 21;
            txtRadio.TextChanged += txtRadio_TextChanged;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(362, 141);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(111, 27);
            txtBase.TabIndex = 23;
            txtBase.TextChanged += txtBase_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(499, 141);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 24;
            // 
            // button3
            // 
            button3.Location = new Point(723, 2);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 26;
            button3.Text = "Triangulo";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 71);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 28;
            label1.Text = "Lado1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(746, 131);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 29;
            label2.Text = "Lado2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(746, 199);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 30;
            label3.Text = "Lado3";
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(746, 222);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(125, 27);
            txtLadoC.TabIndex = 31;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(746, 154);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(125, 27);
            txtLadoB.TabIndex = 32;
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(746, 94);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(125, 27);
            txtLadoA.TabIndex = 33;
            // 
            // lblTPerimetro
            // 
            lblTPerimetro.AutoSize = true;
            lblTPerimetro.Location = new Point(746, 312);
            lblTPerimetro.Name = "lblTPerimetro";
            lblTPerimetro.Size = new Size(73, 20);
            lblTPerimetro.TabIndex = 0;
            lblTPerimetro.Text = "Perimetro";
            // 
            // lblTArea
            // 
            lblTArea.AutoSize = true;
            lblTArea.Location = new Point(746, 285);
            lblTArea.Name = "lblTArea";
            lblTArea.Size = new Size(40, 20);
            lblTArea.TabIndex = 1;
            lblTArea.Text = "Area";
            lblTArea.Click += lblTArea_Click;
            // 
            // btnTCalcular
            // 
            btnTCalcular.Location = new Point(746, 335);
            btnTCalcular.Name = "btnTCalcular";
            btnTCalcular.Size = new Size(94, 29);
            btnTCalcular.TabIndex = 34;
            btnTCalcular.Text = "Triangulo";
            btnTCalcular.UseVisualStyleBackColor = true;
            btnTCalcular.Click += button4_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(1002, 10);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 35;
            button4.Text = "Cuadrado";
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1014, 81);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 36;
            label5.Text = "Lado en cm";
            label5.Click += label5_Click_1;
            // 
            // textLCuadrado
            // 
            textLCuadrado.Location = new Point(1014, 104);
            textLCuadrado.Name = "textLCuadrado";
            textLCuadrado.Size = new Size(125, 27);
            textLCuadrado.TabIndex = 37;
            textLCuadrado.TextChanged += textBox1_TextChanged;
            // 
            // lblAreaLCuadrado
            // 
            lblAreaLCuadrado.AutoSize = true;
            lblAreaLCuadrado.Location = new Point(1014, 160);
            lblAreaLCuadrado.Name = "lblAreaLCuadrado";
            lblAreaLCuadrado.Size = new Size(40, 20);
            lblAreaLCuadrado.TabIndex = 38;
            lblAreaLCuadrado.Text = "Area";
            lblAreaLCuadrado.Click += label6_Click_1;
            // 
            // lblPerimetroLCuadrado
            // 
            lblPerimetroLCuadrado.AutoSize = true;
            lblPerimetroLCuadrado.Location = new Point(1014, 209);
            lblPerimetroLCuadrado.Name = "lblPerimetroLCuadrado";
            lblPerimetroLCuadrado.Size = new Size(73, 20);
            lblPerimetroLCuadrado.TabIndex = 39;
            lblPerimetroLCuadrado.Text = "Perimetro";
            // 
            // btnCC
            // 
            btnCC.Location = new Point(1014, 253);
            btnCC.Name = "btnCC";
            btnCC.Size = new Size(94, 29);
            btnCC.TabIndex = 40;
            btnCC.Text = "Cuadrado";
            btnCC.UseVisualStyleBackColor = true;
            btnCC.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(32, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 237);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "P Y A del circulo";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(1002, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 273);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "P Y A del cuadrado";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(723, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(223, 362);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "P Y A del triangulo";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(348, 71);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(302, 224);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "P Y A del rectangulo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 450);
            Controls.Add(btnCC);
            Controls.Add(lblPerimetroLCuadrado);
            Controls.Add(lblAreaLCuadrado);
            Controls.Add(textLCuadrado);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(btnTCalcular);
            Controls.Add(lblTPerimetro);
            Controls.Add(txtLadoA);
            Controls.Add(lblTArea);
            Controls.Add(txtLadoB);
            Controls.Add(txtLadoC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(txtAltura);
            Controls.Add(lblRArea);
            Controls.Add(txtBase);
            Controls.Add(txtRadio);
            Controls.Add(lblPerimetro);
            Controls.Add(btnRCalcular);
            Controls.Add(lblRPerimetro);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnCalcular);
            Controls.Add(lblArea);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label4;
        private Label lblPerimetro;
        private Label lblArea;
        private Button btnCalcular;
        private Label label7;
        private Label label8;
        private Label lblRPerimetro;
        private Label lblRArea;
        private Button btnRCalcular;
        private TextBox txtRadio;
        private TextBox txtBase;
        private TextBox txtAltura;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLadoC;
        private TextBox txtLadoB;
        private TextBox txtLadoA;
        private Label lblTPerimetro;
        private Label lblTArea;
        private Button btnTCalcular;
        private Button button4;
        private Label label5;
        private TextBox textLCuadrado;
        private Label lblAreaLCuadrado;
        private Label lblPerimetroLCuadrado;
        private Button btnCC;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}