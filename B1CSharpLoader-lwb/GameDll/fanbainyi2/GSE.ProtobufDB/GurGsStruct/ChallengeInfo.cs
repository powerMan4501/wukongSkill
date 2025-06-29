using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class ChallengeInfo : IMessage<ChallengeInfo>, IMessage, IEquatable<ChallengeInfo>, IDeepCloneable<ChallengeInfo>
{
	private static readonly MessageParser<ChallengeInfo> _parser = new MessageParser<ChallengeInfo>(() => new ChallengeInfo());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int challengeId_;

	private int challengeLevel_;

	private static readonly FieldCodec<ListDeltaMsgEntity> _repeated_challengingPlayerList_codec = FieldCodec.ForMessage(26u, ListDeltaMsgEntity.Parser);

	private readonly RepeatedField<ListDeltaMsgEntity> challengingPlayerList_ = new RepeatedField<ListDeltaMsgEntity>();

	private static readonly FieldCodec<ListDeltaMsgEntity> _repeated_fallDyingPlayerList_codec = FieldCodec.ForMessage(34u, ListDeltaMsgEntity.Parser);

	private readonly RepeatedField<ListDeltaMsgEntity> fallDyingPlayerList_ = new RepeatedField<ListDeltaMsgEntity>();

	private bool challengeFailed_;

	private float limitTime_;

	public static MessageParser<ChallengeInfo> Parser => _parser;

	public int ChallengeId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return challengeId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			challengeId_ = value;
		}
	}

	public bool HasChallengeId => (_hasBits0 & 1) != 0;

	public int ChallengeLevel
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return challengeLevel_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			challengeLevel_ = value;
		}
	}

	public bool HasChallengeLevel => (_hasBits0 & 2) != 0;

	public RepeatedField<ListDeltaMsgEntity> ChallengingPlayerList => challengingPlayerList_;

	public RepeatedField<ListDeltaMsgEntity> FallDyingPlayerList => fallDyingPlayerList_;

	public bool ChallengeFailed
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return challengeFailed_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 4;
			challengeFailed_ = value;
		}
	}

	public bool HasChallengeFailed => (_hasBits0 & 4) != 0;

	public float LimitTime
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return limitTime_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 8;
			limitTime_ = value;
		}
	}

	public bool HasLimitTime => (_hasBits0 & 8) != 0;

	public ChallengeInfo()
	{
	}

	public ChallengeInfo(ChallengeInfo other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		challengeId_ = other.challengeId_;
		challengeLevel_ = other.challengeLevel_;
		challengingPlayerList_ = other.challengingPlayerList_.Clone();
		fallDyingPlayerList_ = other.fallDyingPlayerList_.Clone();
		challengeFailed_ = other.challengeFailed_;
		limitTime_ = other.limitTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChallengeInfo Clone()
	{
		return new ChallengeInfo(this);
	}

	public void ClearChallengeId()
	{
		_hasBits0 &= -2;
	}

	public void ClearChallengeLevel()
	{
		_hasBits0 &= -3;
	}

	public void ClearChallengeFailed()
	{
		_hasBits0 &= -5;
	}

	public void ClearLimitTime()
	{
		_hasBits0 &= -9;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChallengeInfo);
	}

	public bool Equals(ChallengeInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (ChallengeLevel != other.ChallengeLevel)
		{
			return false;
		}
		if (!challengingPlayerList_.Equals(other.challengingPlayerList_))
		{
			return false;
		}
		if (!fallDyingPlayerList_.Equals(other.fallDyingPlayerList_))
		{
			return false;
		}
		if (ChallengeFailed != other.ChallengeFailed)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LimitTime, other.LimitTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasChallengeId)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (HasChallengeLevel)
		{
			num ^= ChallengeLevel.GetHashCode();
		}
		num ^= challengingPlayerList_.GetHashCode();
		num ^= fallDyingPlayerList_.GetHashCode();
		if (HasChallengeFailed)
		{
			num ^= ChallengeFailed.GetHashCode();
		}
		if (HasLimitTime)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LimitTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasChallengeId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ChallengeId);
		}
		if (HasChallengeLevel)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ChallengeLevel);
		}
		challengingPlayerList_.WriteTo(output, _repeated_challengingPlayerList_codec);
		fallDyingPlayerList_.WriteTo(output, _repeated_fallDyingPlayerList_codec);
		if (HasChallengeFailed)
		{
			output.WriteRawTag(40);
			output.WriteBool(ChallengeFailed);
		}
		if (HasLimitTime)
		{
			output.WriteRawTag(53);
			output.WriteFloat(LimitTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasChallengeId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChallengeId);
		}
		if (HasChallengeLevel)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChallengeLevel);
		}
		num += challengingPlayerList_.CalculateSize(_repeated_challengingPlayerList_codec);
		num += fallDyingPlayerList_.CalculateSize(_repeated_fallDyingPlayerList_codec);
		if (HasChallengeFailed)
		{
			num += 2;
		}
		if (HasLimitTime)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ChallengeInfo other)
	{
		if (other != null)
		{
			if (other.HasChallengeId)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.HasChallengeLevel)
			{
				ChallengeLevel = other.ChallengeLevel;
			}
			challengingPlayerList_.Add(other.challengingPlayerList_);
			fallDyingPlayerList_.Add(other.fallDyingPlayerList_);
			if (other.HasChallengeFailed)
			{
				ChallengeFailed = other.ChallengeFailed;
			}
			if (other.HasLimitTime)
			{
				LimitTime = other.LimitTime;
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
				ChallengeId = input.ReadInt32();
				break;
			case 16u:
				ChallengeLevel = input.ReadInt32();
				break;
			case 26u:
				challengingPlayerList_.AddEntriesFrom(input, _repeated_challengingPlayerList_codec);
				break;
			case 34u:
				fallDyingPlayerList_.AddEntriesFrom(input, _repeated_fallDyingPlayerList_codec);
				break;
			case 40u:
				ChallengeFailed = input.ReadBool();
				break;
			case 53u:
				LimitTime = input.ReadFloat();
				break;
			}
		}
	}
}
