using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NameGeneratorMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : CarouselPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            string[] array = {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"};
            ListViewNames.ItemsSource = array;
            ListViewLists.ItemsSource = array;
        }

        private void ButtonGenerate_Clicked(object sender, EventArgs e)
        {
            string[] array1 = (string[])ListViewNames.ItemsSource;
            string[] array2 = {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"};

            string[] newArray = new string[array1.Length + array2.Length];
            Array.Copy(array1, newArray, array1.Length);
            Array.Copy(array2, 0, newArray, array1.Length, array2.Length);
            ListViewNames.ItemsSource = newArray;
            ListViewLists.ItemsSource = newArray;
        }
    }
}