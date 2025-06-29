using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushRefightSyncWrapper : IMessage<BossRushRefightSyncWrapper>, IMessage, IEquatable<BossRushRefightSyncWrapper>, IDeepCloneable<BossRushRefightSyncWrapper>
{
	private static readonly MessageParser<BossRushRefightSyncWrapper> _parser = new MessageParser<BossRushRefightSyncWrapper>(() => new BossRushRefightSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<BossRushRefightBossSyncWrapper> _repeated_bossList_codec = FieldCodec.ForMessage(26u, BossRushRefightBossSyncWrapper.Parser);

	private readonly RepeatedField<BossRushRefightBossSyncWrapper> bossList_ = new RepeatedField<BossRushRefightBossSyncWrapper>();

	public static MessageParser<BossRushRefightSyncWrapper> Parser => _parser;

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

	public RepeatedField<BossRushRefightBossSyncWrapper> BossList => bossList_;

	public BossRushRefightSyncWrapper()
	{
	}

	public BossRushRefightSyncWrapper(BossRushRefightSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		bossList_ = other.bossList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushRefightSyncWrapper Clone()
	{
		return new BossRushRefightSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushRefightSyncWrapper);
	}

	public bool Equals(BossRushRefightSyncWrapper other)
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
		if (!bossList_.Equals(other.bossList_))
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
		num ^= bossList_.GetHashCode();
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
		bossList_.WriteTo(output, _repeated_bossList_codec);
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
		num += bossList_.CalculateSize(_repeated_bossList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushRefightSyncWrapper other)
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
			bossList_.Add(other.bossList_);
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
				bossList_.AddEntriesFrom(input, _repeated_bossList_codec);
				break;
			}
		}
	}
}
