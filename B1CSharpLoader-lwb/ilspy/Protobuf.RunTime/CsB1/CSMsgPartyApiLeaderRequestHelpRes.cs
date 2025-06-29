using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderRequestHelpRes : IMessage<CSMsgPartyApiLeaderRequestHelpRes>, IMessage, IEquatable<CSMsgPartyApiLeaderRequestHelpRes>, IDeepCloneable<CSMsgPartyApiLeaderRequestHelpRes>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderRequestHelpRes> _parser = new MessageParser<CSMsgPartyApiLeaderRequestHelpRes>(() => new CSMsgPartyApiLeaderRequestHelpRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiLeaderRequestHelpRes> Parser => _parser;

	public CSMsgPartyApiLeaderRequestHelpRes()
	{
	}

	public CSMsgPartyApiLeaderRequestHelpRes(CSMsgPartyApiLeaderRequestHelpRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderRequestHelpRes Clone()
	{
		return new CSMsgPartyApiLeaderRequestHelpRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderRequestHelpRes);
	}

	public bool Equals(CSMsgPartyApiLeaderRequestHelpRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgPartyApiLeaderRequestHelpRes other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
