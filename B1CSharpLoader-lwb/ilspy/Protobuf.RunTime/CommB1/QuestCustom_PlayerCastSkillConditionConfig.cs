using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_PlayerCastSkillConditionConfig : IMessage<QuestCustom_PlayerCastSkillConditionConfig>, IMessage, IEquatable<QuestCustom_PlayerCastSkillConditionConfig>, IDeepCloneable<QuestCustom_PlayerCastSkillConditionConfig>
{
	private static readonly MessageParser<QuestCustom_PlayerCastSkillConditionConfig> _parser = new MessageParser<QuestCustom_PlayerCastSkillConditionConfig>(() => new QuestCustom_PlayerCastSkillConditionConfig());

	private UnknownFieldSet _unknownFields;

	private int conditionType_;

	private int attrType_;

	private int unitState_;

	private int compareOperation_;

	private float floatValue_;

	private int intValue_;

	private bool inverseCondition_;

	public static MessageParser<QuestCustom_PlayerCastSkillConditionConfig> Parser => _parser;

	public int ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

	public int AttrType
	{
		get
		{
			return attrType_;
		}
		set
		{
			attrType_ = value;
		}
	}

	public int UnitState
	{
		get
		{
			return unitState_;
		}
		set
		{
			unitState_ = value;
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

	public float FloatValue
	{
		get
		{
			return floatValue_;
		}
		set
		{
			floatValue_ = value;
		}
	}

	public int IntValue
	{
		get
		{
			return intValue_;
		}
		set
		{
			intValue_ = value;
		}
	}

	public bool InverseCondition
	{
		get
		{
			return inverseCondition_;
		}
		set
		{
			inverseCondition_ = value;
		}
	}

	public QuestCustom_PlayerCastSkillConditionConfig()
	{
	}

	public QuestCustom_PlayerCastSkillConditionConfig(QuestCustom_PlayerCastSkillConditionConfig other)
		: this()
	{
		conditionType_ = other.conditionType_;
		attrType_ = other.attrType_;
		unitState_ = other.unitState_;
		compareOperation_ = other.compareOperation_;
		floatValue_ = other.floatValue_;
		intValue_ = other.intValue_;
		inverseCondition_ = other.inverseCondition_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayerCastSkillConditionConfig Clone()
	{
		return new QuestCustom_PlayerCastSkillConditionConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayerCastSkillConditionConfig);
	}

	public bool Equals(QuestCustom_PlayerCastSkillConditionConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConditionType != other.ConditionType)
		{
			return false;
		}
		if (AttrType != other.AttrType)
		{
			return false;
		}
		if (UnitState != other.UnitState)
		{
			return false;
		}
		if (CompareOperation != other.CompareOperation)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatValue, other.FloatValue))
		{
			return false;
		}
		if (IntValue != other.IntValue)
		{
			return false;
		}
		if (InverseCondition != other.InverseCondition)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (AttrType != 0)
		{
			num ^= AttrType.GetHashCode();
		}
		if (UnitState != 0)
		{
			num ^= UnitState.GetHashCode();
		}
		if (CompareOperation != 0)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (FloatValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatValue);
		}
		if (IntValue != 0)
		{
			num ^= IntValue.GetHashCode();
		}
		if (InverseCondition)
		{
			num ^= InverseCondition.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConditionType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionType);
		}
		if (AttrType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AttrType);
		}
		if (UnitState != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UnitState);
		}
		if (CompareOperation != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CompareOperation);
		}
		if (FloatValue != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(FloatValue);
		}
		if (IntValue != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(IntValue);
		}
		if (InverseCondition)
		{
			output.WriteRawTag(56);
			output.WriteBool(InverseCondition);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		if (AttrType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrType);
		}
		if (UnitState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitState);
		}
		if (CompareOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (FloatValue != 0f)
		{
			num += 5;
		}
		if (IntValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IntValue);
		}
		if (InverseCondition)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PlayerCastSkillConditionConfig other)
	{
		if (other != null)
		{
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.AttrType != 0)
			{
				AttrType = other.AttrType;
			}
			if (other.UnitState != 0)
			{
				UnitState = other.UnitState;
			}
			if (other.CompareOperation != 0)
			{
				CompareOperation = other.CompareOperation;
			}
			if (other.FloatValue != 0f)
			{
				FloatValue = other.FloatValue;
			}
			if (other.IntValue != 0)
			{
				IntValue = other.IntValue;
			}
			if (other.InverseCondition)
			{
				InverseCondition = other.InverseCondition;
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
				ConditionType = input.ReadInt32();
				break;
			case 16u:
				AttrType = input.ReadInt32();
				break;
			case 24u:
				UnitState = input.ReadInt32();
				break;
			case 32u:
				CompareOperation = input.ReadInt32();
				break;
			case 45u:
				FloatValue = input.ReadFloat();
				break;
			case 48u:
				IntValue = input.ReadInt32();
				break;
			case 56u:
				InverseCondition = input.ReadBool();
				break;
			}
		}
	}
}
