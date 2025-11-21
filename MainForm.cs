
namespace WinFormsApp1
{
    public partial class MainForm : Form, IAppMainScreenNavigator 
    {
        public event Action<string> SwitchScreenRequested;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            SwitchScreenRequested?.Invoke(AppContext.ScreenSwitchContext.Dashboard);
        }
        private void button_statistic_Click(object sender, EventArgs e)
        {
            SwitchScreenRequested?.Invoke(AppContext.ScreenSwitchContext.Statistic);
        }
        private void button_WalletManagement_Click(object sender, EventArgs e)
        {
            SwitchScreenRequested?.Invoke(AppContext.ScreenSwitchContext.WalletsManagement);
        }
        private void button_noti_Click(object sender, EventArgs e)
        {
            SwitchScreenRequested?.Invoke(AppContext.ScreenSwitchContext.Notifications);
        }
        private void button_QuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            SwitchScreenRequested?.Invoke(AppContext.ScreenSwitchContext.CategoriesManagement);
        }

        public void ShowMesssage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowMainContent(UserControl mainContent)
        {
            panel_content.Controls.Clear();
            mainContent.Dock = DockStyle.Fill;
            panel_content.Controls.Add(mainContent);
        }
    }
}
