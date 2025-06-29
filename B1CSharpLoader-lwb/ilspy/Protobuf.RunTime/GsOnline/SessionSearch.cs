using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class SessionSearch : IMessage<SessionSearch>, IMessage, IEquatable<SessionSearch>, IDeepCloneable<SessionSearch>
{
	private static readonly MessageParser<SessionSearch> _parser = new MessageParser<SessionSearch>(() => new SessionSearch());

	private UnknownFieldSet _unknownFields;

	private int maxSearchResult_;

	private int searchTimeout_;

	public static MessageParser<SessionSearch> Parser => _parser;

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

	public int SearchTimeout
	{
		get
		{
			return searchTimeout_;
		}
		set
		{
			searchTimeout_ = value;
		}
	}

	public SessionSearch()
	{
	}

	public SessionSearch(SessionSearch other)
		: this()
	{
		maxSearchResult_ = other.maxSearchResult_;
		searchTimeout_ = other.searchTimeout_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SessionSearch Clone()
	{
		return new SessionSearch(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionSearch);
	}

	public bool Equals(SessionSearch other)
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
		if (SearchTimeout != other.SearchTimeout)
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
		if (SearchTimeout != 0)
		{
			num ^= SearchTimeout.GetHashCode();
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
		if (SearchTimeout != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SearchTimeout);
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
		if (SearchTimeout != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SearchTimeout);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SessionSearch other)
	{
		if (other != null)
		{
			if (other.MaxSearchResult != 0)
			{
				MaxSearchResult = other.MaxSearchResult;
			}
			if (other.SearchTimeout != 0)
			{
				SearchTimeout = other.SearchTimeout;
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
				MaxSearchResult = input.ReadInt32();
				break;
			case 16u:
				SearchTimeout = input.ReadInt32();
				break;
			}
		}
	}
}
