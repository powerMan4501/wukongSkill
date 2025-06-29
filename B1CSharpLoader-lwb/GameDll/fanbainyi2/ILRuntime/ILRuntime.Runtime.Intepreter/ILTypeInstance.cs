using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Other;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Intepreter;

public class ILTypeInstance
{
	protected ILType type;

	protected StackObject[] fields;

	protected UncheckedList<object> managedObjs;

	private object clrInstance;

	private ulong valueTypeMask;

	private Dictionary<ILMethod, IDelegateAdapter> delegates;

	private const int SizeOfILTypeInstance = 21;

	public ILType Type => type;

	public StackObject[] Fields => fields;

	public virtual bool IsValueType
	{
		get
		{
			if (type.IsValueType)
			{
				return !Boxed;
			}
			return false;
		}
	}

	public bool Boxed { get; set; }

	public UncheckedList<object> ManagedObjects => managedObjs;

	public object CLRInstance
	{
		get
		{
			return clrInstance;
		}
		set
		{
			clrInstance = value;
		}
	}

	public unsafe object this[int index]
	{
		get
		{
			if (index < fields.Length && index >= 0)
			{
				fixed (StackObject* ptr = fields)
				{
					return StackObject.ToObject(ptr + index, null, managedObjs);
				}
			}
			if (Type.FirstCLRBaseType != null && Type.FirstCLRBaseType is CrossBindingAdaptor)
			{
				return (type.AppDomain.GetType(((CrossBindingAdaptor)Type.FirstCLRBaseType).BaseCLRType) as CLRType).GetFieldValue(index, clrInstance);
			}
			throw new TypeLoadException();
		}
		set
		{
			value = ILIntepreter.CheckAndCloneValueType(value, this.type.AppDomain);
			if (index < fields.Length && index >= 0)
			{
				fixed (StackObject* ptr = fields)
				{
					StackObject* ptr2 = ptr + index;
					if (value != null)
					{
						Type type = value.GetType();
						if (type.IsPrimitive)
						{
							ILIntepreter.UnboxObject(ptr2, value, managedObjs, this.type.AppDomain);
						}
						else if (type.IsEnum)
						{
							ptr2->ObjectType = ObjectTypes.Integer;
							ptr2->Value = value.ToInt32();
							ptr2->ValueLow = 0;
						}
						else
						{
							ptr2->ObjectType = ObjectTypes.Object;
							ptr2->Value = index;
							managedObjs[index] = value;
						}
					}
					else
					{
						*ptr2 = StackObject.Null;
					}
				}
			}
			else
			{
				if (Type.FirstCLRBaseType == null || !(Type.FirstCLRBaseType is CrossBindingAdaptor))
				{
					throw new TypeLoadException();
				}
				(this.type.AppDomain.GetType(((CrossBindingAdaptor)Type.FirstCLRBaseType).BaseCLRType) as CLRType).SetFieldValue(index, ref clrInstance, value);
			}
		}
	}

	protected ILTypeInstance()
	{
	}

	public ILTypeInstance(ILType type, bool initializeCLRInstance = true)
	{
		this.type = type;
		fields = new StackObject[type.TotalFieldCount];
		int num = fields.Length;
		managedObjs = new UncheckedList<object>(num);
		for (int i = 0; i < num; i++)
		{
			managedObjs.Add(null);
		}
		InitializeFields(type);
		if (initializeCLRInstance)
		{
			if (type.FirstCLRBaseType is CrossBindingAdaptor)
			{
				clrInstance = ((CrossBindingAdaptor)type.FirstCLRBaseType).CreateCLRInstance(type.AppDomain, this);
			}
			else
			{
				clrInstance = this;
			}
			if (type.FirstCLRInterface is CrossBindingAdaptor)
			{
				if (clrInstance != this)
				{
					throw new NotSupportedException("Inheriting and implementing interface at the same time is not supported yet");
				}
				clrInstance = ((CrossBindingAdaptor)type.FirstCLRInterface).CreateCLRInstance(type.AppDomain, this);
			}
		}
		else
		{
			clrInstance = this;
		}
	}

