using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiCreateOnlinePartyRes : IMessage<CSMsgPartyApiCreateOnlinePartyRes>, IMessage, IEquatable<CSMsgPartyApiCreateOnlinePartyRes>, IDeepCloneable<CSMsgPartyApiCreateOnlinePartyRes>
{
	private static readonly MessageParser<CSMsgPartyApiCreateOnlinePartyRes> _parser = new MessageParser<CSMsgPartyApiCreateOnlinePartyRes>(() => new CSMsgPartyApiCreateOnlinePartyRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiCreateOnlinePartyRes> Parser => _parser;

	public CSMsgPartyApiCreateOnlinePartyRes()
	{
	}

	public CSMsgPartyApiCreateOnlinePartyRes(CSMsgPartyApiCreateOnlinePartyRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiCreateOnlinePartyRes Clone()
	{
		return new CSMsgPartyApiCreateOnlinePartyRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiCreateOnlinePartyRes);
	}

	public bool Equals(CSMsgPartyApiCreateOnlinePartyRes other)
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

	public void MergeFrom(CSMsgPartyApiCreateOnlinePartyRes other)
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
