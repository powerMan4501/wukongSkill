using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomSendPartyBattleMessageCSRes : IMessage<CSMsgRoomSendPartyBattleMessageCSRes>, IMessage, IEquatable<CSMsgRoomSendPartyBattleMessageCSRes>, IDeepCloneable<CSMsgRoomSendPartyBattleMessageCSRes>
{
	private static readonly MessageParser<CSMsgRoomSendPartyBattleMessageCSRes> _parser = new MessageParser<CSMsgRoomSendPartyBattleMessageCSRes>(() => new CSMsgRoomSendPartyBattleMessageCSRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomSendPartyBattleMessageCSRes> Parser => _parser;

	public CSMsgRoomSendPartyBattleMessageCSRes()
	{
	}

	public CSMsgRoomSendPartyBattleMessageCSRes(CSMsgRoomSendPartyBattleMessageCSRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomSendPartyBattleMessageCSRes Clone()
	{
		return new CSMsgRoomSendPartyBattleMessageCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomSendPartyBattleMessageCSRes);
	}

	public bool Equals(CSMsgRoomSendPartyBattleMessageCSRes other)
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

	public void MergeFrom(CSMsgRoomSendPartyBattleMessageCSRes other)
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
