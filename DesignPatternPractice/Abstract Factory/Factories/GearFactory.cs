namespace DesignPatternPractice.Abstract_Factory {
	internal class GearFactory : PartFactory {
		public override Material CreateMaterial() {
			return new Iron();
		}

		internal override Scale CreateScale() {
			return new HeavyScale();
		}
	}
}