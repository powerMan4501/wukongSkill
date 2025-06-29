using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBGUBulletSweepCheckTypeTupleWrapper : IMessage<EBGUBulletSweepCheckTypeTupleWrapper>, IMessage, IEquatable<EBGUBulletSweepCheckTypeTupleWrapper>, IDeepCloneable<EBGUBulletSweepCheckTypeTupleWrapper>
{
	private static readonly MessageParser<EBGUBulletSweepCheckTypeTupleWrapper> _parser = new MessageParser<EBGUBulletSweepCheckTypeTupleWrapper>(() => new EBGUBulletSweepCheckTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBGUBulletSweepCheckType item1_;

	private EBGUBulletSweepCheckType item2_;

	public static MessageParser<EBGUBulletSweepCheckTypeTupleWrapper> Parser => _parser;

	public EBGUBulletSweepCheckType Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public EBGUBulletSweepCheckType Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public EBGUBulletSweepCheckTypeTupleWrapper()
	{
	}

	public EBGUBulletSweepCheckTypeTupleWrapper(EBGUBulletSweepCheckTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBGUBulletSweepCheckTypeTupleWrapper Clone()
	{
		return new EBGUBulletSweepCheckTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBGUBulletSweepCheckTypeTupleWrapper);
	}

	public bool Equals(EBGUBulletSweepCheckTypeTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != EBGUBulletSweepCheckType.BoxShape)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBGUBulletSweepCheckType.BoxShape)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != EBGUBulletSweepCheckType.BoxShape)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBGUBulletSweepCheckType.BoxShape)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != EBGUBulletSweepCheckType.BoxShape)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBGUBulletSweepCheckType.BoxShape)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBGUBulletSweepCheckTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBGUBulletSweepCheckType.BoxShape)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBGUBulletSweepCheckType.BoxShape)
			{
				Item2 = other.Item2;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				Item1 = (EBGUBulletSweepCheckType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBGUBulletSweepCheckType)input.ReadEnum();
				break;
			}
		}
	}
}
