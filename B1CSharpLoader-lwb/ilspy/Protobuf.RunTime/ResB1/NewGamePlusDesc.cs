using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class NewGamePlusDesc : IMessage<NewGamePlusDesc>, IMessage, IEquatable<NewGamePlusDesc>, IDeepCloneable<NewGamePlusDesc>
{
	private static readonly MessageParser<NewGamePlusDesc> _parser = new MessageParser<NewGamePlusDesc>(() => new NewGamePlusDesc());

	private UnknownFieldSet _unknownFields;

	private EUnitQualityType quality_;

	private int count_;

	private float hpMaxBase_;

	private float atkMul_;

	private float defMul_;

	private int addExp_;

	private int addSprit_;

	private int levelStrength_;

	public static MessageParser<NewGamePlusDesc> Parser => _parser;

	public EUnitQualityType Quality
	{
		get
		{
			return quality_;
		}
		set
		{
			quality_ = value;
		}
	}

	public int Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	public float HpMaxBase
	{
		get
		{
			return hpMaxBase_;
		}
		set
		{
			hpMaxBase_ = value;
		}
	}

	public float AtkMul
	{
		get
		{
			return atkMul_;
		}
		set
		{
			atkMul_ = value;
		}
	}

	public float DefMul
	{
		get
		{
			return defMul_;
		}
		set
		{
			defMul_ = value;
		}
	}

	public int AddExp
	{
		get
		{
			return addExp_;
		}
		set
		{
			addExp_ = value;
		}
	}

	public int AddSprit
	{
		get
		{
			return addSprit_;
		}
		set
		{
			addSprit_ = value;
		}
	}

	public int LevelStrength
	{
		get
		{
			return levelStrength_;
		}
		set
		{
			levelStrength_ = value;
		}
	}

	public NewGamePlusDesc()
	{
	}

	public NewGamePlusDesc(NewGamePlusDesc other)
		: this()
	{
		quality_ = other.quality_;
		count_ = other.count_;
		hpMaxBase_ = other.hpMaxBase_;
		atkMul_ = other.atkMul_;
		defMul_ = other.defMul_;
		addExp_ = other.addExp_;
		addSprit_ = other.addSprit_;
		levelStrength_ = other.levelStrength_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public NewGamePlusDesc Clone()
	{
		return new NewGamePlusDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as NewGamePlusDesc);
	}

	public bool Equals(NewGamePlusDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Quality != other.Quality)
		{
			return false;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HpMaxBase, other.HpMaxBase))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AtkMul, other.AtkMul))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DefMul, other.DefMul))
		{
			return false;
		}
		if (AddExp != other.AddExp)
		{
			return false;
		}
		if (AddSprit != other.AddSprit)
		{
			return false;
		}
		if (LevelStrength != other.LevelStrength)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Quality != EUnitQualityType.None)
		{
			num ^= Quality.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (HpMaxBase != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HpMaxBase);
		}
		if (AtkMul != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AtkMul);
		}
		if (DefMul != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DefMul);
		}
		if (AddExp != 0)
		{
			num ^= AddExp.GetHashCode();
		}
		if (AddSprit != 0)
		{
			num ^= AddSprit.GetHashCode();
		}
		if (LevelStrength != 0)
		{
			num ^= LevelStrength.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Quality != EUnitQualityType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Quality);
		}
		if (Count != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Count);
		}
		if (HpMaxBase != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(HpMaxBase);
		}
		if (AtkMul != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(AtkMul);
		}
		if (DefMul != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(DefMul);
		}
		if (AddExp != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(AddExp);
		}
		if (AddSprit != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(AddSprit);
		}
		if (LevelStrength != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LevelStrength);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Quality != EUnitQualityType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Quality);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Count);
		}
		if (HpMaxBase != 0f)
		{
			num += 5;
		}
		if (AtkMul != 0f)
		{
			num += 5;
		}
		if (DefMul != 0f)
		{
			num += 5;
		}
		if (AddExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddExp);
		}
		if (AddSprit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddSprit);
		}
		if (LevelStrength != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelStrength);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(NewGamePlusDesc other)
	{
		if (other != null)
		{
			if (other.Quality != EUnitQualityType.None)
			{
				Quality = other.Quality;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.HpMaxBase != 0f)
			{
				HpMaxBase = other.HpMaxBase;
			}
			if (other.AtkMul != 0f)
			{
				AtkMul = other.AtkMul;
			}
			if (other.DefMul != 0f)
			{
				DefMul = other.DefMul;
			}
			if (other.AddExp != 0)
			{
				AddExp = other.AddExp;
			}
			if (other.AddSprit != 0)
			{
				AddSprit = other.AddSprit;
			}
			if (other.LevelStrength != 0)
			{
				LevelStrength = other.LevelStrength;
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
				Quality = (EUnitQualityType)input.ReadEnum();
				break;
			case 16u:
				Count = input.ReadInt32();
				break;
			case 29u:
				HpMaxBase = input.ReadFloat();
				break;
			case 37u:
				AtkMul = input.ReadFloat();
				break;
			case 45u:
				DefMul = input.ReadFloat();
				break;
			case 48u:
				AddExp = input.ReadInt32();
				break;
			case 56u:
				AddSprit = input.ReadInt32();
				break;
			case 64u:
				LevelStrength = input.ReadInt32();
				break;
			}
		}
	}
}
