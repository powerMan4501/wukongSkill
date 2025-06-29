using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class EnumerableToBindableIterableAdapter
{
	internal sealed class NonGenericToGenericEnumerator : IEnumerator<object>, IDisposable, IEnumerator
	{
		private IEnumerator enumerator;

		public object Current => enumerator.Current;

		public NonGenericToGenericEnumerator(IEnumerator enumerator)
		{
			this.enumerator = enumerator;
		}

		public bool MoveNext()
		{
			return enumerator.MoveNext();
		}

		public void Reset()
		{
			enumerator.Reset();
		}

		public void Dispose()
		{
		}
	}

	private EnumerableToBindableIterableAdapter()
	{
	}

	[SecurityCritical]
	internal IBindableIterator First_Stub()
	{
		IEnumerable enumerable = JitHelpers.UnsafeCast<IEnumerable>(this);
		return new EnumeratorToIteratorAdapter<object>(new NonGenericToGenericEnumerator(enumerable.GetEnumerator()));
	}
}
