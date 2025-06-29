using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomExitPartyCSRes : IMessage<CSMsgRoomExitPartyCSRes>, IMessage, IEquatable<CSMsgRoomExitPartyCSRes>, IDeepCloneable<CSMsgRoomExitPartyCSRes>
{
	private static readonly MessageParser<CSMsgRoomExitPartyCSRes> _parser = new MessageParser<CSMsgRoomExitPartyCSRes>(() => new CSMsgRoomExitPartyCSRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomExitPartyCSRes> Parser => _parser;

	public CSMsgRoomExitPartyCSRes()
	{
	}

	public CSMsgRoomExitPartyCSRes(CSMsgRoomExitPartyCSRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomExitPartyCSRes Clone()
	{
		return new CSMsgRoomExitPartyCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomExitPartyCSRes);
	}

	public bool Equals(CSMsgRoomExitPartyCSRes other)
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

	public void MergeFrom(CSMsgRoomExitPartyCSRes other)
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
