using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MazeRunner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Point relativePoint = label.TransformToAncestor(borde).Transform(new Point(0, 0));
            //polyline.Points.Add(e.GetPosition(canvas));
            var hola = Canvas.GetTop(imgAgent);
            moveLeft();
        }

        private void moveLeft()
        {

            if ((Canvas.GetTop(imgAgent) == 0)&&(Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar1) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder)))
                return;
            else if ((Canvas.GetTop(imgAgent) == 40) &&(Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar2) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar3) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar4) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar5)))
                return;
            else if((Canvas.GetTop(imgAgent) == 80) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar6) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar7) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar8) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar9)))
                return;
            else if ((Canvas.GetTop(imgAgent) == 120)&&(Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar10) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar11) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar12) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar13) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar14) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar15)))
                return;
            else if ((Canvas.GetTop(imgAgent) == 160) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar16) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar17) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar18) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar19) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar20) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar21)))
                return;
            else if ((Canvas.GetTop(imgAgent) == 200)&&(Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar22) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar23) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar24) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar25) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar26) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar27)))
                return;
            else if ((Canvas.GetTop(imgAgent) == 240)&&(Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar28) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar29) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar30) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar31) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar32) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar33)))
                return;
            else if ((Canvas.GetTop(imgAgent) == 280)&&(Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar34) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar35) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar36) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar37) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar38) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar39)))
                return;
            else if ((Canvas.GetTop(imgAgent) == 320)&&(Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar40) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar41) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar42) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar43) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar44)))
                return;
            else if ((Canvas.GetTop(imgAgent) == 360)&&(Canvas.GetLeft(imgAgent) == Canvas.GetLeft(leftBorder) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar45) || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar46)))
                return;
            else
                Canvas.SetLeft(imgAgent, Canvas.GetLeft(imgAgent) - 40);
        }

        private void moveRight()
        {
            if ((Canvas.GetTop(imgAgent) == 0) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar1)-40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(rightBorder1) - 40))
                return;
            else if ((Canvas.GetTop(imgAgent) == 40) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(rightBorder1) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar2) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar3) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar4) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar5) - 40))
                return;
            else if ((Canvas.GetTop(imgAgent) == 80) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(rightBorder1) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar6) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar7) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar8) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar9) - 40))
                return;
            else if ((Canvas.GetTop(imgAgent) == 120) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(rightBorder1) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar10) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar11) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar12) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar13) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar14) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar15) - 40))
                return;
            else if ((Canvas.GetTop(imgAgent) == 160) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(rightBorder1) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar16) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar17) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar18) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar19) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar20) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar21) - 40))
                return;
            else if ((Canvas.GetTop(imgAgent) == 200) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(rightBorder1) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar22) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar23) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar24) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar25) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar26) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar27) - 40))
                return;
            else if ((Canvas.GetTop(imgAgent) == 240) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(rightBorder1) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar28) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar29) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar30) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar31) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar32) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar33) - 40))
                return;
            else if ((Canvas.GetTop(imgAgent) == 280) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar34) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar35) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar36) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar37) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar38) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar39) - 40))
                return;
            else if ((Canvas.GetTop(imgAgent) == 320) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(rightBorder2) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar40) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar41) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar42) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar43) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar44) - 40))
                return;
            else if ((Canvas.GetTop(imgAgent) == 360) && (Canvas.GetLeft(imgAgent) == Canvas.GetLeft(rightBorder2) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar45) - 40 || Canvas.GetLeft(imgAgent) == Canvas.GetLeft(vbar46) - 40))
                return;
            else
                Canvas.SetLeft(imgAgent, Canvas.GetLeft(imgAgent) + 40);
        }

        private void moveUp()
        {
                if ((Canvas.GetTop(imgAgent) == 0) && (Canvas.GetTop(imgAgent) == Canvas.GetTop(topBorder)))
                    return;

            Canvas.SetTop(imgAgent, Canvas.GetTop(imgAgent) - 40);
        }




        private void moveDown()
        {
            Canvas.SetTop(imgAgent, Canvas.GetTop(imgAgent) + 40);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            moveRight();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            moveUp();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            moveDown();
        }
    }
}
