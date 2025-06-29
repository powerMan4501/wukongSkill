using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_LevelStream : IMessage<QuestCustom_LevelStream>, IMessage, IEquatable<QuestCustom_LevelStream>, IDeepCloneable<QuestCustom_LevelStream>
{
	private static readonly MessageParser<QuestCustom_LevelStream> _parser = new MessageParser<QuestCustom_LevelStream>(() => new QuestCustom_LevelStream());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<string> _repeated_loadStreamingVolumes_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> loadStreamingVolumes_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_unloadStreamingVolumes_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> unloadStreamingVolumes_ = new RepeatedField<string>();

	public static MessageParser<QuestCustom_LevelStream> Parser => _parser;

	public RepeatedField<string> LoadStreamingVolumes => loadStreamingVolumes_;

	public RepeatedField<string> UnloadStreamingVolumes => unloadStreamingVolumes_;

	public QuestCustom_LevelStream()
	{
	}

	public QuestCustom_LevelStream(QuestCustom_LevelStream other)
		: this()
	{
		loadStreamingVolumes_ = other.loadStreamingVolumes_.Clone();
		unloadStreamingVolumes_ = other.unloadStreamingVolumes_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_LevelStream Clone()
	{
		return new QuestCustom_LevelStream(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_LevelStream);
	}

	public bool Equals(QuestCustom_LevelStream other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!loadStreamingVolumes_.Equals(other.loadStreamingVolumes_))
		{
			return false;
		}
		if (!unloadStreamingVolumes_.Equals(other.unloadStreamingVolumes_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= loadStreamingVolumes_.GetHashCode();
		num ^= unloadStreamingVolumes_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		loadStreamingVolumes_.WriteTo(output, _repeated_loadStreamingVolumes_codec);
		unloadStreamingVolumes_.WriteTo(output, _repeated_unloadStreamingVolumes_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += loadStreamingVolumes_.CalculateSize(_repeated_loadStreamingVolumes_codec);
		num += unloadStreamingVolumes_.CalculateSize(_repeated_unloadStreamingVolumes_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_LevelStream other)
	{
		if (other != null)
		{
			loadStreamingVolumes_.Add(other.loadStreamingVolumes_);
			unloadStreamingVolumes_.Add(other.unloadStreamingVolumes_);
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
				loadStreamingVolumes_.AddEntriesFrom(input, _repeated_loadStreamingVolumes_codec);
				break;
			case 18u:
				unloadStreamingVolumes_.AddEntriesFrom(input, _repeated_unloadStreamingVolumes_codec);
				break;
			}
		}
	}
}
