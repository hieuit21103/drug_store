using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class Home : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private int type;
        private string username;

        public Home(string username, int type)
        {
            InitializeComponent();
            this.username = username;
            this.type = type;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 42);
            panelMenu.Controls.Add(leftBorderBtn);
            // tu dong full form && thay doi kich thuoc theo click
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // doi icon nut home
                ibtnHome.IconChar = currentBtn.IconChar;
                ibtnHome.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            ibtnHome.IconChar = IconChar.Home;
            ibtnHome.IconColor = Color.MediumPurple;
            lblHome.Text = "Home";
        }
        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;
        }
        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void ibtnAddMedicine_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                OpenChildForm(new Add());
            }
        }
        private void ibtnNewMedicine_Click(object sender, EventArgs e)
        {
            OpenChildForm(new List(this, type));
        }

        private void ibtnMedicineVlyCheck_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ValidCheck());
        }

        private void ibtnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile(username,type));
        }

        private void ibtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sell(this,username));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer(this,username));
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Report());
        }
    }
}
