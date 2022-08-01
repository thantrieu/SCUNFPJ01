using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Models;
using Controllers;

namespace Views
{
    // enum mô tả hành động đang thực hiện diễn ra trên tập dữ liệu nào
    public enum ActionType
    {
        NORMAL, SEARCH
    };

    public interface IViewControl
    {
        void AddNewItem<T>(T item);
        void UpdateItem<T>(T item);
    }

    public partial class HomeFrm : Form, IViewControl
    {
        private Controller _controller;
        private List<Item> _items;
        private List<Item> _searchResultItems;
        private ActionType _actionType;

        public HomeFrm()
        {
            InitializeComponent();
            _items = new List<Item>();
            _items.AddRange(Utils.CreateFakeItems());
            _controller = new Controller();
            _searchResultItems = new List<Item>();
            _actionType = ActionType.NORMAL;
            // read file
            ShowItems(_items);
        }

        // cập nhật để cho phép hoặc vô hiệu hóa các lựa chọn
        private void SearchItemSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboSearch.SelectedIndex;
            if (selectedIndex == 1 || selectedIndex == 4)
            {
                txtSearch.Enabled = false;
                labelItemFrom.Enabled = true;
                labelItemTo.Enabled = true;
                labelItemKey.Enabled = false;
                numericFrom.Enabled = true;
                numericTo.Enabled = true;
            }
            else
            {
                txtSearch.Enabled = true;
                labelItemFrom.Enabled = false;
                labelItemTo.Enabled = false;
                labelItemKey.Enabled = true;
                numericFrom.Enabled = false;
                numericTo.Enabled = false;
            }
        }

        // xử lý sự kiện nút tìm kiếm mặt hàng được click
        private void BtnSearchItemClick(object sender, EventArgs e)
        {
            if (comboSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm trước", "Lỗi tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSearch.Enabled && txtSearch.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập giá trị cần tìm trước", "Lỗi tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _actionType = ActionType.SEARCH;
                _searchResultItems.Clear();
                switch (comboSearch.SelectedIndex)
                {
                    case 0:
                        _searchResultItems.AddRange(_controller.FindBy(_items, _controller.IsNameMatch, txtSearch.Text));
                        break;
                    case 1:
                        _searchResultItems.AddRange(_controller.FindBy(_items, _controller.IsPriceMatch, (int)numericFrom.Value, (int)numericTo.Value));
                        break;
                    case 2:
                        _searchResultItems.AddRange(_controller.FindBy(_items, _controller.IsItemTypeMatch, txtSearch.Text));
                        break;
                    case 3:
                        _searchResultItems.AddRange(_controller.FindBy(_items, _controller.IsItemBrandMatch, txtSearch.Text));
                        break;
                    case 4:
                        _searchResultItems.AddRange(_controller.FindBy(_items, _controller.IsQuantityMatch, (int)numericFrom.Value, (int)numericTo.Value));
                        break;
                    default:
                        break;
                }
                if (_searchResultItems.Count > 0)
                {
                    ShowItems(_searchResultItems);
                }
                else
                {
                    var title = "Kết quả tìm kiếm";
                    var msg = "Không tìm thấy kết quả nào.";
                    ShowNoticeMessage(msg, title);
                }
            }
        }

