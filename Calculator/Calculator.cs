namespace Calculator
{
    public partial class Calculator : Form
    {
        public static float angkaF = 0;
        public static float angkaS = 0;
        public Calculator()
        {
            InitializeComponent();
        }
        private void parsing()
        {
            angkaF = float.Parse(txtAngka1.Text);
            angkaS = float.Parse(txtAngka2.Text);
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            parsing();
            float hasil;
            hasil = angkaF + angkaS;
            txtHasil.Text = hasil.ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            parsing();
            float hasil;
            hasil = angkaF * angkaS;
            txtHasil.Text = hasil.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            parsing();
            float hasil;
            hasil = angkaF - angkaS;
            txtHasil.Text = hasil.ToString();
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            parsing();
            float hasil;
            hasil = angkaF / angkaS;
            txtHasil.Text = hasil.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAngka1.Text = "";
            txtAngka2.Text = "";
            txtHasil.Text = "";
        }
    }
}