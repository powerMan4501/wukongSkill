using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class ItemRecipeDesc : IMessage<ItemRecipeDesc>, IMessage, IEquatable<ItemRecipeDesc>, IDeepCloneable<ItemRecipeDesc>
{
	private static readonly MessageParser<ItemRecipeDesc> _parser = new MessageParser<ItemRecipeDesc>(() => new ItemRecipeDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private ItemOne targetItem_;

	private int successRate_;

	private static readonly FieldCodec<ItemOne> _repeated_materialList_codec = FieldCodec.ForMessage(34u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> materialList_ = new RepeatedField<ItemOne>();

	private YesNoType isAttrItem_;

	private int costMoney_;

	private int keyItemId_;

	private int keyItemNum_;

	public static MessageParser<ItemRecipeDesc> Parser => _parser;

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

	public ItemOne TargetItem
	{
		get
		{
			return targetItem_;
		}
		set
		{
			targetItem_ = value;
		}
	}

	public int SuccessRate
	{
		get
		{
			return successRate_;
		}
		set
		{
			successRate_ = value;
		}
	}

	public RepeatedField<ItemOne> MaterialList => materialList_;

	public YesNoType IsAttrItem
	{
		get
		{
			return isAttrItem_;
		}
		set
		{
			isAttrItem_ = value;
		}
	}

	public int CostMoney
	{
		get
		{
			return costMoney_;
		}
		set
		{
			costMoney_ = value;
		}
	}

	public int KeyItemId
	{
		get
		{
			return keyItemId_;
		}
		set
		{
			keyItemId_ = value;
		}
	}

	public int KeyItemNum
	{
		get
		{
			return keyItemNum_;
		}
		set
		{
			keyItemNum_ = value;
		}
	}

	public ItemRecipeDesc()
	{
	}

	public ItemRecipeDesc(ItemRecipeDesc other)
		: this()
	{
		id_ = other.id_;
		targetItem_ = ((other.targetItem_ != null) ? other.targetItem_.Clone() : null);
		successRate_ = other.successRate_;
		materialList_ = other.materialList_.Clone();
		isAttrItem_ = other.isAttrItem_;
		costMoney_ = other.costMoney_;
		keyItemId_ = other.keyItemId_;
		keyItemNum_ = other.keyItemNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ItemRecipeDesc Clone()
	{
		return new ItemRecipeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ItemRecipeDesc);
	}

	public bool Equals(ItemRecipeDesc other)
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
		if (!object.Equals(TargetItem, other.TargetItem))
		{
			return false;
		}
		if (SuccessRate != other.SuccessRate)
		{
			return false;
		}
		if (!materialList_.Equals(other.materialList_))
		{
			return false;
		}
		if (IsAttrItem != other.IsAttrItem)
		{
			return false;
		}
		if (CostMoney != other.CostMoney)
		{
			return false;
		}
		if (KeyItemId != other.KeyItemId)
		{
			return false;
		}
		if (KeyItemNum != other.KeyItemNum)
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
		if (targetItem_ != null)
		{
			num ^= TargetItem.GetHashCode();
		}
		if (SuccessRate != 0)
		{
			num ^= SuccessRate.GetHashCode();
		}
		num ^= materialList_.GetHashCode();
		if (IsAttrItem != YesNoType.No)
		{
			num ^= IsAttrItem.GetHashCode();
		}
		if (CostMoney != 0)
		{
			num ^= CostMoney.GetHashCode();
		}
		if (KeyItemId != 0)
		{
			num ^= KeyItemId.GetHashCode();
		}
		if (KeyItemNum != 0)
		{
			num ^= KeyItemNum.GetHashCode();
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
		if (targetItem_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(TargetItem);
		}
		if (SuccessRate != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SuccessRate);
		}
		materialList_.WriteTo(output, _repeated_materialList_codec);
		if (IsAttrItem != YesNoType.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsAttrItem);
		}
		if (CostMoney != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(CostMoney);
		}
		if (KeyItemId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(KeyItemId);
		}
		if (KeyItemNum != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(KeyItemNum);
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
		if (targetItem_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetItem);
		}
		if (SuccessRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuccessRate);
		}
		num += materialList_.CalculateSize(_repeated_materialList_codec);
		if (IsAttrItem != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsAttrItem);
		}
		if (CostMoney != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostMoney);
		}
		if (KeyItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KeyItemId);
		}
		if (KeyItemNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KeyItemNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ItemRecipeDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.targetItem_ != null)
		{
			if (targetItem_ == null)
			{
				TargetItem = new ItemOne();
			}
			TargetItem.MergeFrom(other.TargetItem);
		}
		if (other.SuccessRate != 0)
		{
			SuccessRate = other.SuccessRate;
		}
		materialList_.Add(other.materialList_);
		if (other.IsAttrItem != YesNoType.No)
		{
			IsAttrItem = other.IsAttrItem;
		}
		if (other.CostMoney != 0)
		{
			CostMoney = other.CostMoney;
		}
		if (other.KeyItemId != 0)
		{
			KeyItemId = other.KeyItemId;
		}
		if (other.KeyItemNum != 0)
		{
			KeyItemNum = other.KeyItemNum;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (targetItem_ == null)
				{
					TargetItem = new ItemOne();
				}
				input.ReadMessage(TargetItem);
				break;
			case 24u:
				SuccessRate = input.ReadInt32();
				break;
			case 34u:
				materialList_.AddEntriesFrom(input, _repeated_materialList_codec);
				break;
			case 40u:
				IsAttrItem = (YesNoType)input.ReadEnum();
				break;
			case 48u:
				CostMoney = input.ReadInt32();
				break;
			case 56u:
				KeyItemId = input.ReadInt32();
				break;
			case 64u:
				KeyItemNum = input.ReadInt32();
				break;
			}
		}
	}
}
