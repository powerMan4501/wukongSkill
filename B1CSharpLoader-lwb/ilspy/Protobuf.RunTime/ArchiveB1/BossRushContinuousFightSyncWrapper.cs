using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushContinuousFightSyncWrapper : IMessage<BossRushContinuousFightSyncWrapper>, IMessage, IEquatable<BossRushContinuousFightSyncWrapper>, IDeepCloneable<BossRushContinuousFightSyncWrapper>
{
	private static readonly MessageParser<BossRushContinuousFightSyncWrapper> _parser = new MessageParser<BossRushContinuousFightSyncWrapper>(() => new BossRushContinuousFightSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<BossRushContinuousFightGroupSyncWrapper> _repeated_bossGroups_codec = FieldCodec.ForMessage(26u, BossRushContinuousFightGroupSyncWrapper.Parser);

	private readonly RepeatedField<BossRushContinuousFightGroupSyncWrapper> bossGroups_ = new RepeatedField<BossRushContinuousFightGroupSyncWrapper>();

	public static MessageParser<BossRushContinuousFightSyncWrapper> Parser => _parser;

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

	public RepeatedField<BossRushContinuousFightGroupSyncWrapper> BossGroups => bossGroups_;

	public BossRushContinuousFightSyncWrapper()
	{
	}

	public BossRushContinuousFightSyncWrapper(BossRushContinuousFightSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		bossGroups_ = other.bossGroups_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushContinuousFightSyncWrapper Clone()
	{
		return new BossRushContinuousFightSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushContinuousFightSyncWrapper);
	}

	public bool Equals(BossRushContinuousFightSyncWrapper other)
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
		if (!bossGroups_.Equals(other.bossGroups_))
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
		num ^= bossGroups_.GetHashCode();
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
		bossGroups_.WriteTo(output, _repeated_bossGroups_codec);
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
		num += bossGroups_.CalculateSize(_repeated_bossGroups_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushContinuousFightSyncWrapper other)
	{
		if (other != null)
		{
			if (other.SyncFlag != 0)
			{
				SyncFlag = other.SyncFlag;
			}
			if (other.SyncIdx != 0)
			{
				SyncIdx = other.SyncIdx;
			}
			bossGroups_.Add(other.bossGroups_);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				bossGroups_.AddEntriesFrom(input, _repeated_bossGroups_codec);
				break;
			}
		}
	}
}
