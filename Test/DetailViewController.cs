using System;

using UIKit;

namespace Test
{
    public partial class DetailViewController : UIViewController
    {
        public object DetailItem { get; set; }

        protected DetailViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void SetDetailItem(object newDetailItem)
        {
            if (DetailItem != newDetailItem)
            {
                DetailItem = newDetailItem;

                // Update the view
                ConfigureView();
            }
        }

        void ConfigureView()
        {
            // Update the user interface for the detail item
            if (IsViewLoaded && DetailItem != null)
                detailDescriptionLabel.Text = DetailItem.ToString();

            Test();
            Test2();
            Test3();
            Test4();
            Test5();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            ConfigureView();
        }

        void Test()
        {
            
        }

        void Test2()
        {

        }

        void Test3()
        {

        }

        void Test4()
        {

        }

        void Test5()
        {

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

