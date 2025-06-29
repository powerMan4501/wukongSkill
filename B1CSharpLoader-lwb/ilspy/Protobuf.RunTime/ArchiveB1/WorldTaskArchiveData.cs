using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class WorldTaskArchiveData : IMessage<WorldTaskArchiveData>, IMessage, IEquatable<WorldTaskArchiveData>, IDeepCloneable<WorldTaskArchiveData>
{
	private static readonly MessageParser<WorldTaskArchiveData> _parser = new MessageParser<WorldTaskArchiveData>(() => new WorldTaskArchiveData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<TaskGraphDataInfo> _repeated_taskGraphDataInfoList_codec = FieldCodec.ForMessage(10u, TaskGraphDataInfo.Parser);

	private readonly RepeatedField<TaskGraphDataInfo> taskGraphDataInfoList_ = new RepeatedField<TaskGraphDataInfo>();

	private static readonly FieldCodec<InteractionRecordData> _repeated_interactionRecordList_codec = FieldCodec.ForMessage(18u, InteractionRecordData.Parser);

	private readonly RepeatedField<InteractionRecordData> interactionRecordList_ = new RepeatedField<InteractionRecordData>();

	public static MessageParser<WorldTaskArchiveData> Parser => _parser;

	public RepeatedField<TaskGraphDataInfo> TaskGraphDataInfoList => taskGraphDataInfoList_;

	public RepeatedField<InteractionRecordData> InteractionRecordList => interactionRecordList_;

	public WorldTaskArchiveData()
	{
	}

	public WorldTaskArchiveData(WorldTaskArchiveData other)
		: this()
	{
		taskGraphDataInfoList_ = other.taskGraphDataInfoList_.Clone();
		interactionRecordList_ = other.interactionRecordList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WorldTaskArchiveData Clone()
	{
		return new WorldTaskArchiveData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WorldTaskArchiveData);
	}

	public bool Equals(WorldTaskArchiveData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!taskGraphDataInfoList_.Equals(other.taskGraphDataInfoList_))
		{
			return false;
		}
		if (!interactionRecordList_.Equals(other.interactionRecordList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= taskGraphDataInfoList_.GetHashCode();
		num ^= interactionRecordList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		taskGraphDataInfoList_.WriteTo(output, _repeated_taskGraphDataInfoList_codec);
		interactionRecordList_.WriteTo(output, _repeated_interactionRecordList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += taskGraphDataInfoList_.CalculateSize(_repeated_taskGraphDataInfoList_codec);
		num += interactionRecordList_.CalculateSize(_repeated_interactionRecordList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WorldTaskArchiveData other)
	{
		if (other != null)
		{
			taskGraphDataInfoList_.Add(other.taskGraphDataInfoList_);
			interactionRecordList_.Add(other.interactionRecordList_);
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
				taskGraphDataInfoList_.AddEntriesFrom(input, _repeated_taskGraphDataInfoList_codec);
				break;
			case 18u:
				interactionRecordList_.AddEntriesFrom(input, _repeated_interactionRecordList_codec);
				break;
			}
		}
	}
}
