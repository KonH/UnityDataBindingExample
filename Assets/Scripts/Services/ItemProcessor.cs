public class ItemProcessor {
	IItemModel _model;
	float _advanceTimer;
	float _advanceTime;

	public ItemProcessor(IItemModel model, float advanceTime) {
		_model = model;
		_advanceTimer = 0.0f;
		_advanceTime = advanceTime;
	}

	public void Update(float deltaTime) {
		_advanceTimer += deltaTime;
		if ( _advanceTimer > _advanceTime ) {
			_model.Count++;
			_advanceTimer = 0.0f;
		}
	}

	public void Switch() {
		_model.Active = !_model.Active;
	}
}
