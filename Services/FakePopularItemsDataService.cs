using System;
using System.Collections.ObjectModel;
using DemoApp.Model;

namespace DemoApp.Services
{
    public class FakePopularItemsDataService
    {
        public ObservableCollection<PopularItem> GetPopularItems()
        {
            return new ObservableCollection<PopularItem>
            {
                new PopularItem
                {
                    ImageUrl="Option1",
                    ProductName="Millonario State Cafe",
                    Description="Deli - Pizza - Breakfast and Brunch",
                    Rating=" 4.5 (98) ",
                    IntervalTime="10-15 min"
                },
                new PopularItem
                {
                    ImageUrl="Option2",
                    ProductName="Burger State",
                    Description="Burgers - Pizza",
                    Rating=" 4.0 (90) ",
                    IntervalTime="10-15 min"
                },
                new PopularItem
                {
                    ImageUrl="Option3",
                    ProductName="Burger Burger",
                    Description="Breakfast and Brunch",
                    Rating=" 4.9 (100) ",
                    IntervalTime="10-15 min"
                }
            };
        }
    }
}
