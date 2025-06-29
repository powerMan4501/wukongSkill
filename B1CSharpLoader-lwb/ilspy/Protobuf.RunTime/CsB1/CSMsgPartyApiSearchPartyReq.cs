using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiSearchPartyReq : IMessage<CSMsgPartyApiSearchPartyReq>, IMessage, IEquatable<CSMsgPartyApiSearchPartyReq>, IDeepCloneable<CSMsgPartyApiSearchPartyReq>
{
	private static readonly MessageParser<CSMsgPartyApiSearchPartyReq> _parser = new MessageParser<CSMsgPartyApiSearchPartyReq>(() => new CSMsgPartyApiSearchPartyReq());

	private UnknownFieldSet _unknownFields;

	private PartySearchParam searchParam_;

	public static MessageParser<CSMsgPartyApiSearchPartyReq> Parser => _parser;

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

	public CSMsgPartyApiSearchPartyReq()
	{
	}

	public CSMsgPartyApiSearchPartyReq(CSMsgPartyApiSearchPartyReq other)
		: this()
	{
		searchParam_ = ((other.searchParam_ != null) ? other.searchParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiSearchPartyReq Clone()
	{
		return new CSMsgPartyApiSearchPartyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiSearchPartyReq);
	}

	public bool Equals(CSMsgPartyApiSearchPartyReq other)
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

	public void MergeFrom(CSMsgPartyApiSearchPartyReq other)
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
