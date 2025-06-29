using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomPartyTaskFinishCSRes : IMessage<CSMsgRoomPartyTaskFinishCSRes>, IMessage, IEquatable<CSMsgRoomPartyTaskFinishCSRes>, IDeepCloneable<CSMsgRoomPartyTaskFinishCSRes>
{
	private static readonly MessageParser<CSMsgRoomPartyTaskFinishCSRes> _parser = new MessageParser<CSMsgRoomPartyTaskFinishCSRes>(() => new CSMsgRoomPartyTaskFinishCSRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomPartyTaskFinishCSRes> Parser => _parser;

	public CSMsgRoomPartyTaskFinishCSRes()
	{
	}

	public CSMsgRoomPartyTaskFinishCSRes(CSMsgRoomPartyTaskFinishCSRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomPartyTaskFinishCSRes Clone()
	{
		return new CSMsgRoomPartyTaskFinishCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomPartyTaskFinishCSRes);
	}

	public bool Equals(CSMsgRoomPartyTaskFinishCSRes other)
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

	public void MergeFrom(CSMsgRoomPartyTaskFinishCSRes other)
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
