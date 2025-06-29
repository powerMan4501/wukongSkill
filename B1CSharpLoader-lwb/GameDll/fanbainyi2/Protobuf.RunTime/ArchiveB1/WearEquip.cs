using System;
using BtlB1;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class WearEquip : IMessage<WearEquip>, IMessage, IEquatable<WearEquip>, IDeepCloneable<WearEquip>
{
	private static readonly MessageParser<WearEquip> _parser = new MessageParser<WearEquip>(() => new WearEquip());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private EquipPosition position_;

	private ulong uid_;

	public static MessageParser<WearEquip> Parser => _parser;

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

	public EquipPosition Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	public ulong Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	public WearEquip()
	{
	}

	public WearEquip(WearEquip other)
		: this()
	{
		id_ = other.id_;
		position_ = other.position_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WearEquip Clone()
	{
		return new WearEquip(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WearEquip);
	}

	public bool Equals(WearEquip other)
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
		if (Position != other.Position)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		if (Position != EquipPosition.Head)
		{
			num ^= Position.GetHashCode();
		}
		if (Uid != 0L)
		{
			num ^= Uid.GetHashCode();
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
		if (Position != EquipPosition.Head)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Position);
		}
		if (Uid != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(Uid);
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
		if (Position != EquipPosition.Head)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Position);
		}
		if (Uid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WearEquip other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Position != EquipPosition.Head)
			{
				Position = other.Position;
			}
			if (other.Uid != 0L)
			{
				Uid = other.Uid;
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
				Position = (EquipPosition)input.ReadEnum();
				break;
			case 24u:
				Uid = input.ReadUInt64();
				break;
			}
		}
	}
}
