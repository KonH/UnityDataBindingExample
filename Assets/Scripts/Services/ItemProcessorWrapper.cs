using UnityEngine;

public class ItemProcessorWrapper : MonoBehaviour {
	public float AdvanceTime = 1.0f;

	ItemProcessor _processor;

	void Start () {
		var model = GetComponent<IItemModel>();
		_processor = new ItemProcessor(model, AdvanceTime);
	}

	void Update () {
		_processor.Update(Time.deltaTime);
	}
}
