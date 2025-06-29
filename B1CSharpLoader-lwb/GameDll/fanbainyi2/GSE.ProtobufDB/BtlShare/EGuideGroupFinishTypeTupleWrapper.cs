using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EGuideGroupFinishTypeTupleWrapper : IMessage<EGuideGroupFinishTypeTupleWrapper>, IMessage, IEquatable<EGuideGroupFinishTypeTupleWrapper>, IDeepCloneable<EGuideGroupFinishTypeTupleWrapper>
{
	private static readonly MessageParser<EGuideGroupFinishTypeTupleWrapper> _parser = new MessageParser<EGuideGroupFinishTypeTupleWrapper>(() => new EGuideGroupFinishTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGuideGroupFinishType item1_;

	private EGuideGroupFinishType item2_;

	public static MessageParser<EGuideGroupFinishTypeTupleWrapper> Parser => _parser;

	public EGuideGroupFinishType Item1
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

	public EGuideGroupFinishType Item2
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

	public EGuideGroupFinishTypeTupleWrapper()
	{
	}

	public EGuideGroupFinishTypeTupleWrapper(EGuideGroupFinishTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGuideGroupFinishTypeTupleWrapper Clone()
	{
		return new EGuideGroupFinishTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGuideGroupFinishTypeTupleWrapper);
	}

	public bool Equals(EGuideGroupFinishTypeTupleWrapper other)
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
		if (Item1 != EGuideGroupFinishType.Confirm)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGuideGroupFinishType.Confirm)
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
		if (Item1 != EGuideGroupFinishType.Confirm)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGuideGroupFinishType.Confirm)
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
		if (Item1 != EGuideGroupFinishType.Confirm)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGuideGroupFinishType.Confirm)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGuideGroupFinishTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGuideGroupFinishType.Confirm)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGuideGroupFinishType.Confirm)
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
				Item1 = (EGuideGroupFinishType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGuideGroupFinishType)input.ReadEnum();
				break;
			}
		}
	}
}
