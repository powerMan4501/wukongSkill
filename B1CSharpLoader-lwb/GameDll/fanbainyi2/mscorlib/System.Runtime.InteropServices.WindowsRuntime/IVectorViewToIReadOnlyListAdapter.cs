using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.StubHelpers;

namespace System.Runtime.InteropServices.WindowsRuntime;

[DebuggerDisplay("Count = {Count}")]
internal sealed class IVectorViewToIReadOnlyListAdapter
{
	private IVectorViewToIReadOnlyListAdapter()
	{
	}

	[SecurityCritical]
	internal T Indexer_Get<T>(int index)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		IVectorView<T> vectorView = JitHelpers.UnsafeCast<IVectorView<T>>(this);
		try
		{
			return vectorView.GetAt((uint)index);
		}
		catch (Exception ex)
		{
			if (-2147483637 == ex._HResult)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			throw;
		}
	}

	[SecurityCritical]
	internal T Indexer_Get_Variance<T>(int index) where T : class
	{
		bool fUseString;
		Delegate targetForAmbiguousVariantCall = System.StubHelpers.StubHelpers.GetTargetForAmbiguousVariantCall(this, typeof(IReadOnlyList<T>).TypeHandle.Value, out fUseString);
		if ((object)targetForAmbiguousVariantCall != null)
		{
			return JitHelpers.UnsafeCast<Indexer_Get_Delegate<T>>(targetForAmbiguousVariantCall)(index);
		}
		if (fUseString)
		{
			return JitHelpers.UnsafeCast<T>(Indexer_Get<string>(index));
		}
		return Indexer_Get<T>(index);
	}
}
