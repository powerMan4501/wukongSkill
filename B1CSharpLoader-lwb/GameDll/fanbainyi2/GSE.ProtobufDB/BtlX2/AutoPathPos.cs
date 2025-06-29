using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class AutoPathPos : IMessage<AutoPathPos>, IMessage, IEquatable<AutoPathPos>, IDeepCloneable<AutoPathPos>
{
	private static readonly MessageParser<AutoPathPos> _parser = new MessageParser<AutoPathPos>(() => new AutoPathPos());

	private UnknownFieldSet _unknownFields;

	private int posX_;

	private int posY_;

	public static MessageParser<AutoPathPos> Parser => _parser;

	public int PosX
	{
		get
		{
			return posX_;
		}
		set
		{
			posX_ = value;
		}
	}

	public int PosY
	{
		get
		{
			return posY_;
		}
		set
		{
			posY_ = value;
		}
	}

	public AutoPathPos()
	{
	}

	public AutoPathPos(AutoPathPos other)
		: this()
	{
		posX_ = other.posX_;
		posY_ = other.posY_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AutoPathPos Clone()
	{
		return new AutoPathPos(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AutoPathPos);
	}

	public bool Equals(AutoPathPos other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PosX != other.PosX)
		{
			return false;
		}
		if (PosY != other.PosY)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PosX != 0)
		{
			num ^= PosX.GetHashCode();
		}
		if (PosY != 0)
		{
			num ^= PosY.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PosX != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PosX);
		}
		if (PosY != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PosY);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PosX != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PosX);
		}
		if (PosY != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PosY);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AutoPathPos other)
	{
		if (other != null)
		{
			if (other.PosX != 0)
			{
				PosX = other.PosX;
			}
			if (other.PosY != 0)
			{
				PosY = other.PosY;
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
				PosX = input.ReadInt32();
				break;
			case 16u:
				PosY = input.ReadInt32();
				break;
			}
		}
	}
}
