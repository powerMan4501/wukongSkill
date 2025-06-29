using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomPartyEventNotifyReq : IMessage<CSMsgRoomPartyEventNotifyReq>, IMessage, IEquatable<CSMsgRoomPartyEventNotifyReq>, IDeepCloneable<CSMsgRoomPartyEventNotifyReq>
{
	private static readonly MessageParser<CSMsgRoomPartyEventNotifyReq> _parser = new MessageParser<CSMsgRoomPartyEventNotifyReq>(() => new CSMsgRoomPartyEventNotifyReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomPartyEventNotifyReq> Parser => _parser;

	public CSMsgRoomPartyEventNotifyReq()
	{
	}

	public CSMsgRoomPartyEventNotifyReq(CSMsgRoomPartyEventNotifyReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomPartyEventNotifyReq Clone()
	{
		return new CSMsgRoomPartyEventNotifyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomPartyEventNotifyReq);
	}

	public bool Equals(CSMsgRoomPartyEventNotifyReq other)
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

	public void MergeFrom(CSMsgRoomPartyEventNotifyReq other)
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
