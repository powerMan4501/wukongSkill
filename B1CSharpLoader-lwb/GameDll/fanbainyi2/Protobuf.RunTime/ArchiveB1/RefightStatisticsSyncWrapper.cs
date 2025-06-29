using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class RefightStatisticsSyncWrapper : IMessage<RefightStatisticsSyncWrapper>, IMessage, IEquatable<RefightStatisticsSyncWrapper>, IDeepCloneable<RefightStatisticsSyncWrapper>
{
	private static readonly MessageParser<RefightStatisticsSyncWrapper> _parser = new MessageParser<RefightStatisticsSyncWrapper>(() => new RefightStatisticsSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private EReChallengeLevelSyncWrapper challengeLevel_;

	private Uint32SyncWrapper battleCount_;

	public static MessageParser<RefightStatisticsSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public EReChallengeLevelSyncWrapper ChallengeLevel
	{
		get
		{
			return challengeLevel_;
		}
		set
		{
			challengeLevel_ = value;
		}
	}

	public Uint32SyncWrapper BattleCount
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

	public RefightStatisticsSyncWrapper()
	{
	}

	public RefightStatisticsSyncWrapper(RefightStatisticsSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		challengeLevel_ = ((other.challengeLevel_ != null) ? other.challengeLevel_.Clone() : null);
		battleCount_ = ((other.battleCount_ != null) ? other.battleCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RefightStatisticsSyncWrapper Clone()
	{
		return new RefightStatisticsSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RefightStatisticsSyncWrapper);
	}

	public bool Equals(RefightStatisticsSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(ChallengeLevel, other.ChallengeLevel))
		{
			return false;
		}
		if (!object.Equals(BattleCount, other.BattleCount))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (challengeLevel_ != null)
		{
			num ^= ChallengeLevel.GetHashCode();
		}
		if (battleCount_ != null)
		{
			num ^= BattleCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (challengeLevel_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ChallengeLevel);
		}
		if (battleCount_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BattleCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (challengeLevel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChallengeLevel);
		}
		if (battleCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RefightStatisticsSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.challengeLevel_ != null)
		{
			if (challengeLevel_ == null)
			{
				ChallengeLevel = new EReChallengeLevelSyncWrapper();
			}
			ChallengeLevel.MergeFrom(other.ChallengeLevel);
		}
		if (other.battleCount_ != null)
		{
			if (battleCount_ == null)
			{
				BattleCount = new Uint32SyncWrapper();
			}
			BattleCount.MergeFrom(other.BattleCount);
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
			case 8u:
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (challengeLevel_ == null)
				{
					ChallengeLevel = new EReChallengeLevelSyncWrapper();
				}
				input.ReadMessage(ChallengeLevel);
				break;
			case 34u:
				if (battleCount_ == null)
				{
					BattleCount = new Uint32SyncWrapper();
				}
				input.ReadMessage(BattleCount);
				break;
			}
		}
	}
}
