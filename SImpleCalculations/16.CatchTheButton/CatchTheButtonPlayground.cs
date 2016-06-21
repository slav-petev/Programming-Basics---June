using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.CatchTheButton
{
    public partial class CatchTheButtonPlayground : Form
    {
        private int _minButtonPositionX;
        private int _maxButtonPositionX;
        private int _minButtonPositionY;
        private int _maxButtonPositionY;

        public CatchTheButtonPlayground()
        {
            InitializeComponent();
        }

        private void CatchTheButtonPlayground_Load(object sender, EventArgs e)
        {
            _minButtonPositionX = Location.X;
            _maxButtonPositionX = Location.X + Width;
            _minButtonPositionY = Location.Y;
            _maxButtonPositionY = Location.Y + Height;
        }

        private void btnCatchMe_MouseEnter(object sender, EventArgs e)
        {
            var newPositionRandomCoordinatesGenerator = new Random();

            var newXCoordinate = newPositionRandomCoordinatesGenerator.Next(
                _minButtonPositionX, _maxButtonPositionX);
            var newYCoordinate = newPositionRandomCoordinatesGenerator.Next(
                _minButtonPositionY, _maxButtonPositionY);

            btnCatchMe.Location = new Point(newXCoordinate, newYCoordinate);
        }

        private void btnCatchMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You win!");

            btnCatchMe.MouseEnter -= btnCatchMe_MouseEnter;
            btnCatchMe.Click -= btnCatchMe_Click;
        }
    }
}
