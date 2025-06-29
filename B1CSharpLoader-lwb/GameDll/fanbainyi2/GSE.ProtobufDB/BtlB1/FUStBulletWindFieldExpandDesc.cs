using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStBulletWindFieldExpandDesc : IMessage<FUStBulletWindFieldExpandDesc>, IMessage, IEquatable<FUStBulletWindFieldExpandDesc>, IDeepCloneable<FUStBulletWindFieldExpandDesc>
{
	private static readonly MessageParser<FUStBulletWindFieldExpandDesc> _parser = new MessageParser<FUStBulletWindFieldExpandDesc>(() => new FUStBulletWindFieldExpandDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EBulletWindFieldActionType hitUnitActionType_;

	private EBulletWindFieldActionType hitItemActionType_;

	private EBulletWindFieldActionType lifeOverDestroyActionType_;

	private EBulletWindFieldActionType effectDestroyActionType_;

	private string guard_ = "";

	public static MessageParser<FUStBulletWindFieldExpandDesc> Parser => _parser;

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

	public EBulletWindFieldActionType HitUnitActionType
	{
		get
		{
			return hitUnitActionType_;
		}
		set
		{
			hitUnitActionType_ = value;
		}
	}

	public EBulletWindFieldActionType HitItemActionType
	{
		get
		{
			return hitItemActionType_;
		}
		set
		{
			hitItemActionType_ = value;
		}
	}

	public EBulletWindFieldActionType LifeOverDestroyActionType
	{
		get
		{
			return lifeOverDestroyActionType_;
		}
		set
		{
			lifeOverDestroyActionType_ = value;
		}
	}

	public EBulletWindFieldActionType EffectDestroyActionType
	{
		get
		{
			return effectDestroyActionType_;
		}
		set
		{
			effectDestroyActionType_ = value;
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStBulletWindFieldExpandDesc()
	{
	}

	public FUStBulletWindFieldExpandDesc(FUStBulletWindFieldExpandDesc other)
		: this()
	{
		iD_ = other.iD_;
		hitUnitActionType_ = other.hitUnitActionType_;
		hitItemActionType_ = other.hitItemActionType_;
		lifeOverDestroyActionType_ = other.lifeOverDestroyActionType_;
		effectDestroyActionType_ = other.effectDestroyActionType_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBulletWindFieldExpandDesc Clone()
	{
		return new FUStBulletWindFieldExpandDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBulletWindFieldExpandDesc);
	}

	public bool Equals(FUStBulletWindFieldExpandDesc other)
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
		if (HitUnitActionType != other.HitUnitActionType)
		{
			return false;
		}
		if (HitItemActionType != other.HitItemActionType)
		{
			return false;
		}
		if (LifeOverDestroyActionType != other.LifeOverDestroyActionType)
		{
			return false;
		}
		if (EffectDestroyActionType != other.EffectDestroyActionType)
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (HitUnitActionType != EBulletWindFieldActionType.None)
		{
			num ^= HitUnitActionType.GetHashCode();
		}
		if (HitItemActionType != EBulletWindFieldActionType.None)
		{
			num ^= HitItemActionType.GetHashCode();
		}
		if (LifeOverDestroyActionType != EBulletWindFieldActionType.None)
		{
			num ^= LifeOverDestroyActionType.GetHashCode();
		}
		if (EffectDestroyActionType != EBulletWindFieldActionType.None)
		{
			num ^= EffectDestroyActionType.GetHashCode();
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
		}
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
		if (HitUnitActionType != EBulletWindFieldActionType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)HitUnitActionType);
		}
		if (HitItemActionType != EBulletWindFieldActionType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)HitItemActionType);
		}
		if (LifeOverDestroyActionType != EBulletWindFieldActionType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)LifeOverDestroyActionType);
		}
		if (EffectDestroyActionType != EBulletWindFieldActionType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)EffectDestroyActionType);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Guard);
		}
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
		if (HitUnitActionType != EBulletWindFieldActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitUnitActionType);
		}
		if (HitItemActionType != EBulletWindFieldActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitItemActionType);
		}
		if (LifeOverDestroyActionType != EBulletWindFieldActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LifeOverDestroyActionType);
		}
		if (EffectDestroyActionType != EBulletWindFieldActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectDestroyActionType);
		}
		if (Guard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBulletWindFieldExpandDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.HitUnitActionType != EBulletWindFieldActionType.None)
			{
				HitUnitActionType = other.HitUnitActionType;
			}
			if (other.HitItemActionType != EBulletWindFieldActionType.None)
			{
				HitItemActionType = other.HitItemActionType;
			}
			if (other.LifeOverDestroyActionType != EBulletWindFieldActionType.None)
			{
				LifeOverDestroyActionType = other.LifeOverDestroyActionType;
			}
			if (other.EffectDestroyActionType != EBulletWindFieldActionType.None)
			{
				EffectDestroyActionType = other.EffectDestroyActionType;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				HitUnitActionType = (EBulletWindFieldActionType)input.ReadEnum();
				break;
			case 24u:
				HitItemActionType = (EBulletWindFieldActionType)input.ReadEnum();
				break;
			case 32u:
				LifeOverDestroyActionType = (EBulletWindFieldActionType)input.ReadEnum();
				break;
			case 40u:
				EffectDestroyActionType = (EBulletWindFieldActionType)input.ReadEnum();
				break;
			case 50u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
