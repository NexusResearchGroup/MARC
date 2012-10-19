using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows; // Window, MessageBox
using System.Windows.Input; // MouseButtonEventHandler

namespace CSWinFormSingleInstanceApp
{
    
        public partial class EllipseEventHandlingWindow : Window
        {
            public EllipseEventHandlingWindow()
            {
                InitializeComponent();
            }

            void clickableEllipse_MouseUp(object sender, MouseButtonEventArgs e)
            {
                // Display a message
                MessageBox.Show("You clicked the ellipse!");
            }
        }
    
}
