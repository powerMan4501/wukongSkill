using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EAITaskActionTypeTupleWrapper : IMessage<EAITaskActionTypeTupleWrapper>, IMessage, IEquatable<EAITaskActionTypeTupleWrapper>, IDeepCloneable<EAITaskActionTypeTupleWrapper>
{
	private static readonly MessageParser<EAITaskActionTypeTupleWrapper> _parser = new MessageParser<EAITaskActionTypeTupleWrapper>(() => new EAITaskActionTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EAITaskActionType item1_;

	private EAITaskActionType item2_;

	public static MessageParser<EAITaskActionTypeTupleWrapper> Parser => _parser;

	public EAITaskActionType Item1
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

	public EAITaskActionType Item2
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

	public EAITaskActionTypeTupleWrapper()
	{
	}

	public EAITaskActionTypeTupleWrapper(EAITaskActionTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EAITaskActionTypeTupleWrapper Clone()
	{
		return new EAITaskActionTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EAITaskActionTypeTupleWrapper);
	}

	public bool Equals(EAITaskActionTypeTupleWrapper other)
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
		if (Item1 != EAITaskActionType.CastSkill)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EAITaskActionType.CastSkill)
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
		if (Item1 != EAITaskActionType.CastSkill)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EAITaskActionType.CastSkill)
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
		if (Item1 != EAITaskActionType.CastSkill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EAITaskActionType.CastSkill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EAITaskActionTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EAITaskActionType.CastSkill)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EAITaskActionType.CastSkill)
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
				Item1 = (EAITaskActionType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EAITaskActionType)input.ReadEnum();
				break;
			}
		}
	}
}
