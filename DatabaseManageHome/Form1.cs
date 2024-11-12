namespace DataBaseManageHome
{
    public partial class homeForm : Form
    { 
        BindingSource buildingBindingSource = new BindingSource();
        public homeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void buttonListBuilding_Click(object sender, EventArgs e)
        {
            ManageDAO manageDAO = new ManageDAO();
            

            // connect the list to the grid view control
            buildingBindingSource.DataSource = manageDAO.GetAllBuildings();

            dataGridView1.DataSource = buildingBindingSource;
        }
    }
}
