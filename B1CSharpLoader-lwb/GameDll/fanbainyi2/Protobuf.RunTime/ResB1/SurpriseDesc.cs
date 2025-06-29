using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class SurpriseDesc : IMessage<SurpriseDesc>, IMessage, IEquatable<SurpriseDesc>, IDeepCloneable<SurpriseDesc>
{
	private static readonly MessageParser<SurpriseDesc> _parser = new MessageParser<SurpriseDesc>(() => new SurpriseDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int chapterId_;

	private int taskStageId_;

	private QuestStage stage_;

	private int sequenceId_;

	private float activeRadius_;

	private float interactRadius_;

	private float activeDistanceMax_;

	private float activeDistanceMin_;

	private float interactDistanceMax_;

	private float interactDistanceMin_;

	public static MessageParser<SurpriseDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
		}
	}

	public int TaskStageId
	{
		get
		{
			return taskStageId_;
		}
		set
		{
			taskStageId_ = value;
		}
	}

	public QuestStage Stage
	{
		get
		{
			return stage_;
		}
		set
		{
			stage_ = value;
		}
	}

	public int SequenceId
	{
		get
		{
			return sequenceId_;
		}
		set
		{
			sequenceId_ = value;
		}
	}

	public float ActiveRadius
	{
		get
		{
			return activeRadius_;
		}
		set
		{
			activeRadius_ = value;
		}
	}

	public float InteractRadius
	{
		get
		{
			return interactRadius_;
		}
		set
		{
			interactRadius_ = value;
		}
	}

	public float ActiveDistanceMax
	{
		get
		{
			return activeDistanceMax_;
		}
		set
		{
			activeDistanceMax_ = value;
		}
	}

	public float ActiveDistanceMin
	{
		get
		{
			return activeDistanceMin_;
		}
		set
		{
			activeDistanceMin_ = value;
		}
	}

	public float InteractDistanceMax
	{
		get
		{
			return interactDistanceMax_;
		}
		set
		{
			interactDistanceMax_ = value;
		}
	}

	public float InteractDistanceMin
	{
		get
		{
			return interactDistanceMin_;
		}
		set
		{
			interactDistanceMin_ = value;
		}
	}

	public SurpriseDesc()
	{
	}

	public SurpriseDesc(SurpriseDesc other)
		: this()
	{
		id_ = other.id_;
		chapterId_ = other.chapterId_;
		taskStageId_ = other.taskStageId_;
		stage_ = other.stage_;
		sequenceId_ = other.sequenceId_;
		activeRadius_ = other.activeRadius_;
		interactRadius_ = other.interactRadius_;
		activeDistanceMax_ = other.activeDistanceMax_;
		activeDistanceMin_ = other.activeDistanceMin_;
		interactDistanceMax_ = other.interactDistanceMax_;
		interactDistanceMin_ = other.interactDistanceMin_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SurpriseDesc Clone()
	{
		return new SurpriseDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SurpriseDesc);
	}

	public bool Equals(SurpriseDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		if (TaskStageId != other.TaskStageId)
		{
			return false;
		}
		if (Stage != other.Stage)
		{
			return false;
		}
		if (SequenceId != other.SequenceId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ActiveRadius, other.ActiveRadius))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InteractRadius, other.InteractRadius))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ActiveDistanceMax, other.ActiveDistanceMax))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ActiveDistanceMin, other.ActiveDistanceMin))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InteractDistanceMax, other.InteractDistanceMax))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InteractDistanceMin, other.InteractDistanceMin))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		if (TaskStageId != 0)
		{
			num ^= TaskStageId.GetHashCode();
		}
		if (Stage != QuestStage.Default)
		{
			num ^= Stage.GetHashCode();
		}
		if (SequenceId != 0)
		{
			num ^= SequenceId.GetHashCode();
		}
		if (ActiveRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ActiveRadius);
		}
		if (InteractRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InteractRadius);
		}
		if (ActiveDistanceMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ActiveDistanceMax);
		}
		if (ActiveDistanceMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ActiveDistanceMin);
		}
		if (InteractDistanceMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InteractDistanceMax);
		}
		if (InteractDistanceMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InteractDistanceMin);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ChapterId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ChapterId);
		}
		if (TaskStageId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TaskStageId);
		}
		if (Stage != QuestStage.Default)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Stage);
		}
		if (SequenceId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SequenceId);
		}
		if (ActiveRadius != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(ActiveRadius);
		}
		if (InteractRadius != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(InteractRadius);
		}
		if (ActiveDistanceMax != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(ActiveDistanceMax);
		}
		if (ActiveDistanceMin != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(ActiveDistanceMin);
		}
		if (InteractDistanceMax != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(InteractDistanceMax);
		}
		if (InteractDistanceMin != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(InteractDistanceMin);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		if (TaskStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskStageId);
		}
		if (Stage != QuestStage.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Stage);
		}
		if (SequenceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SequenceId);
		}
		if (ActiveRadius != 0f)
		{
			num += 5;
		}
		if (InteractRadius != 0f)
		{
			num += 5;
		}
		if (ActiveDistanceMax != 0f)
		{
			num += 5;
		}
		if (ActiveDistanceMin != 0f)
		{
			num += 5;
		}
		if (InteractDistanceMax != 0f)
		{
			num += 5;
		}
		if (InteractDistanceMin != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SurpriseDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
			}
			if (other.TaskStageId != 0)
			{
				TaskStageId = other.TaskStageId;
			}
			if (other.Stage != QuestStage.Default)
			{
				Stage = other.Stage;
			}
			if (other.SequenceId != 0)
			{
				SequenceId = other.SequenceId;
			}
			if (other.ActiveRadius != 0f)
			{
				ActiveRadius = other.ActiveRadius;
			}
			if (other.InteractRadius != 0f)
			{
				InteractRadius = other.InteractRadius;
			}
			if (other.ActiveDistanceMax != 0f)
			{
				ActiveDistanceMax = other.ActiveDistanceMax;
			}
			if (other.ActiveDistanceMin != 0f)
			{
				ActiveDistanceMin = other.ActiveDistanceMin;
			}
			if (other.InteractDistanceMax != 0f)
			{
				InteractDistanceMax = other.InteractDistanceMax;
			}
			if (other.InteractDistanceMin != 0f)
			{
				InteractDistanceMin = other.InteractDistanceMin;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				ChapterId = input.ReadInt32();
				break;
			case 24u:
				TaskStageId = input.ReadInt32();
				break;
			case 32u:
				Stage = (QuestStage)input.ReadEnum();
				break;
			case 40u:
				SequenceId = input.ReadInt32();
				break;
			case 53u:
				ActiveRadius = input.ReadFloat();
				break;
			case 61u:
				InteractRadius = input.ReadFloat();
				break;
			case 69u:
				ActiveDistanceMax = input.ReadFloat();
				break;
			case 77u:
				ActiveDistanceMin = input.ReadFloat();
				break;
			case 85u:
				InteractDistanceMax = input.ReadFloat();
				break;
			case 93u:
				InteractDistanceMin = input.ReadFloat();
				break;
			}
		}
	}
}
