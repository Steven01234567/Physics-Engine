using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Shapes;

namespace Models
{
    public class BaseEntity : BaseNotification
    {
        /// private variables
        
        private int _xCoordinate;
        private int _yCoordinate;
        private BaseShape _entityShape;

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
        public BaseShape EntityShape
        {
            get => _entityShape;
            set
            {
                _entityShape = value;
                OnPropertyChanged(nameof(EntityShape));
            }
        }

        public BaseEntity(int xCoordinate = 0, int yCoordinate = 0, BaseShape? shape = null)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
            if (shape == null)
            {
                _entityShape = new BaseShape();
            }
            else
            {
                _entityShape = shape;
            }
        }
    }
}
