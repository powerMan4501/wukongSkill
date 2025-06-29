using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class UserAuthResult : IMessage<UserAuthResult>, IMessage, IEquatable<UserAuthResult>, IDeepCloneable<UserAuthResult>
{
	private static readonly MessageParser<UserAuthResult> _parser = new MessageParser<UserAuthResult>(() => new UserAuthResult());

	private UnknownFieldSet _unknownFields;

	private long aid_;

	private static readonly FieldCodec<string> _repeated_bindChannelList_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> bindChannelList_ = new RepeatedField<string>();

	private int bindTimes_;

	private string channelUid_ = "";

	private string channelId_ = "";

	public static MessageParser<UserAuthResult> Parser => _parser;

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

	public RepeatedField<string> BindChannelList => bindChannelList_;

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

	public UserAuthResult()
	{
	}

	public UserAuthResult(UserAuthResult other)
		: this()
	{
		aid_ = other.aid_;
		bindChannelList_ = other.bindChannelList_.Clone();
		bindTimes_ = other.bindTimes_;
		channelUid_ = other.channelUid_;
		channelId_ = other.channelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UserAuthResult Clone()
	{
		return new UserAuthResult(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UserAuthResult);
	}

	public bool Equals(UserAuthResult other)
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
		if (!bindChannelList_.Equals(other.bindChannelList_))
		{
			return false;
		}
		if (BindTimes != other.BindTimes)
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
		num ^= bindChannelList_.GetHashCode();
		if (BindTimes != 0)
		{
			num ^= BindTimes.GetHashCode();
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
		bindChannelList_.WriteTo(output, _repeated_bindChannelList_codec);
		if (BindTimes != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BindTimes);
		}
		if (ChannelUid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ChannelUid);
		}
		if (ChannelId.Length != 0)
		{
			output.WriteRawTag(42);
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
		num += bindChannelList_.CalculateSize(_repeated_bindChannelList_codec);
		if (BindTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BindTimes);
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

	public void MergeFrom(UserAuthResult other)
	{
		if (other != null)
		{
			if (other.Aid != 0L)
			{
				Aid = other.Aid;
			}
			bindChannelList_.Add(other.bindChannelList_);
			if (other.BindTimes != 0)
			{
				BindTimes = other.BindTimes;
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
				bindChannelList_.AddEntriesFrom(input, _repeated_bindChannelList_codec);
				break;
			case 24u:
				BindTimes = input.ReadInt32();
				break;
			case 34u:
				ChannelUid = input.ReadString();
				break;
			case 42u:
				ChannelId = input.ReadString();
				break;
			}
		}
	}
}
