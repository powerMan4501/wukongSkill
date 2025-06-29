using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class ShopItemDesc : IMessage<ShopItemDesc>, IMessage, IEquatable<ShopItemDesc>, IDeepCloneable<ShopItemDesc>
{
	private static readonly MessageParser<ShopItemDesc> _parser = new MessageParser<ShopItemDesc>(() => new ShopItemDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int itemId_;

	private int sortId_;

	private static readonly FieldCodec<ItemOne> _repeated_costItem_codec = FieldCodec.ForMessage(34u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> costItem_ = new RepeatedField<ItemOne>();

	private YesNoType isLimitBuy_;

	private YesNoType isBatchSell_;

	private NumConfigType sellMoneyConfigType_;

	private int sellMoneyConfigValue_;

	private ShopNewGameResetType newGameResetType_;

	private ShopItemAppendType appendType_;

	private int limitAppendNum_;

	public static MessageParser<ShopItemDesc> Parser => _parser;

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

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public RepeatedField<ItemOne> CostItem => costItem_;

	public YesNoType IsLimitBuy
	{
		get
		{
			return isLimitBuy_;
		}
		set
		{
			isLimitBuy_ = value;
		}
	}

	public YesNoType IsBatchSell
	{
		get
		{
			return isBatchSell_;
		}
		set
		{
			isBatchSell_ = value;
		}
	}

	public NumConfigType SellMoneyConfigType
	{
		get
		{
			return sellMoneyConfigType_;
		}
		set
		{
			sellMoneyConfigType_ = value;
		}
	}

	public int SellMoneyConfigValue
	{
		get
		{
			return sellMoneyConfigValue_;
		}
		set
		{
			sellMoneyConfigValue_ = value;
		}
	}

	public ShopNewGameResetType NewGameResetType
	{
		get
		{
			return newGameResetType_;
		}
		set
		{
			newGameResetType_ = value;
		}
	}

	public ShopItemAppendType AppendType
	{
		get
		{
			return appendType_;
		}
		set
		{
			appendType_ = value;
		}
	}

	public int LimitAppendNum
	{
		get
		{
			return limitAppendNum_;
		}
		set
		{
			limitAppendNum_ = value;
		}
	}

	public ShopItemDesc()
	{
	}

	public ShopItemDesc(ShopItemDesc other)
		: this()
	{
		id_ = other.id_;
		itemId_ = other.itemId_;
		sortId_ = other.sortId_;
		costItem_ = other.costItem_.Clone();
		isLimitBuy_ = other.isLimitBuy_;
		isBatchSell_ = other.isBatchSell_;
		sellMoneyConfigType_ = other.sellMoneyConfigType_;
		sellMoneyConfigValue_ = other.sellMoneyConfigValue_;
		newGameResetType_ = other.newGameResetType_;
		appendType_ = other.appendType_;
		limitAppendNum_ = other.limitAppendNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShopItemDesc Clone()
	{
		return new ShopItemDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShopItemDesc);
	}

	public bool Equals(ShopItemDesc other)
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
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (!costItem_.Equals(other.costItem_))
		{
			return false;
		}
		if (IsLimitBuy != other.IsLimitBuy)
		{
			return false;
		}
		if (IsBatchSell != other.IsBatchSell)
		{
			return false;
		}
		if (SellMoneyConfigType != other.SellMoneyConfigType)
		{
			return false;
		}
		if (SellMoneyConfigValue != other.SellMoneyConfigValue)
		{
			return false;
		}
		if (NewGameResetType != other.NewGameResetType)
		{
			return false;
		}
		if (AppendType != other.AppendType)
		{
			return false;
		}
		if (LimitAppendNum != other.LimitAppendNum)
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
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		num ^= costItem_.GetHashCode();
		if (IsLimitBuy != YesNoType.No)
		{
			num ^= IsLimitBuy.GetHashCode();
		}
		if (IsBatchSell != YesNoType.No)
		{
			num ^= IsBatchSell.GetHashCode();
		}
		if (SellMoneyConfigType != NumConfigType.Default)
		{
			num ^= SellMoneyConfigType.GetHashCode();
		}
		if (SellMoneyConfigValue != 0)
		{
			num ^= SellMoneyConfigValue.GetHashCode();
		}
		if (NewGameResetType != ShopNewGameResetType.Default)
		{
			num ^= NewGameResetType.GetHashCode();
		}
		if (AppendType != ShopItemAppendType.Add)
		{
			num ^= AppendType.GetHashCode();
		}
		if (LimitAppendNum != 0)
		{
			num ^= LimitAppendNum.GetHashCode();
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
		if (ItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemId);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SortId);
		}
		costItem_.WriteTo(output, _repeated_costItem_codec);
		if (IsLimitBuy != YesNoType.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsLimitBuy);
		}
		if (IsBatchSell != YesNoType.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)IsBatchSell);
		}
		if (SellMoneyConfigType != NumConfigType.Default)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)SellMoneyConfigType);
		}
		if (SellMoneyConfigValue != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SellMoneyConfigValue);
		}
		if (NewGameResetType != ShopNewGameResetType.Default)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)NewGameResetType);
		}
		if (AppendType != ShopItemAppendType.Add)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)AppendType);
		}
		if (LimitAppendNum != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(LimitAppendNum);
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
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		num += costItem_.CalculateSize(_repeated_costItem_codec);
		if (IsLimitBuy != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsLimitBuy);
		}
		if (IsBatchSell != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsBatchSell);
		}
		if (SellMoneyConfigType != NumConfigType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SellMoneyConfigType);
		}
		if (SellMoneyConfigValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SellMoneyConfigValue);
		}
		if (NewGameResetType != ShopNewGameResetType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NewGameResetType);
		}
		if (AppendType != ShopItemAppendType.Add)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AppendType);
		}
		if (LimitAppendNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitAppendNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShopItemDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			costItem_.Add(other.costItem_);
			if (other.IsLimitBuy != YesNoType.No)
			{
				IsLimitBuy = other.IsLimitBuy;
			}
			if (other.IsBatchSell != YesNoType.No)
			{
				IsBatchSell = other.IsBatchSell;
			}
			if (other.SellMoneyConfigType != NumConfigType.Default)
			{
				SellMoneyConfigType = other.SellMoneyConfigType;
			}
			if (other.SellMoneyConfigValue != 0)
			{
				SellMoneyConfigValue = other.SellMoneyConfigValue;
			}
			if (other.NewGameResetType != ShopNewGameResetType.Default)
			{
				NewGameResetType = other.NewGameResetType;
			}
			if (other.AppendType != ShopItemAppendType.Add)
			{
				AppendType = other.AppendType;
			}
			if (other.LimitAppendNum != 0)
			{
				LimitAppendNum = other.LimitAppendNum;
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
				ItemId = input.ReadInt32();
				break;
			case 24u:
				SortId = input.ReadInt32();
				break;
			case 34u:
				costItem_.AddEntriesFrom(input, _repeated_costItem_codec);
				break;
			case 40u:
				IsLimitBuy = (YesNoType)input.ReadEnum();
				break;
			case 48u:
				IsBatchSell = (YesNoType)input.ReadEnum();
				break;
			case 56u:
				SellMoneyConfigType = (NumConfigType)input.ReadEnum();
				break;
			case 64u:
				SellMoneyConfigValue = input.ReadInt32();
				break;
			case 72u:
				NewGameResetType = (ShopNewGameResetType)input.ReadEnum();
				break;
			case 80u:
				AppendType = (ShopItemAppendType)input.ReadEnum();
				break;
			case 88u:
				LimitAppendNum = input.ReadInt32();
				break;
			}
		}
	}
}