	public unsafe void AssignFieldNoClone(int index, object value)
	{
		if (index < fields.Length && index >= 0)
		{
			fixed (StackObject* ptr = fields)
			{
				StackObject* ptr2 = ptr + index;
				if (value != null)
				{
					Type type = value.GetType();
					if (type.IsPrimitive)
					{
						ILIntepreter.UnboxObject(ptr2, value, managedObjs, this.type.AppDomain);
					}
					else if (type.IsEnum)
					{
						ptr2->ObjectType = ObjectTypes.Integer;
						ptr2->Value = value.ToInt32();
						ptr2->ValueLow = 0;
					}
					else
					{
						ptr2->ObjectType = ObjectTypes.Object;
						ptr2->Value = index;
						managedObjs[index] = value;
					}
				}
				else
				{
					*ptr2 = StackObject.Null;
				}
			}
		}
		else
		{
			if (Type.FirstCLRBaseType == null || !(Type.FirstCLRBaseType is CrossBindingAdaptor))
			{
				throw new TypeLoadException();
			}
			(this.type.AppDomain.GetType(((CrossBindingAdaptor)Type.FirstCLRBaseType).BaseCLRType) as CLRType).SetFieldValue(index, ref clrInstance, value);
		}
	}

	public unsafe int GetSizeInMemory(HashSet<object> traversedObj)
	{
		if (traversedObj.Contains(this))
		{
			return 0;
		}
		traversedObj.Add(this);
		if (type == null)
		{
			return 21;
		}
		int num = 21 + sizeof(StackObject) * fields.Length;
		if (managedObjs != null)
		{
			num += managedObjs.Count * 4;
			foreach (object managedObj in managedObjs)
			{
				num += GetSizeInMemory(managedObj, traversedObj);
			}
		}
		return num;
	}

