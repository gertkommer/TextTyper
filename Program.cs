using TextTyper;

class Program
{
	static void Main(string[] args)
	{
		if (args.Length == 0)
		{
			Console.WriteLine("Provide the string to type as an argument");
			Console.WriteLine("Press a key to quit...");
			Console.Read();
			System.Environment.Exit(11);
		}
		else
		{
			Console.WriteLine("Put the focus on the field to type and press the ScrollLock key to write your text");
			KeyboardListener.Run(args[0]);
		}
	}
}
