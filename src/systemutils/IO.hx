package systemutils;


interface IO
{
	public function writeText (objectID : String) : IOTextObject;

	public function inputText (objectID : String) : String;
}

interface IOTextObject
{
	public var text (get_text, set_text);
	
	public function update ();
}

