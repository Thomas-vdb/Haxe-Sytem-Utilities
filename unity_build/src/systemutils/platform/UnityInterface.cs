
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace systemutils.platform{
	public  class UnityInterface : global::haxe.lang.HxObject, global::systemutils.IO {
		public    UnityInterface(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    UnityInterface(){
			unchecked {
				#line 7 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				global::systemutils.platform.UnityInterface.__hx_ctor_systemutils_platform_UnityInterface(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_systemutils_platform_UnityInterface(global::systemutils.platform.UnityInterface __temp_me24){
			unchecked {
				#line 7 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				return new global::systemutils.platform.UnityInterface(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				return new global::systemutils.platform.UnityInterface();
			}
			#line default
		}
		
		
		public virtual   object @add(string objectID, global::systemutils.IOType type, string @value, object interact){
			unchecked {
				#line 13 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				if (string.Equals(@value, default(string))) {
					#line 13 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
					@value = "no value";
				}
				
				#line 13 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void @remove(string objectID){
			unchecked {
				#line 18 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				if (this.has(objectID)) {
					#line 19 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
					{
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object @get(string objectID){
			unchecked {
				#line 26 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				if (this.has(objectID)) {
					#line 27 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
					{
					}
					
				}
				
				#line 31 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   bool has(string objectID){
			unchecked {
				#line 36 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				return true;
			}
			#line default
		}
		
		
		public virtual   void clear(){
			unchecked {
				#line 39 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				switch (hash){
					case 1213952397:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("clear") ), ((int) (1213952397) ))) );
					}
					
					
					case 5193562:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("has") ), ((int) (5193562) ))) );
					}
					
					
					case 5144726:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get") ), ((int) (5144726) ))) );
					}
					
					
					case 76061764:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("remove") ), ((int) (76061764) ))) );
					}
					
					
					case 4846113:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("add") ), ((int) (4846113) ))) );
					}
					
					
					default:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs){
			unchecked {
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				switch (hash){
					case 1213952397:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						this.clear();
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						break;
					}
					
					
					case 5193562:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return this.has(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 5144726:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return this.@get(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 76061764:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						this.@remove(global::haxe.lang.Runtime.toString(dynargs[0]));
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						break;
					}
					
					
					case 4846113:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return this.@add(global::haxe.lang.Runtime.toString(dynargs[0]), ((global::systemutils.IOType) (dynargs[1]) ), global::haxe.lang.Runtime.toString(dynargs[2]), dynargs[3]);
					}
					
					
					default:
					{
						#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 5 "C:\\Users\\Thomas\\Desktop\\PROJECTEN\\HSU\\src\\systemutils\\platform\\UnityInterface.hx"
				return default(object);
			}
			#line default
		}
		
		
	}
}


