using System.Security.Permissions;
using Back;


namespace Front
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {


           

            



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = Principal.context;
            
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}