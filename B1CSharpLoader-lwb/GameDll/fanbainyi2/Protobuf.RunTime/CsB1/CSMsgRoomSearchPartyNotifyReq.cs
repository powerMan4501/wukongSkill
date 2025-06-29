using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomSearchPartyNotifyReq : IMessage<CSMsgRoomSearchPartyNotifyReq>, IMessage, IEquatable<CSMsgRoomSearchPartyNotifyReq>, IDeepCloneable<CSMsgRoomSearchPartyNotifyReq>
{
	private static readonly MessageParser<CSMsgRoomSearchPartyNotifyReq> _parser = new MessageParser<CSMsgRoomSearchPartyNotifyReq>(() => new CSMsgRoomSearchPartyNotifyReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomSearchPartyNotifyReq> Parser => _parser;

	public CSMsgRoomSearchPartyNotifyReq()
	{
	}

	public CSMsgRoomSearchPartyNotifyReq(CSMsgRoomSearchPartyNotifyReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomSearchPartyNotifyReq Clone()
	{
		return new CSMsgRoomSearchPartyNotifyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomSearchPartyNotifyReq);
	}

	public bool Equals(CSMsgRoomSearchPartyNotifyReq other)
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

	public void MergeFrom(CSMsgRoomSearchPartyNotifyReq other)
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
