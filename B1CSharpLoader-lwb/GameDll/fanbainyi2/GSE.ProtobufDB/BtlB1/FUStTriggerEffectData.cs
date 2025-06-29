using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStTriggerEffectData : IMessage<FUStTriggerEffectData>, IMessage, IEquatable<FUStTriggerEffectData>, IDeepCloneable<FUStTriggerEffectData>
{
	private static readonly MessageParser<FUStTriggerEffectData> _parser = new MessageParser<FUStTriggerEffectData>(() => new FUStTriggerEffectData());

	private UnknownFieldSet _unknownFields;

	private int notifyStartTime_;

	private int effectID_;

	public static MessageParser<FUStTriggerEffectData> Parser => _parser;

	public int NotifyStartTime
	{
		get
		{
			return notifyStartTime_;
		}
		set
		{
			notifyStartTime_ = value;
		}
	}

	public int EffectID
	{
		get
		{
			return effectID_;
		}
		set
		{
			effectID_ = value;
		}
	}

	public FUStTriggerEffectData()
	{
	}

	public FUStTriggerEffectData(FUStTriggerEffectData other)
		: this()
	{
		notifyStartTime_ = other.notifyStartTime_;
		effectID_ = other.effectID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTriggerEffectData Clone()
	{
		return new FUStTriggerEffectData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTriggerEffectData);
	}

	public bool Equals(FUStTriggerEffectData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NotifyStartTime != other.NotifyStartTime)
		{
			return false;
		}
		if (EffectID != other.EffectID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (NotifyStartTime != 0)
		{
			num ^= NotifyStartTime.GetHashCode();
		}
		if (EffectID != 0)
		{
			num ^= EffectID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (NotifyStartTime != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(NotifyStartTime);
		}
		if (EffectID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EffectID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (NotifyStartTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NotifyStartTime);
		}
		if (EffectID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStTriggerEffectData other)
	{
		if (other != null)
		{
			if (other.NotifyStartTime != 0)
			{
				NotifyStartTime = other.NotifyStartTime;
			}
			if (other.EffectID != 0)
			{
				EffectID = other.EffectID;
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
				NotifyStartTime = input.ReadInt32();
				break;
			case 16u:
				EffectID = input.ReadInt32();
				break;
			}
		}
	}
}
