using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1 {
    public class SampleGalleryViewModel : ViewModelBase {
        public ObservableCollection<GroupViewModel> Groups {
            get { return GetProperty(() => Groups); }
            set { SetProperty(() => Groups, value); }
        }
        public SampleGalleryViewModel() {
            Groups = new ObservableCollection<GroupViewModel>();
            InitGroups();
        }
        void InitGroups() {
            for(int i = 0; i < 10; i++) {
                Groups.Add(new GroupViewModel() { Caption = String.Format("Group {0}", i) });
            }
        }
    }
    public class GroupViewModel : ViewModelBase {
        public string Caption {
            get { return GetProperty(() => Caption); }
            set { SetProperty(() => Caption, value); }
        }
        public ObservableCollection<ItemViewModel> Items {
            get { return GetProperty(() => Items); }
            set { SetProperty(() => Items, value); }
        }
        public GroupViewModel() {
            Items = new ObservableCollection<ItemViewModel>();
            InitItems();
        }
        void InitItems() {
            for(int i = 0; i < 3; i++) {
                Items.Add(new ItemViewModel() { Caption = String.Format("Item {0}", i) });
            }
        }
    }
    public class ItemViewModel : ViewModelBase {
        public string Caption {
            get { return GetProperty(() => Caption); }
            set { SetProperty(() => Caption, value); }
        }
    }
}
