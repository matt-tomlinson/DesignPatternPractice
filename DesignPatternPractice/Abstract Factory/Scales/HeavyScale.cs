namespace DesignPatternPractice.Abstract_Factory {
	internal class HeavyScale : Scale {
		public override void Weigh(Material material) {
			Random rand = new Random();
			Console.WriteLine($"{rand.Next(50, 100)}g of {material.GetType().Name}");
		}
	}
}