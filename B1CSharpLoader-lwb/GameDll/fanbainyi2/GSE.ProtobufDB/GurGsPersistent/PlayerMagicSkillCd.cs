using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class PlayerMagicSkillCd : IMessage<PlayerMagicSkillCd>, IMessage, IEquatable<PlayerMagicSkillCd>, IDeepCloneable<PlayerMagicSkillCd>
{
	private static readonly MessageParser<PlayerMagicSkillCd> _parser = new MessageParser<PlayerMagicSkillCd>(() => new PlayerMagicSkillCd());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int skillId_;

	private float coolDown_;

	public static MessageParser<PlayerMagicSkillCd> Parser => _parser;

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

	public float CoolDown
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return coolDown_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			coolDown_ = value;
		}
	}

	public bool HasCoolDown => (_hasBits0 & 2) != 0;

	public PlayerMagicSkillCd()
	{
	}

	public PlayerMagicSkillCd(PlayerMagicSkillCd other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		skillId_ = other.skillId_;
		coolDown_ = other.coolDown_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerMagicSkillCd Clone()
	{
		return new PlayerMagicSkillCd(this);
	}

	public void ClearSkillId()
	{
		_hasBits0 &= -2;
	}

	public void ClearCoolDown()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerMagicSkillCd);
	}

	public bool Equals(PlayerMagicSkillCd other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CoolDown, other.CoolDown))
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
		if (HasCoolDown)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CoolDown);
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
		if (HasCoolDown)
		{
			output.WriteRawTag(21);
			output.WriteFloat(CoolDown);
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
		if (HasCoolDown)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerMagicSkillCd other)
	{
		if (other != null)
		{
			if (other.HasSkillId)
			{
				SkillId = other.SkillId;
			}
			if (other.HasCoolDown)
			{
				CoolDown = other.CoolDown;
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
			case 21u:
				CoolDown = input.ReadFloat();
				break;
			}
		}
	}
}
