using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleBossRush : IMessage<RoleBossRush>, IMessage, IEquatable<RoleBossRush>, IDeepCloneable<RoleBossRush>
{
	private static readonly MessageParser<RoleBossRush> _parser = new MessageParser<RoleBossRush>(() => new RoleBossRush());

	private UnknownFieldSet _unknownFields;

	private BossRushRefight refight_;

	private BossRushContinuousFight continuousFight_;

	private ulong battleCount_;

	public static MessageParser<RoleBossRush> Parser => _parser;

	public BossRushRefight Refight
	{
		get
		{
			return refight_;
		}
		set
		{
			refight_ = value;
		}
	}

	public BossRushContinuousFight ContinuousFight
	{
		get
		{
			return continuousFight_;
		}
		set
		{
			continuousFight_ = value;
		}
	}

	public ulong BattleCount
	{
		get
		{
			return battleCount_;
		}
		set
		{
			battleCount_ = value;
		}
	}

	public RoleBossRush()
	{
	}

	public RoleBossRush(RoleBossRush other)
		: this()
	{
		refight_ = ((other.refight_ != null) ? other.refight_.Clone() : null);
		continuousFight_ = ((other.continuousFight_ != null) ? other.continuousFight_.Clone() : null);
		battleCount_ = other.battleCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleBossRush Clone()
	{
		return new RoleBossRush(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleBossRush);
	}

	public bool Equals(RoleBossRush other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Refight, other.Refight))
		{
			return false;
		}
		if (!object.Equals(ContinuousFight, other.ContinuousFight))
		{
			return false;
		}
		if (BattleCount != other.BattleCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (refight_ != null)
		{
			num ^= Refight.GetHashCode();
		}
		if (continuousFight_ != null)
		{
			num ^= ContinuousFight.GetHashCode();
		}
		if (BattleCount != 0L)
		{
			num ^= BattleCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (refight_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Refight);
		}
		if (continuousFight_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ContinuousFight);
		}
		if (BattleCount != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(BattleCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (refight_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Refight);
		}
		if (continuousFight_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ContinuousFight);
		}
		if (BattleCount != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BattleCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleBossRush other)
	{
		if (other == null)
		{
			return;
		}
		if (other.refight_ != null)
		{
			if (refight_ == null)
			{
				Refight = new BossRushRefight();
			}
			Refight.MergeFrom(other.Refight);
		}
		if (other.continuousFight_ != null)
		{
			if (continuousFight_ == null)
			{
				ContinuousFight = new BossRushContinuousFight();
			}
			ContinuousFight.MergeFrom(other.ContinuousFight);
		}
		if (other.BattleCount != 0L)
		{
			BattleCount = other.BattleCount;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 10u:
				if (refight_ == null)
				{
					Refight = new BossRushRefight();
				}
				input.ReadMessage(Refight);
				break;
			case 18u:
				if (continuousFight_ == null)
				{
					ContinuousFight = new BossRushContinuousFight();
				}
				input.ReadMessage(ContinuousFight);
				break;
			case 24u:
				BattleCount = input.ReadUInt64();
				break;
			}
		}
	}
}
