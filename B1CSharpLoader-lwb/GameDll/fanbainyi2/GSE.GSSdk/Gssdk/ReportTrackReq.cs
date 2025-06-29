using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportTrackReq : IMessage<ReportTrackReq>, IMessage, IEquatable<ReportTrackReq>, IDeepCloneable<ReportTrackReq>
{
	private static readonly MessageParser<ReportTrackReq> _parser = new MessageParser<ReportTrackReq>(() => new ReportTrackReq());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ReportTrack> _repeated_tracks_codec = FieldCodec.ForMessage(10u, ReportTrack.Parser);

	private readonly RepeatedField<ReportTrack> tracks_ = new RepeatedField<ReportTrack>();

	private uint time_;

	public static MessageParser<ReportTrackReq> Parser => _parser;

	public RepeatedField<ReportTrack> Tracks => tracks_;

	public uint Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	public ReportTrackReq()
	{
	}

	public ReportTrackReq(ReportTrackReq other)
		: this()
	{
		tracks_ = other.tracks_.Clone();
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportTrackReq Clone()
	{
		return new ReportTrackReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportTrackReq);
	}

	public bool Equals(ReportTrackReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!tracks_.Equals(other.tracks_))
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= tracks_.GetHashCode();
		if (Time != 0)
		{
			num ^= Time.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		tracks_.WriteTo(output, _repeated_tracks_codec);
		if (Time != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Time);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += tracks_.CalculateSize(_repeated_tracks_codec);
		if (Time != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Time);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportTrackReq other)
	{
		if (other != null)
		{
			tracks_.Add(other.tracks_);
			if (other.Time != 0)
			{
				Time = other.Time;
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
			case 10u:
				tracks_.AddEntriesFrom(input, _repeated_tracks_codec);
				break;
			case 16u:
				Time = input.ReadUInt32();
				break;
			}
		}
	}
}
