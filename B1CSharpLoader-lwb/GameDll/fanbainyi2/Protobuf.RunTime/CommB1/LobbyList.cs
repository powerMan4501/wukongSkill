using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class LobbyList : IMessage<LobbyList>, IMessage, IEquatable<LobbyList>, IDeepCloneable<LobbyList>
{
	private static readonly MessageParser<LobbyList> _parser = new MessageParser<LobbyList>(() => new LobbyList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<LobbyData> _repeated_lobbies_codec = FieldCodec.ForMessage(10u, LobbyData.Parser);

	private readonly RepeatedField<LobbyData> lobbies_ = new RepeatedField<LobbyData>();

	public static MessageParser<LobbyList> Parser => _parser;

	public RepeatedField<LobbyData> Lobbies => lobbies_;

	public LobbyList()
	{
	}

	public LobbyList(LobbyList other)
		: this()
	{
		lobbies_ = other.lobbies_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbyList Clone()
	{
		return new LobbyList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbyList);
	}

	public bool Equals(LobbyList other)
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

	public void MergeFrom(LobbyList other)
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
