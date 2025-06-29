using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_BeHurt : IMessage<BehaviorCustom_BeHurt>, IMessage, IEquatable<BehaviorCustom_BeHurt>, IDeepCloneable<BehaviorCustom_BeHurt>
{
	private static readonly MessageParser<BehaviorCustom_BeHurt> _parser = new MessageParser<BehaviorCustom_BeHurt>(() => new BehaviorCustom_BeHurt());

	private UnknownFieldSet _unknownFields;

	private int victimUnitType_;

	private string victimSmartUnitGuid_ = "";

	private int compareOperation_;

	private int dmgValue_;

	private int attackerUnitType_;

	private string attackerSmartUnitGuid_ = "";

	public static MessageParser<BehaviorCustom_BeHurt> Parser => _parser;

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

	public int DmgValue
	{
		get
		{
			return dmgValue_;
		}
		set
		{
			dmgValue_ = value;
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

	public BehaviorCustom_BeHurt()
	{
	}

	public BehaviorCustom_BeHurt(BehaviorCustom_BeHurt other)
		: this()
	{
		victimUnitType_ = other.victimUnitType_;
		victimSmartUnitGuid_ = other.victimSmartUnitGuid_;
		compareOperation_ = other.compareOperation_;
		dmgValue_ = other.dmgValue_;
		attackerUnitType_ = other.attackerUnitType_;
		attackerSmartUnitGuid_ = other.attackerSmartUnitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_BeHurt Clone()
	{
		return new BehaviorCustom_BeHurt(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_BeHurt);
	}

	public bool Equals(BehaviorCustom_BeHurt other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VictimUnitType != other.VictimUnitType)
		{
			return false;
		}
		if (VictimSmartUnitGuid != other.VictimSmartUnitGuid)
		{
			return false;
		}
		if (CompareOperation != other.CompareOperation)
		{
			return false;
		}
		if (DmgValue != other.DmgValue)
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
		if (VictimUnitType != 0)
		{
			num ^= VictimUnitType.GetHashCode();
		}
		if (VictimSmartUnitGuid.Length != 0)
		{
			num ^= VictimSmartUnitGuid.GetHashCode();
		}
		if (CompareOperation != 0)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (DmgValue != 0)
		{
			num ^= DmgValue.GetHashCode();
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
		if (VictimUnitType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(VictimUnitType);
		}
		if (VictimSmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(VictimSmartUnitGuid);
		}
		if (CompareOperation != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CompareOperation);
		}
		if (DmgValue != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DmgValue);
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
		if (VictimUnitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(VictimUnitType);
		}
		if (VictimSmartUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VictimSmartUnitGuid);
		}
		if (CompareOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (DmgValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgValue);
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

	public void MergeFrom(BehaviorCustom_BeHurt other)
	{
		if (other != null)
		{
			if (other.VictimUnitType != 0)
			{
				VictimUnitType = other.VictimUnitType;
			}
			if (other.VictimSmartUnitGuid.Length != 0)
			{
				VictimSmartUnitGuid = other.VictimSmartUnitGuid;
			}
			if (other.CompareOperation != 0)
			{
				CompareOperation = other.CompareOperation;
			}
			if (other.DmgValue != 0)
			{
				DmgValue = other.DmgValue;
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
				VictimUnitType = input.ReadInt32();
				break;
			case 18u:
				VictimSmartUnitGuid = input.ReadString();
				break;
			case 24u:
				CompareOperation = input.ReadInt32();
				break;
			case 32u:
				DmgValue = input.ReadInt32();
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