	private static int GetSizeInMemory(object obj, HashSet<object> traversedObj)
	{
		if (obj == null)
		{
			return 0;
		}
		if (obj is ILTypeInstance)
		{
			return ((ILTypeInstance)obj).GetSizeInMemory(traversedObj);
		}
		if (traversedObj.Contains(obj))
		{
			return 0;
		}
		traversedObj.Add(obj);
		if (obj is string)
		{
			return Encoding.Unicode.GetByteCount((string)obj);
		}
		Type type = obj.GetType();
		if (type.IsArray)
		{
			Array obj2 = (Array)obj;
			Type elementType = type.GetElementType();
			int num = 0;
			num = ((!elementType.IsPrimitive) ? 4 : Marshal.SizeOf(elementType));
			return obj2.Length * num;
		}
		if (type.IsPrimitive)
		{
			return Marshal.SizeOf(type);
		}
		int num2 = 0;
		if (obj is ICollection collection)
		{
			IEnumerator enumerator = collection.GetEnumerator();
			while (enumerator.MoveNext())
			{
				num2 += GetSizeInMemory(enumerator.Current, traversedObj);
			}
		}
		else if (obj is IDictionary dictionary)
		{
			IDictionaryEnumerator enumerator2 = dictionary.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				num2 += GetSizeInMemory(enumerator2.Key, traversedObj);
				num2 += GetSizeInMemory(enumerator2.Value, traversedObj);
			}
		}
		return num2;
	}

	private void InitializeFields(ILType type)
	{
		for (int i = 0; i < type.FieldTypes.Length; i++)
		{
			int num = type.FieldStartIndex + i;
			IType type2 = type.FieldTypes[i];
			if (type2.IsValueType && num < 64)
			{
				valueTypeMask |= (ulong)(1L << num);
			}
			StackObject.Initialized(ref fields[num], num, type2, managedObjs);
		}
		if (type.BaseType != null && type.BaseType is ILType)
		{
			InitializeFields((ILType)type.BaseType);
		}
	}

	internal unsafe void PushFieldAddress(int fieldIdx, StackObject* esp, UncheckedList<object> managedStack)
	{
		esp->ObjectType = ObjectTypes.FieldReference;
		esp->Value = managedStack.Count;
		managedStack.Add(this);
		esp->ValueLow = fieldIdx;
	}

	internal unsafe void PushToStack(int fieldIdx, StackObject* esp, ILIntepreter intp, UncheckedList<object> managedStack)
	{
		if (fieldIdx < fields.Length && fieldIdx >= 0)
		{
			PushToStackSub(ref fields[fieldIdx], fieldIdx, esp, managedStack, intp);
			return;
		}
		if (Type.FirstCLRBaseType != null && Type.FirstCLRBaseType is CrossBindingAdaptor)
		{
			object obj = (intp.AppDomain.GetType(((CrossBindingAdaptor)Type.FirstCLRBaseType).BaseCLRType) as CLRType).GetFieldValue(fieldIdx, clrInstance);
			if (obj is CrossBindingAdaptorType)
			{
				obj = ((CrossBindingAdaptorType)obj).ILInstance;
			}
			ILIntepreter.PushObject(esp, managedStack, obj);
			return;
		}
		throw new TypeLoadException();
	}

	internal unsafe void CopyToRegister(int fieldIdx, ref RegisterFrameInfo info, short reg)
	{
		if (fieldIdx < fields.Length && fieldIdx >= 0)
		{
			fixed (StackObject* ptr = fields)
			{
				info.Intepreter.CopyToRegister(ref info, reg, ptr + fieldIdx, managedObjs);
			}
			return;
		}
		if (Type.FirstCLRBaseType != null && Type.FirstCLRBaseType is CrossBindingAdaptor)
		{
			object obj = (info.Intepreter.AppDomain.GetType(((CrossBindingAdaptor)Type.FirstCLRBaseType).BaseCLRType) as CLRType).GetFieldValue(fieldIdx, clrInstance);
			if (obj is CrossBindingAdaptorType)
			{
				obj = ((CrossBindingAdaptorType)obj).ILInstance;
			}
			ILIntepreter.AssignToRegister(ref info, reg, obj);
			return;
		}
		throw new TypeLoadException();
	}

	private bool NeedCheckFieldValueType(int fieldIdx)
	{
		if (fieldIdx < 64)
		{
			return (valueTypeMask & (ulong)(1L << fieldIdx)) != 0;
		}
		return true;
	}

	private unsafe void PushToStackSub(ref StackObject field, int fieldIdx, StackObject* esp, UncheckedList<object> managedStack, ILIntepreter intp)
	{
		if (field.ObjectType >= ObjectTypes.Object)
		{
			object obj = managedObjs[fieldIdx];
			if (obj != null && NeedCheckFieldValueType(fieldIdx))
			{
				if (obj is ILTypeInstance)
				{
					ILTypeInstance iLTypeInstance = (ILTypeInstance)obj;
					if (iLTypeInstance.type != null && iLTypeInstance.type.IsValueType)
					{
						intp.AllocValueType(esp, iLTypeInstance.type);
						StackObject* ptr = ILIntepreter.ResolveReference(esp);
						iLTypeInstance.CopyValueTypeToStack(ptr, managedStack);
						return;
					}
				}
				else
				{
					Type type = obj.GetType();
					if (type.IsValueType && this.type.AppDomain.ValueTypeBinders.TryGetValue(type, out var value))
					{
						intp.AllocValueType(esp, value.CLRType);
						StackObject* ptr2 = ILIntepreter.ResolveReference(esp);
						value.CopyValueTypeToStack(obj, ptr2, managedStack);
						return;
					}
				}
			}
			*esp = field;
			esp->Value = managedStack.Count;
			managedStack.Add(managedObjs[fieldIdx]);
		}
		else
		{
			*esp = field;
		}
	}

	internal unsafe void CopyValueTypeToStack(StackObject* ptr, UncheckedList<object> mStack)
	{
		ptr->ObjectType = ObjectTypes.ValueTypeDescriptor;
		ptr->Value = type.TypeIndex;
		ptr->ValueLow = type.TotalFieldCount;
		for (int i = 0; i < fields.Length; i++)
		{
			StackObject* ptr2 = ILIntepreter.Minus(ptr, i + 1);
			switch (ptr2->ObjectType)
			{
			case ObjectTypes.Object:
			case ObjectTypes.FieldReference:
			case ObjectTypes.ArrayReference:
				mStack[ptr2->Value] = ILIntepreter.CheckAndCloneValueType(managedObjs[i], type.AppDomain);
				ptr2->ValueLow = fields[i].ValueLow;
				break;
			case ObjectTypes.ValueTypeObjectReference:
			{
				object obj = managedObjs[i];
				StackObject* ptr3 = ILIntepreter.ResolveReference(ptr2);
				IType typeByIndex = type.AppDomain.GetTypeByIndex(ptr3->Value);
				if (typeByIndex is ILType)
				{
					((ILTypeInstance)obj).CopyValueTypeToStack(ptr3, mStack);
				}
				else
				{
					((CLRType)typeByIndex).ValueTypeBinder.CopyValueTypeToStack(obj, ptr3, mStack);
				}
				break;
			}
			default:
				*ptr2 = fields[i];
				break;
			}
		}
	}

	internal void Clear()
	{
		InitializeFields(type);
	}

	internal void InitializeField(int fieldIdx)
	{
		_ = type.FieldStartIndex;
		for (ILType iLType = type; iLType != null; iLType = iLType.BaseType as ILType)
		{
			int num = iLType.FieldStartIndex + iLType.FieldTypes.Length;
			if (fieldIdx < num && fieldIdx >= iLType.FieldStartIndex)
			{
				IType fieldType = iLType.FieldTypes[fieldIdx - iLType.FieldStartIndex];
				StackObject.Initialized(ref fields[fieldIdx], fieldIdx, fieldType, managedObjs);
				return;
			}
		}
		throw new NotImplementedException();
	}

	internal unsafe void AssignFromStack(int fieldIdx, StackObject* esp, ILRuntime.Runtime.Enviorment.AppDomain appdomain, UncheckedList<object> managedStack)
	{
		if (fieldIdx < fields.Length && fieldIdx >= 0)
		{
			AssignFromStackSub(ref fields[fieldIdx], fieldIdx, esp, managedStack);
			return;
		}
		if (Type.FirstCLRBaseType != null && Type.FirstCLRBaseType is CrossBindingAdaptor)
		{
			CLRType obj = appdomain.GetType(((CrossBindingAdaptor)Type.FirstCLRBaseType).BaseCLRType) as CLRType;
			obj.SetFieldValue(value: obj.GetField(fieldIdx).FieldType.CheckCLRTypes(ILIntepreter.CheckAndCloneValueType(StackObject.ToObject(esp, appdomain, managedStack), appdomain)), hash: fieldIdx, target: ref clrInstance);
			return;
		}
		throw new TypeLoadException();
	}

	internal unsafe void AssignFromStack(StackObject* esp, ILRuntime.Runtime.Enviorment.AppDomain appdomain, UncheckedList<object> managedStack)
	{
		StackObject* ptr = ILIntepreter.ResolveReference(esp);
		int valueLow = ptr->ValueLow;
		for (int i = 0; i < valueLow; i++)
		{
			StackObject* esp2 = ILIntepreter.Minus(ptr, i + 1);
			AssignFromStack(i, esp2, type.AppDomain, managedStack);
		}
	}

	private unsafe void AssignFromStackSub(ref StackObject field, int fieldIdx, StackObject* esp, UncheckedList<object> managedStack)
	{
		esp = ILIntepreter.GetObjectAndResolveReference(esp);
		field = *esp;
		switch (field.ObjectType)
		{
		case ObjectTypes.Object:
		case ObjectTypes.FieldReference:
		case ObjectTypes.ArrayReference:
			field.ObjectType = ObjectTypes.Object;
			field.Value = fieldIdx;
			if (NeedCheckFieldValueType(fieldIdx))
			{
				managedObjs[fieldIdx] = ILIntepreter.CheckAndCloneValueType(managedStack[esp->Value], Type.AppDomain);
			}
			else
			{
				managedObjs[fieldIdx] = managedStack[esp->Value];
			}
			break;
		case ObjectTypes.ValueTypeObjectReference:
		{
			ILRuntime.Runtime.Enviorment.AppDomain appDomain = type.AppDomain;
			field.ObjectType = ObjectTypes.Object;
			field.Value = fieldIdx;
			StackObject* ptr = ILIntepreter.ResolveReference(esp);
			IType typeByIndex = appDomain.GetTypeByIndex(ptr->Value);
			if (typeByIndex is ILType)
			{
				((ILTypeInstance)(managedObjs[fieldIdx] ?? throw new NullReferenceException())).AssignFromStack(esp, appDomain, managedStack);
			}
			else
			{
				managedObjs[fieldIdx] = ((CLRType)typeByIndex).ValueTypeBinder.ToObject(ptr, managedStack);
			}
			break;
		}
		default:
			if (managedObjs != null)
			{
				managedObjs[fieldIdx] = null;
			}
			break;
		}
	}

	public override string ToString()
	{
		IMethod toStringMethod = type.ToStringMethod;
		if (toStringMethod != null)
		{
			if (toStringMethod is ILMethod)
			{
				return type.AppDomain.Invoke(toStringMethod, this, null).ToString();
			}
			return clrInstance.ToString();
		}
		return type.FullName;
	}

	public override bool Equals(object obj)
	{
		if (type != null)
		{
			IMethod equalsMethod = type.EqualsMethod;
			if (equalsMethod != null && equalsMethod is ILMethod)
			{
				using (InvocationContext invocationContext = type.AppDomain.BeginInvoke(equalsMethod))
				{
					invocationContext.PushObject(this);
					invocationContext.PushObject(obj);
					invocationContext.Invoke();
					return invocationContext.ReadBool();
				}
			}
			if (this is ILEnumTypeInstance)
			{
				if (obj is ILEnumTypeInstance)
				{
					ILEnumTypeInstance iLEnumTypeInstance = (ILEnumTypeInstance)this;
					ILEnumTypeInstance iLEnumTypeInstance2 = (ILEnumTypeInstance)obj;
					if (iLEnumTypeInstance.type == iLEnumTypeInstance2.type)
					{
						if (iLEnumTypeInstance.fields[0].ObjectType == ObjectTypes.Integer)
						{
							return iLEnumTypeInstance.fields[0].Value == iLEnumTypeInstance2.fields[0].Value;
						}
						return iLEnumTypeInstance.fields[0] == iLEnumTypeInstance2.fields[0];
					}
					return false;
				}
				return base.Equals(obj);
			}
			return base.Equals(obj);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		if (type != null)
		{
			IMethod getHashCodeMethod = type.GetHashCodeMethod;
			if (getHashCodeMethod != null && getHashCodeMethod is ILMethod)
			{
				using (InvocationContext invocationContext = type.AppDomain.BeginInvoke(getHashCodeMethod))
				{
					invocationContext.PushObject(this);
					invocationContext.Invoke();
					return invocationContext.ReadInteger();
				}
			}
			if (this is ILEnumTypeInstance)
			{
				return ((ILEnumTypeInstance)this).fields[0].Value.GetHashCode();
			}
			return base.GetHashCode();
		}
		return base.GetHashCode();
	}

	public virtual bool CanAssignTo(IType type)
	{
		return this.type.CanAssignTo(type);
	}

	public virtual ILTypeInstance Clone()
	{
		ILTypeInstance iLTypeInstance = new ILTypeInstance(type);
		for (int i = 0; i < fields.Length; i++)
		{
			iLTypeInstance.fields[i] = fields[i];
			iLTypeInstance.managedObjs[i] = ILIntepreter.CheckAndCloneValueType(managedObjs[i], Type.AppDomain);
		}
		return iLTypeInstance;
	}

	internal IDelegateAdapter GetDelegateAdapter(ILMethod method)
	{
		if (delegates == null)
		{
			return null;
		}
		if (delegates.TryGetValue(method, out var value))
		{
			return value;
		}
		return null;
	}

	internal void SetDelegateAdapter(ILMethod method, IDelegateAdapter adapter)
	{
		if (delegates == null)
		{
			delegates = new Dictionary<ILMethod, IDelegateAdapter>();
		}
		if (!delegates.ContainsKey(method))
		{
			delegates[method] = adapter;
			return;
		}
		throw new NotSupportedException();
	}
}
