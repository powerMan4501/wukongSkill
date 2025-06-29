using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderBattleReadyRes : IMessage<CSMsgPartyApiLeaderBattleReadyRes>, IMessage, IEquatable<CSMsgPartyApiLeaderBattleReadyRes>, IDeepCloneable<CSMsgPartyApiLeaderBattleReadyRes>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderBattleReadyRes> _parser = new MessageParser<CSMsgPartyApiLeaderBattleReadyRes>(() => new CSMsgPartyApiLeaderBattleReadyRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiLeaderBattleReadyRes> Parser => _parser;

	public CSMsgPartyApiLeaderBattleReadyRes()
	{
	}

	public CSMsgPartyApiLeaderBattleReadyRes(CSMsgPartyApiLeaderBattleReadyRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderBattleReadyRes Clone()
	{
		return new CSMsgPartyApiLeaderBattleReadyRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderBattleReadyRes);
	}

	public bool Equals(CSMsgPartyApiLeaderBattleReadyRes other)
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

	public void MergeFrom(CSMsgPartyApiLeaderBattleReadyRes other)
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
