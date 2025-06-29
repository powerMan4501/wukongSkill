using System;
using Google.Protobuf;

namespace OssB1;

public sealed class SpellFire : IMessage<SpellFire>, IMessage, IEquatable<SpellFire>, IDeepCloneable<SpellFire>
{
	private static readonly MessageParser<SpellFire> _parser = new MessageParser<SpellFire>(() => new SpellFire());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int dist_;

	private int angle_;

	private int num_;

	public static MessageParser<SpellFire> Parser => _parser;

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

	public int Dist
	{
		get
		{
			return dist_;
		}
		set
		{
			dist_ = value;
		}
	}

	public int Angle
	{
		get
		{
			return angle_;
		}
		set
		{
			angle_ = value;
		}
	}

	public int Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	public SpellFire()
	{
	}

	public SpellFire(SpellFire other)
		: this()
	{
		id_ = other.id_;
		dist_ = other.dist_;
		angle_ = other.angle_;
		num_ = other.num_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SpellFire Clone()
	{
		return new SpellFire(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SpellFire);
	}

	public bool Equals(SpellFire other)
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
		if (Dist != other.Dist)
		{
			return false;
		}
		if (Angle != other.Angle)
		{
			return false;
		}
		if (Num != other.Num)
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
		if (Dist != 0)
		{
			num ^= Dist.GetHashCode();
		}
		if (Angle != 0)
		{
			num ^= Angle.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
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
		if (Dist != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Dist);
		}
		if (Angle != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Angle);
		}
		if (Num != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Num);
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
		if (Dist != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Dist);
		}
		if (Angle != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Angle);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Num);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SpellFire other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Dist != 0)
			{
				Dist = other.Dist;
			}
			if (other.Angle != 0)
			{
				Angle = other.Angle;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
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
				Dist = input.ReadInt32();
				break;
			case 24u:
				Angle = input.ReadInt32();
				break;
			case 32u:
				Num = input.ReadInt32();
				break;
			}
		}
	}
}
