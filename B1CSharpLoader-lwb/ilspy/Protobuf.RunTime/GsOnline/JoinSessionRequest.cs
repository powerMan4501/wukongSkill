using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class JoinSessionRequest : IMessage<JoinSessionRequest>, IMessage, IEquatable<JoinSessionRequest>, IDeepCloneable<JoinSessionRequest>
{
	private static readonly MessageParser<JoinSessionRequest> _parser = new MessageParser<JoinSessionRequest>(() => new JoinSessionRequest());

	private UnknownFieldSet _unknownFields;

	private ulong userId_;

	private string userName_ = "";

	private ulong sessionId_;

	public static MessageParser<JoinSessionRequest> Parser => _parser;

	public ulong UserId
	{
		get
		{
			return userId_;
		}
		set
		{
			userId_ = value;
		}
	}

	public string UserName
	{
		get
		{
			return userName_;
		}
		set
		{
			userName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ulong SessionId
	{
		get
		{
			return sessionId_;
		}
		set
		{
			sessionId_ = value;
		}
	}

	public JoinSessionRequest()
	{
	}

	public JoinSessionRequest(JoinSessionRequest other)
		: this()
	{
		userId_ = other.userId_;
		userName_ = other.userName_;
		sessionId_ = other.sessionId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public JoinSessionRequest Clone()
	{
		return new JoinSessionRequest(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as JoinSessionRequest);
	}

	public bool Equals(JoinSessionRequest other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UserId != other.UserId)
		{
			return false;
		}
		if (UserName != other.UserName)
		{
			return false;
		}
		if (SessionId != other.SessionId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UserId != 0L)
		{
			num ^= UserId.GetHashCode();
		}
		if (UserName.Length != 0)
		{
			num ^= UserName.GetHashCode();
		}
		if (SessionId != 0L)
		{
			num ^= SessionId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UserId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(UserId);
		}
		if (UserName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UserName);
		}
		if (SessionId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(SessionId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UserId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(UserId);
		}
		if (UserName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserName);
		}
		if (SessionId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(SessionId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(JoinSessionRequest other)
	{
		if (other != null)
		{
			if (other.UserId != 0L)
			{
				UserId = other.UserId;
			}
			if (other.UserName.Length != 0)
			{
				UserName = other.UserName;
			}
			if (other.SessionId != 0L)
			{
				SessionId = other.SessionId;
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
				UserId = input.ReadUInt64();
				break;
			case 18u:
				UserName = input.ReadString();
				break;
			case 24u:
				SessionId = input.ReadUInt64();
				break;
			}
		}
	}
}
