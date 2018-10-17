public class ItemModel : IItemModel {
	public string Name { get; set; }
	public int Count { get; set; }

	public ItemModel(string name, int count) {
		Name  = name;
		Count = count;
	}
}
