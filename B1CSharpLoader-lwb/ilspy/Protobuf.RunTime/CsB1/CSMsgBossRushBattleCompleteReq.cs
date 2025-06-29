using System;
using ArchiveB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CsB1;

public sealed class CSMsgBossRushBattleCompleteReq : IMessage<CSMsgBossRushBattleCompleteReq>, IMessage, IEquatable<CSMsgBossRushBattleCompleteReq>, IDeepCloneable<CSMsgBossRushBattleCompleteReq>
{
	private static readonly MessageParser<CSMsgBossRushBattleCompleteReq> _parser = new MessageParser<CSMsgBossRushBattleCompleteReq>(() => new CSMsgBossRushBattleCompleteReq());

	private UnknownFieldSet _unknownFields;

	private BossRushBattleParam battleParam_;

	private bool changleSuccess_;

	private static readonly FieldCodec<ItemOne> _repeated_costItemList_codec = FieldCodec.ForMessage(26u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> costItemList_ = new RepeatedField<ItemOne>();

	private BossRushBattleData battleData_;

	private int encounterBossIndex_;

	public static MessageParser<CSMsgBossRushBattleCompleteReq> Parser => _parser;

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

	public bool ChangleSuccess
	{
		get
		{
			return changleSuccess_;
		}
		set
		{
			changleSuccess_ = value;
		}
	}

	public RepeatedField<ItemOne> CostItemList => costItemList_;

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

	public int EncounterBossIndex
	{
		get
		{
			return encounterBossIndex_;
		}
		set
		{
			encounterBossIndex_ = value;
		}
	}

	public CSMsgBossRushBattleCompleteReq()
	{
	}

	public CSMsgBossRushBattleCompleteReq(CSMsgBossRushBattleCompleteReq other)
		: this()
	{
		battleParam_ = ((other.battleParam_ != null) ? other.battleParam_.Clone() : null);
		changleSuccess_ = other.changleSuccess_;
		costItemList_ = other.costItemList_.Clone();
		battleData_ = ((other.battleData_ != null) ? other.battleData_.Clone() : null);
		encounterBossIndex_ = other.encounterBossIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBossRushBattleCompleteReq Clone()
	{
		return new CSMsgBossRushBattleCompleteReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBossRushBattleCompleteReq);
	}

	public bool Equals(CSMsgBossRushBattleCompleteReq other)
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
		if (ChangleSuccess != other.ChangleSuccess)
		{
			return false;
		}
		if (!costItemList_.Equals(other.costItemList_))
		{
			return false;
		}
		if (!object.Equals(BattleData, other.BattleData))
		{
			return false;
		}
		if (EncounterBossIndex != other.EncounterBossIndex)
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
		if (ChangleSuccess)
		{
			num ^= ChangleSuccess.GetHashCode();
		}
		num ^= costItemList_.GetHashCode();
		if (battleData_ != null)
		{
			num ^= BattleData.GetHashCode();
		}
		if (EncounterBossIndex != 0)
		{
			num ^= EncounterBossIndex.GetHashCode();
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
		if (ChangleSuccess)
		{
			output.WriteRawTag(16);
			output.WriteBool(ChangleSuccess);
		}
		costItemList_.WriteTo(output, _repeated_costItemList_codec);
		if (battleData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BattleData);
		}
		if (EncounterBossIndex != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EncounterBossIndex);
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
		if (ChangleSuccess)
		{
			num += 2;
		}
		num += costItemList_.CalculateSize(_repeated_costItemList_codec);
		if (battleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleData);
		}
		if (EncounterBossIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EncounterBossIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBossRushBattleCompleteReq other)
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
		if (other.ChangleSuccess)
		{
			ChangleSuccess = other.ChangleSuccess;
		}
		costItemList_.Add(other.costItemList_);
		if (other.battleData_ != null)
		{
			if (battleData_ == null)
			{
				BattleData = new BossRushBattleData();
			}
			BattleData.MergeFrom(other.BattleData);
		}
		if (other.EncounterBossIndex != 0)
		{
			EncounterBossIndex = other.EncounterBossIndex;
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
				if (battleParam_ == null)
				{
					BattleParam = new BossRushBattleParam();
				}
				input.ReadMessage(BattleParam);
				break;
			case 16u:
				ChangleSuccess = input.ReadBool();
				break;
			case 26u:
				costItemList_.AddEntriesFrom(input, _repeated_costItemList_codec);
				break;
			case 34u:
				if (battleData_ == null)
				{
					BattleData = new BossRushBattleData();
				}
				input.ReadMessage(BattleData);
				break;
			case 40u:
				EncounterBossIndex = input.ReadInt32();
				break;
			}
		}
	}
}
