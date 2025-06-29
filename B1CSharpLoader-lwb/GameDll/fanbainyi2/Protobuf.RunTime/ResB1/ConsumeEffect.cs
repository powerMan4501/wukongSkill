using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ConsumeEffect : IMessage<ConsumeEffect>, IMessage, IEquatable<ConsumeEffect>, IDeepCloneable<ConsumeEffect>
{
	private static readonly MessageParser<ConsumeEffect> _parser = new MessageParser<ConsumeEffect>(() => new ConsumeEffect());

	private UnknownFieldSet _unknownFields;

	private ConsumeEffectType effectType_;

	private int effectId_;

	public static MessageParser<ConsumeEffect> Parser => _parser;

	public ConsumeEffectType EffectType
	{
		get
		{
			return effectType_;
		}
		set
		{
			effectType_ = value;
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

	public ConsumeEffect()
	{
	}

	public ConsumeEffect(ConsumeEffect other)
		: this()
	{
		effectType_ = other.effectType_;
		effectId_ = other.effectId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ConsumeEffect Clone()
	{
		return new ConsumeEffect(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ConsumeEffect);
	}

	public bool Equals(ConsumeEffect other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EffectType != other.EffectType)
		{
			return false;
		}
		if (EffectId != other.EffectId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EffectType != ConsumeEffectType.Buff)
		{
			num ^= EffectType.GetHashCode();
		}
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EffectType != ConsumeEffectType.Buff)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EffectType);
		}
		if (EffectId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EffectId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EffectType != ConsumeEffectType.Buff)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectType);
		}
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ConsumeEffect other)
	{
		if (other != null)
		{
			if (other.EffectType != ConsumeEffectType.Buff)
			{
				EffectType = other.EffectType;
			}
			if (other.EffectId != 0)
			{
				EffectId = other.EffectId;
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
				EffectType = (ConsumeEffectType)input.ReadEnum();
				break;
			case 16u:
				EffectId = input.ReadInt32();
				break;
			}
		}
	}
}
