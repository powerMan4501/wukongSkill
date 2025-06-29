using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderCancelHelpReq : IMessage<CSMsgPartyApiLeaderCancelHelpReq>, IMessage, IEquatable<CSMsgPartyApiLeaderCancelHelpReq>, IDeepCloneable<CSMsgPartyApiLeaderCancelHelpReq>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderCancelHelpReq> _parser = new MessageParser<CSMsgPartyApiLeaderCancelHelpReq>(() => new CSMsgPartyApiLeaderCancelHelpReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiLeaderCancelHelpReq> Parser => _parser;

	public CSMsgPartyApiLeaderCancelHelpReq()
	{
	}

	public CSMsgPartyApiLeaderCancelHelpReq(CSMsgPartyApiLeaderCancelHelpReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderCancelHelpReq Clone()
	{
		return new CSMsgPartyApiLeaderCancelHelpReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderCancelHelpReq);
	}

	public bool Equals(CSMsgPartyApiLeaderCancelHelpReq other)
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

	public void MergeFrom(CSMsgPartyApiLeaderCancelHelpReq other)
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
