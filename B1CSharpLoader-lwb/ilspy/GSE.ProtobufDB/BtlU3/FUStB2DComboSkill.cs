using System;
using Google.Protobuf;

namespace BtlU3;

public sealed class FUStB2DComboSkill : IMessage<FUStB2DComboSkill>, IMessage, IEquatable<FUStB2DComboSkill>, IDeepCloneable<FUStB2DComboSkill>
{
	private static readonly MessageParser<FUStB2DComboSkill> _parser = new MessageParser<FUStB2DComboSkill>(() => new FUStB2DComboSkill());

	private UnknownFieldSet _unknownFields;

	private int comboId_;

	private int triggerWindowBegin_;

	private int triggerWindowEnd_;

	private int effectWindowBegin_;

	private int effectWindowEnd_;

	public static MessageParser<FUStB2DComboSkill> Parser => _parser;

	public int ComboId
	{
		get
		{
			return comboId_;
		}
		set
		{
			comboId_ = value;
		}
	}

	public int TriggerWindowBegin
	{
		get
		{
			return triggerWindowBegin_;
		}
		set
		{
			triggerWindowBegin_ = value;
		}
	}

	public int TriggerWindowEnd
	{
		get
		{
			return triggerWindowEnd_;
		}
		set
		{
			triggerWindowEnd_ = value;
		}
	}

	public int EffectWindowBegin
	{
		get
		{
			return effectWindowBegin_;
		}
		set
		{
			effectWindowBegin_ = value;
		}
	}

	public int EffectWindowEnd
	{
		get
		{
			return effectWindowEnd_;
		}
		set
		{
			effectWindowEnd_ = value;
		}
	}

	public FUStB2DComboSkill()
	{
	}

	public FUStB2DComboSkill(FUStB2DComboSkill other)
		: this()
	{
		comboId_ = other.comboId_;
		triggerWindowBegin_ = other.triggerWindowBegin_;
		triggerWindowEnd_ = other.triggerWindowEnd_;
		effectWindowBegin_ = other.effectWindowBegin_;
		effectWindowEnd_ = other.effectWindowEnd_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DComboSkill Clone()
	{
		return new FUStB2DComboSkill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DComboSkill);
	}

	public bool Equals(FUStB2DComboSkill other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ComboId != other.ComboId)
		{
			return false;
		}
		if (TriggerWindowBegin != other.TriggerWindowBegin)
		{
			return false;
		}
		if (TriggerWindowEnd != other.TriggerWindowEnd)
		{
			return false;
		}
		if (EffectWindowBegin != other.EffectWindowBegin)
		{
			return false;
		}
		if (EffectWindowEnd != other.EffectWindowEnd)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ComboId != 0)
		{
			num ^= ComboId.GetHashCode();
		}
		if (TriggerWindowBegin != 0)
		{
			num ^= TriggerWindowBegin.GetHashCode();
		}
		if (TriggerWindowEnd != 0)
		{
			num ^= TriggerWindowEnd.GetHashCode();
		}
		if (EffectWindowBegin != 0)
		{
			num ^= EffectWindowBegin.GetHashCode();
		}
		if (EffectWindowEnd != 0)
		{
			num ^= EffectWindowEnd.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ComboId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ComboId);
		}
		if (TriggerWindowBegin != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TriggerWindowBegin);
		}
		if (TriggerWindowEnd != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TriggerWindowEnd);
		}
		if (EffectWindowBegin != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EffectWindowBegin);
		}
		if (EffectWindowEnd != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EffectWindowEnd);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ComboId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ComboId);
		}
		if (TriggerWindowBegin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TriggerWindowBegin);
		}
		if (TriggerWindowEnd != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TriggerWindowEnd);
		}
		if (EffectWindowBegin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectWindowBegin);
		}
		if (EffectWindowEnd != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectWindowEnd);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DComboSkill other)
	{
		if (other != null)
		{
			if (other.ComboId != 0)
			{
				ComboId = other.ComboId;
			}
			if (other.TriggerWindowBegin != 0)
			{
				TriggerWindowBegin = other.TriggerWindowBegin;
			}
			if (other.TriggerWindowEnd != 0)
			{
				TriggerWindowEnd = other.TriggerWindowEnd;
			}
			if (other.EffectWindowBegin != 0)
			{
				EffectWindowBegin = other.EffectWindowBegin;
			}
			if (other.EffectWindowEnd != 0)
			{
				EffectWindowEnd = other.EffectWindowEnd;
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
				ComboId = input.ReadInt32();
				break;
			case 16u:
				TriggerWindowBegin = input.ReadInt32();
				break;
			case 24u:
				TriggerWindowEnd = input.ReadInt32();
				break;
			case 32u:
				EffectWindowBegin = input.ReadInt32();
				break;
			case 40u:
				EffectWindowEnd = input.ReadInt32();
				break;
			}
		}
	}
}
