using FluentValidation.Results;

namespace FluentValidationDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            CustomerService customerService = new CustomerService();
            Customer customer = new Customer { Id = new Guid(), Name = txtName.Text };

            var res = customerService.Validate(customer);
            if (!res.IsValid)
            {
                MessageBox.Show(res.Errors.FirstOrDefault().ErrorMessage, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var res1 = customerService.Add(customer);
                MessageBox.Show(res1);
            }
        }
    }
}