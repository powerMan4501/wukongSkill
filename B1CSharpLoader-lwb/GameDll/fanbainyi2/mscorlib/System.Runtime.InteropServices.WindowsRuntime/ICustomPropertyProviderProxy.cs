using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal class ICustomPropertyProviderProxy<T1, T2> : IGetProxyTarget, ICustomPropertyProvider, ICustomQueryInterface, IEnumerable, IBindableVector, IBindableIterable, IBindableVectorView
{
	private sealed class IVectorViewToIBindableVectorViewAdapter<T> : IBindableVectorView, IBindableIterable
	{
		private IVectorView<T> _vectorView;

		uint IBindableVectorView.Size => _vectorView.Size;

		public IVectorViewToIBindableVectorViewAdapter(IVectorView<T> vectorView)
		{
			_vectorView = vectorView;
		}

		object IBindableVectorView.GetAt(uint index)
		{
			return _vectorView.GetAt(index);
		}

		bool IBindableVectorView.IndexOf(object value, out uint index)
		{
			return _vectorView.IndexOf(ICustomPropertyProviderProxy<T1, T2>.ConvertTo<T>(value), out index);
		}

		IBindableIterator IBindableIterable.First()
		{
			return new IteratorOfTToIteratorAdapter<T>(_vectorView.First());
		}
	}

	private sealed class IteratorOfTToIteratorAdapter<T> : IBindableIterator
	{
		private IIterator<T> _iterator;

		public bool HasCurrent => _iterator.HasCurrent;

		public object Current => _iterator.Current;

		public IteratorOfTToIteratorAdapter(IIterator<T> iterator)
		{
			_iterator = iterator;
		}

		public bool MoveNext()
		{
			return _iterator.MoveNext();
		}
	}

	private object _target;

	private InterfaceForwardingSupport _flags;

	Type ICustomPropertyProvider.Type => _target.GetType();

	uint IBindableVector.Size => GetIBindableVectorNoThrow()?.Size ?? GetVectorOfT().Size;

	uint IBindableVectorView.Size => GetIBindableVectorViewNoThrow()?.Size ?? GetVectorViewOfT().Size;

	internal ICustomPropertyProviderProxy(object target, InterfaceForwardingSupport flags)
	{
		_target = target;
		_flags = flags;
	}

	internal static object CreateInstance(object target)
	{
		InterfaceForwardingSupport interfaceForwardingSupport = InterfaceForwardingSupport.None;
		if (target is IList)
		{
			interfaceForwardingSupport |= InterfaceForwardingSupport.IBindableVector;
		}
		if (target is IList<T1>)
		{
			interfaceForwardingSupport |= InterfaceForwardingSupport.IVector;
		}
		if (target is IBindableVectorView)
		{
			interfaceForwardingSupport |= InterfaceForwardingSupport.IBindableVectorView;
		}
		if (target is IReadOnlyList<T2>)
		{
			interfaceForwardingSupport |= InterfaceForwardingSupport.IVectorView;
		}
		if (target is IEnumerable)
		{
			interfaceForwardingSupport |= InterfaceForwardingSupport.IBindableIterableOrIIterable;
		}
		return new ICustomPropertyProviderProxy<T1, T2>(target, interfaceForwardingSupport);
	}

	ICustomProperty ICustomPropertyProvider.GetCustomProperty(string name)
	{
		return ICustomPropertyProviderImpl.CreateProperty(_target, name);
	}

	ICustomProperty ICustomPropertyProvider.GetIndexedProperty(string name, Type indexParameterType)
	{
		return ICustomPropertyProviderImpl.CreateIndexedProperty(_target, name, indexParameterType);
	}

	string ICustomPropertyProvider.GetStringRepresentation()
	{
		return IStringableHelper.ToString(_target);
	}

	public override string ToString()
	{
		return IStringableHelper.ToString(_target);
	}

	object IGetProxyTarget.GetTarget()
	{
		return _target;
	}

	[SecurityCritical]
	public CustomQueryInterfaceResult GetInterface([In] ref Guid iid, out IntPtr ppv)
	{
		ppv = IntPtr.Zero;
		if (iid == typeof(IBindableIterable).GUID && (_flags & InterfaceForwardingSupport.IBindableIterableOrIIterable) == 0)
		{
			return CustomQueryInterfaceResult.Failed;
		}
		if (iid == typeof(IBindableVector).GUID && (_flags & (InterfaceForwardingSupport.IBindableVector | InterfaceForwardingSupport.IVector)) == 0)
		{
			return CustomQueryInterfaceResult.Failed;
		}
		if (iid == typeof(IBindableVectorView).GUID && (_flags & (InterfaceForwardingSupport.IBindableVectorView | InterfaceForwardingSupport.IVectorView)) == 0)
		{
			return CustomQueryInterfaceResult.Failed;
		}
		return CustomQueryInterfaceResult.NotHandled;
	}

	public IEnumerator GetEnumerator()
	{
		return ((IEnumerable)_target).GetEnumerator();
	}

	object IBindableVector.GetAt(uint index)
	{
		IBindableVector iBindableVectorNoThrow = GetIBindableVectorNoThrow();
		if (iBindableVectorNoThrow != null)
		{
			return iBindableVectorNoThrow.GetAt(index);
		}
		return GetVectorOfT().GetAt(index);
	}

	IBindableVectorView IBindableVector.GetView()
	{
		IBindableVector iBindableVectorNoThrow = GetIBindableVectorNoThrow();
		if (iBindableVectorNoThrow != null)
		{
			return iBindableVectorNoThrow.GetView();
		}
		return new IVectorViewToIBindableVectorViewAdapter<T1>(GetVectorOfT().GetView());
	}

	bool IBindableVector.IndexOf(object value, out uint index)
	{
		return GetIBindableVectorNoThrow()?.IndexOf(value, out index) ?? GetVectorOfT().IndexOf(ConvertTo<T1>(value), out index);
	}

	void IBindableVector.SetAt(uint index, object value)
	{
		IBindableVector iBindableVectorNoThrow = GetIBindableVectorNoThrow();
		if (iBindableVectorNoThrow != null)
		{
			iBindableVectorNoThrow.SetAt(index, value);
		}
		else
		{
			GetVectorOfT().SetAt(index, ConvertTo<T1>(value));
		}
	}

	void IBindableVector.InsertAt(uint index, object value)
	{
		IBindableVector iBindableVectorNoThrow = GetIBindableVectorNoThrow();
		if (iBindableVectorNoThrow != null)
		{
			iBindableVectorNoThrow.InsertAt(index, value);
		}
		else
		{
			GetVectorOfT().InsertAt(index, ConvertTo<T1>(value));
		}
	}

	void IBindableVector.RemoveAt(uint index)
	{
		IBindableVector iBindableVectorNoThrow = GetIBindableVectorNoThrow();
		if (iBindableVectorNoThrow != null)
		{
			iBindableVectorNoThrow.RemoveAt(index);
		}
		else
		{
			GetVectorOfT().RemoveAt(index);
		}
	}

	void IBindableVector.Append(object value)
	{
		IBindableVector iBindableVectorNoThrow = GetIBindableVectorNoThrow();
		if (iBindableVectorNoThrow != null)
		{
			iBindableVectorNoThrow.Append(value);
		}
		else
		{
			GetVectorOfT().Append(ConvertTo<T1>(value));
		}
	}

	void IBindableVector.RemoveAtEnd()
	{
		IBindableVector iBindableVectorNoThrow = GetIBindableVectorNoThrow();
		if (iBindableVectorNoThrow != null)
		{
			iBindableVectorNoThrow.RemoveAtEnd();
		}
		else
		{
			GetVectorOfT().RemoveAtEnd();
		}
	}

	void IBindableVector.Clear()
	{
		IBindableVector iBindableVectorNoThrow = GetIBindableVectorNoThrow();
		if (iBindableVectorNoThrow != null)
		{
			iBindableVectorNoThrow.Clear();
		}
		else
		{
			GetVectorOfT().Clear();
		}
	}

	[SecuritySafeCritical]
	private IBindableVector GetIBindableVectorNoThrow()
	{
		if ((_flags & InterfaceForwardingSupport.IBindableVector) != InterfaceForwardingSupport.None)
		{
			return JitHelpers.UnsafeCast<IBindableVector>(_target);
		}
		return null;
	}

	[SecuritySafeCritical]
	private IVector_Raw<T1> GetVectorOfT()
	{
		if ((_flags & InterfaceForwardingSupport.IVector) != InterfaceForwardingSupport.None)
		{
			return JitHelpers.UnsafeCast<IVector_Raw<T1>>(_target);
		}
		throw new InvalidOperationException();
	}

	object IBindableVectorView.GetAt(uint index)
	{
		IBindableVectorView iBindableVectorViewNoThrow = GetIBindableVectorViewNoThrow();
		if (iBindableVectorViewNoThrow != null)
		{
			return iBindableVectorViewNoThrow.GetAt(index);
		}
		return GetVectorViewOfT().GetAt(index);
	}

	bool IBindableVectorView.IndexOf(object value, out uint index)
	{
		return GetIBindableVectorViewNoThrow()?.IndexOf(value, out index) ?? GetVectorViewOfT().IndexOf(ConvertTo<T2>(value), out index);
	}

	IBindableIterator IBindableIterable.First()
	{
		IBindableVectorView iBindableVectorViewNoThrow = GetIBindableVectorViewNoThrow();
		if (iBindableVectorViewNoThrow != null)
		{
			return iBindableVectorViewNoThrow.First();
		}
		return new IteratorOfTToIteratorAdapter<T2>(GetVectorViewOfT().First());
	}

	[SecuritySafeCritical]
	private IBindableVectorView GetIBindableVectorViewNoThrow()
	{
		if ((_flags & InterfaceForwardingSupport.IBindableVectorView) != InterfaceForwardingSupport.None)
		{
			return JitHelpers.UnsafeCast<IBindableVectorView>(_target);
		}
		return null;
	}

	[SecuritySafeCritical]
	private IVectorView<T2> GetVectorViewOfT()
	{
		if ((_flags & InterfaceForwardingSupport.IVectorView) != InterfaceForwardingSupport.None)
		{
			return JitHelpers.UnsafeCast<IVectorView<T2>>(_target);
		}
		throw new InvalidOperationException();
	}

	private static T ConvertTo<T>(object value)
	{
		ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
		return (T)value;
	}
}
