using System;
using Google.Protobuf;

namespace ResB1;

public sealed class MantraWeightDesc : IMessage<MantraWeightDesc>, IMessage, IEquatable<MantraWeightDesc>, IDeepCloneable<MantraWeightDesc>
{
	private static readonly MessageParser<MantraWeightDesc> _parser = new MessageParser<MantraWeightDesc>(() => new MantraWeightDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int luckValueMin_;

	private int luckValueMax_;

	private int greyMantraWeight_;

	private int greenMantraWeight_;

	private int blueMantraWeight_;

	private int purpleMantraWeight_;

	private int orangeMantraWeight_;

	private int redMantraWeight_;

	public static MessageParser<MantraWeightDesc> Parser => _parser;

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

	public int LuckValueMin
	{
		get
		{
			return luckValueMin_;
		}
		set
		{
			luckValueMin_ = value;
		}
	}

	public int LuckValueMax
	{
		get
		{
			return luckValueMax_;
		}
		set
		{
			luckValueMax_ = value;
		}
	}

	public int GreyMantraWeight
	{
		get
		{
			return greyMantraWeight_;
		}
		set
		{
			greyMantraWeight_ = value;
		}
	}

	public int GreenMantraWeight
	{
		get
		{
			return greenMantraWeight_;
		}
		set
		{
			greenMantraWeight_ = value;
		}
	}

	public int BlueMantraWeight
	{
		get
		{
			return blueMantraWeight_;
		}
		set
		{
			blueMantraWeight_ = value;
		}
	}

	public int PurpleMantraWeight
	{
		get
		{
			return purpleMantraWeight_;
		}
		set
		{
			purpleMantraWeight_ = value;
		}
	}

	public int OrangeMantraWeight
	{
		get
		{
			return orangeMantraWeight_;
		}
		set
		{
			orangeMantraWeight_ = value;
		}
	}

	public int RedMantraWeight
	{
		get
		{
			return redMantraWeight_;
		}
		set
		{
			redMantraWeight_ = value;
		}
	}

	public MantraWeightDesc()
	{
	}

	public MantraWeightDesc(MantraWeightDesc other)
		: this()
	{
		id_ = other.id_;
		luckValueMin_ = other.luckValueMin_;
		luckValueMax_ = other.luckValueMax_;
		greyMantraWeight_ = other.greyMantraWeight_;
		greenMantraWeight_ = other.greenMantraWeight_;
		blueMantraWeight_ = other.blueMantraWeight_;
		purpleMantraWeight_ = other.purpleMantraWeight_;
		orangeMantraWeight_ = other.orangeMantraWeight_;
		redMantraWeight_ = other.redMantraWeight_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MantraWeightDesc Clone()
	{
		return new MantraWeightDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MantraWeightDesc);
	}

	public bool Equals(MantraWeightDesc other)
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
		if (LuckValueMin != other.LuckValueMin)
		{
			return false;
		}
		if (LuckValueMax != other.LuckValueMax)
		{
			return false;
		}
		if (GreyMantraWeight != other.GreyMantraWeight)
		{
			return false;
		}
		if (GreenMantraWeight != other.GreenMantraWeight)
		{
			return false;
		}
		if (BlueMantraWeight != other.BlueMantraWeight)
		{
			return false;
		}
		if (PurpleMantraWeight != other.PurpleMantraWeight)
		{
			return false;
		}
		if (OrangeMantraWeight != other.OrangeMantraWeight)
		{
			return false;
		}
		if (RedMantraWeight != other.RedMantraWeight)
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
		if (LuckValueMin != 0)
		{
			num ^= LuckValueMin.GetHashCode();
		}
		if (LuckValueMax != 0)
		{
			num ^= LuckValueMax.GetHashCode();
		}
		if (GreyMantraWeight != 0)
		{
			num ^= GreyMantraWeight.GetHashCode();
		}
		if (GreenMantraWeight != 0)
		{
			num ^= GreenMantraWeight.GetHashCode();
		}
		if (BlueMantraWeight != 0)
		{
			num ^= BlueMantraWeight.GetHashCode();
		}
		if (PurpleMantraWeight != 0)
		{
			num ^= PurpleMantraWeight.GetHashCode();
		}
		if (OrangeMantraWeight != 0)
		{
			num ^= OrangeMantraWeight.GetHashCode();
		}
		if (RedMantraWeight != 0)
		{
			num ^= RedMantraWeight.GetHashCode();
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
		if (LuckValueMin != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LuckValueMin);
		}
		if (LuckValueMax != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LuckValueMax);
		}
		if (GreyMantraWeight != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GreyMantraWeight);
		}
		if (GreenMantraWeight != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GreenMantraWeight);
		}
		if (BlueMantraWeight != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BlueMantraWeight);
		}
		if (PurpleMantraWeight != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(PurpleMantraWeight);
		}
		if (OrangeMantraWeight != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(OrangeMantraWeight);
		}
		if (RedMantraWeight != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(RedMantraWeight);
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
		if (LuckValueMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LuckValueMin);
		}
		if (LuckValueMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LuckValueMax);
		}
		if (GreyMantraWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GreyMantraWeight);
		}
		if (GreenMantraWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GreenMantraWeight);
		}
		if (BlueMantraWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BlueMantraWeight);
		}
		if (PurpleMantraWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PurpleMantraWeight);
		}
		if (OrangeMantraWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OrangeMantraWeight);
		}
		if (RedMantraWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RedMantraWeight);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MantraWeightDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LuckValueMin != 0)
			{
				LuckValueMin = other.LuckValueMin;
			}
			if (other.LuckValueMax != 0)
			{
				LuckValueMax = other.LuckValueMax;
			}
			if (other.GreyMantraWeight != 0)
			{
				GreyMantraWeight = other.GreyMantraWeight;
			}
			if (other.GreenMantraWeight != 0)
			{
				GreenMantraWeight = other.GreenMantraWeight;
			}
			if (other.BlueMantraWeight != 0)
			{
				BlueMantraWeight = other.BlueMantraWeight;
			}
			if (other.PurpleMantraWeight != 0)
			{
				PurpleMantraWeight = other.PurpleMantraWeight;
			}
			if (other.OrangeMantraWeight != 0)
			{
				OrangeMantraWeight = other.OrangeMantraWeight;
			}
			if (other.RedMantraWeight != 0)
			{
				RedMantraWeight = other.RedMantraWeight;
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
				LuckValueMin = input.ReadInt32();
				break;
			case 24u:
				LuckValueMax = input.ReadInt32();
				break;
			case 32u:
				GreyMantraWeight = input.ReadInt32();
				break;
			case 40u:
				GreenMantraWeight = input.ReadInt32();
				break;
			case 48u:
				BlueMantraWeight = input.ReadInt32();
				break;
			case 56u:
				PurpleMantraWeight = input.ReadInt32();
				break;
			case 64u:
				OrangeMantraWeight = input.ReadInt32();
				break;
			case 72u:
				RedMantraWeight = input.ReadInt32();
				break;
			}
		}
	}
}
