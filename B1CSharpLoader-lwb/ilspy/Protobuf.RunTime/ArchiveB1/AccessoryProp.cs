using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class AccessoryProp : IMessage<AccessoryProp>, IMessage, IEquatable<AccessoryProp>, IDeepCloneable<AccessoryProp>
{
	private static readonly MessageParser<AccessoryProp> _parser = new MessageParser<AccessoryProp>(() => new AccessoryProp());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private ulong uid_;

	private int pos_;

	public static MessageParser<AccessoryProp> Parser => _parser;

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

	public int Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	public AccessoryProp()
	{
	}

	public AccessoryProp(AccessoryProp other)
		: this()
	{
		id_ = other.id_;
		uid_ = other.uid_;
		pos_ = other.pos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AccessoryProp Clone()
	{
		return new AccessoryProp(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AccessoryProp);
	}

	public bool Equals(AccessoryProp other)
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
		if (Uid != other.Uid)
		{
			return false;
		}
		if (Pos != other.Pos)
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
		if (Uid != 0L)
		{
			num ^= Uid.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
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
		if (Uid != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Uid);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Pos);
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
		if (Uid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Uid);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Pos);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AccessoryProp other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Uid != 0L)
			{
				Uid = other.Uid;
			}
			if (other.Pos != 0)
			{
				Pos = other.Pos;
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
				Uid = input.ReadUInt64();
				break;
			case 24u:
				Pos = input.ReadInt32();
				break;
			}
		}
	}
}
