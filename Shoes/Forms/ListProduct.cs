using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes
{
    public partial class ListProducts : Form
    {
        ShoesDBDataSet.ProductCategoryStatusDataTable productCategoryStatusDataTable;
        ShoesDBDataSetTableAdapters.ProductCategoryStatusTableAdapter productCategoryStatus = new ShoesDBDataSetTableAdapters.ProductCategoryStatusTableAdapter();
        int sort = 0;

        public ListProducts()
        {
            InitializeComponent();

            if(Program.param.auth == false)
            {
                if (Program.param.userRow.IdRole == 1)
                    BtAdd.Visible = true;
                if(Program.param.userRow.IdRole != 1)
                    BtAdd.Visible = false;
            }            

            TbName.AutoSize = true;
            CbCategory.AutoSize = true;
            CbStatus.AutoSize = true;

            if (Program.param.auth == false)
                label6.Text = Program.param.userRow.Firstname + " " + Program.param.userRow.Lastname + " " + Program.param.userRow.Patronymic;
            else
                label6.Text = "Гость";

            ViewList();
            
        }
        
        private void ViewList()
        {
            flowLayoutPanelList.Controls.Clear();

            if (sort == 0)
                productCategoryStatusDataTable = productCategoryStatus.GetData();
            else if (sort == 1)
                productCategoryStatusDataTable = productCategoryStatus.GetDataBy(CbCategory.Text);
            else if (sort == 2)
                productCategoryStatusDataTable = productCategoryStatus.GetDataBy1(CbStatus.Text);
            else if (sort == 3)
                productCategoryStatusDataTable = productCategoryStatus.GetDataBy2(TbName.Text);

            foreach (var item in productCategoryStatusDataTable)
            {
                double Disk = Convert.ToDouble(item.Price) * Convert.ToDouble(item.Discount);
                double priceDisk = Convert.ToDouble(item.Price) - Disk;

                var content = $"Наименование товара: {item.nameProduct} \n" +
                    $"Категория: {item.Title} \n" +
                    $"Цена без скидки: {item.Price}\n" +
                    $"Скидка: {Convert.ToDouble(item.Discount) * 100}%\n" +
                    $"Цена со скидкой: {priceDisk}\n" +
                    $"Бренд: {item.Manufacturer}\n";

                var control = new ListControl(Resource1.ak12_gus_5808_free_13355_1080);
                control.Context = content;
                flowLayoutPanelList.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanelList.WrapContents = false;
                flowLayoutPanelList.AutoScroll = true;                
                flowLayoutPanelList.Controls.Add(control);
            }
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = 1;
            ViewList();
            TbName.Clear();
        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = 2;
            ViewList();            
            TbName.Clear();
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            sort = 3;
            ViewList();            
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
