using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class BossRushContinuousFightRecord : IMessage<BossRushContinuousFightRecord>, IMessage, IEquatable<BossRushContinuousFightRecord>, IDeepCloneable<BossRushContinuousFightRecord>
{
	private static readonly MessageParser<BossRushContinuousFightRecord> _parser = new MessageParser<BossRushContinuousFightRecord>(() => new BossRushContinuousFightRecord());

	private UnknownFieldSet _unknownFields;

	private ulong battleId_;

	private BossRushBattleData battleData_;

	public static MessageParser<BossRushContinuousFightRecord> Parser => _parser;

	public ulong BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
		}
	}

	public BossRushBattleData BattleData
	{
		get
		{
			return battleData_;
		}
		set
		{
			battleData_ = value;
		}
	}

	public BossRushContinuousFightRecord()
	{
	}

	public BossRushContinuousFightRecord(BossRushContinuousFightRecord other)
		: this()
	{
		battleId_ = other.battleId_;
		battleData_ = ((other.battleData_ != null) ? other.battleData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushContinuousFightRecord Clone()
	{
		return new BossRushContinuousFightRecord(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushContinuousFightRecord);
	}

	public bool Equals(BossRushContinuousFightRecord other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BattleId != other.BattleId)
		{
			return false;
		}
		if (!object.Equals(BattleData, other.BattleData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BattleId != 0L)
		{
			num ^= BattleId.GetHashCode();
		}
		if (battleData_ != null)
		{
			num ^= BattleData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BattleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(BattleId);
		}
		if (battleData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BattleData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BattleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BattleId);
		}
		if (battleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushContinuousFightRecord other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BattleId != 0L)
		{
			BattleId = other.BattleId;
		}
		if (other.battleData_ != null)
		{
			if (battleData_ == null)
			{
				BattleData = new BossRushBattleData();
			}
			BattleData.MergeFrom(other.BattleData);
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
			case 8u:
				BattleId = input.ReadUInt64();
				break;
			case 18u:
				if (battleData_ == null)
				{
					BattleData = new BossRushBattleData();
				}
				input.ReadMessage(BattleData);
				break;
			}
		}
	}
}
