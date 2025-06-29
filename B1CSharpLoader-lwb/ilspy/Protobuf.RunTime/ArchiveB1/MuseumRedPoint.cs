using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class MuseumRedPoint : IMessage<MuseumRedPoint>, IMessage, IEquatable<MuseumRedPoint>, IDeepCloneable<MuseumRedPoint>
{
	private static readonly MessageParser<MuseumRedPoint> _parser = new MessageParser<MuseumRedPoint>(() => new MuseumRedPoint());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<int> _repeated_mvRedpoint_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> mvRedpoint_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_soundtrackRedpointList_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> soundtrackRedpointList_ = new RepeatedField<int>();

	public static MessageParser<MuseumRedPoint> Parser => _parser;

	public RepeatedField<int> MvRedpoint => mvRedpoint_;

	public RepeatedField<int> SoundtrackRedpointList => soundtrackRedpointList_;

	public MuseumRedPoint()
	{
	}

	public MuseumRedPoint(MuseumRedPoint other)
		: this()
	{
		mvRedpoint_ = other.mvRedpoint_.Clone();
		soundtrackRedpointList_ = other.soundtrackRedpointList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MuseumRedPoint Clone()
	{
		return new MuseumRedPoint(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MuseumRedPoint);
	}

	public bool Equals(MuseumRedPoint other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mvRedpoint_.Equals(other.mvRedpoint_))
		{
			return false;
		}
		if (!soundtrackRedpointList_.Equals(other.soundtrackRedpointList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= mvRedpoint_.GetHashCode();
		num ^= soundtrackRedpointList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		mvRedpoint_.WriteTo(output, _repeated_mvRedpoint_codec);
		soundtrackRedpointList_.WriteTo(output, _repeated_soundtrackRedpointList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += mvRedpoint_.CalculateSize(_repeated_mvRedpoint_codec);
		num += soundtrackRedpointList_.CalculateSize(_repeated_soundtrackRedpointList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MuseumRedPoint other)
	{
		if (other != null)
		{
			mvRedpoint_.Add(other.mvRedpoint_);
			soundtrackRedpointList_.Add(other.soundtrackRedpointList_);
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
			case 40u:
			case 42u:
				mvRedpoint_.AddEntriesFrom(input, _repeated_mvRedpoint_codec);
				break;
			case 48u:
			case 50u:
				soundtrackRedpointList_.AddEntriesFrom(input, _repeated_soundtrackRedpointList_codec);
				break;
			}
		}
	}
}
