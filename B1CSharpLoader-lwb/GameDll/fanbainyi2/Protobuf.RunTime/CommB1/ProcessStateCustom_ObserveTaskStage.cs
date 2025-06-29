using System;
using ArchiveB1;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_ObserveTaskStage : IMessage<ProcessStateCustom_ObserveTaskStage>, IMessage, IEquatable<ProcessStateCustom_ObserveTaskStage>, IDeepCloneable<ProcessStateCustom_ObserveTaskStage>
{
	private static readonly MessageParser<ProcessStateCustom_ObserveTaskStage> _parser = new MessageParser<ProcessStateCustom_ObserveTaskStage>(() => new ProcessStateCustom_ObserveTaskStage());

	private UnknownFieldSet _unknownFields;

	private QuestStageOne observeTaskStageInfo_;

	public static MessageParser<ProcessStateCustom_ObserveTaskStage> Parser => _parser;

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

	public ProcessStateCustom_ObserveTaskStage()
	{
	}

	public ProcessStateCustom_ObserveTaskStage(ProcessStateCustom_ObserveTaskStage other)
		: this()
	{
		observeTaskStageInfo_ = ((other.observeTaskStageInfo_ != null) ? other.observeTaskStageInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_ObserveTaskStage Clone()
	{
		return new ProcessStateCustom_ObserveTaskStage(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_ObserveTaskStage);
	}

	public bool Equals(ProcessStateCustom_ObserveTaskStage other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ObserveTaskStageInfo, other.ObserveTaskStageInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (observeTaskStageInfo_ != null)
		{
			num ^= ObserveTaskStageInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (observeTaskStageInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ObserveTaskStageInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (observeTaskStageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ObserveTaskStageInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_ObserveTaskStage other)
	{
		if (other == null)
		{
			return;
		}
		if (other.observeTaskStageInfo_ != null)
		{
			if (observeTaskStageInfo_ == null)
			{
				ObserveTaskStageInfo = new QuestStageOne();
			}
			ObserveTaskStageInfo.MergeFrom(other.ObserveTaskStageInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (observeTaskStageInfo_ == null)
			{
				ObserveTaskStageInfo = new QuestStageOne();
			}
			input.ReadMessage(ObserveTaskStageInfo);
		}
	}
}
