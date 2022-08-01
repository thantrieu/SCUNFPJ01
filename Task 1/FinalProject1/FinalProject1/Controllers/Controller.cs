using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controllers
{
    public class Controller : IController
    {
        public void AddNew<T>(T t, List<T> elements)
        {
            elements.Add(t);
        }

        public int CalculatePoint(float amount)
        {
            throw new NotImplementedException();
        }

        public int Edit<T>(T t, List<T> elements)
        {
            int updatedIndex = elements.IndexOf(t);
            elements.Remove(t);
            elements.Insert(updatedIndex, t);
            return updatedIndex;
        }

        public List<T> FindBy<T, V>(List<T> items, 
            FindItemDelegate<T, V> del, V value1, V value2=default)
        {
            List<T> result = new List<T>();
            foreach (var item in items)
            {
                if(del(item, value1, value2))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public void Remove<T>(T t, List<T> elements)
        {
            elements.Remove(t);
        }

        public void ShowBestSeltItems(List<object> objects)
        {
            throw new NotImplementedException();
        }

        public void ShowDailyRevenue(int month)
        {
            throw new NotImplementedException();
        }

        public void ShowMonthlyRevenue(int year)
        {
            throw new NotImplementedException();
        }

        public void ShowMostBoughtCustomer(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public void Sort<T>(Comparison<T> comparer, List<T> elements)
        {
            elements.Sort(comparer);
        }

        // thiết lập điều kiện sắp xếp tăng dần theo giá
        public int ComparePriceASC(Item item1, Item item2)
        {
            return item1.Price - item2.Price;
        }

        // thiết lập điều kiện sắp xếp giảm dần theo giá
        public int ComparePriceDESC(Item item1, Item item2)
        {
            return item2.Price - item1.Price;
        }

        // thiết lập điều kiện sắp xếp tăng dần theo tên
        public int CompareName(Item item1, Item item2)
        {
            return item1.ItemName.CompareTo(item2.ItemName);
        }

        // thiết lập điều kiện sắp xếp tăng dần theo số lượng
        public int CompareQuantity(Item item1, Item item2)
        {
            return item1.Quantity - item2.Quantity;
        }

        // thiết lập điều kiện sắp xếp tăng dần theo ngày sản xuất
        public int CompareReleaseDate(Item item1, Item item2)
        {
            if(item1.ReleaseDate < item2.ReleaseDate)
            {
                return -1;
            } else if(item1.ReleaseDate == item2.ReleaseDate)
            {
                return 0;
            } else
            {
                return 1;
            }
        }

        // lấy chỉ số của phần tử trong danh sách các phần tử
        public int IndexOf<T>(List<T> elements, T item)
        {
            return elements.IndexOf(item);
        }

        // so khớp theo tên
        public bool IsNameMatch(Item item, string name, string other = null)
        {
            var pattern = $".*{name}.*";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(item.ItemName);
        }

        // so khớp theo khoảng giá
        public bool IsPriceMatch(Item item, int priceFrom, int priceTo)
        {
            if(item.Price >= priceFrom && item.Price <= priceTo)
            {
                return true;
            }
            return false;
        }

        // so khớp theo loại mặt hàng
        public bool IsItemTypeMatch(Item item, string type, string other=null)
        {
            var pattern = $".*{type}.*";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(item.ItemType);
        }

        // so khớp theo hãng sản xuất
        public bool IsItemBrandMatch(Item item, string brand, string other = null)
        {
            var pattern = $".*{brand}.*";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(item.Brand);
        }

        // so khớp theo số lượng
        public bool IsQuantityMatch(Item item, int quantity, int other)
        {
            return item.Quantity >= quantity && item.Quantity <= other;
        }
    }
}
