using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushRefightBoss : IMessage<BossRushRefightBoss>, IMessage, IEquatable<BossRushRefightBoss>, IDeepCloneable<BossRushRefightBoss>
{
	private static readonly MessageParser<BossRushRefightBoss> _parser = new MessageParser<BossRushRefightBoss>(() => new BossRushRefightBoss());

	private UnknownFieldSet _unknownFields;

	private int bossId_;

	private EReChallengeLevel passedMaxLevel_;

	private EReChallengeLevel lastChallengeLevel_;

	private static readonly FieldCodec<BossRushRefightRecord> _repeated_bestRecords_codec = FieldCodec.ForMessage(34u, BossRushRefightRecord.Parser);

	private readonly RepeatedField<BossRushRefightRecord> bestRecords_ = new RepeatedField<BossRushRefightRecord>();

	private ECooperativeStatus cooperativeStatus_;

	private static readonly FieldCodec<RefightStatistics> _repeated_refightStatisticsList_codec = FieldCodec.ForMessage(50u, RefightStatistics.Parser);

	private readonly RepeatedField<RefightStatistics> refightStatisticsList_ = new RepeatedField<RefightStatistics>();

	public static MessageParser<BossRushRefightBoss> Parser => _parser;

	public int BossId
	{
		get
		{
			return bossId_;
		}
		set
		{
			bossId_ = value;
		}
	}

	public EReChallengeLevel PassedMaxLevel
	{
		get
		{
			return passedMaxLevel_;
		}
		set
		{
			passedMaxLevel_ = value;
		}
	}

	public EReChallengeLevel LastChallengeLevel
	{
		get
		{
			return lastChallengeLevel_;
		}
		set
		{
			lastChallengeLevel_ = value;
		}
	}

	public RepeatedField<BossRushRefightRecord> BestRecords => bestRecords_;

	public ECooperativeStatus CooperativeStatus
	{
		get
		{
			return cooperativeStatus_;
		}
		set
		{
			cooperativeStatus_ = value;
		}
	}

	public RepeatedField<RefightStatistics> RefightStatisticsList => refightStatisticsList_;

	public BossRushRefightBoss()
	{
	}

	public BossRushRefightBoss(BossRushRefightBoss other)
		: this()
	{
		bossId_ = other.bossId_;
		passedMaxLevel_ = other.passedMaxLevel_;
		lastChallengeLevel_ = other.lastChallengeLevel_;
		bestRecords_ = other.bestRecords_.Clone();
		cooperativeStatus_ = other.cooperativeStatus_;
		refightStatisticsList_ = other.refightStatisticsList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushRefightBoss Clone()
	{
		return new BossRushRefightBoss(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushRefightBoss);
	}

	public bool Equals(BossRushRefightBoss other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BossId != other.BossId)
		{
			return false;
		}
		if (PassedMaxLevel != other.PassedMaxLevel)
		{
			return false;
		}
		if (LastChallengeLevel != other.LastChallengeLevel)
		{
			return false;
		}
		if (!bestRecords_.Equals(other.bestRecords_))
		{
			return false;
		}
		if (CooperativeStatus != other.CooperativeStatus)
		{
			return false;
		}
		if (!refightStatisticsList_.Equals(other.refightStatisticsList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BossId != 0)
		{
			num ^= BossId.GetHashCode();
		}
		if (PassedMaxLevel != EReChallengeLevel.Default)
		{
			num ^= PassedMaxLevel.GetHashCode();
		}
		if (LastChallengeLevel != EReChallengeLevel.Default)
		{
			num ^= LastChallengeLevel.GetHashCode();
		}
		num ^= bestRecords_.GetHashCode();
		if (CooperativeStatus != ECooperativeStatus.Forbid)
		{
			num ^= CooperativeStatus.GetHashCode();
		}
		num ^= refightStatisticsList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BossId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BossId);
		}
		if (PassedMaxLevel != EReChallengeLevel.Default)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)PassedMaxLevel);
		}
		if (LastChallengeLevel != EReChallengeLevel.Default)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)LastChallengeLevel);
		}
		bestRecords_.WriteTo(output, _repeated_bestRecords_codec);
		if (CooperativeStatus != ECooperativeStatus.Forbid)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)CooperativeStatus);
		}
		refightStatisticsList_.WriteTo(output, _repeated_refightStatisticsList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BossId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossId);
		}
		if (PassedMaxLevel != EReChallengeLevel.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PassedMaxLevel);
		}
		if (LastChallengeLevel != EReChallengeLevel.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LastChallengeLevel);
		}
		num += bestRecords_.CalculateSize(_repeated_bestRecords_codec);
		if (CooperativeStatus != ECooperativeStatus.Forbid)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CooperativeStatus);
		}
		num += refightStatisticsList_.CalculateSize(_repeated_refightStatisticsList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushRefightBoss other)
	{
		if (other != null)
		{
			if (other.BossId != 0)
			{
				BossId = other.BossId;
			}
			if (other.PassedMaxLevel != EReChallengeLevel.Default)
			{
				PassedMaxLevel = other.PassedMaxLevel;
			}
			if (other.LastChallengeLevel != EReChallengeLevel.Default)
			{
				LastChallengeLevel = other.LastChallengeLevel;
			}
			bestRecords_.Add(other.bestRecords_);
			if (other.CooperativeStatus != ECooperativeStatus.Forbid)
			{
				CooperativeStatus = other.CooperativeStatus;
			}
			refightStatisticsList_.Add(other.refightStatisticsList_);
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
				BossId = input.ReadInt32();
				break;
			case 16u:
				PassedMaxLevel = (EReChallengeLevel)input.ReadEnum();
				break;
			case 24u:
				LastChallengeLevel = (EReChallengeLevel)input.ReadEnum();
				break;
			case 34u:
				bestRecords_.AddEntriesFrom(input, _repeated_bestRecords_codec);
				break;
			case 40u:
				CooperativeStatus = (ECooperativeStatus)input.ReadEnum();
				break;
			case 50u:
				refightStatisticsList_.AddEntriesFrom(input, _repeated_refightStatisticsList_codec);
				break;
			}
		}
	}
}
