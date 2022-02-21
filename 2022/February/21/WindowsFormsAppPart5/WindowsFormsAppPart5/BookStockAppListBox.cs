using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppPart5
{
    public partial class BookStockAppListBox : Form
    {
        public BookStockAppListBox()
        {
            InitializeComponent();
        }

        private void BookStockAppListBox_Load(object sender, EventArgs e)
        {
            //fillListBoxV1();
            fillListBoxV2();
        }

        void fillListBoxV1()
        {
            foreach (var item in VirtualDatabase.BooksTable)
            {
                lstbBooks.Items.Add(item);
            }
        }

        void fillListBoxV2()
        {
            lstbBooks.DataSource = VirtualDatabase.BooksTable;
        }

        private void lstbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCount = lstbBooks.SelectedItems.Count;

            if(selectedCount == 1)
            {
                ListBox lbox = (ListBox)sender;
                Book book = (Book)lbox.SelectedItem;

                bookPicture.Image = Image.FromFile(book.ImagePath);
                bookPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                bookNameText.Text = book.Name;
                bookCategoryText.Text = book.Category;
                bookCountText.Text = book.Count.ToString();
                bookAuthorText.Text = book.Author;
                bookDescriptionText.Text = book.Description;
            }
            else
            {
                List<Book> books = new List<Book>();
                foreach (var item in lstbBooks.SelectedItems)
                {
                    books.Add(item as Book);
                }
                MultipleListBoxResultView multiView = new MultipleListBoxResultView(books);
                multiView.ShowDialog();
            }
        }
    }
}
