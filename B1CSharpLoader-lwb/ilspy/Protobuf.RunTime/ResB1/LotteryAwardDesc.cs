using System;
using Google.Protobuf;

namespace ResB1;

public sealed class LotteryAwardDesc : IMessage<LotteryAwardDesc>, IMessage, IEquatable<LotteryAwardDesc>, IDeepCloneable<LotteryAwardDesc>
{
	private static readonly MessageParser<LotteryAwardDesc> _parser = new MessageParser<LotteryAwardDesc>(() => new LotteryAwardDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string awardName_ = "";

	private AwardQuality awardQuality_;

	private int num_;

	private string awardImage_ = "";

	private int itemId_;

	public static MessageParser<LotteryAwardDesc> Parser => _parser;

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

	public string AwardName
	{
		get
		{
			return awardName_;
		}
		set
		{
			awardName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public AwardQuality AwardQuality
	{
		get
		{
			return awardQuality_;
		}
		set
		{
			awardQuality_ = value;
		}
	}

	public int Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	public string AwardImage
	{
		get
		{
			return awardImage_;
		}
		set
		{
			awardImage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	public LotteryAwardDesc()
	{
	}

	public LotteryAwardDesc(LotteryAwardDesc other)
		: this()
	{
		id_ = other.id_;
		awardName_ = other.awardName_;
		awardQuality_ = other.awardQuality_;
		num_ = other.num_;
		awardImage_ = other.awardImage_;
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LotteryAwardDesc Clone()
	{
		return new LotteryAwardDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LotteryAwardDesc);
	}

	public bool Equals(LotteryAwardDesc other)
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
		if (AwardName != other.AwardName)
		{
			return false;
		}
		if (AwardQuality != other.AwardQuality)
		{
			return false;
		}
		if (Num != other.Num)
		{
			return false;
		}
		if (AwardImage != other.AwardImage)
		{
			return false;
		}
		if (ItemId != other.ItemId)
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
		if (AwardName.Length != 0)
		{
			num ^= AwardName.GetHashCode();
		}
		if (AwardQuality != AwardQuality.Happy)
		{
			num ^= AwardQuality.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (AwardImage.Length != 0)
		{
			num ^= AwardImage.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
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
		if (AwardName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AwardName);
		}
		if (AwardQuality != AwardQuality.Happy)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)AwardQuality);
		}
		if (Num != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Num);
		}
		if (AwardImage.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(AwardImage);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ItemId);
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
		if (AwardName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AwardName);
		}
		if (AwardQuality != AwardQuality.Happy)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AwardQuality);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Num);
		}
		if (AwardImage.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AwardImage);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LotteryAwardDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.AwardName.Length != 0)
			{
				AwardName = other.AwardName;
			}
			if (other.AwardQuality != AwardQuality.Happy)
			{
				AwardQuality = other.AwardQuality;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.AwardImage.Length != 0)
			{
				AwardImage = other.AwardImage;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
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
			case 18u:
				AwardName = input.ReadString();
				break;
			case 24u:
				AwardQuality = (AwardQuality)input.ReadEnum();
				break;
			case 32u:
				Num = input.ReadInt32();
				break;
			case 42u:
				AwardImage = input.ReadString();
				break;
			case 48u:
				ItemId = input.ReadInt32();
				break;
			}
		}
	}
}
