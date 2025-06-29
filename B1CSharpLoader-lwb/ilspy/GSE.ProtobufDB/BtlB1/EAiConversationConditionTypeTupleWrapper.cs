using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EAiConversationConditionTypeTupleWrapper : IMessage<EAiConversationConditionTypeTupleWrapper>, IMessage, IEquatable<EAiConversationConditionTypeTupleWrapper>, IDeepCloneable<EAiConversationConditionTypeTupleWrapper>
{
	private static readonly MessageParser<EAiConversationConditionTypeTupleWrapper> _parser = new MessageParser<EAiConversationConditionTypeTupleWrapper>(() => new EAiConversationConditionTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EAiConversationConditionType item1_;

	private EAiConversationConditionType item2_;

	public static MessageParser<EAiConversationConditionTypeTupleWrapper> Parser => _parser;

	public EAiConversationConditionType Item1
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

	public EAiConversationConditionType Item2
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

	public EAiConversationConditionTypeTupleWrapper()
	{
	}

	public EAiConversationConditionTypeTupleWrapper(EAiConversationConditionTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EAiConversationConditionTypeTupleWrapper Clone()
	{
		return new EAiConversationConditionTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EAiConversationConditionTypeTupleWrapper);
	}

	public bool Equals(EAiConversationConditionTypeTupleWrapper other)
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
		if (Item1 != EAiConversationConditionType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EAiConversationConditionType.None)
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
		if (Item1 != EAiConversationConditionType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EAiConversationConditionType.None)
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
		if (Item1 != EAiConversationConditionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EAiConversationConditionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EAiConversationConditionTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EAiConversationConditionType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EAiConversationConditionType.None)
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
				Item1 = (EAiConversationConditionType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EAiConversationConditionType)input.ReadEnum();
				break;
			}
		}
	}
}
