using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Entity
    {
        /// private variables
        private int _xCoordinate;
        private int _yCoordinate;
        private int _height;
        private int _width;

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
        public int Height
        {
            get => _height;
            set
            {
                _height = value;
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

        public Entity(int xCoordinate = 0, int yCoordinate = 0, int height = 1, int width = 1)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
            _height = height;
            _width = width;
        }
    }
}
