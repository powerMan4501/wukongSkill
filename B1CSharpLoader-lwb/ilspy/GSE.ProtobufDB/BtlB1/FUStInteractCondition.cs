using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStInteractCondition : IMessage<FUStInteractCondition>, IMessage, IEquatable<FUStInteractCondition>, IDeepCloneable<FUStInteractCondition>
{
	private static readonly MessageParser<FUStInteractCondition> _parser = new MessageParser<FUStInteractCondition>(() => new FUStInteractCondition());

	private UnknownFieldSet _unknownFields;

	private int conditionItemID_;

	private int conditionItemNum_;

	private EGSYesNo isConsume_;

	public static MessageParser<FUStInteractCondition> Parser => _parser;

	public int ConditionItemID
	{
		get
		{
			return conditionItemID_;
		}
		set
		{
			conditionItemID_ = value;
		}
	}

	public int ConditionItemNum
	{
		get
		{
			return conditionItemNum_;
		}
		set
		{
			conditionItemNum_ = value;
		}
	}

	public EGSYesNo IsConsume
	{
		get
		{
			return isConsume_;
		}
		set
		{
			isConsume_ = value;
		}
	}

	public FUStInteractCondition()
	{
	}

	public FUStInteractCondition(FUStInteractCondition other)
		: this()
	{
		conditionItemID_ = other.conditionItemID_;
		conditionItemNum_ = other.conditionItemNum_;
		isConsume_ = other.isConsume_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStInteractCondition Clone()
	{
		return new FUStInteractCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStInteractCondition);
	}

	public bool Equals(FUStInteractCondition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConditionItemID != other.ConditionItemID)
		{
			return false;
		}
		if (ConditionItemNum != other.ConditionItemNum)
		{
			return false;
		}
		if (IsConsume != other.IsConsume)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConditionItemID != 0)
		{
			num ^= ConditionItemID.GetHashCode();
		}
		if (ConditionItemNum != 0)
		{
			num ^= ConditionItemNum.GetHashCode();
		}
		if (IsConsume != EGSYesNo.No)
		{
			num ^= IsConsume.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConditionItemID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionItemID);
		}
		if (ConditionItemNum != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ConditionItemNum);
		}
		if (IsConsume != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IsConsume);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConditionItemID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionItemID);
		}
		if (ConditionItemNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionItemNum);
		}
		if (IsConsume != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsConsume);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStInteractCondition other)
	{
		if (other != null)
		{
			if (other.ConditionItemID != 0)
			{
				ConditionItemID = other.ConditionItemID;
			}
			if (other.ConditionItemNum != 0)
			{
				ConditionItemNum = other.ConditionItemNum;
			}
			if (other.IsConsume != EGSYesNo.No)
			{
				IsConsume = other.IsConsume;
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
				ConditionItemID = input.ReadInt32();
				break;
			case 16u:
				ConditionItemNum = input.ReadInt32();
				break;
			case 24u:
				IsConsume = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
