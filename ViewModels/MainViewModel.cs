using Models;

namespace ViewModels
{
    public class MainViewModel
    {
        private BaseEntity _entity;
        public BaseEntity Entity
        {
            get => _entity;
            set
            {
                _entity = value;
            }
        }

        public MainViewModel()
        {
            _entity = new BaseEntity(new BaseShape(1, 2, 3, 4));
        }
    }
}
