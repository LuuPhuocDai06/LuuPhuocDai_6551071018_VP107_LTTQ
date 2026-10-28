namespace LuuPhuocDai_6551071018_VP107_LTTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // các pannel.
        private void panel1_ttMonHoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_dsMonHoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_nutChucNang_Paint(object sender, PaintEventArgs e)
        {

        }


        // các label.
        private void label1_ttMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void label2_dsMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void label3_maMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void label4_tenMonHoc_Click(object sender, EventArgs e)
        {

        }

        // các textbox

        private void textBox1_maMonHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_tenMonHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_soTinChi_TextChanged(object sender, EventArgs e)
        {

        }


        // các buuton
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             var resutl = MessageBox.Show("Bạn có muốn thoát chương trình không!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(resutl.ToString().Equals("Yes"))
            {
                Close();
            }
        }
    }
}
