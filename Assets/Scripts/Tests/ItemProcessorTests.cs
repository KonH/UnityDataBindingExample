using NUnit.Framework;

public class ItemProcessorTests {

	[Test]
    public void IsItemCountAdvances() {
		var itemModel = new ItemModel(string.Empty, 0, true);
		var itemProcessor = new ItemProcessor(itemModel, 1.0f);
		itemProcessor.Update(1.1f);
		Assert.AreEqual(1, itemModel.Count);
    }

	public void IsSwitchedItemChangeActive() {
		var itemModel = new ItemModel(string.Empty, 0, true);
		var itemProcessor = new ItemProcessor(itemModel, 0.0f);
		itemProcessor.Switch();
		Assert.AreEqual(false, itemModel.Active);
	}
}
