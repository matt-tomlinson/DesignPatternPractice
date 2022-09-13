namespace DesignPatternPractice {
	public class DesignPattern {
		public virtual void Run() {
			Console.WriteLine($"Running {this.GetType().Name} pattern");
			Console.WriteLine($"=====================================");
		}
	}
}
