using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleDropSyncWrapper : IMessage<RoleDropSyncWrapper>, IMessage, IEquatable<RoleDropSyncWrapper>, IDeepCloneable<RoleDropSyncWrapper>
{
	private static readonly MessageParser<RoleDropSyncWrapper> _parser = new MessageParser<RoleDropSyncWrapper>(() => new RoleDropSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<DropRecordSyncWrapper> _repeated_dropRecordList_codec = FieldCodec.ForMessage(34u, DropRecordSyncWrapper.Parser);

	private readonly RepeatedField<DropRecordSyncWrapper> dropRecordList_ = new RepeatedField<DropRecordSyncWrapper>();

	private static readonly FieldCodec<SoulSkillDropRecordSyncWrapper> _repeated_soulSkillDropList_codec = FieldCodec.ForMessage(42u, SoulSkillDropRecordSyncWrapper.Parser);

	private readonly RepeatedField<SoulSkillDropRecordSyncWrapper> soulSkillDropList_ = new RepeatedField<SoulSkillDropRecordSyncWrapper>();

	public static MessageParser<RoleDropSyncWrapper> Parser => _parser;

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

	public RepeatedField<DropRecordSyncWrapper> DropRecordList => dropRecordList_;

	public RepeatedField<SoulSkillDropRecordSyncWrapper> SoulSkillDropList => soulSkillDropList_;

	public RoleDropSyncWrapper()
	{
	}

	public RoleDropSyncWrapper(RoleDropSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		dropRecordList_ = other.dropRecordList_.Clone();
		soulSkillDropList_ = other.soulSkillDropList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDropSyncWrapper Clone()
	{
		return new RoleDropSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDropSyncWrapper);
	}

	public bool Equals(RoleDropSyncWrapper other)
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
		if (!dropRecordList_.Equals(other.dropRecordList_))
		{
			return false;
		}
		if (!soulSkillDropList_.Equals(other.soulSkillDropList_))
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
		num ^= dropRecordList_.GetHashCode();
		num ^= soulSkillDropList_.GetHashCode();
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
		dropRecordList_.WriteTo(output, _repeated_dropRecordList_codec);
		soulSkillDropList_.WriteTo(output, _repeated_soulSkillDropList_codec);
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
		num += dropRecordList_.CalculateSize(_repeated_dropRecordList_codec);
		num += soulSkillDropList_.CalculateSize(_repeated_soulSkillDropList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDropSyncWrapper other)
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
			dropRecordList_.Add(other.dropRecordList_);
			soulSkillDropList_.Add(other.soulSkillDropList_);
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
			case 34u:
				dropRecordList_.AddEntriesFrom(input, _repeated_dropRecordList_codec);
				break;
			case 42u:
				soulSkillDropList_.AddEntriesFrom(input, _repeated_soulSkillDropList_codec);
				break;
			}
		}
	}
}
