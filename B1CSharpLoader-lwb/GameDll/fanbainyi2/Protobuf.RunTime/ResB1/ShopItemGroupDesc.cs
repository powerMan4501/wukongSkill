using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ShopItemGroupDesc : IMessage<ShopItemGroupDesc>, IMessage, IEquatable<ShopItemGroupDesc>, IDeepCloneable<ShopItemGroupDesc>
{
	private static readonly MessageParser<ShopItemGroupDesc> _parser = new MessageParser<ShopItemGroupDesc>(() => new ShopItemGroupDesc());

	private UnknownFieldSet _unknownFields;

	private int groupId_;

	private int goodsId_;

	private int goodsNum_;

	public static MessageParser<ShopItemGroupDesc> Parser => _parser;

	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	public int GoodsId
	{
		get
		{
			return goodsId_;
		}
		set
		{
			goodsId_ = value;
		}
	}

	public int GoodsNum
	{
		get
		{
			return goodsNum_;
		}
		set
		{
			goodsNum_ = value;
		}
	}

	public ShopItemGroupDesc()
	{
	}

	public ShopItemGroupDesc(ShopItemGroupDesc other)
		: this()
	{
		groupId_ = other.groupId_;
		goodsId_ = other.goodsId_;
		goodsNum_ = other.goodsNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShopItemGroupDesc Clone()
	{
		return new ShopItemGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShopItemGroupDesc);
	}

	public bool Equals(ShopItemGroupDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (GoodsId != other.GoodsId)
		{
			return false;
		}
		if (GoodsNum != other.GoodsNum)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (GoodsId != 0)
		{
			num ^= GoodsId.GetHashCode();
		}
		if (GoodsNum != 0)
		{
			num ^= GoodsNum.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (GoodsId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GoodsId);
		}
		if (GoodsNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GoodsNum);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (GoodsId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GoodsId);
		}
		if (GoodsNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GoodsNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShopItemGroupDesc other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.GoodsId != 0)
			{
				GoodsId = other.GoodsId;
			}
			if (other.GoodsNum != 0)
			{
				GoodsNum = other.GoodsNum;
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
				GroupId = input.ReadInt32();
				break;
			case 16u:
				GoodsId = input.ReadInt32();
				break;
			case 24u:
				GoodsNum = input.ReadInt32();
				break;
			}
		}
	}
}
