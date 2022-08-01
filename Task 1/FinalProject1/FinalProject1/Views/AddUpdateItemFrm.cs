using System;
using System.Windows.Forms;
using Models;

namespace Views
{
    public partial class AddUpdateItemFrm : Form
    {
        private IViewControl _viewControl;

        public AddUpdateItemFrm()
        {
            InitializeComponent();
        }

        public AddUpdateItemFrm(IViewControl view, Item item = null) : this()
        {
            _viewControl = view;
            if(item != null)
            {
                ShowData(item);
                btnAdd.Text = "Cập nhật";
            }
        }

        private void ShowData(Item item)
        {
            txtId.Text = $"{item.ItemId}";
            txtName.Text = item.ItemName;
            txtPrice.Text = $"{item.Price}";
            numericQuantity.Value = item.Quantity;
            txtBrand.Text = item.Brand;
            dateTimePickerProductDate.Value = item.ReleaseDate;
            for (int i = 0; i < comboBoxItemType.Items.Count; i++)
            {
                if (item.ItemType.CompareTo(comboBoxItemType.Items[i]) == 0)
                {
                    comboBoxItemType.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var itemName = txtName.Text;
            var itemType = comboBoxItemType.Text;
            var itemPrice = int.Parse(txtPrice.Text);
            var quantity = (int)numericQuantity.Value;
            var brand = txtBrand.Text;
            var manufactureDate = dateTimePickerProductDate.Value;
            Item item = new Item(id, itemName, itemType, 
                quantity, brand, manufactureDate, itemPrice);
            if("Cập nhật".CompareTo(btnAdd.Text) == 0)
            {
                var msg = "Bạn có chắc chắn muốn xóa bản ghi này?";
                var title = "Xác nhận xóa bản ghi";
                var result = ShowConfirmMessage(msg, title);
                if (result == DialogResult.Yes)
                {
                    _viewControl.UpdateItem(item);
                    Dispose();
                }
            } else
            {
                _viewControl.AddNewItem(item);
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private DialogResult ShowConfirmMessage(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
