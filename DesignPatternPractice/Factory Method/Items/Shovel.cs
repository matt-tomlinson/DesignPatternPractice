namespace DesignPatternPractice.Factory_Method {
	internal class Shovel : InventoryItem {
		public override void CreateItems() {
			Items.Add(new WoodenDowel());
			Items.Add(new MetalSpade());
		}
	}
}