using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderCreateBattleRes : IMessage<CSMsgPartyApiLeaderCreateBattleRes>, IMessage, IEquatable<CSMsgPartyApiLeaderCreateBattleRes>, IDeepCloneable<CSMsgPartyApiLeaderCreateBattleRes>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderCreateBattleRes> _parser = new MessageParser<CSMsgPartyApiLeaderCreateBattleRes>(() => new CSMsgPartyApiLeaderCreateBattleRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiLeaderCreateBattleRes> Parser => _parser;

	public CSMsgPartyApiLeaderCreateBattleRes()
	{
	}

	public CSMsgPartyApiLeaderCreateBattleRes(CSMsgPartyApiLeaderCreateBattleRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderCreateBattleRes Clone()
	{
		return new CSMsgPartyApiLeaderCreateBattleRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderCreateBattleRes);
	}

	public bool Equals(CSMsgPartyApiLeaderCreateBattleRes other)
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

	public void MergeFrom(CSMsgPartyApiLeaderCreateBattleRes other)
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
