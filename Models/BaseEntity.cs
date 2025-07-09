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

        private BaseShape _entityShape;

        /// public variables
        public BaseShape EntityShape
        {
            get => _entityShape;
            set
            {
                _entityShape = value;
                OnPropertyChanged(nameof(EntityShape));
            }
        }

        public BaseEntity(BaseShape? shape = null)
        {
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
