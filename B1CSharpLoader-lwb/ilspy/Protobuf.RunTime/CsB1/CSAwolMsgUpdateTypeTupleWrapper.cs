using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSAwolMsgUpdateTypeTupleWrapper : IMessage<CSAwolMsgUpdateTypeTupleWrapper>, IMessage, IEquatable<CSAwolMsgUpdateTypeTupleWrapper>, IDeepCloneable<CSAwolMsgUpdateTypeTupleWrapper>
{
	private static readonly MessageParser<CSAwolMsgUpdateTypeTupleWrapper> _parser = new MessageParser<CSAwolMsgUpdateTypeTupleWrapper>(() => new CSAwolMsgUpdateTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private CSAwolMsgUpdateType item1_;

	private CSAwolMsgUpdateType item2_;

	public static MessageParser<CSAwolMsgUpdateTypeTupleWrapper> Parser => _parser;

	public CSAwolMsgUpdateType Item1
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

	public CSAwolMsgUpdateType Item2
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

	public CSAwolMsgUpdateTypeTupleWrapper()
	{
	}

	public CSAwolMsgUpdateTypeTupleWrapper(CSAwolMsgUpdateTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSAwolMsgUpdateTypeTupleWrapper Clone()
	{
		return new CSAwolMsgUpdateTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSAwolMsgUpdateTypeTupleWrapper);
	}

	public bool Equals(CSAwolMsgUpdateTypeTupleWrapper other)
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
		if (Item1 != CSAwolMsgUpdateType.CsAwolmsgOpNone)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != CSAwolMsgUpdateType.CsAwolmsgOpNone)
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
		if (Item1 != CSAwolMsgUpdateType.CsAwolmsgOpNone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != CSAwolMsgUpdateType.CsAwolmsgOpNone)
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
		if (Item1 != CSAwolMsgUpdateType.CsAwolmsgOpNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != CSAwolMsgUpdateType.CsAwolmsgOpNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSAwolMsgUpdateTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != CSAwolMsgUpdateType.CsAwolmsgOpNone)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != CSAwolMsgUpdateType.CsAwolmsgOpNone)
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
				Item1 = (CSAwolMsgUpdateType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (CSAwolMsgUpdateType)input.ReadEnum();
				break;
			}
		}
	}
}
