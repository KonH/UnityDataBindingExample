using System;
using System.ComponentModel;
using UnityEngine;
using UnityWeld.Binding;

namespace Variant2 {
	[Binding]
	public class ItemViewModel : MonoBehaviour, INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		[Binding] public string Name { get => _state.Name; set => _state.Name = value; }
		[Binding] public int Count { get => _state.Count; set => _state.Count = value; }
		[Binding] public bool Active { get => _state.Active; set => _state.Active = value; }

		ItemModel _state;
		ItemService _service;

		void Awake() {
			var repo = new ItemRepository();
			_state = repo.GetModel();
			_service = new ItemService(_state, 1.0f);
			_state.PropertyChanged += OnPropertyChanged;
		}


		void OnDestroy() {
			_state.PropertyChanged -= OnPropertyChanged;
		}

		private void OnPropertyChanged(object sender, PropertyChangedEventArgs e) {
			PropertyChanged?.Invoke(sender, e);
		}

		void Update() {
			_service.Update(Time.deltaTime);
		}

		[Binding]
		public void Switch() {
			_service.Switch();
		}
	}
}
