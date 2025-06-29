using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBossRushBattleStartRes : IMessage<CSMsgBossRushBattleStartRes>, IMessage, IEquatable<CSMsgBossRushBattleStartRes>, IDeepCloneable<CSMsgBossRushBattleStartRes>
{
	private static readonly MessageParser<CSMsgBossRushBattleStartRes> _parser = new MessageParser<CSMsgBossRushBattleStartRes>(() => new CSMsgBossRushBattleStartRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBossRushBattleStartRes> Parser => _parser;

	public CSMsgBossRushBattleStartRes()
	{
	}

	public CSMsgBossRushBattleStartRes(CSMsgBossRushBattleStartRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBossRushBattleStartRes Clone()
	{
		return new CSMsgBossRushBattleStartRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBossRushBattleStartRes);
	}

	public bool Equals(CSMsgBossRushBattleStartRes other)
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

	public void MergeFrom(CSMsgBossRushBattleStartRes other)
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
