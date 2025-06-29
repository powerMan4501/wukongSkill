using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorSetShortCut : IMessage<CSMsgActorSetShortCut>, IMessage, IEquatable<CSMsgActorSetShortCut>, IDeepCloneable<CSMsgActorSetShortCut>
{
	private static readonly MessageParser<CSMsgActorSetShortCut> _parser = new MessageParser<CSMsgActorSetShortCut>(() => new CSMsgActorSetShortCut());

	private UnknownFieldSet _unknownFields;

	private CSMsgActorSetShortCutReq req_;

	private CSMsgActorSetShortCutRes res_;

	public static MessageParser<CSMsgActorSetShortCut> Parser => _parser;

	public CSMsgActorSetShortCutReq Req
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

	public CSMsgActorSetShortCutRes Res
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

	public CSMsgActorSetShortCut()
	{
	}

	public CSMsgActorSetShortCut(CSMsgActorSetShortCut other)
		: this()
	{
		req_ = ((other.req_ != null) ? other.req_.Clone() : null);
		res_ = ((other.res_ != null) ? other.res_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorSetShortCut Clone()
	{
		return new CSMsgActorSetShortCut(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorSetShortCut);
	}

	public bool Equals(CSMsgActorSetShortCut other)
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

	public void MergeFrom(CSMsgActorSetShortCut other)
	{
		if (other == null)
		{
			return;
		}
		if (other.req_ != null)
		{
			if (req_ == null)
			{
				Req = new CSMsgActorSetShortCutReq();
			}
			Req.MergeFrom(other.Req);
		}
		if (other.res_ != null)
		{
			if (res_ == null)
			{
				Res = new CSMsgActorSetShortCutRes();
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
					Req = new CSMsgActorSetShortCutReq();
				}
				input.ReadMessage(Req);
				break;
			case 18u:
				if (res_ == null)
				{
					Res = new CSMsgActorSetShortCutRes();
				}
				input.ReadMessage(Res);
				break;
			}
		}
	}
}
