using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class LobbySearchResult : IMessage<LobbySearchResult>, IMessage, IEquatable<LobbySearchResult>, IDeepCloneable<LobbySearchResult>
{
	private static readonly MessageParser<LobbySearchResult> _parser = new MessageParser<LobbySearchResult>(() => new LobbySearchResult());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<LobbyInfo> _repeated_lobbies_codec = FieldCodec.ForMessage(10u, LobbyInfo.Parser);

	private readonly RepeatedField<LobbyInfo> lobbies_ = new RepeatedField<LobbyInfo>();

	public static MessageParser<LobbySearchResult> Parser => _parser;

	public RepeatedField<LobbyInfo> Lobbies => lobbies_;

	public LobbySearchResult()
	{
	}

	public LobbySearchResult(LobbySearchResult other)
		: this()
	{
		lobbies_ = other.lobbies_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbySearchResult Clone()
	{
		return new LobbySearchResult(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbySearchResult);
	}

	public bool Equals(LobbySearchResult other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lobbies_.Equals(other.lobbies_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= lobbies_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		lobbies_.WriteTo(output, _repeated_lobbies_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += lobbies_.CalculateSize(_repeated_lobbies_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobbySearchResult other)
	{
		if (other != null)
		{
			lobbies_.Add(other.lobbies_);
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
				lobbies_.AddEntriesFrom(input, _repeated_lobbies_codec);
			}
		}
	}
}
