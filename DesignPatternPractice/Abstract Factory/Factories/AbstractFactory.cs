using System;

namespace DesignPatternPractice.Abstract_Factory {
	public class AbstractFactory : DesignPattern {
		public override void Run() {
			base.Run();

			PartFactory gear = new GearFactory();
			Part part1 = new Part(gear);
			part1.WriteRequirementInfo();

			PartFactory wire = new WireFactory();
			Part part2 = new Part(wire);
			part2.WriteRequirementInfo();
			
		}
	}
}
