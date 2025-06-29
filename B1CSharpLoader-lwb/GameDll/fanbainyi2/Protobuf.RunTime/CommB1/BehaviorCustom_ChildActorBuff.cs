using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_ChildActorBuff : IMessage<BehaviorCustom_ChildActorBuff>, IMessage, IEquatable<BehaviorCustom_ChildActorBuff>, IDeepCloneable<BehaviorCustom_ChildActorBuff>
{
	private static readonly MessageParser<BehaviorCustom_ChildActorBuff> _parser = new MessageParser<BehaviorCustom_ChildActorBuff>(() => new BehaviorCustom_ChildActorBuff());

	private UnknownFieldSet _unknownFields;

	private int buffId_;

	private int buffLayer_;

	private bool isAddBuff_;

	private int buffDuration_;

	private bool triggerRemoveEffect_;

	private ByteString matchInfo_ = ByteString.Empty;

	public static MessageParser<BehaviorCustom_ChildActorBuff> Parser => _parser;

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

	public bool IsAddBuff
	{
		get
		{
			return isAddBuff_;
		}
		set
		{
			isAddBuff_ = value;
		}
	}

	public int BuffDuration
	{
		get
		{
			return buffDuration_;
		}
		set
		{
			buffDuration_ = value;
		}
	}

	public bool TriggerRemoveEffect
	{
		get
		{
			return triggerRemoveEffect_;
		}
		set
		{
			triggerRemoveEffect_ = value;
		}
	}

	public ByteString MatchInfo
	{
		get
		{
			return matchInfo_;
		}
		set
		{
			matchInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_ChildActorBuff()
	{
	}

	public BehaviorCustom_ChildActorBuff(BehaviorCustom_ChildActorBuff other)
		: this()
	{
		buffId_ = other.buffId_;
		buffLayer_ = other.buffLayer_;
		isAddBuff_ = other.isAddBuff_;
		buffDuration_ = other.buffDuration_;
		triggerRemoveEffect_ = other.triggerRemoveEffect_;
		matchInfo_ = other.matchInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_ChildActorBuff Clone()
	{
		return new BehaviorCustom_ChildActorBuff(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_ChildActorBuff);
	}

	public bool Equals(BehaviorCustom_ChildActorBuff other)
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
		if (IsAddBuff != other.IsAddBuff)
		{
			return false;
		}
		if (BuffDuration != other.BuffDuration)
		{
			return false;
		}
		if (TriggerRemoveEffect != other.TriggerRemoveEffect)
		{
			return false;
		}
		if (MatchInfo != other.MatchInfo)
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
		if (IsAddBuff)
		{
			num ^= IsAddBuff.GetHashCode();
		}
		if (BuffDuration != 0)
		{
			num ^= BuffDuration.GetHashCode();
		}
		if (TriggerRemoveEffect)
		{
			num ^= TriggerRemoveEffect.GetHashCode();
		}
		if (MatchInfo.Length != 0)
		{
			num ^= MatchInfo.GetHashCode();
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
		if (IsAddBuff)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsAddBuff);
		}
		if (BuffDuration != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BuffDuration);
		}
		if (TriggerRemoveEffect)
		{
			output.WriteRawTag(40);
			output.WriteBool(TriggerRemoveEffect);
		}
		if (MatchInfo.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteBytes(MatchInfo);
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
		if (IsAddBuff)
		{
			num += 2;
		}
		if (BuffDuration != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffDuration);
		}
		if (TriggerRemoveEffect)
		{
			num += 2;
		}
		if (MatchInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(MatchInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_ChildActorBuff other)
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
			if (other.IsAddBuff)
			{
				IsAddBuff = other.IsAddBuff;
			}
			if (other.BuffDuration != 0)
			{
				BuffDuration = other.BuffDuration;
			}
			if (other.TriggerRemoveEffect)
			{
				TriggerRemoveEffect = other.TriggerRemoveEffect;
			}
			if (other.MatchInfo.Length != 0)
			{
				MatchInfo = other.MatchInfo;
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
				IsAddBuff = input.ReadBool();
				break;
			case 32u:
				BuffDuration = input.ReadInt32();
				break;
			case 40u:
				TriggerRemoveEffect = input.ReadBool();
				break;
			case 50u:
				MatchInfo = input.ReadBytes();
				break;
			}
		}
	}
}
