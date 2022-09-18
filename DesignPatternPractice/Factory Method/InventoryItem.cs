namespace DesignPatternPractice.Factory_Method {
	abstract class InventoryItem {
		private List<Item> _items = new List<Item>();

		public InventoryItem() {
			this.CreateItems();
		}

		public List<Item> Items {
			get { return _items; }
		}

		public abstract void CreateItems();
	}
}