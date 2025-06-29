using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_RemoveBuff : IMessage<BehaviorCustom_RemoveBuff>, IMessage, IEquatable<BehaviorCustom_RemoveBuff>, IDeepCloneable<BehaviorCustom_RemoveBuff>
{
	private static readonly MessageParser<BehaviorCustom_RemoveBuff> _parser = new MessageParser<BehaviorCustom_RemoveBuff>(() => new BehaviorCustom_RemoveBuff());

	private UnknownFieldSet _unknownFields;

	private int buffId_;

	private int buffLayer_;

	private bool isTriggerRemoveEffect_;

	public static MessageParser<BehaviorCustom_RemoveBuff> Parser => _parser;

	public int BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	public int BuffLayer
	{
		get
		{
			return buffLayer_;
		}
		set
		{
			buffLayer_ = value;
		}
	}

	public bool IsTriggerRemoveEffect
	{
		get
		{
			return isTriggerRemoveEffect_;
		}
		set
		{
			isTriggerRemoveEffect_ = value;
		}
	}

	public BehaviorCustom_RemoveBuff()
	{
	}

	public BehaviorCustom_RemoveBuff(BehaviorCustom_RemoveBuff other)
		: this()
	{
		buffId_ = other.buffId_;
		buffLayer_ = other.buffLayer_;
		isTriggerRemoveEffect_ = other.isTriggerRemoveEffect_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_RemoveBuff Clone()
	{
		return new BehaviorCustom_RemoveBuff(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_RemoveBuff);
	}

	public bool Equals(BehaviorCustom_RemoveBuff other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (BuffLayer != other.BuffLayer)
		{
			return false;
		}
		if (IsTriggerRemoveEffect != other.IsTriggerRemoveEffect)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (BuffLayer != 0)
		{
			num ^= BuffLayer.GetHashCode();
		}
		if (IsTriggerRemoveEffect)
		{
			num ^= IsTriggerRemoveEffect.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BuffId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuffId);
		}
		if (BuffLayer != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffLayer);
		}
		if (IsTriggerRemoveEffect)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsTriggerRemoveEffect);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (BuffLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffLayer);
		}
		if (IsTriggerRemoveEffect)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_RemoveBuff other)
	{
		if (other != null)
		{
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.BuffLayer != 0)
			{
				BuffLayer = other.BuffLayer;
			}
			if (other.IsTriggerRemoveEffect)
			{
				IsTriggerRemoveEffect = other.IsTriggerRemoveEffect;
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
				BuffId = input.ReadInt32();
				break;
			case 16u:
				BuffLayer = input.ReadInt32();
				break;
			case 24u:
				IsTriggerRemoveEffect = input.ReadBool();
				break;
			}
		}
	}
}
