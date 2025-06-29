using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class UserAuthInfo : IMessage<UserAuthInfo>, IMessage, IEquatable<UserAuthInfo>, IDeepCloneable<UserAuthInfo>
{
	private static readonly MessageParser<UserAuthInfo> _parser = new MessageParser<UserAuthInfo>(() => new UserAuthInfo());

	private UnknownFieldSet _unknownFields;

	private string loginChannel_ = "";

	private string loginSubChannel_ = "";

	private string loginChannelUid_ = "";

	private ulong aid_;

	private ulong roleid_;

	private int localChannelSdkLoginState_;

	private string loginChannelUserName_ = "";

	private string loginChannelSdkExtension_ = "";

	public static MessageParser<UserAuthInfo> Parser => _parser;

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

	public string LoginSubChannel
	{
		get
		{
			return loginSubChannel_;
		}
		set
		{
			loginSubChannel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LoginChannelUid
	{
		get
		{
			return loginChannelUid_;
		}
		set
		{
			loginChannelUid_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int LocalChannelSdkLoginState
	{
		get
		{
			return localChannelSdkLoginState_;
		}
		set
		{
			localChannelSdkLoginState_ = value;
		}
	}

	public string LoginChannelUserName
	{
		get
		{
			return loginChannelUserName_;
		}
		set
		{
			loginChannelUserName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LoginChannelSdkExtension
	{
		get
		{
			return loginChannelSdkExtension_;
		}
		set
		{
			loginChannelSdkExtension_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public UserAuthInfo()
	{
	}

	public UserAuthInfo(UserAuthInfo other)
		: this()
	{
		loginChannel_ = other.loginChannel_;
		loginSubChannel_ = other.loginSubChannel_;
		loginChannelUid_ = other.loginChannelUid_;
		aid_ = other.aid_;
		roleid_ = other.roleid_;
		localChannelSdkLoginState_ = other.localChannelSdkLoginState_;
		loginChannelUserName_ = other.loginChannelUserName_;
		loginChannelSdkExtension_ = other.loginChannelSdkExtension_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UserAuthInfo Clone()
	{
		return new UserAuthInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UserAuthInfo);
	}

	public bool Equals(UserAuthInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LoginChannel != other.LoginChannel)
		{
			return false;
		}
		if (LoginSubChannel != other.LoginSubChannel)
		{
			return false;
		}
		if (LoginChannelUid != other.LoginChannelUid)
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
		if (LocalChannelSdkLoginState != other.LocalChannelSdkLoginState)
		{
			return false;
		}
		if (LoginChannelUserName != other.LoginChannelUserName)
		{
			return false;
		}
		if (LoginChannelSdkExtension != other.LoginChannelSdkExtension)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LoginChannel.Length != 0)
		{
			num ^= LoginChannel.GetHashCode();
		}
		if (LoginSubChannel.Length != 0)
		{
			num ^= LoginSubChannel.GetHashCode();
		}
		if (LoginChannelUid.Length != 0)
		{
			num ^= LoginChannelUid.GetHashCode();
		}
		if (Aid != 0L)
		{
			num ^= Aid.GetHashCode();
		}
		if (Roleid != 0L)
		{
			num ^= Roleid.GetHashCode();
		}
		if (LocalChannelSdkLoginState != 0)
		{
			num ^= LocalChannelSdkLoginState.GetHashCode();
		}
		if (LoginChannelUserName.Length != 0)
		{
			num ^= LoginChannelUserName.GetHashCode();
		}
		if (LoginChannelSdkExtension.Length != 0)
		{
			num ^= LoginChannelSdkExtension.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LoginChannel.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(LoginChannel);
		}
		if (LoginSubChannel.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(LoginSubChannel);
		}
		if (LoginChannelUid.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(LoginChannelUid);
		}
		if (Aid != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(Aid);
		}
		if (Roleid != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(Roleid);
		}
		if (LocalChannelSdkLoginState != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LocalChannelSdkLoginState);
		}
		if (LoginChannelUserName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(LoginChannelUserName);
		}
		if (LoginChannelSdkExtension.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(LoginChannelSdkExtension);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LoginChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoginChannel);
		}
		if (LoginSubChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoginSubChannel);
		}
		if (LoginChannelUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoginChannelUid);
		}
		if (Aid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Aid);
		}
		if (Roleid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Roleid);
		}
		if (LocalChannelSdkLoginState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalChannelSdkLoginState);
		}
		if (LoginChannelUserName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoginChannelUserName);
		}
		if (LoginChannelSdkExtension.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoginChannelSdkExtension);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UserAuthInfo other)
	{
		if (other != null)
		{
			if (other.LoginChannel.Length != 0)
			{
				LoginChannel = other.LoginChannel;
			}
			if (other.LoginSubChannel.Length != 0)
			{
				LoginSubChannel = other.LoginSubChannel;
			}
			if (other.LoginChannelUid.Length != 0)
			{
				LoginChannelUid = other.LoginChannelUid;
			}
			if (other.Aid != 0L)
			{
				Aid = other.Aid;
			}
			if (other.Roleid != 0L)
			{
				Roleid = other.Roleid;
			}
			if (other.LocalChannelSdkLoginState != 0)
			{
				LocalChannelSdkLoginState = other.LocalChannelSdkLoginState;
			}
			if (other.LoginChannelUserName.Length != 0)
			{
				LoginChannelUserName = other.LoginChannelUserName;
			}
			if (other.LoginChannelSdkExtension.Length != 0)
			{
				LoginChannelSdkExtension = other.LoginChannelSdkExtension;
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
				LoginChannel = input.ReadString();
				break;
			case 18u:
				LoginSubChannel = input.ReadString();
				break;
			case 26u:
				LoginChannelUid = input.ReadString();
				break;
			case 32u:
				Aid = input.ReadUInt64();
				break;
			case 40u:
				Roleid = input.ReadUInt64();
				break;
			case 48u:
				LocalChannelSdkLoginState = input.ReadInt32();
				break;
			case 58u:
				LoginChannelUserName = input.ReadString();
				break;
			case 66u:
				LoginChannelSdkExtension = input.ReadString();
				break;
			}
		}
	}
}
