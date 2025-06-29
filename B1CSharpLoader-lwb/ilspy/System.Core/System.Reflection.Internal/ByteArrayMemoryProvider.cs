using System.Collections.Immutable;
using System.IO;
using System.Security;
using System.Threading;

namespace System.Reflection.Internal;

internal sealed class ByteArrayMemoryProvider : MemoryBlockProvider
{
	private readonly ImmutableArray<byte> _array;

	private PinnedObject _pinned;

	public override int Size => _array.Length;

	public ImmutableArray<byte> Array => _array;

	internal unsafe byte* Pointer
	{
		[SecurityCritical]
		get
		{
			if (_pinned == null)
			{
				PinnedObject pinnedObject = new PinnedObject(_array.UnderlyingArray);
				if (Interlocked.CompareExchange(ref _pinned, pinnedObject, null) != null)
				{
					pinnedObject.Dispose();
				}
			}
			return _pinned.Pointer;
		}
	}

	public ByteArrayMemoryProvider(ImmutableArray<byte> array)
	{
		_array = array;
	}

	protected override void Dispose(bool disposing)
	{
		Interlocked.Exchange(ref _pinned, null)?.Dispose();
	}

	protected override AbstractMemoryBlock GetMemoryBlockImpl(int start, int size)
	{
		return new ByteArrayMemoryBlock(this, start, size);
	}

	public override Stream GetStream(out StreamConstraints constraints)
	{
		constraints = new StreamConstraints(null, 0L, Size);
		return new ImmutableMemoryStream(_array);
	}
}
