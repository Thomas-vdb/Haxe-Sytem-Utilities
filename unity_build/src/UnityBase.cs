
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class UnityBase : global::haxe.lang.HxObject {
	public static void Main(){
		global::cs.Boot.init();
		main();
	}
	public    UnityBase(global::haxe.lang.EmptyObject empty){
		unchecked {
			#line 6 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\UnityBase.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    UnityBase(){
		unchecked {
			#line 6 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\UnityBase.hx"
			global::UnityBase.__hx_ctor__UnityBase(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__UnityBase(global::UnityBase __temp_me10){
		unchecked {
			#line 6 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\UnityBase.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   void main(){
		unchecked {
			#line 10 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\UnityBase.hx"
			global::systemutils.IO io = new global::systemutils.platform.UnityInterface();
			#line 12 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\UnityBase.hx"
			global::systemutils.Console.Setup(io);
			global::systemutils.Console.Log("Hello World");
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty(){
		unchecked {
			#line 6 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\UnityBase.hx"
			return new global::UnityBase(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr){
		unchecked {
			#line 6 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\UnityBase.hx"
			return new global::UnityBase();
		}
		#line default
	}
	
	
}


