using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushRoleBase : IMessage<BossRushRoleBase>, IMessage, IEquatable<BossRushRoleBase>, IDeepCloneable<BossRushRoleBase>
{
	private static readonly MessageParser<BossRushRoleBase> _parser = new MessageParser<BossRushRoleBase>(() => new BossRushRoleBase());

	private UnknownFieldSet _unknownFields;

	private int level_;

	private float atk_;

	private float hpMax_;

	private float staminaMax_;

	private float mpMax_;

	public static MessageParser<BossRushRoleBase> Parser => _parser;

	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public float Atk
	{
		get
		{
			return atk_;
		}
		set
		{
			atk_ = value;
		}
	}

	public float HpMax
	{
		get
		{
			return hpMax_;
		}
		set
		{
			hpMax_ = value;
		}
	}

	public float StaminaMax
	{
		get
		{
			return staminaMax_;
		}
		set
		{
			staminaMax_ = value;
		}
	}

	public float MpMax
	{
		get
		{
			return mpMax_;
		}
		set
		{
			mpMax_ = value;
		}
	}

	public BossRushRoleBase()
	{
	}

	public BossRushRoleBase(BossRushRoleBase other)
		: this()
	{
		level_ = other.level_;
		atk_ = other.atk_;
		hpMax_ = other.hpMax_;
		staminaMax_ = other.staminaMax_;
		mpMax_ = other.mpMax_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushRoleBase Clone()
	{
		return new BossRushRoleBase(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushRoleBase);
	}

	public bool Equals(BossRushRoleBase other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Atk, other.Atk))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HpMax, other.HpMax))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StaminaMax, other.StaminaMax))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MpMax, other.MpMax))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Atk != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Atk);
		}
		if (HpMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HpMax);
		}
		if (StaminaMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StaminaMax);
		}
		if (MpMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MpMax);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Level != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Level);
		}
		if (Atk != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Atk);
		}
		if (HpMax != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(HpMax);
		}
		if (StaminaMax != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(StaminaMax);
		}
		if (MpMax != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(MpMax);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (Atk != 0f)
		{
			num += 5;
		}
		if (HpMax != 0f)
		{
			num += 5;
		}
		if (StaminaMax != 0f)
		{
			num += 5;
		}
		if (MpMax != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushRoleBase other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Atk != 0f)
			{
				Atk = other.Atk;
			}
			if (other.HpMax != 0f)
			{
				HpMax = other.HpMax;
			}
			if (other.StaminaMax != 0f)
			{
				StaminaMax = other.StaminaMax;
			}
			if (other.MpMax != 0f)
			{
				MpMax = other.MpMax;
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
				Level = input.ReadInt32();
				break;
			case 21u:
				Atk = input.ReadFloat();
				break;
			case 29u:
				HpMax = input.ReadFloat();
				break;
			case 37u:
				StaminaMax = input.ReadFloat();
				break;
			case 45u:
				MpMax = input.ReadFloat();
				break;
			}
		}
	}
}
