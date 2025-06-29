using System;
using Google.Protobuf;

namespace ResB1;

public sealed class RoleDataConfigDesc : IMessage<RoleDataConfigDesc>, IMessage, IEquatable<RoleDataConfigDesc>, IDeepCloneable<RoleDataConfigDesc>
{
	private static readonly MessageParser<RoleDataConfigDesc> _parser = new MessageParser<RoleDataConfigDesc>(() => new RoleDataConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int group_;

	private RoleDataConfigItemType itemType_;

	private int itemId_;

	private int itemNum_;

	private YesNoType isWear_;

	private string desc_ = "";

	private int levelDesiredPlayerHp_;

	private int wearTargetId_;

	public static MessageParser<RoleDataConfigDesc> Parser => _parser;

	public int Group
	{
		get
		{
			return group_;
		}
		set
		{
			group_ = value;
		}
	}

	public RoleDataConfigItemType ItemType
	{
		get
		{
			return itemType_;
		}
		set
		{
			itemType_ = value;
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

	public int ItemNum
	{
		get
		{
			return itemNum_;
		}
		set
		{
			itemNum_ = value;
		}
	}

	public YesNoType IsWear
	{
		get
		{
			return isWear_;
		}
		set
		{
			isWear_ = value;
		}
	}

	public string Desc
	{
		get
		{
			return desc_;
		}
		set
		{
			desc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LevelDesiredPlayerHp
	{
		get
		{
			return levelDesiredPlayerHp_;
		}
		set
		{
			levelDesiredPlayerHp_ = value;
		}
	}

	public int WearTargetId
	{
		get
		{
			return wearTargetId_;
		}
		set
		{
			wearTargetId_ = value;
		}
	}

	public RoleDataConfigDesc()
	{
	}

	public RoleDataConfigDesc(RoleDataConfigDesc other)
		: this()
	{
		group_ = other.group_;
		itemType_ = other.itemType_;
		itemId_ = other.itemId_;
		itemNum_ = other.itemNum_;
		isWear_ = other.isWear_;
		desc_ = other.desc_;
		levelDesiredPlayerHp_ = other.levelDesiredPlayerHp_;
		wearTargetId_ = other.wearTargetId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataConfigDesc Clone()
	{
		return new RoleDataConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataConfigDesc);
	}

	public bool Equals(RoleDataConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Group != other.Group)
		{
			return false;
		}
		if (ItemType != other.ItemType)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (ItemNum != other.ItemNum)
		{
			return false;
		}
		if (IsWear != other.IsWear)
		{
			return false;
		}
		if (Desc != other.Desc)
		{
			return false;
		}
		if (LevelDesiredPlayerHp != other.LevelDesiredPlayerHp)
		{
			return false;
		}
		if (WearTargetId != other.WearTargetId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Group != 0)
		{
			num ^= Group.GetHashCode();
		}
		if (ItemType != RoleDataConfigItemType.None)
		{
			num ^= ItemType.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (ItemNum != 0)
		{
			num ^= ItemNum.GetHashCode();
		}
		if (IsWear != YesNoType.No)
		{
			num ^= IsWear.GetHashCode();
		}
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
		}
		if (LevelDesiredPlayerHp != 0)
		{
			num ^= LevelDesiredPlayerHp.GetHashCode();
		}
		if (WearTargetId != 0)
		{
			num ^= WearTargetId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Group != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Group);
		}
		if (ItemType != RoleDataConfigItemType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ItemType);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ItemId);
		}
		if (ItemNum != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ItemNum);
		}
		if (IsWear != YesNoType.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsWear);
		}
		if (Desc.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Desc);
		}
		if (LevelDesiredPlayerHp != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(LevelDesiredPlayerHp);
		}
		if (WearTargetId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(WearTargetId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Group != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Group);
		}
		if (ItemType != RoleDataConfigItemType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ItemType);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (ItemNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemNum);
		}
		if (IsWear != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsWear);
		}
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (LevelDesiredPlayerHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelDesiredPlayerHp);
		}
		if (WearTargetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WearTargetId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDataConfigDesc other)
	{
		if (other != null)
		{
			if (other.Group != 0)
			{
				Group = other.Group;
			}
			if (other.ItemType != RoleDataConfigItemType.None)
			{
				ItemType = other.ItemType;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.ItemNum != 0)
			{
				ItemNum = other.ItemNum;
			}
			if (other.IsWear != YesNoType.No)
			{
				IsWear = other.IsWear;
			}
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
			}
			if (other.LevelDesiredPlayerHp != 0)
			{
				LevelDesiredPlayerHp = other.LevelDesiredPlayerHp;
			}
			if (other.WearTargetId != 0)
			{
				WearTargetId = other.WearTargetId;
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
				Group = input.ReadInt32();
				break;
			case 16u:
				ItemType = (RoleDataConfigItemType)input.ReadEnum();
				break;
			case 24u:
				ItemId = input.ReadInt32();
				break;
			case 32u:
				ItemNum = input.ReadInt32();
				break;
			case 40u:
				IsWear = (YesNoType)input.ReadEnum();
				break;
			case 50u:
				Desc = input.ReadString();
				break;
			case 56u:
				LevelDesiredPlayerHp = input.ReadInt32();
				break;
			case 64u:
				WearTargetId = input.ReadInt32();
				break;
			}
		}
	}
}
