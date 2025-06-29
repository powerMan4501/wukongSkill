using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomSearchPartyCS : IMessage<CSMsgRoomSearchPartyCS>, IMessage, IEquatable<CSMsgRoomSearchPartyCS>, IDeepCloneable<CSMsgRoomSearchPartyCS>
{
	private static readonly MessageParser<CSMsgRoomSearchPartyCS> _parser = new MessageParser<CSMsgRoomSearchPartyCS>(() => new CSMsgRoomSearchPartyCS());

	private UnknownFieldSet _unknownFields;

	private CSMsgRoomSearchPartyCSReq req_;

	private CSMsgRoomSearchPartyCSRes res_;

	public static MessageParser<CSMsgRoomSearchPartyCS> Parser => _parser;

	public CSMsgRoomSearchPartyCSReq Req
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

	public CSMsgRoomSearchPartyCSRes Res
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

	public CSMsgRoomSearchPartyCS()
	{
	}

	public CSMsgRoomSearchPartyCS(CSMsgRoomSearchPartyCS other)
		: this()
	{
		req_ = ((other.req_ != null) ? other.req_.Clone() : null);
		res_ = ((other.res_ != null) ? other.res_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomSearchPartyCS Clone()
	{
		return new CSMsgRoomSearchPartyCS(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomSearchPartyCS);
	}

	public bool Equals(CSMsgRoomSearchPartyCS other)
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

	public void MergeFrom(CSMsgRoomSearchPartyCS other)
	{
		if (other == null)
		{
			return;
		}
		if (other.req_ != null)
		{
			if (req_ == null)
			{
				Req = new CSMsgRoomSearchPartyCSReq();
			}
			Req.MergeFrom(other.Req);
		}
		if (other.res_ != null)
		{
			if (res_ == null)
			{
				Res = new CSMsgRoomSearchPartyCSRes();
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
					Req = new CSMsgRoomSearchPartyCSReq();
				}
				input.ReadMessage(Req);
				break;
			case 18u:
				if (res_ == null)
				{
					Res = new CSMsgRoomSearchPartyCSRes();
				}
				input.ReadMessage(Res);
				break;
			}
		}
	}
}
