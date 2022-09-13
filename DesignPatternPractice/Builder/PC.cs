namespace DesignPatternPractice.Builder {
    class PC {
        private string _pcType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public PC(string pcType) {
            _pcType = pcType;
        }

        public string this[string key] {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void WriteInfo() {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("PC Type: {0}", _pcType);
            Console.WriteLine(" GPU : {0}", _parts["GPU"]);
            Console.WriteLine(" CPU : {0}", _parts["CPU"]);
            Console.WriteLine(" RAM : {0}", _parts["RAM"]);
            Console.WriteLine(" PSU : {0}", _parts["PSU"]);
        }
    }
}