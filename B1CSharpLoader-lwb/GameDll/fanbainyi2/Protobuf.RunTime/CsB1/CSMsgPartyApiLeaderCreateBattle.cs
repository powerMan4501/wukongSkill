using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderCreateBattle : IMessage<CSMsgPartyApiLeaderCreateBattle>, IMessage, IEquatable<CSMsgPartyApiLeaderCreateBattle>, IDeepCloneable<CSMsgPartyApiLeaderCreateBattle>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderCreateBattle> _parser = new MessageParser<CSMsgPartyApiLeaderCreateBattle>(() => new CSMsgPartyApiLeaderCreateBattle());

	private UnknownFieldSet _unknownFields;

	private CSMsgPartyApiLeaderCreateBattleReq req_;

	private CSMsgPartyApiLeaderCreateBattleRes res_;

	public static MessageParser<CSMsgPartyApiLeaderCreateBattle> Parser => _parser;

	public CSMsgPartyApiLeaderCreateBattleReq Req
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

	public CSMsgPartyApiLeaderCreateBattleRes Res
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

	public CSMsgPartyApiLeaderCreateBattle()
	{
	}

	public CSMsgPartyApiLeaderCreateBattle(CSMsgPartyApiLeaderCreateBattle other)
		: this()
	{
		req_ = ((other.req_ != null) ? other.req_.Clone() : null);
		res_ = ((other.res_ != null) ? other.res_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderCreateBattle Clone()
	{
		return new CSMsgPartyApiLeaderCreateBattle(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderCreateBattle);
	}

	public bool Equals(CSMsgPartyApiLeaderCreateBattle other)
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

	public void MergeFrom(CSMsgPartyApiLeaderCreateBattle other)
	{
		if (other == null)
		{
			return;
		}
		if (other.req_ != null)
		{
			if (req_ == null)
			{
				Req = new CSMsgPartyApiLeaderCreateBattleReq();
			}
			Req.MergeFrom(other.Req);
		}
		if (other.res_ != null)
		{
			if (res_ == null)
			{
				Res = new CSMsgPartyApiLeaderCreateBattleRes();
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
					Req = new CSMsgPartyApiLeaderCreateBattleReq();
				}
				input.ReadMessage(Req);
				break;
			case 18u:
				if (res_ == null)
				{
					Res = new CSMsgPartyApiLeaderCreateBattleRes();
				}
				input.ReadMessage(Res);
				break;
			}
		}
	}
}
