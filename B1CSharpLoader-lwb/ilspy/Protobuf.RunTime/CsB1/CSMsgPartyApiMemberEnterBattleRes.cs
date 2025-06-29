using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiMemberEnterBattleRes : IMessage<CSMsgPartyApiMemberEnterBattleRes>, IMessage, IEquatable<CSMsgPartyApiMemberEnterBattleRes>, IDeepCloneable<CSMsgPartyApiMemberEnterBattleRes>
{
	private static readonly MessageParser<CSMsgPartyApiMemberEnterBattleRes> _parser = new MessageParser<CSMsgPartyApiMemberEnterBattleRes>(() => new CSMsgPartyApiMemberEnterBattleRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiMemberEnterBattleRes> Parser => _parser;

	public CSMsgPartyApiMemberEnterBattleRes()
	{
	}

	public CSMsgPartyApiMemberEnterBattleRes(CSMsgPartyApiMemberEnterBattleRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiMemberEnterBattleRes Clone()
	{
		return new CSMsgPartyApiMemberEnterBattleRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiMemberEnterBattleRes);
	}

	public bool Equals(CSMsgPartyApiMemberEnterBattleRes other)
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

	public void MergeFrom(CSMsgPartyApiMemberEnterBattleRes other)
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
