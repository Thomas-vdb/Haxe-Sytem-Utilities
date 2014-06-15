 
package systemutils.platform;

import systemutils.IO;

class NekoInterface implements IO
{
	private var textMap : Map <String, IOTextObject>;

	public function writeText (objectID : String)
	{
		createNekoTextObject (false);
	}

	public function inputText (objectID : String) : String;
	{
		createNekoTextObject (true);
	}

	private function createNekoTextObject (input : Bool) : IOTextObject
	{
		if (textMap == null) textMap = new Map <String, NekoTextObject> ();
		textMap.set (objectID, new NekoTextObject (input));
 		return textMap.get (objectID);
	}
}

class NekoTextObject implements IOTextObject
{
	private var textStr : String;
	private var input : Bool = false;

	public function new (?isInputText : Bool = false) { input = isInputText; }

	public var text (get_text, set_text);

	private function get_text () : String { return textStr; }
	private function set_text (value : String) : String { return textStr = value; }

	public function update () : String 
	{ 
		Sys.println (textStr); 
		if (input) return Sys.stdin().readLine(); 
		return "";
	}
}







