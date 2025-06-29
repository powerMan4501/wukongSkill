using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_BattleWaveUnitSpawnConfig : IMessage<CalliopeCustom_BattleWaveUnitSpawnConfig>, IMessage, IEquatable<CalliopeCustom_BattleWaveUnitSpawnConfig>, IDeepCloneable<CalliopeCustom_BattleWaveUnitSpawnConfig>
{
	private static readonly MessageParser<CalliopeCustom_BattleWaveUnitSpawnConfig> _parser = new MessageParser<CalliopeCustom_BattleWaveUnitSpawnConfig>(() => new CalliopeCustom_BattleWaveUnitSpawnConfig());

	private UnknownFieldSet _unknownFields;

	private string unitType_ = "";

	private CalliopeCustom_Transform spawnPoint_;

	private static readonly FieldCodec<int> _repeated_birthBuff_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> birthBuff_ = new RepeatedField<int>();

	private int unitSpawnTiming_;

	private int unitTargetType_;

	private int unitCatchTargetTiming_;

	public static MessageParser<CalliopeCustom_BattleWaveUnitSpawnConfig> Parser => _parser;

	public string UnitType
	{
		get
		{
			return unitType_;
		}
		set
		{
			unitType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeCustom_Transform SpawnPoint
	{
		get
		{
			return spawnPoint_;
		}
		set
		{
			spawnPoint_ = value;
		}
	}

	public RepeatedField<int> BirthBuff => birthBuff_;

	public int UnitSpawnTiming
	{
		get
		{
			return unitSpawnTiming_;
		}
		set
		{
			unitSpawnTiming_ = value;
		}
	}

	public int UnitTargetType
	{
		get
		{
			return unitTargetType_;
		}
		set
		{
			unitTargetType_ = value;
		}
	}

	public int UnitCatchTargetTiming
	{
		get
		{
			return unitCatchTargetTiming_;
		}
		set
		{
			unitCatchTargetTiming_ = value;
		}
	}

	public CalliopeCustom_BattleWaveUnitSpawnConfig()
	{
	}

	public CalliopeCustom_BattleWaveUnitSpawnConfig(CalliopeCustom_BattleWaveUnitSpawnConfig other)
		: this()
	{
		unitType_ = other.unitType_;
		spawnPoint_ = ((other.spawnPoint_ != null) ? other.spawnPoint_.Clone() : null);
		birthBuff_ = other.birthBuff_.Clone();
		unitSpawnTiming_ = other.unitSpawnTiming_;
		unitTargetType_ = other.unitTargetType_;
		unitCatchTargetTiming_ = other.unitCatchTargetTiming_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_BattleWaveUnitSpawnConfig Clone()
	{
		return new CalliopeCustom_BattleWaveUnitSpawnConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_BattleWaveUnitSpawnConfig);
	}

	public bool Equals(CalliopeCustom_BattleWaveUnitSpawnConfig other)
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
		if (!object.Equals(SpawnPoint, other.SpawnPoint))
		{
			return false;
		}
		if (!birthBuff_.Equals(other.birthBuff_))
		{
			return false;
		}
		if (UnitSpawnTiming != other.UnitSpawnTiming)
		{
			return false;
		}
		if (UnitTargetType != other.UnitTargetType)
		{
			return false;
		}
		if (UnitCatchTargetTiming != other.UnitCatchTargetTiming)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitType.Length != 0)
		{
			num ^= UnitType.GetHashCode();
		}
		if (spawnPoint_ != null)
		{
			num ^= SpawnPoint.GetHashCode();
		}
		num ^= birthBuff_.GetHashCode();
		if (UnitSpawnTiming != 0)
		{
			num ^= UnitSpawnTiming.GetHashCode();
		}
		if (UnitTargetType != 0)
		{
			num ^= UnitTargetType.GetHashCode();
		}
		if (UnitCatchTargetTiming != 0)
		{
			num ^= UnitCatchTargetTiming.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitType.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(UnitType);
		}
		if (spawnPoint_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(SpawnPoint);
		}
		birthBuff_.WriteTo(output, _repeated_birthBuff_codec);
		if (UnitSpawnTiming != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(UnitSpawnTiming);
		}
		if (UnitTargetType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(UnitTargetType);
		}
		if (UnitCatchTargetTiming != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(UnitCatchTargetTiming);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitType);
		}
		if (spawnPoint_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SpawnPoint);
		}
		num += birthBuff_.CalculateSize(_repeated_birthBuff_codec);
		if (UnitSpawnTiming != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitSpawnTiming);
		}
		if (UnitTargetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitTargetType);
		}
		if (UnitCatchTargetTiming != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitCatchTargetTiming);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_BattleWaveUnitSpawnConfig other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UnitType.Length != 0)
		{
			UnitType = other.UnitType;
		}
		if (other.spawnPoint_ != null)
		{
			if (spawnPoint_ == null)
			{
				SpawnPoint = new CalliopeCustom_Transform();
			}
			SpawnPoint.MergeFrom(other.SpawnPoint);
		}
		birthBuff_.Add(other.birthBuff_);
		if (other.UnitSpawnTiming != 0)
		{
			UnitSpawnTiming = other.UnitSpawnTiming;
		}
		if (other.UnitTargetType != 0)
		{
			UnitTargetType = other.UnitTargetType;
		}
		if (other.UnitCatchTargetTiming != 0)
		{
			UnitCatchTargetTiming = other.UnitCatchTargetTiming;
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
				UnitType = input.ReadString();
				break;
			case 18u:
				if (spawnPoint_ == null)
				{
					SpawnPoint = new CalliopeCustom_Transform();
				}
				input.ReadMessage(SpawnPoint);
				break;
			case 24u:
			case 26u:
				birthBuff_.AddEntriesFrom(input, _repeated_birthBuff_codec);
				break;
			case 32u:
				UnitSpawnTiming = input.ReadInt32();
				break;
			case 40u:
				UnitTargetType = input.ReadInt32();
				break;
			case 48u:
				UnitCatchTargetTiming = input.ReadInt32();
				break;
			}
		}
	}
}
