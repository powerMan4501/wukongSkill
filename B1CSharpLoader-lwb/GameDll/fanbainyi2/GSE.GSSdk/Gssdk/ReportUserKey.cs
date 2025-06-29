using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportUserKey : IMessage<ReportUserKey>, IMessage, IEquatable<ReportUserKey>, IDeepCloneable<ReportUserKey>
{
	private static readonly MessageParser<ReportUserKey> _parser = new MessageParser<ReportUserKey>(() => new ReportUserKey());

	private UnknownFieldSet _unknownFields;

	private string deviceId_ = "";

	private ulong aid_;

	private ulong roleid_;

	private string sessionUuid_ = "";

	private string shareArchiveUuid_ = "";

	private string env_ = "";

	private string devBranch_ = "";

	public static MessageParser<ReportUserKey> Parser => _parser;

	public string DeviceId
	{
		get
		{
			return deviceId_;
		}
		set
		{
			deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ulong Aid
	{
		get
		{
			return aid_;
		}
		set
		{
			aid_ = value;
		}
	}

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

	public string SessionUuid
	{
		get
		{
			return sessionUuid_;
		}
		set
		{
			sessionUuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ShareArchiveUuid
	{
		get
		{
			return shareArchiveUuid_;
		}
		set
		{
			shareArchiveUuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Env
	{
		get
		{
			return env_;
		}
		set
		{
			env_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DevBranch
	{
		get
		{
			return devBranch_;
		}
		set
		{
			devBranch_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportUserKey()
	{
	}

	public ReportUserKey(ReportUserKey other)
		: this()
	{
		deviceId_ = other.deviceId_;
		aid_ = other.aid_;
		roleid_ = other.roleid_;
		sessionUuid_ = other.sessionUuid_;
		shareArchiveUuid_ = other.shareArchiveUuid_;
		env_ = other.env_;
		devBranch_ = other.devBranch_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportUserKey Clone()
	{
		return new ReportUserKey(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportUserKey);
	}

	public bool Equals(ReportUserKey other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DeviceId != other.DeviceId)
		{
			return false;
		}
		if (Aid != other.Aid)
		{
			return false;
		}
		if (Roleid != other.Roleid)
		{
			return false;
		}
		if (SessionUuid != other.SessionUuid)
		{
			return false;
		}
		if (ShareArchiveUuid != other.ShareArchiveUuid)
		{
			return false;
		}
		if (Env != other.Env)
		{
			return false;
		}
		if (DevBranch != other.DevBranch)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DeviceId.Length != 0)
		{
			num ^= DeviceId.GetHashCode();
		}
		if (Aid != 0L)
		{
			num ^= Aid.GetHashCode();
		}
		if (Roleid != 0L)
		{
			num ^= Roleid.GetHashCode();
		}
		if (SessionUuid.Length != 0)
		{
			num ^= SessionUuid.GetHashCode();
		}
		if (ShareArchiveUuid.Length != 0)
		{
			num ^= ShareArchiveUuid.GetHashCode();
		}
		if (Env.Length != 0)
		{
			num ^= Env.GetHashCode();
		}
		if (DevBranch.Length != 0)
		{
			num ^= DevBranch.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DeviceId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(DeviceId);
		}
		if (Aid != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Aid);
		}
		if (Roleid != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(Roleid);
		}
		if (SessionUuid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SessionUuid);
		}
		if (ShareArchiveUuid.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ShareArchiveUuid);
		}
		if (Env.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Env);
		}
		if (DevBranch.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(DevBranch);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DeviceId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
		}
		if (Aid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Aid);
		}
		if (Roleid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Roleid);
		}
		if (SessionUuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SessionUuid);
		}
		if (ShareArchiveUuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ShareArchiveUuid);
		}
		if (Env.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Env);
		}
		if (DevBranch.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DevBranch);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportUserKey other)
	{
		if (other != null)
		{
			if (other.DeviceId.Length != 0)
			{
				DeviceId = other.DeviceId;
			}
			if (other.Aid != 0L)
			{
				Aid = other.Aid;
			}
			if (other.Roleid != 0L)
			{
				Roleid = other.Roleid;
			}
			if (other.SessionUuid.Length != 0)
			{
				SessionUuid = other.SessionUuid;
			}
			if (other.ShareArchiveUuid.Length != 0)
			{
				ShareArchiveUuid = other.ShareArchiveUuid;
			}
			if (other.Env.Length != 0)
			{
				Env = other.Env;
			}
			if (other.DevBranch.Length != 0)
			{
				DevBranch = other.DevBranch;
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
			case 10u:
				DeviceId = input.ReadString();
				break;
			case 16u:
				Aid = input.ReadUInt64();
				break;
			case 24u:
				Roleid = input.ReadUInt64();
				break;
			case 34u:
				SessionUuid = input.ReadString();
				break;
			case 42u:
				ShareArchiveUuid = input.ReadString();
				break;
			case 50u:
				Env = input.ReadString();
				break;
			case 58u:
				DevBranch = input.ReadString();
				break;
			}
		}
	}
}
