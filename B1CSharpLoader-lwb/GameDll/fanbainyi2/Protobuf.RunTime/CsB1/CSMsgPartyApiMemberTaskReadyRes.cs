using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiMemberTaskReadyRes : IMessage<CSMsgPartyApiMemberTaskReadyRes>, IMessage, IEquatable<CSMsgPartyApiMemberTaskReadyRes>, IDeepCloneable<CSMsgPartyApiMemberTaskReadyRes>
{
	private static readonly MessageParser<CSMsgPartyApiMemberTaskReadyRes> _parser = new MessageParser<CSMsgPartyApiMemberTaskReadyRes>(() => new CSMsgPartyApiMemberTaskReadyRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiMemberTaskReadyRes> Parser => _parser;

	public CSMsgPartyApiMemberTaskReadyRes()
	{
	}

	public CSMsgPartyApiMemberTaskReadyRes(CSMsgPartyApiMemberTaskReadyRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiMemberTaskReadyRes Clone()
	{
		return new CSMsgPartyApiMemberTaskReadyRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiMemberTaskReadyRes);
	}

	public bool Equals(CSMsgPartyApiMemberTaskReadyRes other)
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

	public void MergeFrom(CSMsgPartyApiMemberTaskReadyRes other)
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
