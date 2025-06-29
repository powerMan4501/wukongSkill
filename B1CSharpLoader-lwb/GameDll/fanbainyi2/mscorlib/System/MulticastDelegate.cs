using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class MulticastDelegate : Delegate
{
	[SecurityCritical]
	private object _invocationList;

	[SecurityCritical]
	private IntPtr _invocationCount;

	protected MulticastDelegate(object target, string method)
		: base(target, method)
	{
	}

	protected MulticastDelegate(Type target, string method)
		: base(target, method)
	{
	}

	[SecuritySafeCritical]
	internal bool IsUnmanagedFunctionPtr()
	{
		return _invocationCount == (IntPtr)(-1);
	}

	[SecuritySafeCritical]
	internal bool InvocationListLogicallyNull()
	{
		if (_invocationList != null && !(_invocationList is LoaderAllocator))
		{
			return _invocationList is DynamicResolver;
		}
		return true;
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int targetIndex = 0;
		if (!(_invocationList is object[] array))
		{
			MethodInfo method = base.Method;
			if (!(method is RuntimeMethodInfo) || IsUnmanagedFunctionPtr())
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidDelegateType"));
			}
			if (!InvocationListLogicallyNull() && !_invocationCount.IsNull() && !_methodPtrAux.IsNull())
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidDelegateType"));
			}
			DelegateSerializationHolder.GetDelegateSerializationInfo(info, GetType(), base.Target, method, targetIndex);
			return;
		}
		DelegateSerializationHolder.DelegateEntry delegateEntry = null;
		int num = (int)_invocationCount;
		int num2 = num;
		while (--num2 >= 0)
		{
			MulticastDelegate multicastDelegate = (MulticastDelegate)array[num2];
			MethodInfo method2 = multicastDelegate.Method;
			if (method2 is RuntimeMethodInfo && !IsUnmanagedFunctionPtr() && (multicastDelegate.InvocationListLogicallyNull() || multicastDelegate._invocationCount.IsNull() || multicastDelegate._methodPtrAux.IsNull()))
			{
				DelegateSerializationHolder.DelegateEntry delegateSerializationInfo = DelegateSerializationHolder.GetDelegateSerializationInfo(info, multicastDelegate.GetType(), multicastDelegate.Target, method2, targetIndex++);
				if (delegateEntry != null)
				{
					delegateEntry.Entry = delegateSerializationInfo;
				}
				delegateEntry = delegateSerializationInfo;
			}
		}
		if (delegateEntry != null)
		{
			return;
		}
		throw new SerializationException(Environment.GetResourceString("Serialization_InvalidDelegateType"));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public sealed override bool Equals(object obj)
	{
		if (obj == null || !Delegate.InternalEqualTypes(this, obj))
		{
			return false;
		}
		if (!(obj is MulticastDelegate multicastDelegate))
		{
			return false;
		}
		if (_invocationCount != (IntPtr)0)
		{
			if (InvocationListLogicallyNull())
			{
				if (IsUnmanagedFunctionPtr())
				{
					if (!multicastDelegate.IsUnmanagedFunctionPtr())
					{
						return false;
					}
					return Delegate.CompareUnmanagedFunctionPtrs(this, multicastDelegate);
				}
				if (multicastDelegate._invocationList is Delegate)
				{
					return Equals(multicastDelegate._invocationList);
				}
				return base.Equals(obj);
			}
			if (_invocationList is Delegate)
			{
				return _invocationList.Equals(obj);
			}
			return InvocationListEquals(multicastDelegate);
		}
		if (!InvocationListLogicallyNull())
		{
			if (!_invocationList.Equals(multicastDelegate._invocationList))
			{
				return false;
			}
			return base.Equals((object)multicastDelegate);
		}
		if (multicastDelegate._invocationList is Delegate)
		{
			return Equals(multicastDelegate._invocationList);
		}
		return base.Equals((object)multicastDelegate);
	}

	[SecuritySafeCritical]
	private bool InvocationListEquals(MulticastDelegate d)
	{
		object[] array = _invocationList as object[];
		if (d._invocationCount != _invocationCount)
		{
			return false;
		}
		int num = (int)_invocationCount;
		for (int i = 0; i < num; i++)
		{
			Delegate obj = (Delegate)array[i];
			object[] array2 = d._invocationList as object[];
			if (!obj.Equals(array2[i]))
			{
				return false;
			}
		}
		return true;
	}

	[SecurityCritical]
	private bool TrySetSlot(object[] a, int index, object o)
	{
		if (a[index] == null && Interlocked.CompareExchange<object>(ref a[index], o, (object)null) == null)
		{
			return true;
		}
		if (a[index] != null)
		{
			MulticastDelegate multicastDelegate = (MulticastDelegate)o;
			MulticastDelegate multicastDelegate2 = (MulticastDelegate)a[index];
			if (multicastDelegate2._methodPtr == multicastDelegate._methodPtr && multicastDelegate2._target == multicastDelegate._target && multicastDelegate2._methodPtrAux == multicastDelegate._methodPtrAux)
			{
				return true;
			}
		}
		return false;
	}

	[SecurityCritical]
	private MulticastDelegate NewMulticastDelegate(object[] invocationList, int invocationCount, bool thisIsMultiCastAlready)
	{
		MulticastDelegate multicastDelegate = Delegate.InternalAllocLike(this);
		if (thisIsMultiCastAlready)
		{
			multicastDelegate._methodPtr = _methodPtr;
			multicastDelegate._methodPtrAux = _methodPtrAux;
		}
		else
		{
			multicastDelegate._methodPtr = GetMulticastInvoke();
			multicastDelegate._methodPtrAux = GetInvokeMethod();
		}
		multicastDelegate._target = multicastDelegate;
		multicastDelegate._invocationList = invocationList;
		multicastDelegate._invocationCount = (IntPtr)invocationCount;
		return multicastDelegate;
	}

	[SecurityCritical]
	internal MulticastDelegate NewMulticastDelegate(object[] invocationList, int invocationCount)
	{
		return NewMulticastDelegate(invocationList, invocationCount, thisIsMultiCastAlready: false);
	}

	[SecurityCritical]
	internal void StoreDynamicMethod(MethodInfo dynamicMethod)
	{
		if (_invocationCount != (IntPtr)0)
		{
			MulticastDelegate multicastDelegate = (MulticastDelegate)_invocationList;
			multicastDelegate._methodBase = dynamicMethod;
		}
		else
		{
			_methodBase = dynamicMethod;
		}
	}

	[SecuritySafeCritical]
	protected sealed override Delegate CombineImpl(Delegate follow)
	{
		if ((object)follow == null)
		{
			return this;
		}
		if (!Delegate.InternalEqualTypes(this, follow))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTypeMis"));
		}
		MulticastDelegate multicastDelegate = (MulticastDelegate)follow;
		int num = 1;
		object[] array = multicastDelegate._invocationList as object[];
		if (array != null)
		{
			num = (int)multicastDelegate._invocationCount;
		}
		int num2;
		object[] array3;
		if (!(_invocationList is object[] array2))
		{
			num2 = 1 + num;
			array3 = new object[num2];
			array3[0] = this;
			if (array == null)
			{
				array3[1] = multicastDelegate;
			}
			else
			{
				for (int i = 0; i < num; i++)
				{
					array3[1 + i] = array[i];
				}
			}
			return NewMulticastDelegate(array3, num2);
		}
		int num3 = (int)_invocationCount;
		num2 = num3 + num;
		array3 = null;
		if (num2 <= array2.Length)
		{
			array3 = array2;
			if (array == null)
			{
				if (!TrySetSlot(array3, num3, multicastDelegate))
				{
					array3 = null;
				}
			}
			else
			{
				for (int j = 0; j < num; j++)
				{
					if (!TrySetSlot(array3, num3 + j, array[j]))
					{
						array3 = null;
						break;
					}
				}
			}
		}
		if (array3 == null)
		{
			int num4;
			for (num4 = array2.Length; num4 < num2; num4 *= 2)
			{
			}
			array3 = new object[num4];
			for (int k = 0; k < num3; k++)
			{
				array3[k] = array2[k];
			}
			if (array == null)
			{
				array3[num3] = multicastDelegate;
			}
			else
			{
				for (int l = 0; l < num; l++)
				{
					array3[num3 + l] = array[l];
				}
			}
		}
		return NewMulticastDelegate(array3, num2, thisIsMultiCastAlready: true);
	}

	[SecurityCritical]
	private object[] DeleteFromInvocationList(object[] invocationList, int invocationCount, int deleteIndex, int deleteCount)
	{
		object[] array = _invocationList as object[];
		int num = array.Length;
		while (num / 2 >= invocationCount - deleteCount)
		{
			num /= 2;
		}
		object[] array2 = new object[num];
		for (int i = 0; i < deleteIndex; i++)
		{
			array2[i] = invocationList[i];
		}
		for (int j = deleteIndex + deleteCount; j < invocationCount; j++)
		{
			array2[j - deleteCount] = invocationList[j];
		}
		return array2;
	}

	private bool EqualInvocationLists(object[] a, object[] b, int start, int count)
	{
		for (int i = 0; i < count; i++)
		{
			if (!a[start + i].Equals(b[i]))
			{
				return false;
			}
		}
		return true;
	}

	[SecuritySafeCritical]
	protected sealed override Delegate RemoveImpl(Delegate value)
	{
		if (!(value is MulticastDelegate multicastDelegate))
		{
			return this;
		}
		if (!(multicastDelegate._invocationList is object[]))
		{
			if (!(_invocationList is object[] array))
			{
				if (Equals(value))
				{
					return null;
				}
			}
			else
			{
				int num = (int)_invocationCount;
				int num2 = num;
				while (--num2 >= 0)
				{
					if (value.Equals(array[num2]))
					{
						if (num == 2)
						{
							return (Delegate)array[1 - num2];
						}
						object[] invocationList = DeleteFromInvocationList(array, num, num2, 1);
						return NewMulticastDelegate(invocationList, num - 1, thisIsMultiCastAlready: true);
					}
				}
			}
		}
		else if (_invocationList is object[] array2)
		{
			int num3 = (int)_invocationCount;
			int num4 = (int)multicastDelegate._invocationCount;
			for (int num5 = num3 - num4; num5 >= 0; num5--)
			{
				if (EqualInvocationLists(array2, multicastDelegate._invocationList as object[], num5, num4))
				{
					if (num3 - num4 == 0)
					{
						return null;
					}
					if (num3 - num4 == 1)
					{
						return (Delegate)array2[(num5 == 0) ? (num3 - 1) : 0];
					}
					object[] invocationList2 = DeleteFromInvocationList(array2, num3, num5, num4);
					return NewMulticastDelegate(invocationList2, num3 - num4, thisIsMultiCastAlready: true);
				}
			}
		}
		return this;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public sealed override Delegate[] GetInvocationList()
	{
		Delegate[] array2;
		if (!(_invocationList is object[] array))
		{
			array2 = new Delegate[1] { this };
		}
		else
		{
			int num = (int)_invocationCount;
			array2 = new Delegate[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = (Delegate)array[i];
			}
		}
		return array2;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(MulticastDelegate d1, MulticastDelegate d2)
	{
		return d1?.Equals(d2) ?? ((object)d2 == null);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(MulticastDelegate d1, MulticastDelegate d2)
	{
		if ((object)d1 == null)
		{
			return (object)d2 != null;
		}
		return !d1.Equals(d2);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public sealed override int GetHashCode()
	{
		if (IsUnmanagedFunctionPtr())
		{
			return ValueType.GetHashCodeOfPtr(_methodPtr) ^ ValueType.GetHashCodeOfPtr(_methodPtrAux);
		}
		if (!(_invocationList is object[] array))
		{
			return base.GetHashCode();
		}
		int num = 0;
		for (int i = 0; i < (int)_invocationCount; i++)
		{
			num = num * 33 + array[i].GetHashCode();
		}
		return num;
	}

	[SecuritySafeCritical]
	internal override object GetTarget()
	{
		if (_invocationCount != (IntPtr)0)
		{
			if (InvocationListLogicallyNull())
			{
				return null;
			}
			if (_invocationList is object[] array)
			{
				int num = (int)_invocationCount;
				return ((Delegate)array[num - 1]).GetTarget();
			}
			if (_invocationList is Delegate obj)
			{
				return obj.GetTarget();
			}
		}
		return base.GetTarget();
	}

	[SecuritySafeCritical]
	protected override MethodInfo GetMethodImpl()
	{
		if (_invocationCount != (IntPtr)0 && _invocationList != null)
		{
			if (_invocationList is object[] array)
			{
				int num = (int)_invocationCount - 1;
				return ((Delegate)array[num]).Method;
			}
			if (_invocationList is MulticastDelegate multicastDelegate)
			{
				return multicastDelegate.GetMethodImpl();
			}
		}
		else if (IsUnmanagedFunctionPtr())
		{
			if (_methodBase == null || !(_methodBase is MethodInfo))
			{
				IRuntimeMethodInfo runtimeMethodInfo = FindMethodHandle();
				RuntimeType runtimeType = RuntimeMethodHandle.GetDeclaringType(runtimeMethodInfo);
				if (RuntimeTypeHandle.IsGenericTypeDefinition(runtimeType) || RuntimeTypeHandle.HasInstantiation(runtimeType))
				{
					RuntimeType runtimeType2 = GetType() as RuntimeType;
					runtimeType = runtimeType2;
				}
				_methodBase = (MethodInfo)RuntimeType.GetMethodBase(runtimeType, runtimeMethodInfo);
			}
			return (MethodInfo)_methodBase;
		}
		return base.GetMethodImpl();
	}

	[DebuggerNonUserCode]
	private void ThrowNullThisInDelegateToInstance()
	{
		throw new ArgumentException(Environment.GetResourceString("Arg_DlgtNullInst"));
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorClosed(object target, IntPtr methodPtr)
	{
		if (target == null)
		{
			ThrowNullThisInDelegateToInstance();
		}
		_target = target;
		_methodPtr = methodPtr;
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorClosedStatic(object target, IntPtr methodPtr)
	{
		_target = target;
		_methodPtr = methodPtr;
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorRTClosed(object target, IntPtr methodPtr)
	{
		_target = target;
		_methodPtr = AdjustTarget(target, methodPtr);
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorOpened(object target, IntPtr methodPtr, IntPtr shuffleThunk)
	{
		_target = this;
		_methodPtr = shuffleThunk;
		_methodPtrAux = methodPtr;
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorSecureClosed(object target, IntPtr methodPtr, IntPtr callThunk, IntPtr creatorMethod)
	{
		MulticastDelegate multicastDelegate = Delegate.InternalAllocLike(this);
		multicastDelegate.CtorClosed(target, methodPtr);
		_invocationList = multicastDelegate;
		_target = this;
		_methodPtr = callThunk;
		_methodPtrAux = creatorMethod;
		_invocationCount = GetInvokeMethod();
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorSecureClosedStatic(object target, IntPtr methodPtr, IntPtr callThunk, IntPtr creatorMethod)
	{
		MulticastDelegate multicastDelegate = Delegate.InternalAllocLike(this);
		multicastDelegate.CtorClosedStatic(target, methodPtr);
		_invocationList = multicastDelegate;
		_target = this;
		_methodPtr = callThunk;
		_methodPtrAux = creatorMethod;
		_invocationCount = GetInvokeMethod();
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorSecureRTClosed(object target, IntPtr methodPtr, IntPtr callThunk, IntPtr creatorMethod)
	{
		MulticastDelegate multicastDelegate = Delegate.InternalAllocLike(this);
		multicastDelegate.CtorRTClosed(target, methodPtr);
		_invocationList = multicastDelegate;
		_target = this;
		_methodPtr = callThunk;
		_methodPtrAux = creatorMethod;
		_invocationCount = GetInvokeMethod();
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorSecureOpened(object target, IntPtr methodPtr, IntPtr shuffleThunk, IntPtr callThunk, IntPtr creatorMethod)
	{
		MulticastDelegate multicastDelegate = Delegate.InternalAllocLike(this);
		multicastDelegate.CtorOpened(target, methodPtr, shuffleThunk);
		_invocationList = multicastDelegate;
		_target = this;
		_methodPtr = callThunk;
		_methodPtrAux = creatorMethod;
		_invocationCount = GetInvokeMethod();
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorVirtualDispatch(object target, IntPtr methodPtr, IntPtr shuffleThunk)
	{
		_target = this;
		_methodPtr = shuffleThunk;
		_methodPtrAux = GetCallStub(methodPtr);
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorSecureVirtualDispatch(object target, IntPtr methodPtr, IntPtr shuffleThunk, IntPtr callThunk, IntPtr creatorMethod)
	{
		MulticastDelegate multicastDelegate = Delegate.InternalAllocLike(this);
		multicastDelegate.CtorVirtualDispatch(target, methodPtr, shuffleThunk);
		_invocationList = multicastDelegate;
		_target = this;
		_methodPtr = callThunk;
		_methodPtrAux = creatorMethod;
		_invocationCount = GetInvokeMethod();
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorCollectibleClosedStatic(object target, IntPtr methodPtr, IntPtr gchandle)
	{
		_target = target;
		_methodPtr = methodPtr;
		_methodBase = GCHandle.InternalGet(gchandle);
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorCollectibleOpened(object target, IntPtr methodPtr, IntPtr shuffleThunk, IntPtr gchandle)
	{
		_target = this;
		_methodPtr = shuffleThunk;
		_methodPtrAux = methodPtr;
		_methodBase = GCHandle.InternalGet(gchandle);
	}

	[SecurityCritical]
	[DebuggerNonUserCode]
	private void CtorCollectibleVirtualDispatch(object target, IntPtr methodPtr, IntPtr shuffleThunk, IntPtr gchandle)
	{
		_target = this;
		_methodPtr = shuffleThunk;
		_methodPtrAux = GetCallStub(methodPtr);
		_methodBase = GCHandle.InternalGet(gchandle);
	}
}
