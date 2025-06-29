using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnSetShortCut : IMessage<CSMsgActorUnSetShortCut>, IMessage, IEquatable<CSMsgActorUnSetShortCut>, IDeepCloneable<CSMsgActorUnSetShortCut>
{
	private static readonly MessageParser<CSMsgActorUnSetShortCut> _parser = new MessageParser<CSMsgActorUnSetShortCut>(() => new CSMsgActorUnSetShortCut());

	private UnknownFieldSet _unknownFields;

	private CSMsgActorUnSetShortCutReq req_;

	private CSMsgActorUnSetShortCutRes res_;

	public static MessageParser<CSMsgActorUnSetShortCut> Parser => _parser;

	public CSMsgActorUnSetShortCutReq Req
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

	public CSMsgActorUnSetShortCutRes Res
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

	public CSMsgActorUnSetShortCut()
	{
	}

	public CSMsgActorUnSetShortCut(CSMsgActorUnSetShortCut other)
		: this()
	{
		req_ = ((other.req_ != null) ? other.req_.Clone() : null);
		res_ = ((other.res_ != null) ? other.res_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnSetShortCut Clone()
	{
		return new CSMsgActorUnSetShortCut(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnSetShortCut);
	}

	public bool Equals(CSMsgActorUnSetShortCut other)
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

	public void MergeFrom(CSMsgActorUnSetShortCut other)
	{
		if (other == null)
		{
			return;
		}
		if (other.req_ != null)
		{
			if (req_ == null)
			{
				Req = new CSMsgActorUnSetShortCutReq();
			}
			Req.MergeFrom(other.Req);
		}
		if (other.res_ != null)
		{
			if (res_ == null)
			{
				Res = new CSMsgActorUnSetShortCutRes();
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
					Req = new CSMsgActorUnSetShortCutReq();
				}
				input.ReadMessage(Req);
				break;
			case 18u:
				if (res_ == null)
				{
					Res = new CSMsgActorUnSetShortCutRes();
				}
				input.ReadMessage(Res);
				break;
			}
		}
	}
}
