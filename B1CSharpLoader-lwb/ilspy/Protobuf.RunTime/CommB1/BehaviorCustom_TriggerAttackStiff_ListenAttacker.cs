using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_TriggerAttackStiff_ListenAttacker : IMessage<BehaviorCustom_TriggerAttackStiff_ListenAttacker>, IMessage, IEquatable<BehaviorCustom_TriggerAttackStiff_ListenAttacker>, IDeepCloneable<BehaviorCustom_TriggerAttackStiff_ListenAttacker>
{
	private static readonly MessageParser<BehaviorCustom_TriggerAttackStiff_ListenAttacker> _parser = new MessageParser<BehaviorCustom_TriggerAttackStiff_ListenAttacker>(() => new BehaviorCustom_TriggerAttackStiff_ListenAttacker());

	private UnknownFieldSet _unknownFields;

	private int attackerUnitType_;

	private string attackerSmartUnitGuid_ = "";

	private int compareOperation_;

	private int stiffLevel_;

	private int victimUnitType_;

	private string victimSmartUnitGuid_ = "";

	public static MessageParser<BehaviorCustom_TriggerAttackStiff_ListenAttacker> Parser => _parser;

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

	public int VictimUnitType
	{
		get
		{
			return victimUnitType_;
		}
		set
		{
			victimUnitType_ = value;
		}
	}

	public string VictimSmartUnitGuid
	{
		get
		{
			return victimSmartUnitGuid_;
		}
		set
		{
			victimSmartUnitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_TriggerAttackStiff_ListenAttacker()
	{
	}

	public BehaviorCustom_TriggerAttackStiff_ListenAttacker(BehaviorCustom_TriggerAttackStiff_ListenAttacker other)
		: this()
	{
		attackerUnitType_ = other.attackerUnitType_;
		attackerSmartUnitGuid_ = other.attackerSmartUnitGuid_;
		compareOperation_ = other.compareOperation_;
		stiffLevel_ = other.stiffLevel_;
		victimUnitType_ = other.victimUnitType_;
		victimSmartUnitGuid_ = other.victimSmartUnitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_TriggerAttackStiff_ListenAttacker Clone()
	{
		return new BehaviorCustom_TriggerAttackStiff_ListenAttacker(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_TriggerAttackStiff_ListenAttacker);
	}

	public bool Equals(BehaviorCustom_TriggerAttackStiff_ListenAttacker other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AttackerUnitType != other.AttackerUnitType)
		{
			return false;
		}
		if (AttackerSmartUnitGuid != other.AttackerSmartUnitGuid)
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
		if (VictimUnitType != other.VictimUnitType)
		{
			return false;
		}
		if (VictimSmartUnitGuid != other.VictimSmartUnitGuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AttackerUnitType != 0)
		{
			num ^= AttackerUnitType.GetHashCode();
		}
		if (AttackerSmartUnitGuid.Length != 0)
		{
			num ^= AttackerSmartUnitGuid.GetHashCode();
		}
		if (CompareOperation != 0)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (StiffLevel != 0)
		{
			num ^= StiffLevel.GetHashCode();
		}
		if (VictimUnitType != 0)
		{
			num ^= VictimUnitType.GetHashCode();
		}
		if (VictimSmartUnitGuid.Length != 0)
		{
			num ^= VictimSmartUnitGuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AttackerUnitType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AttackerUnitType);
		}
		if (AttackerSmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AttackerSmartUnitGuid);
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
		if (VictimUnitType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(VictimUnitType);
		}
		if (VictimSmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(VictimSmartUnitGuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AttackerUnitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackerUnitType);
		}
		if (AttackerSmartUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AttackerSmartUnitGuid);
		}
		if (CompareOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (StiffLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StiffLevel);
		}
		if (VictimUnitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(VictimUnitType);
		}
		if (VictimSmartUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VictimSmartUnitGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_TriggerAttackStiff_ListenAttacker other)
	{
		if (other != null)
		{
			if (other.AttackerUnitType != 0)
			{
				AttackerUnitType = other.AttackerUnitType;
			}
			if (other.AttackerSmartUnitGuid.Length != 0)
			{
				AttackerSmartUnitGuid = other.AttackerSmartUnitGuid;
			}
			if (other.CompareOperation != 0)
			{
				CompareOperation = other.CompareOperation;
			}
			if (other.StiffLevel != 0)
			{
				StiffLevel = other.StiffLevel;
			}
			if (other.VictimUnitType != 0)
			{
				VictimUnitType = other.VictimUnitType;
			}
			if (other.VictimSmartUnitGuid.Length != 0)
			{
				VictimSmartUnitGuid = other.VictimSmartUnitGuid;
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
				AttackerUnitType = input.ReadInt32();
				break;
			case 18u:
				AttackerSmartUnitGuid = input.ReadString();
				break;
			case 24u:
				CompareOperation = input.ReadInt32();
				break;
			case 32u:
				StiffLevel = input.ReadInt32();
				break;
			case 40u:
				VictimUnitType = input.ReadInt32();
				break;
			case 50u:
				VictimSmartUnitGuid = input.ReadString();
				break;
			}
		}
	}
}
