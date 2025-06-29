using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBossRushBattleStartReq : IMessage<CSMsgBossRushBattleStartReq>, IMessage, IEquatable<CSMsgBossRushBattleStartReq>, IDeepCloneable<CSMsgBossRushBattleStartReq>
{
	private static readonly MessageParser<CSMsgBossRushBattleStartReq> _parser = new MessageParser<CSMsgBossRushBattleStartReq>(() => new CSMsgBossRushBattleStartReq());

	private UnknownFieldSet _unknownFields;

	private BossRushBattleParam battleParam_;

	public static MessageParser<CSMsgBossRushBattleStartReq> Parser => _parser;

	public BossRushBattleParam BattleParam
	{
		get
		{
			return battleParam_;
		}
		set
		{
			battleParam_ = value;
		}
	}

	public CSMsgBossRushBattleStartReq()
	{
	}

	public CSMsgBossRushBattleStartReq(CSMsgBossRushBattleStartReq other)
		: this()
	{
		battleParam_ = ((other.battleParam_ != null) ? other.battleParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBossRushBattleStartReq Clone()
	{
		return new CSMsgBossRushBattleStartReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBossRushBattleStartReq);
	}

	public bool Equals(CSMsgBossRushBattleStartReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BattleParam, other.BattleParam))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (battleParam_ != null)
		{
			num ^= BattleParam.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (battleParam_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BattleParam);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (battleParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleParam);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBossRushBattleStartReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.battleParam_ != null)
		{
			if (battleParam_ == null)
			{
				BattleParam = new BossRushBattleParam();
			}
			BattleParam.MergeFrom(other.BattleParam);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (battleParam_ == null)
			{
				BattleParam = new BossRushBattleParam();
			}
			input.ReadMessage(BattleParam);
		}
	}
}
