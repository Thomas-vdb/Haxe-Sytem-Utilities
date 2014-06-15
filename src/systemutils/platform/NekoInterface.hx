 
package systemutils.platform;

import systemutils.IO;

class NekoInterface implements IO
{
	public function new () {}
	
	public function writeText (objectID : String) : IOTextObject
	{
		return createNekoTextObject (false);
	}

	public function inputText (objectID : String) : IOTextObject
	{
		return createNekoTextObject (true);
	}

	private function createNekoTextObject (input : Bool) : IOTextObject
	{
 		return new NekoTextObject (input);
	}
}

class NekoTextObject implements IOTextObject
{
	private var textStr : String;
	private var input : Bool = false;

	public function new (?isInputText : Bool = false) { input = isInputText; }

	public var text (get_text, set_text) : String;

	private function get_text () : String { return textStr; }
	private function set_text (value : String) : String { return textStr = value; }

	public function update () : String 
	{ 
		Sys.println (textStr); 
		if (input) return Sys.stdin().readLine(); 
		return "";
	}
}







