using System;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.Utils;
using ILRuntime.Other;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Enviorment;

public struct InvocationContext : IDisposable
{
	private unsafe StackObject* ebp;

	private unsafe StackObject* esp;

	private AppDomain domain;

	private ILIntepreter intp;

	private ILMethod method;

	private UncheckedList<object> mStack;

	private bool invocated;

	private int paramCnt;

	private bool hasReturn;

	private bool useRegister;

	private static bool defaultConverterIntialized;

	internal unsafe StackObject* ESP
	{
		get
		{
			return esp;
		}
		set
		{
			esp = value;
		}
	}

	internal ILIntepreter Intepreter => intp;

	internal UncheckedList<object> ManagedStack => mStack;

	internal static void InitializeDefaultConverters()
	{
		if (!defaultConverterIntialized)
		{
			PrimitiveConverter<int>.ToInteger = (int a) => a;
			PrimitiveConverter<int>.FromInteger = (int a) => a;
			PrimitiveConverter<short>.ToInteger = (short a) => a;
			PrimitiveConverter<short>.FromInteger = (int a) => (short)a;
			PrimitiveConverter<byte>.ToInteger = (byte a) => a;
			PrimitiveConverter<byte>.FromInteger = (int a) => (byte)a;
			PrimitiveConverter<sbyte>.ToInteger = (sbyte a) => a;
			PrimitiveConverter<sbyte>.FromInteger = (int a) => (sbyte)a;
			PrimitiveConverter<ushort>.ToInteger = (ushort a) => a;
			PrimitiveConverter<ushort>.FromInteger = (int a) => (ushort)a;
			PrimitiveConverter<char>.ToInteger = (char a) => a;
			PrimitiveConverter<char>.FromInteger = (int a) => (char)a;
			PrimitiveConverter<uint>.ToInteger = (uint a) => (int)a;
			PrimitiveConverter<uint>.FromInteger = (int a) => (uint)a;
			PrimitiveConverter<bool>.ToInteger = (bool a) => a ? 1 : 0;
			PrimitiveConverter<bool>.FromInteger = (int a) => a == 1;
			PrimitiveConverter<long>.ToLong = (long a) => a;
			PrimitiveConverter<long>.FromLong = (long a) => a;
			PrimitiveConverter<ulong>.ToLong = (ulong a) => (long)a;
			PrimitiveConverter<ulong>.FromLong = (long a) => (ulong)a;
			PrimitiveConverter<float>.ToFloat = (float a) => a;
			PrimitiveConverter<float>.FromFloat = (float a) => a;
			PrimitiveConverter<double>.ToDouble = (double a) => a;
			PrimitiveConverter<double>.FromDouble = (double a) => a;
			defaultConverterIntialized = true;
		}
	}

	internal static InvocationTypes GetInvocationType<T>()
	{
		Type typeFromHandle = typeof(T);
		if (typeFromHandle.IsPrimitive)
		{
			if (typeFromHandle == typeof(int))
			{
				return InvocationTypes.Integer;
			}
			if (typeFromHandle == typeof(short))
			{
				return InvocationTypes.Integer;
			}
			if (typeFromHandle == typeof(bool))
			{
				return InvocationTypes.Integer;
			}
			if (typeFromHandle == typeof(long))
			{
				return InvocationTypes.Long;
			}
			if (typeFromHandle == typeof(float))
			{
				return InvocationTypes.Float;
			}
			if (typeFromHandle == typeof(double))
			{
				return InvocationTypes.Double;
			}
			if (typeFromHandle == typeof(char))
			{
				return InvocationTypes.Integer;
			}
			if (typeFromHandle == typeof(ushort))
			{
				return InvocationTypes.Integer;
			}
			if (typeFromHandle == typeof(uint))
			{
				return InvocationTypes.Integer;
			}
			if (typeFromHandle == typeof(ulong))
			{
				return InvocationTypes.Long;
			}
			if (typeFromHandle == typeof(byte))
			{
				return InvocationTypes.Integer;
			}
			if (typeFromHandle == typeof(sbyte))
			{
				return InvocationTypes.Integer;
			}
			throw new NotImplementedException($"Not supported type:{typeFromHandle.FullName}");
		}
		if (typeFromHandle.IsEnum)
		{
			if (PrimitiveConverter<T>.ToInteger != null && PrimitiveConverter<T>.FromInteger != null)
			{
				return InvocationTypes.Integer;
			}
			if (PrimitiveConverter<T>.ToLong != null && PrimitiveConverter<T>.FromLong != null)
			{
				return InvocationTypes.Long;
			}
			return InvocationTypes.Enum;
		}
		if (typeFromHandle.IsValueType)
		{
			return InvocationTypes.ValueType;
		}
		return InvocationTypes.Object;
	}

