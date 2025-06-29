using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_AddBuff : IMessage<BehaviorCustom_AddBuff>, IMessage, IEquatable<BehaviorCustom_AddBuff>, IDeepCloneable<BehaviorCustom_AddBuff>
{
	private static readonly MessageParser<BehaviorCustom_AddBuff> _parser = new MessageParser<BehaviorCustom_AddBuff>(() => new BehaviorCustom_AddBuff());

	private UnknownFieldSet _unknownFields;

	private int buffId_;

	private int buffLayer_;

	private int buffDuration_;

	public static MessageParser<BehaviorCustom_AddBuff> Parser => _parser;

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

	public BehaviorCustom_AddBuff()
	{
	}

	public BehaviorCustom_AddBuff(BehaviorCustom_AddBuff other)
		: this()
	{
		buffId_ = other.buffId_;
		buffLayer_ = other.buffLayer_;
		buffDuration_ = other.buffDuration_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_AddBuff Clone()
	{
		return new BehaviorCustom_AddBuff(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_AddBuff);
	}

	public bool Equals(BehaviorCustom_AddBuff other)
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
		if (BuffDuration != other.BuffDuration)
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
		if (BuffDuration != 0)
		{
			num ^= BuffDuration.GetHashCode();
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
		if (BuffDuration != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuffDuration);
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
		if (BuffDuration != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffDuration);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_AddBuff other)
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
			if (other.BuffDuration != 0)
			{
				BuffDuration = other.BuffDuration;
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
				BuffDuration = input.ReadInt32();
				break;
			}
		}
	}
}
