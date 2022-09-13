namespace DesignPatternPractice.Abstract_Factory {
	internal class WireFactory : PartFactory {
		public override Material CreateMaterial() {
			return new Copper();
		}

		internal override Scale CreateScale() {
			return new LightScale();
		}
	}
}