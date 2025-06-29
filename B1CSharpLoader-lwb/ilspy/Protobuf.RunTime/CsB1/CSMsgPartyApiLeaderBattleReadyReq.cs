using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderBattleReadyReq : IMessage<CSMsgPartyApiLeaderBattleReadyReq>, IMessage, IEquatable<CSMsgPartyApiLeaderBattleReadyReq>, IDeepCloneable<CSMsgPartyApiLeaderBattleReadyReq>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderBattleReadyReq> _parser = new MessageParser<CSMsgPartyApiLeaderBattleReadyReq>(() => new CSMsgPartyApiLeaderBattleReadyReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiLeaderBattleReadyReq> Parser => _parser;

	public CSMsgPartyApiLeaderBattleReadyReq()
	{
	}

	public CSMsgPartyApiLeaderBattleReadyReq(CSMsgPartyApiLeaderBattleReadyReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderBattleReadyReq Clone()
	{
		return new CSMsgPartyApiLeaderBattleReadyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderBattleReadyReq);
	}

	public bool Equals(CSMsgPartyApiLeaderBattleReadyReq other)
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

	public void MergeFrom(CSMsgPartyApiLeaderBattleReadyReq other)
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
