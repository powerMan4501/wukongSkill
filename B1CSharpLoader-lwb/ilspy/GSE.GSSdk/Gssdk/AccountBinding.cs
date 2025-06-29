using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AccountBinding : IMessage<AccountBinding>, IMessage, IEquatable<AccountBinding>, IDeepCloneable<AccountBinding>
{
	private static readonly MessageParser<AccountBinding> _parser = new MessageParser<AccountBinding>(() => new AccountBinding());

	private UnknownFieldSet _unknownFields;

	private long aid_;

	private string channelUid_ = "";

	private string channelId_ = "";

	public static MessageParser<AccountBinding> Parser => _parser;

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

	public AccountBinding()
	{
	}

	public AccountBinding(AccountBinding other)
		: this()
	{
		aid_ = other.aid_;
		channelUid_ = other.channelUid_;
		channelId_ = other.channelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AccountBinding Clone()
	{
		return new AccountBinding(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AccountBinding);
	}

	public bool Equals(AccountBinding other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Aid != other.Aid)
		{
			return false;
		}
		if (ChannelUid != other.ChannelUid)
		{
			return false;
		}
		if (ChannelId != other.ChannelId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Aid != 0L)
		{
			num ^= Aid.GetHashCode();
		}
		if (ChannelUid.Length != 0)
		{
			num ^= ChannelUid.GetHashCode();
		}
		if (ChannelId.Length != 0)
		{
			num ^= ChannelId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Aid != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Aid);
		}
		if (ChannelUid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ChannelUid);
		}
		if (ChannelId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ChannelId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Aid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Aid);
		}
		if (ChannelUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChannelUid);
		}
		if (ChannelId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChannelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AccountBinding other)
	{
		if (other != null)
		{
			if (other.Aid != 0L)
			{
				Aid = other.Aid;
			}
			if (other.ChannelUid.Length != 0)
			{
				ChannelUid = other.ChannelUid;
			}
			if (other.ChannelId.Length != 0)
			{
				ChannelId = other.ChannelId;
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
				Aid = input.ReadInt64();
				break;
			case 18u:
				ChannelUid = input.ReadString();
				break;
			case 26u:
				ChannelId = input.ReadString();
				break;
			}
		}
	}
}
