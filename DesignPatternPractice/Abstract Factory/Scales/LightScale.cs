namespace DesignPatternPractice.Abstract_Factory {
	internal class LightScale : Scale {
		public override void Weigh(Material material) {
			Random rand = new Random();
			Console.WriteLine($"{rand.Next(1, 25)}g of {material.GetType().Name}");
		}
	}
}