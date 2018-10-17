using System.ComponentModel;
using UnityEngine;

[RequireComponent(typeof(DataBindContext))]
public class DataBindItemViewModel : MonoBehaviour, IItemModel {

	public string Name {
		get {
			return _state.Name;
		}

		set {
			if ( _state.Name != value ) {
				_state.Name = value;
				OnPropertyChanged(nameof(Name), _state.Name);
			}
		}
	}

	public int Count {
		get {
			return _state.Count;
		}
		set {
			if ( _state.Count != value ) {
				_state.Count = value;
				OnPropertyChanged(nameof(Count), _state.Count);
			}
		}
	}

	ItemModel _state = new ItemModel("ItemName", 0);

	DataBindContext _context;

	void Awake() {
		_context = GetComponent<DataBindContext>();
		OnPropertyChanged(nameof(Name), _state.Name);
		OnPropertyChanged(nameof(Count), _state.Count);
	}

	void OnPropertyChanged(string name, object value) {
		_context[name] = value;
	}
}
