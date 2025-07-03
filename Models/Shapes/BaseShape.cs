using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseShape
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
            }
        }
        public int YCoordinate
        {
            get => _yCoordinate;
            set
            {
                _yCoordinate = value;
            }
        }
        public int Width
        {
            get => _width;
            set
            {
                _width = value;
            }
        }
        public int Height
        {
            get => _height;
            set
            {
                _height = value;
            }
        }



        /// Constructor

        public BaseShape(int xCoordinate = 0, int yCoordinate = 0, int width = 1, int height = 1)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
            _width = width;
            _height = height;
        }
    }
}