	internal unsafe InvocationContext(ILIntepreter intp, ILMethod method)
	{
		RuntimeStack stack = intp.Stack;
		mStack = stack.ManagedStack;
		esp = stack.StackBase;
		ebp = esp;
		stack.ResetValueTypePointer();
		domain = intp.AppDomain;
		this.intp = intp;
		this.method = method;
		invocated = false;
		paramCnt = 0;
		hasReturn = method.ReturnType != domain.VoidType;
		useRegister = method.ShouldUseRegisterVM;
	}

	internal unsafe void SetInvoked(StackObject* esp)
	{
		this.esp = esp - 1;
		invocated = true;
	}

	public void PushBool(bool val)
	{
		PushInteger(val ? 1 : 0);
	}

	public void PushInteger<T>(T val)
	{
		PushInteger(PrimitiveConverter<T>.CheckAndInvokeToInteger(val));
	}

	public void PushLong<T>(T val)
	{
		PushInteger(PrimitiveConverter<T>.CheckAndInvokeToLong(val));
	}

	public unsafe void PushInteger(int val)
	{
		esp->ObjectType = ObjectTypes.Integer;
		esp->Value = val;
		esp->ValueLow = 0;
		if (useRegister)
		{
			mStack.Add(null);
		}
		esp++;
		paramCnt++;
	}

	public unsafe void PushInteger(long val)
	{
		esp->ObjectType = ObjectTypes.Long;
		*(long*)(&esp->Value) = val;
		if (useRegister)
		{
			mStack.Add(null);
		}
		esp++;
		paramCnt++;
	}

	public void PushFloat<T>(T val)
	{
		PushFloat(PrimitiveConverter<T>.CheckAndInvokeToFloat(val));
	}

	public unsafe void PushFloat(float val)
	{
		esp->ObjectType = ObjectTypes.Float;
		*(float*)(&esp->Value) = val;
		if (useRegister)
		{
			mStack.Add(null);
		}
		esp++;
		paramCnt++;
	}

	public void PushDouble<T>(T val)
	{
		PushDouble(PrimitiveConverter<T>.CheckAndInvokeToDouble(val));
	}

	public unsafe void PushDouble(double val)
	{
		esp->ObjectType = ObjectTypes.Double;
		*(double*)(&esp->Value) = val;
		if (useRegister)
		{
			mStack.Add(null);
		}
		esp++;
		paramCnt++;
	}

