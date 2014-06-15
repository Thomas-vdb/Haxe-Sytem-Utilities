package systemutils;


interface IO
{
	public function writeText (objectID : String) : IOTextObject;

	public function inputText (objectID : String) : IOTextObject;
}

interface IOTextObject
{
	public var text (get_text, set_text) : String;

	public function update () : String;
}

