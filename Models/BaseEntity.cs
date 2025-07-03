using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseEntity
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
            }
        }

        public BaseEntity(BaseShape shape)
        {
            _entityShape = shape;
        }
    }
}
