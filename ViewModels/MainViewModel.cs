using Models;
using System.Collections.ObjectModel;

namespace ViewModels
{
    public class MainViewModel : BaseNotification
    {

        public ObservableCollection<BaseEntity> Entities;



        /// Constructor

        public MainViewModel()
        {
            Entities = new ObservableCollection<BaseEntity>();
            Entities.Add(new BaseEntity(100, 100));
            Entities.Add(new BaseEntity(200, 200));
        }
    }
}
