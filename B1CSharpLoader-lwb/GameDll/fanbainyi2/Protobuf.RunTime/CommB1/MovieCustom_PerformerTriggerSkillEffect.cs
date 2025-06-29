using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_PerformerTriggerSkillEffect : IMessage<MovieCustom_PerformerTriggerSkillEffect>, IMessage, IEquatable<MovieCustom_PerformerTriggerSkillEffect>, IDeepCloneable<MovieCustom_PerformerTriggerSkillEffect>
{
	private static readonly MessageParser<MovieCustom_PerformerTriggerSkillEffect> _parser = new MessageParser<MovieCustom_PerformerTriggerSkillEffect>(() => new MovieCustom_PerformerTriggerSkillEffect());

	private UnknownFieldSet _unknownFields;

	private string performerGuid_ = "";

	private int skillEffectId_;

	public static MessageParser<MovieCustom_PerformerTriggerSkillEffect> Parser => _parser;

	public string PerformerGuid
	{
		get
		{
			return performerGuid_;
		}
		set
		{
			performerGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SkillEffectId
	{
		get
		{
			return skillEffectId_;
		}
		set
		{
			skillEffectId_ = value;
		}
	}

	public MovieCustom_PerformerTriggerSkillEffect()
	{
	}

	public MovieCustom_PerformerTriggerSkillEffect(MovieCustom_PerformerTriggerSkillEffect other)
		: this()
	{
		performerGuid_ = other.performerGuid_;
		skillEffectId_ = other.skillEffectId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PerformerTriggerSkillEffect Clone()
	{
		return new MovieCustom_PerformerTriggerSkillEffect(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PerformerTriggerSkillEffect);
	}

	public bool Equals(MovieCustom_PerformerTriggerSkillEffect other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformerGuid != other.PerformerGuid)
		{
			return false;
		}
		if (SkillEffectId != other.SkillEffectId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PerformerGuid.Length != 0)
		{
			num ^= PerformerGuid.GetHashCode();
		}
		if (SkillEffectId != 0)
		{
			num ^= SkillEffectId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PerformerGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PerformerGuid);
		}
		if (SkillEffectId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SkillEffectId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PerformerGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PerformerGuid);
		}
		if (SkillEffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillEffectId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PerformerTriggerSkillEffect other)
	{
		if (other != null)
		{
			if (other.PerformerGuid.Length != 0)
			{
				PerformerGuid = other.PerformerGuid;
			}
			if (other.SkillEffectId != 0)
			{
				SkillEffectId = other.SkillEffectId;
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
			case 10u:
				PerformerGuid = input.ReadString();
				break;
			case 16u:
				SkillEffectId = input.ReadInt32();
				break;
			}
		}
	}
}
