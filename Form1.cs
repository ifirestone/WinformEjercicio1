namespace WinFormsProgramacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void llenado(int valor)
        {
            pb_progreso.Visible = true;
            lbl_progreso.Visible=true;
            int current = pb_progreso.Value;

            if(current + valor > 100)
            {
                pb_progreso.Value = 100;
                lbl_progreso.Text = "100%";
            } else {
                pb_progreso.Value = current + valor;
                lbl_progreso.Text = (current + valor).ToString() + "%";
            }

            
        }

        private void limpiar()
        {
            pb_progreso.Visible = false;
            lbl_progreso.Visible= false;
            pb_progreso.Value = 0;
            lbl_progreso.Text = "0%";
        }

        private void btn_progreso_Click(object sender, EventArgs e)
        {
            llenado(10);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}