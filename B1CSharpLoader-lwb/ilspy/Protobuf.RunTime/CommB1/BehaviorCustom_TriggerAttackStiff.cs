using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_TriggerAttackStiff : IMessage<BehaviorCustom_TriggerAttackStiff>, IMessage, IEquatable<BehaviorCustom_TriggerAttackStiff>, IDeepCloneable<BehaviorCustom_TriggerAttackStiff>
{
	private static readonly MessageParser<BehaviorCustom_TriggerAttackStiff> _parser = new MessageParser<BehaviorCustom_TriggerAttackStiff>(() => new BehaviorCustom_TriggerAttackStiff());

	private UnknownFieldSet _unknownFields;

	private int unitType_;

	private string smartUnitGuid_ = "";

	private int compareOperation_;

	private int stiffLevel_;

	private int attackerUnitType_;

	private string attackerSmartUnitGuid_ = "";

	public static MessageParser<BehaviorCustom_TriggerAttackStiff> Parser => _parser;

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

	public int StiffLevel
	{
		get
		{
			return stiffLevel_;
		}
		set
		{
			stiffLevel_ = value;
		}
	}

	public int AttackerUnitType
	{
		get
		{
			return attackerUnitType_;
		}
		set
		{
			attackerUnitType_ = value;
		}
	}

	public string AttackerSmartUnitGuid
	{
		get
		{
			return attackerSmartUnitGuid_;
		}
		set
		{
			attackerSmartUnitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_TriggerAttackStiff()
	{
	}

	public BehaviorCustom_TriggerAttackStiff(BehaviorCustom_TriggerAttackStiff other)
		: this()
	{
		unitType_ = other.unitType_;
		smartUnitGuid_ = other.smartUnitGuid_;
		compareOperation_ = other.compareOperation_;
		stiffLevel_ = other.stiffLevel_;
		attackerUnitType_ = other.attackerUnitType_;
		attackerSmartUnitGuid_ = other.attackerSmartUnitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_TriggerAttackStiff Clone()
	{
		return new BehaviorCustom_TriggerAttackStiff(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_TriggerAttackStiff);
	}

	public bool Equals(BehaviorCustom_TriggerAttackStiff other)
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
		if (CompareOperation != other.CompareOperation)
		{
			return false;
		}
		if (StiffLevel != other.StiffLevel)
		{
			return false;
		}
		if (AttackerUnitType != other.AttackerUnitType)
		{
			return false;
		}
		if (AttackerSmartUnitGuid != other.AttackerSmartUnitGuid)
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
		if (CompareOperation != 0)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (StiffLevel != 0)
		{
			num ^= StiffLevel.GetHashCode();
		}
		if (AttackerUnitType != 0)
		{
			num ^= AttackerUnitType.GetHashCode();
		}
		if (AttackerSmartUnitGuid.Length != 0)
		{
			num ^= AttackerSmartUnitGuid.GetHashCode();
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
		if (CompareOperation != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CompareOperation);
		}
		if (StiffLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(StiffLevel);
		}
		if (AttackerUnitType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(AttackerUnitType);
		}
		if (AttackerSmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(AttackerSmartUnitGuid);
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
		if (CompareOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (StiffLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StiffLevel);
		}
		if (AttackerUnitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackerUnitType);
		}
		if (AttackerSmartUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AttackerSmartUnitGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_TriggerAttackStiff other)
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
			if (other.CompareOperation != 0)
			{
				CompareOperation = other.CompareOperation;
			}
			if (other.StiffLevel != 0)
			{
				StiffLevel = other.StiffLevel;
			}
			if (other.AttackerUnitType != 0)
			{
				AttackerUnitType = other.AttackerUnitType;
			}
			if (other.AttackerSmartUnitGuid.Length != 0)
			{
				AttackerSmartUnitGuid = other.AttackerSmartUnitGuid;
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
				CompareOperation = input.ReadInt32();
				break;
			case 32u:
				StiffLevel = input.ReadInt32();
				break;
			case 40u:
				AttackerUnitType = input.ReadInt32();
				break;
			case 50u:
				AttackerSmartUnitGuid = input.ReadString();
				break;
			}
		}
	}
}
