using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class FUStB2DSkillShakeData : IMessage<FUStB2DSkillShakeData>, IMessage, IEquatable<FUStB2DSkillShakeData>, IDeepCloneable<FUStB2DSkillShakeData>
{
	private static readonly MessageParser<FUStB2DSkillShakeData> _parser = new MessageParser<FUStB2DSkillShakeData>(() => new FUStB2DSkillShakeData());

	private UnknownFieldSet _unknownFields;

	private int period_;

	private int amplitude_;

	private int scaleAmplitude_;

	private int duration_;

	public static MessageParser<FUStB2DSkillShakeData> Parser => _parser;

	public int Period
	{
		get
		{
			return period_;
		}
		set
		{
			period_ = value;
		}
	}

	public int Amplitude
	{
		get
		{
			return amplitude_;
		}
		set
		{
			amplitude_ = value;
		}
	}

	public int ScaleAmplitude
	{
		get
		{
			return scaleAmplitude_;
		}
		set
		{
			scaleAmplitude_ = value;
		}
	}

	public int Duration
	{
		get
		{
			return duration_;
		}
		set
		{
			duration_ = value;
		}
	}

	public FUStB2DSkillShakeData()
	{
	}

	public FUStB2DSkillShakeData(FUStB2DSkillShakeData other)
		: this()
	{
		period_ = other.period_;
		amplitude_ = other.amplitude_;
		scaleAmplitude_ = other.scaleAmplitude_;
		duration_ = other.duration_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSkillShakeData Clone()
	{
		return new FUStB2DSkillShakeData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSkillShakeData);
	}

	public bool Equals(FUStB2DSkillShakeData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Period != other.Period)
		{
			return false;
		}
		if (Amplitude != other.Amplitude)
		{
			return false;
		}
		if (ScaleAmplitude != other.ScaleAmplitude)
		{
			return false;
		}
		if (Duration != other.Duration)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Period != 0)
		{
			num ^= Period.GetHashCode();
		}
		if (Amplitude != 0)
		{
			num ^= Amplitude.GetHashCode();
		}
		if (ScaleAmplitude != 0)
		{
			num ^= ScaleAmplitude.GetHashCode();
		}
		if (Duration != 0)
		{
			num ^= Duration.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Period != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Period);
		}
		if (Amplitude != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Amplitude);
		}
		if (ScaleAmplitude != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ScaleAmplitude);
		}
		if (Duration != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Duration);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Period != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Period);
		}
		if (Amplitude != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Amplitude);
		}
		if (ScaleAmplitude != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScaleAmplitude);
		}
		if (Duration != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Duration);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSkillShakeData other)
	{
		if (other != null)
		{
			if (other.Period != 0)
			{
				Period = other.Period;
			}
			if (other.Amplitude != 0)
			{
				Amplitude = other.Amplitude;
			}
			if (other.ScaleAmplitude != 0)
			{
				ScaleAmplitude = other.ScaleAmplitude;
			}
			if (other.Duration != 0)
			{
				Duration = other.Duration;
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
			case 8u:
				Period = input.ReadInt32();
				break;
			case 16u:
				Amplitude = input.ReadInt32();
				break;
			case 24u:
				ScaleAmplitude = input.ReadInt32();
				break;
			case 32u:
				Duration = input.ReadInt32();
				break;
			}
		}
	}
}
