#region Using namespaces
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
#endregion
namespace Magic.VSPackage1
{
    /// <summary>
    /// Interaction logic for MyControl.xaml
    /// </summary>
    public partial class MyControl
    {
        #region Private member methods
        readonly DispatcherTimer _timer;
        int _counter; 
        #endregion

        #region Constructor
        /// <summary>
        /// Public Constructor
        /// </summary>
        public MyControl()
        {
            InitializeComponent();
            _timer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 2) };
            _timer.Tick += TimerTick;
        } 
        #endregion

        #region Private member methods
        /// <summary>
        /// Play slide show
        /// </summary>
        /// <param name="ctr"></param>
        private void PlaySlideShow(int ctr)
        {
            var image = new BitmapImage();
            image.BeginInit();
            var filename = ((ctr < 10) ? "images/Image0" + ctr + ".jpg" : "images/Image" + ctr + ".jpg");
            image.UriSource = new Uri(filename, UriKind.Relative);
            image.EndInit();
            myImage.Source = image;
            myImage.Stretch = Stretch.Uniform;
            progressBar1.Value = ctr;
        } 
        #endregion

        #region Private events

        /// <summary>
        /// Private event fired at timers click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TimerTick(object sender, EventArgs e)
        {
            _counter++;
            if (_counter > 15)
            {
                _counter = 1;
            }
            PlaySlideShow(_counter);
        }

        /// <summary>
        /// Private method for playing slide show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlLoaded(object sender, RoutedEventArgs e)
        {
            _counter = 1;
            PlaySlideShow(_counter);
        }

        /// <summary>
        /// Event for first button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFirstClick(object sender, RoutedEventArgs e)
        {
            _counter = 1;
            PlaySlideShow(_counter);
        }

        /// <summary>
        /// Event for previous button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPreviousClick(object sender, RoutedEventArgs e)
        {
            _counter--;
            if (_counter < 1)
            {
                _counter = 15;
            }
            PlaySlideShow(_counter);
        }

        /// <summary>
        /// Event for next button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNextClick(object sender, RoutedEventArgs e)
        {
            _counter++;
            if (_counter > 15)
            {
                _counter = 1;
            }
            PlaySlideShow(_counter);
        }

        /// <summary>
        /// Event for last button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLastClick(object sender, RoutedEventArgs e)
        {
            _counter = 15;
            PlaySlideShow(_counter);
        }

        /// <summary>
        /// Auto play click checkbox event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkAutoPlayClick(object sender, RoutedEventArgs e)
        {
            if (chkAutoPlay.IsChecked != null) _timer.IsEnabled = chkAutoPlay.IsChecked.Value;
            btnFirst.Visibility = (btnFirst.IsVisible == true) ? Visibility.Hidden : Visibility.Visible;
            btnPrevious.Visibility = (btnPrevious.IsVisible == true) ? Visibility.Hidden : Visibility.Visible;
            btnNext.Visibility = (btnNext.IsVisible == true) ? Visibility.Hidden : Visibility.Visible;
            btnLast.Visibility = (btnLast.IsVisible == true) ? Visibility.Hidden : Visibility.Visible;
        } 
        #endregion
    }
}