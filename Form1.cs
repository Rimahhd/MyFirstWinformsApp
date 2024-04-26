using System.Data;
using System.Windows.Forms;

namespace MyFirstWinformsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("You have choosed the image.");
                MyPhotoBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            String data = String.Empty;
            data = "\n" + NametextBox.Text + "\n" + PhoneTextBox.Text + "\n"
                + DOBTextBox.Text + "\n" + EmailTextBox.Text + "\n"
                + TripdateTimePicker.Value.ToString() + "\n"
                + comboBox1.SelectedItem.ToString() + "\n" + 
                comboBox2.SelectedItem.ToString() + "\n" +
                checkBox1.CheckState.ToString();
            DialogResult res = MessageBox.Show("You Have Entered the following data : " + data);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("You have clicked Ok Button");
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked Cancel Button");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = comboBox2.SelectedIndex;
        }
    }
}