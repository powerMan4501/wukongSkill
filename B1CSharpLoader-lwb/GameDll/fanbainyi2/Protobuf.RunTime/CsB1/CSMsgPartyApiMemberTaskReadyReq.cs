using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiMemberTaskReadyReq : IMessage<CSMsgPartyApiMemberTaskReadyReq>, IMessage, IEquatable<CSMsgPartyApiMemberTaskReadyReq>, IDeepCloneable<CSMsgPartyApiMemberTaskReadyReq>
{
	private static readonly MessageParser<CSMsgPartyApiMemberTaskReadyReq> _parser = new MessageParser<CSMsgPartyApiMemberTaskReadyReq>(() => new CSMsgPartyApiMemberTaskReadyReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiMemberTaskReadyReq> Parser => _parser;

	public CSMsgPartyApiMemberTaskReadyReq()
	{
	}

	public CSMsgPartyApiMemberTaskReadyReq(CSMsgPartyApiMemberTaskReadyReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiMemberTaskReadyReq Clone()
	{
		return new CSMsgPartyApiMemberTaskReadyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiMemberTaskReadyReq);
	}

	public bool Equals(CSMsgPartyApiMemberTaskReadyReq other)
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

	public void MergeFrom(CSMsgPartyApiMemberTaskReadyReq other)
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
