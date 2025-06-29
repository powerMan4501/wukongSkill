using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessCustom_NPCState : IMessage<ProcessCustom_NPCState>, IMessage, IEquatable<ProcessCustom_NPCState>, IDeepCloneable<ProcessCustom_NPCState>
{
	private static readonly MessageParser<ProcessCustom_NPCState> _parser = new MessageParser<ProcessCustom_NPCState>(() => new ProcessCustom_NPCState());

	private UnknownFieldSet _unknownFields;

	private string stateName_ = "";

	private static readonly FieldCodec<TaskConditionOutpinInfo> _repeated_taskConditionInfoList_codec = FieldCodec.ForMessage(18u, TaskConditionOutpinInfo.Parser);

	private readonly RepeatedField<TaskConditionOutpinInfo> taskConditionInfoList_ = new RepeatedField<TaskConditionOutpinInfo>();

	public static MessageParser<ProcessCustom_NPCState> Parser => _parser;

	public string StateName
	{
		get
		{
			return stateName_;
		}
		set
		{
			stateName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<TaskConditionOutpinInfo> TaskConditionInfoList => taskConditionInfoList_;

	public ProcessCustom_NPCState()
	{
	}

	public ProcessCustom_NPCState(ProcessCustom_NPCState other)
		: this()
	{
		stateName_ = other.stateName_;
		taskConditionInfoList_ = other.taskConditionInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_NPCState Clone()
	{
		return new ProcessCustom_NPCState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_NPCState);
	}

	public bool Equals(ProcessCustom_NPCState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StateName != other.StateName)
		{
			return false;
		}
		if (!taskConditionInfoList_.Equals(other.taskConditionInfoList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (StateName.Length != 0)
		{
			num ^= StateName.GetHashCode();
		}
		num ^= taskConditionInfoList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (StateName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(StateName);
		}
		taskConditionInfoList_.WriteTo(output, _repeated_taskConditionInfoList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (StateName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StateName);
		}
		num += taskConditionInfoList_.CalculateSize(_repeated_taskConditionInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessCustom_NPCState other)
	{
		if (other != null)
		{
			if (other.StateName.Length != 0)
			{
				StateName = other.StateName;
			}
			taskConditionInfoList_.Add(other.taskConditionInfoList_);
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
			case 10u:
				StateName = input.ReadString();
				break;
			case 18u:
				taskConditionInfoList_.AddEntriesFrom(input, _repeated_taskConditionInfoList_codec);
				break;
			}
		}
	}
}
