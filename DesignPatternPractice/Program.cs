using DesignPatternPractice;
using DesignPatternPractice.Abstract_Factory;

//https://www.dofactory.com/net/design-patterns
bool exit = false;

while (!exit) {
	Console.Clear();

	DesignPattern currentDesignPattern = new AbstractFactory();
	currentDesignPattern.Run();

	try {
		char c = Console.ReadKey().KeyChar;
		if (c == 'q') {
			exit = true;
		}
	} catch {
		Environment.Exit(0);
	}
}
