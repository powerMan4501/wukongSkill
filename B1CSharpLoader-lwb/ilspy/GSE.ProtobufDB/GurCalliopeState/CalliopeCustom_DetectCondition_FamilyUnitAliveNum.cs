using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_FamilyUnitAliveNum : IMessage<CalliopeCustom_DetectCondition_FamilyUnitAliveNum>, IMessage, IEquatable<CalliopeCustom_DetectCondition_FamilyUnitAliveNum>, IDeepCloneable<CalliopeCustom_DetectCondition_FamilyUnitAliveNum>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_FamilyUnitAliveNum> _parser = new MessageParser<CalliopeCustom_DetectCondition_FamilyUnitAliveNum>(() => new CalliopeCustom_DetectCondition_FamilyUnitAliveNum());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private CalliopeCustom_FTamerFamilyMatchChildInfo matchInfo_;

	private int compareOperation_;

	private int aliveUnitNum_;

	public static MessageParser<CalliopeCustom_DetectCondition_FamilyUnitAliveNum> Parser => _parser;

	public CalliopeCustom_FTamerFamilyMatchChildInfo MatchInfo
	{
		get
		{
			return matchInfo_;
		}
		set
		{
			matchInfo_ = value;
		}
	}

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

	public int AliveUnitNum
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return aliveUnitNum_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			aliveUnitNum_ = value;
		}
	}

	public bool HasAliveUnitNum => (_hasBits0 & 2) != 0;

	public CalliopeCustom_DetectCondition_FamilyUnitAliveNum()
	{
	}

	public CalliopeCustom_DetectCondition_FamilyUnitAliveNum(CalliopeCustom_DetectCondition_FamilyUnitAliveNum other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		matchInfo_ = ((other.matchInfo_ != null) ? other.matchInfo_.Clone() : null);
		compareOperation_ = other.compareOperation_;
		aliveUnitNum_ = other.aliveUnitNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_FamilyUnitAliveNum Clone()
	{
		return new CalliopeCustom_DetectCondition_FamilyUnitAliveNum(this);
	}

	public void ClearCompareOperation()
	{
		_hasBits0 &= -2;
	}

	public void ClearAliveUnitNum()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_FamilyUnitAliveNum);
	}

	public bool Equals(CalliopeCustom_DetectCondition_FamilyUnitAliveNum other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MatchInfo, other.MatchInfo))
		{
			return false;
		}
		if (CompareOperation != other.CompareOperation)
		{
			return false;
		}
		if (AliveUnitNum != other.AliveUnitNum)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (matchInfo_ != null)
		{
			num ^= MatchInfo.GetHashCode();
		}
		if (HasCompareOperation)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (HasAliveUnitNum)
		{
			num ^= AliveUnitNum.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (matchInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MatchInfo);
		}
		if (HasCompareOperation)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CompareOperation);
		}
		if (HasAliveUnitNum)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AliveUnitNum);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (matchInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MatchInfo);
		}
		if (HasCompareOperation)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (HasAliveUnitNum)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AliveUnitNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_FamilyUnitAliveNum other)
	{
		if (other == null)
		{
			return;
		}
		if (other.matchInfo_ != null)
		{
			if (matchInfo_ == null)
			{
				MatchInfo = new CalliopeCustom_FTamerFamilyMatchChildInfo();
			}
			MatchInfo.MergeFrom(other.MatchInfo);
		}
		if (other.HasCompareOperation)
		{
			CompareOperation = other.CompareOperation;
		}
		if (other.HasAliveUnitNum)
		{
			AliveUnitNum = other.AliveUnitNum;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (matchInfo_ == null)
				{
					MatchInfo = new CalliopeCustom_FTamerFamilyMatchChildInfo();
				}
				input.ReadMessage(MatchInfo);
				break;
			case 16u:
				CompareOperation = input.ReadInt32();
				break;
			case 24u:
				AliveUnitNum = input.ReadInt32();
				break;
			}
		}
	}
}
