using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_BattleStartCondition : IMessage<CalliopeCustom_BattleStartCondition>, IMessage, IEquatable<CalliopeCustom_BattleStartCondition>, IDeepCloneable<CalliopeCustom_BattleStartCondition>
{
	private static readonly MessageParser<CalliopeCustom_BattleStartCondition> _parser = new MessageParser<CalliopeCustom_BattleStartCondition>(() => new CalliopeCustom_BattleStartCondition());

	private UnknownFieldSet _unknownFields;

	private int startConditionType_;

	private string unitGuid_ = "";

	private string spawnerGuid_ = "";

	private string overlapGuid_ = "";

	public static MessageParser<CalliopeCustom_BattleStartCondition> Parser => _parser;

	public int StartConditionType
	{
		get
		{
			return startConditionType_;
		}
		set
		{
			startConditionType_ = value;
		}
	}

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

	public string SpawnerGuid
	{
		get
		{
			return spawnerGuid_;
		}
		set
		{
			spawnerGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string OverlapGuid
	{
		get
		{
			return overlapGuid_;
		}
		set
		{
			overlapGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeCustom_BattleStartCondition()
	{
	}

	public CalliopeCustom_BattleStartCondition(CalliopeCustom_BattleStartCondition other)
		: this()
	{
		startConditionType_ = other.startConditionType_;
		unitGuid_ = other.unitGuid_;
		spawnerGuid_ = other.spawnerGuid_;
		overlapGuid_ = other.overlapGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_BattleStartCondition Clone()
	{
		return new CalliopeCustom_BattleStartCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_BattleStartCondition);
	}

	public bool Equals(CalliopeCustom_BattleStartCondition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StartConditionType != other.StartConditionType)
		{
			return false;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (SpawnerGuid != other.SpawnerGuid)
		{
			return false;
		}
		if (OverlapGuid != other.OverlapGuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (StartConditionType != 0)
		{
			num ^= StartConditionType.GetHashCode();
		}
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (SpawnerGuid.Length != 0)
		{
			num ^= SpawnerGuid.GetHashCode();
		}
		if (OverlapGuid.Length != 0)
		{
			num ^= OverlapGuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (StartConditionType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(StartConditionType);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UnitGuid);
		}
		if (SpawnerGuid.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(SpawnerGuid);
		}
		if (OverlapGuid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(OverlapGuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (StartConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StartConditionType);
		}
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (SpawnerGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SpawnerGuid);
		}
		if (OverlapGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OverlapGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_BattleStartCondition other)
	{
		if (other != null)
		{
			if (other.StartConditionType != 0)
			{
				StartConditionType = other.StartConditionType;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.SpawnerGuid.Length != 0)
			{
				SpawnerGuid = other.SpawnerGuid;
			}
			if (other.OverlapGuid.Length != 0)
			{
				OverlapGuid = other.OverlapGuid;
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
				StartConditionType = input.ReadInt32();
				break;
			case 18u:
				UnitGuid = input.ReadString();
				break;
			case 26u:
				SpawnerGuid = input.ReadString();
				break;
			case 34u:
				OverlapGuid = input.ReadString();
				break;
			}
		}
	}
}
