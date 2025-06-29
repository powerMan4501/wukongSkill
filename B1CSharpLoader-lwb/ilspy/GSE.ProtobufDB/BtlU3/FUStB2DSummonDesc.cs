using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DSummonDesc : IMessage<FUStB2DSummonDesc>, IMessage, IEquatable<FUStB2DSummonDesc>, IDeepCloneable<FUStB2DSummonDesc>
{
	private static readonly MessageParser<FUStB2DSummonDesc> _parser = new MessageParser<FUStB2DSummonDesc>(() => new FUStB2DSummonDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int bornBuff_;

	private float bornShowTime_;

	private float lifeTime_;

	private int destroyOnOwnerDead_;

	private float inheritFinalAtk_;

	private float inheritFinalHp_;

	private float inheritFinalDef_;

	private int inheritMasterAttrLevel2_;

	public static MessageParser<FUStB2DSummonDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int BornBuff
	{
		get
		{
			return bornBuff_;
		}
		set
		{
			bornBuff_ = value;
		}
	}

	public float BornShowTime
	{
		get
		{
			return bornShowTime_;
		}
		set
		{
			bornShowTime_ = value;
		}
	}

	public float LifeTime
	{
		get
		{
			return lifeTime_;
		}
		set
		{
			lifeTime_ = value;
		}
	}

	public int DestroyOnOwnerDead
	{
		get
		{
			return destroyOnOwnerDead_;
		}
		set
		{
			destroyOnOwnerDead_ = value;
		}
	}

	public float InheritFinalAtk
	{
		get
		{
			return inheritFinalAtk_;
		}
		set
		{
			inheritFinalAtk_ = value;
		}
	}

	public float InheritFinalHp
	{
		get
		{
			return inheritFinalHp_;
		}
		set
		{
			inheritFinalHp_ = value;
		}
	}

	public float InheritFinalDef
	{
		get
		{
			return inheritFinalDef_;
		}
		set
		{
			inheritFinalDef_ = value;
		}
	}

	public int InheritMasterAttrLevel2
	{
		get
		{
			return inheritMasterAttrLevel2_;
		}
		set
		{
			inheritMasterAttrLevel2_ = value;
		}
	}

	public FUStB2DSummonDesc()
	{
	}

	public FUStB2DSummonDesc(FUStB2DSummonDesc other)
		: this()
	{
		id_ = other.id_;
		bornBuff_ = other.bornBuff_;
		bornShowTime_ = other.bornShowTime_;
		lifeTime_ = other.lifeTime_;
		destroyOnOwnerDead_ = other.destroyOnOwnerDead_;
		inheritFinalAtk_ = other.inheritFinalAtk_;
		inheritFinalHp_ = other.inheritFinalHp_;
		inheritFinalDef_ = other.inheritFinalDef_;
		inheritMasterAttrLevel2_ = other.inheritMasterAttrLevel2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSummonDesc Clone()
	{
		return new FUStB2DSummonDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSummonDesc);
	}

	public bool Equals(FUStB2DSummonDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (BornBuff != other.BornBuff)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BornShowTime, other.BornShowTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LifeTime, other.LifeTime))
		{
			return false;
		}
		if (DestroyOnOwnerDead != other.DestroyOnOwnerDead)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InheritFinalAtk, other.InheritFinalAtk))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InheritFinalHp, other.InheritFinalHp))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InheritFinalDef, other.InheritFinalDef))
		{
			return false;
		}
		if (InheritMasterAttrLevel2 != other.InheritMasterAttrLevel2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (BornBuff != 0)
		{
			num ^= BornBuff.GetHashCode();
		}
		if (BornShowTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BornShowTime);
		}
		if (LifeTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LifeTime);
		}
		if (DestroyOnOwnerDead != 0)
		{
			num ^= DestroyOnOwnerDead.GetHashCode();
		}
		if (InheritFinalAtk != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InheritFinalAtk);
		}
		if (InheritFinalHp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InheritFinalHp);
		}
		if (InheritFinalDef != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InheritFinalDef);
		}
		if (InheritMasterAttrLevel2 != 0)
		{
			num ^= InheritMasterAttrLevel2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (BornBuff != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BornBuff);
		}
		if (BornShowTime != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(BornShowTime);
		}
		if (LifeTime != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(LifeTime);
		}
		if (DestroyOnOwnerDead != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DestroyOnOwnerDead);
		}
		if (InheritFinalAtk != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(InheritFinalAtk);
		}
		if (InheritFinalHp != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(InheritFinalHp);
		}
		if (InheritFinalDef != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(InheritFinalDef);
		}
		if (InheritMasterAttrLevel2 != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(InheritMasterAttrLevel2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (BornBuff != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BornBuff);
		}
		if (BornShowTime != 0f)
		{
			num += 5;
		}
		if (LifeTime != 0f)
		{
			num += 5;
		}
		if (DestroyOnOwnerDead != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DestroyOnOwnerDead);
		}
		if (InheritFinalAtk != 0f)
		{
			num += 5;
		}
		if (InheritFinalHp != 0f)
		{
			num += 5;
		}
		if (InheritFinalDef != 0f)
		{
			num += 5;
		}
		if (InheritMasterAttrLevel2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InheritMasterAttrLevel2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSummonDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.BornBuff != 0)
			{
				BornBuff = other.BornBuff;
			}
			if (other.BornShowTime != 0f)
			{
				BornShowTime = other.BornShowTime;
			}
			if (other.LifeTime != 0f)
			{
				LifeTime = other.LifeTime;
			}
			if (other.DestroyOnOwnerDead != 0)
			{
				DestroyOnOwnerDead = other.DestroyOnOwnerDead;
			}
			if (other.InheritFinalAtk != 0f)
			{
				InheritFinalAtk = other.InheritFinalAtk;
			}
			if (other.InheritFinalHp != 0f)
			{
				InheritFinalHp = other.InheritFinalHp;
			}
			if (other.InheritFinalDef != 0f)
			{
				InheritFinalDef = other.InheritFinalDef;
			}
			if (other.InheritMasterAttrLevel2 != 0)
			{
				InheritMasterAttrLevel2 = other.InheritMasterAttrLevel2;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				BornBuff = input.ReadInt32();
				break;
			case 29u:
				BornShowTime = input.ReadFloat();
				break;
			case 37u:
				LifeTime = input.ReadFloat();
				break;
			case 40u:
				DestroyOnOwnerDead = input.ReadInt32();
				break;
			case 53u:
				InheritFinalAtk = input.ReadFloat();
				break;
			case 61u:
				InheritFinalHp = input.ReadFloat();
				break;
			case 69u:
				InheritFinalDef = input.ReadFloat();
				break;
			case 72u:
				InheritMasterAttrLevel2 = input.ReadInt32();
				break;
			}
		}
	}
}
