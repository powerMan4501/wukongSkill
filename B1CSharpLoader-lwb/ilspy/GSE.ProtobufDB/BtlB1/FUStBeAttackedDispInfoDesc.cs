using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStBeAttackedDispInfoDesc : IMessage<FUStBeAttackedDispInfoDesc>, IMessage, IEquatable<FUStBeAttackedDispInfoDesc>, IDeepCloneable<FUStBeAttackedDispInfoDesc>
{
	private static readonly MessageParser<FUStBeAttackedDispInfoDesc> _parser = new MessageParser<FUStBeAttackedDispInfoDesc>(() => new FUStBeAttackedDispInfoDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private int beAttackedInfoID_;

	private int partRuleID_;

	private int partID_;

	private EHitItemFXType hitItemFXType_;

	private EHitItemAudioType hitItemAudioType_;

	private string guard_ = "";

	public static MessageParser<FUStBeAttackedDispInfoDesc> Parser => _parser;

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

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public int BeAttackedInfoID
	{
		get
		{
			return beAttackedInfoID_;
		}
		set
		{
			beAttackedInfoID_ = value;
		}
	}

	public int PartRuleID
	{
		get
		{
			return partRuleID_;
		}
		set
		{
			partRuleID_ = value;
		}
	}

	public int PartID
	{
		get
		{
			return partID_;
		}
		set
		{
			partID_ = value;
		}
	}

	public EHitItemFXType HitItemFXType
	{
		get
		{
			return hitItemFXType_;
		}
		set
		{
			hitItemFXType_ = value;
		}
	}

	public EHitItemAudioType HitItemAudioType
	{
		get
		{
			return hitItemAudioType_;
		}
		set
		{
			hitItemAudioType_ = value;
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

	public FUStBeAttackedDispInfoDesc()
	{
	}

	public FUStBeAttackedDispInfoDesc(FUStBeAttackedDispInfoDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		beAttackedInfoID_ = other.beAttackedInfoID_;
		partRuleID_ = other.partRuleID_;
		partID_ = other.partID_;
		hitItemFXType_ = other.hitItemFXType_;
		hitItemAudioType_ = other.hitItemAudioType_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBeAttackedDispInfoDesc Clone()
	{
		return new FUStBeAttackedDispInfoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBeAttackedDispInfoDesc);
	}

	public bool Equals(FUStBeAttackedDispInfoDesc other)
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
		if (ResID != other.ResID)
		{
			return false;
		}
		if (BeAttackedInfoID != other.BeAttackedInfoID)
		{
			return false;
		}
		if (PartRuleID != other.PartRuleID)
		{
			return false;
		}
		if (PartID != other.PartID)
		{
			return false;
		}
		if (HitItemFXType != other.HitItemFXType)
		{
			return false;
		}
		if (HitItemAudioType != other.HitItemAudioType)
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
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (BeAttackedInfoID != 0)
		{
			num ^= BeAttackedInfoID.GetHashCode();
		}
		if (PartRuleID != 0)
		{
			num ^= PartRuleID.GetHashCode();
		}
		if (PartID != 0)
		{
			num ^= PartID.GetHashCode();
		}
		if (HitItemFXType != EHitItemFXType.NormalBody)
		{
			num ^= HitItemFXType.GetHashCode();
		}
		if (HitItemAudioType != EHitItemAudioType.NormalBody)
		{
			num ^= HitItemAudioType.GetHashCode();
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
		if (ResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResID);
		}
		if (BeAttackedInfoID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BeAttackedInfoID);
		}
		if (PartRuleID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PartRuleID);
		}
		if (PartID != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(PartID);
		}
		if (HitItemFXType != EHitItemFXType.NormalBody)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)HitItemFXType);
		}
		if (HitItemAudioType != EHitItemAudioType.NormalBody)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)HitItemAudioType);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(66);
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
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (BeAttackedInfoID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BeAttackedInfoID);
		}
		if (PartRuleID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PartRuleID);
		}
		if (PartID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PartID);
		}
		if (HitItemFXType != EHitItemFXType.NormalBody)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitItemFXType);
		}
		if (HitItemAudioType != EHitItemAudioType.NormalBody)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitItemAudioType);
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

	public void MergeFrom(FUStBeAttackedDispInfoDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.BeAttackedInfoID != 0)
			{
				BeAttackedInfoID = other.BeAttackedInfoID;
			}
			if (other.PartRuleID != 0)
			{
				PartRuleID = other.PartRuleID;
			}
			if (other.PartID != 0)
			{
				PartID = other.PartID;
			}
			if (other.HitItemFXType != EHitItemFXType.NormalBody)
			{
				HitItemFXType = other.HitItemFXType;
			}
			if (other.HitItemAudioType != EHitItemAudioType.NormalBody)
			{
				HitItemAudioType = other.HitItemAudioType;
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
				ResID = input.ReadInt32();
				break;
			case 24u:
				BeAttackedInfoID = input.ReadInt32();
				break;
			case 32u:
				PartRuleID = input.ReadInt32();
				break;
			case 40u:
				PartID = input.ReadInt32();
				break;
			case 48u:
				HitItemFXType = (EHitItemFXType)input.ReadEnum();
				break;
			case 56u:
				HitItemAudioType = (EHitItemAudioType)input.ReadEnum();
				break;
			case 66u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
