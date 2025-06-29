using System.Collections;
using System.Collections.Generic;

namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("bbe1fa4c-b0e3-4583-baef-1f1b2e483e56")]
internal interface IVectorView<T> : IIterable<T>, IEnumerable<T>, IEnumerable
{
	T GetAt(uint index);

	uint Size { get; }

	bool IndexOf(T value, out uint index);

	uint GetMany(uint startIndex, [Out] T[] items);
}
