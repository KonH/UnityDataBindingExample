using NUnit.Framework;

namespace Variant2 {
	public class ItemServiceTests {

		[Test]
		public void IsItemCountAdvances() {
			var itemModel = new ItemModel(string.Empty, 0, true);
			var service = new ItemService(itemModel, 1.0f);
			service.Update(1.1f);
			Assert.AreEqual(1, itemModel.Count);
		}

		public void IsSwitchedItemChangeActive() {
			var itemModel = new ItemModel(string.Empty, 0, true);
			var service = new ItemService(itemModel, 0.0f);
			service.Switch();
			Assert.AreEqual(false, itemModel.Active);
		}
	}
}
