using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Other;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.CLR.Method;

public sealed class CLRMethod : IMethod
{
	private MethodInfo def;

	private ConstructorInfo cDef;

	private List<IType> parameters;

	private ParameterInfo[] parametersCLR;

	private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private CLRType declaringType;

	private bool isConstructor;

	private CLRRedirectionDelegate redirect;

	private IType[] genericArguments;

	private Type[] genericArgumentsCLR;

	private object[] invocationParam;

	private bool isDelegateInvoke;

	private bool isDelegateDynamicInvoke;

	private int hashCode = -1;

	private static int instance_id = 536870912;

	private int _genericParameterCount = -1;

	private bool? isExtend;

	public IType DeclearingType => declaringType;

	public string Name => def.Name;

	public bool HasThis
	{
		get
		{
			if (!isConstructor)
			{
				return !def.IsStatic;
			}
			return !cDef.IsStatic;
		}
	}

	public int GenericParameterCount
	{
		get
		{
			if (_genericParameterCount == -1)
			{
				if (def.ContainsGenericParameters && def.IsGenericMethodDefinition)
				{
					_genericParameterCount = def.GetGenericArguments().Length;
				}
				else
				{
					_genericParameterCount = 0;
				}
			}
			return _genericParameterCount;
		}
	}

	public bool IsGenericInstance => genericArguments != null;

	public bool IsDelegateInvoke => isDelegateInvoke;

	public bool IsDelegateDynamicInvoke => isDelegateDynamicInvoke;

	public bool IsStatic
	{
		get
		{
			if (cDef != null)
			{
				return cDef.IsStatic;
			}
			return def.IsStatic;
		}
	}

	public CLRRedirectionDelegate Redirection
	{
		get
		{
			if (redirect == null)
			{
				if (def != null)
				{
					if (def.IsGenericMethod && !def.IsGenericMethodDefinition)
					{
						if (!appdomain.RedirectMap.TryGetValue(def.GetGenericMethodDefinition(), out redirect))
						{
							appdomain.RedirectMap.TryGetValue(def, out redirect);
						}
					}
					else
					{
						appdomain.RedirectMap.TryGetValue(def, out redirect);
					}
				}
				else if (cDef != null)
				{
					appdomain.RedirectMap.TryGetValue(cDef, out redirect);
				}
			}
			return redirect;
		}
	}

	public MethodInfo MethodInfo => def;

	public ConstructorInfo ConstructorInfo => cDef;

	public IType[] GenericArguments => genericArguments;

	public Type[] GenericArgumentsCLR
	{
		get
		{
			if (genericArgumentsCLR == null)
			{
				if (cDef != null)
				{
					genericArgumentsCLR = cDef.GetGenericArguments();
				}
				else
				{
					genericArgumentsCLR = def.GetGenericArguments();
				}
			}
			return genericArgumentsCLR;
		}
	}

	public int ParameterCount => Parameters.Count;

	public List<IType> Parameters
	{
		get
		{
			if (parameters == null)
			{
				InitParameters();
			}
			return parameters;
		}
	}

	public ParameterInfo[] ParametersCLR
	{
		get
		{
			if (parametersCLR == null)
			{
				if (cDef != null)
				{
					parametersCLR = cDef.GetParameters();
				}
				else
				{
					parametersCLR = def.GetParameters();
				}
			}
			return parametersCLR;
		}
	}

	public IType ReturnType { get; private set; }

	public bool IsConstructor => cDef != null;

	public bool IsExtend
	{
		get
		{
			if (!isExtend.HasValue)
			{
				isExtend = this.IsExtendMethod();
			}
			return isExtend.Value;
		}
	}

	internal CLRMethod(MethodInfo def, CLRType type, ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		this.def = def;
		declaringType = type;
		appdomain = domain;
		if (!def.ContainsGenericParameters)
		{
			ReturnType = domain.GetType(def.ReturnType.FullName);
			if (ReturnType == null)
			{
				ReturnType = domain.GetType(def.ReturnType.AssemblyQualifiedName);
			}
		}
		if (type.IsDelegate)
		{
			if (def.Name == "Invoke")
			{
				isDelegateInvoke = true;
			}
			if (def.Name == "DynamicInvoke")
			{
				isDelegateInvoke = true;
				isDelegateDynamicInvoke = true;
			}
		}
		isConstructor = false;
	}

	internal CLRMethod(ConstructorInfo def, CLRType type, ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		cDef = def;
		declaringType = type;
		appdomain = domain;
		if (!def.ContainsGenericParameters)
		{
			ReturnType = type;
		}
		isConstructor = true;
	}

	private void InitParameters()
	{
		parameters = new List<IType>();
		ParameterInfo[] array = ParametersCLR;
		foreach (ParameterInfo parameterInfo in array)
		{
			IType type = appdomain.GetType(parameterInfo.ParameterType.FullName);
			if (type == null)
			{
				type = appdomain.GetType(parameterInfo.ParameterType.AssemblyQualifiedName);
			}
			if (parameterInfo.ParameterType.IsGenericTypeDefinition)
			{
				if (type == null)
				{
					type = appdomain.GetType(parameterInfo.ParameterType.GetGenericTypeDefinition().FullName);
				}
				if (type == null)
				{
					type = appdomain.GetType(parameterInfo.ParameterType.GetGenericTypeDefinition().AssemblyQualifiedName);
				}
			}
			if (parameterInfo.ParameterType.ContainsGenericParameters)
			{
				Type type2 = parameterInfo.ParameterType;
				if (type2.HasElementType)
				{
					type2 = parameterInfo.ParameterType.GetElementType();
				}
				else if (type2.GetGenericArguments().Length != 0)
				{
					type2 = type2.GetGenericArguments()[0];
				}
				type = new ILGenericParameterType(type2.Name);
			}
			if (type == null)
			{
				throw new TypeLoadException();
			}
			parameters.Add(type);
		}
	}

