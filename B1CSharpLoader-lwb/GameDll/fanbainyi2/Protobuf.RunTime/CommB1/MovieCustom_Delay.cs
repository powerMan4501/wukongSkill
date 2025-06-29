using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_Delay : IMessage<MovieCustom_Delay>, IMessage, IEquatable<MovieCustom_Delay>, IDeepCloneable<MovieCustom_Delay>
{
	private static readonly MessageParser<MovieCustom_Delay> _parser = new MessageParser<MovieCustom_Delay>(() => new MovieCustom_Delay());

	private UnknownFieldSet _unknownFields;

	private float delayTime_;

	private string timeDilationCurve_ = "";

	public static MessageParser<MovieCustom_Delay> Parser => _parser;

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

	public MovieCustom_Delay()
	{
	}

	public MovieCustom_Delay(MovieCustom_Delay other)
		: this()
	{
		delayTime_ = other.delayTime_;
		timeDilationCurve_ = other.timeDilationCurve_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_Delay Clone()
	{
		return new MovieCustom_Delay(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_Delay);
	}

	public bool Equals(MovieCustom_Delay other)
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_Delay other)
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
			}
		}
	}
}
