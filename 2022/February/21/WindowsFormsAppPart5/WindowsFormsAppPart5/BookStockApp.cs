using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppPart5
{
    public partial class BookStockApp : Form
    {
        public BookStockApp()
        {
            InitializeComponent();
        }

        private void BookStoreApp_Load(object sender, EventArgs e)
        {
            //fillComboBoxV2();
            fillComboBoxV1();
        }

        void fillComboBoxV1()
        {
            foreach (var item in VirtualDatabase.BooksTable)
            {
                cmbBooks.Items.Add(item);
            }
        }

        void fillComboBoxV2()
        {
            cmbBooks.DataSource = VirtualDatabase.BooksTable;
        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book;

            //1-ci yol (casting ile)
            var selectedItem = cmbBooks.SelectedItem;
            book = (Book)selectedItem;

            //2-ci yol (as ile)
            book = cmbBooks.SelectedItem as Book;

            //check null
            book = cmbBooks.SelectedItem == null ? null : cmbBooks.SelectedItem as Book;

            //3-cü yol (sender'i ComboBox kimi alıb ComboBox'dan SelectedItem'i almaq.)
            ComboBox selectedComboBox = sender as ComboBox;
            book = selectedComboBox.SelectedItem == null ? null : selectedComboBox.SelectedItem as Book;

            bookNameText.Text = book.Name;
            bookCategoryText.Text = book.Category;
            bookCountText.Text = book.Count.ToString();
            bookAuthorText.Text = book.Author;
            bookDescriptionText.Text = book.Description;

            bookPicture.Image = Image.FromFile(book.ImagePath);
            bookPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            
            var selectedIndex = selectedComboBox.SelectedIndex;
        }
    }
}
