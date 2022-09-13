using DesignPatternPractice;
using DesignPatternPractice.Abstract_Factory;
using DesignPatternPractice.Builder;

//https://www.dofactory.com/net/design-patterns

List<object> patterns = new List<object>() { 
	new AbstractFactory(),
	new Builder()
};

while (true) {
	Console.WriteLine("Select a pattern to run:");
    for (int i = 0; i < patterns.Count; i++) {
		Console.WriteLine($" {i} - {patterns[i].GetType().Name}");
    }

	char c = Console.ReadKey().KeyChar;
	Console.Clear();

	if (int.TryParse(c.ToString(), out int index)) {
		DesignPattern? currentDesignPattern = patterns[index] as DesignPattern;
		currentDesignPattern?.Run();
	} else if (c == 'q') {
		Environment.Exit(0);
	}

	Console.WriteLine();
}
