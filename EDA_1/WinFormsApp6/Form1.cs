
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


                lblArea.Text = $"Área: {area}";
                lblPerimetro.Text = $"Perímetro: {perimetro}";


            }
            else
            {
                lblArea.Text = "Por favor, ingrese un número válido.";
                lblPerimetro.Text = "Por favor, ingrese un número válido.";

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
            // Verifica si los valores ingresados son números válidos
            if (double.TryParse(txtBase.Text, out double baseRectangulo) &&
                double.TryParse(txtAltura.Text, out double alturaRectangulo))
            {
                Rectangulo rectangulo = new Rectangulo();
                rectangulo.Bases = baseRectangulo;
                rectangulo.Altura = alturaRectangulo;

                double area = rectangulo.area();
                double perimetro = rectangulo.perimetro();

                lblRArea.Text = $"Área: {area}";
                lblRPerimetro.Text = $"Perímetro: {perimetro}";
            }
            else
            {
                lblRArea.Text = "Por favor, ingrese números válidos.";
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

                lblTArea.Text = $"Área: {area}";
                lblTPerimetro.Text = $"Perímetro: {perimetro}";
            }
            else
            {
                lblTArea.Text = "Por favor, ingrese números válidos.";
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
            // Verifica si el valor ingresado es un número válido
            if (double.TryParse(textLCuadrado.Text, out double ladoCuadrado))
            {
                Cuadrado cuadrado = new Cuadrado(ladoCuadrado);

                double area = cuadrado.area();
                double perimetro = cuadrado.perimetro();

                lblAreaLCuadrado.Text = $"Área: {area}";
                lblPerimetroLCuadrado.Text = $"Perímetro: {perimetro}";
            }
            else
            {
                lblAreaLCuadrado.Text = "Por favor, ingrese un número válido.";
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