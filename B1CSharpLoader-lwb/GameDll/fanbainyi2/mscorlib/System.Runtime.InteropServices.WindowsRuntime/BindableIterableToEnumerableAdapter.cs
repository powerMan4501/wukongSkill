using System.Collections;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class BindableIterableToEnumerableAdapter
{
	private sealed class NonGenericToGenericIterator : IIterator<object>
	{
		private IBindableIterator iterator;

		public object Current => iterator.Current;

		public bool HasCurrent => iterator.HasCurrent;

		public NonGenericToGenericIterator(IBindableIterator iterator)
		{
			this.iterator = iterator;
		}

		public bool MoveNext()
		{
			return iterator.MoveNext();
		}

		public int GetMany(object[] items)
		{
			throw new NotSupportedException();
		}
	}

	private BindableIterableToEnumerableAdapter()
	{
	}

	[SecurityCritical]
	internal IEnumerator GetEnumerator_Stub()
	{
		IBindableIterable bindableIterable = JitHelpers.UnsafeCast<IBindableIterable>(this);
		return new IteratorToEnumeratorAdapter<object>(new NonGenericToGenericIterator(bindableIterable.First()));
	}
}
