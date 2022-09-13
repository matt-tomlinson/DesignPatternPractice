namespace DesignPatternPractice.Builder.Builders {
    abstract class PCBuilder {
        protected PC pc;

        public PC PC { get { return pc; } }

        public abstract void BuildGPU();
        public abstract void BuildCPU();
        public abstract void BuildRAM();
        public abstract void BuildPSU();
    }
}