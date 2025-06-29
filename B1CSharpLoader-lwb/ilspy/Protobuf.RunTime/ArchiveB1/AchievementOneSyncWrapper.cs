using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class AchievementOneSyncWrapper : IMessage<AchievementOneSyncWrapper>, IMessage, IEquatable<AchievementOneSyncWrapper>, IDeepCloneable<AchievementOneSyncWrapper>
{
	private static readonly MessageParser<AchievementOneSyncWrapper> _parser = new MessageParser<AchievementOneSyncWrapper>(() => new AchievementOneSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private AchievementConfigSyncWrapper config_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_completeRequirementList_codec = FieldCodec.ForMessage(34u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> completeRequirementList_ = new RepeatedField<Int32SyncWrapper>();

	private BoolSyncWrapper isComplete_;

	private static readonly FieldCodec<StringSyncWrapper> _repeated_completeRequirementGuidList_codec = FieldCodec.ForMessage(50u, StringSyncWrapper.Parser);

	private readonly RepeatedField<StringSyncWrapper> completeRequirementGuidList_ = new RepeatedField<StringSyncWrapper>();

	public static MessageParser<AchievementOneSyncWrapper> Parser => _parser;

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

	public AchievementConfigSyncWrapper Config
	{
		get
		{
			return config_;
		}
		set
		{
			config_ = value;
		}
	}

	public RepeatedField<Int32SyncWrapper> CompleteRequirementList => completeRequirementList_;

	public BoolSyncWrapper IsComplete
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

	public RepeatedField<StringSyncWrapper> CompleteRequirementGuidList => completeRequirementGuidList_;

	public AchievementOneSyncWrapper()
	{
	}

	public AchievementOneSyncWrapper(AchievementOneSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		config_ = ((other.config_ != null) ? other.config_.Clone() : null);
		completeRequirementList_ = other.completeRequirementList_.Clone();
		isComplete_ = ((other.isComplete_ != null) ? other.isComplete_.Clone() : null);
		completeRequirementGuidList_ = other.completeRequirementGuidList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementOneSyncWrapper Clone()
	{
		return new AchievementOneSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementOneSyncWrapper);
	}

	public bool Equals(AchievementOneSyncWrapper other)
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
		if (!object.Equals(Config, other.Config))
		{
			return false;
		}
		if (!completeRequirementList_.Equals(other.completeRequirementList_))
		{
			return false;
		}
		if (!object.Equals(IsComplete, other.IsComplete))
		{
			return false;
		}
		if (!completeRequirementGuidList_.Equals(other.completeRequirementGuidList_))
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
		if (config_ != null)
		{
			num ^= Config.GetHashCode();
		}
		num ^= completeRequirementList_.GetHashCode();
		if (isComplete_ != null)
		{
			num ^= IsComplete.GetHashCode();
		}
		num ^= completeRequirementGuidList_.GetHashCode();
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
		if (config_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Config);
		}
		completeRequirementList_.WriteTo(output, _repeated_completeRequirementList_codec);
		if (isComplete_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(IsComplete);
		}
		completeRequirementGuidList_.WriteTo(output, _repeated_completeRequirementGuidList_codec);
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
		if (config_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Config);
		}
		num += completeRequirementList_.CalculateSize(_repeated_completeRequirementList_codec);
		if (isComplete_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IsComplete);
		}
		num += completeRequirementGuidList_.CalculateSize(_repeated_completeRequirementGuidList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementOneSyncWrapper other)
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
		if (other.config_ != null)
		{
			if (config_ == null)
			{
				Config = new AchievementConfigSyncWrapper();
			}
			Config.MergeFrom(other.Config);
		}
		completeRequirementList_.Add(other.completeRequirementList_);
		if (other.isComplete_ != null)
		{
			if (isComplete_ == null)
			{
				IsComplete = new BoolSyncWrapper();
			}
			IsComplete.MergeFrom(other.IsComplete);
		}
		completeRequirementGuidList_.Add(other.completeRequirementGuidList_);
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
				if (config_ == null)
				{
					Config = new AchievementConfigSyncWrapper();
				}
				input.ReadMessage(Config);
				break;
			case 34u:
				completeRequirementList_.AddEntriesFrom(input, _repeated_completeRequirementList_codec);
				break;
			case 42u:
				if (isComplete_ == null)
				{
					IsComplete = new BoolSyncWrapper();
				}
				input.ReadMessage(IsComplete);
				break;
			case 50u:
				completeRequirementGuidList_.AddEntriesFrom(input, _repeated_completeRequirementGuidList_codec);
				break;
			}
		}
	}
}
