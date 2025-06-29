using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnitEncounter : IMessage<CSMsgActorUnitEncounter>, IMessage, IEquatable<CSMsgActorUnitEncounter>, IDeepCloneable<CSMsgActorUnitEncounter>
{
	private static readonly MessageParser<CSMsgActorUnitEncounter> _parser = new MessageParser<CSMsgActorUnitEncounter>(() => new CSMsgActorUnitEncounter());

	private UnknownFieldSet _unknownFields;

	private CSMsgActorUnitEncounterReq req_;

	private CSMsgActorUnitEncounterRes res_;

	public static MessageParser<CSMsgActorUnitEncounter> Parser => _parser;

	public CSMsgActorUnitEncounterReq Req
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

	public CSMsgActorUnitEncounterRes Res
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

	public CSMsgActorUnitEncounter()
	{
	}

	public CSMsgActorUnitEncounter(CSMsgActorUnitEncounter other)
		: this()
	{
		req_ = ((other.req_ != null) ? other.req_.Clone() : null);
		res_ = ((other.res_ != null) ? other.res_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnitEncounter Clone()
	{
		return new CSMsgActorUnitEncounter(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnitEncounter);
	}

	public bool Equals(CSMsgActorUnitEncounter other)
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

	public void MergeFrom(CSMsgActorUnitEncounter other)
	{
		if (other == null)
		{
			return;
		}
		if (other.req_ != null)
		{
			if (req_ == null)
			{
				Req = new CSMsgActorUnitEncounterReq();
			}
			Req.MergeFrom(other.Req);
		}
		if (other.res_ != null)
		{
			if (res_ == null)
			{
				Res = new CSMsgActorUnitEncounterRes();
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
					Req = new CSMsgActorUnitEncounterReq();
				}
				input.ReadMessage(Req);
				break;
			case 18u:
				if (res_ == null)
				{
					Res = new CSMsgActorUnitEncounterRes();
				}
				input.ReadMessage(Res);
				break;
			}
		}
	}
}
