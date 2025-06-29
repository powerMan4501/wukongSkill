using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomPartyKickMemberCSRes : IMessage<CSMsgRoomPartyKickMemberCSRes>, IMessage, IEquatable<CSMsgRoomPartyKickMemberCSRes>, IDeepCloneable<CSMsgRoomPartyKickMemberCSRes>
{
	private static readonly MessageParser<CSMsgRoomPartyKickMemberCSRes> _parser = new MessageParser<CSMsgRoomPartyKickMemberCSRes>(() => new CSMsgRoomPartyKickMemberCSRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomPartyKickMemberCSRes> Parser => _parser;

	public CSMsgRoomPartyKickMemberCSRes()
	{
	}

	public CSMsgRoomPartyKickMemberCSRes(CSMsgRoomPartyKickMemberCSRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomPartyKickMemberCSRes Clone()
	{
		return new CSMsgRoomPartyKickMemberCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomPartyKickMemberCSRes);
	}

	public bool Equals(CSMsgRoomPartyKickMemberCSRes other)
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

	public void MergeFrom(CSMsgRoomPartyKickMemberCSRes other)
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
