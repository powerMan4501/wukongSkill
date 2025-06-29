using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomSearchPartyCSReq : IMessage<CSMsgRoomSearchPartyCSReq>, IMessage, IEquatable<CSMsgRoomSearchPartyCSReq>, IDeepCloneable<CSMsgRoomSearchPartyCSReq>
{
	private static readonly MessageParser<CSMsgRoomSearchPartyCSReq> _parser = new MessageParser<CSMsgRoomSearchPartyCSReq>(() => new CSMsgRoomSearchPartyCSReq());

	private UnknownFieldSet _unknownFields;

	private PartySearchParam searchParam_;

	public static MessageParser<CSMsgRoomSearchPartyCSReq> Parser => _parser;

	public PartySearchParam SearchParam
	{
		get
		{
			return searchParam_;
		}
		set
		{
			searchParam_ = value;
		}
	}

	public CSMsgRoomSearchPartyCSReq()
	{
	}

	public CSMsgRoomSearchPartyCSReq(CSMsgRoomSearchPartyCSReq other)
		: this()
	{
		searchParam_ = ((other.searchParam_ != null) ? other.searchParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomSearchPartyCSReq Clone()
	{
		return new CSMsgRoomSearchPartyCSReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomSearchPartyCSReq);
	}

	public bool Equals(CSMsgRoomSearchPartyCSReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(SearchParam, other.SearchParam))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (searchParam_ != null)
		{
			num ^= SearchParam.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (searchParam_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(SearchParam);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (searchParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SearchParam);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomSearchPartyCSReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.searchParam_ != null)
		{
			if (searchParam_ == null)
			{
				SearchParam = new PartySearchParam();
			}
			SearchParam.MergeFrom(other.SearchParam);
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
			if (searchParam_ == null)
			{
				SearchParam = new PartySearchParam();
			}
			input.ReadMessage(SearchParam);
		}
	}
}
