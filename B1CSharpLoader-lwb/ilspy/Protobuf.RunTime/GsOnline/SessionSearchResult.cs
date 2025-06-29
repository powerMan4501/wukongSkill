using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GsOnline;

public sealed class SessionSearchResult : IMessage<SessionSearchResult>, IMessage, IEquatable<SessionSearchResult>, IDeepCloneable<SessionSearchResult>
{
	private static readonly MessageParser<SessionSearchResult> _parser = new MessageParser<SessionSearchResult>(() => new SessionSearchResult());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<SessionInfo> _repeated_sessionList_codec = FieldCodec.ForMessage(10u, SessionInfo.Parser);

	private readonly RepeatedField<SessionInfo> sessionList_ = new RepeatedField<SessionInfo>();

	public static MessageParser<SessionSearchResult> Parser => _parser;

	public RepeatedField<SessionInfo> SessionList => sessionList_;

	public SessionSearchResult()
	{
	}

	public SessionSearchResult(SessionSearchResult other)
		: this()
	{
		sessionList_ = other.sessionList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SessionSearchResult Clone()
	{
		return new SessionSearchResult(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionSearchResult);
	}

	public bool Equals(SessionSearchResult other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!sessionList_.Equals(other.sessionList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= sessionList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		sessionList_.WriteTo(output, _repeated_sessionList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += sessionList_.CalculateSize(_repeated_sessionList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SessionSearchResult other)
	{
		if (other != null)
		{
			sessionList_.Add(other.sessionList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				sessionList_.AddEntriesFrom(input, _repeated_sessionList_codec);
			}
		}
	}
}
