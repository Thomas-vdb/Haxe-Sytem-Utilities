
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace systemutils{
	public  class Console : global::haxe.lang.HxObject {
		public    Console(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Console(){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				global::systemutils.Console.__hx_ctor_systemutils_Console(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_systemutils_Console(global::systemutils.Console __temp_me23){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  global::haxe.ds.StringMap C;
		
		public static  global::systemutils.IO I;
		
		public static   void Setup(global::systemutils.IO io){
			unchecked {
				#line 12 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				global::systemutils.Console.I = io;
			}
			#line default
		}
		
		
		public static   void Show(){
			unchecked {
				#line 16 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   void Hide(){
			unchecked {
				#line 21 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   void Log(string str){
			unchecked {
				#line 27 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				object log = global::systemutils.Console.I.@add("systemutils.console.log", global::systemutils.IOType.LOG, str, default(object));
			}
			#line default
		}
		
		
		public static   void RegisterCommand(string command, object callback){
			unchecked {
				#line 32 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				if (( global::systemutils.Console.C == default(global::haxe.ds.StringMap) )) {
					#line 32 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
					global::systemutils.Console.C = new global::haxe.ds.StringMap<object>();
				}
				
				#line 33 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				{
					#line 33 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
					object @value = callback;
					#line 33 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
					global::haxe.lang.Runtime.callField(global::systemutils.Console.C, "set", 5741474, new global::Array<object>(new object[]{command, @value}));
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				return new global::systemutils.Console(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\Console.hx"
				return new global::systemutils.Console();
			}
			#line default
		}
		
		
	}
}


