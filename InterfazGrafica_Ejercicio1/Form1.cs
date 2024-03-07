namespace datos_alumno
{
    public partial class Form1 : Form
    {
        int matricula, edad;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_matricula_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        private void lbl_apellido_Click(object sender, EventArgs e)
        {

        }

        private void lbl_edad_Click(object sender, EventArgs e)
        {

        }

        private void lbl_carrera_Click(object sender, EventArgs e)
        {

        }

        private void txt_pasar_Click(object sender, EventArgs e)
        {
            matricula = int.Parse(txt_matricula.Text);
            edad = int.Parse(txt_edad.Text);
            lbl_matricula.Text = matricula.ToString();
            lbl_nombre.Text = txt_nombre.Text;
            lbl_apellido.Text = txt_apellido.Text;
            lbl_edad.Text = edad.ToString();
            lbl_carrera.Text = txt_carrera.Text;

        }

        private void txt_limpiar_Click(object sender, EventArgs e)
        {
            txt_carrera.Clear();
            txt_apellido.Clear();
            txt_edad.Clear();
            txt_matricula.Clear();
            txt_nombre.Clear();
        }

        private void txt_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}