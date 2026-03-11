using fitness_app_mvvm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;
using static System.Reflection.Metadata.BlobBuilder;

namespace fitness_app_mvvm.ViewModel
{
    class VehicleService
    {
        //singleton
        private static VehicleService _instance;
        public static VehicleService Instance => _instance ??= new VehicleService();

        //själva listan
        public ObservableCollection<Workout> VehicleItems { get; set; }

        private VehicleService()
        {
            VehicleItems = new ObservableCollection<Workout>();
        }
    }

}
