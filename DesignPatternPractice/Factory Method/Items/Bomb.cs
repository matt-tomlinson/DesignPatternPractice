namespace DesignPatternPractice.Factory_Method {
	internal class Bomb : InventoryItem {
		public override void CreateItems() {
			Items.Add(new Kerosene());
			Items.Add(new MetalSpade());
		}
	}
}