using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public delegate bool FindItemDelegate<T, V>(T item, V first, V second=default);
    public interface IController
    {
        void AddNew<T>(T t, List<T> elements);
        void Remove<T>(T t, List<T> elements);
        int Edit<T>(T t, List<T> elements);
        void Sort<T>(Comparison<T> comparer, List<T> elements);
        List<T> FindBy<T, V>(List<T> items, FindItemDelegate<T, V> del, V value1, V value2);
        int CalculatePoint(float amount);
        void ShowBestSeltItems(List<Object> objects);
        void ShowMostBoughtCustomer(List<Customer> customers);
        void ShowMonthlyRevenue(int year);
        void ShowDailyRevenue(int month);
        int IndexOf<T>(List<T> elements, T item);
    }
}
