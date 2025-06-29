using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LevelArchiveSceneObjData : IMessage<LevelArchiveSceneObjData>, IMessage, IEquatable<LevelArchiveSceneObjData>, IDeepCloneable<LevelArchiveSceneObjData>
{
	private static readonly MessageParser<LevelArchiveSceneObjData> _parser = new MessageParser<LevelArchiveSceneObjData>(() => new LevelArchiveSceneObjData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<LevelArchiveSceneObjStateData> _repeated_stateData_codec = FieldCodec.ForMessage(10u, LevelArchiveSceneObjStateData.Parser);

	private readonly RepeatedField<LevelArchiveSceneObjStateData> stateData_ = new RepeatedField<LevelArchiveSceneObjStateData>();

	private static readonly FieldCodec<LevelArchiveSceneObjEventData> _repeated_eventData_codec = FieldCodec.ForMessage(18u, LevelArchiveSceneObjEventData.Parser);

	private readonly RepeatedField<LevelArchiveSceneObjEventData> eventData_ = new RepeatedField<LevelArchiveSceneObjEventData>();

	public static MessageParser<LevelArchiveSceneObjData> Parser => _parser;

	public RepeatedField<LevelArchiveSceneObjStateData> StateData => stateData_;

	public RepeatedField<LevelArchiveSceneObjEventData> EventData => eventData_;

	public LevelArchiveSceneObjData()
	{
	}

	public LevelArchiveSceneObjData(LevelArchiveSceneObjData other)
		: this()
	{
		stateData_ = other.stateData_.Clone();
		eventData_ = other.eventData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelArchiveSceneObjData Clone()
	{
		return new LevelArchiveSceneObjData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelArchiveSceneObjData);
	}

	public bool Equals(LevelArchiveSceneObjData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!stateData_.Equals(other.stateData_))
		{
			return false;
		}
		if (!eventData_.Equals(other.eventData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= stateData_.GetHashCode();
		num ^= eventData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		stateData_.WriteTo(output, _repeated_stateData_codec);
		eventData_.WriteTo(output, _repeated_eventData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += stateData_.CalculateSize(_repeated_stateData_codec);
		num += eventData_.CalculateSize(_repeated_eventData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelArchiveSceneObjData other)
	{
		if (other != null)
		{
			stateData_.Add(other.stateData_);
			eventData_.Add(other.eventData_);
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
				stateData_.AddEntriesFrom(input, _repeated_stateData_codec);
				break;
			case 18u:
				eventData_.AddEntriesFrom(input, _repeated_eventData_codec);
				break;
			}
		}
	}
}
