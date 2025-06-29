using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderCancelHelpRes : IMessage<CSMsgPartyApiLeaderCancelHelpRes>, IMessage, IEquatable<CSMsgPartyApiLeaderCancelHelpRes>, IDeepCloneable<CSMsgPartyApiLeaderCancelHelpRes>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderCancelHelpRes> _parser = new MessageParser<CSMsgPartyApiLeaderCancelHelpRes>(() => new CSMsgPartyApiLeaderCancelHelpRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiLeaderCancelHelpRes> Parser => _parser;

	public CSMsgPartyApiLeaderCancelHelpRes()
	{
	}

	public CSMsgPartyApiLeaderCancelHelpRes(CSMsgPartyApiLeaderCancelHelpRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderCancelHelpRes Clone()
	{
		return new CSMsgPartyApiLeaderCancelHelpRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderCancelHelpRes);
	}

	public bool Equals(CSMsgPartyApiLeaderCancelHelpRes other)
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

	public void MergeFrom(CSMsgPartyApiLeaderCancelHelpRes other)
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
