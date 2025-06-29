using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBGUBulletTypeTupleWrapper : IMessage<EBGUBulletTypeTupleWrapper>, IMessage, IEquatable<EBGUBulletTypeTupleWrapper>, IDeepCloneable<EBGUBulletTypeTupleWrapper>
{
	private static readonly MessageParser<EBGUBulletTypeTupleWrapper> _parser = new MessageParser<EBGUBulletTypeTupleWrapper>(() => new EBGUBulletTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBGUBulletType item1_;

	private EBGUBulletType item2_;

	public static MessageParser<EBGUBulletTypeTupleWrapper> Parser => _parser;

	public EBGUBulletType Item1
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

	public EBGUBulletType Item2
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

	public EBGUBulletTypeTupleWrapper()
	{
	}

	public EBGUBulletTypeTupleWrapper(EBGUBulletTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBGUBulletTypeTupleWrapper Clone()
	{
		return new EBGUBulletTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBGUBulletTypeTupleWrapper);
	}

	public bool Equals(EBGUBulletTypeTupleWrapper other)
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
		if (Item1 != EBGUBulletType.NormalSpawn)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBGUBulletType.NormalSpawn)
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
		if (Item1 != EBGUBulletType.NormalSpawn)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBGUBulletType.NormalSpawn)
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
		if (Item1 != EBGUBulletType.NormalSpawn)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBGUBulletType.NormalSpawn)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBGUBulletTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBGUBulletType.NormalSpawn)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBGUBulletType.NormalSpawn)
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
				Item1 = (EBGUBulletType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBGUBulletType)input.ReadEnum();
				break;
			}
		}
	}
}
