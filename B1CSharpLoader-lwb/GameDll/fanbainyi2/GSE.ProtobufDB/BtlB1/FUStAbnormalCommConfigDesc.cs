using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAbnormalCommConfigDesc : IMessage<FUStAbnormalCommConfigDesc>, IMessage, IEquatable<FUStAbnormalCommConfigDesc>, IDeepCloneable<FUStAbnormalCommConfigDesc>
{
	private static readonly MessageParser<FUStAbnormalCommConfigDesc> _parser = new MessageParser<FUStAbnormalCommConfigDesc>(() => new FUStAbnormalCommConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int accMaxCalcKValue_;

	private int thresholdAbnormalDefToImmue_;

	private float accTriggerProcessAbnormalPercentFrozen_;

	private int accProcessBuffIDFrozen_;

	private float accTriggerProcessAbnormalPercentYin_;

	private int accProcessBuffIDYin_;

	private float accTriggerProcessAbnormalPercentYang_;

	private int accProcessBuffIDYang_;

	public static MessageParser<FUStAbnormalCommConfigDesc> Parser => _parser;

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

	public int AccMaxCalcKValue
	{
		get
		{
			return accMaxCalcKValue_;
		}
		set
		{
			accMaxCalcKValue_ = value;
		}
	}

	public int ThresholdAbnormalDefToImmue
	{
		get
		{
			return thresholdAbnormalDefToImmue_;
		}
		set
		{
			thresholdAbnormalDefToImmue_ = value;
		}
	}

	public float AccTriggerProcessAbnormalPercentFrozen
	{
		get
		{
			return accTriggerProcessAbnormalPercentFrozen_;
		}
		set
		{
			accTriggerProcessAbnormalPercentFrozen_ = value;
		}
	}

	public int AccProcessBuffIDFrozen
	{
		get
		{
			return accProcessBuffIDFrozen_;
		}
		set
		{
			accProcessBuffIDFrozen_ = value;
		}
	}

	public float AccTriggerProcessAbnormalPercentYin
	{
		get
		{
			return accTriggerProcessAbnormalPercentYin_;
		}
		set
		{
			accTriggerProcessAbnormalPercentYin_ = value;
		}
	}

	public int AccProcessBuffIDYin
	{
		get
		{
			return accProcessBuffIDYin_;
		}
		set
		{
			accProcessBuffIDYin_ = value;
		}
	}

	public float AccTriggerProcessAbnormalPercentYang
	{
		get
		{
			return accTriggerProcessAbnormalPercentYang_;
		}
		set
		{
			accTriggerProcessAbnormalPercentYang_ = value;
		}
	}

	public int AccProcessBuffIDYang
	{
		get
		{
			return accProcessBuffIDYang_;
		}
		set
		{
			accProcessBuffIDYang_ = value;
		}
	}

	public FUStAbnormalCommConfigDesc()
	{
	}

	public FUStAbnormalCommConfigDesc(FUStAbnormalCommConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		accMaxCalcKValue_ = other.accMaxCalcKValue_;
		thresholdAbnormalDefToImmue_ = other.thresholdAbnormalDefToImmue_;
		accTriggerProcessAbnormalPercentFrozen_ = other.accTriggerProcessAbnormalPercentFrozen_;
		accProcessBuffIDFrozen_ = other.accProcessBuffIDFrozen_;
		accTriggerProcessAbnormalPercentYin_ = other.accTriggerProcessAbnormalPercentYin_;
		accProcessBuffIDYin_ = other.accProcessBuffIDYin_;
		accTriggerProcessAbnormalPercentYang_ = other.accTriggerProcessAbnormalPercentYang_;
		accProcessBuffIDYang_ = other.accProcessBuffIDYang_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAbnormalCommConfigDesc Clone()
	{
		return new FUStAbnormalCommConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAbnormalCommConfigDesc);
	}

	public bool Equals(FUStAbnormalCommConfigDesc other)
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
		if (AccMaxCalcKValue != other.AccMaxCalcKValue)
		{
			return false;
		}
		if (ThresholdAbnormalDefToImmue != other.ThresholdAbnormalDefToImmue)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccTriggerProcessAbnormalPercentFrozen, other.AccTriggerProcessAbnormalPercentFrozen))
		{
			return false;
		}
		if (AccProcessBuffIDFrozen != other.AccProcessBuffIDFrozen)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccTriggerProcessAbnormalPercentYin, other.AccTriggerProcessAbnormalPercentYin))
		{
			return false;
		}
		if (AccProcessBuffIDYin != other.AccProcessBuffIDYin)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccTriggerProcessAbnormalPercentYang, other.AccTriggerProcessAbnormalPercentYang))
		{
			return false;
		}
		if (AccProcessBuffIDYang != other.AccProcessBuffIDYang)
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
		if (AccMaxCalcKValue != 0)
		{
			num ^= AccMaxCalcKValue.GetHashCode();
		}
		if (ThresholdAbnormalDefToImmue != 0)
		{
			num ^= ThresholdAbnormalDefToImmue.GetHashCode();
		}
		if (AccTriggerProcessAbnormalPercentFrozen != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccTriggerProcessAbnormalPercentFrozen);
		}
		if (AccProcessBuffIDFrozen != 0)
		{
			num ^= AccProcessBuffIDFrozen.GetHashCode();
		}
		if (AccTriggerProcessAbnormalPercentYin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccTriggerProcessAbnormalPercentYin);
		}
		if (AccProcessBuffIDYin != 0)
		{
			num ^= AccProcessBuffIDYin.GetHashCode();
		}
		if (AccTriggerProcessAbnormalPercentYang != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccTriggerProcessAbnormalPercentYang);
		}
		if (AccProcessBuffIDYang != 0)
		{
			num ^= AccProcessBuffIDYang.GetHashCode();
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
		if (AccMaxCalcKValue != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AccMaxCalcKValue);
		}
		if (ThresholdAbnormalDefToImmue != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ThresholdAbnormalDefToImmue);
		}
		if (AccTriggerProcessAbnormalPercentFrozen != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(AccTriggerProcessAbnormalPercentFrozen);
		}
		if (AccProcessBuffIDFrozen != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(AccProcessBuffIDFrozen);
		}
		if (AccTriggerProcessAbnormalPercentYin != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(AccTriggerProcessAbnormalPercentYin);
		}
		if (AccProcessBuffIDYin != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(AccProcessBuffIDYin);
		}
		if (AccTriggerProcessAbnormalPercentYang != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(AccTriggerProcessAbnormalPercentYang);
		}
		if (AccProcessBuffIDYang != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(AccProcessBuffIDYang);
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
		if (AccMaxCalcKValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AccMaxCalcKValue);
		}
		if (ThresholdAbnormalDefToImmue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ThresholdAbnormalDefToImmue);
		}
		if (AccTriggerProcessAbnormalPercentFrozen != 0f)
		{
			num += 5;
		}
		if (AccProcessBuffIDFrozen != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AccProcessBuffIDFrozen);
		}
		if (AccTriggerProcessAbnormalPercentYin != 0f)
		{
			num += 5;
		}
		if (AccProcessBuffIDYin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AccProcessBuffIDYin);
		}
		if (AccTriggerProcessAbnormalPercentYang != 0f)
		{
			num += 5;
		}
		if (AccProcessBuffIDYang != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AccProcessBuffIDYang);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAbnormalCommConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.AccMaxCalcKValue != 0)
			{
				AccMaxCalcKValue = other.AccMaxCalcKValue;
			}
			if (other.ThresholdAbnormalDefToImmue != 0)
			{
				ThresholdAbnormalDefToImmue = other.ThresholdAbnormalDefToImmue;
			}
			if (other.AccTriggerProcessAbnormalPercentFrozen != 0f)
			{
				AccTriggerProcessAbnormalPercentFrozen = other.AccTriggerProcessAbnormalPercentFrozen;
			}
			if (other.AccProcessBuffIDFrozen != 0)
			{
				AccProcessBuffIDFrozen = other.AccProcessBuffIDFrozen;
			}
			if (other.AccTriggerProcessAbnormalPercentYin != 0f)
			{
				AccTriggerProcessAbnormalPercentYin = other.AccTriggerProcessAbnormalPercentYin;
			}
			if (other.AccProcessBuffIDYin != 0)
			{
				AccProcessBuffIDYin = other.AccProcessBuffIDYin;
			}
			if (other.AccTriggerProcessAbnormalPercentYang != 0f)
			{
				AccTriggerProcessAbnormalPercentYang = other.AccTriggerProcessAbnormalPercentYang;
			}
			if (other.AccProcessBuffIDYang != 0)
			{
				AccProcessBuffIDYang = other.AccProcessBuffIDYang;
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
				AccMaxCalcKValue = input.ReadInt32();
				break;
			case 24u:
				ThresholdAbnormalDefToImmue = input.ReadInt32();
				break;
			case 37u:
				AccTriggerProcessAbnormalPercentFrozen = input.ReadFloat();
				break;
			case 40u:
				AccProcessBuffIDFrozen = input.ReadInt32();
				break;
			case 53u:
				AccTriggerProcessAbnormalPercentYin = input.ReadFloat();
				break;
			case 56u:
				AccProcessBuffIDYin = input.ReadInt32();
				break;
			case 69u:
				AccTriggerProcessAbnormalPercentYang = input.ReadFloat();
				break;
			case 72u:
				AccProcessBuffIDYang = input.ReadInt32();
				break;
			}
		}
	}
}
