using System.Reflection.Metadata;
using System.Security;

namespace System.Reflection.Internal;

internal abstract class AbstractMemoryBlock : IDisposable
{
	public unsafe abstract byte* Pointer
	{
		[SecuritySafeCritical]
		get;
	}

	public abstract int Size { get; }

	[SecuritySafeCritical]
	public unsafe BlobReader GetReader()
	{
		return new BlobReader(Pointer, Size);
	}

	public abstract void Dispose();
}
