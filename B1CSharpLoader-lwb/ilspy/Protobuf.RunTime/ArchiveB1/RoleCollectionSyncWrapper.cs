using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleCollectionSyncWrapper : IMessage<RoleCollectionSyncWrapper>, IMessage, IEquatable<RoleCollectionSyncWrapper>, IDeepCloneable<RoleCollectionSyncWrapper>
{
	private static readonly MessageParser<RoleCollectionSyncWrapper> _parser = new MessageParser<RoleCollectionSyncWrapper>(() => new RoleCollectionSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<MonsterCollectionSyncWrapper> _repeated_monsterCollectionList_codec = FieldCodec.ForMessage(26u, MonsterCollectionSyncWrapper.Parser);

	private readonly RepeatedField<MonsterCollectionSyncWrapper> monsterCollectionList_ = new RepeatedField<MonsterCollectionSyncWrapper>();

	public static MessageParser<RoleCollectionSyncWrapper> Parser => _parser;

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

	public RepeatedField<MonsterCollectionSyncWrapper> MonsterCollectionList => monsterCollectionList_;

	public RoleCollectionSyncWrapper()
	{
	}

	public RoleCollectionSyncWrapper(RoleCollectionSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		monsterCollectionList_ = other.monsterCollectionList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleCollectionSyncWrapper Clone()
	{
		return new RoleCollectionSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleCollectionSyncWrapper);
	}

	public bool Equals(RoleCollectionSyncWrapper other)
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
		if (!monsterCollectionList_.Equals(other.monsterCollectionList_))
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
		num ^= monsterCollectionList_.GetHashCode();
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
		monsterCollectionList_.WriteTo(output, _repeated_monsterCollectionList_codec);
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
		num += monsterCollectionList_.CalculateSize(_repeated_monsterCollectionList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleCollectionSyncWrapper other)
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
			monsterCollectionList_.Add(other.monsterCollectionList_);
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
				monsterCollectionList_.AddEntriesFrom(input, _repeated_monsterCollectionList_codec);
				break;
			}
		}
	}
}
