using System;
using System.Runtime.InteropServices;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Other;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Stack;

internal class RuntimeStack : IDisposable
{
	private ILIntepreter intepreter;

	private unsafe StackObject* pointer;

	private unsafe StackObject* endOfMemory;

	private unsafe StackObject* valueTypePtr;

	private StackObjectAllocator allocator;

	private IntPtr nativePointer;

	private UncheckedList<object> managedStack = new UncheckedList<object>(32);

	private UncheckedStack<StackFrame> frames = new UncheckedStack<StackFrame>();

	public const int MAXIMAL_STACK_OBJECTS = 16384;

	public UncheckedStack<StackFrame> Frames => frames;

	public unsafe StackObject* StackBase => pointer;

	public unsafe StackObject* ValueTypeStackPointer
	{
		get
		{
			return valueTypePtr;
		}
		internal set
		{
			if (value > ValueTypeStackBase)
			{
				throw new StackOverflowException();
			}
			valueTypePtr = value;
		}
	}

	public unsafe StackObject* ValueTypeStackBase => endOfMemory - 1;

	public UncheckedList<object> ManagedStack => managedStack;

	public unsafe RuntimeStack(ILIntepreter intepreter)
	{
		this.intepreter = intepreter;
		nativePointer = Marshal.AllocHGlobal(sizeof(StackObject) * 16384);
		pointer = (StackObject*)nativePointer.ToPointer();
		endOfMemory = Add(pointer, 16384);
		valueTypePtr = endOfMemory - 1;
	}

	~RuntimeStack()
	{
		Dispose();
	}

	public unsafe void ResetValueTypePointer()
	{
		valueTypePtr = endOfMemory - 1;
	}

	public unsafe void InitializeFrame(ILMethod method, StackObject* esp, out StackFrame res)
	{
		res = default(StackFrame);
		res.LocalVarPointer = esp;
		res.Method = method;
		res.BasePointer = ((method.LocalVariableCount > 0) ? Add(esp, method.LocalVariableCount) : esp);
		res.ManagedStackBase = managedStack.Count;
		res.ValueTypeBasePointer = valueTypePtr;
	}

	public void PushFrame(ref StackFrame frame)
	{
		frames.Push(ref frame);
	}

	public unsafe StackObject* PopFrame(ref StackFrame frame, StackObject* esp)
	{
		frames.Pop();
		StackObject* ptr = esp - 1;
		ILMethod method = frame.Method;
		StackObject* ptr2 = ILIntepreter.Minus(frame.LocalVarPointer, method.ParameterCount);
		int mStackBase = frame.ManagedStackBase;
		if (method.HasThis)
		{
			ptr2--;
		}
		if (allocator != null)
		{
			allocator.FreeBefore(frame.ValueTypeBasePointer);
		}
		for (StackObject* ptr3 = ptr2; ptr3 < frame.LocalVarPointer; ptr3++)
		{
			if (ptr3->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				StackObject* ptr4 = ILIntepreter.ResolveReference(ptr3);
				int start = int.MaxValue;
				int end = int.MaxValue;
				StackObject* ptr5 = ptr4;
				CountValueTypeManaged(ptr3, ref start, ref end, &ptr5);
				if (ptr4 > frame.ValueTypeBasePointer)
				{
					frame.ValueTypeBasePointer = ptr4;
				}
				if (start < mStackBase)
				{
					mStackBase = start;
				}
			}
		}
		if (method.ReturnType != intepreter.AppDomain.VoidType)
		{
			*ptr2 = *ptr;
			if (ptr2->ObjectType == ObjectTypes.Object)
			{
				ptr2->Value = mStackBase;
				managedStack[mStackBase] = managedStack[ptr->Value];
				mStackBase++;
			}
			else if (ptr2->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				StackObject* valueTypeBasePointer = frame.ValueTypeBasePointer;
				RelocateValueType(ptr2, ref frame.ValueTypeBasePointer, ref mStackBase);
				*(long*)(&ptr2->Value) = (long)valueTypeBasePointer;
			}
			ptr2++;
		}
		managedStack.RemoveRange(mStackBase, managedStack.Count - mStackBase);
		valueTypePtr = frame.ValueTypeBasePointer;
		return ptr2;
	}

	public unsafe void RelocateValueTypeAndFreeAfterDst(StackObject* src, StackObject* dst)
	{
		StackObject* esp = dst;
		dst = ILIntepreter.ResolveReference(dst);
		int start = int.MaxValue;
		int end = int.MaxValue;
		CountValueTypeManaged(esp, ref start, ref end, &esp);
		RelocateValueType(src, ref dst, ref start);
		ValueTypeStackPointer = dst;
		if (start <= end)
		{
			RemoveManagedStackRange(start, end);
		}
	}

