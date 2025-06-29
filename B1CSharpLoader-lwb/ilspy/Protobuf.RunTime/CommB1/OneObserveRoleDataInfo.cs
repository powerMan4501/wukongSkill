using System;
using ArchiveB1;
using Google.Protobuf;

namespace CommB1;

public sealed class OneObserveRoleDataInfo : IMessage<OneObserveRoleDataInfo>, IMessage, IEquatable<OneObserveRoleDataInfo>, IDeepCloneable<OneObserveRoleDataInfo>
{
	private static readonly MessageParser<OneObserveRoleDataInfo> _parser = new MessageParser<OneObserveRoleDataInfo>(() => new OneObserveRoleDataInfo());

	private UnknownFieldSet _unknownFields;

	private int index_;

	private ObserveRoleDataType observeType_;

	private QuestStageOne observeTaskStageInfo_;

	private InteractionRecordInfo observeInteractionRecordInfo_;

	private OwningItemInfo observeOwningItemInfo_;

	private ConsumedItemInfo observeComsumedItemInfo_;

	public static MessageParser<OneObserveRoleDataInfo> Parser => _parser;

	public int Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	public ObserveRoleDataType ObserveType
	{
		get
		{
			return observeType_;
		}
		set
		{
			observeType_ = value;
		}
	}

	public QuestStageOne ObserveTaskStageInfo
	{
		get
		{
			return observeTaskStageInfo_;
		}
		set
		{
			observeTaskStageInfo_ = value;
		}
	}

	public InteractionRecordInfo ObserveInteractionRecordInfo
	{
		get
		{
			return observeInteractionRecordInfo_;
		}
		set
		{
			observeInteractionRecordInfo_ = value;
		}
	}

	public OwningItemInfo ObserveOwningItemInfo
	{
		get
		{
			return observeOwningItemInfo_;
		}
		set
		{
			observeOwningItemInfo_ = value;
		}
	}

	public ConsumedItemInfo ObserveComsumedItemInfo
	{
		get
		{
			return observeComsumedItemInfo_;
		}
		set
		{
			observeComsumedItemInfo_ = value;
		}
	}

	public OneObserveRoleDataInfo()
	{
	}

	public OneObserveRoleDataInfo(OneObserveRoleDataInfo other)
		: this()
	{
		index_ = other.index_;
		observeType_ = other.observeType_;
		observeTaskStageInfo_ = ((other.observeTaskStageInfo_ != null) ? other.observeTaskStageInfo_.Clone() : null);
		observeInteractionRecordInfo_ = ((other.observeInteractionRecordInfo_ != null) ? other.observeInteractionRecordInfo_.Clone() : null);
		observeOwningItemInfo_ = ((other.observeOwningItemInfo_ != null) ? other.observeOwningItemInfo_.Clone() : null);
		observeComsumedItemInfo_ = ((other.observeComsumedItemInfo_ != null) ? other.observeComsumedItemInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OneObserveRoleDataInfo Clone()
	{
		return new OneObserveRoleDataInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OneObserveRoleDataInfo);
	}

	public bool Equals(OneObserveRoleDataInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (ObserveType != other.ObserveType)
		{
			return false;
		}
		if (!object.Equals(ObserveTaskStageInfo, other.ObserveTaskStageInfo))
		{
			return false;
		}
		if (!object.Equals(ObserveInteractionRecordInfo, other.ObserveInteractionRecordInfo))
		{
			return false;
		}
		if (!object.Equals(ObserveOwningItemInfo, other.ObserveOwningItemInfo))
		{
			return false;
		}
		if (!object.Equals(ObserveComsumedItemInfo, other.ObserveComsumedItemInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (ObserveType != ObserveRoleDataType.ObserveConsumedItem)
		{
			num ^= ObserveType.GetHashCode();
		}
		if (observeTaskStageInfo_ != null)
		{
			num ^= ObserveTaskStageInfo.GetHashCode();
		}
		if (observeInteractionRecordInfo_ != null)
		{
			num ^= ObserveInteractionRecordInfo.GetHashCode();
		}
		if (observeOwningItemInfo_ != null)
		{
			num ^= ObserveOwningItemInfo.GetHashCode();
		}
		if (observeComsumedItemInfo_ != null)
		{
			num ^= ObserveComsumedItemInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Index != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Index);
		}
		if (ObserveType != ObserveRoleDataType.ObserveConsumedItem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ObserveType);
		}
		if (observeTaskStageInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ObserveTaskStageInfo);
		}
		if (observeInteractionRecordInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ObserveInteractionRecordInfo);
		}
		if (observeOwningItemInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ObserveOwningItemInfo);
		}
		if (observeComsumedItemInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ObserveComsumedItemInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Index);
		}
		if (ObserveType != ObserveRoleDataType.ObserveConsumedItem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ObserveType);
		}
		if (observeTaskStageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ObserveTaskStageInfo);
		}
		if (observeInteractionRecordInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ObserveInteractionRecordInfo);
		}
		if (observeOwningItemInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ObserveOwningItemInfo);
		}
		if (observeComsumedItemInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ObserveComsumedItemInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OneObserveRoleDataInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Index != 0)
		{
			Index = other.Index;
		}
		if (other.ObserveType != ObserveRoleDataType.ObserveConsumedItem)
		{
			ObserveType = other.ObserveType;
		}
		if (other.observeTaskStageInfo_ != null)
		{
			if (observeTaskStageInfo_ == null)
			{
				ObserveTaskStageInfo = new QuestStageOne();
			}
			ObserveTaskStageInfo.MergeFrom(other.ObserveTaskStageInfo);
		}
		if (other.observeInteractionRecordInfo_ != null)
		{
			if (observeInteractionRecordInfo_ == null)
			{
				ObserveInteractionRecordInfo = new InteractionRecordInfo();
			}
			ObserveInteractionRecordInfo.MergeFrom(other.ObserveInteractionRecordInfo);
		}
		if (other.observeOwningItemInfo_ != null)
		{
			if (observeOwningItemInfo_ == null)
			{
				ObserveOwningItemInfo = new OwningItemInfo();
			}
			ObserveOwningItemInfo.MergeFrom(other.ObserveOwningItemInfo);
		}
		if (other.observeComsumedItemInfo_ != null)
		{
			if (observeComsumedItemInfo_ == null)
			{
				ObserveComsumedItemInfo = new ConsumedItemInfo();
			}
			ObserveComsumedItemInfo.MergeFrom(other.ObserveComsumedItemInfo);
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
				Index = input.ReadInt32();
				break;
			case 16u:
				ObserveType = (ObserveRoleDataType)input.ReadEnum();
				break;
			case 26u:
				if (observeTaskStageInfo_ == null)
				{
					ObserveTaskStageInfo = new QuestStageOne();
				}
				input.ReadMessage(ObserveTaskStageInfo);
				break;
			case 34u:
				if (observeInteractionRecordInfo_ == null)
				{
					ObserveInteractionRecordInfo = new InteractionRecordInfo();
				}
				input.ReadMessage(ObserveInteractionRecordInfo);
				break;
			case 42u:
				if (observeOwningItemInfo_ == null)
				{
					ObserveOwningItemInfo = new OwningItemInfo();
				}
				input.ReadMessage(ObserveOwningItemInfo);
				break;
			case 50u:
				if (observeComsumedItemInfo_ == null)
				{
					ObserveComsumedItemInfo = new ConsumedItemInfo();
				}
				input.ReadMessage(ObserveComsumedItemInfo);
				break;
			}
		}
	}
}
