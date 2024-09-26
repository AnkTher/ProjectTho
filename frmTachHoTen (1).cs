using Calculator___lv_Medium;

namespace HoTen
{
    public partial class frmTachHoTen : Form
    {
        public frmTachHoTen()
        {
            InitializeComponent();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            lblShowHo.Text = ""; lblShowDem.Text = ""; lblShowTen.Text = "";
            string fullName = txtHoTen.Text;
            fullName = fullName.Trim();
            string[] ht = fullName.Split(" ");
            lblShowHo.Text = ht[0];
            int v1 = ht[0].Length;

            if (ht.Length > 1)
            {
                lblShowTen.Text = ht[ht.Length - 1];
                int v2 = ht[ht.Length - 1].Length;

                int v3 = fullName.Length;
                lblShowDem.Text = fullName.Substring(v1 + 1, v3 - v1 - v2 - 1);
            }

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
