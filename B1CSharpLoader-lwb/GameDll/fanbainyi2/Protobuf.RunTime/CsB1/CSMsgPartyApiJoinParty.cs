using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiJoinParty : IMessage<CSMsgPartyApiJoinParty>, IMessage, IEquatable<CSMsgPartyApiJoinParty>, IDeepCloneable<CSMsgPartyApiJoinParty>
{
	private static readonly MessageParser<CSMsgPartyApiJoinParty> _parser = new MessageParser<CSMsgPartyApiJoinParty>(() => new CSMsgPartyApiJoinParty());

	private UnknownFieldSet _unknownFields;

	private CSMsgPartyApiJoinPartyReq req_;

	private CSMsgPartyApiJoinPartyRes res_;

	public static MessageParser<CSMsgPartyApiJoinParty> Parser => _parser;

	public CSMsgPartyApiJoinPartyReq Req
	{
		get
		{
			return req_;
		}
		set
		{
			req_ = value;
		}
	}

	public CSMsgPartyApiJoinPartyRes Res
	{
		get
		{
			return res_;
		}
		set
		{
			res_ = value;
		}
	}

	public CSMsgPartyApiJoinParty()
	{
	}

	public CSMsgPartyApiJoinParty(CSMsgPartyApiJoinParty other)
		: this()
	{
		req_ = ((other.req_ != null) ? other.req_.Clone() : null);
		res_ = ((other.res_ != null) ? other.res_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiJoinParty Clone()
	{
		return new CSMsgPartyApiJoinParty(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiJoinParty);
	}

	public bool Equals(CSMsgPartyApiJoinParty other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Req, other.Req))
		{
			return false;
		}
		if (!object.Equals(Res, other.Res))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (req_ != null)
		{
			num ^= Req.GetHashCode();
		}
		if (res_ != null)
		{
			num ^= Res.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (req_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Req);
		}
		if (res_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Res);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (req_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Req);
		}
		if (res_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Res);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgPartyApiJoinParty other)
	{
		if (other == null)
		{
			return;
		}
		if (other.req_ != null)
		{
			if (req_ == null)
			{
				Req = new CSMsgPartyApiJoinPartyReq();
			}
			Req.MergeFrom(other.Req);
		}
		if (other.res_ != null)
		{
			if (res_ == null)
			{
				Res = new CSMsgPartyApiJoinPartyRes();
			}
			Res.MergeFrom(other.Res);
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
			case 10u:
				if (req_ == null)
				{
					Req = new CSMsgPartyApiJoinPartyReq();
				}
				input.ReadMessage(Req);
				break;
			case 18u:
				if (res_ == null)
				{
					Res = new CSMsgPartyApiJoinPartyRes();
				}
				input.ReadMessage(Res);
				break;
			}
		}
	}
}
