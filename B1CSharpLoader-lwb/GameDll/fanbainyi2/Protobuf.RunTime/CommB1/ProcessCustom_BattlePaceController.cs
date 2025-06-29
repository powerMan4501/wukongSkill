using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessCustom_BattlePaceController : IMessage<ProcessCustom_BattlePaceController>, IMessage, IEquatable<ProcessCustom_BattlePaceController>, IDeepCloneable<ProcessCustom_BattlePaceController>
{
	private static readonly MessageParser<ProcessCustom_BattlePaceController> _parser = new MessageParser<ProcessCustom_BattlePaceController>(() => new ProcessCustom_BattlePaceController());

	private UnknownFieldSet _unknownFields;

	private bool autoEnable_;

	private bool needSaveState_;

	private static readonly FieldCodec<CalliopeCustom_BattlePaceWaveConfig> _repeated_battlePaceWaves_codec = FieldCodec.ForMessage(26u, CalliopeCustom_BattlePaceWaveConfig.Parser);

	private readonly RepeatedField<CalliopeCustom_BattlePaceWaveConfig> battlePaceWaves_ = new RepeatedField<CalliopeCustom_BattlePaceWaveConfig>();

	private static readonly FieldCodec<string> _repeated_battleObstacleGuids_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> battleObstacleGuids_ = new RepeatedField<string>();

	private string battleOverlapGuid_ = "";

	public static MessageParser<ProcessCustom_BattlePaceController> Parser => _parser;

	public bool AutoEnable
	{
		get
		{
			return autoEnable_;
		}
		set
		{
			autoEnable_ = value;
		}
	}

	public bool NeedSaveState
	{
		get
		{
			return needSaveState_;
		}
		set
		{
			needSaveState_ = value;
		}
	}

	public RepeatedField<CalliopeCustom_BattlePaceWaveConfig> BattlePaceWaves => battlePaceWaves_;

	public RepeatedField<string> BattleObstacleGuids => battleObstacleGuids_;

	public string BattleOverlapGuid
	{
		get
		{
			return battleOverlapGuid_;
		}
		set
		{
			battleOverlapGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ProcessCustom_BattlePaceController()
	{
	}

	public ProcessCustom_BattlePaceController(ProcessCustom_BattlePaceController other)
		: this()
	{
		autoEnable_ = other.autoEnable_;
		needSaveState_ = other.needSaveState_;
		battlePaceWaves_ = other.battlePaceWaves_.Clone();
		battleObstacleGuids_ = other.battleObstacleGuids_.Clone();
		battleOverlapGuid_ = other.battleOverlapGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_BattlePaceController Clone()
	{
		return new ProcessCustom_BattlePaceController(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_BattlePaceController);
	}

	public bool Equals(ProcessCustom_BattlePaceController other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AutoEnable != other.AutoEnable)
		{
			return false;
		}
		if (NeedSaveState != other.NeedSaveState)
		{
			return false;
		}
		if (!battlePaceWaves_.Equals(other.battlePaceWaves_))
		{
			return false;
		}
		if (!battleObstacleGuids_.Equals(other.battleObstacleGuids_))
		{
			return false;
		}
		if (BattleOverlapGuid != other.BattleOverlapGuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AutoEnable)
		{
			num ^= AutoEnable.GetHashCode();
		}
		if (NeedSaveState)
		{
			num ^= NeedSaveState.GetHashCode();
		}
		num ^= battlePaceWaves_.GetHashCode();
		num ^= battleObstacleGuids_.GetHashCode();
		if (BattleOverlapGuid.Length != 0)
		{
			num ^= BattleOverlapGuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AutoEnable)
		{
			output.WriteRawTag(8);
			output.WriteBool(AutoEnable);
		}
		if (NeedSaveState)
		{
			output.WriteRawTag(16);
			output.WriteBool(NeedSaveState);
		}
		battlePaceWaves_.WriteTo(output, _repeated_battlePaceWaves_codec);
		battleObstacleGuids_.WriteTo(output, _repeated_battleObstacleGuids_codec);
		if (BattleOverlapGuid.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(BattleOverlapGuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AutoEnable)
		{
			num += 2;
		}
		if (NeedSaveState)
		{
			num += 2;
		}
		num += battlePaceWaves_.CalculateSize(_repeated_battlePaceWaves_codec);
		num += battleObstacleGuids_.CalculateSize(_repeated_battleObstacleGuids_codec);
		if (BattleOverlapGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BattleOverlapGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessCustom_BattlePaceController other)
	{
		if (other != null)
		{
			if (other.AutoEnable)
			{
				AutoEnable = other.AutoEnable;
			}
			if (other.NeedSaveState)
			{
				NeedSaveState = other.NeedSaveState;
			}
			battlePaceWaves_.Add(other.battlePaceWaves_);
			battleObstacleGuids_.Add(other.battleObstacleGuids_);
			if (other.BattleOverlapGuid.Length != 0)
			{
				BattleOverlapGuid = other.BattleOverlapGuid;
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
				AutoEnable = input.ReadBool();
				break;
			case 16u:
				NeedSaveState = input.ReadBool();
				break;
			case 26u:
				battlePaceWaves_.AddEntriesFrom(input, _repeated_battlePaceWaves_codec);
				break;
			case 34u:
				battleObstacleGuids_.AddEntriesFrom(input, _repeated_battleObstacleGuids_codec);
				break;
			case 42u:
				BattleOverlapGuid = input.ReadString();
				break;
			}
		}
	}
}
