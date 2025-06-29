using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventBossRushResult : IMessage<ReportEventBossRushResult>, IMessage, IEquatable<ReportEventBossRushResult>, IDeepCloneable<ReportEventBossRushResult>
{
	private static readonly MessageParser<ReportEventBossRushResult> _parser = new MessageParser<ReportEventBossRushResult>(() => new ReportEventBossRushResult());

	private UnknownFieldSet _unknownFields;

	private int targetId_;

	private int type_;

	private BossRushResultType result_;

	private float battleTime_;

	private int hardLevel_;

	private static readonly FieldCodec<int> _repeated_debuffList_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> debuffList_ = new RepeatedField<int>();

	private int progress_;

	private uint battleCount_;

	private bool isComplete_;

	private static readonly FieldCodec<float> _repeated_battleTimeList_codec = FieldCodec.ForFloat(82u);

	private readonly RepeatedField<float> battleTimeList_ = new RepeatedField<float>();

	public static MessageParser<ReportEventBossRushResult> Parser => _parser;

	public int TargetId
	{
		get
		{
			return targetId_;
		}
		set
		{
			targetId_ = value;
		}
	}

	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public BossRushResultType Result
	{
		get
		{
			return result_;
		}
		set
		{
			result_ = value;
		}
	}

	public float BattleTime
	{
		get
		{
			return battleTime_;
		}
		set
		{
			battleTime_ = value;
		}
	}

	public int HardLevel
	{
		get
		{
			return hardLevel_;
		}
		set
		{
			hardLevel_ = value;
		}
	}

	public RepeatedField<int> DebuffList => debuffList_;

	public int Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	public uint BattleCount
	{
		get
		{
			return battleCount_;
		}
		set
		{
			battleCount_ = value;
		}
	}

	public bool IsComplete
	{
		get
		{
			return isComplete_;
		}
		set
		{
			isComplete_ = value;
		}
	}

	public RepeatedField<float> BattleTimeList => battleTimeList_;

	public ReportEventBossRushResult()
	{
	}

	public ReportEventBossRushResult(ReportEventBossRushResult other)
		: this()
	{
		targetId_ = other.targetId_;
		type_ = other.type_;
		result_ = other.result_;
		battleTime_ = other.battleTime_;
		hardLevel_ = other.hardLevel_;
		debuffList_ = other.debuffList_.Clone();
		progress_ = other.progress_;
		battleCount_ = other.battleCount_;
		isComplete_ = other.isComplete_;
		battleTimeList_ = other.battleTimeList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventBossRushResult Clone()
	{
		return new ReportEventBossRushResult(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventBossRushResult);
	}

	public bool Equals(ReportEventBossRushResult other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetId != other.TargetId)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Result != other.Result)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BattleTime, other.BattleTime))
		{
			return false;
		}
		if (HardLevel != other.HardLevel)
		{
			return false;
		}
		if (!debuffList_.Equals(other.debuffList_))
		{
			return false;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (BattleCount != other.BattleCount)
		{
			return false;
		}
		if (IsComplete != other.IsComplete)
		{
			return false;
		}
		if (!battleTimeList_.Equals(other.battleTimeList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TargetId != 0)
		{
			num ^= TargetId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Result != BossRushResultType.None)
		{
			num ^= Result.GetHashCode();
		}
		if (BattleTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BattleTime);
		}
		if (HardLevel != 0)
		{
			num ^= HardLevel.GetHashCode();
		}
		num ^= debuffList_.GetHashCode();
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (BattleCount != 0)
		{
			num ^= BattleCount.GetHashCode();
		}
		if (IsComplete)
		{
			num ^= IsComplete.GetHashCode();
		}
		num ^= battleTimeList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TargetId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TargetId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Type);
		}
		if (Result != BossRushResultType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Result);
		}
		if (BattleTime != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(BattleTime);
		}
		if (HardLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(HardLevel);
		}
		debuffList_.WriteTo(output, _repeated_debuffList_codec);
		if (Progress != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Progress);
		}
		if (BattleCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BattleCount);
		}
		if (IsComplete)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsComplete);
		}
		battleTimeList_.WriteTo(output, _repeated_battleTimeList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TargetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetId);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (Result != BossRushResultType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Result);
		}
		if (BattleTime != 0f)
		{
			num += 5;
		}
		if (HardLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HardLevel);
		}
		num += debuffList_.CalculateSize(_repeated_debuffList_codec);
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Progress);
		}
		if (BattleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleCount);
		}
		if (IsComplete)
		{
			num += 2;
		}
		num += battleTimeList_.CalculateSize(_repeated_battleTimeList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventBossRushResult other)
	{
		if (other != null)
		{
			if (other.TargetId != 0)
			{
				TargetId = other.TargetId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Result != BossRushResultType.None)
			{
				Result = other.Result;
			}
			if (other.BattleTime != 0f)
			{
				BattleTime = other.BattleTime;
			}
			if (other.HardLevel != 0)
			{
				HardLevel = other.HardLevel;
			}
			debuffList_.Add(other.debuffList_);
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			if (other.BattleCount != 0)
			{
				BattleCount = other.BattleCount;
			}
			if (other.IsComplete)
			{
				IsComplete = other.IsComplete;
			}
			battleTimeList_.Add(other.battleTimeList_);
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
				TargetId = input.ReadInt32();
				break;
			case 16u:
				Type = input.ReadInt32();
				break;
			case 24u:
				Result = (BossRushResultType)input.ReadEnum();
				break;
			case 37u:
				BattleTime = input.ReadFloat();
				break;
			case 40u:
				HardLevel = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				debuffList_.AddEntriesFrom(input, _repeated_debuffList_codec);
				break;
			case 56u:
				Progress = input.ReadInt32();
				break;
			case 64u:
				BattleCount = input.ReadUInt32();
				break;
			case 72u:
				IsComplete = input.ReadBool();
				break;
			case 82u:
			case 85u:
				battleTimeList_.AddEntriesFrom(input, _repeated_battleTimeList_codec);
				break;
			}
		}
	}
}
