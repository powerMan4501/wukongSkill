using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStDelayTriggerEffects : IMessage<FUStDelayTriggerEffects>, IMessage, IEquatable<FUStDelayTriggerEffects>, IDeepCloneable<FUStDelayTriggerEffects>
{
	private static readonly MessageParser<FUStDelayTriggerEffects> _parser = new MessageParser<FUStDelayTriggerEffects>(() => new FUStDelayTriggerEffects());

	private UnknownFieldSet _unknownFields;

	private float delayTime_;

	private static readonly FieldCodec<int> _repeated_effectIDs_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> effectIDs_ = new RepeatedField<int>();

	public static MessageParser<FUStDelayTriggerEffects> Parser => _parser;

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

	public RepeatedField<int> EffectIDs => effectIDs_;

	public FUStDelayTriggerEffects()
	{
	}

	public FUStDelayTriggerEffects(FUStDelayTriggerEffects other)
		: this()
	{
		delayTime_ = other.delayTime_;
		effectIDs_ = other.effectIDs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDelayTriggerEffects Clone()
	{
		return new FUStDelayTriggerEffects(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDelayTriggerEffects);
	}

	public bool Equals(FUStDelayTriggerEffects other)
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
		if (!effectIDs_.Equals(other.effectIDs_))
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
		num ^= effectIDs_.GetHashCode();
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
		effectIDs_.WriteTo(output, _repeated_effectIDs_codec);
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
		num += effectIDs_.CalculateSize(_repeated_effectIDs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDelayTriggerEffects other)
	{
		if (other != null)
		{
			if (other.DelayTime != 0f)
			{
				DelayTime = other.DelayTime;
			}
			effectIDs_.Add(other.effectIDs_);
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
			case 16u:
			case 18u:
				effectIDs_.AddEntriesFrom(input, _repeated_effectIDs_codec);
				break;
			}
		}
	}
}
