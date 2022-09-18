namespace DesignPatternPractice.Factory_Method {
	internal class Torch : InventoryItem {
		public override void CreateItems() {
			Items.Add(new WoodenDowel());
			Items.Add(new ClothWrap());
			Items.Add(new Kerosene());
		}
	}
}