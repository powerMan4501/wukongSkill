using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStMandatoryAITaskDesc : IMessage<FUStMandatoryAITaskDesc>, IMessage, IEquatable<FUStMandatoryAITaskDesc>, IDeepCloneable<FUStMandatoryAITaskDesc>
{
	private static readonly MessageParser<FUStMandatoryAITaskDesc> _parser = new MessageParser<FUStMandatoryAITaskDesc>(() => new FUStMandatoryAITaskDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private string instanceGUID_ = "";

	private EAITaskCondition taskCondition_;

	private EAITaskActivationEvent taskActivationEvent_;

	private EGSYesNo isReverseCondition_;

	private static readonly FieldCodec<float> _repeated_conditionFloatParams_codec = FieldCodec.ForFloat(58u);

	private readonly RepeatedField<float> conditionFloatParams_ = new RepeatedField<float>();

	private static readonly FieldCodec<int> _repeated_conditionIntParams_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> conditionIntParams_ = new RepeatedField<int>();

	private static readonly FieldCodec<FUStAITaskInfo> _repeated_aITaskInfoList_codec = FieldCodec.ForMessage(74u, FUStAITaskInfo.Parser);

	private readonly RepeatedField<FUStAITaskInfo> aITaskInfoList_ = new RepeatedField<FUStAITaskInfo>();

	public static MessageParser<FUStMandatoryAITaskDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public string InstanceGUID
	{
		get
		{
			return instanceGUID_;
		}
		set
		{
			instanceGUID_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EAITaskCondition TaskCondition
	{
		get
		{
			return taskCondition_;
		}
		set
		{
			taskCondition_ = value;
		}
	}

	public EAITaskActivationEvent TaskActivationEvent
	{
		get
		{
			return taskActivationEvent_;
		}
		set
		{
			taskActivationEvent_ = value;
		}
	}

	public EGSYesNo IsReverseCondition
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

	public RepeatedField<float> ConditionFloatParams => conditionFloatParams_;

	public RepeatedField<int> ConditionIntParams => conditionIntParams_;

	public RepeatedField<FUStAITaskInfo> AITaskInfoList => aITaskInfoList_;

	public FUStMandatoryAITaskDesc()
	{
	}

	public FUStMandatoryAITaskDesc(FUStMandatoryAITaskDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		instanceGUID_ = other.instanceGUID_;
		taskCondition_ = other.taskCondition_;
		taskActivationEvent_ = other.taskActivationEvent_;
		isReverseCondition_ = other.isReverseCondition_;
		conditionFloatParams_ = other.conditionFloatParams_.Clone();
		conditionIntParams_ = other.conditionIntParams_.Clone();
		aITaskInfoList_ = other.aITaskInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMandatoryAITaskDesc Clone()
	{
		return new FUStMandatoryAITaskDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMandatoryAITaskDesc);
	}

	public bool Equals(FUStMandatoryAITaskDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (ResID != other.ResID)
		{
			return false;
		}
		if (InstanceGUID != other.InstanceGUID)
		{
			return false;
		}
		if (TaskCondition != other.TaskCondition)
		{
			return false;
		}
		if (TaskActivationEvent != other.TaskActivationEvent)
		{
			return false;
		}
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (!conditionFloatParams_.Equals(other.conditionFloatParams_))
		{
			return false;
		}
		if (!conditionIntParams_.Equals(other.conditionIntParams_))
		{
			return false;
		}
		if (!aITaskInfoList_.Equals(other.aITaskInfoList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (InstanceGUID.Length != 0)
		{
			num ^= InstanceGUID.GetHashCode();
		}
		if (TaskCondition != EAITaskCondition.None)
		{
			num ^= TaskCondition.GetHashCode();
		}
		if (TaskActivationEvent != EAITaskActivationEvent.AtOnce)
		{
			num ^= TaskActivationEvent.GetHashCode();
		}
		if (IsReverseCondition != EGSYesNo.No)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		num ^= conditionFloatParams_.GetHashCode();
		num ^= conditionIntParams_.GetHashCode();
		num ^= aITaskInfoList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (ResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResID);
		}
		if (InstanceGUID.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(InstanceGUID);
		}
		if (TaskCondition != EAITaskCondition.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)TaskCondition);
		}
		if (TaskActivationEvent != EAITaskActivationEvent.AtOnce)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)TaskActivationEvent);
		}
		if (IsReverseCondition != EGSYesNo.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)IsReverseCondition);
		}
		conditionFloatParams_.WriteTo(output, _repeated_conditionFloatParams_codec);
		conditionIntParams_.WriteTo(output, _repeated_conditionIntParams_codec);
		aITaskInfoList_.WriteTo(output, _repeated_aITaskInfoList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (InstanceGUID.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InstanceGUID);
		}
		if (TaskCondition != EAITaskCondition.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TaskCondition);
		}
		if (TaskActivationEvent != EAITaskActivationEvent.AtOnce)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TaskActivationEvent);
		}
		if (IsReverseCondition != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsReverseCondition);
		}
		num += conditionFloatParams_.CalculateSize(_repeated_conditionFloatParams_codec);
		num += conditionIntParams_.CalculateSize(_repeated_conditionIntParams_codec);
		num += aITaskInfoList_.CalculateSize(_repeated_aITaskInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStMandatoryAITaskDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.InstanceGUID.Length != 0)
			{
				InstanceGUID = other.InstanceGUID;
			}
			if (other.TaskCondition != EAITaskCondition.None)
			{
				TaskCondition = other.TaskCondition;
			}
			if (other.TaskActivationEvent != EAITaskActivationEvent.AtOnce)
			{
				TaskActivationEvent = other.TaskActivationEvent;
			}
			if (other.IsReverseCondition != EGSYesNo.No)
			{
				IsReverseCondition = other.IsReverseCondition;
			}
			conditionFloatParams_.Add(other.conditionFloatParams_);
			conditionIntParams_.Add(other.conditionIntParams_);
			aITaskInfoList_.Add(other.aITaskInfoList_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
				ResID = input.ReadInt32();
				break;
			case 26u:
				InstanceGUID = input.ReadString();
				break;
			case 32u:
				TaskCondition = (EAITaskCondition)input.ReadEnum();
				break;
			case 40u:
				TaskActivationEvent = (EAITaskActivationEvent)input.ReadEnum();
				break;
			case 48u:
				IsReverseCondition = (EGSYesNo)input.ReadEnum();
				break;
			case 58u:
			case 61u:
				conditionFloatParams_.AddEntriesFrom(input, _repeated_conditionFloatParams_codec);
				break;
			case 64u:
			case 66u:
				conditionIntParams_.AddEntriesFrom(input, _repeated_conditionIntParams_codec);
				break;
			case 74u:
				aITaskInfoList_.AddEntriesFrom(input, _repeated_aITaskInfoList_codec);
				break;
			}
		}
	}
}
