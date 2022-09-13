namespace DesignPatternPractice.Builder.Builders {
    internal class SteamDeckBuilder : PCBuilder {
        public SteamDeckBuilder() {
            pc = new PC("Steam Deck");
        }
        public override void BuildCPU() {
            pc["CPU"] = "Zen 2";
        }

        public override void BuildGPU() {
            pc["GPU"] = "8 RDNA 2 CUs";
        }

        public override void BuildPSU() {
            pc["PSU"] = "4-15W APU";
        }

        public override void BuildRAM() {
            pc["RAM"] = "16 GB LPDDR5";
        }
    }
}