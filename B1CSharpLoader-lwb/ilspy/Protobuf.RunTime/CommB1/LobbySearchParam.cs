using System;
using Google.Protobuf;

namespace CommB1;

public sealed class LobbySearchParam : IMessage<LobbySearchParam>, IMessage, IEquatable<LobbySearchParam>, IDeepCloneable<LobbySearchParam>
{
	private static readonly MessageParser<LobbySearchParam> _parser = new MessageParser<LobbySearchParam>(() => new LobbySearchParam());

	private UnknownFieldSet _unknownFields;

	private int maxSearchResult_;

	public static MessageParser<LobbySearchParam> Parser => _parser;

	public int MaxSearchResult
	{
		get
		{
			return maxSearchResult_;
		}
		set
		{
			maxSearchResult_ = value;
		}
	}

	public LobbySearchParam()
	{
	}

	public LobbySearchParam(LobbySearchParam other)
		: this()
	{
		maxSearchResult_ = other.maxSearchResult_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbySearchParam Clone()
	{
		return new LobbySearchParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbySearchParam);
	}

	public bool Equals(LobbySearchParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MaxSearchResult != other.MaxSearchResult)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MaxSearchResult != 0)
		{
			num ^= MaxSearchResult.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MaxSearchResult != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MaxSearchResult);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MaxSearchResult != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxSearchResult);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobbySearchParam other)
	{
		if (other != null)
		{
			if (other.MaxSearchResult != 0)
			{
				MaxSearchResult = other.MaxSearchResult;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				MaxSearchResult = input.ReadInt32();
			}
		}
	}
}
