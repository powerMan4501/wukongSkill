using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderFinishTaskReq : IMessage<CSMsgPartyApiLeaderFinishTaskReq>, IMessage, IEquatable<CSMsgPartyApiLeaderFinishTaskReq>, IDeepCloneable<CSMsgPartyApiLeaderFinishTaskReq>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderFinishTaskReq> _parser = new MessageParser<CSMsgPartyApiLeaderFinishTaskReq>(() => new CSMsgPartyApiLeaderFinishTaskReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiLeaderFinishTaskReq> Parser => _parser;

	public CSMsgPartyApiLeaderFinishTaskReq()
	{
	}

	public CSMsgPartyApiLeaderFinishTaskReq(CSMsgPartyApiLeaderFinishTaskReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderFinishTaskReq Clone()
	{
		return new CSMsgPartyApiLeaderFinishTaskReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderFinishTaskReq);
	}

	public bool Equals(CSMsgPartyApiLeaderFinishTaskReq other)
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

	public void MergeFrom(CSMsgPartyApiLeaderFinishTaskReq other)
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
