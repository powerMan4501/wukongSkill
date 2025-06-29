using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPartHitExpandDesc : IMessage<FUStPartHitExpandDesc>, IMessage, IEquatable<FUStPartHitExpandDesc>, IDeepCloneable<FUStPartHitExpandDesc>
{
	private static readonly MessageParser<FUStPartHitExpandDesc> _parser = new MessageParser<FUStPartHitExpandDesc>(() => new FUStPartHitExpandDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int partRuleID_;

	private int partID_;

	private static readonly FieldCodec<FUStPartHitAttrRecoverConfig> _repeated_partHitAttrRecoverList_codec = FieldCodec.ForMessage(34u, FUStPartHitAttrRecoverConfig.Parser);

	private readonly RepeatedField<FUStPartHitAttrRecoverConfig> partHitAttrRecoverList_ = new RepeatedField<FUStPartHitAttrRecoverConfig>();

	private string guard_ = "";

	public static MessageParser<FUStPartHitExpandDesc> Parser => _parser;

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

	public RepeatedField<FUStPartHitAttrRecoverConfig> PartHitAttrRecoverList => partHitAttrRecoverList_;

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

	public FUStPartHitExpandDesc()
	{
	}

	public FUStPartHitExpandDesc(FUStPartHitExpandDesc other)
		: this()
	{
		iD_ = other.iD_;
		partRuleID_ = other.partRuleID_;
		partID_ = other.partID_;
		partHitAttrRecoverList_ = other.partHitAttrRecoverList_.Clone();
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPartHitExpandDesc Clone()
	{
		return new FUStPartHitExpandDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPartHitExpandDesc);
	}

	public bool Equals(FUStPartHitExpandDesc other)
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
		if (PartRuleID != other.PartRuleID)
		{
			return false;
		}
		if (PartID != other.PartID)
		{
			return false;
		}
		if (!partHitAttrRecoverList_.Equals(other.partHitAttrRecoverList_))
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
		if (PartRuleID != 0)
		{
			num ^= PartRuleID.GetHashCode();
		}
		if (PartID != 0)
		{
			num ^= PartID.GetHashCode();
		}
		num ^= partHitAttrRecoverList_.GetHashCode();
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
		if (PartRuleID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PartRuleID);
		}
		if (PartID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PartID);
		}
		partHitAttrRecoverList_.WriteTo(output, _repeated_partHitAttrRecoverList_codec);
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
		if (PartRuleID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PartRuleID);
		}
		if (PartID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PartID);
		}
		num += partHitAttrRecoverList_.CalculateSize(_repeated_partHitAttrRecoverList_codec);
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

	public void MergeFrom(FUStPartHitExpandDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.PartRuleID != 0)
			{
				PartRuleID = other.PartRuleID;
			}
			if (other.PartID != 0)
			{
				PartID = other.PartID;
			}
			partHitAttrRecoverList_.Add(other.partHitAttrRecoverList_);
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
				PartRuleID = input.ReadInt32();
				break;
			case 24u:
				PartID = input.ReadInt32();
				break;
			case 34u:
				partHitAttrRecoverList_.AddEntriesFrom(input, _repeated_partHitAttrRecoverList_codec);
				break;
			case 42u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
