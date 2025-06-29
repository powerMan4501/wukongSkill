using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ShopRefreshDesc : IMessage<ShopRefreshDesc>, IMessage, IEquatable<ShopRefreshDesc>, IDeepCloneable<ShopRefreshDesc>
{
	private static readonly MessageParser<ShopRefreshDesc> _parser = new MessageParser<ShopRefreshDesc>(() => new ShopRefreshDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int shopId_;

	private int groupId_;

	private ShopRefreshType refreshType_;

	private int limitGameCountMin_;

	private int limitGameCountMax_;

	public static MessageParser<ShopRefreshDesc> Parser => _parser;

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

	public int ShopId
	{
		get
		{
			return shopId_;
		}
		set
		{
			shopId_ = value;
		}
	}

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

	public ShopRefreshType RefreshType
	{
		get
		{
			return refreshType_;
		}
		set
		{
			refreshType_ = value;
		}
	}

	public int LimitGameCountMin
	{
		get
		{
			return limitGameCountMin_;
		}
		set
		{
			limitGameCountMin_ = value;
		}
	}

	public int LimitGameCountMax
	{
		get
		{
			return limitGameCountMax_;
		}
		set
		{
			limitGameCountMax_ = value;
		}
	}

	public ShopRefreshDesc()
	{
	}

	public ShopRefreshDesc(ShopRefreshDesc other)
		: this()
	{
		id_ = other.id_;
		shopId_ = other.shopId_;
		groupId_ = other.groupId_;
		refreshType_ = other.refreshType_;
		limitGameCountMin_ = other.limitGameCountMin_;
		limitGameCountMax_ = other.limitGameCountMax_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShopRefreshDesc Clone()
	{
		return new ShopRefreshDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShopRefreshDesc);
	}

	public bool Equals(ShopRefreshDesc other)
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
		if (ShopId != other.ShopId)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (RefreshType != other.RefreshType)
		{
			return false;
		}
		if (LimitGameCountMin != other.LimitGameCountMin)
		{
			return false;
		}
		if (LimitGameCountMax != other.LimitGameCountMax)
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
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (RefreshType != ShopRefreshType.Default)
		{
			num ^= RefreshType.GetHashCode();
		}
		if (LimitGameCountMin != 0)
		{
			num ^= LimitGameCountMin.GetHashCode();
		}
		if (LimitGameCountMax != 0)
		{
			num ^= LimitGameCountMax.GetHashCode();
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
		if (ShopId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ShopId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupId);
		}
		if (RefreshType != ShopRefreshType.Default)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)RefreshType);
		}
		if (LimitGameCountMin != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(LimitGameCountMin);
		}
		if (LimitGameCountMax != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LimitGameCountMax);
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
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (RefreshType != ShopRefreshType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RefreshType);
		}
		if (LimitGameCountMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitGameCountMin);
		}
		if (LimitGameCountMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitGameCountMax);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShopRefreshDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.RefreshType != ShopRefreshType.Default)
			{
				RefreshType = other.RefreshType;
			}
			if (other.LimitGameCountMin != 0)
			{
				LimitGameCountMin = other.LimitGameCountMin;
			}
			if (other.LimitGameCountMax != 0)
			{
				LimitGameCountMax = other.LimitGameCountMax;
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
				ShopId = input.ReadInt32();
				break;
			case 24u:
				GroupId = input.ReadInt32();
				break;
			case 32u:
				RefreshType = (ShopRefreshType)input.ReadEnum();
				break;
			case 40u:
				LimitGameCountMin = input.ReadInt32();
				break;
			case 48u:
				LimitGameCountMax = input.ReadInt32();
				break;
			}
		}
	}
}
