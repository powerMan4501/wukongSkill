using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_ObserveOnlineCondition : IMessage<QuestCustom_ObserveOnlineCondition>, IMessage, IEquatable<QuestCustom_ObserveOnlineCondition>, IDeepCloneable<QuestCustom_ObserveOnlineCondition>
{
	private static readonly MessageParser<QuestCustom_ObserveOnlineCondition> _parser = new MessageParser<QuestCustom_ObserveOnlineCondition>(() => new QuestCustom_ObserveOnlineCondition());

	private UnknownFieldSet _unknownFields;

	private int conditionType_;

	private int successLimit_;

	private string observeActorGuid_ = "";

	private int playerCount_;

	private int killMonsterCount_;

	private int gainItemCount_;

	private int itemId_;

	private int traceDistance_;

	private int eventId_;

	private int randomCount_;

	public static MessageParser<QuestCustom_ObserveOnlineCondition> Parser => _parser;

	public int ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

	public int SuccessLimit
	{
		get
		{
			return successLimit_;
		}
		set
		{
			successLimit_ = value;
		}
	}

	public string ObserveActorGuid
	{
		get
		{
			return observeActorGuid_;
		}
		set
		{
			observeActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int PlayerCount
	{
		get
		{
			return playerCount_;
		}
		set
		{
			playerCount_ = value;
		}
	}

	public int KillMonsterCount
	{
		get
		{
			return killMonsterCount_;
		}
		set
		{
			killMonsterCount_ = value;
		}
	}

	public int GainItemCount
	{
		get
		{
			return gainItemCount_;
		}
		set
		{
			gainItemCount_ = value;
		}
	}

	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	public int TraceDistance
	{
		get
		{
			return traceDistance_;
		}
		set
		{
			traceDistance_ = value;
		}
	}

	public int EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	public int RandomCount
	{
		get
		{
			return randomCount_;
		}
		set
		{
			randomCount_ = value;
		}
	}

	public QuestCustom_ObserveOnlineCondition()
	{
	}

	public QuestCustom_ObserveOnlineCondition(QuestCustom_ObserveOnlineCondition other)
		: this()
	{
		conditionType_ = other.conditionType_;
		successLimit_ = other.successLimit_;
		observeActorGuid_ = other.observeActorGuid_;
		playerCount_ = other.playerCount_;
		killMonsterCount_ = other.killMonsterCount_;
		gainItemCount_ = other.gainItemCount_;
		itemId_ = other.itemId_;
		traceDistance_ = other.traceDistance_;
		eventId_ = other.eventId_;
		randomCount_ = other.randomCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_ObserveOnlineCondition Clone()
	{
		return new QuestCustom_ObserveOnlineCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_ObserveOnlineCondition);
	}

	public bool Equals(QuestCustom_ObserveOnlineCondition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConditionType != other.ConditionType)
		{
			return false;
		}
		if (SuccessLimit != other.SuccessLimit)
		{
			return false;
		}
		if (ObserveActorGuid != other.ObserveActorGuid)
		{
			return false;
		}
		if (PlayerCount != other.PlayerCount)
		{
			return false;
		}
		if (KillMonsterCount != other.KillMonsterCount)
		{
			return false;
		}
		if (GainItemCount != other.GainItemCount)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (TraceDistance != other.TraceDistance)
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (RandomCount != other.RandomCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (SuccessLimit != 0)
		{
			num ^= SuccessLimit.GetHashCode();
		}
		if (ObserveActorGuid.Length != 0)
		{
			num ^= ObserveActorGuid.GetHashCode();
		}
		if (PlayerCount != 0)
		{
			num ^= PlayerCount.GetHashCode();
		}
		if (KillMonsterCount != 0)
		{
			num ^= KillMonsterCount.GetHashCode();
		}
		if (GainItemCount != 0)
		{
			num ^= GainItemCount.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (TraceDistance != 0)
		{
			num ^= TraceDistance.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (RandomCount != 0)
		{
			num ^= RandomCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConditionType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionType);
		}
		if (SuccessLimit != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SuccessLimit);
		}
		if (ObserveActorGuid.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ObserveActorGuid);
		}
		if (PlayerCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PlayerCount);
		}
		if (KillMonsterCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(KillMonsterCount);
		}
		if (GainItemCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(GainItemCount);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ItemId);
		}
		if (TraceDistance != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TraceDistance);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(EventId);
		}
		if (RandomCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(RandomCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		if (SuccessLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuccessLimit);
		}
		if (ObserveActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObserveActorGuid);
		}
		if (PlayerCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayerCount);
		}
		if (KillMonsterCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KillMonsterCount);
		}
		if (GainItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GainItemCount);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (TraceDistance != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TraceDistance);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (RandomCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RandomCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_ObserveOnlineCondition other)
	{
		if (other != null)
		{
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.SuccessLimit != 0)
			{
				SuccessLimit = other.SuccessLimit;
			}
			if (other.ObserveActorGuid.Length != 0)
			{
				ObserveActorGuid = other.ObserveActorGuid;
			}
			if (other.PlayerCount != 0)
			{
				PlayerCount = other.PlayerCount;
			}
			if (other.KillMonsterCount != 0)
			{
				KillMonsterCount = other.KillMonsterCount;
			}
			if (other.GainItemCount != 0)
			{
				GainItemCount = other.GainItemCount;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.TraceDistance != 0)
			{
				TraceDistance = other.TraceDistance;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.RandomCount != 0)
			{
				RandomCount = other.RandomCount;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				ConditionType = input.ReadInt32();
				break;
			case 16u:
				SuccessLimit = input.ReadInt32();
				break;
			case 26u:
				ObserveActorGuid = input.ReadString();
				break;
			case 32u:
				PlayerCount = input.ReadInt32();
				break;
			case 40u:
				KillMonsterCount = input.ReadInt32();
				break;
			case 48u:
				GainItemCount = input.ReadInt32();
				break;
			case 56u:
				ItemId = input.ReadInt32();
				break;
			case 64u:
				TraceDistance = input.ReadInt32();
				break;
			case 72u:
				EventId = input.ReadInt32();
				break;
			case 80u:
				RandomCount = input.ReadInt32();
				break;
			}
		}
	}
}
