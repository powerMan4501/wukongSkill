using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiJoinPartyRes : IMessage<CSMsgPartyApiJoinPartyRes>, IMessage, IEquatable<CSMsgPartyApiJoinPartyRes>, IDeepCloneable<CSMsgPartyApiJoinPartyRes>
{
	private static readonly MessageParser<CSMsgPartyApiJoinPartyRes> _parser = new MessageParser<CSMsgPartyApiJoinPartyRes>(() => new CSMsgPartyApiJoinPartyRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiJoinPartyRes> Parser => _parser;

	public CSMsgPartyApiJoinPartyRes()
	{
	}

	public CSMsgPartyApiJoinPartyRes(CSMsgPartyApiJoinPartyRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiJoinPartyRes Clone()
	{
		return new CSMsgPartyApiJoinPartyRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiJoinPartyRes);
	}

	public bool Equals(CSMsgPartyApiJoinPartyRes other)
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

	public void MergeFrom(CSMsgPartyApiJoinPartyRes other)
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
