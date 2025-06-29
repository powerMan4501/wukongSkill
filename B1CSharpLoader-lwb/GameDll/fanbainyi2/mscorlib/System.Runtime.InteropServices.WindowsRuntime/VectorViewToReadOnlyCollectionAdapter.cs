using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class VectorViewToReadOnlyCollectionAdapter
{
	private VectorViewToReadOnlyCollectionAdapter()
	{
	}

	[SecurityCritical]
	internal int Count<T>()
	{
		IVectorView<T> vectorView = JitHelpers.UnsafeCast<IVectorView<T>>(this);
		uint size = vectorView.Size;
		if (int.MaxValue < size)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingListTooLarge"));
		}
		return (int)size;
	}
}
