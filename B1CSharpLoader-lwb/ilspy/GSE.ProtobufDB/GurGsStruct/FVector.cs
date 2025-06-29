using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class FVector : IMessage<FVector>, IMessage, IEquatable<FVector>, IDeepCloneable<FVector>
{
	private static readonly MessageParser<FVector> _parser = new MessageParser<FVector>(() => new FVector());

	private UnknownFieldSet _unknownFields;

	private float x_;

	private float y_;

	private float z_;

	public static MessageParser<FVector> Parser => _parser;

	public float X
	{
		get
		{
			return x_;
		}
		set
		{
			x_ = value;
		}
	}

	public float Y
	{
		get
		{
			return y_;
		}
		set
		{
			y_ = value;
		}
	}

	public float Z
	{
		get
		{
			return z_;
		}
		set
		{
			z_ = value;
		}
	}

	public FVector()
	{
	}

	public FVector(FVector other)
		: this()
	{
		x_ = other.x_;
		y_ = other.y_;
		z_ = other.z_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FVector Clone()
	{
		return new FVector(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FVector);
	}

	public bool Equals(FVector other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (X != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
		}
		if (Y != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
		}
		if (Z != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (X != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(X);
		}
		if (Y != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Y);
		}
		if (Z != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(Z);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (X != 0f)
		{
			num += 5;
		}
		if (Y != 0f)
		{
			num += 5;
		}
		if (Z != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FVector other)
	{
		if (other != null)
		{
			if (other.X != 0f)
			{
				X = other.X;
			}
			if (other.Y != 0f)
			{
				Y = other.Y;
			}
			if (other.Z != 0f)
			{
				Z = other.Z;
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
				X = input.ReadFloat();
				break;
			case 21u:
				Y = input.ReadFloat();
				break;
			case 29u:
				Z = input.ReadFloat();
				break;
			}
		}
	}
}
