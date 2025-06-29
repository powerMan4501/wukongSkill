using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthUserChannelVerify : IMessage<AuthUserChannelVerify>, IMessage, IEquatable<AuthUserChannelVerify>, IDeepCloneable<AuthUserChannelVerify>
{
	private static readonly MessageParser<AuthUserChannelVerify> _parser = new MessageParser<AuthUserChannelVerify>(() => new AuthUserChannelVerify());

	private UnknownFieldSet _unknownFields;

	private string channelId_ = "";

	private string token_ = "";

	private string gsuserpassTodoDel_ = "";

	private ByteDanceVerify bytedanceTodoDel_;

	private string subChannel_ = "";

	private string channelUid_ = "";

	public static MessageParser<AuthUserChannelVerify> Parser => _parser;

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

	public string Token
	{
		get
		{
			return token_;
		}
		set
		{
			token_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string GsuserpassTodoDel
	{
		get
		{
			return gsuserpassTodoDel_;
		}
		set
		{
			gsuserpassTodoDel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ByteDanceVerify BytedanceTodoDel
	{
		get
		{
			return bytedanceTodoDel_;
		}
		set
		{
			bytedanceTodoDel_ = value;
		}
	}

	public string SubChannel
	{
		get
		{
			return subChannel_;
		}
		set
		{
			subChannel_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public AuthUserChannelVerify()
	{
	}

	public AuthUserChannelVerify(AuthUserChannelVerify other)
		: this()
	{
		channelId_ = other.channelId_;
		token_ = other.token_;
		gsuserpassTodoDel_ = other.gsuserpassTodoDel_;
		bytedanceTodoDel_ = ((other.bytedanceTodoDel_ != null) ? other.bytedanceTodoDel_.Clone() : null);
		subChannel_ = other.subChannel_;
		channelUid_ = other.channelUid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthUserChannelVerify Clone()
	{
		return new AuthUserChannelVerify(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthUserChannelVerify);
	}

	public bool Equals(AuthUserChannelVerify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChannelId != other.ChannelId)
		{
			return false;
		}
		if (Token != other.Token)
		{
			return false;
		}
		if (GsuserpassTodoDel != other.GsuserpassTodoDel)
		{
			return false;
		}
		if (!object.Equals(BytedanceTodoDel, other.BytedanceTodoDel))
		{
			return false;
		}
		if (SubChannel != other.SubChannel)
		{
			return false;
		}
		if (ChannelUid != other.ChannelUid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ChannelId.Length != 0)
		{
			num ^= ChannelId.GetHashCode();
		}
		if (Token.Length != 0)
		{
			num ^= Token.GetHashCode();
		}
		if (GsuserpassTodoDel.Length != 0)
		{
			num ^= GsuserpassTodoDel.GetHashCode();
		}
		if (bytedanceTodoDel_ != null)
		{
			num ^= BytedanceTodoDel.GetHashCode();
		}
		if (SubChannel.Length != 0)
		{
			num ^= SubChannel.GetHashCode();
		}
		if (ChannelUid.Length != 0)
		{
			num ^= ChannelUid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ChannelId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ChannelId);
		}
		if (Token.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Token);
		}
		if (GsuserpassTodoDel.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(GsuserpassTodoDel);
		}
		if (bytedanceTodoDel_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BytedanceTodoDel);
		}
		if (SubChannel.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(SubChannel);
		}
		if (ChannelUid.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(ChannelUid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ChannelId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChannelId);
		}
		if (Token.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Token);
		}
		if (GsuserpassTodoDel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GsuserpassTodoDel);
		}
		if (bytedanceTodoDel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BytedanceTodoDel);
		}
		if (SubChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SubChannel);
		}
		if (ChannelUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChannelUid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthUserChannelVerify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ChannelId.Length != 0)
		{
			ChannelId = other.ChannelId;
		}
		if (other.Token.Length != 0)
		{
			Token = other.Token;
		}
		if (other.GsuserpassTodoDel.Length != 0)
		{
			GsuserpassTodoDel = other.GsuserpassTodoDel;
		}
		if (other.bytedanceTodoDel_ != null)
		{
			if (bytedanceTodoDel_ == null)
			{
				BytedanceTodoDel = new ByteDanceVerify();
			}
			BytedanceTodoDel.MergeFrom(other.BytedanceTodoDel);
		}
		if (other.SubChannel.Length != 0)
		{
			SubChannel = other.SubChannel;
		}
		if (other.ChannelUid.Length != 0)
		{
			ChannelUid = other.ChannelUid;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				ChannelId = input.ReadString();
				break;
			case 18u:
				Token = input.ReadString();
				break;
			case 26u:
				GsuserpassTodoDel = input.ReadString();
				break;
			case 34u:
				if (bytedanceTodoDel_ == null)
				{
					BytedanceTodoDel = new ByteDanceVerify();
				}
				input.ReadMessage(BytedanceTodoDel);
				break;
			case 42u:
				SubChannel = input.ReadString();
				break;
			case 50u:
				ChannelUid = input.ReadString();
				break;
			}
		}
	}
}
