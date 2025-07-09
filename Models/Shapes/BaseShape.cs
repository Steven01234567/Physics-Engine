using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Shapes
{
    public class BaseShape : BaseNotification
    {
        /// private variables

        private int _width;
        private int _height;



        /// public variables
        
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



        /// Constructor

        public BaseShape(int width = 100, int height = 100)
        {
            _width = width;
            _height = height;
        }
    }
}
