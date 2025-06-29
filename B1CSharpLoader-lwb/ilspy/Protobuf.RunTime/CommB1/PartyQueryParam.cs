using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyQueryParam : IMessage<PartyQueryParam>, IMessage, IEquatable<PartyQueryParam>, IDeepCloneable<PartyQueryParam>
{
	private static readonly MessageParser<PartyQueryParam> _parser = new MessageParser<PartyQueryParam>(() => new PartyQueryParam());

	private UnknownFieldSet _unknownFields;

	private PartyQueryType queryType_;

	private ulong queryPartyId_;

	public static MessageParser<PartyQueryParam> Parser => _parser;

	public PartyQueryType QueryType
	{
		get
		{
			return queryType_;
		}
		set
		{
			queryType_ = value;
		}
	}

	public ulong QueryPartyId
	{
		get
		{
			return queryPartyId_;
		}
		set
		{
			queryPartyId_ = value;
		}
	}

	public PartyQueryParam()
	{
	}

	public PartyQueryParam(PartyQueryParam other)
		: this()
	{
		queryType_ = other.queryType_;
		queryPartyId_ = other.queryPartyId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyQueryParam Clone()
	{
		return new PartyQueryParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyQueryParam);
	}

	public bool Equals(PartyQueryParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QueryType != other.QueryType)
		{
			return false;
		}
		if (QueryPartyId != other.QueryPartyId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (QueryType != PartyQueryType.Role)
		{
			num ^= QueryType.GetHashCode();
		}
		if (QueryPartyId != 0L)
		{
			num ^= QueryPartyId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (QueryType != PartyQueryType.Role)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)QueryType);
		}
		if (QueryPartyId != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(QueryPartyId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (QueryType != PartyQueryType.Role)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)QueryType);
		}
		if (QueryPartyId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(QueryPartyId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyQueryParam other)
	{
		if (other != null)
		{
			if (other.QueryType != PartyQueryType.Role)
			{
				QueryType = other.QueryType;
			}
			if (other.QueryPartyId != 0L)
			{
				QueryPartyId = other.QueryPartyId;
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
				QueryType = (PartyQueryType)input.ReadEnum();
				break;
			case 16u:
				QueryPartyId = input.ReadUInt64();
				break;
			}
		}
	}
}
