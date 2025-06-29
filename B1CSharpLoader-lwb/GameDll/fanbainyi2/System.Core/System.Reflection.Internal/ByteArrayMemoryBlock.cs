using System.Security;

namespace System.Reflection.Internal;

internal sealed class ByteArrayMemoryBlock : AbstractMemoryBlock
{
	private ByteArrayMemoryProvider _provider;

	private readonly int _start;

	private readonly int _size;

	public unsafe override byte* Pointer
	{
		[SecuritySafeCritical]
		get
		{
			return _provider.Pointer + _start;
		}
	}

	public override int Size => _size;

	internal ByteArrayMemoryBlock(ByteArrayMemoryProvider provider, int start, int size)
	{
		_provider = provider;
		_size = size;
		_start = start;
	}

	public override void Dispose()
	{
		_provider = null;
	}
}
