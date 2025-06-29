using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EScreenMsgTypeTupleWrapper : IMessage<EScreenMsgTypeTupleWrapper>, IMessage, IEquatable<EScreenMsgTypeTupleWrapper>, IDeepCloneable<EScreenMsgTypeTupleWrapper>
{
	private static readonly MessageParser<EScreenMsgTypeTupleWrapper> _parser = new MessageParser<EScreenMsgTypeTupleWrapper>(() => new EScreenMsgTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EScreenMsgType item1_;

	private EScreenMsgType item2_;

	public static MessageParser<EScreenMsgTypeTupleWrapper> Parser => _parser;

	public EScreenMsgType Item1
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

	public EScreenMsgType Item2
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

	public EScreenMsgTypeTupleWrapper()
	{
	}

	public EScreenMsgTypeTupleWrapper(EScreenMsgTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EScreenMsgTypeTupleWrapper Clone()
	{
		return new EScreenMsgTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EScreenMsgTypeTupleWrapper);
	}

	public bool Equals(EScreenMsgTypeTupleWrapper other)
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
		if (Item1 != EScreenMsgType.PlayerDead)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EScreenMsgType.PlayerDead)
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
		if (Item1 != EScreenMsgType.PlayerDead)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EScreenMsgType.PlayerDead)
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
		if (Item1 != EScreenMsgType.PlayerDead)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EScreenMsgType.PlayerDead)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EScreenMsgTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EScreenMsgType.PlayerDead)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EScreenMsgType.PlayerDead)
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
				Item1 = (EScreenMsgType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EScreenMsgType)input.ReadEnum();
				break;
			}
		}
	}
}
