using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_TriggerUnitBattleConfig : IMessage<CalliopeCustom_TriggerUnitBattleConfig>, IMessage, IEquatable<CalliopeCustom_TriggerUnitBattleConfig>, IDeepCloneable<CalliopeCustom_TriggerUnitBattleConfig>
{
	private static readonly MessageParser<CalliopeCustom_TriggerUnitBattleConfig> _parser = new MessageParser<CalliopeCustom_TriggerUnitBattleConfig>(() => new CalliopeCustom_TriggerUnitBattleConfig());

	private UnknownFieldSet _unknownFields;

	private string unitGuid_ = "";

	private int switchTeamId_;

	private string targetGuid_ = "";

	public static MessageParser<CalliopeCustom_TriggerUnitBattleConfig> Parser => _parser;

	public string UnitGuid
	{
		get
		{
			return unitGuid_;
		}
		set
		{
			unitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SwitchTeamId
	{
		get
		{
			return switchTeamId_;
		}
		set
		{
			switchTeamId_ = value;
		}
	}

	public string TargetGuid
	{
		get
		{
			return targetGuid_;
		}
		set
		{
			targetGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeCustom_TriggerUnitBattleConfig()
	{
	}

	public CalliopeCustom_TriggerUnitBattleConfig(CalliopeCustom_TriggerUnitBattleConfig other)
		: this()
	{
		unitGuid_ = other.unitGuid_;
		switchTeamId_ = other.switchTeamId_;
		targetGuid_ = other.targetGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_TriggerUnitBattleConfig Clone()
	{
		return new CalliopeCustom_TriggerUnitBattleConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_TriggerUnitBattleConfig);
	}

	public bool Equals(CalliopeCustom_TriggerUnitBattleConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (SwitchTeamId != other.SwitchTeamId)
		{
			return false;
		}
		if (TargetGuid != other.TargetGuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (SwitchTeamId != 0)
		{
			num ^= SwitchTeamId.GetHashCode();
		}
		if (TargetGuid.Length != 0)
		{
			num ^= TargetGuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(UnitGuid);
		}
		if (SwitchTeamId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SwitchTeamId);
		}
		if (TargetGuid.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TargetGuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (SwitchTeamId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SwitchTeamId);
		}
		if (TargetGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TargetGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_TriggerUnitBattleConfig other)
	{
		if (other != null)
		{
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.SwitchTeamId != 0)
			{
				SwitchTeamId = other.SwitchTeamId;
			}
			if (other.TargetGuid.Length != 0)
			{
				TargetGuid = other.TargetGuid;
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
			case 10u:
				UnitGuid = input.ReadString();
				break;
			case 16u:
				SwitchTeamId = input.ReadInt32();
				break;
			case 26u:
				TargetGuid = input.ReadString();
				break;
			}
		}
	}
}
