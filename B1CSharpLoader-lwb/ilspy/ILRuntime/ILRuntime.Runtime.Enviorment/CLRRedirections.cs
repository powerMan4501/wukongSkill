using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Mono.Cecil;
using ILRuntime.Mono.Collections.Generic;
using ILRuntime.Other;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Enviorment;

internal static class CLRRedirections
{
	public unsafe static StackObject* GetCurrentStackTrace(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1 - 1;
		intp.Free(esp - 1);
		return ILIntepreter.PushObject(esp2, mStack, intp.AppDomain.DebugService.GetStackTrace(intp));
	}

	public unsafe static StackObject* CreateInstance(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		IType[] genericArguments = method.GenericArguments;
		if (genericArguments != null && genericArguments.Length == 1)
		{
			IType type = genericArguments[0];
			if (type is ILType)
			{
				if (type.IsValueType && !type.IsEnum)
				{
					intp.AllocValueType(esp++, type);
					return esp;
				}
				return ILIntepreter.PushObject(esp, mStack, ((ILType)type).Instantiate());
			}
			if (intp.AppDomain.ValueTypeBinders.ContainsKey(type.TypeForCLR))
			{
				intp.AllocValueType(esp++, type);
				return esp;
			}
			return ILIntepreter.PushObject(esp, mStack, ((CLRType)type).CreateDefaultInstance());
		}
		throw new EntryPointNotFoundException();
	}

	public unsafe static StackObject* CreateInstance2(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* ptr = esp - 1;
		Type type = mStack[ptr->Value] as Type;
		intp.Free(ptr);
		if (type != null)
		{
			if (type is ILRuntimeType)
			{
				return ILIntepreter.PushObject(ptr, mStack, ((ILRuntimeType)type).ILType.Instantiate());
			}
			return ILIntepreter.PushObject(ptr, mStack, Activator.CreateInstance(type));
		}
		return ILIntepreter.PushNull(ptr);
	}

