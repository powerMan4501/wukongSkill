using System.Security;

namespace System.Reflection.Internal;

internal sealed class ExternalMemoryBlock : AbstractMemoryBlock
{
	private readonly object _memoryOwner;

	[SecurityCritical]
	private unsafe byte* _buffer;

	private int _size;

	public unsafe override byte* Pointer
	{
		[SecurityCritical]
		get
		{
			return _buffer;
		}
	}

	public override int Size => _size;

	[SecurityCritical]
	public unsafe ExternalMemoryBlock(object memoryOwner, byte* buffer, int size)
	{
		_memoryOwner = memoryOwner;
		_buffer = buffer;
		_size = size;
	}

	[SecuritySafeCritical]
	public unsafe override void Dispose()
	{
		_buffer = null;
		_size = 0;
	}
}
