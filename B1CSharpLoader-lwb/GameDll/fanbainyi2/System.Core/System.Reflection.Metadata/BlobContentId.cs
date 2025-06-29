using System.Collections.Immutable;
using System.Reflection.Internal;
using System.Security;

namespace System.Reflection.Metadata;

internal struct BlobContentId : IEquatable<BlobContentId>
{
	private const int Size = 20;

	public Guid Guid { get; }

	public uint Stamp { get; }

	public bool IsDefault
	{
		get
		{
			if (Guid == default(Guid))
			{
				return Stamp == 0;
			}
			return false;
		}
	}

	public BlobContentId(Guid guid, uint stamp)
	{
		Guid = guid;
		Stamp = stamp;
	}

	public BlobContentId(ImmutableArray<byte> id)
		: this(id.UnderlyingArray)
	{
	}

	[SecuritySafeCritical]
	public unsafe BlobContentId(byte[] id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (id.Length != 20)
		{
			throw new ArgumentException("UnexpectedArrayLength", "id");
		}
		fixed (byte* buffer = &id[0])
		{
			BlobReader blobReader = new BlobReader(buffer, id.Length);
			Guid = blobReader.ReadGuid();
			Stamp = blobReader.ReadUInt32();
		}
	}

	public bool Equals(BlobContentId other)
	{
		if (Guid == other.Guid)
		{
			return Stamp == other.Stamp;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj is BlobContentId)
		{
			return Equals((BlobContentId)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Hash.Combine(Stamp, Guid.GetHashCode());
	}

	public static bool operator ==(BlobContentId left, BlobContentId right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(BlobContentId left, BlobContentId right)
	{
		return !left.Equals(right);
	}
}
