import systemutils.Console;

import systemutils.IO;

import systemutils.platform.UnityInterface;

import systemutils.interfaces.IDebug;


class UnityBase
{
	public static function main () 
	{
		var io : IO = new UnityInterface ();

		Console.Setup (io);
		Console.Log ("Hello World");
	}
}