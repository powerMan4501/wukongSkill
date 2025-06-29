using System;
using Google.Protobuf;

namespace CommB1;

public sealed class OneCBGCastSkillInfo : IMessage<OneCBGCastSkillInfo>, IMessage, IEquatable<OneCBGCastSkillInfo>, IDeepCloneable<OneCBGCastSkillInfo>
{
	private static readonly MessageParser<OneCBGCastSkillInfo> _parser = new MessageParser<OneCBGCastSkillInfo>(() => new OneCBGCastSkillInfo());

	private UnknownFieldSet _unknownFields;

	private int skillId_;

	private string montageStartSectionName_ = "";

	private bool dontCheckSkillCanCast_;

	private bool canCastWhenDead_;

	public static MessageParser<OneCBGCastSkillInfo> Parser => _parser;

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

	public string MontageStartSectionName
	{
		get
		{
			return montageStartSectionName_;
		}
		set
		{
			montageStartSectionName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool DontCheckSkillCanCast
	{
		get
		{
			return dontCheckSkillCanCast_;
		}
		set
		{
			dontCheckSkillCanCast_ = value;
		}
	}

	public bool CanCastWhenDead
	{
		get
		{
			return canCastWhenDead_;
		}
		set
		{
			canCastWhenDead_ = value;
		}
	}

	public OneCBGCastSkillInfo()
	{
	}

	public OneCBGCastSkillInfo(OneCBGCastSkillInfo other)
		: this()
	{
		skillId_ = other.skillId_;
		montageStartSectionName_ = other.montageStartSectionName_;
		dontCheckSkillCanCast_ = other.dontCheckSkillCanCast_;
		canCastWhenDead_ = other.canCastWhenDead_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OneCBGCastSkillInfo Clone()
	{
		return new OneCBGCastSkillInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OneCBGCastSkillInfo);
	}

	public bool Equals(OneCBGCastSkillInfo other)
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
		if (MontageStartSectionName != other.MontageStartSectionName)
		{
			return false;
		}
		if (DontCheckSkillCanCast != other.DontCheckSkillCanCast)
		{
			return false;
		}
		if (CanCastWhenDead != other.CanCastWhenDead)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (MontageStartSectionName.Length != 0)
		{
			num ^= MontageStartSectionName.GetHashCode();
		}
		if (DontCheckSkillCanCast)
		{
			num ^= DontCheckSkillCanCast.GetHashCode();
		}
		if (CanCastWhenDead)
		{
			num ^= CanCastWhenDead.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SkillId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SkillId);
		}
		if (MontageStartSectionName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MontageStartSectionName);
		}
		if (DontCheckSkillCanCast)
		{
			output.WriteRawTag(24);
			output.WriteBool(DontCheckSkillCanCast);
		}
		if (CanCastWhenDead)
		{
			output.WriteRawTag(32);
			output.WriteBool(CanCastWhenDead);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (MontageStartSectionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MontageStartSectionName);
		}
		if (DontCheckSkillCanCast)
		{
			num += 2;
		}
		if (CanCastWhenDead)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OneCBGCastSkillInfo other)
	{
		if (other != null)
		{
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.MontageStartSectionName.Length != 0)
			{
				MontageStartSectionName = other.MontageStartSectionName;
			}
			if (other.DontCheckSkillCanCast)
			{
				DontCheckSkillCanCast = other.DontCheckSkillCanCast;
			}
			if (other.CanCastWhenDead)
			{
				CanCastWhenDead = other.CanCastWhenDead;
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
				SkillId = input.ReadInt32();
				break;
			case 18u:
				MontageStartSectionName = input.ReadString();
				break;
			case 24u:
				DontCheckSkillCanCast = input.ReadBool();
				break;
			case 32u:
				CanCastWhenDead = input.ReadBool();
				break;
			}
		}
	}
}
