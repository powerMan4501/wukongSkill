using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomPartyMemberUpdateCSRes : IMessage<CSMsgRoomPartyMemberUpdateCSRes>, IMessage, IEquatable<CSMsgRoomPartyMemberUpdateCSRes>, IDeepCloneable<CSMsgRoomPartyMemberUpdateCSRes>
{
	private static readonly MessageParser<CSMsgRoomPartyMemberUpdateCSRes> _parser = new MessageParser<CSMsgRoomPartyMemberUpdateCSRes>(() => new CSMsgRoomPartyMemberUpdateCSRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomPartyMemberUpdateCSRes> Parser => _parser;

	public CSMsgRoomPartyMemberUpdateCSRes()
	{
	}

	public CSMsgRoomPartyMemberUpdateCSRes(CSMsgRoomPartyMemberUpdateCSRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomPartyMemberUpdateCSRes Clone()
	{
		return new CSMsgRoomPartyMemberUpdateCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomPartyMemberUpdateCSRes);
	}

	public bool Equals(CSMsgRoomPartyMemberUpdateCSRes other)
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

	public void MergeFrom(CSMsgRoomPartyMemberUpdateCSRes other)
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
