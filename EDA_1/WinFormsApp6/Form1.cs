
using TDA_Tarea1;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRadio.Text, out double radio))
            {
                Circulo circulo = new Circulo();
                circulo.Radio = radio;

                double area = circulo.area();
                double perimetro = circulo.perimetro();


                lblArea.Text = $"�rea: {area}";
                lblPerimetro.Text = $"Per�metro: {perimetro}";


            }
            else
            {
                lblArea.Text = "Por favor, ingrese un n�mero v�lido.";
                lblPerimetro.Text = "Por favor, ingrese un n�mero v�lido.";

            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Verifica si los valores ingresados son n�meros v�lidos
            if (double.TryParse(txtBase.Text, out double baseRectangulo) &&
                double.TryParse(txtAltura.Text, out double alturaRectangulo))
            {
                Rectangulo rectangulo = new Rectangulo();
                rectangulo.Bases = baseRectangulo;
                rectangulo.Altura = alturaRectangulo;

                double area = rectangulo.area();
                double perimetro = rectangulo.perimetro();

                lblRArea.Text = $"�rea: {area}";
                lblRPerimetro.Text = $"Per�metro: {perimetro}";
            }
            else
            {
                lblRArea.Text = "Por favor, ingrese n�meros v�lidos.";
                lblRPerimetro.Text = "";
            }
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtLadoA.Text, out double ladoA) && double.TryParse(txtLadoB.Text, out double ladoB) && double.TryParse(txtLadoC.Text, out double ladoC))
            {
                Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

                double area = triangulo.area();
                double perimetro = triangulo.perimetro();

                lblTArea.Text = $"�rea: {area}";
                lblTPerimetro.Text = $"Per�metro: {perimetro}";
            }
            else
            {
                lblTArea.Text = "Por favor, ingrese n�meros v�lidos.";
                lblTPerimetro.Text = "";
            }
        }

        private void lblTArea_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Verifica si el valor ingresado es un n�mero v�lido
            if (double.TryParse(textLCuadrado.Text, out double ladoCuadrado))
            {
                Cuadrado cuadrado = new Cuadrado(ladoCuadrado);

                double area = cuadrado.area();
                double perimetro = cuadrado.perimetro();

                lblAreaLCuadrado.Text = $"�rea: {area}";
                lblPerimetroLCuadrado.Text = $"Per�metro: {perimetro}";
            }
            else
            {
                lblAreaLCuadrado.Text = "Por favor, ingrese un n�mero v�lido.";
                lblPerimetroLCuadrado.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}