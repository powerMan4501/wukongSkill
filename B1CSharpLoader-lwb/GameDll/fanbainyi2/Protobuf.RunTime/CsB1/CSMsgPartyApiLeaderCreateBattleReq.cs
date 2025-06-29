using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderCreateBattleReq : IMessage<CSMsgPartyApiLeaderCreateBattleReq>, IMessage, IEquatable<CSMsgPartyApiLeaderCreateBattleReq>, IDeepCloneable<CSMsgPartyApiLeaderCreateBattleReq>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderCreateBattleReq> _parser = new MessageParser<CSMsgPartyApiLeaderCreateBattleReq>(() => new CSMsgPartyApiLeaderCreateBattleReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiLeaderCreateBattleReq> Parser => _parser;

	public CSMsgPartyApiLeaderCreateBattleReq()
	{
	}

	public CSMsgPartyApiLeaderCreateBattleReq(CSMsgPartyApiLeaderCreateBattleReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderCreateBattleReq Clone()
	{
		return new CSMsgPartyApiLeaderCreateBattleReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderCreateBattleReq);
	}

	public bool Equals(CSMsgPartyApiLeaderCreateBattleReq other)
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

	public void MergeFrom(CSMsgPartyApiLeaderCreateBattleReq other)
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
