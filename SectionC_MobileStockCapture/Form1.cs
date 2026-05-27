namespace SectionC_MobileStockCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtMake.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter values for all fields.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCode.Text, out int mobileCode))
            {
                MessageBox.Show("Please enter a valid integer for the mobile code.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string make = txtMake.Text;

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid integer for the quantity.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Record Deleted";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                lblOutput.Text = "Record Found";
            } else
            {
                lblOutput.Text = "Record NOT Found";
            }
        }
    }
}
