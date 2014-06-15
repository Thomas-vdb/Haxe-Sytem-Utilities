package systemutils;

import systemutils.IO;

class Console
{
	private static var C : Map <String, Dynamic>;
	private static var I : IO;

	public static function Setup ( interface : IO )
	{
		I = interface;
	}

	public static function Show ()
	{

	}

	public static function Hide ()
	{

	}

	public static function RegisterCommand (command : String, callback : Dynamic)
	{
		if (C == null) C = new Map <String, Dynamic> ();
		C.set (command, callback);
	}
}