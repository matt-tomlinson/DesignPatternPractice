namespace DesignPatternPractice.Factory_Method {
	public abstract class Item {
		public override string ToString() {
			return this.GetType().Name;
		}
	}
}
