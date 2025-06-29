using System.Collections;
using System.Collections.Generic;

namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("faa585ea-6214-4217-afda-7f46de5869b3")]
internal interface IIterable<T> : IEnumerable<T>, IEnumerable
{
	IIterator<T> First();
}
