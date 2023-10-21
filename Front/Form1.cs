using System.Security.Permissions;
using Back;


namespace Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {


           

            



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = Principal.context;
            
            context.Database.EnsureCreated();
        }
    }
}