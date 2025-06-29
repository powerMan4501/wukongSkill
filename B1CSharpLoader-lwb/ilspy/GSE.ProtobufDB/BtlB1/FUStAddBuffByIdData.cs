using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStAddBuffByIdData : IMessage<FUStAddBuffByIdData>, IMessage, IEquatable<FUStAddBuffByIdData>, IDeepCloneable<FUStAddBuffByIdData>
{
	private static readonly MessageParser<FUStAddBuffByIdData> _parser = new MessageParser<FUStAddBuffByIdData>(() => new FUStAddBuffByIdData());

	private UnknownFieldSet _unknownFields;

	private int notifyStartTime_;

	private int notifyDurationTime_;

	private int buffID_;

	private int buffLayer_;

	private bool useBuffDescDuration_;

	public static MessageParser<FUStAddBuffByIdData> Parser => _parser;

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

	public int NotifyDurationTime
	{
		get
		{
			return notifyDurationTime_;
		}
		set
		{
			notifyDurationTime_ = value;
		}
	}

	public int BuffID
	{
		get
		{
			return buffID_;
		}
		set
		{
			buffID_ = value;
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

	public bool UseBuffDescDuration
	{
		get
		{
			return useBuffDescDuration_;
		}
		set
		{
			useBuffDescDuration_ = value;
		}
	}

	public FUStAddBuffByIdData()
	{
	}

	public FUStAddBuffByIdData(FUStAddBuffByIdData other)
		: this()
	{
		notifyStartTime_ = other.notifyStartTime_;
		notifyDurationTime_ = other.notifyDurationTime_;
		buffID_ = other.buffID_;
		buffLayer_ = other.buffLayer_;
		useBuffDescDuration_ = other.useBuffDescDuration_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAddBuffByIdData Clone()
	{
		return new FUStAddBuffByIdData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAddBuffByIdData);
	}

	public bool Equals(FUStAddBuffByIdData other)
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
		if (NotifyDurationTime != other.NotifyDurationTime)
		{
			return false;
		}
		if (BuffID != other.BuffID)
		{
			return false;
		}
		if (BuffLayer != other.BuffLayer)
		{
			return false;
		}
		if (UseBuffDescDuration != other.UseBuffDescDuration)
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
		if (NotifyDurationTime != 0)
		{
			num ^= NotifyDurationTime.GetHashCode();
		}
		if (BuffID != 0)
		{
			num ^= BuffID.GetHashCode();
		}
		if (BuffLayer != 0)
		{
			num ^= BuffLayer.GetHashCode();
		}
		if (UseBuffDescDuration)
		{
			num ^= UseBuffDescDuration.GetHashCode();
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
		if (NotifyDurationTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(NotifyDurationTime);
		}
		if (BuffID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuffID);
		}
		if (BuffLayer != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BuffLayer);
		}
		if (UseBuffDescDuration)
		{
			output.WriteRawTag(40);
			output.WriteBool(UseBuffDescDuration);
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
		if (NotifyDurationTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NotifyDurationTime);
		}
		if (BuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffID);
		}
		if (BuffLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffLayer);
		}
		if (UseBuffDescDuration)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAddBuffByIdData other)
	{
		if (other != null)
		{
			if (other.NotifyStartTime != 0)
			{
				NotifyStartTime = other.NotifyStartTime;
			}
			if (other.NotifyDurationTime != 0)
			{
				NotifyDurationTime = other.NotifyDurationTime;
			}
			if (other.BuffID != 0)
			{
				BuffID = other.BuffID;
			}
			if (other.BuffLayer != 0)
			{
				BuffLayer = other.BuffLayer;
			}
			if (other.UseBuffDescDuration)
			{
				UseBuffDescDuration = other.UseBuffDescDuration;
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
				NotifyDurationTime = input.ReadInt32();
				break;
			case 24u:
				BuffID = input.ReadInt32();
				break;
			case 32u:
				BuffLayer = input.ReadInt32();
				break;
			case 40u:
				UseBuffDescDuration = input.ReadBool();
				break;
			}
		}
	}
}
