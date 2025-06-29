using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthGetUserInfoReq : IMessage<AuthGetUserInfoReq>, IMessage, IEquatable<AuthGetUserInfoReq>, IDeepCloneable<AuthGetUserInfoReq>
{
	private static readonly MessageParser<AuthGetUserInfoReq> _parser = new MessageParser<AuthGetUserInfoReq>(() => new AuthGetUserInfoReq());

	private UnknownFieldSet _unknownFields;

	private string channelUid_ = "";

	private string channelId_ = "";

	private long aid_;

	private long roleid_;

	public static MessageParser<AuthGetUserInfoReq> Parser => _parser;

	public string ChannelUid
	{
		get
		{
			return channelUid_;
		}
		set
		{
			channelUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ChannelId
	{
		get
		{
			return channelId_;
		}
		set
		{
			channelId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public long Aid
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

	public long Roleid
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

	public AuthGetUserInfoReq()
	{
	}

	public AuthGetUserInfoReq(AuthGetUserInfoReq other)
		: this()
	{
		channelUid_ = other.channelUid_;
		channelId_ = other.channelId_;
		aid_ = other.aid_;
		roleid_ = other.roleid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthGetUserInfoReq Clone()
	{
		return new AuthGetUserInfoReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthGetUserInfoReq);
	}

	public bool Equals(AuthGetUserInfoReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChannelUid != other.ChannelUid)
		{
			return false;
		}
		if (ChannelId != other.ChannelId)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ChannelUid.Length != 0)
		{
			num ^= ChannelUid.GetHashCode();
		}
		if (ChannelId.Length != 0)
		{
			num ^= ChannelId.GetHashCode();
		}
		if (Aid != 0L)
		{
			num ^= Aid.GetHashCode();
		}
		if (Roleid != 0L)
		{
			num ^= Roleid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ChannelUid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ChannelUid);
		}
		if (ChannelId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ChannelId);
		}
		if (Aid != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(Aid);
		}
		if (Roleid != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(Roleid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ChannelUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChannelUid);
		}
		if (ChannelId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChannelId);
		}
		if (Aid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Aid);
		}
		if (Roleid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Roleid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthGetUserInfoReq other)
	{
		if (other != null)
		{
			if (other.ChannelUid.Length != 0)
			{
				ChannelUid = other.ChannelUid;
			}
			if (other.ChannelId.Length != 0)
			{
				ChannelId = other.ChannelId;
			}
			if (other.Aid != 0L)
			{
				Aid = other.Aid;
			}
			if (other.Roleid != 0L)
			{
				Roleid = other.Roleid;
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
				ChannelUid = input.ReadString();
				break;
			case 18u:
				ChannelId = input.ReadString();
				break;
			case 24u:
				Aid = input.ReadInt64();
				break;
			case 32u:
				Roleid = input.ReadInt64();
				break;
			}
		}
	}
}
