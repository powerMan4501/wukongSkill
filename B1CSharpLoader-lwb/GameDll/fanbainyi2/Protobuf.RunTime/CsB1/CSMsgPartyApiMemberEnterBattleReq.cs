using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiMemberEnterBattleReq : IMessage<CSMsgPartyApiMemberEnterBattleReq>, IMessage, IEquatable<CSMsgPartyApiMemberEnterBattleReq>, IDeepCloneable<CSMsgPartyApiMemberEnterBattleReq>
{
	private static readonly MessageParser<CSMsgPartyApiMemberEnterBattleReq> _parser = new MessageParser<CSMsgPartyApiMemberEnterBattleReq>(() => new CSMsgPartyApiMemberEnterBattleReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgPartyApiMemberEnterBattleReq> Parser => _parser;

	public CSMsgPartyApiMemberEnterBattleReq()
	{
	}

	public CSMsgPartyApiMemberEnterBattleReq(CSMsgPartyApiMemberEnterBattleReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiMemberEnterBattleReq Clone()
	{
		return new CSMsgPartyApiMemberEnterBattleReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiMemberEnterBattleReq);
	}

	public bool Equals(CSMsgPartyApiMemberEnterBattleReq other)
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

	public void MergeFrom(CSMsgPartyApiMemberEnterBattleReq other)
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
