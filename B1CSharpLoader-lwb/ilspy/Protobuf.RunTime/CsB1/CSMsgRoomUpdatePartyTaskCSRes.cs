using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomUpdatePartyTaskCSRes : IMessage<CSMsgRoomUpdatePartyTaskCSRes>, IMessage, IEquatable<CSMsgRoomUpdatePartyTaskCSRes>, IDeepCloneable<CSMsgRoomUpdatePartyTaskCSRes>
{
	private static readonly MessageParser<CSMsgRoomUpdatePartyTaskCSRes> _parser = new MessageParser<CSMsgRoomUpdatePartyTaskCSRes>(() => new CSMsgRoomUpdatePartyTaskCSRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomUpdatePartyTaskCSRes> Parser => _parser;

	public CSMsgRoomUpdatePartyTaskCSRes()
	{
	}

	public CSMsgRoomUpdatePartyTaskCSRes(CSMsgRoomUpdatePartyTaskCSRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomUpdatePartyTaskCSRes Clone()
	{
		return new CSMsgRoomUpdatePartyTaskCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomUpdatePartyTaskCSRes);
	}

	public bool Equals(CSMsgRoomUpdatePartyTaskCSRes other)
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

	public void MergeFrom(CSMsgRoomUpdatePartyTaskCSRes other)
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