	private unsafe void RelocateValueType(StackObject* src, ref StackObject* dst, ref int mStackBase)
	{
		StackObject* ptr = ILIntepreter.ResolveReference(src);
		if (ptr > dst)
		{
			throw new StackOverflowException();
		}
		intepreter.AppDomain.GetTypeByIndex(ptr->Value).GetValueTypeSize(out var fieldCout, out var _);
		StackObject* ptr2 = ptr;
		StackObject* ptr3 = ptr - fieldCout;
		StackObject* ptr4 = dst;
		StackObject* ptr5 = dst - fieldCout;
		for (int i = 0; i < fieldCout; i++)
		{
			StackObject* ptr6 = ptr2 - i;
			StackObject* ptr7 = ptr4 - i;
			*ptr7 = *ptr6;
			switch (ptr6->ObjectType)
			{
			case ObjectTypes.Object:
			case ObjectTypes.FieldReference:
			case ObjectTypes.ArrayReference:
				if (ptr7->Value >= mStackBase)
				{
					int value = ptr6->Value;
					ptr7->Value = mStackBase;
					managedStack[mStackBase] = managedStack[value];
					mStackBase++;
				}
				break;
			case ObjectTypes.ValueTypeObjectReference:
			{
				StackObject* ptr8 = *(StackObject**)(&ptr7->Value);
				if (ptr8 <= ptr2 && ptr8 > ptr3)
				{
					long num = ptr2 - ptr8;
					StackObject* ptr9 = ptr4 - num;
					*(StackObject**)(&ptr7->Value) = ptr9;
					break;
				}
				throw new StackOverflowException();
			}
			}
		}
		dst = ptr5;
	}

	private int CountValueTypeManaged(IType type)
	{
		int num = 0;
		if (type is ILType)
		{
			ILType iLType = (ILType)type;
			for (int i = 0; i < iLType.FieldTypes.Length; i++)
			{
				IType type2 = iLType.FieldTypes[i];
				if (type2.IsPrimitive || type2.IsEnum)
				{
					continue;
				}
				if (type2.IsValueType)
				{
					if (!(type2 is ILType) && ((CLRType)type2).ValueTypeBinder == null)
					{
						num++;
					}
				}
				else
				{
					num++;
				}
			}
			if (type.BaseType != null && type.BaseType is ILType)
			{
				num += CountValueTypeManaged((ILType)type.BaseType);
			}
		}
		else
		{
			CLRType cLRType = (CLRType)type;
			int totalFieldCount = cLRType.TotalFieldCount;
			for (int j = 0; j < totalFieldCount; j++)
			{
				CLRType cLRType2 = cLRType.OrderedFieldTypes[j] as CLRType;
				if (cLRType2.IsPrimitive || !cLRType2.IsEnum)
				{
					continue;
				}
				if (cLRType2.IsValueType)
				{
					if (cLRType2.ValueTypeBinder == null)
					{
						num++;
					}
				}
				else
				{
					num++;
				}
			}
		}
		return num;
	}

	private unsafe void AllocBlock(int size, out StackObject* dst, out int managedIdx)
	{
		dst = valueTypePtr;
		valueTypePtr = ILIntepreter.Minus(valueTypePtr, size);
		if (valueTypePtr <= StackBase)
		{
			throw new StackOverflowException();
		}
		managedIdx = managedStack.Count;
	}

	public void ClearAllocator()
	{
		if (allocator != null)
		{
			allocator.Clear();
		}
	}

	public unsafe void AllocValueTypeAndCopy(StackObject* ptr, StackObject* src)
	{
		StackObject* ptr2 = ILIntepreter.ResolveReference(src);
		IType typeByIndex = intepreter.AppDomain.GetTypeByIndex(ptr2->Value);
		typeByIndex.GetValueTypeSize(out var fieldCout, out var managedCount);
		if (allocator == null)
		{
			allocator = new StackObjectAllocator(AllocBlock);
		}
		if (allocator.AllocExisting(ptr, fieldCout, managedCount, out var alloc))
		{
			if (ptr2 != alloc.Address)
			{
				ptr2 = alloc.Address;
				ptr->ObjectType = ObjectTypes.ValueTypeObjectReference;
				*(long*)(&ptr->Value) = (long)ptr2;
				int managedIdx = alloc.ManagedIndex;
				InitializeValueTypeObject(typeByIndex, ptr2, register: true, ref managedIdx, noInitialize: false);
				intepreter.CopyStackValueType(src, ptr, managedStack);
				FreeValueTypeObject(src);
			}
			else
			{
				ptr->ObjectType = ObjectTypes.ValueTypeObjectReference;
				*(long*)(&ptr->Value) = (long)ptr2;
			}
		}
		else
		{
			int start = int.MaxValue;
			int end = int.MinValue;
			StackObject* ptr3 = default(StackObject*);
			CountValueTypeManaged(src, ref start, ref end, &ptr3);
			if (ptr3 == valueTypePtr)
			{
				valueTypePtr = ptr2;
			}
			allocator.RegisterAllocation(ptr, ptr2, fieldCout, start, managedCount);
			ptr->ObjectType = ObjectTypes.ValueTypeObjectReference;
			*(long*)(&ptr->Value) = (long)ptr2;
		}
	}

