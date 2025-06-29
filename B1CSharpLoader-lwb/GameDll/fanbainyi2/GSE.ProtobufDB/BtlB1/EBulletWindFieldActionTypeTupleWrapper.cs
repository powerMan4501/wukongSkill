using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EBulletWindFieldActionTypeTupleWrapper : IMessage<EBulletWindFieldActionTypeTupleWrapper>, IMessage, IEquatable<EBulletWindFieldActionTypeTupleWrapper>, IDeepCloneable<EBulletWindFieldActionTypeTupleWrapper>
{
	private static readonly MessageParser<EBulletWindFieldActionTypeTupleWrapper> _parser = new MessageParser<EBulletWindFieldActionTypeTupleWrapper>(() => new EBulletWindFieldActionTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBulletWindFieldActionType item1_;

	private EBulletWindFieldActionType item2_;

	public static MessageParser<EBulletWindFieldActionTypeTupleWrapper> Parser => _parser;

	public EBulletWindFieldActionType Item1
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

	public EBulletWindFieldActionType Item2
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

	public EBulletWindFieldActionTypeTupleWrapper()
	{
	}

	public EBulletWindFieldActionTypeTupleWrapper(EBulletWindFieldActionTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBulletWindFieldActionTypeTupleWrapper Clone()
	{
		return new EBulletWindFieldActionTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBulletWindFieldActionTypeTupleWrapper);
	}

	public bool Equals(EBulletWindFieldActionTypeTupleWrapper other)
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
		if (Item1 != EBulletWindFieldActionType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBulletWindFieldActionType.None)
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
		if (Item1 != EBulletWindFieldActionType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBulletWindFieldActionType.None)
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
		if (Item1 != EBulletWindFieldActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBulletWindFieldActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBulletWindFieldActionTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBulletWindFieldActionType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBulletWindFieldActionType.None)
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
				Item1 = (EBulletWindFieldActionType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBulletWindFieldActionType)input.ReadEnum();
				break;
			}
		}
	}
}
