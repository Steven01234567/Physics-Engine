using Models;
using System.Collections.ObjectModel;

namespace ViewModels
{
    public class MainViewModel : BaseNotification
    {
        private ObservableCollection<BaseEntity> _entities;
        public ObservableCollection<BaseEntity> Entities
        {
            get => _entities;
            set
            {
                _entities = value;
                OnPropertyChanged(nameof(Entities));
            }
        }

        public MainViewModel()
        {
            _entities = new ObservableCollection<BaseEntity>();
        }
    }
}
