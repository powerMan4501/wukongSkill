using System;
using System.Collections.Generic;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Other;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Stack;

public struct StackObject
{
	public static StackObject Null = new StackObject
	{
		ObjectType = ObjectTypes.Null,
		Value = -1,
		ValueLow = 0
	};

	public ObjectTypes ObjectType;

	public int Value;

	public int ValueLow;

	public static bool operator ==(StackObject a, StackObject b)
	{
		if (a.ObjectType == b.ObjectType && a.Value == b.Value)
		{
			return a.ValueLow == b.ValueLow;
		}
		return false;
	}

	public static bool operator !=(StackObject a, StackObject b)
	{
		if (a.ObjectType == b.ObjectType && a.Value == b.Value)
		{
			return a.ValueLow == b.ValueLow;
		}
		return true;
	}

	[Obsolete]
	public unsafe static object ToObject(StackObject* esp, ILRuntime.Runtime.Enviorment.AppDomain appdomain, IList<object> mStack)
	{
		return ToObject(esp, appdomain, (UncheckedList<object>)mStack);
	}

	public unsafe static object ToObject(StackObject* esp, ILRuntime.Runtime.Enviorment.AppDomain appdomain, UncheckedList<object> mStack)
	{
		switch (esp->ObjectType)
		{
		case ObjectTypes.Integer:
			return esp->Value;
		case ObjectTypes.Long:
			return *(long*)(&esp->Value);
		case ObjectTypes.Float:
			return *(float*)(&esp->Value);
		case ObjectTypes.Double:
			return *(double*)(&esp->Value);
		case ObjectTypes.Object:
			return mStack[esp->Value];
		case ObjectTypes.FieldReference:
		{
			if (mStack[esp->Value] is ILTypeInstance iLTypeInstance2)
			{
				return iLTypeInstance2[esp->ValueLow];
			}
			object obj = mStack[esp->Value];
			IType type = null;
			type = ((!(obj is CrossBindingAdaptorType)) ? appdomain.GetType(obj.GetType()) : appdomain.GetType(((CrossBindingAdaptor)((CrossBindingAdaptorType)obj).ILInstance.Type.FirstCLRBaseType).BaseCLRType));
			return ((CLRType)type).GetFieldValue(esp->ValueLow, obj);
		}
		case ObjectTypes.ArrayReference:
			return (mStack[esp->Value] as Array).GetValue(esp->ValueLow);
		case ObjectTypes.StaticFieldReference:
		{
			IType type2 = appdomain.GetType(esp->Value);
			if (type2 is ILType)
			{
				return ((ILType)type2).StaticInstance[esp->ValueLow];
			}
			return ((CLRType)type2).GetFieldValue(esp->ValueLow, null);
		}
		case ObjectTypes.StackObjectReference:
			return ToObject(ILIntepreter.ResolveReference(esp), appdomain, mStack);
		case ObjectTypes.ValueTypeObjectReference:
		{
			StackObject* ptr = ILIntepreter.ResolveReference(esp);
			IType typeByIndex = appdomain.GetTypeByIndex(ptr->Value);
			if (typeByIndex is ILType)
			{
				ILTypeInstance iLTypeInstance = ((ILType)typeByIndex).Instantiate(callDefaultConstructor: false);
				for (int i = 0; i < ptr->ValueLow; i++)
				{
					StackObject* esp2 = ILIntepreter.Minus(ptr, i + 1);
					iLTypeInstance.AssignFromStack(i, esp2, appdomain, mStack);
				}
				return iLTypeInstance;
			}
			return ((CLRType)typeByIndex).ValueTypeBinder.ToObject(ptr, mStack);
		}
		case ObjectTypes.Null:
			return null;
		default:
			throw new NotImplementedException();
		}
	}

	public static void Initialized(ref StackObject esp, int idx, IType fieldType, UncheckedList<object> mStack)
	{
		if (fieldType.IsPrimitive)
		{
			esp = fieldType.DefaultObject;
		}
		else if (fieldType.IsValueType)
		{
			esp.ObjectType = ObjectTypes.Object;
			esp.Value = idx;
			if (fieldType is CLRType)
			{
				if (fieldType.TypeForCLR.IsEnum)
				{
					esp.ObjectType = ObjectTypes.Integer;
					esp.Value = 0;
					esp.ValueLow = 0;
					mStack[idx] = null;
				}
				else
				{
					mStack[idx] = ((CLRType)fieldType).CreateDefaultInstance();
				}
			}
			else if (((ILType)fieldType).IsEnum)
			{
				esp.ObjectType = ObjectTypes.Integer;
				esp.Value = 0;
				esp.ValueLow = 0;
				mStack[idx] = null;
			}
			else
			{
				mStack[idx] = ((ILType)fieldType).Instantiate();
			}
		}
		else
		{
			esp = Null;
			mStack[idx] = null;
		}
	}

	public unsafe static void Initialized(StackObject* esp, IType type)
	{
		if (type.IsPrimitive)
		{
			*esp = type.DefaultObject;
		}
		else if (type.IsEnum)
		{
			if (type is ILType iLType)
			{
				Initialized(esp, iLType.FieldTypes[0]);
			}
			else
			{
				Initialized(esp, ((CLRType)type).OrderedFieldTypes[0]);
			}
		}
		else
		{
			*esp = Null;
		}
	}
}
