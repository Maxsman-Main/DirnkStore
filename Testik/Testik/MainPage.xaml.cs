using Xamarin.Forms;
using System.Collections.Generic;

namespace Testik
{
    public partial class MainPage : ContentPage
    {
        private Counter _counter;
        private Shelf _shelf;

        public MainPage()
        {
            InitializeComponent();
            _counter = new Counter();
            _shelf = new Shelf();
            shelf.ItemsSource = _shelf.ProductsNames;
        }

        private void IncreaseButtonClicked(object sender, System.EventArgs e)
        {
            _counter.Increase();
            productCounter.Text = _counter.Value.ToString();
        }

        private void ReduceButtonClicked(object sender, System.EventArgs e)
        {
            _counter.Reduce();
            productCounter.Text = _counter.Value.ToString();
        }

        private void ShelfProductChanged(object sender, System.EventArgs e)
        {
            Product product = _shelf.GetProductByID(((Picker)sender).SelectedIndex);
            shelfImage.Source = product.Image;
        }
    }
}
