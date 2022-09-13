using DesignPatternPractice.Builder.Builders;

namespace DesignPatternPractice.Builder {
    internal class Shop {
        public void Build(PCBuilder pcBuilder) {
            pcBuilder.BuildCPU();
            pcBuilder.BuildGPU();
            pcBuilder.BuildRAM();
            pcBuilder.BuildPSU();
        }
    }
}