using System;
using Google.Protobuf;

namespace BtlU3;

public sealed class FUStB2DSkillStage : IMessage<FUStB2DSkillStage>, IMessage, IEquatable<FUStB2DSkillStage>, IDeepCloneable<FUStB2DSkillStage>
{
	private static readonly MessageParser<FUStB2DSkillStage> _parser = new MessageParser<FUStB2DSkillStage>(() => new FUStB2DSkillStage());

	private UnknownFieldSet _unknownFields;

	private int prepareTimeMs_;

	private int effectId_;

	private int totalTime_;

	public static MessageParser<FUStB2DSkillStage> Parser => _parser;

	public int PrepareTimeMs
	{
		get
		{
			return prepareTimeMs_;
		}
		set
		{
			prepareTimeMs_ = value;
		}
	}

	public int EffectId
	{
		get
		{
			return effectId_;
		}
		set
		{
			effectId_ = value;
		}
	}

	public int TotalTime
	{
		get
		{
			return totalTime_;
		}
		set
		{
			totalTime_ = value;
		}
	}

	public FUStB2DSkillStage()
	{
	}

	public FUStB2DSkillStage(FUStB2DSkillStage other)
		: this()
	{
		prepareTimeMs_ = other.prepareTimeMs_;
		effectId_ = other.effectId_;
		totalTime_ = other.totalTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSkillStage Clone()
	{
		return new FUStB2DSkillStage(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSkillStage);
	}

	public bool Equals(FUStB2DSkillStage other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PrepareTimeMs != other.PrepareTimeMs)
		{
			return false;
		}
		if (EffectId != other.EffectId)
		{
			return false;
		}
		if (TotalTime != other.TotalTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PrepareTimeMs != 0)
		{
			num ^= PrepareTimeMs.GetHashCode();
		}
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
		}
		if (TotalTime != 0)
		{
			num ^= TotalTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PrepareTimeMs != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PrepareTimeMs);
		}
		if (EffectId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EffectId);
		}
		if (TotalTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TotalTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PrepareTimeMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PrepareTimeMs);
		}
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectId);
		}
		if (TotalTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSkillStage other)
	{
		if (other != null)
		{
			if (other.PrepareTimeMs != 0)
			{
				PrepareTimeMs = other.PrepareTimeMs;
			}
			if (other.EffectId != 0)
			{
				EffectId = other.EffectId;
			}
			if (other.TotalTime != 0)
			{
				TotalTime = other.TotalTime;
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
				PrepareTimeMs = input.ReadInt32();
				break;
			case 16u:
				EffectId = input.ReadInt32();
				break;
			case 24u:
				TotalTime = input.ReadInt32();
				break;
			}
		}
	}
}