	public unsafe void AllocValueType(StackObject* ptr, IType type, bool register = false, bool noInitialize = false)
	{
		type.GetValueTypeSize(out var fieldCout, out var managedCount);
		int num = -1;
		StackObject* address;
		if (register)
		{
			if (allocator == null)
			{
				allocator = new StackObjectAllocator(AllocBlock);
			}
			StackObjectAllocation stackObjectAllocation = allocator.Alloc(ptr, fieldCout, managedCount);
			address = stackObjectAllocation.Address;
			num = stackObjectAllocation.ManagedIndex;
		}
		else
		{
			address = valueTypePtr;
			num = managedStack.Count;
			valueTypePtr = ILIntepreter.Minus(valueTypePtr, fieldCout);
			if (valueTypePtr <= StackBase)
			{
				throw new StackOverflowException();
			}
		}
		ptr->ObjectType = ObjectTypes.ValueTypeObjectReference;
		*(long*)(&ptr->Value) = (long)address;
		InitializeValueTypeObject(type, address, register, ref num, noInitialize);
	}

	internal unsafe void InitializeValueTypeObject(IType type, StackObject* ptr, bool register, ref int managedIdx, bool noInitialize)
	{
		int totalFieldCount = type.TotalFieldCount;
		ptr->ObjectType = ObjectTypes.ValueTypeDescriptor;
		ptr->Value = type.TypeIndex;
		ptr->ValueLow = totalFieldCount;
		StackObject* ptr2 = ptr - (totalFieldCount + 1);
		if (noInitialize)
		{
			return;
		}
		if (type is ILType)
		{
			ILType iLType = (ILType)type;
			for (int i = 0; i < iLType.FieldTypes.Length; i++)
			{
				IType type2 = iLType.FieldTypes[i];
				StackObject* ptr3 = ILIntepreter.Minus(ptr, iLType.FieldStartIndex + i + 1);
				if (type2.IsPrimitive)
				{
					*ptr3 = type2.DefaultObject;
				}
				else if (type2.IsEnum)
				{
					StackObject.Initialized(ptr3, type2);
				}
				else if (type2.IsValueType)
				{
					if (type2 is ILType || ((CLRType)type2).ValueTypeBinder != null)
					{
						ptr3->ObjectType = ObjectTypes.ValueTypeObjectReference;
						*(long*)(&ptr3->Value) = (long)ptr2;
						InitializeValueTypeObject(type2, ptr2, register, ref managedIdx, noInitialize);
						type2.GetValueTypeSize(out var fieldCout, out var _);
						ptr2 -= fieldCout;
						continue;
					}
					ptr3->ObjectType = ObjectTypes.Object;
					ptr3->Value = managedIdx;
					if (managedIdx < managedStack.Count)
					{
						managedStack[managedIdx] = ((CLRType)type2).CreateDefaultInstance();
					}
					else
					{
						managedStack.Add(((CLRType)type2).CreateDefaultInstance());
					}
					managedIdx++;
				}
				else
				{
					ptr3->ObjectType = ObjectTypes.Object;
					ptr3->Value = managedIdx;
					if (managedIdx < managedStack.Count)
					{
						managedStack[managedIdx] = null;
					}
					else
					{
						managedStack.Add(null);
					}
					managedIdx++;
				}
			}
			if (type.BaseType != null && type.BaseType is ILType)
			{
				InitializeValueTypeObject((ILType)type.BaseType, ptr, register, ref managedIdx, noInitialize);
			}
			return;
		}
		CLRType obj = (CLRType)type;
		int num = totalFieldCount;
		IType[] orderedFieldTypes = obj.OrderedFieldTypes;
		for (int j = 0; j < num; j++)
		{
			CLRType cLRType = orderedFieldTypes[j] as CLRType;
			StackObject* ptr4 = ILIntepreter.Minus(ptr, j + 1);
			if (cLRType.IsPrimitive)
			{
				*ptr4 = cLRType.DefaultObject;
			}
			else if (cLRType.IsEnum)
			{
				StackObject.Initialized(ptr4, cLRType);
			}
			else if (cLRType.IsValueType)
			{
				if (cLRType.ValueTypeBinder != null)
				{
					ptr4->ObjectType = ObjectTypes.ValueTypeObjectReference;
					*(long*)(&ptr4->Value) = (long)ptr2;
					InitializeValueTypeObject(cLRType, ptr2, register, ref managedIdx, noInitialize);
					cLRType.GetValueTypeSize(out var fieldCout2, out var _);
					ptr2 -= fieldCout2;
					continue;
				}
				ptr4->ObjectType = ObjectTypes.Object;
				ptr4->Value = managedIdx;
				if (managedIdx < managedStack.Count)
				{
					managedStack[managedIdx] = cLRType.CreateDefaultInstance();
				}
				else
				{
					managedStack.Add(cLRType.CreateDefaultInstance());
				}
				managedIdx++;
			}
			else
			{
				ptr4->ObjectType = ObjectTypes.Object;
				ptr4->Value = managedIdx;
				if (managedIdx < managedStack.Count)
				{
					managedStack[managedIdx] = null;
				}
				else
				{
					managedStack.Add(null);
				}
				managedIdx++;
			}
		}
	}

