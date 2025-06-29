using System.Collections;

namespace System.Security.AccessControl;

public sealed class RawAcl : GenericAcl
{
	private byte _revision;

	private ArrayList _aces;

	public override byte Revision => _revision;

	public override int Count => _aces.Count;

	public override int BinaryLength
	{
		get
		{
			int num = 8;
			for (int i = 0; i < Count; i++)
			{
				GenericAce genericAce = _aces[i] as GenericAce;
				num += genericAce.BinaryLength;
			}
			return num;
		}
	}

	public override GenericAce this[int index]
	{
		get
		{
			return _aces[index] as GenericAce;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.BinaryLength % 4 != 0)
			{
				throw new SystemException();
			}
			int num = BinaryLength - ((index < _aces.Count) ? (_aces[index] as GenericAce).BinaryLength : 0) + value.BinaryLength;
			if (num > GenericAcl.MaxBinaryLength)
			{
				throw new OverflowException(Environment.GetResourceString("AccessControl_AclTooLong"));
			}
			_aces[index] = value;
		}
	}

	private static void VerifyHeader(byte[] binaryForm, int offset, out byte revision, out int count, out int length)
	{
		if (binaryForm == null)
		{
			throw new ArgumentNullException("binaryForm");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (binaryForm.Length - offset >= 8)
		{
			revision = binaryForm[offset];
			length = binaryForm[offset + 2] + (binaryForm[offset + 3] << 8);
			count = binaryForm[offset + 4] + (binaryForm[offset + 5] << 8);
			if (length <= binaryForm.Length - offset)
			{
				return;
			}
		}
		throw new ArgumentOutOfRangeException("binaryForm", Environment.GetResourceString("ArgumentOutOfRange_ArrayTooSmall"));
	}

	private void MarshalHeader(byte[] binaryForm, int offset)
	{
		if (binaryForm == null)
		{
			throw new ArgumentNullException("binaryForm");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (BinaryLength > GenericAcl.MaxBinaryLength)
		{
			throw new InvalidOperationException(Environment.GetResourceString("AccessControl_AclTooLong"));
		}
		if (binaryForm.Length - offset < BinaryLength)
		{
			throw new ArgumentOutOfRangeException("binaryForm", Environment.GetResourceString("ArgumentOutOfRange_ArrayTooSmall"));
		}
		binaryForm[offset] = Revision;
		binaryForm[offset + 1] = 0;
		binaryForm[offset + 2] = (byte)BinaryLength;
		binaryForm[offset + 3] = (byte)(BinaryLength >> 8);
		binaryForm[offset + 4] = (byte)Count;
		binaryForm[offset + 5] = (byte)(Count >> 8);
		binaryForm[offset + 6] = 0;
		binaryForm[offset + 7] = 0;
	}

	internal void SetBinaryForm(byte[] binaryForm, int offset)
	{
		VerifyHeader(binaryForm, offset, out _revision, out var count, out var length);
		length += offset;
		offset += 8;
		_aces = new ArrayList(count);
		int num = 8;
		int num2 = 0;
		while (true)
		{
			if (num2 < count)
			{
				GenericAce genericAce = GenericAce.CreateFromBinaryForm(binaryForm, offset);
				int binaryLength = genericAce.BinaryLength;
				if (num + binaryLength > GenericAcl.MaxBinaryLength)
				{
					throw new ArgumentException(Environment.GetResourceString("ArgumentException_InvalidAclBinaryForm"), "binaryForm");
				}
				_aces.Add(genericAce);
				if (binaryLength % 4 != 0)
				{
					throw new SystemException();
				}
				num += binaryLength;
				offset = ((_revision != GenericAcl.AclRevisionDS) ? (offset + binaryLength) : (offset + (binaryForm[offset + 2] + (binaryForm[offset + 3] << 8))));
				if (offset > length)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		throw new ArgumentException(Environment.GetResourceString("ArgumentException_InvalidAclBinaryForm"), "binaryForm");
	}

	public RawAcl(byte revision, int capacity)
	{
		_revision = revision;
		_aces = new ArrayList(capacity);
	}

	public RawAcl(byte[] binaryForm, int offset)
	{
		SetBinaryForm(binaryForm, offset);
	}

	public override void GetBinaryForm(byte[] binaryForm, int offset)
	{
		MarshalHeader(binaryForm, offset);
		offset += 8;
		for (int i = 0; i < Count; i++)
		{
			GenericAce genericAce = _aces[i] as GenericAce;
			genericAce.GetBinaryForm(binaryForm, offset);
			int binaryLength = genericAce.BinaryLength;
			if (binaryLength % 4 != 0)
			{
				throw new SystemException();
			}
			offset += binaryLength;
		}
	}

	public void InsertAce(int index, GenericAce ace)
	{
		if (ace == null)
		{
			throw new ArgumentNullException("ace");
		}
		if (BinaryLength + ace.BinaryLength > GenericAcl.MaxBinaryLength)
		{
			throw new OverflowException(Environment.GetResourceString("AccessControl_AclTooLong"));
		}
		_aces.Insert(index, ace);
	}

	public void RemoveAce(int index)
	{
		GenericAce genericAce = _aces[index] as GenericAce;
		_aces.RemoveAt(index);
	}
}
