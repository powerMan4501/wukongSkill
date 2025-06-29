using System.Reflection.Internal;
using System.Reflection.Metadata;
using System.Security;

namespace System.Reflection.PortableExecutable;

internal struct PEMemoryBlock
{
	private readonly AbstractMemoryBlock _block;

	private readonly int _offset;

	public unsafe byte* Pointer
	{
		[SecurityCritical]
		get
		{
			if (_block == null)
			{
				return null;
			}
			return _block.Pointer + _offset;
		}
	}

	public int Length => (_block?.Size - _offset).GetValueOrDefault();

	internal PEMemoryBlock(AbstractMemoryBlock block, int offset = 0)
	{
		_block = block;
		_offset = offset;
	}

	[SecuritySafeCritical]
	public unsafe BlobReader GetReader()
	{
		return new BlobReader(Pointer, Length);
	}

	[SecuritySafeCritical]
	public unsafe BlobReader GetReader(int start, int length)
	{
		BlobUtilities.ValidateRange(Length, start, length, "length");
		return new BlobReader(Pointer + start, length);
	}
}
