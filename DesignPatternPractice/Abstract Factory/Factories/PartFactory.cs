namespace DesignPatternPractice.Abstract_Factory {
	abstract class PartFactory {
		public abstract Material CreateMaterial();
		internal abstract Scale CreateScale() ;
		internal void WriteRequirementInfo() {
			Console.Write($"The {this.GetType().Name} needs ");
		}
	}
}