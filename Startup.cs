namespace Voter_Registration_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void pBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSchedule.Height;
            sidePanel.Top = btnSchedule.Top;
            schedTab schedTab = new schedTab();
            schedTab.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnLogin.Height;
            sidePanel.Top = btnLogin.Top;
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRegister.Height;
            sidePanel.Top = btnRegister.Top;
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
