using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_BeAttackedNumFromSkill : IMessage<BehaviorCustom_BeAttackedNumFromSkill>, IMessage, IEquatable<BehaviorCustom_BeAttackedNumFromSkill>, IDeepCloneable<BehaviorCustom_BeAttackedNumFromSkill>
{
	private static readonly MessageParser<BehaviorCustom_BeAttackedNumFromSkill> _parser = new MessageParser<BehaviorCustom_BeAttackedNumFromSkill>(() => new BehaviorCustom_BeAttackedNumFromSkill());

	private UnknownFieldSet _unknownFields;

	private int unitType_;

	private string smartUnitGuid_ = "";

	private int skillId_;

	private int compareOperation_;

	private int beHittedNum_;

	private float timeDuration_;

	public static MessageParser<BehaviorCustom_BeAttackedNumFromSkill> Parser => _parser;

	public int UnitType
	{
		get
		{
			return unitType_;
		}
		set
		{
			unitType_ = value;
		}
	}

	public string SmartUnitGuid
	{
		get
		{
			return smartUnitGuid_;
		}
		set
		{
			smartUnitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	public int CompareOperation
	{
		get
		{
			return compareOperation_;
		}
		set
		{
			compareOperation_ = value;
		}
	}

	public int BeHittedNum
	{
		get
		{
			return beHittedNum_;
		}
		set
		{
			beHittedNum_ = value;
		}
	}

	public float TimeDuration
	{
		get
		{
			return timeDuration_;
		}
		set
		{
			timeDuration_ = value;
		}
	}

	public BehaviorCustom_BeAttackedNumFromSkill()
	{
	}

	public BehaviorCustom_BeAttackedNumFromSkill(BehaviorCustom_BeAttackedNumFromSkill other)
		: this()
	{
		unitType_ = other.unitType_;
		smartUnitGuid_ = other.smartUnitGuid_;
		skillId_ = other.skillId_;
		compareOperation_ = other.compareOperation_;
		beHittedNum_ = other.beHittedNum_;
		timeDuration_ = other.timeDuration_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_BeAttackedNumFromSkill Clone()
	{
		return new BehaviorCustom_BeAttackedNumFromSkill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_BeAttackedNumFromSkill);
	}

	public bool Equals(BehaviorCustom_BeAttackedNumFromSkill other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitType != other.UnitType)
		{
			return false;
		}
		if (SmartUnitGuid != other.SmartUnitGuid)
		{
			return false;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (CompareOperation != other.CompareOperation)
		{
			return false;
		}
		if (BeHittedNum != other.BeHittedNum)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TimeDuration, other.TimeDuration))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitType != 0)
		{
			num ^= UnitType.GetHashCode();
		}
		if (SmartUnitGuid.Length != 0)
		{
			num ^= SmartUnitGuid.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (CompareOperation != 0)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (BeHittedNum != 0)
		{
			num ^= BeHittedNum.GetHashCode();
		}
		if (TimeDuration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TimeDuration);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UnitType);
		}
		if (SmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SmartUnitGuid);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SkillId);
		}
		if (CompareOperation != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CompareOperation);
		}
		if (BeHittedNum != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BeHittedNum);
		}
		if (TimeDuration != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(TimeDuration);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitType);
		}
		if (SmartUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SmartUnitGuid);
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (CompareOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (BeHittedNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BeHittedNum);
		}
		if (TimeDuration != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_BeAttackedNumFromSkill other)
	{
		if (other != null)
		{
			if (other.UnitType != 0)
			{
				UnitType = other.UnitType;
			}
			if (other.SmartUnitGuid.Length != 0)
			{
				SmartUnitGuid = other.SmartUnitGuid;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.CompareOperation != 0)
			{
				CompareOperation = other.CompareOperation;
			}
			if (other.BeHittedNum != 0)
			{
				BeHittedNum = other.BeHittedNum;
			}
			if (other.TimeDuration != 0f)
			{
				TimeDuration = other.TimeDuration;
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
				UnitType = input.ReadInt32();
				break;
			case 18u:
				SmartUnitGuid = input.ReadString();
				break;
			case 24u:
				SkillId = input.ReadInt32();
				break;
			case 32u:
				CompareOperation = input.ReadInt32();
				break;
			case 40u:
				BeHittedNum = input.ReadInt32();
				break;
			case 53u:
				TimeDuration = input.ReadFloat();
				break;
			}
		}
	}
}
