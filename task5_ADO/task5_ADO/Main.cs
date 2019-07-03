using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task5_ADO.DAL.Model;
using task5_ADO.Services;

namespace task5_ADO
{
    public partial class Main : Form
    {
        string IDCategory; // строки для хранения выбранных пользователем индексов 
        string IDSupplier;
        string CityName;
        float ProdPrice;

        ServiceProd service = new ServiceProd();


        public Main()
        {
            InitializeComponent();
            IDCategory = String.Empty;
            IDSupplier = String.Empty;
            CityName = String.Empty;
            ProdPrice = 0f;            
        }

        

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {            
                this.Dispose();
                Application.Exit(); // при ручном закрытии формы            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Database.SetInitializer(new BDInitializer()); //  инициализация бд
            ListSubj(); // список категорий в comboBox
            ListSupplier();
            ListSupplierCity();
        }


        void ListSubj()
        {  // список категорий

            cbCategory.DataSource = service.GetCategory_List(); //вызов метода сервиса
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            cbCategory.Text = "Виберите категорию";
        }

        void ListSupplier()
        {  // список поставщиков

            cbSupplier.DataSource = service.GetSupplier_List(); //вызов метода сервиса
            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "SupplierId";
            cbSupplier.Text = "Виберите поставщика";
        }

        void ListSupplierCity()
        {  // список поставщиков

            cbSupplierCity.DataSource = service.GetSupplier_List(); //вызов метода сервиса
            cbSupplierCity.DisplayMember = "SupplierICity";
            cbSupplierCity.ValueMember = "SupplierICity";
            cbSupplierCity.Text = "Виберите город";
        }


        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDCategory = cbCategory.SelectedValue.ToString();
        }
        private void CbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDSupplier = cbSupplier.SelectedValue.ToString();
        }
        private void CbSupplierCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityName = cbSupplierCity.SelectedValue.ToString();
        }         


        private void BtQueryProdPerCategory_Click(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(IDCategory);
            dgvProd.DataSource = service.GetListViewProductByCatID(categoryID);
        }      

       
        private void BtQueryProdPerSupplier_Click(object sender, EventArgs e)
        {
           
            int supplierID = Convert.ToInt32(IDSupplier);
            dgvProd.DataSource = service.GetListViewProductByIdSup(supplierID);//вызов метода сервиса
        }

        private void BtQuerySupplierCity_Click(object sender, EventArgs e)
        {
           
            dgvProd.DataSource = service.GetListViewSupByCityName(CityName);//вызов метода сервиса
        }

        private void BtQueryPrice_Click(object sender, EventArgs e)
        {
            ProdPrice= (float)Convert.ToDouble(tbPrice.Text);
            dgvProd.DataSource = service.GetListViewProductByPrice(ProdPrice);//вызов метода сервиса
        }


    }

}
