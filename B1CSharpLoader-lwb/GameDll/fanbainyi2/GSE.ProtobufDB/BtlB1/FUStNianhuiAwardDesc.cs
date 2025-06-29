using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStNianhuiAwardDesc : IMessage<FUStNianhuiAwardDesc>, IMessage, IEquatable<FUStNianhuiAwardDesc>, IDeepCloneable<FUStNianhuiAwardDesc>
{
	private static readonly MessageParser<FUStNianhuiAwardDesc> _parser = new MessageParser<FUStNianhuiAwardDesc>(() => new FUStNianhuiAwardDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string awardName_ = "";

	private int awardLevel_;

	private string awardImage_ = "";

	private float dropItemScale_;

	private string dropItemColor_ = "";

	private string dropItemNameColor_ = "";

	private string dropItemFixedEffect_ = "";

	private string dropItemSpawnEffect_ = "";

	private string dropItemLightEffect_ = "";

	private string dropSound_ = "";

	public static MessageParser<FUStNianhuiAwardDesc> Parser => _parser;

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

	public int AwardLevel
	{
		get
		{
			return awardLevel_;
		}
		set
		{
			awardLevel_ = value;
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

	public float DropItemScale
	{
		get
		{
			return dropItemScale_;
		}
		set
		{
			dropItemScale_ = value;
		}
	}

	public string DropItemColor
	{
		get
		{
			return dropItemColor_;
		}
		set
		{
			dropItemColor_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DropItemNameColor
	{
		get
		{
			return dropItemNameColor_;
		}
		set
		{
			dropItemNameColor_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DropItemFixedEffect
	{
		get
		{
			return dropItemFixedEffect_;
		}
		set
		{
			dropItemFixedEffect_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DropItemSpawnEffect
	{
		get
		{
			return dropItemSpawnEffect_;
		}
		set
		{
			dropItemSpawnEffect_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DropItemLightEffect
	{
		get
		{
			return dropItemLightEffect_;
		}
		set
		{
			dropItemLightEffect_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DropSound
	{
		get
		{
			return dropSound_;
		}
		set
		{
			dropSound_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStNianhuiAwardDesc()
	{
	}

	public FUStNianhuiAwardDesc(FUStNianhuiAwardDesc other)
		: this()
	{
		iD_ = other.iD_;
		awardName_ = other.awardName_;
		awardLevel_ = other.awardLevel_;
		awardImage_ = other.awardImage_;
		dropItemScale_ = other.dropItemScale_;
		dropItemColor_ = other.dropItemColor_;
		dropItemNameColor_ = other.dropItemNameColor_;
		dropItemFixedEffect_ = other.dropItemFixedEffect_;
		dropItemSpawnEffect_ = other.dropItemSpawnEffect_;
		dropItemLightEffect_ = other.dropItemLightEffect_;
		dropSound_ = other.dropSound_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStNianhuiAwardDesc Clone()
	{
		return new FUStNianhuiAwardDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStNianhuiAwardDesc);
	}

	public bool Equals(FUStNianhuiAwardDesc other)
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
		if (AwardName != other.AwardName)
		{
			return false;
		}
		if (AwardLevel != other.AwardLevel)
		{
			return false;
		}
		if (AwardImage != other.AwardImage)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DropItemScale, other.DropItemScale))
		{
			return false;
		}
		if (DropItemColor != other.DropItemColor)
		{
			return false;
		}
		if (DropItemNameColor != other.DropItemNameColor)
		{
			return false;
		}
		if (DropItemFixedEffect != other.DropItemFixedEffect)
		{
			return false;
		}
		if (DropItemSpawnEffect != other.DropItemSpawnEffect)
		{
			return false;
		}
		if (DropItemLightEffect != other.DropItemLightEffect)
		{
			return false;
		}
		if (DropSound != other.DropSound)
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
		if (AwardName.Length != 0)
		{
			num ^= AwardName.GetHashCode();
		}
		if (AwardLevel != 0)
		{
			num ^= AwardLevel.GetHashCode();
		}
		if (AwardImage.Length != 0)
		{
			num ^= AwardImage.GetHashCode();
		}
		if (DropItemScale != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DropItemScale);
		}
		if (DropItemColor.Length != 0)
		{
			num ^= DropItemColor.GetHashCode();
		}
		if (DropItemNameColor.Length != 0)
		{
			num ^= DropItemNameColor.GetHashCode();
		}
		if (DropItemFixedEffect.Length != 0)
		{
			num ^= DropItemFixedEffect.GetHashCode();
		}
		if (DropItemSpawnEffect.Length != 0)
		{
			num ^= DropItemSpawnEffect.GetHashCode();
		}
		if (DropItemLightEffect.Length != 0)
		{
			num ^= DropItemLightEffect.GetHashCode();
		}
		if (DropSound.Length != 0)
		{
			num ^= DropSound.GetHashCode();
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
		if (AwardName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AwardName);
		}
		if (AwardLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AwardLevel);
		}
		if (AwardImage.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(AwardImage);
		}
		if (DropItemScale != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(DropItemScale);
		}
		if (DropItemColor.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(DropItemColor);
		}
		if (DropItemNameColor.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(DropItemNameColor);
		}
		if (DropItemFixedEffect.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(DropItemFixedEffect);
		}
		if (DropItemSpawnEffect.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(DropItemSpawnEffect);
		}
		if (DropItemLightEffect.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(DropItemLightEffect);
		}
		if (DropSound.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(DropSound);
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
		if (AwardName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AwardName);
		}
		if (AwardLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AwardLevel);
		}
		if (AwardImage.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AwardImage);
		}
		if (DropItemScale != 0f)
		{
			num += 5;
		}
		if (DropItemColor.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DropItemColor);
		}
		if (DropItemNameColor.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DropItemNameColor);
		}
		if (DropItemFixedEffect.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DropItemFixedEffect);
		}
		if (DropItemSpawnEffect.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DropItemSpawnEffect);
		}
		if (DropItemLightEffect.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DropItemLightEffect);
		}
		if (DropSound.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DropSound);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStNianhuiAwardDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.AwardName.Length != 0)
			{
				AwardName = other.AwardName;
			}
			if (other.AwardLevel != 0)
			{
				AwardLevel = other.AwardLevel;
			}
			if (other.AwardImage.Length != 0)
			{
				AwardImage = other.AwardImage;
			}
			if (other.DropItemScale != 0f)
			{
				DropItemScale = other.DropItemScale;
			}
			if (other.DropItemColor.Length != 0)
			{
				DropItemColor = other.DropItemColor;
			}
			if (other.DropItemNameColor.Length != 0)
			{
				DropItemNameColor = other.DropItemNameColor;
			}
			if (other.DropItemFixedEffect.Length != 0)
			{
				DropItemFixedEffect = other.DropItemFixedEffect;
			}
			if (other.DropItemSpawnEffect.Length != 0)
			{
				DropItemSpawnEffect = other.DropItemSpawnEffect;
			}
			if (other.DropItemLightEffect.Length != 0)
			{
				DropItemLightEffect = other.DropItemLightEffect;
			}
			if (other.DropSound.Length != 0)
			{
				DropSound = other.DropSound;
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
			case 18u:
				AwardName = input.ReadString();
				break;
			case 24u:
				AwardLevel = input.ReadInt32();
				break;
			case 34u:
				AwardImage = input.ReadString();
				break;
			case 45u:
				DropItemScale = input.ReadFloat();
				break;
			case 50u:
				DropItemColor = input.ReadString();
				break;
			case 58u:
				DropItemNameColor = input.ReadString();
				break;
			case 66u:
				DropItemFixedEffect = input.ReadString();
				break;
			case 74u:
				DropItemSpawnEffect = input.ReadString();
				break;
			case 82u:
				DropItemLightEffect = input.ReadString();
				break;
			case 90u:
				DropSound = input.ReadString();
				break;
			}
		}
	}
}
