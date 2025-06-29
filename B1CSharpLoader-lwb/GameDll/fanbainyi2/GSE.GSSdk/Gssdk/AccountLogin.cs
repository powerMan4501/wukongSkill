using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AccountLogin : IMessage<AccountLogin>, IMessage, IEquatable<AccountLogin>, IDeepCloneable<AccountLogin>
{
	private static readonly MessageParser<AccountLogin> _parser = new MessageParser<AccountLogin>(() => new AccountLogin());

	private UnknownFieldSet _unknownFields;

	private string channelUid_ = "";

	private string channelId_ = "";

	private long bindAid_;

	private uint updateTime_;

	private int bindTimes_;

	private uint createTime_;

	public static MessageParser<AccountLogin> Parser => _parser;

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

	public long BindAid
	{
		get
		{
			return bindAid_;
		}
		set
		{
			bindAid_ = value;
		}
	}

	public uint UpdateTime
	{
		get
		{
			return updateTime_;
		}
		set
		{
			updateTime_ = value;
		}
	}

	public int BindTimes
	{
		get
		{
			return bindTimes_;
		}
		set
		{
			bindTimes_ = value;
		}
	}

	public uint CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	public AccountLogin()
	{
	}

	public AccountLogin(AccountLogin other)
		: this()
	{
		channelUid_ = other.channelUid_;
		channelId_ = other.channelId_;
		bindAid_ = other.bindAid_;
		updateTime_ = other.updateTime_;
		bindTimes_ = other.bindTimes_;
		createTime_ = other.createTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AccountLogin Clone()
	{
		return new AccountLogin(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AccountLogin);
	}

	public bool Equals(AccountLogin other)
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
		if (BindAid != other.BindAid)
		{
			return false;
		}
		if (UpdateTime != other.UpdateTime)
		{
			return false;
		}
		if (BindTimes != other.BindTimes)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
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
		if (BindAid != 0L)
		{
			num ^= BindAid.GetHashCode();
		}
		if (UpdateTime != 0)
		{
			num ^= UpdateTime.GetHashCode();
		}
		if (BindTimes != 0)
		{
			num ^= BindTimes.GetHashCode();
		}
		if (CreateTime != 0)
		{
			num ^= CreateTime.GetHashCode();
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
		if (BindAid != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(BindAid);
		}
		if (UpdateTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(UpdateTime);
		}
		if (BindTimes != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BindTimes);
		}
		if (CreateTime != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CreateTime);
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
		if (BindAid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BindAid);
		}
		if (UpdateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UpdateTime);
		}
		if (BindTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BindTimes);
		}
		if (CreateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CreateTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AccountLogin other)
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
			if (other.BindAid != 0L)
			{
				BindAid = other.BindAid;
			}
			if (other.UpdateTime != 0)
			{
				UpdateTime = other.UpdateTime;
			}
			if (other.BindTimes != 0)
			{
				BindTimes = other.BindTimes;
			}
			if (other.CreateTime != 0)
			{
				CreateTime = other.CreateTime;
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
				BindAid = input.ReadInt64();
				break;
			case 32u:
				UpdateTime = input.ReadUInt32();
				break;
			case 40u:
				BindTimes = input.ReadInt32();
				break;
			case 48u:
				CreateTime = input.ReadUInt32();
				break;
			}
		}
	}
}
