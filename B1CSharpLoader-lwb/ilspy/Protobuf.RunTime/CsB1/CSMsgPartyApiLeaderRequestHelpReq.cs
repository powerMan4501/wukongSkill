using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderRequestHelpReq : IMessage<CSMsgPartyApiLeaderRequestHelpReq>, IMessage, IEquatable<CSMsgPartyApiLeaderRequestHelpReq>, IDeepCloneable<CSMsgPartyApiLeaderRequestHelpReq>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderRequestHelpReq> _parser = new MessageParser<CSMsgPartyApiLeaderRequestHelpReq>(() => new CSMsgPartyApiLeaderRequestHelpReq());

	private UnknownFieldSet _unknownFields;

	private PartyHelpParam helpParam_;

	public static MessageParser<CSMsgPartyApiLeaderRequestHelpReq> Parser => _parser;

	public PartyHelpParam HelpParam
	{
		get
		{
			return helpParam_;
		}
		set
		{
			helpParam_ = value;
		}
	}

	public CSMsgPartyApiLeaderRequestHelpReq()
	{
	}

	public CSMsgPartyApiLeaderRequestHelpReq(CSMsgPartyApiLeaderRequestHelpReq other)
		: this()
	{
		helpParam_ = ((other.helpParam_ != null) ? other.helpParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderRequestHelpReq Clone()
	{
		return new CSMsgPartyApiLeaderRequestHelpReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderRequestHelpReq);
	}

	public bool Equals(CSMsgPartyApiLeaderRequestHelpReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HelpParam, other.HelpParam))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (helpParam_ != null)
		{
			num ^= HelpParam.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (helpParam_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(HelpParam);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (helpParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HelpParam);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgPartyApiLeaderRequestHelpReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.helpParam_ != null)
		{
			if (helpParam_ == null)
			{
				HelpParam = new PartyHelpParam();
			}
			HelpParam.MergeFrom(other.HelpParam);
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
			if (helpParam_ == null)
			{
				HelpParam = new PartyHelpParam();
			}
			input.ReadMessage(HelpParam);
		}
	}
}
