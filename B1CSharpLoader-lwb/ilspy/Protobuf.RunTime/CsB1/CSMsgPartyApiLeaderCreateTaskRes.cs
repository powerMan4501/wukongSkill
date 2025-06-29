using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderCreateTaskRes : IMessage<CSMsgPartyApiLeaderCreateTaskRes>, IMessage, IEquatable<CSMsgPartyApiLeaderCreateTaskRes>, IDeepCloneable<CSMsgPartyApiLeaderCreateTaskRes>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderCreateTaskRes> _parser = new MessageParser<CSMsgPartyApiLeaderCreateTaskRes>(() => new CSMsgPartyApiLeaderCreateTaskRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiLeaderCreateTaskRes> Parser => _parser;

	public CSMsgPartyApiLeaderCreateTaskRes()
	{
	}

	public CSMsgPartyApiLeaderCreateTaskRes(CSMsgPartyApiLeaderCreateTaskRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderCreateTaskRes Clone()
	{
		return new CSMsgPartyApiLeaderCreateTaskRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderCreateTaskRes);
	}

	public bool Equals(CSMsgPartyApiLeaderCreateTaskRes other)
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

	public void MergeFrom(CSMsgPartyApiLeaderCreateTaskRes other)
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
