namespace DesignPatternPractice.Abstract_Factory {
	internal class Part {
		private Material _material;
		private Scale _scale;
		PartFactory _factory;

		public Part(PartFactory partFactory) {
			_factory = partFactory;
			_material = _factory.CreateMaterial();
			_scale = _factory.CreateScale();
		}

		public void WriteRequirementInfo() {
			_factory.WriteRequirementInfo();
			_scale.Weigh(_material);
		}
	}
}