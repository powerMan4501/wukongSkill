using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomSearchPartyCSRes : IMessage<CSMsgRoomSearchPartyCSRes>, IMessage, IEquatable<CSMsgRoomSearchPartyCSRes>, IDeepCloneable<CSMsgRoomSearchPartyCSRes>
{
	private static readonly MessageParser<CSMsgRoomSearchPartyCSRes> _parser = new MessageParser<CSMsgRoomSearchPartyCSRes>(() => new CSMsgRoomSearchPartyCSRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomSearchPartyCSRes> Parser => _parser;

	public CSMsgRoomSearchPartyCSRes()
	{
	}

	public CSMsgRoomSearchPartyCSRes(CSMsgRoomSearchPartyCSRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomSearchPartyCSRes Clone()
	{
		return new CSMsgRoomSearchPartyCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomSearchPartyCSRes);
	}

	public bool Equals(CSMsgRoomSearchPartyCSRes other)
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

	public void MergeFrom(CSMsgRoomSearchPartyCSRes other)
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
