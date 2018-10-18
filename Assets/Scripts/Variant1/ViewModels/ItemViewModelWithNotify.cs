using System;
using System.ComponentModel;
using UnityEngine;
using UnityWeld.Binding;

namespace Variant1 {
	[Binding]
	public class ItemViewModelWithNotify : MonoBehaviour, IItemModel, INotifyPropertyChanged {

		[Binding]
		public string Name {
			get {
				return _state.Name;
			}

			set {
				if ( _state.Name != value ) {
					_state.Name = value;
					OnPropertyChanged(nameof(Name));
				}
			}
		}

		[Binding]
		public int Count {
			get {
				return _state.Count;
			}
			set {
				if ( _state.Count != value ) {
					_state.Count = value;
					OnPropertyChanged(nameof(Count));
				}
			}
		}

		[Binding]
		public bool Active {
			get {
				return _state.Active;
			}
			set {
				if ( _state.Active != value ) {
					_state.Active = value;
					OnPropertyChanged(nameof(Active));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		ItemModel _state = new ItemModel("ItemName", 0, true);

		void OnPropertyChanged(string name) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}