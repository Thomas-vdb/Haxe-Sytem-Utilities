package systemutils.platform;

import systemutils.IO;

class UnityInterface implements IO
{
	public function new () {}

	public function add (objectID : String, type : IOType, ?value : String = "no value", ?interact : Dynamic) : IOObject
	{
		//if (IOGUI == null) IOGUI.Log(value);

		return null;
	}

	public function remove (objectID : String)
	{
		if (has (objectID))
		{

		}
	}

	public function get (objectID : String) : IOObject
	{
		if (has (objectID))
		{
			
		}

		return null;
	}

	public function has (objectID : String) : Bool
	{
		return true;
	}

	public function clear () {}
}