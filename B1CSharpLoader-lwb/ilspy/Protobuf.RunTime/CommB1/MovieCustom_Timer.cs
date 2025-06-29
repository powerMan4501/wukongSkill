using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_Timer : IMessage<MovieCustom_Timer>, IMessage, IEquatable<MovieCustom_Timer>, IDeepCloneable<MovieCustom_Timer>
{
	private static readonly MessageParser<MovieCustom_Timer> _parser = new MessageParser<MovieCustom_Timer>(() => new MovieCustom_Timer());

	private UnknownFieldSet _unknownFields;

	private float completionTime_;

	private float stepTime_;

	public static MessageParser<MovieCustom_Timer> Parser => _parser;

	public float CompletionTime
	{
		get
		{
			return completionTime_;
		}
		set
		{
			completionTime_ = value;
		}
	}

	public float StepTime
	{
		get
		{
			return stepTime_;
		}
		set
		{
			stepTime_ = value;
		}
	}

	public MovieCustom_Timer()
	{
	}

	public MovieCustom_Timer(MovieCustom_Timer other)
		: this()
	{
		completionTime_ = other.completionTime_;
		stepTime_ = other.stepTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_Timer Clone()
	{
		return new MovieCustom_Timer(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_Timer);
	}

	public bool Equals(MovieCustom_Timer other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CompletionTime, other.CompletionTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StepTime, other.StepTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CompletionTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CompletionTime);
		}
		if (StepTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StepTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CompletionTime != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(CompletionTime);
		}
		if (StepTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(StepTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CompletionTime != 0f)
		{
			num += 5;
		}
		if (StepTime != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_Timer other)
	{
		if (other != null)
		{
			if (other.CompletionTime != 0f)
			{
				CompletionTime = other.CompletionTime;
			}
			if (other.StepTime != 0f)
			{
				StepTime = other.StepTime;
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
				CompletionTime = input.ReadFloat();
				break;
			case 21u:
				StepTime = input.ReadFloat();
				break;
			}
		}
	}
}
