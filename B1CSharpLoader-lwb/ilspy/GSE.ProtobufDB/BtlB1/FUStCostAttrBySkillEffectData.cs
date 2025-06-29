using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStCostAttrBySkillEffectData : IMessage<FUStCostAttrBySkillEffectData>, IMessage, IEquatable<FUStCostAttrBySkillEffectData>, IDeepCloneable<FUStCostAttrBySkillEffectData>
{
	private static readonly MessageParser<FUStCostAttrBySkillEffectData> _parser = new MessageParser<FUStCostAttrBySkillEffectData>(() => new FUStCostAttrBySkillEffectData());

	private UnknownFieldSet _unknownFields;

	private int notifyStartTime_;

	private int notifyDurationTime_;

	private int skillEffectID_;

	public static MessageParser<FUStCostAttrBySkillEffectData> Parser => _parser;

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

	public int SkillEffectID
	{
		get
		{
			return skillEffectID_;
		}
		set
		{
			skillEffectID_ = value;
		}
	}

	public FUStCostAttrBySkillEffectData()
	{
	}

	public FUStCostAttrBySkillEffectData(FUStCostAttrBySkillEffectData other)
		: this()
	{
		notifyStartTime_ = other.notifyStartTime_;
		notifyDurationTime_ = other.notifyDurationTime_;
		skillEffectID_ = other.skillEffectID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStCostAttrBySkillEffectData Clone()
	{
		return new FUStCostAttrBySkillEffectData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStCostAttrBySkillEffectData);
	}

	public bool Equals(FUStCostAttrBySkillEffectData other)
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
		if (SkillEffectID != other.SkillEffectID)
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
		if (SkillEffectID != 0)
		{
			num ^= SkillEffectID.GetHashCode();
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
		if (SkillEffectID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SkillEffectID);
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
		if (SkillEffectID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillEffectID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStCostAttrBySkillEffectData other)
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
			if (other.SkillEffectID != 0)
			{
				SkillEffectID = other.SkillEffectID;
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
				SkillEffectID = input.ReadInt32();
				break;
			}
		}
	}
}
