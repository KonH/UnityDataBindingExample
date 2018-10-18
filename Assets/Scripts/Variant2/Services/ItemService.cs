namespace Variant2 {
	public class ItemService {
		ItemModel _state;
		float _advanceTime;
		float _advanceTimer;

		public ItemService(ItemModel state, float advanceTime) {
			_state = state;
			_advanceTime = advanceTime;
		}

		public ItemModel GetItem() {
			return _state;
		}

		public void Update(float deltaTime) {
			_advanceTimer += deltaTime;
			if ( _advanceTimer > _advanceTime ) {
				_state.Count++;
				_advanceTimer = 0.0f;
			}
		}

		public void Switch() {
			_state.Active = !_state.Active;
		}
	}
}
