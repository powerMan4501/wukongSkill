using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class RoleBaseSyncWrapper : IMessage<RoleBaseSyncWrapper>, IMessage, IEquatable<RoleBaseSyncWrapper>, IDeepCloneable<RoleBaseSyncWrapper>
{
	private static readonly MessageParser<RoleBaseSyncWrapper> _parser = new MessageParser<RoleBaseSyncWrapper>(() => new RoleBaseSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Fixed64SyncWrapper roleid_;

	private StringSyncWrapper name_;

	private Int32SyncWrapper level_;

	private Int32SyncWrapper archiveId_;

	private ProtocolTagSyncWrapper protoTag_;

	public static MessageParser<RoleBaseSyncWrapper> Parser => _parser;

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

	public Fixed64SyncWrapper Roleid
	{
		get
		{
			return roleid_;
		}
		set
		{
			roleid_ = value;
		}
	}

	public StringSyncWrapper Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = value;
		}
	}

	public Int32SyncWrapper Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public Int32SyncWrapper ArchiveId
	{
		get
		{
			return archiveId_;
		}
		set
		{
			archiveId_ = value;
		}
	}

	public ProtocolTagSyncWrapper ProtoTag
	{
		get
		{
			return protoTag_;
		}
		set
		{
			protoTag_ = value;
		}
	}

	public RoleBaseSyncWrapper()
	{
	}

	public RoleBaseSyncWrapper(RoleBaseSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		roleid_ = ((other.roleid_ != null) ? other.roleid_.Clone() : null);
		name_ = ((other.name_ != null) ? other.name_.Clone() : null);
		level_ = ((other.level_ != null) ? other.level_.Clone() : null);
		archiveId_ = ((other.archiveId_ != null) ? other.archiveId_.Clone() : null);
		protoTag_ = ((other.protoTag_ != null) ? other.protoTag_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleBaseSyncWrapper Clone()
	{
		return new RoleBaseSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleBaseSyncWrapper);
	}

	public bool Equals(RoleBaseSyncWrapper other)
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
		if (!object.Equals(Roleid, other.Roleid))
		{
			return false;
		}
		if (!object.Equals(Name, other.Name))
		{
			return false;
		}
		if (!object.Equals(Level, other.Level))
		{
			return false;
		}
		if (!object.Equals(ArchiveId, other.ArchiveId))
		{
			return false;
		}
		if (!object.Equals(ProtoTag, other.ProtoTag))
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
		if (roleid_ != null)
		{
			num ^= Roleid.GetHashCode();
		}
		if (name_ != null)
		{
			num ^= Name.GetHashCode();
		}
		if (level_ != null)
		{
			num ^= Level.GetHashCode();
		}
		if (archiveId_ != null)
		{
			num ^= ArchiveId.GetHashCode();
		}
		if (protoTag_ != null)
		{
			num ^= ProtoTag.GetHashCode();
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
		if (roleid_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Roleid);
		}
		if (name_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Name);
		}
		if (level_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Level);
		}
		if (archiveId_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ArchiveId);
		}
		if (protoTag_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ProtoTag);
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
		if (roleid_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Roleid);
		}
		if (name_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Name);
		}
		if (level_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Level);
		}
		if (archiveId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ArchiveId);
		}
		if (protoTag_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ProtoTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleBaseSyncWrapper other)
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
		if (other.roleid_ != null)
		{
			if (roleid_ == null)
			{
				Roleid = new Fixed64SyncWrapper();
			}
			Roleid.MergeFrom(other.Roleid);
		}
		if (other.name_ != null)
		{
			if (name_ == null)
			{
				Name = new StringSyncWrapper();
			}
			Name.MergeFrom(other.Name);
		}
		if (other.level_ != null)
		{
			if (level_ == null)
			{
				Level = new Int32SyncWrapper();
			}
			Level.MergeFrom(other.Level);
		}
		if (other.archiveId_ != null)
		{
			if (archiveId_ == null)
			{
				ArchiveId = new Int32SyncWrapper();
			}
			ArchiveId.MergeFrom(other.ArchiveId);
		}
		if (other.protoTag_ != null)
		{
			if (protoTag_ == null)
			{
				ProtoTag = new ProtocolTagSyncWrapper();
			}
			ProtoTag.MergeFrom(other.ProtoTag);
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
				if (roleid_ == null)
				{
					Roleid = new Fixed64SyncWrapper();
				}
				input.ReadMessage(Roleid);
				break;
			case 34u:
				if (name_ == null)
				{
					Name = new StringSyncWrapper();
				}
				input.ReadMessage(Name);
				break;
			case 50u:
				if (level_ == null)
				{
					Level = new Int32SyncWrapper();
				}
				input.ReadMessage(Level);
				break;
			case 74u:
				if (archiveId_ == null)
				{
					ArchiveId = new Int32SyncWrapper();
				}
				input.ReadMessage(ArchiveId);
				break;
			case 106u:
				if (protoTag_ == null)
				{
					ProtoTag = new ProtocolTagSyncWrapper();
				}
				input.ReadMessage(ProtoTag);
				break;
			}
		}
	}
}
