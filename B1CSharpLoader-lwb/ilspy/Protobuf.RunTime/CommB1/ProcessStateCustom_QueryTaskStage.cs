using System;
using ArchiveB1;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_QueryTaskStage : IMessage<ProcessStateCustom_QueryTaskStage>, IMessage, IEquatable<ProcessStateCustom_QueryTaskStage>, IDeepCloneable<ProcessStateCustom_QueryTaskStage>
{
	private static readonly MessageParser<ProcessStateCustom_QueryTaskStage> _parser = new MessageParser<ProcessStateCustom_QueryTaskStage>(() => new ProcessStateCustom_QueryTaskStage());

	private UnknownFieldSet _unknownFields;

	private QuestStageOne queryTaskStageInfo_;

	public static MessageParser<ProcessStateCustom_QueryTaskStage> Parser => _parser;

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

	public ProcessStateCustom_QueryTaskStage()
	{
	}

	public ProcessStateCustom_QueryTaskStage(ProcessStateCustom_QueryTaskStage other)
		: this()
	{
		queryTaskStageInfo_ = ((other.queryTaskStageInfo_ != null) ? other.queryTaskStageInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_QueryTaskStage Clone()
	{
		return new ProcessStateCustom_QueryTaskStage(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_QueryTaskStage);
	}

	public bool Equals(ProcessStateCustom_QueryTaskStage other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(QueryTaskStageInfo, other.QueryTaskStageInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (queryTaskStageInfo_ != null)
		{
			num ^= QueryTaskStageInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (queryTaskStageInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(QueryTaskStageInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (queryTaskStageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QueryTaskStageInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_QueryTaskStage other)
	{
		if (other == null)
		{
			return;
		}
		if (other.queryTaskStageInfo_ != null)
		{
			if (queryTaskStageInfo_ == null)
			{
				QueryTaskStageInfo = new QuestStageOne();
			}
			QueryTaskStageInfo.MergeFrom(other.QueryTaskStageInfo);
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
			if (queryTaskStageInfo_ == null)
			{
				QueryTaskStageInfo = new QuestStageOne();
			}
			input.ReadMessage(QueryTaskStageInfo);
		}
	}
}
