import systemutils.Console;

import systemutils.IO;
import systemutils.platform.NekoInterface;

class Main
{
	public static function main () 
	{
		var io : IO = new NekoInterface ();

		Console.Setup (io);
		Console.Log ("Hello World");
	}
}