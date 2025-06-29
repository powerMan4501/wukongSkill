using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_SkillCoolDown : IMessage<CalliopeCustom_DetectCondition_SkillCoolDown>, IMessage, IEquatable<CalliopeCustom_DetectCondition_SkillCoolDown>, IDeepCloneable<CalliopeCustom_DetectCondition_SkillCoolDown>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_SkillCoolDown> _parser = new MessageParser<CalliopeCustom_DetectCondition_SkillCoolDown>(() => new CalliopeCustom_DetectCondition_SkillCoolDown());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int skillId_;

	public static MessageParser<CalliopeCustom_DetectCondition_SkillCoolDown> Parser => _parser;

	public int SkillId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return skillId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			skillId_ = value;
		}
	}

	public bool HasSkillId => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_SkillCoolDown()
	{
	}

	public CalliopeCustom_DetectCondition_SkillCoolDown(CalliopeCustom_DetectCondition_SkillCoolDown other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		skillId_ = other.skillId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_SkillCoolDown Clone()
	{
		return new CalliopeCustom_DetectCondition_SkillCoolDown(this);
	}

	public void ClearSkillId()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_SkillCoolDown);
	}

	public bool Equals(CalliopeCustom_DetectCondition_SkillCoolDown other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasSkillId)
		{
			num ^= SkillId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasSkillId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SkillId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasSkillId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_SkillCoolDown other)
	{
		if (other != null)
		{
			if (other.HasSkillId)
			{
				SkillId = other.SkillId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				SkillId = input.ReadInt32();
			}
		}
	}
}
