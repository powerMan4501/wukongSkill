using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel : IMessage<CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel>, IMessage, IEquatable<CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel>, IDeepCloneable<CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel> _parser = new MessageParser<CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel>(() => new CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int compareOperation_;

	private int compareValueInt_;

	public static MessageParser<CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel> Parser => _parser;

	public int CompareOperation
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return compareOperation_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			compareOperation_ = value;
		}
	}

	public bool HasCompareOperation => (_hasBits0 & 1) != 0;

	public int CompareValueInt
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return compareValueInt_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			compareValueInt_ = value;
		}
	}

	public bool HasCompareValueInt => (_hasBits0 & 2) != 0;

	public CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel()
	{
	}

	public CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel(CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		compareOperation_ = other.compareOperation_;
		compareValueInt_ = other.compareValueInt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel Clone()
	{
		return new CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel(this);
	}

	public void ClearCompareOperation()
	{
		_hasBits0 &= -2;
	}

	public void ClearCompareValueInt()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel);
	}

	public bool Equals(CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CompareOperation != other.CompareOperation)
		{
			return false;
		}
		if (CompareValueInt != other.CompareValueInt)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasCompareOperation)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (HasCompareValueInt)
		{
			num ^= CompareValueInt.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasCompareOperation)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CompareOperation);
		}
		if (HasCompareValueInt)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CompareValueInt);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasCompareOperation)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (HasCompareValueInt)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareValueInt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel other)
	{
		if (other != null)
		{
			if (other.HasCompareOperation)
			{
				CompareOperation = other.CompareOperation;
			}
			if (other.HasCompareValueInt)
			{
				CompareValueInt = other.CompareValueInt;
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
				CompareOperation = input.ReadInt32();
				break;
			case 16u:
				CompareValueInt = input.ReadInt32();
				break;
			}
		}
	}
}
