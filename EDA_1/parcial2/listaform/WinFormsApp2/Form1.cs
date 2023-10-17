namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private GestorArticulos gestorArticulos = new GestorArticulos();
        private Practica2 practica2 = new Practica2();
        private GestorAlumnos gestorAlumnos = new GestorAlumnos();
        private GestionProductos gestionProductos = new GestionProductos();
        private GestorPalabras gestorPalabras = new GestorPalabras();
        private GestionPalabrasInvertidas gestionPalabrasInvertidas = new GestionPalabrasInvertidas();
        private ValidadorPalindromo validadorPalindromo = new ValidadorPalindromo();





        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;
            groupBox19.Visible = false;








        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button10_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox5.Visible = true;



            // Obtener y mostrar los productos disponibles
            List<Articulo> productosDisponibles = gestorArticulos.ObtenerArticulosDisponibles();

            // Construir el texto para el label
            string textoLabel = "Productos Disponibles:\n";
            foreach (Articulo articulo in productosDisponibles)
            {
                textoLabel += $"Nombre: {articulo.Nombre}, ID: {articulo.ID}, Precio: {articulo.Precio}, Cantidad: {articulo.Cantidad}\n";
            }

            // Actualizar el texto del label
            label28.Text = textoLabel;

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }


        private void button17_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

            groupBox3.Visible = false;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;


        }

        private void button16_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;




        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;
            groupBox19.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;

            groupBox3.Visible = true;
            groupBox4.Visible = false;

            groupBox5.Visible = false;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;


        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            List<int> numerosAleatorios = practica2.GenerarNumerosAleatorios(10);
            textBox3.Text = string.Join(", ", numerosAleatorios);

            Tuple<List<int>, List<int>> paresImpares = practica2.SepararParesImpares(numerosAleatorios);
            textBox4.Text = string.Join(", ", paresImpares.Item2);
            textBox5.Text = string.Join(", ", paresImpares.Item1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;





        }

        private void button25_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;


        }

        private void button22_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = true;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorAlumnos.ObtenerAprobados();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = gestorAlumnos.ObtenerReprobados();

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {


        }

        private void button21_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = true;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;


        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox6.Text;
                double calificacion1 = Convert.ToDouble(textBox7.Text);
                double calificacion2 = Convert.ToDouble(textBox8.Text);
                double calificacion3 = Convert.ToDouble(textBox9.Text);

                Alumno alumno = new Alumno(nombre, calificacion1, calificacion2, calificacion3);
                gestorAlumnos.AgregarAlumno(alumno);
                MessageBox.Show("Alumno registrado con éxito.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en el rango de 1 al 10.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = true;
            groupBox12.Visible = false;
            groupBox13.Visible = false;


        }

        private void button35_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = true;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                int clave = Convert.ToInt32(textBox12.Text);
                string nombre = textBox10.Text;
                double precio = Convert.ToDouble(textBox11.Text);

                gestionProductos.AgregarProducto(clave, nombre, precio);
                MessageBox.Show("Producto agregado con éxito.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                int clave = Convert.ToInt32(textBox13.Text);
                gestionProductos.EliminarProducto(clave);
                MessageBox.Show("Producto eliminado con éxito.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa una clave válida.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = true;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = true;

            // Limpiamos el DataGridView3 antes de agregar datos
            dataGridView3.Rows.Clear();

            // Añadimos las columnas al DataGridView3 si aún no están agregadas
            if (dataGridView3.Columns.Count == 0)
            {
                dataGridView3.Columns.Add("Clave", "Clave");
                dataGridView3.Columns.Add("Nombre", "Nombre");
                dataGridView3.Columns.Add("Precio", "Precio");
            }

            // Obtenemos la lista de productos
            List<Producto> productos = gestionProductos.ObtenerProductosOrdenadosPorNombre();

            // Agregamos los productos al DataGridView3
            foreach (Producto producto in productos)
            {
                dataGridView3.Rows.Add(producto.Clave, producto.Nombre, producto.Precio);
            }

            // Añadimos la columna al DataGridView4 si aún no está agregada
            if (dataGridView4.Columns.Count == 0)
            {
                dataGridView4.Columns.Add("Total", "Total");
            }

            // Calculamos el costo total y lo mostramos en el DataGridView4
            double costoTotal = gestionProductos.CalcularCostoTotal();
            dataGridView4.Rows.Clear(); // Limpiamos el DataGridView4 antes de agregar datos
            dataGridView4.Rows.Add(costoTotal); // Agregamos el monto total como una fila
        }


        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = true;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = true;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;

        }

        private void button33_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = true;
            groupBox13.Visible = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = true;

        }

        private void button40_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = true;


            Dictionary<char, List<string>> palabrasPorLetra = gestorPalabras.ObtenerPalabrasPorLetra();
            string resultado = "";

            foreach (var kvp in palabrasPorLetra)
            {
                char letra = kvp.Key;
                List<string> palabras = kvp.Value;

                resultado += $"Palabras con la letra '{letra}': {string.Join(", ", palabras)}\n";
            }


            label22.Text = resultado;
            listBox3.Items.Clear();

            List<string> palabrasAgregadas = new List<string>();
            foreach (var listaDeLetra in gestorPalabras.ObtenerPalabrasPorLetra())
            {
                palabrasAgregadas.AddRange(listaDeLetra.Value);
            }

            foreach (string palabra in palabrasAgregadas)
            {
                listBox3.Items.Add(palabra);
            }
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            string palabra = textBox14.Text.Trim(); // Eliminar espacios al inicio y al final

            // Verificar si la palabra contiene solo letras
            if (System.Text.RegularExpressions.Regex.IsMatch(palabra, @"^[a-zA-Z]+$"))
            {
                gestorPalabras.AgregarPalabra(palabra);
                MessageBox.Show("Palabra agregada: " + palabra);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa solo letras.");
            }
        }


        private void button42_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = true;
            groupBox15.Visible = false;
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = true;
            groupBox15.Visible = false;
            groupBox16.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = true;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;


        }

        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = true;
            groupBox18.Visible = false;


        }

        private void button45_Click(object sender, EventArgs e)
        {
            string palabra = textBox15.Text.Trim(); // Eliminar espacios al inicio y al final

            // Verificar si la palabra contiene solo letras
            if (System.Text.RegularExpressions.Regex.IsMatch(palabra, @"^[a-zA-Z]+$"))
            {
                List<string> palabras = new List<string>();
                palabras.Add(palabra);

                List<string> palabrasInvertidas = gestionPalabrasInvertidas.InvertirPalabras(palabras);

                if (palabrasInvertidas.Count > 0)
                {
                    MessageBox.Show("Tu palabra invertida es: " + palabrasInvertidas[0]);
                }
                else
                {
                    MessageBox.Show("No se pudo invertir la palabra.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa palabras validas.");
            }
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
        }

        private void groupBox18_Enter(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            string palabra = textBox16.Text;

            // Utilizamos una expresión regular para verificar si solo contiene letras
            if (System.Text.RegularExpressions.Regex.IsMatch(palabra, @"^[a-zA-Z]+$"))
            {
                if (validadorPalindromo.EsPalindromo(palabra))
                {
                    MessageBox.Show("La palabra '" + palabra + "' es un palíndromo.");
                }
                else
                {
                    MessageBox.Show("La palabra '" + palabra + "' no es un palíndromo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa palabras validas.");
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = true;

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;

            gestorArticulos.AgregarArticuloAleatorio();

            Articulo articuloAgregado = gestorArticulos.ObtenerArticulosDisponibles().Last();

            MessageBox.Show($"Se ha agregado el {articuloAgregado.Nombre} con ID {articuloAgregado.ID}, cantidad {articuloAgregado.Cantidad} y precio {articuloAgregado.Precio}");
        }



        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            bool productoEliminado = gestorArticulos.RetirarArticuloPorID(id);

            if (productoEliminado)
            {
                MessageBox.Show($"El producto con ID {id} ha sido eliminado correctamente.");
            }
            else
            {
                MessageBox.Show($"El producto con ID {id} no existe.");
            }
        }

        private void dataGridView5_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;
            groupBox19.Visible = true;


            List<Articulo> productosRetirados = gestorArticulos.ObtenerArticulosRetirados();
            string textoLabel = "Productos Eliminados:\n";

            foreach (Articulo articulo in productosRetirados)
            {
                textoLabel += $"Nombre: {articulo.Nombre}, ID: {articulo.ID}, Precio: {articulo.Precio}, Cantidad: {articulo.Cantidad}\n";
            }

            label27.Text = textoLabel;
        }
        private void dataGridView5_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void groupBox19_Enter(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;
            groupBox19.Visible = false;
        }
    }

}