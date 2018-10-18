using System.ComponentModel;

namespace Variant2 {
	public class ItemModel : INotifyPropertyChanged {

		string _name;
		int _count;
		bool _active;

		public string Name {
			get {
				return _name;
			}

			set {
				if ( value == _name ) {
					return;
				}
				_name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		public int Count {
			get {
				return _count;
			}

			set {
				if ( value == _count ) {
					return;
				}
				_count = value;
				OnPropertyChanged(nameof(Count));
			}
		}

		public bool Active {
			get {
				return _active;
			}

			set {
				if ( value == _active ) {
					return;
				}
				_active = value;
				OnPropertyChanged(nameof(Active));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public ItemModel(string name, int count, bool active) {
			Name = name;
			Count = count;
			Active = active;
		}

		void OnPropertyChanged(string name) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
