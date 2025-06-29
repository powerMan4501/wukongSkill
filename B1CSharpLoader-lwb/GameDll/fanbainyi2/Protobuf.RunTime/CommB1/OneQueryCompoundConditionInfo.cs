using System;
using ArchiveB1;
using Google.Protobuf;

namespace CommB1;

public sealed class OneQueryCompoundConditionInfo : IMessage<OneQueryCompoundConditionInfo>, IMessage, IEquatable<OneQueryCompoundConditionInfo>, IDeepCloneable<OneQueryCompoundConditionInfo>
{
	private static readonly MessageParser<OneQueryCompoundConditionInfo> _parser = new MessageParser<OneQueryCompoundConditionInfo>(() => new OneQueryCompoundConditionInfo());

	private UnknownFieldSet _unknownFields;

	private bool isReverseCondition_;

	private QueryCompoundConditionType conditionType_;

	private QuestStageOne queryTaskStageInfo_;

	private InteractionRecordInfo queryInteractionRecordInfo_;

	private OwningItemInfo queryOwningItemInfo_;

	private UnitStatusInfo queryUnitStatusInfo_;

	public static MessageParser<OneQueryCompoundConditionInfo> Parser => _parser;

	public bool IsReverseCondition
	{
		get
		{
			return isReverseCondition_;
		}
		set
		{
			isReverseCondition_ = value;
		}
	}

	public QueryCompoundConditionType ConditionType
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

	public QuestStageOne QueryTaskStageInfo
	{
		get
		{
			return queryTaskStageInfo_;
		}
		set
		{
			queryTaskStageInfo_ = value;
		}
	}

	public InteractionRecordInfo QueryInteractionRecordInfo
	{
		get
		{
			return queryInteractionRecordInfo_;
		}
		set
		{
			queryInteractionRecordInfo_ = value;
		}
	}

	public OwningItemInfo QueryOwningItemInfo
	{
		get
		{
			return queryOwningItemInfo_;
		}
		set
		{
			queryOwningItemInfo_ = value;
		}
	}

	public UnitStatusInfo QueryUnitStatusInfo
	{
		get
		{
			return queryUnitStatusInfo_;
		}
		set
		{
			queryUnitStatusInfo_ = value;
		}
	}

	public OneQueryCompoundConditionInfo()
	{
	}

	public OneQueryCompoundConditionInfo(OneQueryCompoundConditionInfo other)
		: this()
	{
		isReverseCondition_ = other.isReverseCondition_;
		conditionType_ = other.conditionType_;
		queryTaskStageInfo_ = ((other.queryTaskStageInfo_ != null) ? other.queryTaskStageInfo_.Clone() : null);
		queryInteractionRecordInfo_ = ((other.queryInteractionRecordInfo_ != null) ? other.queryInteractionRecordInfo_.Clone() : null);
		queryOwningItemInfo_ = ((other.queryOwningItemInfo_ != null) ? other.queryOwningItemInfo_.Clone() : null);
		queryUnitStatusInfo_ = ((other.queryUnitStatusInfo_ != null) ? other.queryUnitStatusInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OneQueryCompoundConditionInfo Clone()
	{
		return new OneQueryCompoundConditionInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OneQueryCompoundConditionInfo);
	}

	public bool Equals(OneQueryCompoundConditionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (ConditionType != other.ConditionType)
		{
			return false;
		}
		if (!object.Equals(QueryTaskStageInfo, other.QueryTaskStageInfo))
		{
			return false;
		}
		if (!object.Equals(QueryInteractionRecordInfo, other.QueryInteractionRecordInfo))
		{
			return false;
		}
		if (!object.Equals(QueryOwningItemInfo, other.QueryOwningItemInfo))
		{
			return false;
		}
		if (!object.Equals(QueryUnitStatusInfo, other.QueryUnitStatusInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		if (ConditionType != QueryCompoundConditionType.QueryTaskStageInfo)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (queryTaskStageInfo_ != null)
		{
			num ^= QueryTaskStageInfo.GetHashCode();
		}
		if (queryInteractionRecordInfo_ != null)
		{
			num ^= QueryInteractionRecordInfo.GetHashCode();
		}
		if (queryOwningItemInfo_ != null)
		{
			num ^= QueryOwningItemInfo.GetHashCode();
		}
		if (queryUnitStatusInfo_ != null)
		{
			num ^= QueryUnitStatusInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsReverseCondition)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsReverseCondition);
		}
		if (ConditionType != QueryCompoundConditionType.QueryTaskStageInfo)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ConditionType);
		}
		if (queryTaskStageInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(QueryTaskStageInfo);
		}
		if (queryInteractionRecordInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(QueryInteractionRecordInfo);
		}
		if (queryOwningItemInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(QueryOwningItemInfo);
		}
		if (queryUnitStatusInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(QueryUnitStatusInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (ConditionType != QueryCompoundConditionType.QueryTaskStageInfo)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConditionType);
		}
		if (queryTaskStageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QueryTaskStageInfo);
		}
		if (queryInteractionRecordInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QueryInteractionRecordInfo);
		}
		if (queryOwningItemInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QueryOwningItemInfo);
		}
		if (queryUnitStatusInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QueryUnitStatusInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OneQueryCompoundConditionInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IsReverseCondition)
		{
			IsReverseCondition = other.IsReverseCondition;
		}
		if (other.ConditionType != QueryCompoundConditionType.QueryTaskStageInfo)
		{
			ConditionType = other.ConditionType;
		}
		if (other.queryTaskStageInfo_ != null)
		{
			if (queryTaskStageInfo_ == null)
			{
				QueryTaskStageInfo = new QuestStageOne();
			}
			QueryTaskStageInfo.MergeFrom(other.QueryTaskStageInfo);
		}
		if (other.queryInteractionRecordInfo_ != null)
		{
			if (queryInteractionRecordInfo_ == null)
			{
				QueryInteractionRecordInfo = new InteractionRecordInfo();
			}
			QueryInteractionRecordInfo.MergeFrom(other.QueryInteractionRecordInfo);
		}
		if (other.queryOwningItemInfo_ != null)
		{
			if (queryOwningItemInfo_ == null)
			{
				QueryOwningItemInfo = new OwningItemInfo();
			}
			QueryOwningItemInfo.MergeFrom(other.QueryOwningItemInfo);
		}
		if (other.queryUnitStatusInfo_ != null)
		{
			if (queryUnitStatusInfo_ == null)
			{
				QueryUnitStatusInfo = new UnitStatusInfo();
			}
			QueryUnitStatusInfo.MergeFrom(other.QueryUnitStatusInfo);
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
				IsReverseCondition = input.ReadBool();
				break;
			case 16u:
				ConditionType = (QueryCompoundConditionType)input.ReadEnum();
				break;
			case 26u:
				if (queryTaskStageInfo_ == null)
				{
					QueryTaskStageInfo = new QuestStageOne();
				}
				input.ReadMessage(QueryTaskStageInfo);
				break;
			case 34u:
				if (queryInteractionRecordInfo_ == null)
				{
					QueryInteractionRecordInfo = new InteractionRecordInfo();
				}
				input.ReadMessage(QueryInteractionRecordInfo);
				break;
			case 42u:
				if (queryOwningItemInfo_ == null)
				{
					QueryOwningItemInfo = new OwningItemInfo();
				}
				input.ReadMessage(QueryOwningItemInfo);
				break;
			case 50u:
				if (queryUnitStatusInfo_ == null)
				{
					QueryUnitStatusInfo = new UnitStatusInfo();
				}
				input.ReadMessage(QueryUnitStatusInfo);
				break;
			}
		}
	}
}
