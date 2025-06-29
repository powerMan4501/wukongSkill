using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class LegacyTalentSyncWrapper : IMessage<LegacyTalentSyncWrapper>, IMessage, IEquatable<LegacyTalentSyncWrapper>, IDeepCloneable<LegacyTalentSyncWrapper>
{
	private static readonly MessageParser<LegacyTalentSyncWrapper> _parser = new MessageParser<LegacyTalentSyncWrapper>(() => new LegacyTalentSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper talentId_;

	private BoolSyncWrapper isActive_;

	public static MessageParser<LegacyTalentSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper TalentId
	{
		get
		{
			return talentId_;
		}
		set
		{
			talentId_ = value;
		}
	}

	public BoolSyncWrapper IsActive
	{
		get
		{
			return isActive_;
		}
		set
		{
			isActive_ = value;
		}
	}

	public LegacyTalentSyncWrapper()
	{
	}

	public LegacyTalentSyncWrapper(LegacyTalentSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		talentId_ = ((other.talentId_ != null) ? other.talentId_.Clone() : null);
		isActive_ = ((other.isActive_ != null) ? other.isActive_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LegacyTalentSyncWrapper Clone()
	{
		return new LegacyTalentSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LegacyTalentSyncWrapper);
	}

	public bool Equals(LegacyTalentSyncWrapper other)
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
		if (!object.Equals(TalentId, other.TalentId))
		{
			return false;
		}
		if (!object.Equals(IsActive, other.IsActive))
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
		if (talentId_ != null)
		{
			num ^= TalentId.GetHashCode();
		}
		if (isActive_ != null)
		{
			num ^= IsActive.GetHashCode();
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
		if (talentId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(TalentId);
		}
		if (isActive_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(IsActive);
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
		if (talentId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentId);
		}
		if (isActive_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IsActive);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LegacyTalentSyncWrapper other)
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
		if (other.talentId_ != null)
		{
			if (talentId_ == null)
			{
				TalentId = new Int32SyncWrapper();
			}
			TalentId.MergeFrom(other.TalentId);
		}
		if (other.isActive_ != null)
		{
			if (isActive_ == null)
			{
				IsActive = new BoolSyncWrapper();
			}
			IsActive.MergeFrom(other.IsActive);
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
				if (talentId_ == null)
				{
					TalentId = new Int32SyncWrapper();
				}
				input.ReadMessage(TalentId);
				break;
			case 34u:
				if (isActive_ == null)
				{
					IsActive = new BoolSyncWrapper();
				}
				input.ReadMessage(IsActive);
				break;
			}
		}
	}
}
