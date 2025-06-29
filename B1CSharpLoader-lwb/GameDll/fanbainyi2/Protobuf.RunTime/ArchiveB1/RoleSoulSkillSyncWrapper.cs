using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class RoleSoulSkillSyncWrapper : IMessage<RoleSoulSkillSyncWrapper>, IMessage, IEquatable<RoleSoulSkillSyncWrapper>, IDeepCloneable<RoleSoulSkillSyncWrapper>
{
	private static readonly MessageParser<RoleSoulSkillSyncWrapper> _parser = new MessageParser<RoleSoulSkillSyncWrapper>(() => new RoleSoulSkillSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper soulSkillId_;

	private Uint64SyncWrapper uid_;

	public static MessageParser<RoleSoulSkillSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper SoulSkillId
	{
		get
		{
			return soulSkillId_;
		}
		set
		{
			soulSkillId_ = value;
		}
	}

	public Uint64SyncWrapper Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	public RoleSoulSkillSyncWrapper()
	{
	}

	public RoleSoulSkillSyncWrapper(RoleSoulSkillSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		soulSkillId_ = ((other.soulSkillId_ != null) ? other.soulSkillId_.Clone() : null);
		uid_ = ((other.uid_ != null) ? other.uid_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleSoulSkillSyncWrapper Clone()
	{
		return new RoleSoulSkillSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleSoulSkillSyncWrapper);
	}

	public bool Equals(RoleSoulSkillSyncWrapper other)
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
		if (!object.Equals(SoulSkillId, other.SoulSkillId))
		{
			return false;
		}
		if (!object.Equals(Uid, other.Uid))
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
		if (soulSkillId_ != null)
		{
			num ^= SoulSkillId.GetHashCode();
		}
		if (uid_ != null)
		{
			num ^= Uid.GetHashCode();
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
		if (soulSkillId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SoulSkillId);
		}
		if (uid_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Uid);
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
		if (soulSkillId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SoulSkillId);
		}
		if (uid_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleSoulSkillSyncWrapper other)
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
		if (other.soulSkillId_ != null)
		{
			if (soulSkillId_ == null)
			{
				SoulSkillId = new Int32SyncWrapper();
			}
			SoulSkillId.MergeFrom(other.SoulSkillId);
		}
		if (other.uid_ != null)
		{
			if (uid_ == null)
			{
				Uid = new Uint64SyncWrapper();
			}
			Uid.MergeFrom(other.Uid);
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
				if (soulSkillId_ == null)
				{
					SoulSkillId = new Int32SyncWrapper();
				}
				input.ReadMessage(SoulSkillId);
				break;
			case 34u:
				if (uid_ == null)
				{
					Uid = new Uint64SyncWrapper();
				}
				input.ReadMessage(Uid);
				break;
			}
		}
	}
}
