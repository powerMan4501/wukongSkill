using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class FindSessionRequest : IMessage<FindSessionRequest>, IMessage, IEquatable<FindSessionRequest>, IDeepCloneable<FindSessionRequest>
{
	private static readonly MessageParser<FindSessionRequest> _parser = new MessageParser<FindSessionRequest>(() => new FindSessionRequest());

	private UnknownFieldSet _unknownFields;

	private ulong userId_;

	private SessionSearch search_;

	public static MessageParser<FindSessionRequest> Parser => _parser;

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

	public SessionSearch Search
	{
		get
		{
			return search_;
		}
		set
		{
			search_ = value;
		}
	}

	public FindSessionRequest()
	{
	}

	public FindSessionRequest(FindSessionRequest other)
		: this()
	{
		userId_ = other.userId_;
		search_ = ((other.search_ != null) ? other.search_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FindSessionRequest Clone()
	{
		return new FindSessionRequest(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FindSessionRequest);
	}

	public bool Equals(FindSessionRequest other)
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
		if (!object.Equals(Search, other.Search))
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
		if (search_ != null)
		{
			num ^= Search.GetHashCode();
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
		if (search_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Search);
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
		if (search_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Search);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FindSessionRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UserId != 0L)
		{
			UserId = other.UserId;
		}
		if (other.search_ != null)
		{
			if (search_ == null)
			{
				Search = new SessionSearch();
			}
			Search.MergeFrom(other.Search);
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
			case 8u:
				UserId = input.ReadUInt64();
				break;
			case 18u:
				if (search_ == null)
				{
					Search = new SessionSearch();
				}
				input.ReadMessage(Search);
				break;
			}
		}
	}
}
