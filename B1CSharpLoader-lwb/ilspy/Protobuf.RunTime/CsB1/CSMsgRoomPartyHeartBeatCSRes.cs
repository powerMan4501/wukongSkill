using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomPartyHeartBeatCSRes : IMessage<CSMsgRoomPartyHeartBeatCSRes>, IMessage, IEquatable<CSMsgRoomPartyHeartBeatCSRes>, IDeepCloneable<CSMsgRoomPartyHeartBeatCSRes>
{
	private static readonly MessageParser<CSMsgRoomPartyHeartBeatCSRes> _parser = new MessageParser<CSMsgRoomPartyHeartBeatCSRes>(() => new CSMsgRoomPartyHeartBeatCSRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoomPartyHeartBeatCSRes> Parser => _parser;

	public CSMsgRoomPartyHeartBeatCSRes()
	{
	}

	public CSMsgRoomPartyHeartBeatCSRes(CSMsgRoomPartyHeartBeatCSRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomPartyHeartBeatCSRes Clone()
	{
		return new CSMsgRoomPartyHeartBeatCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomPartyHeartBeatCSRes);
	}

	public bool Equals(CSMsgRoomPartyHeartBeatCSRes other)
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

	public void MergeFrom(CSMsgRoomPartyHeartBeatCSRes other)
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
