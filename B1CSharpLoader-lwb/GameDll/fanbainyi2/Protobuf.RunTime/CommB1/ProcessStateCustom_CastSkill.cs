using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_CastSkill : IMessage<ProcessStateCustom_CastSkill>, IMessage, IEquatable<ProcessStateCustom_CastSkill>, IDeepCloneable<ProcessStateCustom_CastSkill>
{
	private static readonly MessageParser<ProcessStateCustom_CastSkill> _parser = new MessageParser<ProcessStateCustom_CastSkill>(() => new ProcessStateCustom_CastSkill());

	private UnknownFieldSet _unknownFields;

	private string unitGuid_ = "";

	private int skillId_;

	private bool needCheckSkillCanCast_;

	public static MessageParser<ProcessStateCustom_CastSkill> Parser => _parser;

	public string UnitGuid
	{
		get
		{
			return unitGuid_;
		}
		set
		{
			unitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	public bool NeedCheckSkillCanCast
	{
		get
		{
			return needCheckSkillCanCast_;
		}
		set
		{
			needCheckSkillCanCast_ = value;
		}
	}

	public ProcessStateCustom_CastSkill()
	{
	}

	public ProcessStateCustom_CastSkill(ProcessStateCustom_CastSkill other)
		: this()
	{
		unitGuid_ = other.unitGuid_;
		skillId_ = other.skillId_;
		needCheckSkillCanCast_ = other.needCheckSkillCanCast_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_CastSkill Clone()
	{
		return new ProcessStateCustom_CastSkill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_CastSkill);
	}

	public bool Equals(ProcessStateCustom_CastSkill other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (NeedCheckSkillCanCast != other.NeedCheckSkillCanCast)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (NeedCheckSkillCanCast)
		{
			num ^= NeedCheckSkillCanCast.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(UnitGuid);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SkillId);
		}
		if (NeedCheckSkillCanCast)
		{
			output.WriteRawTag(24);
			output.WriteBool(NeedCheckSkillCanCast);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (NeedCheckSkillCanCast)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_CastSkill other)
	{
		if (other != null)
		{
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.NeedCheckSkillCanCast)
			{
				NeedCheckSkillCanCast = other.NeedCheckSkillCanCast;
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
				UnitGuid = input.ReadString();
				break;
			case 16u:
				SkillId = input.ReadInt32();
				break;
			case 24u:
				NeedCheckSkillCanCast = input.ReadBool();
				break;
			}
		}
	}
}
