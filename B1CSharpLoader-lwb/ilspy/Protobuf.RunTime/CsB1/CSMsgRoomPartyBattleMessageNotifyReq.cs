using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomPartyBattleMessageNotifyReq : IMessage<CSMsgRoomPartyBattleMessageNotifyReq>, IMessage, IEquatable<CSMsgRoomPartyBattleMessageNotifyReq>, IDeepCloneable<CSMsgRoomPartyBattleMessageNotifyReq>
{
	private static readonly MessageParser<CSMsgRoomPartyBattleMessageNotifyReq> _parser = new MessageParser<CSMsgRoomPartyBattleMessageNotifyReq>(() => new CSMsgRoomPartyBattleMessageNotifyReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomPartyBattleMessageNotifyReq> Parser => _parser;

	public CSMsgRoomPartyBattleMessageNotifyReq()
	{
	}

	public CSMsgRoomPartyBattleMessageNotifyReq(CSMsgRoomPartyBattleMessageNotifyReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomPartyBattleMessageNotifyReq Clone()
	{
		return new CSMsgRoomPartyBattleMessageNotifyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomPartyBattleMessageNotifyReq);
	}

	public bool Equals(CSMsgRoomPartyBattleMessageNotifyReq other)
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

	public void MergeFrom(CSMsgRoomPartyBattleMessageNotifyReq other)
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