        // xử lý sự kiện nút thêm mới được click
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if (sender.Equals(btnAddNewItem))
            {
                new AddUpdateItemFrm(this).Show();
            }
        }

        // thêm mới đối tượng vào danh sách tương ứng
        public void AddNewItem<T>(T t)
        {
            if (typeof(T) == typeof(Item))
            {
                var item = t as Item;
                _controller.AddNew(item, _items);
                dataGridViewItems.Rows.Add(
                new object[] {item.ItemId, item.ItemName, item.ItemType,
                item.Quantity, item.Brand, item.ReleaseDate.ToString("dd/MM/yyyy HH:mm:ss"), item.Price}
                );
            } else if(typeof(T) == typeof(Customer))
            {

            }
        }

        // cập nhật đối tượng sau khi sửa xong thông tin
        public void UpdateItem<T>(T t)
        {
            int index;
            if (typeof(T) == typeof(Item))
            {
                var item = t as Item;
                if (_actionType == ActionType.NORMAL)
                {
                    index = _controller.Edit(item, _items);
                }
                else
                {
                    _controller.Edit(item, _items);
                    index = _controller.Edit(item, _searchResultItems);
                }
                dataGridViewItems.Rows.RemoveAt(index);
                dataGridViewItems.Rows.Insert(index, new object[] {item.ItemId, item.ItemName, item.ItemType,
                item.Quantity, item.Brand, item.ReleaseDate.ToString("dd/MM/yyyy HH:mm:ss"), item.Price});
            } else if(typeof(T) == typeof(Customer))
            {

            }
        }

        // xử lý sự kiện khi 1 ô trong bảng được click
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridViewItems.Columns["edit"].Index)
            {
                Item item = _items[e.RowIndex];
                if(_actionType == ActionType.SEARCH)
                {
                    item = _searchResultItems[e.RowIndex];
                }
                new AddUpdateItemFrm(this, item).Show();
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == dataGridViewItems.Columns["remove"].Index)
            {
                var msg = "Bạn có chắc chắn muốn xóa bản ghi này?";
                var title = "Xác nhận xóa bản ghi";
                var result = ShowConfirmMessage(msg, title);
                if (result == DialogResult.Yes)
                {
                    if (_actionType == ActionType.SEARCH)
                    {
                        _controller.Remove(_searchResultItems[e.RowIndex], _items);
                    } else if(_actionType == ActionType.NORMAL)
                    {
                        _controller.Remove(_items[e.RowIndex], _items);
                    }
                    dataGridViewItems.Rows.RemoveAt(e.RowIndex);
                    title = "Xóa thành công";
                    msg = "Xóa bản ghi thành công!";
                    ShowNoticeMessage(msg, title);
                }
            }
        }

        // hiển thị hộp thoại thông báo kết quả
        private DialogResult ShowNoticeMessage(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // hiển thị hộp thoại yêu cầu xác nhận hành động
        private DialogResult ShowConfirmMessage(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        // xử lý sự kiện 1 nút radio button quản lý sắp xếp các mặt hàng được tick
        private void RadioSortItemCheckedChange(object sender, EventArgs e)
        {
            if (btnSortItemByPrice.Checked)
            {
                _controller.Sort(_controller.ComparePriceASC, _items);
            }
            else if (btnSortItemByPriceDESC.Checked)
            {
                _controller.Sort(_controller.ComparePriceDESC, _items);
            }
            else if (btnSortItemByName.Checked)
            {
                _controller.Sort(_controller.CompareName, _items);
            }
            else if (btnSortItemByQuantity.Checked)
            {
                _controller.Sort(_controller.CompareQuantity, _items);
            }
            else if (btnSortItemByDate.Checked)
            {
                _controller.Sort(_controller.CompareReleaseDate, _items);
            }
            ShowItems(_items);
        }

        // hiển thị danh sách các mặt hàng
        private void ShowItems(List<Item> items)
        {
            dataGridViewItems.Rows.Clear();
            if (items != null && items.Count > 0)
            {
                foreach (var item in items)
                {
                    dataGridViewItems.Rows.Add(new object[] {item.ItemId, item.ItemName, item.ItemType,
                item.Quantity, item.Brand, item.ReleaseDate.ToString("dd/MM/yyyy HH:mm:ss"), item.Price});
                }
            }
        }

        // xử lý sự kiện khi nút refresh được click
        private void BtnRefreshClick(object sender, EventArgs e)
        {
            ShowItems(_items);
            _actionType = ActionType.NORMAL;
        }
    }
}
