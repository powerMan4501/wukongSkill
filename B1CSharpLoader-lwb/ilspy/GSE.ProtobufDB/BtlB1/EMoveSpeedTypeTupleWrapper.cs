using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EMoveSpeedTypeTupleWrapper : IMessage<EMoveSpeedTypeTupleWrapper>, IMessage, IEquatable<EMoveSpeedTypeTupleWrapper>, IDeepCloneable<EMoveSpeedTypeTupleWrapper>
{
	private static readonly MessageParser<EMoveSpeedTypeTupleWrapper> _parser = new MessageParser<EMoveSpeedTypeTupleWrapper>(() => new EMoveSpeedTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EMoveSpeedType item1_;

	private EMoveSpeedType item2_;

	public static MessageParser<EMoveSpeedTypeTupleWrapper> Parser => _parser;

	public EMoveSpeedType Item1
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

	public EMoveSpeedType Item2
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

	public EMoveSpeedTypeTupleWrapper()
	{
	}

	public EMoveSpeedTypeTupleWrapper(EMoveSpeedTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EMoveSpeedTypeTupleWrapper Clone()
	{
		return new EMoveSpeedTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EMoveSpeedTypeTupleWrapper);
	}

	public bool Equals(EMoveSpeedTypeTupleWrapper other)
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
		if (Item1 != EMoveSpeedType.Walk)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EMoveSpeedType.Walk)
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
		if (Item1 != EMoveSpeedType.Walk)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EMoveSpeedType.Walk)
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
		if (Item1 != EMoveSpeedType.Walk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EMoveSpeedType.Walk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EMoveSpeedTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EMoveSpeedType.Walk)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EMoveSpeedType.Walk)
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
				Item1 = (EMoveSpeedType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EMoveSpeedType)input.ReadEnum();
				break;
			}
		}
	}
}
