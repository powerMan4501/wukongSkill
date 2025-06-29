using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStMobLevelMappingDesc : IMessage<FUStMobLevelMappingDesc>, IMessage, IEquatable<FUStMobLevelMappingDesc>, IDeepCloneable<FUStMobLevelMappingDesc>
{
	private static readonly MessageParser<FUStMobLevelMappingDesc> _parser = new MessageParser<FUStMobLevelMappingDesc>(() => new FUStMobLevelMappingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EMobStrengthLevel strengthLevel_;

	private EMobAttackType attackType_;

	private static readonly FieldCodec<string> _repeated_mobLibAssetPath_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> mobLibAssetPath_ = new RepeatedField<string>();

	public static MessageParser<FUStMobLevelMappingDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public EMobStrengthLevel StrengthLevel
	{
		get
		{
			return strengthLevel_;
		}
		set
		{
			strengthLevel_ = value;
		}
	}

	public EMobAttackType AttackType
	{
		get
		{
			return attackType_;
		}
		set
		{
			attackType_ = value;
		}
	}

	public RepeatedField<string> MobLibAssetPath => mobLibAssetPath_;

	public FUStMobLevelMappingDesc()
	{
	}

	public FUStMobLevelMappingDesc(FUStMobLevelMappingDesc other)
		: this()
	{
		iD_ = other.iD_;
		strengthLevel_ = other.strengthLevel_;
		attackType_ = other.attackType_;
		mobLibAssetPath_ = other.mobLibAssetPath_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMobLevelMappingDesc Clone()
	{
		return new FUStMobLevelMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMobLevelMappingDesc);
	}

	public bool Equals(FUStMobLevelMappingDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (StrengthLevel != other.StrengthLevel)
		{
			return false;
		}
		if (AttackType != other.AttackType)
		{
			return false;
		}
		if (!mobLibAssetPath_.Equals(other.mobLibAssetPath_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (StrengthLevel != EMobStrengthLevel.LevelWeak)
		{
			num ^= StrengthLevel.GetHashCode();
		}
		if (AttackType != EMobAttackType.MeleeAttack)
		{
			num ^= AttackType.GetHashCode();
		}
		num ^= mobLibAssetPath_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (StrengthLevel != EMobStrengthLevel.LevelWeak)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)StrengthLevel);
		}
		if (AttackType != EMobAttackType.MeleeAttack)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)AttackType);
		}
		mobLibAssetPath_.WriteTo(output, _repeated_mobLibAssetPath_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (StrengthLevel != EMobStrengthLevel.LevelWeak)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)StrengthLevel);
		}
		if (AttackType != EMobAttackType.MeleeAttack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AttackType);
		}
		num += mobLibAssetPath_.CalculateSize(_repeated_mobLibAssetPath_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStMobLevelMappingDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.StrengthLevel != EMobStrengthLevel.LevelWeak)
			{
				StrengthLevel = other.StrengthLevel;
			}
			if (other.AttackType != EMobAttackType.MeleeAttack)
			{
				AttackType = other.AttackType;
			}
			mobLibAssetPath_.Add(other.mobLibAssetPath_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
				StrengthLevel = (EMobStrengthLevel)input.ReadEnum();
				break;
			case 24u:
				AttackType = (EMobAttackType)input.ReadEnum();
				break;
			case 34u:
				mobLibAssetPath_.AddEntriesFrom(input, _repeated_mobLibAssetPath_codec);
				break;
			}
		}
	}
}
