using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventCreateRole : IMessage<ReportEventCreateRole>, IMessage, IEquatable<ReportEventCreateRole>, IDeepCloneable<ReportEventCreateRole>
{
	private static readonly MessageParser<ReportEventCreateRole> _parser = new MessageParser<ReportEventCreateRole>(() => new ReportEventCreateRole());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private string archiveUid_ = "";

	public static MessageParser<ReportEventCreateRole> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public string ArchiveUid
	{
		get
		{
			return archiveUid_;
		}
		set
		{
			archiveUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventCreateRole()
	{
	}

	public ReportEventCreateRole(ReportEventCreateRole other)
		: this()
	{
		roleId_ = other.roleId_;
		archiveUid_ = other.archiveUid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventCreateRole Clone()
	{
		return new ReportEventCreateRole(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventCreateRole);
	}

	public bool Equals(ReportEventCreateRole other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (ArchiveUid != other.ArchiveUid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (ArchiveUid.Length != 0)
		{
			num ^= ArchiveUid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		if (ArchiveUid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ArchiveUid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (ArchiveUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveUid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventCreateRole other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.ArchiveUid.Length != 0)
			{
				ArchiveUid = other.ArchiveUid;
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
			case 8u:
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				ArchiveUid = input.ReadString();
				break;
			}
		}
	}
}
