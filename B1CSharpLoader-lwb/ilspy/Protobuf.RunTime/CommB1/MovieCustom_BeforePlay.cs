using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_BeforePlay : IMessage<MovieCustom_BeforePlay>, IMessage, IEquatable<MovieCustom_BeforePlay>, IDeepCloneable<MovieCustom_BeforePlay>
{
	private static readonly MessageParser<MovieCustom_BeforePlay> _parser = new MessageParser<MovieCustom_BeforePlay>(() => new MovieCustom_BeforePlay());

	private UnknownFieldSet _unknownFields;

	private float delayTime_;

	private string timeDilationCurve_ = "";

	private bool useAsyncTransback_;

	public static MessageParser<MovieCustom_BeforePlay> Parser => _parser;

	public float DelayTime
	{
		get
		{
			return delayTime_;
		}
		set
		{
			delayTime_ = value;
		}
	}

	public string TimeDilationCurve
	{
		get
		{
			return timeDilationCurve_;
		}
		set
		{
			timeDilationCurve_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool UseAsyncTransback
	{
		get
		{
			return useAsyncTransback_;
		}
		set
		{
			useAsyncTransback_ = value;
		}
	}

	public MovieCustom_BeforePlay()
	{
	}

	public MovieCustom_BeforePlay(MovieCustom_BeforePlay other)
		: this()
	{
		delayTime_ = other.delayTime_;
		timeDilationCurve_ = other.timeDilationCurve_;
		useAsyncTransback_ = other.useAsyncTransback_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_BeforePlay Clone()
	{
		return new MovieCustom_BeforePlay(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_BeforePlay);
	}

	public bool Equals(MovieCustom_BeforePlay other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DelayTime, other.DelayTime))
		{
			return false;
		}
		if (TimeDilationCurve != other.TimeDilationCurve)
		{
			return false;
		}
		if (UseAsyncTransback != other.UseAsyncTransback)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DelayTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DelayTime);
		}
		if (TimeDilationCurve.Length != 0)
		{
			num ^= TimeDilationCurve.GetHashCode();
		}
		if (UseAsyncTransback)
		{
			num ^= UseAsyncTransback.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DelayTime != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(DelayTime);
		}
		if (TimeDilationCurve.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(TimeDilationCurve);
		}
		if (UseAsyncTransback)
		{
			output.WriteRawTag(24);
			output.WriteBool(UseAsyncTransback);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DelayTime != 0f)
		{
			num += 5;
		}
		if (TimeDilationCurve.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TimeDilationCurve);
		}
		if (UseAsyncTransback)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_BeforePlay other)
	{
		if (other != null)
		{
			if (other.DelayTime != 0f)
			{
				DelayTime = other.DelayTime;
			}
			if (other.TimeDilationCurve.Length != 0)
			{
				TimeDilationCurve = other.TimeDilationCurve;
			}
			if (other.UseAsyncTransback)
			{
				UseAsyncTransback = other.UseAsyncTransback;
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
			case 13u:
				DelayTime = input.ReadFloat();
				break;
			case 18u:
				TimeDilationCurve = input.ReadString();
				break;
			case 24u:
				UseAsyncTransback = input.ReadBool();
				break;
			}
		}
	}
}
