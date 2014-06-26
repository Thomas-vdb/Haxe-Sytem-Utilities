
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace systemutils{
	public  interface IO : global::haxe.lang.IHxObject {
		   object @add(string objectID, global::systemutils.IOType type, string @value, object interact);
		
		   void @remove(string objectID);
		
		   object @get(string objectID);
		
		   bool has(string objectID);
		
		   void clear();
		
	}
}



namespace systemutils{
	public enum IOType{
		LOG, STATIC_TEXT, INPUT_TEXT, STATIC_2D, INTERACT_2D, STATIC_3D, INTERACT_3D
	}
}