	public unsafe void ClearValueTypeObject(IType type, StackObject* ptr)
	{
		if (type is ILType)
		{
			ILType iLType = (ILType)type;
			for (int i = 0; i < iLType.FieldTypes.Length; i++)
			{
				IType type2 = iLType.FieldTypes[i];
				StackObject* ptr2 = ILIntepreter.Minus(ptr, iLType.FieldStartIndex + i + 1);
				if (type2.IsPrimitive || type2.IsEnum)
				{
					StackObject.Initialized(ptr2, type2);
				}
				else if (ptr2->ObjectType == ObjectTypes.ValueTypeObjectReference)
				{
					ClearValueTypeObject(type2, ILIntepreter.ResolveReference(ptr2));
				}
				else if (type2.IsValueType)
				{
					if (type2 is ILType)
					{
						throw new NotImplementedException();
					}
					managedStack[ptr2->Value] = ((CLRType)type2).CreateDefaultInstance();
				}
				else
				{
					managedStack[ptr2->Value] = null;
				}
			}
			if (type.BaseType != null && type.BaseType is ILType)
			{
				ClearValueTypeObject((ILType)type.BaseType, ptr);
			}
			return;
		}
		CLRType cLRType = (CLRType)type;
		int totalFieldCount = cLRType.TotalFieldCount;
		for (int j = 0; j < totalFieldCount; j++)
		{
			CLRType cLRType2 = cLRType.OrderedFieldTypes[j] as CLRType;
			StackObject* ptr3 = ILIntepreter.Minus(ptr, j + 1);
			if (cLRType2.IsPrimitive)
			{
				StackObject.Initialized(ptr3, cLRType2);
			}
			else if (ptr3->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				StackObject* ptr4 = ILIntepreter.ResolveReference(ptr3);
				ClearValueTypeObject(cLRType2, ptr4);
			}
			else if (cLRType2.IsValueType)
			{
				managedStack[ptr3->Value] = cLRType2.CreateDefaultInstance();
			}
			else
			{
				managedStack[ptr3->Value] = null;
			}
		}
	}

	internal void RemoveManagedStackRange(int start, int end)
	{
		if (start != int.MaxValue)
		{
			managedStack.RemoveRange(start, managedStack.Count - start);
		}
	}

	public unsafe void FreeRegisterValueType(StackObject* esp)
	{
		if (esp->ObjectType == ObjectTypes.ValueTypeObjectReference)
		{
			allocator.Free(esp);
		}
	}

	public unsafe void FreeValueTypeObject(StackObject* esp)
	{
		if (esp->ObjectType == ObjectTypes.ValueTypeObjectReference)
		{
			int start = int.MaxValue;
			int end = int.MinValue;
			StackObject* ptr = default(StackObject*);
			CountValueTypeManaged(esp, ref start, ref end, &ptr);
			if (ptr != valueTypePtr)
			{
				throw new NotSupportedException();
			}
			valueTypePtr = ILIntepreter.ResolveReference(esp);
			RemoveManagedStackRange(start, end);
		}
	}

	public unsafe void CountValueTypeManaged(StackObject* esp, ref int start, ref int end, StackObject** endAddr)
	{
		StackObject* ptr = ILIntepreter.ResolveReference(esp);
		intepreter.AppDomain.GetTypeByIndex(ptr->Value).GetValueTypeSize(out var fieldCout, out var managedCount);
		*endAddr = ptr - fieldCout;
		if (managedCount > 0)
		{
			end = managedStack.Count - 1;
			start = managedStack.Count - managedCount;
		}
	}

	public void Dispose()
	{
		if (nativePointer != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(nativePointer);
			nativePointer = IntPtr.Zero;
		}
	}

	private unsafe StackObject* Add(StackObject* a, int b)
	{
		return (StackObject*)((ulong)a + (ulong)(sizeof(StackObject) * b));
	}
}
