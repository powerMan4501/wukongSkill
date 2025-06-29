using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ECtrlActionTypeTupleWrapper : IMessage<ECtrlActionTypeTupleWrapper>, IMessage, IEquatable<ECtrlActionTypeTupleWrapper>, IDeepCloneable<ECtrlActionTypeTupleWrapper>
{
	private static readonly MessageParser<ECtrlActionTypeTupleWrapper> _parser = new MessageParser<ECtrlActionTypeTupleWrapper>(() => new ECtrlActionTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ECtrlActionType item1_;

	private ECtrlActionType item2_;

	public static MessageParser<ECtrlActionTypeTupleWrapper> Parser => _parser;

	public ECtrlActionType Item1
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

	public ECtrlActionType Item2
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

	public ECtrlActionTypeTupleWrapper()
	{
	}

	public ECtrlActionTypeTupleWrapper(ECtrlActionTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ECtrlActionTypeTupleWrapper Clone()
	{
		return new ECtrlActionTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ECtrlActionTypeTupleWrapper);
	}

	public bool Equals(ECtrlActionTypeTupleWrapper other)
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
		if (Item1 != ECtrlActionType.CatNone)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ECtrlActionType.CatNone)
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
		if (Item1 != ECtrlActionType.CatNone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ECtrlActionType.CatNone)
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
		if (Item1 != ECtrlActionType.CatNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ECtrlActionType.CatNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ECtrlActionTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ECtrlActionType.CatNone)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ECtrlActionType.CatNone)
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
				Item1 = (ECtrlActionType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ECtrlActionType)input.ReadEnum();
				break;
			}
		}
	}
}
