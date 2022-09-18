namespace DesignPatternPractice.Factory_Method {
	internal class FactoryMethod : DesignPattern {
		public override void Run() {
			base.Run();

			InventoryItem[] inventory = new InventoryItem[3];

			inventory[0] = new Shovel();
			inventory[1] = new Torch();
			inventory[2] = new Bomb();

			Dictionary<string, int> baseInventoryItems = GetBaseItems(inventory);

			foreach (var item in baseInventoryItems) {
				Console.WriteLine($"{item.Value}x {item.Key}");
			}
		}

		private static Dictionary<string, int> GetBaseItems(InventoryItem[] inventory) {
			Dictionary<string, int> baseInventoryItems = new Dictionary<string, int>();

			foreach (InventoryItem inventoryItem in inventory) {
				foreach (Item item in inventoryItem.Items) {
					if (!baseInventoryItems.ContainsKey(item.ToString())) {
						baseInventoryItems.Add(item.ToString(), 1);
					} else {
						baseInventoryItems[item.ToString()]++;
					}
				}
			}

			return baseInventoryItems;
		}
	}
}
