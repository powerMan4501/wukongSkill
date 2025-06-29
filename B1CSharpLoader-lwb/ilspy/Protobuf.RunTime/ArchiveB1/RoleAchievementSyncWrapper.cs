using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleAchievementSyncWrapper : IMessage<RoleAchievementSyncWrapper>, IMessage, IEquatable<RoleAchievementSyncWrapper>, IDeepCloneable<RoleAchievementSyncWrapper>
{
	private static readonly MessageParser<RoleAchievementSyncWrapper> _parser = new MessageParser<RoleAchievementSyncWrapper>(() => new RoleAchievementSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<AchievementOneSyncWrapper> _repeated_achievements_codec = FieldCodec.ForMessage(42u, AchievementOneSyncWrapper.Parser);

	private readonly RepeatedField<AchievementOneSyncWrapper> achievements_ = new RepeatedField<AchievementOneSyncWrapper>();

	private AchievementVersionSyncWrapper achievementVersion_;

	public static MessageParser<RoleAchievementSyncWrapper> Parser => _parser;

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

	public RepeatedField<AchievementOneSyncWrapper> Achievements => achievements_;

	public AchievementVersionSyncWrapper AchievementVersion
	{
		get
		{
			return achievementVersion_;
		}
		set
		{
			achievementVersion_ = value;
		}
	}

	public RoleAchievementSyncWrapper()
	{
	}

	public RoleAchievementSyncWrapper(RoleAchievementSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		achievements_ = other.achievements_.Clone();
		achievementVersion_ = ((other.achievementVersion_ != null) ? other.achievementVersion_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleAchievementSyncWrapper Clone()
	{
		return new RoleAchievementSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleAchievementSyncWrapper);
	}

	public bool Equals(RoleAchievementSyncWrapper other)
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
		if (!achievements_.Equals(other.achievements_))
		{
			return false;
		}
		if (!object.Equals(AchievementVersion, other.AchievementVersion))
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
		num ^= achievements_.GetHashCode();
		if (achievementVersion_ != null)
		{
			num ^= AchievementVersion.GetHashCode();
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
		achievements_.WriteTo(output, _repeated_achievements_codec);
		if (achievementVersion_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AchievementVersion);
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
		num += achievements_.CalculateSize(_repeated_achievements_codec);
		if (achievementVersion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AchievementVersion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleAchievementSyncWrapper other)
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
		achievements_.Add(other.achievements_);
		if (other.achievementVersion_ != null)
		{
			if (achievementVersion_ == null)
			{
				AchievementVersion = new AchievementVersionSyncWrapper();
			}
			AchievementVersion.MergeFrom(other.AchievementVersion);
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
			case 42u:
				achievements_.AddEntriesFrom(input, _repeated_achievements_codec);
				break;
			case 50u:
				if (achievementVersion_ == null)
				{
					AchievementVersion = new AchievementVersionSyncWrapper();
				}
				input.ReadMessage(AchievementVersion);
				break;
			}
		}
	}
}
