using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int[,] datos = new int[12, 5];
        private CalculadoraMatrices calculadora = new CalculadoraMatrices();
        private CalculadoraMatrices estadisticas = new CalculadoraMatrices();
        private double[,] datoss = new double[12, 3];


        private int[,] GenerarMatrizAleatoria(int filas, int columnas)
        {

            Random random = new Random();
            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }

            return matriz;
        }
        public Form1()
        {
            InitializeComponent();




            for (int i = 0; i < 10; i++)
            {
                dataGridView7.Columns.Add($"Columna {i + 1}", $"Columna {i + 1}");
                dataGridView9.Columns.Add($"Columna {i + 1}", $"Columna {i + 1}");

                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        dataGridView2.Columns.Add($"Columna {j + 1}", $"Columna {j + 1}");
                    }
                    dataGridView2.Rows.Add();
                }
            }
            dataGridView8.Columns.Add("Resultado", "Resultado");


            for (int i = 0; i < 5; i++)
            {
                dataGridView8.Rows.Add();
            }

            dataGridView10.Columns.Add("Resultado", "Resultado");

            for (int i = 0; i < 5; i++)
            {
                dataGridView10.Rows.Add();
            }

            dataGridView1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            for (int i = 0; i < 5; i++)
            {
                dataGridView11.Columns.Add($"Columna {i + 1}", $"Columna {i + 1}");
            }

            for (int i = 0; i < 12; i++)
            {
                dataGridView11.Rows.Add();
            }



            for (int i = 0; i < 12; i++)
            {
                dataGridView12.Columns.Add($"Parcial {i + 1}", $"Parcial {i + 1}");
            }

            for (int i = 0; i < 3; i++)
            {
                dataGridView12.Rows.Add();
            }
            for (int i = 0; i < 3; i++)
            {
                dataGridView12.Columns.Add($"Parcial {i + 1}", $"Parcial {i + 1}");
            }

            for (int i = 0; i < 12; i++)
            {
                dataGridView12.Rows.Add();
            }

            for (int i = 0; i < 12; i++)
            {
                dataGridView13.Columns.Add($"Alumno {i + 1}", $"Alumno {i + 1}");
            }

            for (int i = 0; i < 2; i++)
            {
                dataGridView13.Rows.Add();
            }
            for (int i = 0; i < 12; i++)
            {
                dataGridView13.Rows.Add();
            }

            dataGridView14.Rows.Clear();
            dataGridView14.Columns.Clear();

            dataGridView14.Columns.Add("Rango", "Rango");
            dataGridView14.Columns.Add("Total Personas", "Total Personas");

            for (int i = 0; i < 6; i++)
            {
                dataGridView14.Rows.Add();
            }
            for (int i = 0; i < 2; i++)
            {
                dataGridView14.Columns.Add($"Parcial {i + 1}", $"Parcial {i + 1}");
            }

            for (int i = 0; i < 6; i++)
            {
                dataGridView14.Rows.Add();
            }


        }



        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            textBox1.Visible = true;
            button6.Visible = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;




            for (int i = 0; i < 3; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = $"Columna {i + 1}";
                dataGridView1.Columns.Add(column);
            }

            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[3, 3];
            bool todosLosValoresIngresados = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (double.TryParse(dataGridView1[j, i].Value.ToString(), out double valor))
                    {
                        matriz[i, j] = valor;
                    }
                    else
                    {
                        todosLosValoresIngresados = false;
                        break;
                    }
                }
            }

            if (!todosLosValoresIngresados)
            {
                textBox1.Text = "Ingresa todos los valores";
                return;
            }

            if (matriz.GetLength(0) != 3 || matriz.GetLength(1) != 3)
            {
                textBox1.Text = "No es una matriz 3x3 válida";
                return;
            }

            if (CuadradoMagico.EsCuadradoMagico(matriz))
            {
                double constante = matriz[0, 0] + matriz[1, 1] + matriz[2, 2];
                textBox1.Text = ($"La constante es: {constante.ToString("")}");

            }
            else
            {

                MessageBox.Show("No es un cuadro mágico:");

            }
        }







        private void button7_Click_1(object sender, EventArgs e)
        {
            double[] sumas = new double[10];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sumas[j] += Convert.ToDouble(dataGridView2[j, i].Value);
                }
            }

            dataGridView7.Rows.Clear();
            dataGridView7.Rows.Add();

            for (int j = 0; j < 10; j++)
            {
                dataGridView7[j, 0].Value = sumas[j];
            }

            double[] promedios = new double[10];

            for (int j = 0; j < 10; j++)
            {
                double sumaColumna = 0;
                for (int i = 0; i < 5; i++)
                {
                    sumaColumna += Convert.ToDouble(dataGridView2[j, i].Value);
                }
                promedios[j] = sumaColumna / 5;
            }

            dataGridView9.Rows.Clear();

            dataGridView9.Rows.Add();

            for (int j = 0; j < 10; j++)
            {
                dataGridView9[j, 0].Value = promedios[j];
            }



            dataGridView8.Rows.Clear();

            for (int i = 0; i < 5; i++)
            {
                double sumaFila = 0;
                for (int j = 0; j < 10; j++)
                {
                    sumaFila += Convert.ToDouble(dataGridView2[j, i].Value);
                }

                dataGridView8.Rows.Add(sumaFila);
            }

            dataGridView10.Rows.Clear();

            for (int i = 0; i < 5; i++)
            {
                double sumaFila = 0;
                for (int j = 0; j < 10; j++)
                {
                    sumaFila += Convert.ToDouble(dataGridView2[j, i].Value);
                }

                double promedio = sumaFila / 10;

                dataGridView10.Rows.Add(promedio);
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            for (int i = 0; i < 10; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = $"Columna {i + 1}";
                dataGridView2.Columns.Add(column);
            }

            for (int i = 0; i < 5; i++)
            {
                dataGridView2.Rows.Add();
                for (int j = 0; j < 10; j++)
                {
                    dataGridView2[j, i].Value = random.Next(1, 101);
                }
            }
        }





        private void button9_Click(object sender, EventArgs e)
        {
            int[,] datos = GenerarMatrizAleatoria(12, 5);

            double menorVenta = double.MaxValue;
            double mayorVenta = double.MinValue;
            double ventasTotales = 0;
            double[] ventasPorDia = new double[5];

            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            int diaMenorVenta = -1;
            int mesMenorVenta = -1;
            int diaMayorVenta = -1;
            int mesMayorVenta = -1;

            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    double ventaActual = datos[i, j];

                    if (ventaActual < menorVenta)
                    {
                        menorVenta = ventaActual;
                        diaMenorVenta = j;
                        mesMenorVenta = i;
                    }

                    if (ventaActual > mayorVenta)
                    {
                        mayorVenta = ventaActual;
                        diaMayorVenta = j;
                        mesMayorVenta = i;
                    }

                    ventasTotales += ventaActual;

                    ventasPorDia[j] += ventaActual;
                }
            }

            textBox6.Text = $"La mayor venta es de {mayorVenta} pesos el día {diasSemana[diaMayorVenta]} del mes de {meses[mesMayorVenta]}";
            textBox7.Text = $"La menor venta es de {menorVenta} pesos el día {diasSemana[diaMenorVenta]} del mes de {meses[mesMenorVenta]}";
            textBox3.Text = $"Ventas totales: {ventasTotales}";

            textBox4.Text = $"La venta total del {diasSemana[0]} es: {ventasPorDia[0]}";
            textBox5.Text = $"La venta total del {diasSemana[1]} es: {ventasPorDia[1]}";
            textBox2.Text = $"La venta total del {diasSemana[2]} es: {ventasPorDia[2]}";
            textBox8.Text = $"La venta total del {diasSemana[3]} es: {ventasPorDia[3]}";
            textBox9.Text = $"La venta total del {diasSemana[4]} es : {ventasPorDia[4]}";

            dataGridView11.Rows.Clear();

            for (int i = 0; i < datos.GetLength(0); i++)
            {
                List<string> fila = new List<string>();
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    fila.Add(datos[i, j].ToString());
                }
                dataGridView11.Rows.Add(fila.ToArray());
            }
        }




        private void button5_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double valor = Math.Round(random.NextDouble() * 9 + 1, 1);
                    dataGridView12[j, i].Value = valor.ToString("N1");
                }
            }

            double promedioMasAlto = double.MinValue;
            double promedioMasBajo = double.MaxValue;
            int personasReprobadas = 0;

            for (int i = 0; i < 12; i++)
            {
                double suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma += Convert.ToDouble(dataGridView12[j, i].Value);
                }

                double promedio = suma / 3;
                dataGridView13[0, i].Value = promedio.ToString("N1");

                if (promedio > promedioMasAlto)
                {
                    promedioMasAlto = promedio;
                }

                if (promedio < promedioMasBajo)
                {
                    promedioMasBajo = promedio;
                }

                if (promedio < 7)
                {
                    personasReprobadas++;
                }
            }

            textBox10.Text = ($"El promedio más alto fue: {promedioMasAlto.ToString("N1")}");
            textBox12.Text = ($"El promedio más bajo fue: {promedioMasBajo.ToString("N1")}");
            textBox11.Text = ($"El total de personas reprobadas es: {personasReprobadas.ToString()}");

            string[] nombresRangos = new string[] { "0 –4.9", "5.0 –5.9", "6.0 –6.9", "7.0 –7.9", "8.0 –8.9", "9.0 –10" };
            double[] rangosInferiores = new double[] { 0, 5.0, 6.0, 7.0, 8.0, 9.0 };
            double[] rangosSuperiores = new double[] { 4.9, 5.9, 6.9, 7.9, 8.9, 10 };

            int[] personasEnRango = new int[6];

            for (int i = 0; i < 12; i++)
            {
                double suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma += Convert.ToDouble(dataGridView12[j, i].Value);
                }

                double promedio = suma / 3;

                for (int r = 0; r < 6; r++)
                {
                    if (promedio >= rangosInferiores[r] && promedio <= rangosSuperiores[r])
                    {
                        personasEnRango[r]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                dataGridView14[0, i].Value = nombresRangos[i];
                dataGridView14[1, i].Value = personasEnRango[i];
            }
        }





    }
}