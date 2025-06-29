using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomQueryPartyInfoCSReq : IMessage<CSMsgRoomQueryPartyInfoCSReq>, IMessage, IEquatable<CSMsgRoomQueryPartyInfoCSReq>, IDeepCloneable<CSMsgRoomQueryPartyInfoCSReq>
{
	private static readonly MessageParser<CSMsgRoomQueryPartyInfoCSReq> _parser = new MessageParser<CSMsgRoomQueryPartyInfoCSReq>(() => new CSMsgRoomQueryPartyInfoCSReq());

	private UnknownFieldSet _unknownFields;

	private PartyQueryParam queryParam_;

	public static MessageParser<CSMsgRoomQueryPartyInfoCSReq> Parser => _parser;

	public PartyQueryParam QueryParam
	{
		get
		{
			return queryParam_;
		}
		set
		{
			queryParam_ = value;
		}
	}

	public CSMsgRoomQueryPartyInfoCSReq()
	{
	}

	public CSMsgRoomQueryPartyInfoCSReq(CSMsgRoomQueryPartyInfoCSReq other)
		: this()
	{
		queryParam_ = ((other.queryParam_ != null) ? other.queryParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomQueryPartyInfoCSReq Clone()
	{
		return new CSMsgRoomQueryPartyInfoCSReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomQueryPartyInfoCSReq);
	}

	public bool Equals(CSMsgRoomQueryPartyInfoCSReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(QueryParam, other.QueryParam))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (queryParam_ != null)
		{
			num ^= QueryParam.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (queryParam_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(QueryParam);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (queryParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QueryParam);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomQueryPartyInfoCSReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.queryParam_ != null)
		{
			if (queryParam_ == null)
			{
				QueryParam = new PartyQueryParam();
			}
			QueryParam.MergeFrom(other.QueryParam);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (queryParam_ == null)
			{
				QueryParam = new PartyQueryParam();
			}
			input.ReadMessage(QueryParam);
		}
	}
}
