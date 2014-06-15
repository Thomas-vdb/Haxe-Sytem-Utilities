package systemutils;

import systemutils.IO;

class Console
{
	private static var C : Map <String, Dynamic>;
	private static var I : IO;

	public static function Setup ( io : IO )
	{
		I = io;
	}

	public static function Show ()
	{

	}

	public static function Hide ()
	{

	}

	public static function Log (str : String)
	{
		var log = I.writeText("systemutils.console.log");
		log.text = str;
		log.update();
	}

	public static function RegisterCommand (command : String, callback : Dynamic)
	{
		if (C == null) C = new Map <String, Dynamic> ();
		C.set (command, callback);
	}
}