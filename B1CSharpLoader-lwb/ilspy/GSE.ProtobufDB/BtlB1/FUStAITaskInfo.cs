using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAITaskInfo : IMessage<FUStAITaskInfo>, IMessage, IEquatable<FUStAITaskInfo>, IDeepCloneable<FUStAITaskInfo>
{
	private static readonly MessageParser<FUStAITaskInfo> _parser = new MessageParser<FUStAITaskInfo>(() => new FUStAITaskInfo());

	private UnknownFieldSet _unknownFields;

	private EAITaskActionType aITaskActionType_;

	private static readonly FieldCodec<int> _repeated_taskIntParams_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> taskIntParams_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_taskFloatParams_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> taskFloatParams_ = new RepeatedField<int>();

	private static readonly FieldCodec<string> _repeated_taskStringParams_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> taskStringParams_ = new RepeatedField<string>();

	public static MessageParser<FUStAITaskInfo> Parser => _parser;

	public EAITaskActionType AITaskActionType
	{
		get
		{
			return aITaskActionType_;
		}
		set
		{
			aITaskActionType_ = value;
		}
	}

	public RepeatedField<int> TaskIntParams => taskIntParams_;

	public RepeatedField<int> TaskFloatParams => taskFloatParams_;

	public RepeatedField<string> TaskStringParams => taskStringParams_;

	public FUStAITaskInfo()
	{
	}

	public FUStAITaskInfo(FUStAITaskInfo other)
		: this()
	{
		aITaskActionType_ = other.aITaskActionType_;
		taskIntParams_ = other.taskIntParams_.Clone();
		taskFloatParams_ = other.taskFloatParams_.Clone();
		taskStringParams_ = other.taskStringParams_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAITaskInfo Clone()
	{
		return new FUStAITaskInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAITaskInfo);
	}

	public bool Equals(FUStAITaskInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AITaskActionType != other.AITaskActionType)
		{
			return false;
		}
		if (!taskIntParams_.Equals(other.taskIntParams_))
		{
			return false;
		}
		if (!taskFloatParams_.Equals(other.taskFloatParams_))
		{
			return false;
		}
		if (!taskStringParams_.Equals(other.taskStringParams_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AITaskActionType != EAITaskActionType.CastSkill)
		{
			num ^= AITaskActionType.GetHashCode();
		}
		num ^= taskIntParams_.GetHashCode();
		num ^= taskFloatParams_.GetHashCode();
		num ^= taskStringParams_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AITaskActionType != EAITaskActionType.CastSkill)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)AITaskActionType);
		}
		taskIntParams_.WriteTo(output, _repeated_taskIntParams_codec);
		taskFloatParams_.WriteTo(output, _repeated_taskFloatParams_codec);
		taskStringParams_.WriteTo(output, _repeated_taskStringParams_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AITaskActionType != EAITaskActionType.CastSkill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AITaskActionType);
		}
		num += taskIntParams_.CalculateSize(_repeated_taskIntParams_codec);
		num += taskFloatParams_.CalculateSize(_repeated_taskFloatParams_codec);
		num += taskStringParams_.CalculateSize(_repeated_taskStringParams_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAITaskInfo other)
	{
		if (other != null)
		{
			if (other.AITaskActionType != EAITaskActionType.CastSkill)
			{
				AITaskActionType = other.AITaskActionType;
			}
			taskIntParams_.Add(other.taskIntParams_);
			taskFloatParams_.Add(other.taskFloatParams_);
			taskStringParams_.Add(other.taskStringParams_);
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
				AITaskActionType = (EAITaskActionType)input.ReadEnum();
				break;
			case 16u:
			case 18u:
				taskIntParams_.AddEntriesFrom(input, _repeated_taskIntParams_codec);
				break;
			case 24u:
			case 26u:
				taskFloatParams_.AddEntriesFrom(input, _repeated_taskFloatParams_codec);
				break;
			case 34u:
				taskStringParams_.AddEntriesFrom(input, _repeated_taskStringParams_codec);
				break;
			}
		}
	}
}
