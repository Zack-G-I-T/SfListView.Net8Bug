namespace SfListViewBug
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            int[] items = new int[]
            {
                0,1,2,3,4,5
            };
            listView.ItemsSource = items;
        }

    }

}
