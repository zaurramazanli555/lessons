using AppPayment.DBModel;
using AppPayment.ModelCLass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPayment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbvendor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (PaymentContext context = new PaymentContext())
            {
                // object[] vendors = context.Vendors.;
                //List object tipinde deyil
                FillComboboxVendor();
                FillComboboxDepartment();
                FillComboboxDestinition();
                FillComboboxCompany();
                FillComboboxPaymentStatuses();
                FillComboboxDocumentStatuses();
            }
        }
        private void FillComboboxVendor()
        {
            using (PaymentContext c = new PaymentContext())
            {
                List<Vendor> vendors = c.Vendors.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Rows.Add(0, "");
                foreach (Vendor item in vendors)
                {
                    dt.Rows.Add(item.Id, item.Decription);
                }
                cmbvendor.ValueMember = dt.Columns[0].ColumnName;
                cmbvendor.DisplayMember = dt.Columns[1].ColumnName;
                cmbvendor.DataSource = dt;

            }
        }
        private void FillComboboxCompany()
        {
            using (PaymentContext c = new PaymentContext())
            {
                List<Company> companies = c.Companies.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Rows.Add(0, "");
                foreach (Company item in companies)
                {
                    dt.Rows.Add(item.Id, item.Decription);
                }
                cmbsirket.ValueMember = dt.Columns[0].ColumnName;
                cmbsirket.DisplayMember = dt.Columns[1].ColumnName;
                cmbsirket.DataSource = dt;

            }
        }
        private void FillComboboxDepartment()
        {
            using (PaymentContext c = new PaymentContext())
            {
                List<Department> departments = c.Departments.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Rows.Add(0, "");
                foreach (Department item in departments)
                {
                    dt.Rows.Add(item.Id, item.Decription);
                }
                cmbdepartament.ValueMember = dt.Columns[0].ColumnName;
                cmbdepartament.DisplayMember = dt.Columns[1].ColumnName;
                cmbdepartament.DataSource = dt;

            }
        }
        private void FillComboboxDestinition()
        {
            using (PaymentContext c = new PaymentContext())
            {
                List<Destinition> destinitions = c.Destinitions.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Columns.Add("surnamename");
                dt.Rows.Add(0, "");
                foreach (Destinition item in destinitions)
                {
                    dt.Rows.Add(item.Id, item.Decription,item.Name);
                }
                cmbteyinat.ValueMember = dt.Columns[0].ColumnName;
                cmbteyinat.DisplayMember = dt.Columns[1].ColumnName;
                cmbteyinat.DisplayMember = dt.Columns[2].ColumnName;
               // cmbteyinat.DisplayMember = dt.Columns[1].ColumnName;
                cmbteyinat.DataSource = dt;

            }
        }
        private void FillComboboxPaymentStatuses()
        {
            using (PaymentContext c = new PaymentContext())
            {
                List<PaymentStatus> paymentStatuses = c.PaymentStatuses.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Rows.Add(0, "");
                foreach (PaymentStatus item in paymentStatuses)
                {
                    dt.Rows.Add(item.Id, item.Name);
                }
                cmbPaymentStatus.ValueMember = dt.Columns[0].ColumnName;
                cmbPaymentStatus.DisplayMember = dt.Columns[1].ColumnName;
                cmbPaymentStatus.DataSource = dt;

            }
        }
        private void FillComboboxDocumentStatuses()
        {
            using (PaymentContext c = new PaymentContext())
            {
                List<DocumentStatus> documentStatuses = c.DocumentStatuses.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Rows.Add(0, "");
                foreach (DocumentStatus item in documentStatuses)
                {
                    dt.Rows.Add(item.Id, item.Name);
                }
                cmbDocstatus.ValueMember = dt.Columns[0].ColumnName;
                cmbDocstatus.DisplayMember = dt.Columns[1].ColumnName;
                cmbDocstatus.DataSource = dt;

            }
        }

        private void cmbsirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = cmbsirket.SelectedItem.ToString();
            string item3 = cmbsirket.SelectedIndex.ToString();
            string kod = cmbsirket.SelectedText.ToString();
            //string kod112 = cmbsirket.selec.ToString();
            string kod2 = cmbsirket.SelectedValue.ToString();
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (PaymentContext db = new PaymentContext())
            {
                DocumentPayment dp = new DocumentPayment();
                dp.DocumentNumber = txtdocno.Text;
                dp.InvoiceNumber = txtInvNo.Text;
                dp.InvoiceDate = datetmInvDate.Value;
                dp.Deadline = datetimeDeadline.Value;
                dp.Note = txtNote.Text;
                dp.Qeyd = txtqeyd.Text;
                var dateDiff = dp.Deadline.Subtract(dp.InvoiceDate);
                dp.DifDeadAndInvDate = dateDiff.Days;
                dp.CurrrencyCode = cmbcurrencycode.SelectedItem.ToString();
                dp.IsDeleted = false;
                dp.Amount =decimal.Parse(txtInvMebleg.Text);
                string companyidstr = cmbsirket.SelectedValue.ToString();
                int companyid = int.Parse(companyidstr);
                Company company = db.Companies.FirstOrDefault(x => x.Id == companyid);
                dp.Company = company;

                string vendorIdstr = cmbvendor.SelectedValue.ToString();
                int vendorId = int.Parse(vendorIdstr);
                Vendor vendor = db.Vendors.FirstOrDefault(x => x.Id == vendorId);
                dp.Vendor = vendor;

                string departmentIdstr = cmbdepartament.SelectedValue.ToString();
                int departmentId = int.Parse(departmentIdstr);
                Department department = db.Departments.FirstOrDefault(x => x.Id == departmentId);
                dp.Department = department;

                string destinitionIdstr = cmbteyinat.SelectedValue.ToString();
                int destinitionId = int.Parse(destinitionIdstr);
                Destinition desstinition = db.Destinitions.FirstOrDefault(x => x.Id == destinitionId);
                dp.Destinition = desstinition;
                dp.CreateDate = DateTime.Now;
                User user = db.Users.FirstOrDefault(x => x.Id == 1);
                dp.CreateUser = user;
                dp.DocumentName = "TestSened";

                DocumentStatus documentStatus = db.DocumentStatuses.FirstOrDefault(x => x.Id == 1);
                dp.DocumentStatus = documentStatus;
                dp.EditDate = DateTime.Now;
                dp.PaymentTypeId = 1;

                PaymentStatus paymentStatus = db.PaymentStatuses.FirstOrDefault(x => x.Id == 1);
                dp.PaymentStatus = paymentStatus;
                /*
                 
        public PaymentStatus PaymentStatus { get; set; }
        ICollection<Payment> payments { get; set; }

                 * */



                db.DocumentPayments.Add(dp);
                db.SaveChanges();
                MessageBox.Show("Ugurlar elave edildi!!!");

            }
        }
    }
}