	private unsafe StackObject* Minus(StackObject* a, int b)
	{
		return (StackObject*)((ulong)a - (ulong)(sizeof(StackObject) * b));
	}

	public unsafe object Invoke(ILIntepreter intepreter, StackObject* esp, UncheckedList<object> mStack, bool isNewObj = false)
	{
		if (parameters == null)
		{
			InitParameters();
		}
		int parameterCount = ParameterCount;
		if (invocationParam == null)
		{
			invocationParam = new object[parameterCount];
		}
		object[] array = invocationParam;
		for (int num = parameterCount; num >= 1; num--)
		{
			StackObject* esp2 = Minus(esp, num);
			object obj = ParametersCLR[parameterCount - num].ParameterType.CheckCLRTypes(StackObject.ToObject(esp2, appdomain, mStack));
			obj = ILIntepreter.CheckAndCloneValueType(obj, appdomain);
			array[parameterCount - num] = obj;
		}
		if (isConstructor)
		{
			if (!isNewObj)
			{
				if (!cDef.IsStatic)
				{
					object obj2 = declaringType.TypeForCLR.CheckCLRTypes(StackObject.ToObject(Minus(esp, parameterCount + 1), appdomain, mStack));
					if (obj2 == null)
					{
						throw new NullReferenceException();
					}
					if (obj2 is CrossBindingAdaptorType && parameterCount == 0)
					{
						return null;
					}
					cDef.Invoke(obj2, array);
					Array.Clear(invocationParam, 0, invocationParam.Length);
					return null;
				}
				throw new NotImplementedException();
			}
			object result = cDef.Invoke(array);
			FixReference(parameterCount, esp, array, mStack, null, hasThis: false);
			Array.Clear(invocationParam, 0, invocationParam.Length);
			return result;
		}
		object obj3 = null;
		if (!def.IsStatic)
		{
			obj3 = StackObject.ToObject(Minus(esp, parameterCount + 1), appdomain, mStack);
			if (!(obj3 is ILRuntimeWrapperType))
			{
				obj3 = declaringType.TypeForCLR.CheckCLRTypes(obj3);
			}
			if (declaringType.IsValueType)
			{
				obj3 = ILIntepreter.CheckAndCloneValueType(obj3, appdomain);
			}
			if (obj3 == null)
			{
				throw new NullReferenceException();
			}
		}
		object? result2 = def.Invoke(obj3, array);
		FixReference(parameterCount, esp, array, mStack, obj3, !def.IsStatic);
		Array.Clear(invocationParam, 0, invocationParam.Length);
		return result2;
	}

	private unsafe void FixReference(int paramCount, StackObject* esp, object[] param, UncheckedList<object> mStack, object instance, bool hasThis)
	{
		for (int num = (hasThis ? (paramCount + 1) : paramCount); num >= 1; num--)
		{
			StackObject* ptr = Minus(esp, num);
			object obj = ((num <= paramCount) ? param[paramCount - num] : instance);
			switch (ptr->ObjectType)
			{
			case ObjectTypes.StackObjectReference:
			{
				StackObject* ptr2 = (StackObject*)(*(ulong*)(&ptr->Value));
				if (ptr2->ObjectType >= ObjectTypes.Object)
				{
					object obj3 = obj;
					if (obj3 is CrossBindingAdaptorType)
					{
						obj3 = ((CrossBindingAdaptorType)obj3).ILInstance;
					}
					mStack[ptr2->Value] = obj3;
				}
				else
				{
					ILIntepreter.UnboxObject(ptr2, obj, mStack, appdomain);
				}
				break;
			}
			case ObjectTypes.FieldReference:
			{
				object obj2 = mStack[ptr->Value];
				if (obj2 is ILTypeInstance)
				{
					((ILTypeInstance)obj2)[ptr->ValueLow] = obj;
				}
				else
				{
					(appdomain.GetType(obj2.GetType()) as CLRType).GetField(ptr->ValueLow).SetValue(obj2, obj);
				}
				break;
			}
			case ObjectTypes.StaticFieldReference:
			{
				IType type = appdomain.GetType(ptr->Value);
				if (type is ILType)
				{
					((ILType)type).StaticInstance[ptr->ValueLow] = obj;
				}
				else
				{
					((CLRType)type).SetStaticFieldValue(ptr->ValueLow, obj);
				}
				break;
			}
			case ObjectTypes.ArrayReference:
				(mStack[ptr->Value] as Array).SetValue(obj, ptr->ValueLow);
				break;
			}
		}
	}

	public IMethod MakeGenericMethod(IType[] genericArguments)
	{
		Type[] array = new Type[genericArguments.Length];
		for (int i = 0; i < genericArguments.Length; i++)
		{
			array[i] = genericArguments[i].TypeForCLR;
		}
		return new CLRMethod(def.MakeGenericMethod(array), declaringType, appdomain)
		{
			genericArguments = genericArguments
		};
	}

	public override string ToString()
	{
		if (def != null)
		{
			return def.ToString();
		}
		return cDef.ToString();
	}

	public override int GetHashCode()
	{
		if (hashCode == -1)
		{
			hashCode = Interlocked.Add(ref instance_id, 1);
		}
		return hashCode;
	}
}
