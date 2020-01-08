using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitOrg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //variable koje ce se koristiti
        String author, title, isbn, yearOi, publisher, binding, nmbrOfPgs;

        //FILTER
        private void btnFilter_Click(object sender, EventArgs e)
        {
            String selectedFilter = cbFilters.SelectedText;

            getAllDataFromTxtFields();

            //query upit sa ovim podatcima
            if (rbtnAsc.Checked && !rbtnDsc.Checked)
            {
                //filtrira uzlazno
            }
            else if (!rbtnAsc.Checked && rbtnDsc.Checked)
            {
                //filtrira silazno
            }
        
        }

        //DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            getAllDataFromTxtFields();
            //query upit sa ovim podatcima
        }

        //UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getAllDataFromTxtFields();
            //query upit sa ovim podatcima
        }

        //FIND
        private void btnFind_Click(object sender, EventArgs e)
        {
            getAllDataFromTxtFields();
            //query upit sa ovim podatcima
        }

        //ADD
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            getAllDataFromTxtFields();
            //query upit sa ovim podatcima
        }



        //metode
        private void getAllDataFromTxtFields()
        {
            author = txtboxAuthor.Text.ToString();
            title = txtboxTitle.Text.ToString();
            isbn = txtboxISBN.Text.ToString();
            yearOi = txtboxYearOI.Text.ToString();
            publisher = txtboxPublisher.Text.ToString();
            binding = txtboxBinding.Text.ToString();
            nmbrOfPgs = txtboxNmbrOfPages.Text.ToString();
        }
    }
}
