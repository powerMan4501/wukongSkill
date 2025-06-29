using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStAttackerHitFXMappingDesc : IMessage<FUStAttackerHitFXMappingDesc>, IMessage, IEquatable<FUStAttackerHitFXMappingDesc>, IDeepCloneable<FUStAttackerHitFXMappingDesc>
{
	private static readonly MessageParser<FUStAttackerHitFXMappingDesc> _parser = new MessageParser<FUStAttackerHitFXMappingDesc>(() => new FUStAttackerHitFXMappingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EHitItemFXType hitItemType_;

	private EHitPerformFXEventType lowerHitPerformTypeCondition_;

	private EHitPerformFXEventType mappingHitPerformType_;

	private string guard_ = "";

	public static MessageParser<FUStAttackerHitFXMappingDesc> Parser => _parser;

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

	public EHitItemFXType HitItemType
	{
		get
		{
			return hitItemType_;
		}
		set
		{
			hitItemType_ = value;
		}
	}

	public EHitPerformFXEventType LowerHitPerformTypeCondition
	{
		get
		{
			return lowerHitPerformTypeCondition_;
		}
		set
		{
			lowerHitPerformTypeCondition_ = value;
		}
	}

	public EHitPerformFXEventType MappingHitPerformType
	{
		get
		{
			return mappingHitPerformType_;
		}
		set
		{
			mappingHitPerformType_ = value;
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

	public FUStAttackerHitFXMappingDesc()
	{
	}

	public FUStAttackerHitFXMappingDesc(FUStAttackerHitFXMappingDesc other)
		: this()
	{
		iD_ = other.iD_;
		hitItemType_ = other.hitItemType_;
		lowerHitPerformTypeCondition_ = other.lowerHitPerformTypeCondition_;
		mappingHitPerformType_ = other.mappingHitPerformType_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAttackerHitFXMappingDesc Clone()
	{
		return new FUStAttackerHitFXMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAttackerHitFXMappingDesc);
	}

	public bool Equals(FUStAttackerHitFXMappingDesc other)
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
		if (HitItemType != other.HitItemType)
		{
			return false;
		}
		if (LowerHitPerformTypeCondition != other.LowerHitPerformTypeCondition)
		{
			return false;
		}
		if (MappingHitPerformType != other.MappingHitPerformType)
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
		if (HitItemType != EHitItemFXType.NormalBody)
		{
			num ^= HitItemType.GetHashCode();
		}
		if (LowerHitPerformTypeCondition != EHitPerformFXEventType.None)
		{
			num ^= LowerHitPerformTypeCondition.GetHashCode();
		}
		if (MappingHitPerformType != EHitPerformFXEventType.None)
		{
			num ^= MappingHitPerformType.GetHashCode();
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
		if (HitItemType != EHitItemFXType.NormalBody)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)HitItemType);
		}
		if (LowerHitPerformTypeCondition != EHitPerformFXEventType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)LowerHitPerformTypeCondition);
		}
		if (MappingHitPerformType != EHitPerformFXEventType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)MappingHitPerformType);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(42);
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
		if (HitItemType != EHitItemFXType.NormalBody)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitItemType);
		}
		if (LowerHitPerformTypeCondition != EHitPerformFXEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LowerHitPerformTypeCondition);
		}
		if (MappingHitPerformType != EHitPerformFXEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MappingHitPerformType);
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

	public void MergeFrom(FUStAttackerHitFXMappingDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.HitItemType != EHitItemFXType.NormalBody)
			{
				HitItemType = other.HitItemType;
			}
			if (other.LowerHitPerformTypeCondition != EHitPerformFXEventType.None)
			{
				LowerHitPerformTypeCondition = other.LowerHitPerformTypeCondition;
			}
			if (other.MappingHitPerformType != EHitPerformFXEventType.None)
			{
				MappingHitPerformType = other.MappingHitPerformType;
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
				HitItemType = (EHitItemFXType)input.ReadEnum();
				break;
			case 24u:
				LowerHitPerformTypeCondition = (EHitPerformFXEventType)input.ReadEnum();
				break;
			case 32u:
				MappingHitPerformType = (EHitPerformFXEventType)input.ReadEnum();
				break;
			case 42u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
