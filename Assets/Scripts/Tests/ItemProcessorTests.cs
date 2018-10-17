using NUnit.Framework;

public class ItemProcessorTests {

	[Test]
    public void IsItemCountAdvances() {
		var itemModel = new ItemModel(string.Empty, 0);
		var itemProcessor = new ItemProcessor(itemModel, 1.0f);
		itemProcessor.Update(1.1f);
		Assert.AreEqual(1, itemModel.Count);
    }
}
