using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class GmVector : IMessage<GmVector>, IMessage, IEquatable<GmVector>, IDeepCloneable<GmVector>
{
	private static readonly MessageParser<GmVector> _parser = new MessageParser<GmVector>(() => new GmVector());

	private UnknownFieldSet _unknownFields;

	private float posX_;

	private float posY_;

	private float posZ_;

	public static MessageParser<GmVector> Parser => _parser;

	public float PosX
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

	public float PosY
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

	public float PosZ
	{
		get
		{
			return posZ_;
		}
		set
		{
			posZ_ = value;
		}
	}

	public GmVector()
	{
	}

	public GmVector(GmVector other)
		: this()
	{
		posX_ = other.posX_;
		posY_ = other.posY_;
		posZ_ = other.posZ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GmVector Clone()
	{
		return new GmVector(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GmVector);
	}

	public bool Equals(GmVector other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosX, other.PosX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosY, other.PosY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosZ, other.PosZ))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PosX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosX);
		}
		if (PosY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosY);
		}
		if (PosZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosZ);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PosX != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(PosX);
		}
		if (PosY != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(PosY);
		}
		if (PosZ != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(PosZ);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PosX != 0f)
		{
			num += 5;
		}
		if (PosY != 0f)
		{
			num += 5;
		}
		if (PosZ != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GmVector other)
	{
		if (other != null)
		{
			if (other.PosX != 0f)
			{
				PosX = other.PosX;
			}
			if (other.PosY != 0f)
			{
				PosY = other.PosY;
			}
			if (other.PosZ != 0f)
			{
				PosZ = other.PosZ;
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
			case 13u:
				PosX = input.ReadFloat();
				break;
			case 21u:
				PosY = input.ReadFloat();
				break;
			case 29u:
				PosZ = input.ReadFloat();
				break;
			}
		}
	}
}
