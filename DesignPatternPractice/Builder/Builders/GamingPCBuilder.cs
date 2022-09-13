namespace DesignPatternPractice.Builder.Builders {
    internal class GamingPCBuilder : PCBuilder {
        public GamingPCBuilder() {
            pc = new PC("Gaming PC");
        }
        public override void BuildCPU() {
            pc["CPU"] = "i5-11400";
        }

        public override void BuildGPU() {
            pc["GPU"] = "RTX 3070ti";
        }

        public override void BuildPSU() {
            pc["PSU"] = "850W";
        }

        public override void BuildRAM() {
            pc["RAM"] = "32GB DDR4";
        }
    }
}