	public unsafe static StackObject* CreateInstance3(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* ptr = esp - 1 - 1;
		Type type = mStack[ptr->Value] as Type;
		StackObject* ptr2 = esp - 1;
		object[] array = mStack[ptr2->Value] as object[];
		intp.Free(ptr);
		if (type != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					throw new ArgumentNullException();
				}
			}
			if (type is ILRuntimeType)
			{
				return ILIntepreter.PushObject(ptr, mStack, ((ILRuntimeType)type).ILType.Instantiate(array));
			}
			return ILIntepreter.PushObject(ptr, mStack, Activator.CreateInstance(type, array));
		}
		return ILIntepreter.PushNull(ptr);
	}

	public unsafe static StackObject* GetType(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1;
		AppDomain appDomain = intp.AppDomain;
		string fullname = (string)StackObject.ToObject(esp2, appDomain, mStack);
		intp.Free(esp2);
		IType type = intp.AppDomain.GetType(fullname);
		if (type != null)
		{
			return ILIntepreter.PushObject(esp2, mStack, type.ReflectionType);
		}
		return ILIntepreter.PushNull(esp2);
	}

	public unsafe static StackObject* TypeEquals(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = ILIntepreter.Minus(esp, 2);
		StackObject* esp3 = esp - 1;
		AppDomain appDomain = intp.AppDomain;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = ILIntepreter.Minus(esp, 2);
		object obj2 = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (obj2 is ILRuntimeType)
		{
			if (obj is ILRuntimeType)
			{
				if (((ILRuntimeType)obj2).ILType == ((ILRuntimeType)obj).ILType)
				{
					return ILIntepreter.PushOne(esp2);
				}
				return ILIntepreter.PushZero(esp2);
			}
			return ILIntepreter.PushZero(esp2);
		}
		if (((Type)typeof(Type).CheckCLRTypes(obj2)).Equals((Type)typeof(Type).CheckCLRTypes(obj)))
		{
			return ILIntepreter.PushOne(esp2);
		}
		return ILIntepreter.PushZero(esp2);
	}

	public unsafe static StackObject* IsAssignableFrom(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = ILIntepreter.Minus(esp, 2);
		StackObject* esp3 = esp - 1;
		AppDomain appDomain = intp.AppDomain;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = ILIntepreter.Minus(esp, 2);
		object obj2 = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (obj2 is ILRuntimeType)
		{
			if (obj is ILRuntimeType)
			{
				if (((ILRuntimeType)obj2).IsAssignableFrom((ILRuntimeType)obj))
				{
					return ILIntepreter.PushOne(esp2);
				}
				return ILIntepreter.PushZero(esp2);
			}
			return ILIntepreter.PushZero(esp2);
		}
		if (obj2 is ILRuntimeWrapperType)
		{
			if (((ILRuntimeWrapperType)obj2).IsAssignableFrom((Type)obj))
			{
				return ILIntepreter.PushOne(esp2);
			}
			return ILIntepreter.PushZero(esp2);
		}
		if (((Type)obj2).IsAssignableFrom((Type)obj))
		{
			return ILIntepreter.PushOne(esp2);
		}
		return ILIntepreter.PushZero(esp2);
	}

	public unsafe static StackObject* InitializeArray(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* result = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp2 = esp - 1;
		byte[] array = StackObject.ToObject(esp2, appDomain, mStack) as byte[];
		intp.Free(esp2);
		esp2 = esp - 1 - 1;
		object obj = StackObject.ToObject(esp2, appDomain, mStack);
		intp.Free(esp2);
		if (array == null)
		{
			return result;
		}
		fixed (byte* ptr = array)
		{
			Array obj2 = (Array)obj;
			GCHandle gCHandle = GCHandle.Alloc(obj2, GCHandleType.Pinned);
			IntPtr destination = Marshal.UnsafeAddrOfPinnedArrayElement(obj2, 0);
			Marshal.Copy(array, 0, destination, array.Length);
			gCHandle.Free();
		}
		return result;
	}

	public unsafe static StackObject* DelegateCombine(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 1 - 1;
		object obj2 = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (obj2 != null)
		{
			if (obj != null)
			{
				if (obj2 is IDelegateAdapter)
				{
					if (obj is IDelegateAdapter)
					{
						IDelegateAdapter delegateAdapter = (IDelegateAdapter)obj2;
						if (!delegateAdapter.IsClone)
						{
							delegateAdapter = delegateAdapter.Clone();
						}
						if (!((IDelegateAdapter)obj).IsClone)
						{
							obj = ((IDelegateAdapter)obj).Clone();
						}
						delegateAdapter.Combine((IDelegateAdapter)obj);
						return ILIntepreter.PushObject(esp2, mStack, delegateAdapter);
					}
					if (!((IDelegateAdapter)obj2).IsClone)
					{
						obj2 = ((IDelegateAdapter)obj2).Clone();
					}
					((IDelegateAdapter)obj2).Combine((Delegate)obj);
					return ILIntepreter.PushObject(esp2, mStack, obj2);
				}
				if (obj is IDelegateAdapter)
				{
					return ILIntepreter.PushObject(esp2, mStack, Delegate.Combine((Delegate)obj2, ((IDelegateAdapter)obj).GetConvertor(obj2.GetType())));
				}
				return ILIntepreter.PushObject(esp2, mStack, Delegate.Combine((Delegate)obj2, (Delegate)obj));
			}
			return ILIntepreter.PushObject(esp2, mStack, obj2);
		}
		return ILIntepreter.PushObject(esp2, mStack, obj);
	}

	public unsafe static StackObject* DelegateRemove(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 1 - 1;
		object obj2 = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (obj2 != null)
		{
			if (obj != null)
			{
				if (obj2 is IDelegateAdapter)
				{
					if (obj is IDelegateAdapter)
					{
						if (((IDelegateAdapter)obj2).Equals((IDelegateAdapter)obj))
						{
							return ILIntepreter.PushObject(esp2, mStack, ((IDelegateAdapter)obj2).Next);
						}
						((IDelegateAdapter)obj2).Remove((IDelegateAdapter)obj);
					}
					else
					{
						((IDelegateAdapter)obj2).Remove((Delegate)obj);
					}
					return ILIntepreter.PushObject(esp2, mStack, obj2);
				}
				if (obj is IDelegateAdapter)
				{
					return ILIntepreter.PushObject(esp2, mStack, Delegate.Remove((Delegate)obj2, ((IDelegateAdapter)obj).GetConvertor(obj2.GetType())));
				}
				return ILIntepreter.PushObject(esp2, mStack, Delegate.Remove((Delegate)obj2, (Delegate)obj));
			}
			return ILIntepreter.PushObject(esp2, mStack, obj2);
		}
		return ILIntepreter.PushNull(esp2);
	}

	public unsafe static StackObject* DelegateGetTarget(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (obj != null)
		{
			if (obj is IDelegateAdapter)
			{
				return ILIntepreter.PushObject(esp2, mStack, ((IDelegateAdapter)obj).Instance);
			}
			return ILIntepreter.PushObject(esp2, mStack, ((Delegate)obj).Target);
		}
		throw new NullReferenceException();
	}

	public unsafe static StackObject* DelegateEqulity(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 1 - 1;
		object obj2 = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		bool flag = false;
		if ((obj2 == null) ? (obj == null) : ((obj == null) ? (obj2 == null) : ((obj2 is IDelegateAdapter) ? ((!(obj is IDelegateAdapter)) ? ((IDelegateAdapter)obj2).Equals((Delegate)obj) : ((IDelegateAdapter)obj2).Equals((IDelegateAdapter)obj)) : ((!(obj is IDelegateAdapter)) ? ((Delegate)obj2 == (Delegate)obj) : ((Delegate)obj2 == ((IDelegateAdapter)obj).GetConvertor(obj2.GetType()))))))
		{
			return ILIntepreter.PushOne(esp2);
		}
		return ILIntepreter.PushZero(esp2);
	}

	public unsafe static StackObject* DelegateInequlity(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 1 - 1;
		object obj2 = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		bool flag = false;
		if ((obj2 == null) ? (obj != null) : ((obj == null) ? (obj2 != null) : ((obj2 is IDelegateAdapter) ? ((!(obj is IDelegateAdapter)) ? (!((IDelegateAdapter)obj2).Equals((Delegate)obj)) : (!((IDelegateAdapter)obj2).Equals((IDelegateAdapter)obj))) : ((!(obj is IDelegateAdapter)) ? ((Delegate)obj2 != (Delegate)obj) : ((Delegate)obj2 != ((IDelegateAdapter)obj).GetConvertor(obj2.GetType()))))))
		{
			return ILIntepreter.PushOne(esp2);
		}
		return ILIntepreter.PushZero(esp2);
	}

	public unsafe static StackObject* GetTypeFromHandle(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		return esp;
	}

	public unsafe static StackObject* MethodInfoInvoke(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		AppDomain appDomain = intp.AppDomain;
		StackObject* ptr = ILIntepreter.Minus(esp, 3);
		StackObject* esp2 = esp - 1;
		object obj = StackObject.ToObject(esp2, appDomain, mStack);
		intp.Free(esp2);
		esp2 = esp - 1 - 1;
		object obj2 = StackObject.ToObject(esp2, appDomain, mStack);
		intp.Free(esp2);
		esp2 = ILIntepreter.Minus(esp, 3);
		object obj3 = CheckCrossBindingAdapter(StackObject.ToObject(esp2, appDomain, mStack));
		intp.Free(esp2);
		if (obj3 is ILRuntimeMethodInfo)
		{
			esp = ((obj2 == null) ? ptr : ILIntepreter.PushObject(ptr, mStack, obj2));
			ILMethod iLMethod = ((ILRuntimeMethodInfo)obj3).ILMethod;
			bool shouldUseRegisterVM = iLMethod.ShouldUseRegisterVM;
			if (obj != null)
			{
				object[] array = (object[])obj;
				for (int i = 0; i < iLMethod.ParameterCount; i++)
				{
					StackObject* intPtr = ILIntepreter.PushObject(esp, mStack, CheckCrossBindingAdapter(array[i]));
					if (esp->ObjectType < ObjectTypes.Object && shouldUseRegisterVM)
					{
						mStack.Add(null);
					}
					esp = intPtr;
				}
			}
			ptr = ((!shouldUseRegisterVM) ? intp.Execute(iLMethod, esp, out var unhandledException) : intp.ExecuteR(iLMethod, esp, out unhandledException));
			IType returnType = ((ILRuntimeMethodInfo)obj3).ILMethod.ReturnType;
			if (returnType != appDomain.VoidType)
			{
				StackObject* ptr2 = ptr - 1;
				if (ptr2->ObjectType < ObjectTypes.Object)
				{
					return ILIntepreter.PushObject(ptr2, mStack, returnType.TypeForCLR.CheckCLRTypes(StackObject.ToObject(ptr2, appDomain, mStack)), isBox: true);
				}
				return ptr;
			}
			return ILIntepreter.PushNull(ptr);
		}
		return ILIntepreter.PushObject(ptr, mStack, ((MethodInfo)obj3).Invoke(obj2, (object[])obj));
	}

	private static object CheckCrossBindingAdapter(object obj)
	{
		if (obj is CrossBindingAdaptorType)
		{
			return ((CrossBindingAdaptorType)obj).ILInstance;
		}
		return obj;
	}

	public unsafe static StackObject* ObjectGetType(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp2 = esp - 1;
		StackObject* esp3 = esp - 1;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		Type type = obj.GetType();
		if (type == typeof(ILTypeInstance) || type == typeof(ILEnumTypeInstance))
		{
			return ILIntepreter.PushObject(esp2, mStack, ((ILTypeInstance)obj).Type.ReflectionType);
		}
		return ILIntepreter.PushObject(esp2, mStack, type);
	}

	public unsafe static StackObject* EnumParse(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		string text = (string)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 1 - 1;
		Type type = (Type)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (type is ILRuntimeType)
		{
			ILType iLType = ((ILRuntimeType)type).ILType;
			if (iLType.IsEnum)
			{
				Collection<FieldDefinition> fields = iLType.TypeDefinition.Fields;
				for (int i = 0; i < fields.Count; i++)
				{
					FieldDefinition fieldDefinition = fields[i];
					if (fieldDefinition.IsStatic)
					{
						if (fieldDefinition.Name == text)
						{
							ILEnumTypeInstance iLEnumTypeInstance = new ILEnumTypeInstance(iLType);
							iLEnumTypeInstance[0] = fieldDefinition.Constant;
							iLEnumTypeInstance.Boxed = true;
							return ILIntepreter.PushObject(esp2, mStack, iLEnumTypeInstance, isBox: true);
						}
						if (int.TryParse(text, out var result) && (int)fieldDefinition.Constant == result)
						{
							ILEnumTypeInstance iLEnumTypeInstance2 = new ILEnumTypeInstance(iLType);
							iLEnumTypeInstance2[0] = fieldDefinition.Constant;
							iLEnumTypeInstance2.Boxed = true;
							return ILIntepreter.PushObject(esp2, mStack, iLEnumTypeInstance2, isBox: true);
						}
					}
				}
				return ILIntepreter.PushNull(esp2);
			}
			throw new Exception($"{type.FullName} is not Enum");
		}
		if (type is ILRuntimeWrapperType)
		{
			return ILIntepreter.PushObject(esp2, mStack, Enum.Parse(((ILRuntimeWrapperType)type).RealType, text), isBox: true);
		}
		return ILIntepreter.PushObject(esp2, mStack, Enum.Parse(type, text), isBox: true);
	}

	public unsafe static StackObject* EnumGetValues(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		Type type = (Type)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (type is ILRuntimeType)
		{
			ILType iLType = ((ILRuntimeType)type).ILType;
			if (iLType.IsEnum)
			{
				IList list = null;
				bool flag = false;
				Collection<FieldDefinition> fields = iLType.TypeDefinition.Fields;
				for (int i = 0; i < fields.Count; i++)
				{
					FieldDefinition fieldDefinition = fields[i];
					if (!fieldDefinition.IsStatic)
					{
						continue;
					}
					if (list == null)
					{
						if (fieldDefinition.Constant is long)
						{
							list = new List<long>();
							flag = true;
						}
						else
						{
							list = new List<int>();
						}
					}
					list.Add(fieldDefinition.Constant);
				}
				object obj = (flag ? ((List<long>)list).ToArray() : ((list != null) ? ((object)((List<int>)list).ToArray()) : ((object)new int[0])));
				return ILIntepreter.PushObject(esp2, mStack, obj, isBox: true);
			}
			throw new Exception($"{type.FullName} is not Enum");
		}
		if (type is ILRuntimeWrapperType)
		{
			return ILIntepreter.PushObject(esp2, mStack, Enum.GetValues(((ILRuntimeWrapperType)type).RealType), isBox: true);
		}
		return ILIntepreter.PushObject(esp2, mStack, Enum.GetValues(type), isBox: true);
	}

	public unsafe static StackObject* EnumGetNames(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		Type type = (Type)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (type is ILRuntimeType)
		{
			ILType iLType = ((ILRuntimeType)type).ILType;
			List<string> list = new List<string>();
			if (iLType.IsEnum)
			{
				Collection<FieldDefinition> fields = iLType.TypeDefinition.Fields;
				for (int i = 0; i < fields.Count; i++)
				{
					FieldDefinition fieldDefinition = fields[i];
					if (fieldDefinition.IsStatic)
					{
						list.Add(fieldDefinition.Name);
					}
				}
				return ILIntepreter.PushObject(esp2, mStack, list.ToArray(), isBox: true);
			}
			throw new Exception($"{type.FullName} is not Enum");
		}
		if (type is ILRuntimeWrapperType)
		{
			return ILIntepreter.PushObject(esp2, mStack, Enum.GetNames(((ILRuntimeWrapperType)type).RealType), isBox: true);
		}
		return ILIntepreter.PushObject(esp2, mStack, Enum.GetNames(type), isBox: true);
	}

	public unsafe static StackObject* EnumGetName(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 1 - 1;
		Type type = (Type)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (type is ILRuntimeType)
		{
			ILType iLType = ((ILRuntimeType)type).ILType;
			new List<string>();
			if (iLType.IsEnum)
			{
				if (obj is ILEnumTypeInstance)
				{
					ILEnumTypeInstance iLEnumTypeInstance = (ILEnumTypeInstance)obj;
					return ILIntepreter.PushObject(esp2, mStack, iLEnumTypeInstance.ToString(), isBox: true);
				}
				if (obj.GetType().IsPrimitive)
				{
					ILEnumTypeInstance iLEnumTypeInstance2 = new ILEnumTypeInstance(iLType);
					iLEnumTypeInstance2[0] = obj;
					return ILIntepreter.PushObject(esp2, mStack, iLEnumTypeInstance2.ToString(), isBox: true);
				}
				throw new NotImplementedException();
			}
			throw new Exception($"{type.FullName} is not Enum");
		}
		if (type is ILRuntimeWrapperType)
		{
			return ILIntepreter.PushObject(esp2, mStack, Enum.GetName(((ILRuntimeWrapperType)type).RealType, obj), isBox: true);
		}
		return ILIntepreter.PushObject(esp2, mStack, Enum.GetName(type, obj), isBox: true);
	}

	public unsafe static StackObject* EnumToObject(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* ptr = esp - 1;
		int value = ptr->Value;
		intp.Free(ptr);
		ptr = esp - 1 - 1;
		Type type = (Type)StackObject.ToObject(ptr, appDomain, mStack);
		intp.Free(ptr);
		if (type is ILRuntimeType)
		{
			ILType iLType = ((ILRuntimeType)type).ILType;
			new List<string>();
			if (iLType.IsEnum)
			{
				ILEnumTypeInstance iLEnumTypeInstance = new ILEnumTypeInstance(iLType);
				iLEnumTypeInstance[0] = value;
				return ILIntepreter.PushObject(esp2, mStack, iLEnumTypeInstance, isBox: true);
			}
			throw new Exception($"{type.FullName} is not Enum");
		}
		if (type is ILRuntimeWrapperType)
		{
			return ILIntepreter.PushObject(esp2, mStack, Enum.GetName(((ILRuntimeWrapperType)type).RealType, value), isBox: true);
		}
		return ILIntepreter.PushObject(esp2, mStack, Enum.GetName(type, value), isBox: true);
	}

	public unsafe static StackObject* EnumHasFlag(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 1 - 1;
		object obj2 = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		bool flag = false;
		if (obj2 is ILEnumTypeInstance)
		{
			int value = ((ILEnumTypeInstance)obj2).Fields[0].Value;
			int value2 = ((ILEnumTypeInstance)obj).Fields[0].Value;
			flag = (value & value2) == value2;
		}
		else
		{
			flag = ((Enum)obj2).HasFlag((Enum)obj);
		}
		if (flag)
		{
			return ILIntepreter.PushOne(esp2);
		}
		return ILIntepreter.PushZero(esp2);
	}

	public unsafe static StackObject* EnumCompareTo(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* num = esp - 1 - 1;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp2 = esp - 1;
		object obj = StackObject.ToObject(esp2, appDomain, mStack);
		intp.Free(esp2);
		esp2 = esp - 1 - 1;
		object obj2 = StackObject.ToObject(esp2, appDomain, mStack);
		intp.Free(esp2);
		int num2 = 0;
		if (obj2 is ILEnumTypeInstance)
		{
			int value = ((ILEnumTypeInstance)obj2).Fields[0].Value;
			int value2 = ((ILEnumTypeInstance)obj).Fields[0].Value;
			num2 = value - value2;
		}
		else
		{
			num2 = ((Enum)obj2).CompareTo(obj);
		}
		num->ObjectType = ObjectTypes.Integer;
		num->Value = num2;
		return num + 1;
	}

	public unsafe static StackObject* DelegateCreateDelegate(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 2;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		MethodInfo methodInfo = (MethodInfo)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 1 - 1;
		Type type = (Type)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (type is ILRuntimeType)
		{
			ILType iLType = ((ILRuntimeType)type).ILType;
			if (iLType.IsDelegate)
			{
				ILMethod method2 = iLType.GetMethod("Invoke") as ILMethod;
				object obj = null;
				if (methodInfo is ILRuntimeMethodInfo)
				{
					ILMethod iLMethod = ((ILRuntimeMethodInfo)methodInfo).ILMethod;
					if (iLMethod.DelegateAdapter == null)
					{
						iLMethod.DelegateAdapter = appDomain.DelegateManager.FindDelegateAdapter(null, iLMethod, method2);
					}
					obj = iLMethod.DelegateAdapter;
					return ILIntepreter.PushObject(esp2, mStack, obj, isBox: true);
				}
				throw new NotSupportedException();
			}
			throw new NotSupportedException($"{type.FullName} is not Delegate");
		}
		if (type is ILRuntimeWrapperType)
		{
			ILRuntimeWrapperType iLRuntimeWrapperType = (ILRuntimeWrapperType)type;
			object obj2 = null;
			if (methodInfo is ILRuntimeMethodInfo)
			{
				ILRuntimeMethodInfo iLRuntimeMethodInfo = (ILRuntimeMethodInfo)methodInfo;
				obj2 = appDomain.DelegateManager.FindDelegateAdapter(iLRuntimeWrapperType.CLRType, null, iLRuntimeMethodInfo.ILMethod);
			}
			else
			{
				obj2 = Delegate.CreateDelegate(iLRuntimeWrapperType.RealType, methodInfo);
			}
			return ILIntepreter.PushObject(esp2, mStack, obj2, isBox: true);
		}
		return ILIntepreter.PushObject(esp2, mStack, Delegate.CreateDelegate(type, methodInfo), isBox: true);
	}

	public unsafe static StackObject* DelegateCreateDelegate2(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 3;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		string text = (string)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 2;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 3;
		Type type = (Type)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (obj == null)
		{
			throw new ArgumentNullException("Argument target cannot be null");
		}
		if (type is ILRuntimeType)
		{
			ILType iLType = ((ILRuntimeType)type).ILType;
			if (iLType.IsDelegate)
			{
				ILMethod method2 = iLType.GetMethod("Invoke") as ILMethod;
				if (obj is ILTypeInstance)
				{
					ILTypeInstance iLTypeInstance = (ILTypeInstance)obj;
					if (!(iLTypeInstance.Type.GetMethod(text) is ILMethod iLMethod))
					{
						throw new ArgumentException($"Cannot find method \"{text}\" in type {iLType.FullName}");
					}
					if (iLMethod.DelegateAdapter == null)
					{
						iLMethod.DelegateAdapter = appDomain.DelegateManager.FindDelegateAdapter(iLTypeInstance, iLMethod, method2);
					}
					object delegateAdapter = iLMethod.DelegateAdapter;
					return ILIntepreter.PushObject(esp2, mStack, delegateAdapter, isBox: true);
				}
				throw new NotSupportedException();
			}
			throw new NotSupportedException($"{type.FullName} is not Delegate");
		}
		if (type is ILRuntimeWrapperType)
		{
			ILRuntimeWrapperType iLRuntimeWrapperType = (ILRuntimeWrapperType)type;
			object obj2 = null;
			if (obj is ILTypeInstance)
			{
				ILTypeInstance iLTypeInstance2 = (ILTypeInstance)obj;
				if (!(iLTypeInstance2.Type.GetMethod(text) is ILMethod ilMethod))
				{
					throw new ArgumentException($"Cannot find method \"{text}\" in type {iLTypeInstance2.Type.FullName}");
				}
				obj2 = appDomain.DelegateManager.FindDelegateAdapter(iLRuntimeWrapperType.CLRType, iLTypeInstance2, ilMethod);
			}
			else
			{
				obj2 = Delegate.CreateDelegate(iLRuntimeWrapperType.RealType, obj, text);
			}
			return ILIntepreter.PushObject(esp2, mStack, obj2, isBox: true);
		}
		return ILIntepreter.PushObject(esp2, mStack, Delegate.CreateDelegate(type, obj, text), isBox: true);
	}

	public unsafe static StackObject* DelegateCreateDelegate3(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 3;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		MethodInfo methodInfo = (MethodInfo)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 2;
		object obj = StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 3;
		Type type = (Type)StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		if (type is ILRuntimeType)
		{
			ILType iLType = ((ILRuntimeType)type).ILType;
			if (iLType.IsDelegate)
			{
				object obj2 = null;
				if (methodInfo is ILRuntimeMethodInfo)
				{
					ILMethod iLMethod = ((ILRuntimeMethodInfo)methodInfo).ILMethod;
					if (obj != null)
					{
						obj2 = ((ILTypeInstance)obj).GetDelegateAdapter(iLMethod);
						if (obj2 == null)
						{
							IMethod method2 = iLType.GetMethod("Invoke", iLMethod.ParameterCount);
							if (method2 == null && iLMethod.IsExtend)
							{
								method2 = iLType.GetMethod("Invoke", iLMethod.ParameterCount - 1);
							}
							obj2 = appDomain.DelegateManager.FindDelegateAdapter((ILTypeInstance)obj, iLMethod, method2);
						}
					}
					else
					{
						if (iLMethod.DelegateAdapter == null)
						{
							ILMethod method3 = iLType.GetMethod("Invoke") as ILMethod;
							iLMethod.DelegateAdapter = appDomain.DelegateManager.FindDelegateAdapter(null, iLMethod, method3);
						}
						obj2 = iLMethod.DelegateAdapter;
					}
					return ILIntepreter.PushObject(esp2, mStack, obj2, isBox: true);
				}
				throw new NotSupportedException();
			}
			throw new NotSupportedException($"{type.FullName} is not Delegate");
		}
		if (type is ILRuntimeWrapperType)
		{
			ILRuntimeWrapperType iLRuntimeWrapperType = (ILRuntimeWrapperType)type;
			object obj3 = null;
			if (methodInfo is ILRuntimeMethodInfo)
			{
				ILRuntimeMethodInfo iLRuntimeMethodInfo = (ILRuntimeMethodInfo)methodInfo;
				obj3 = appDomain.DelegateManager.FindDelegateAdapter(iLRuntimeWrapperType.CLRType, obj as ILTypeInstance, iLRuntimeMethodInfo.ILMethod);
			}
			else
			{
				obj3 = Delegate.CreateDelegate(iLRuntimeWrapperType.RealType, obj, methodInfo);
			}
			return ILIntepreter.PushObject(esp2, mStack, obj3, isBox: true);
		}
		return ILIntepreter.PushObject(esp2, mStack, Delegate.CreateDelegate(type, obj, methodInfo), isBox: true);
	}

	public unsafe static StackObject* TypeMakeGenericType(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		StackObject* esp2 = esp - 2;
		AppDomain appDomain = intp.AppDomain;
		StackObject* esp3 = esp - 1;
		Type[] array = (Type[])StackObject.ToObject(esp3, appDomain, mStack);
		intp.Free(esp3);
		esp3 = esp - 2;
		IType type = ToIType((Type)StackObject.ToObject(esp3, appDomain, mStack), appDomain);
		intp.Free(esp3);
		if (!type.HasGenericParameter)
		{
			throw new NotSupportedException($"{type.FullName} is not a generic type");
		}
		if (type is ILType iLType)
		{
			KeyValuePair<string, IType>[] array2 = new KeyValuePair<string, IType>[iLType.TypeDefinition.GenericParameters.Count];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = new KeyValuePair<string, IType>(iLType.TypeDefinition.GenericParameters[i].Name, ToIType(array[i], appDomain));
			}
			return ILIntepreter.PushObject(esp2, mStack, type.MakeGenericInstance(array2).ReflectionType, isBox: true);
		}
		if (type is CLRType)
		{
			KeyValuePair<string, IType>[] array3 = new KeyValuePair<string, IType>[array.Length];
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j] = new KeyValuePair<string, IType>("!", ToIType(array[j], appDomain));
			}
			return ILIntepreter.PushObject(esp2, mStack, type.MakeGenericInstance(array3).ReflectionType, isBox: true);
		}
		throw new NotImplementedException();
	}

	private static IType ToIType(Type type, AppDomain domain)
	{
		if (type is ILRuntimeType)
		{
			return ((ILRuntimeType)type).ILType;
		}
		if (type is ILRuntimeWrapperType)
		{
			return ((ILRuntimeWrapperType)type).CLRType;
		}
		return domain.GetType(type);
	}
}
