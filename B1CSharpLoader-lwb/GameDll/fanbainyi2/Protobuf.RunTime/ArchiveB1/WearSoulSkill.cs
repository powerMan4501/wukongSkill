using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class WearSoulSkill : IMessage<WearSoulSkill>, IMessage, IEquatable<WearSoulSkill>, IDeepCloneable<WearSoulSkill>
{
	private static readonly MessageParser<WearSoulSkill> _parser = new MessageParser<WearSoulSkill>(() => new WearSoulSkill());

	private UnknownFieldSet _unknownFields;

	private int soulSkillId_;

	private ulong uid_;

	public static MessageParser<WearSoulSkill> Parser => _parser;

	public int SoulSkillId
	{
		get
		{
			return soulSkillId_;
		}
		set
		{
			soulSkillId_ = value;
		}
	}

	public ulong Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	public WearSoulSkill()
	{
	}

	public WearSoulSkill(WearSoulSkill other)
		: this()
	{
		soulSkillId_ = other.soulSkillId_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WearSoulSkill Clone()
	{
		return new WearSoulSkill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WearSoulSkill);
	}

	public bool Equals(WearSoulSkill other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SoulSkillId != other.SoulSkillId)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SoulSkillId != 0)
		{
			num ^= SoulSkillId.GetHashCode();
		}
		if (Uid != 0L)
		{
			num ^= Uid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SoulSkillId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SoulSkillId);
		}
		if (Uid != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Uid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SoulSkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoulSkillId);
		}
		if (Uid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WearSoulSkill other)
	{
		if (other != null)
		{
			if (other.SoulSkillId != 0)
			{
				SoulSkillId = other.SoulSkillId;
			}
			if (other.Uid != 0L)
			{
				Uid = other.Uid;
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
				SoulSkillId = input.ReadInt32();
				break;
			case 16u:
				Uid = input.ReadUInt64();
				break;
			}
		}
	}
}
