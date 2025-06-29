using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_BeKilled : IMessage<BehaviorCustom_BeKilled>, IMessage, IEquatable<BehaviorCustom_BeKilled>, IDeepCloneable<BehaviorCustom_BeKilled>
{
	private static readonly MessageParser<BehaviorCustom_BeKilled> _parser = new MessageParser<BehaviorCustom_BeKilled>(() => new BehaviorCustom_BeKilled());

	private UnknownFieldSet _unknownFields;

	private int victimUnitType_;

	private string victimSmartUnitGuid_ = "";

	private int attackerUnitType_;

	private string attackerSmartUnitGuid_ = "";

	public static MessageParser<BehaviorCustom_BeKilled> Parser => _parser;

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

	public BehaviorCustom_BeKilled()
	{
	}

	public BehaviorCustom_BeKilled(BehaviorCustom_BeKilled other)
		: this()
	{
		victimUnitType_ = other.victimUnitType_;
		victimSmartUnitGuid_ = other.victimSmartUnitGuid_;
		attackerUnitType_ = other.attackerUnitType_;
		attackerSmartUnitGuid_ = other.attackerSmartUnitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_BeKilled Clone()
	{
		return new BehaviorCustom_BeKilled(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_BeKilled);
	}

	public bool Equals(BehaviorCustom_BeKilled other)
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
		if (AttackerUnitType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AttackerUnitType);
		}
		if (AttackerSmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(34);
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

	public void MergeFrom(BehaviorCustom_BeKilled other)
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
				AttackerUnitType = input.ReadInt32();
				break;
			case 34u:
				AttackerSmartUnitGuid = input.ReadString();
				break;
			}
		}
	}
}
