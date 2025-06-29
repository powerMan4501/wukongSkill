using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBulletOrMagicFieldMoveModeTypeTupleWrapper : IMessage<EBulletOrMagicFieldMoveModeTypeTupleWrapper>, IMessage, IEquatable<EBulletOrMagicFieldMoveModeTypeTupleWrapper>, IDeepCloneable<EBulletOrMagicFieldMoveModeTypeTupleWrapper>
{
	private static readonly MessageParser<EBulletOrMagicFieldMoveModeTypeTupleWrapper> _parser = new MessageParser<EBulletOrMagicFieldMoveModeTypeTupleWrapper>(() => new EBulletOrMagicFieldMoveModeTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBulletOrMagicFieldMoveModeType item1_;

	private EBulletOrMagicFieldMoveModeType item2_;

	public static MessageParser<EBulletOrMagicFieldMoveModeTypeTupleWrapper> Parser => _parser;

	public EBulletOrMagicFieldMoveModeType Item1
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

	public EBulletOrMagicFieldMoveModeType Item2
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

	public EBulletOrMagicFieldMoveModeTypeTupleWrapper()
	{
	}

	public EBulletOrMagicFieldMoveModeTypeTupleWrapper(EBulletOrMagicFieldMoveModeTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBulletOrMagicFieldMoveModeTypeTupleWrapper Clone()
	{
		return new EBulletOrMagicFieldMoveModeTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBulletOrMagicFieldMoveModeTypeTupleWrapper);
	}

	public bool Equals(EBulletOrMagicFieldMoveModeTypeTupleWrapper other)
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
		if (Item1 != EBulletOrMagicFieldMoveModeType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBulletOrMagicFieldMoveModeType.None)
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
		if (Item1 != EBulletOrMagicFieldMoveModeType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBulletOrMagicFieldMoveModeType.None)
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
		if (Item1 != EBulletOrMagicFieldMoveModeType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBulletOrMagicFieldMoveModeType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBulletOrMagicFieldMoveModeTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBulletOrMagicFieldMoveModeType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBulletOrMagicFieldMoveModeType.None)
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
				Item1 = (EBulletOrMagicFieldMoveModeType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBulletOrMagicFieldMoveModeType)input.ReadEnum();
				break;
			}
		}
	}
}
