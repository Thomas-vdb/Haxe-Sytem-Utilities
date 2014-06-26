package systemutils;

interface IO
{
	public function add (objectID : String, type : IOType, ?value : String, ?interact : Dynamic) : IOObject;

	public function remove (objectID : String) : Void;

	public function get (objectID : String) : IOObject;

	public function has (objectID : String) : Bool;

	public function clear () : Void;
}

typedef IOObject = {

	public var type : IOType;

	public var value : String;

	public var interact : Dynamic;

	public var size : IOPoint;

	public var position : IOPoint;
}

enum IOType { LOG; STATIC_TEXT; INPUT_TEXT; STATIC_2D; INTERACT_2D; STATIC_3D; INTERACT_3D; }

typedef IOPoint = { x : Float, y : Float, ?z : Float }
