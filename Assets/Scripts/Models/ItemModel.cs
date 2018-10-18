public class ItemModel : IItemModel {
	public string Name { get; set; }
	public int Count { get; set; }
	public bool Active { get; set; }

	public ItemModel(string name, int count, bool active) {
		Name  = name;
		Count = count;
		Active = active;
	}
}
