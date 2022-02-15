using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppPart4
{
    public partial class DynamicFormElements : Form
    {
        public DynamicFormElements()
        {
            InitializeComponent();
        }

        private void createButtonsBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;
                btnTemp.Click += ShowButtonContent;
                buttonsPanel.Controls.Add(btnTemp);
            }
        }

        private void ShowButtonContent(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            MessageBox.Show("Click olunan button: " + text);
        }

        private void createTextBoxesBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                TextBox textBoxTemp = new TextBox();
                textBoxTemp.Text = "textbox: " + i.ToString();
                textBoxTemp.Size = new Size(120, 35);
                textboxPanel.Controls.Add(textBoxTemp);
            }
        }
    }
}
