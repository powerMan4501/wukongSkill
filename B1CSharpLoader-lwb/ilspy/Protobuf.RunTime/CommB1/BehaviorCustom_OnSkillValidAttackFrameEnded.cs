using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_OnSkillValidAttackFrameEnded : IMessage<BehaviorCustom_OnSkillValidAttackFrameEnded>, IMessage, IEquatable<BehaviorCustom_OnSkillValidAttackFrameEnded>, IDeepCloneable<BehaviorCustom_OnSkillValidAttackFrameEnded>
{
	private static readonly MessageParser<BehaviorCustom_OnSkillValidAttackFrameEnded> _parser = new MessageParser<BehaviorCustom_OnSkillValidAttackFrameEnded>(() => new BehaviorCustom_OnSkillValidAttackFrameEnded());

	private UnknownFieldSet _unknownFields;

	private int unitType_;

	private string smartUnitGuid_ = "";

	private int skillId_;

	public static MessageParser<BehaviorCustom_OnSkillValidAttackFrameEnded> Parser => _parser;

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

	public BehaviorCustom_OnSkillValidAttackFrameEnded()
	{
	}

	public BehaviorCustom_OnSkillValidAttackFrameEnded(BehaviorCustom_OnSkillValidAttackFrameEnded other)
		: this()
	{
		unitType_ = other.unitType_;
		smartUnitGuid_ = other.smartUnitGuid_;
		skillId_ = other.skillId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_OnSkillValidAttackFrameEnded Clone()
	{
		return new BehaviorCustom_OnSkillValidAttackFrameEnded(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_OnSkillValidAttackFrameEnded);
	}

	public bool Equals(BehaviorCustom_OnSkillValidAttackFrameEnded other)
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_OnSkillValidAttackFrameEnded other)
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
			}
		}
	}
}
