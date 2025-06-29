using System;
using System.Collections.Generic;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Other;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Enviorment;

public abstract class ValueTypeBinder
{
	protected CLRType clrType;

	protected AppDomain domain;

	public CLRType CLRType
	{
		get
		{
			return clrType;
		}
		set
		{
			if (clrType == null)
			{
				clrType = value;
				domain = value.AppDomain;
				return;
			}
			throw new NotSupportedException();
		}
	}

	public unsafe abstract void CopyValueTypeToStack(object ins, StackObject* ptr, IList<object> mStack);

	public unsafe abstract object ToObject(StackObject* esp, IList<object> managedStack);

	public virtual void RegisterCLRRedirection(AppDomain appdomain)
	{
	}

	protected unsafe void CopyValueTypeToStack<K>(ref K ins, StackObject* esp, IList<object> mStack) where K : struct
	{
		switch (esp->ObjectType)
		{
		case ObjectTypes.ValueTypeObjectReference:
		{
			StackObject* ptr = ILIntepreter.ResolveReference(esp);
			if (((CLRType)domain.GetTypeByIndex(ptr->Value)).ValueTypeBinder is ValueTypeBinder<K> valueTypeBinder)
			{
				valueTypeBinder.CopyValueTypeToStack(ref ins, ptr, mStack);
				break;
			}
			throw new NotSupportedException();
		}
		case ObjectTypes.Object:
			mStack[esp->Value] = ins;
			break;
		default:
			throw new NotImplementedException();
		}
	}

	protected unsafe void AssignFromStack<K>(ref K ins, StackObject* esp, IList<object> mStack) where K : struct
	{
		switch (esp->ObjectType)
		{
		case ObjectTypes.Null:
			throw new NullReferenceException();
		case ObjectTypes.Object:
			ins = (K)mStack[esp->Value];
			break;
		case ObjectTypes.ValueTypeObjectReference:
		{
			StackObject* ptr = ILIntepreter.ResolveReference(esp);
			if (((CLRType)domain.GetTypeByIndex(ptr->Value)).ValueTypeBinder is ValueTypeBinder<K> valueTypeBinder)
			{
				valueTypeBinder.AssignFromStack(ref ins, ptr, mStack);
				break;
			}
			throw new NotSupportedException();
		}
		default:
			throw new NotImplementedException();
		}
	}
}
public abstract class ValueTypeBinder<T> : ValueTypeBinder
{
	public unsafe override void CopyValueTypeToStack(object ins, StackObject* ptr, IList<object> mStack)
	{
		T ins2 = (T)ins;
		CopyValueTypeToStack(ref ins2, ptr, mStack);
	}

	public unsafe abstract void CopyValueTypeToStack(ref T ins, StackObject* ptr, IList<object> mStack);

	public unsafe override object ToObject(StackObject* esp, IList<object> managedStack)
	{
		T ins = default(T);
		AssignFromStack(ref ins, esp, managedStack);
		return ins;
	}

	public unsafe abstract void AssignFromStack(ref T ins, StackObject* ptr, IList<object> mStack);

	public unsafe void ParseValue(ref T value, ILIntepreter intp, StackObject* ptr_of_this_method, IList<object> mStack, bool shouldFree = true)
	{
		StackObject* objectAndResolveReference = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
		if (objectAndResolveReference->ObjectType == ObjectTypes.ValueTypeObjectReference)
		{
			StackObject* ptr = ILIntepreter.ResolveReference(objectAndResolveReference);
			AssignFromStack(ref value, ptr, mStack);
			if (shouldFree)
			{
				intp.FreeStackValueType(ptr_of_this_method);
			}
		}
		else
		{
			value = (T)StackObject.ToObject(objectAndResolveReference, intp.AppDomain, (UncheckedList<object>)mStack);
			if (shouldFree)
			{
				intp.Free(ptr_of_this_method);
			}
		}
	}

	public unsafe void WriteBackValue(AppDomain domain, StackObject* ptr_of_this_method, IList<object> mStack, ref T instance_of_this_method)
	{
		ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
		switch (ptr_of_this_method->ObjectType)
		{
		case ObjectTypes.Object:
			mStack[ptr_of_this_method->Value] = instance_of_this_method;
			break;
		case ObjectTypes.FieldReference:
		{
			object target = mStack[ptr_of_this_method->Value];
			if (target is ILTypeInstance)
			{
				((ILTypeInstance)target)[ptr_of_this_method->ValueLow] = instance_of_this_method;
			}
			else
			{
				(domain.GetType(target.GetType()) as CLRType).SetFieldValue(ptr_of_this_method->ValueLow, ref target, instance_of_this_method);
			}
			break;
		}
		case ObjectTypes.StaticFieldReference:
		{
			IType type = domain.GetType(ptr_of_this_method->Value);
			if (type is ILType)
			{
				((ILType)type).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
			}
			else
			{
				((CLRType)type).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
			}
			break;
		}
		case ObjectTypes.ArrayReference:
			(mStack[ptr_of_this_method->Value] as T[])[ptr_of_this_method->ValueLow] = instance_of_this_method;
			break;
		case ObjectTypes.ValueTypeObjectReference:
		{
			StackObject* ptr = ILIntepreter.ResolveReference(ptr_of_this_method);
			CopyValueTypeToStack(ref instance_of_this_method, ptr, mStack);
			break;
		}
		case ObjectTypes.ValueTypeDescriptor:
			break;
		}
	}

	public unsafe void PushValue(ref T value, ILIntepreter intp, StackObject* ptr_of_this_method, IList<object> mStack)
	{
		intp.AllocValueType(ptr_of_this_method, clrType);
		StackObject* ptr = ILIntepreter.ResolveReference(ptr_of_this_method);
		CopyValueTypeToStack(ref value, ptr, mStack);
	}
}
