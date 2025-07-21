using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseEntity : BaseNotification
    {
        /// private variables
        
        private int _xCoordinate;
        private int _yCoordinate;
        private int _width;
        private int _height;

        /// public variables
        public int XCoordinate
        {
            get => _xCoordinate;
            set
            {
                _xCoordinate = value;
                OnPropertyChanged(nameof(XCoordinate));
            }
        }
        public int YCoordinate
        {
            get => _yCoordinate;
            set
            {
                _yCoordinate = value;
                OnPropertyChanged(nameof(YCoordinate));
            }
        }
        public int Width
        {
            get => _width;
            set
            {
                _width = value;
                OnPropertyChanged(nameof(Width));
            }
        }
        public int Height
        {
            get => _height;
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }

        public BaseEntity(int xCoordinate = 0, int yCoordinate = 0, int width = 100, int height = 100)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
            _width = width;
            _height = height;
        }
    }
}
