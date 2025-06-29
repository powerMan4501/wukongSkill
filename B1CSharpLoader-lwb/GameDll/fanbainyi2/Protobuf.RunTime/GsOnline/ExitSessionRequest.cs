using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class ExitSessionRequest : IMessage<ExitSessionRequest>, IMessage, IEquatable<ExitSessionRequest>, IDeepCloneable<ExitSessionRequest>
{
	private static readonly MessageParser<ExitSessionRequest> _parser = new MessageParser<ExitSessionRequest>(() => new ExitSessionRequest());

	private UnknownFieldSet _unknownFields;

	private ulong userId_;

	private ulong sessionId_;

	public static MessageParser<ExitSessionRequest> Parser => _parser;

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

	public ExitSessionRequest()
	{
	}

	public ExitSessionRequest(ExitSessionRequest other)
		: this()
	{
		userId_ = other.userId_;
		sessionId_ = other.sessionId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ExitSessionRequest Clone()
	{
		return new ExitSessionRequest(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ExitSessionRequest);
	}

	public bool Equals(ExitSessionRequest other)
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
		if (SessionId != 0L)
		{
			output.WriteRawTag(16);
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

	public void MergeFrom(ExitSessionRequest other)
	{
		if (other != null)
		{
			if (other.UserId != 0L)
			{
				UserId = other.UserId;
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
			case 16u:
				SessionId = input.ReadUInt64();
				break;
			}
		}
	}
}
