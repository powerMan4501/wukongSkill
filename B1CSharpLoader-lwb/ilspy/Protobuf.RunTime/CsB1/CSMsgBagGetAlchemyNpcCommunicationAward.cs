using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagGetAlchemyNpcCommunicationAward : IMessage<CSMsgBagGetAlchemyNpcCommunicationAward>, IMessage, IEquatable<CSMsgBagGetAlchemyNpcCommunicationAward>, IDeepCloneable<CSMsgBagGetAlchemyNpcCommunicationAward>
{
	private static readonly MessageParser<CSMsgBagGetAlchemyNpcCommunicationAward> _parser = new MessageParser<CSMsgBagGetAlchemyNpcCommunicationAward>(() => new CSMsgBagGetAlchemyNpcCommunicationAward());

	private UnknownFieldSet _unknownFields;

	private CSMsgBagGetAlchemyNpcCommunicationAwardReq req_;

	private CSMsgBagGetAlchemyNpcCommunicationAwardRes res_;

	public static MessageParser<CSMsgBagGetAlchemyNpcCommunicationAward> Parser => _parser;

	public CSMsgBagGetAlchemyNpcCommunicationAwardReq Req
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

	public CSMsgBagGetAlchemyNpcCommunicationAwardRes Res
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

	public CSMsgBagGetAlchemyNpcCommunicationAward()
	{
	}

	public CSMsgBagGetAlchemyNpcCommunicationAward(CSMsgBagGetAlchemyNpcCommunicationAward other)
		: this()
	{
		req_ = ((other.req_ != null) ? other.req_.Clone() : null);
		res_ = ((other.res_ != null) ? other.res_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagGetAlchemyNpcCommunicationAward Clone()
	{
		return new CSMsgBagGetAlchemyNpcCommunicationAward(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagGetAlchemyNpcCommunicationAward);
	}

	public bool Equals(CSMsgBagGetAlchemyNpcCommunicationAward other)
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

	public void MergeFrom(CSMsgBagGetAlchemyNpcCommunicationAward other)
	{
		if (other == null)
		{
			return;
		}
		if (other.req_ != null)
		{
			if (req_ == null)
			{
				Req = new CSMsgBagGetAlchemyNpcCommunicationAwardReq();
			}
			Req.MergeFrom(other.Req);
		}
		if (other.res_ != null)
		{
			if (res_ == null)
			{
				Res = new CSMsgBagGetAlchemyNpcCommunicationAwardRes();
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
					Req = new CSMsgBagGetAlchemyNpcCommunicationAwardReq();
				}
				input.ReadMessage(Req);
				break;
			case 18u:
				if (res_ == null)
				{
					Res = new CSMsgBagGetAlchemyNpcCommunicationAwardRes();
				}
				input.ReadMessage(Res);
				break;
			}
		}
	}
}
