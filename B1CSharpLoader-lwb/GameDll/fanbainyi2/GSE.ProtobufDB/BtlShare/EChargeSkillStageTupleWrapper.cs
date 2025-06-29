using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EChargeSkillStageTupleWrapper : IMessage<EChargeSkillStageTupleWrapper>, IMessage, IEquatable<EChargeSkillStageTupleWrapper>, IDeepCloneable<EChargeSkillStageTupleWrapper>
{
	private static readonly MessageParser<EChargeSkillStageTupleWrapper> _parser = new MessageParser<EChargeSkillStageTupleWrapper>(() => new EChargeSkillStageTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EChargeSkillStage item1_;

	private EChargeSkillStage item2_;

	public static MessageParser<EChargeSkillStageTupleWrapper> Parser => _parser;

	public EChargeSkillStage Item1
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

	public EChargeSkillStage Item2
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

	public EChargeSkillStageTupleWrapper()
	{
	}

	public EChargeSkillStageTupleWrapper(EChargeSkillStageTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EChargeSkillStageTupleWrapper Clone()
	{
		return new EChargeSkillStageTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EChargeSkillStageTupleWrapper);
	}

	public bool Equals(EChargeSkillStageTupleWrapper other)
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
		if (Item1 != EChargeSkillStage.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EChargeSkillStage.None)
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
		if (Item1 != EChargeSkillStage.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EChargeSkillStage.None)
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
		if (Item1 != EChargeSkillStage.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EChargeSkillStage.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EChargeSkillStageTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EChargeSkillStage.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EChargeSkillStage.None)
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
				Item1 = (EChargeSkillStage)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EChargeSkillStage)input.ReadEnum();
				break;
			}
		}
	}
}
