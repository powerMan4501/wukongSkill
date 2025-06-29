using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EGuideGroupTriggerTypeTupleWrapper : IMessage<EGuideGroupTriggerTypeTupleWrapper>, IMessage, IEquatable<EGuideGroupTriggerTypeTupleWrapper>, IDeepCloneable<EGuideGroupTriggerTypeTupleWrapper>
{
	private static readonly MessageParser<EGuideGroupTriggerTypeTupleWrapper> _parser = new MessageParser<EGuideGroupTriggerTypeTupleWrapper>(() => new EGuideGroupTriggerTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGuideGroupTriggerType item1_;

	private EGuideGroupTriggerType item2_;

	public static MessageParser<EGuideGroupTriggerTypeTupleWrapper> Parser => _parser;

	public EGuideGroupTriggerType Item1
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

	public EGuideGroupTriggerType Item2
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

	public EGuideGroupTriggerTypeTupleWrapper()
	{
	}

	public EGuideGroupTriggerTypeTupleWrapper(EGuideGroupTriggerTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGuideGroupTriggerTypeTupleWrapper Clone()
	{
		return new EGuideGroupTriggerTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGuideGroupTriggerTypeTupleWrapper);
	}

	public bool Equals(EGuideGroupTriggerTypeTupleWrapper other)
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
		if (Item1 != EGuideGroupTriggerType.ObtainItem)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGuideGroupTriggerType.ObtainItem)
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
		if (Item1 != EGuideGroupTriggerType.ObtainItem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGuideGroupTriggerType.ObtainItem)
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
		if (Item1 != EGuideGroupTriggerType.ObtainItem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGuideGroupTriggerType.ObtainItem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGuideGroupTriggerTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGuideGroupTriggerType.ObtainItem)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGuideGroupTriggerType.ObtainItem)
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
				Item1 = (EGuideGroupTriggerType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGuideGroupTriggerType)input.ReadEnum();
				break;
			}
		}
	}
}
