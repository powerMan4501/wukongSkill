using System;
using Google.Protobuf;

namespace OssB1;

public sealed class Spell : IMessage<Spell>, IMessage, IEquatable<Spell>, IDeepCloneable<Spell>
{
	private static readonly MessageParser<Spell> _parser = new MessageParser<Spell>(() => new Spell());

	private UnknownFieldSet _unknownFields;

	private int tp_;

	private int id_;

	public static MessageParser<Spell> Parser => _parser;

	public int Tp
	{
		get
		{
			return tp_;
		}
		set
		{
			tp_ = value;
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

	public Spell()
	{
	}

	public Spell(Spell other)
		: this()
	{
		tp_ = other.tp_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Spell Clone()
	{
		return new Spell(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Spell);
	}

	public bool Equals(Spell other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Tp != other.Tp)
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
		if (Tp != 0)
		{
			num ^= Tp.GetHashCode();
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
		if (Tp != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Tp);
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
		if (Tp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Tp);
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

	public void MergeFrom(Spell other)
	{
		if (other != null)
		{
			if (other.Tp != 0)
			{
				Tp = other.Tp;
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
				Tp = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			}
		}
	}
}
