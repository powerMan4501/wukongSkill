using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.StubHelpers;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class IterableToEnumerableAdapter
{
	private IterableToEnumerableAdapter()
	{
	}

	[SecurityCritical]
	internal IEnumerator<T> GetEnumerator_Stub<T>()
	{
		IIterable<T> iterable = JitHelpers.UnsafeCast<IIterable<T>>(this);
		return new IteratorToEnumeratorAdapter<T>(iterable.First());
	}

	[SecurityCritical]
	internal IEnumerator<T> GetEnumerator_Variance_Stub<T>() where T : class
	{
		bool fUseString;
		Delegate targetForAmbiguousVariantCall = System.StubHelpers.StubHelpers.GetTargetForAmbiguousVariantCall(this, typeof(IEnumerable<T>).TypeHandle.Value, out fUseString);
		if ((object)targetForAmbiguousVariantCall != null)
		{
			return JitHelpers.UnsafeCast<GetEnumerator_Delegate<T>>(targetForAmbiguousVariantCall)();
		}
		if (fUseString)
		{
			return JitHelpers.UnsafeCast<IEnumerator<T>>(GetEnumerator_Stub<string>());
		}
		return GetEnumerator_Stub<T>();
	}
}
