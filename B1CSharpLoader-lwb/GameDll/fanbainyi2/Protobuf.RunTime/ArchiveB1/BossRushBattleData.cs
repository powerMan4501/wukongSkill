using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushBattleData : IMessage<BossRushBattleData>, IMessage, IEquatable<BossRushBattleData>, IDeepCloneable<BossRushBattleData>
{
	private static readonly MessageParser<BossRushBattleData> _parser = new MessageParser<BossRushBattleData>(() => new BossRushBattleData());

	private UnknownFieldSet _unknownFields;

	private float totalTime_;

	private int score_;

	private static readonly FieldCodec<int> _repeated_debuffList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> debuffList_ = new RepeatedField<int>();

	private int targetId_;

	private ulong archiveTime_;

	private BossRushRoleBase roleBase_;

	private BossRushBattleStyle battleStyleInfo_;

	private BossRushDamageInfo damageInfo_;

	public static MessageParser<BossRushBattleData> Parser => _parser;

	public float TotalTime
	{
		get
		{
			return totalTime_;
		}
		set
		{
			totalTime_ = value;
		}
	}

	public int Score
	{
		get
		{
			return score_;
		}
		set
		{
			score_ = value;
		}
	}

	public RepeatedField<int> DebuffList => debuffList_;

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

	public ulong ArchiveTime
	{
		get
		{
			return archiveTime_;
		}
		set
		{
			archiveTime_ = value;
		}
	}

	public BossRushRoleBase RoleBase
	{
		get
		{
			return roleBase_;
		}
		set
		{
			roleBase_ = value;
		}
	}

	public BossRushBattleStyle BattleStyleInfo
	{
		get
		{
			return battleStyleInfo_;
		}
		set
		{
			battleStyleInfo_ = value;
		}
	}

	public BossRushDamageInfo DamageInfo
	{
		get
		{
			return damageInfo_;
		}
		set
		{
			damageInfo_ = value;
		}
	}

	public BossRushBattleData()
	{
	}

	public BossRushBattleData(BossRushBattleData other)
		: this()
	{
		totalTime_ = other.totalTime_;
		score_ = other.score_;
		debuffList_ = other.debuffList_.Clone();
		targetId_ = other.targetId_;
		archiveTime_ = other.archiveTime_;
		roleBase_ = ((other.roleBase_ != null) ? other.roleBase_.Clone() : null);
		battleStyleInfo_ = ((other.battleStyleInfo_ != null) ? other.battleStyleInfo_.Clone() : null);
		damageInfo_ = ((other.damageInfo_ != null) ? other.damageInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushBattleData Clone()
	{
		return new BossRushBattleData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushBattleData);
	}

	public bool Equals(BossRushBattleData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalTime, other.TotalTime))
		{
			return false;
		}
		if (Score != other.Score)
		{
			return false;
		}
		if (!debuffList_.Equals(other.debuffList_))
		{
			return false;
		}
		if (TargetId != other.TargetId)
		{
			return false;
		}
		if (ArchiveTime != other.ArchiveTime)
		{
			return false;
		}
		if (!object.Equals(RoleBase, other.RoleBase))
		{
			return false;
		}
		if (!object.Equals(BattleStyleInfo, other.BattleStyleInfo))
		{
			return false;
		}
		if (!object.Equals(DamageInfo, other.DamageInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TotalTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalTime);
		}
		if (Score != 0)
		{
			num ^= Score.GetHashCode();
		}
		num ^= debuffList_.GetHashCode();
		if (TargetId != 0)
		{
			num ^= TargetId.GetHashCode();
		}
		if (ArchiveTime != 0L)
		{
			num ^= ArchiveTime.GetHashCode();
		}
		if (roleBase_ != null)
		{
			num ^= RoleBase.GetHashCode();
		}
		if (battleStyleInfo_ != null)
		{
			num ^= BattleStyleInfo.GetHashCode();
		}
		if (damageInfo_ != null)
		{
			num ^= DamageInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TotalTime != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(TotalTime);
		}
		if (Score != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Score);
		}
		debuffList_.WriteTo(output, _repeated_debuffList_codec);
		if (TargetId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TargetId);
		}
		if (ArchiveTime != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(ArchiveTime);
		}
		if (roleBase_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(RoleBase);
		}
		if (battleStyleInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(BattleStyleInfo);
		}
		if (damageInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(DamageInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TotalTime != 0f)
		{
			num += 5;
		}
		if (Score != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Score);
		}
		num += debuffList_.CalculateSize(_repeated_debuffList_codec);
		if (TargetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetId);
		}
		if (ArchiveTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ArchiveTime);
		}
		if (roleBase_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleBase);
		}
		if (battleStyleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleStyleInfo);
		}
		if (damageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DamageInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushBattleData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.TotalTime != 0f)
		{
			TotalTime = other.TotalTime;
		}
		if (other.Score != 0)
		{
			Score = other.Score;
		}
		debuffList_.Add(other.debuffList_);
		if (other.TargetId != 0)
		{
			TargetId = other.TargetId;
		}
		if (other.ArchiveTime != 0L)
		{
			ArchiveTime = other.ArchiveTime;
		}
		if (other.roleBase_ != null)
		{
			if (roleBase_ == null)
			{
				RoleBase = new BossRushRoleBase();
			}
			RoleBase.MergeFrom(other.RoleBase);
		}
		if (other.battleStyleInfo_ != null)
		{
			if (battleStyleInfo_ == null)
			{
				BattleStyleInfo = new BossRushBattleStyle();
			}
			BattleStyleInfo.MergeFrom(other.BattleStyleInfo);
		}
		if (other.damageInfo_ != null)
		{
			if (damageInfo_ == null)
			{
				DamageInfo = new BossRushDamageInfo();
			}
			DamageInfo.MergeFrom(other.DamageInfo);
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
			case 13u:
				TotalTime = input.ReadFloat();
				break;
			case 16u:
				Score = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				debuffList_.AddEntriesFrom(input, _repeated_debuffList_codec);
				break;
			case 32u:
				TargetId = input.ReadInt32();
				break;
			case 40u:
				ArchiveTime = input.ReadUInt64();
				break;
			case 50u:
				if (roleBase_ == null)
				{
					RoleBase = new BossRushRoleBase();
				}
				input.ReadMessage(RoleBase);
				break;
			case 58u:
				if (battleStyleInfo_ == null)
				{
					BattleStyleInfo = new BossRushBattleStyle();
				}
				input.ReadMessage(BattleStyleInfo);
				break;
			case 66u:
				if (damageInfo_ == null)
				{
					DamageInfo = new BossRushDamageInfo();
				}
				input.ReadMessage(DamageInfo);
				break;
			}
		}
	}
}
