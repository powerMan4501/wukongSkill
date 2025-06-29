using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomCreatePartyTaskCSRes : IMessage<CSMsgRoomCreatePartyTaskCSRes>, IMessage, IEquatable<CSMsgRoomCreatePartyTaskCSRes>, IDeepCloneable<CSMsgRoomCreatePartyTaskCSRes>
{
	private static readonly MessageParser<CSMsgRoomCreatePartyTaskCSRes> _parser = new MessageParser<CSMsgRoomCreatePartyTaskCSRes>(() => new CSMsgRoomCreatePartyTaskCSRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomCreatePartyTaskCSRes> Parser => _parser;

	public CSMsgRoomCreatePartyTaskCSRes()
	{
	}

	public CSMsgRoomCreatePartyTaskCSRes(CSMsgRoomCreatePartyTaskCSRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomCreatePartyTaskCSRes Clone()
	{
		return new CSMsgRoomCreatePartyTaskCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomCreatePartyTaskCSRes);
	}

	public bool Equals(CSMsgRoomCreatePartyTaskCSRes other)
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

	public void MergeFrom(CSMsgRoomCreatePartyTaskCSRes other)
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
