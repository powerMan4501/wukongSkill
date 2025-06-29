using System;
using Google.Protobuf;

namespace CsB1;

public sealed class LoginRoleReportClientBase : IMessage<LoginRoleReportClientBase>, IMessage, IEquatable<LoginRoleReportClientBase>, IDeepCloneable<LoginRoleReportClientBase>
{
	private static readonly MessageParser<LoginRoleReportClientBase> _parser = new MessageParser<LoginRoleReportClientBase>(() => new LoginRoleReportClientBase());

	private UnknownFieldSet _unknownFields;

	private string playMode_ = "";

	private string version_ = "";

	private ulong roleId_;

	private string sdkUid_ = "";

	private string shareArchiveUid_ = "";

	private string gameSessionUuid_ = "";

	private string loginChannel_ = "";

	private string sdkUname_ = "";

	public static MessageParser<LoginRoleReportClientBase> Parser => _parser;

	public string PlayMode
	{
		get
		{
			return playMode_;
		}
		set
		{
			playMode_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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

	public string SdkUid
	{
		get
		{
			return sdkUid_;
		}
		set
		{
			sdkUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ShareArchiveUid
	{
		get
		{
			return shareArchiveUid_;
		}
		set
		{
			shareArchiveUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string GameSessionUuid
	{
		get
		{
			return gameSessionUuid_;
		}
		set
		{
			gameSessionUuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LoginChannel
	{
		get
		{
			return loginChannel_;
		}
		set
		{
			loginChannel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SdkUname
	{
		get
		{
			return sdkUname_;
		}
		set
		{
			sdkUname_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public LoginRoleReportClientBase()
	{
	}

	public LoginRoleReportClientBase(LoginRoleReportClientBase other)
		: this()
	{
		playMode_ = other.playMode_;
		version_ = other.version_;
		roleId_ = other.roleId_;
		sdkUid_ = other.sdkUid_;
		shareArchiveUid_ = other.shareArchiveUid_;
		gameSessionUuid_ = other.gameSessionUuid_;
		loginChannel_ = other.loginChannel_;
		sdkUname_ = other.sdkUname_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LoginRoleReportClientBase Clone()
	{
		return new LoginRoleReportClientBase(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LoginRoleReportClientBase);
	}

	public bool Equals(LoginRoleReportClientBase other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PlayMode != other.PlayMode)
		{
			return false;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (SdkUid != other.SdkUid)
		{
			return false;
		}
		if (ShareArchiveUid != other.ShareArchiveUid)
		{
			return false;
		}
		if (GameSessionUuid != other.GameSessionUuid)
		{
			return false;
		}
		if (LoginChannel != other.LoginChannel)
		{
			return false;
		}
		if (SdkUname != other.SdkUname)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PlayMode.Length != 0)
		{
			num ^= PlayMode.GetHashCode();
		}
		if (Version.Length != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (SdkUid.Length != 0)
		{
			num ^= SdkUid.GetHashCode();
		}
		if (ShareArchiveUid.Length != 0)
		{
			num ^= ShareArchiveUid.GetHashCode();
		}
		if (GameSessionUuid.Length != 0)
		{
			num ^= GameSessionUuid.GetHashCode();
		}
		if (LoginChannel.Length != 0)
		{
			num ^= LoginChannel.GetHashCode();
		}
		if (SdkUname.Length != 0)
		{
			num ^= SdkUname.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PlayMode.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PlayMode);
		}
		if (Version.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Version);
		}
		if (RoleId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(RoleId);
		}
		if (SdkUid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SdkUid);
		}
		if (ShareArchiveUid.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ShareArchiveUid);
		}
		if (GameSessionUuid.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(GameSessionUuid);
		}
		if (LoginChannel.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(LoginChannel);
		}
		if (SdkUname.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(SdkUname);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PlayMode.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PlayMode);
		}
		if (Version.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Version);
		}
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (SdkUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SdkUid);
		}
		if (ShareArchiveUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ShareArchiveUid);
		}
		if (GameSessionUuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GameSessionUuid);
		}
		if (LoginChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoginChannel);
		}
		if (SdkUname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SdkUname);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LoginRoleReportClientBase other)
	{
		if (other != null)
		{
			if (other.PlayMode.Length != 0)
			{
				PlayMode = other.PlayMode;
			}
			if (other.Version.Length != 0)
			{
				Version = other.Version;
			}
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.SdkUid.Length != 0)
			{
				SdkUid = other.SdkUid;
			}
			if (other.ShareArchiveUid.Length != 0)
			{
				ShareArchiveUid = other.ShareArchiveUid;
			}
			if (other.GameSessionUuid.Length != 0)
			{
				GameSessionUuid = other.GameSessionUuid;
			}
			if (other.LoginChannel.Length != 0)
			{
				LoginChannel = other.LoginChannel;
			}
			if (other.SdkUname.Length != 0)
			{
				SdkUname = other.SdkUname;
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
				PlayMode = input.ReadString();
				break;
			case 18u:
				Version = input.ReadString();
				break;
			case 24u:
				RoleId = input.ReadUInt64();
				break;
			case 34u:
				SdkUid = input.ReadString();
				break;
			case 42u:
				ShareArchiveUid = input.ReadString();
				break;
			case 50u:
				GameSessionUuid = input.ReadString();
				break;
			case 58u:
				LoginChannel = input.ReadString();
				break;
			case 66u:
				SdkUname = input.ReadString();
				break;
			}
		}
	}
}
