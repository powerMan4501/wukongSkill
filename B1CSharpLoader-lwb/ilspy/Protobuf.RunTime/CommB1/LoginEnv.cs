using System;
using Google.Protobuf;

namespace CommB1;

public sealed class LoginEnv : IMessage<LoginEnv>, IMessage, IEquatable<LoginEnv>, IDeepCloneable<LoginEnv>
{
	private static readonly MessageParser<LoginEnv> _parser = new MessageParser<LoginEnv>(() => new LoginEnv());

	private UnknownFieldSet _unknownFields;

	private string loginChannel_ = "";

	private string loginSubChannel_ = "";

	private string loginChannelUid_ = "";

	private string loginExt_ = "";

	public static MessageParser<LoginEnv> Parser => _parser;

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

	public string LoginExt
	{
		get
		{
			return loginExt_;
		}
		set
		{
			loginExt_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public LoginEnv()
	{
	}

	public LoginEnv(LoginEnv other)
		: this()
	{
		loginChannel_ = other.loginChannel_;
		loginSubChannel_ = other.loginSubChannel_;
		loginChannelUid_ = other.loginChannelUid_;
		loginExt_ = other.loginExt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LoginEnv Clone()
	{
		return new LoginEnv(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LoginEnv);
	}

	public bool Equals(LoginEnv other)
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
		if (LoginExt != other.LoginExt)
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
		if (LoginExt.Length != 0)
		{
			num ^= LoginExt.GetHashCode();
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
		if (LoginExt.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(LoginExt);
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
		if (LoginExt.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoginExt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LoginEnv other)
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
			if (other.LoginExt.Length != 0)
			{
				LoginExt = other.LoginExt;
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
			case 34u:
				LoginExt = input.ReadString();
				break;
			}
		}
	}
}
