using System;
using Google.Protobuf;

namespace OssB1;

public sealed class Equip : IMessage<Equip>, IMessage, IEquatable<Equip>, IDeepCloneable<Equip>
{
	private static readonly MessageParser<Equip> _parser = new MessageParser<Equip>(() => new Equip());

	private UnknownFieldSet _unknownFields;

	private int pos_;

	private int id_;

	public static MessageParser<Equip> Parser => _parser;

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

	public Equip()
	{
	}

	public Equip(Equip other)
		: this()
	{
		pos_ = other.pos_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Equip Clone()
	{
		return new Equip(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Equip);
	}

	public bool Equals(Equip other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Pos != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Pos);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Pos);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Equip other)
	{
		if (other != null)
		{
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
				Pos = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			}
		}
	}
}
