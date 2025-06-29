using System;
using Google.Protobuf;

namespace ResB1;

public sealed class CollectionDropDesc : IMessage<CollectionDropDesc>, IMessage, IEquatable<CollectionDropDesc>, IDeepCloneable<CollectionDropDesc>
{
	private static readonly MessageParser<CollectionDropDesc> _parser = new MessageParser<CollectionDropDesc>(() => new CollectionDropDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int dropLevel_;

	private int itemId_;

	private int dropRule_;

	private string dropEfx_ = "";

	private int dropId_;

	public static MessageParser<CollectionDropDesc> Parser => _parser;

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

	public int DropLevel
	{
		get
		{
			return dropLevel_;
		}
		set
		{
			dropLevel_ = value;
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

	public int DropRule
	{
		get
		{
			return dropRule_;
		}
		set
		{
			dropRule_ = value;
		}
	}

	public string DropEfx
	{
		get
		{
			return dropEfx_;
		}
		set
		{
			dropEfx_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DropId
	{
		get
		{
			return dropId_;
		}
		set
		{
			dropId_ = value;
		}
	}

	public CollectionDropDesc()
	{
	}

	public CollectionDropDesc(CollectionDropDesc other)
		: this()
	{
		id_ = other.id_;
		dropLevel_ = other.dropLevel_;
		itemId_ = other.itemId_;
		dropRule_ = other.dropRule_;
		dropEfx_ = other.dropEfx_;
		dropId_ = other.dropId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CollectionDropDesc Clone()
	{
		return new CollectionDropDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CollectionDropDesc);
	}

	public bool Equals(CollectionDropDesc other)
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
		if (DropLevel != other.DropLevel)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (DropRule != other.DropRule)
		{
			return false;
		}
		if (DropEfx != other.DropEfx)
		{
			return false;
		}
		if (DropId != other.DropId)
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
		if (DropLevel != 0)
		{
			num ^= DropLevel.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (DropRule != 0)
		{
			num ^= DropRule.GetHashCode();
		}
		if (DropEfx.Length != 0)
		{
			num ^= DropEfx.GetHashCode();
		}
		if (DropId != 0)
		{
			num ^= DropId.GetHashCode();
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
		if (DropLevel != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DropLevel);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ItemId);
		}
		if (DropRule != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DropRule);
		}
		if (DropEfx.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(DropEfx);
		}
		if (DropId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(DropId);
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
		if (DropLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropLevel);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (DropRule != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropRule);
		}
		if (DropEfx.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DropEfx);
		}
		if (DropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CollectionDropDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.DropLevel != 0)
			{
				DropLevel = other.DropLevel;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.DropRule != 0)
			{
				DropRule = other.DropRule;
			}
			if (other.DropEfx.Length != 0)
			{
				DropEfx = other.DropEfx;
			}
			if (other.DropId != 0)
			{
				DropId = other.DropId;
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
				DropLevel = input.ReadInt32();
				break;
			case 24u:
				ItemId = input.ReadInt32();
				break;
			case 32u:
				DropRule = input.ReadInt32();
				break;
			case 42u:
				DropEfx = input.ReadString();
				break;
			case 48u:
				DropId = input.ReadInt32();
				break;
			}
		}
	}
}