	public unsafe void PushValueType<T>(ref T obj)
	{
		Type typeFromHandle = typeof(T);
		bool flag = false;
		StackObject* ptr = default(StackObject*);
		if (domain.ValueTypeBinders.TryGetValue(typeFromHandle, out var value))
		{
			if (value is ValueTypeBinder<T> valueTypeBinder)
			{
				valueTypeBinder.PushValue(ref obj, intp, esp, mStack);
				if (useRegister)
				{
					mStack.Add(null);
				}
				ptr = esp + 1;
			}
			else
			{
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			ptr = ILIntepreter.PushObject(esp, mStack, obj, isBox: true);
		}
		esp = ptr;
		paramCnt++;
	}

	public unsafe void PushObject(object obj, bool isBox = true)
	{
		if (obj is CrossBindingAdaptorType)
		{
			obj = ((CrossBindingAdaptorType)obj).ILInstance;
		}
		StackObject* ptr = ILIntepreter.PushObject(esp, mStack, obj, isBox);
		if (esp->ObjectType < ObjectTypes.Object && useRegister)
		{
			mStack.Add(null);
		}
		esp = ptr;
		paramCnt++;
	}

	public unsafe void PushReference(int index)
	{
		StackObject* ptr = ILIntepreter.Add(ebp, index);
		esp->ObjectType = ObjectTypes.StackObjectReference;
		*(long*)(&esp->Value) = (long)ptr;
		if (useRegister)
		{
			mStack.Add(null);
		}
		esp++;
	}

	internal void PushParameter<T>(InvocationTypes type, T val)
	{
		switch (type)
		{
		case InvocationTypes.Integer:
			PushInteger(val);
			break;
		case InvocationTypes.Long:
			PushLong(val);
			break;
		case InvocationTypes.Float:
			PushFloat(val);
			break;
		case InvocationTypes.Double:
			PushDouble(val);
			break;
		case InvocationTypes.Enum:
			PushObject(val, isBox: false);
			break;
		case InvocationTypes.ValueType:
			PushValueType(ref val);
			break;
		default:
			PushObject(val);
			break;
		}
	}

	internal T ReadResult<T>(InvocationTypes type)
	{
		return type switch
		{
			InvocationTypes.Integer => ReadInteger<T>(), 
			InvocationTypes.Long => ReadLong<T>(), 
			InvocationTypes.Float => ReadFloat<T>(), 
			InvocationTypes.Double => ReadDouble<T>(), 
			InvocationTypes.ValueType => ReadValueType<T>(), 
			_ => ReadObject<T>(), 
		};
	}

	public unsafe void Invoke()
	{
		if (invocated)
		{
			throw new NotSupportedException("A invocation context can only be used once");
		}
		invocated = true;
		if ((method.HasThis ? (method.ParameterCount + 1) : method.ParameterCount) != paramCnt)
		{
			throw new ArgumentException("Argument count mismatch");
		}
		bool unhandledException;
		if (useRegister)
		{
			esp = intp.ExecuteR(method, esp, out unhandledException);
		}
		else
		{
			esp = intp.Execute(method, esp, out unhandledException);
		}
		esp--;
	}

	private void CheckReturnValue()
	{
		if (!invocated)
		{
			throw new NotSupportedException("You have to invocate first before you try to read the return value");
		}
		if (!hasReturn)
		{
			throw new NotSupportedException("The target method does not have a return value");
		}
	}

	public unsafe int ReadInteger()
	{
		CheckReturnValue();
		return esp->Value;
	}

	public unsafe int ReadInteger(int index)
	{
		return ILIntepreter.Add(ebp, index)->Value;
	}

	public T ReadInteger<T>()
	{
		return PrimitiveConverter<T>.CheckAndInvokeFromInteger(ReadInteger());
	}

	public unsafe long ReadLong()
	{
		CheckReturnValue();
		return *(long*)(&esp->Value);
	}

	public unsafe long ReadLong(int index)
	{
		return *(long*)(&ILIntepreter.Add(ebp, index)->Value);
	}

	public T ReadLong<T>()
	{
		return PrimitiveConverter<T>.CheckAndInvokeFromLong(ReadLong());
	}

	public unsafe float ReadFloat()
	{
		CheckReturnValue();
		return *(float*)(&esp->Value);
	}

	public unsafe float ReadFloat(int index)
	{
		return *(float*)(&ILIntepreter.Add(ebp, index)->Value);
	}

	public T ReadFloat<T>()
	{
		return PrimitiveConverter<T>.CheckAndInvokeFromFloat(ReadFloat());
	}

	public unsafe double ReadDouble()
	{
		CheckReturnValue();
		return *(double*)(&esp->Value);
	}

	public unsafe double ReaDouble(int index)
	{
		return *(double*)(&ILIntepreter.Add(ebp, index)->Value);
	}

	public T ReadDouble<T>()
	{
		return PrimitiveConverter<T>.CheckAndInvokeFromDouble(ReadDouble());
	}

	public unsafe bool ReadBool()
	{
		CheckReturnValue();
		return esp->Value == 1;
	}

	public unsafe bool ReadBool(int index)
	{
		return ILIntepreter.Add(ebp, index)->Value == 1;
	}

	public unsafe T ReadValueType<T>()
	{
		CheckReturnValue();
		Type typeFromHandle = typeof(T);
		T value = default(T);
		if (domain.ValueTypeBinders.TryGetValue(typeFromHandle, out var value2))
		{
			if (value2 is ValueTypeBinder<T> valueTypeBinder)
			{
				valueTypeBinder.ParseValue(ref value, intp, esp, mStack);
				return value;
			}
			return (T)typeFromHandle.CheckCLRTypes(StackObject.ToObject(esp, domain, mStack));
		}
		return (T)typeFromHandle.CheckCLRTypes(StackObject.ToObject(esp, domain, mStack));
	}

	public unsafe T ReadObject<T>()
	{
		CheckReturnValue();
		return (T)typeof(T).CheckCLRTypes(StackObject.ToObject(esp, domain, mStack));
	}

	public unsafe object ReadObject(Type type)
	{
		CheckReturnValue();
		return type.CheckCLRTypes(StackObject.ToObject(esp, domain, mStack));
	}

	public unsafe T ReadObject<T>(int index)
	{
		StackObject* ptr = ILIntepreter.Add(ebp, index);
		return (T)typeof(T).CheckCLRTypes(StackObject.ToObject(ptr, domain, mStack));
	}

	public unsafe void Dispose()
	{
		domain.FreeILIntepreter(intp);
		esp = null;
		intp = null;
		domain = null;
		method = null;
		mStack = null;
	}
}
