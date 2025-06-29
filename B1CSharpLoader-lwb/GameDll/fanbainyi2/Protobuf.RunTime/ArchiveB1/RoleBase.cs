using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleBase : IMessage<RoleBase>, IMessage, IEquatable<RoleBase>, IDeepCloneable<RoleBase>
{
	private static readonly MessageParser<RoleBase> _parser = new MessageParser<RoleBase>(() => new RoleBase());

	private UnknownFieldSet _unknownFields;

	private ulong roleid_;

	private string name_ = "";

	private int level_;

	private int archiveId_;

	private ProtocolTag protoTag_;

	public static MessageParser<RoleBase> Parser => _parser;

	public ulong Roleid
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

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Level
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

	public int ArchiveId
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

	public ProtocolTag ProtoTag
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

	public RoleBase()
	{
	}

	public RoleBase(RoleBase other)
		: this()
	{
		roleid_ = other.roleid_;
		name_ = other.name_;
		level_ = other.level_;
		archiveId_ = other.archiveId_;
		protoTag_ = other.protoTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleBase Clone()
	{
		return new RoleBase(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleBase);
	}

	public bool Equals(RoleBase other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Roleid != other.Roleid)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (ArchiveId != other.ArchiveId)
		{
			return false;
		}
		if (ProtoTag != other.ProtoTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Roleid != 0L)
		{
			num ^= Roleid.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (ArchiveId != 0)
		{
			num ^= ArchiveId.GetHashCode();
		}
		if (ProtoTag != ProtocolTag.Default)
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
		if (Roleid != 0L)
		{
			output.WriteRawTag(9);
			output.WriteFixed64(Roleid);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Level != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Level);
		}
		if (ArchiveId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ArchiveId);
		}
		if (ProtoTag != ProtocolTag.Default)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)ProtoTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Roleid != 0L)
		{
			num += 9;
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (ArchiveId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ArchiveId);
		}
		if (ProtoTag != ProtocolTag.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ProtoTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleBase other)
	{
		if (other != null)
		{
			if (other.Roleid != 0L)
			{
				Roleid = other.Roleid;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.ArchiveId != 0)
			{
				ArchiveId = other.ArchiveId;
			}
			if (other.ProtoTag != ProtocolTag.Default)
			{
				ProtoTag = other.ProtoTag;
			}
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
			case 9u:
				Roleid = input.ReadFixed64();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 32u:
				Level = input.ReadInt32();
				break;
			case 56u:
				ArchiveId = input.ReadInt32();
				break;
			case 88u:
				ProtoTag = (ProtocolTag)input.ReadEnum();
				break;
			}
		}
	}
}
