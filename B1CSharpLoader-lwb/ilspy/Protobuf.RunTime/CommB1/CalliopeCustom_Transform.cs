using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_Transform : IMessage<CalliopeCustom_Transform>, IMessage, IEquatable<CalliopeCustom_Transform>, IDeepCloneable<CalliopeCustom_Transform>
{
	private static readonly MessageParser<CalliopeCustom_Transform> _parser = new MessageParser<CalliopeCustom_Transform>(() => new CalliopeCustom_Transform());

	private UnknownFieldSet _unknownFields;

	private float transformX_;

	private float transformY_;

	private float transformZ_;

	private float transformPitch_;

	private float transformYaw_;

	private float transformRoll_;

	private float transformSx_;

	private float transformSy_;

	private float transformSz_;

	public static MessageParser<CalliopeCustom_Transform> Parser => _parser;

	public float TransformX
	{
		get
		{
			return transformX_;
		}
		set
		{
			transformX_ = value;
		}
	}

	public float TransformY
	{
		get
		{
			return transformY_;
		}
		set
		{
			transformY_ = value;
		}
	}

	public float TransformZ
	{
		get
		{
			return transformZ_;
		}
		set
		{
			transformZ_ = value;
		}
	}

	public float TransformPitch
	{
		get
		{
			return transformPitch_;
		}
		set
		{
			transformPitch_ = value;
		}
	}

	public float TransformYaw
	{
		get
		{
			return transformYaw_;
		}
		set
		{
			transformYaw_ = value;
		}
	}

	public float TransformRoll
	{
		get
		{
			return transformRoll_;
		}
		set
		{
			transformRoll_ = value;
		}
	}

	public float TransformSx
	{
		get
		{
			return transformSx_;
		}
		set
		{
			transformSx_ = value;
		}
	}

	public float TransformSy
	{
		get
		{
			return transformSy_;
		}
		set
		{
			transformSy_ = value;
		}
	}

	public float TransformSz
	{
		get
		{
			return transformSz_;
		}
		set
		{
			transformSz_ = value;
		}
	}

	public CalliopeCustom_Transform()
	{
	}

	public CalliopeCustom_Transform(CalliopeCustom_Transform other)
		: this()
	{
		transformX_ = other.transformX_;
		transformY_ = other.transformY_;
		transformZ_ = other.transformZ_;
		transformPitch_ = other.transformPitch_;
		transformYaw_ = other.transformYaw_;
		transformRoll_ = other.transformRoll_;
		transformSx_ = other.transformSx_;
		transformSy_ = other.transformSy_;
		transformSz_ = other.transformSz_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_Transform Clone()
	{
		return new CalliopeCustom_Transform(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_Transform);
	}

	public bool Equals(CalliopeCustom_Transform other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransformX, other.TransformX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransformY, other.TransformY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransformZ, other.TransformZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransformPitch, other.TransformPitch))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransformYaw, other.TransformYaw))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransformRoll, other.TransformRoll))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransformSx, other.TransformSx))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransformSy, other.TransformSy))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransformSz, other.TransformSz))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TransformX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransformX);
		}
		if (TransformY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransformY);
		}
		if (TransformZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransformZ);
		}
		if (TransformPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransformPitch);
		}
		if (TransformYaw != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransformYaw);
		}
		if (TransformRoll != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransformRoll);
		}
		if (TransformSx != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransformSx);
		}
		if (TransformSy != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransformSy);
		}
		if (TransformSz != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransformSz);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TransformX != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(TransformX);
		}
		if (TransformY != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(TransformY);
		}
		if (TransformZ != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(TransformZ);
		}
		if (TransformPitch != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(TransformPitch);
		}
		if (TransformYaw != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(TransformYaw);
		}
		if (TransformRoll != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(TransformRoll);
		}
		if (TransformSx != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(TransformSx);
		}
		if (TransformSy != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(TransformSy);
		}
		if (TransformSz != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(TransformSz);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TransformX != 0f)
		{
			num += 5;
		}
		if (TransformY != 0f)
		{
			num += 5;
		}
		if (TransformZ != 0f)
		{
			num += 5;
		}
		if (TransformPitch != 0f)
		{
			num += 5;
		}
		if (TransformYaw != 0f)
		{
			num += 5;
		}
		if (TransformRoll != 0f)
		{
			num += 5;
		}
		if (TransformSx != 0f)
		{
			num += 5;
		}
		if (TransformSy != 0f)
		{
			num += 5;
		}
		if (TransformSz != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_Transform other)
	{
		if (other != null)
		{
			if (other.TransformX != 0f)
			{
				TransformX = other.TransformX;
			}
			if (other.TransformY != 0f)
			{
				TransformY = other.TransformY;
			}
			if (other.TransformZ != 0f)
			{
				TransformZ = other.TransformZ;
			}
			if (other.TransformPitch != 0f)
			{
				TransformPitch = other.TransformPitch;
			}
			if (other.TransformYaw != 0f)
			{
				TransformYaw = other.TransformYaw;
			}
			if (other.TransformRoll != 0f)
			{
				TransformRoll = other.TransformRoll;
			}
			if (other.TransformSx != 0f)
			{
				TransformSx = other.TransformSx;
			}
			if (other.TransformSy != 0f)
			{
				TransformSy = other.TransformSy;
			}
			if (other.TransformSz != 0f)
			{
				TransformSz = other.TransformSz;
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
				TransformX = input.ReadFloat();
				break;
			case 21u:
				TransformY = input.ReadFloat();
				break;
			case 29u:
				TransformZ = input.ReadFloat();
				break;
			case 37u:
				TransformPitch = input.ReadFloat();
				break;
			case 45u:
				TransformYaw = input.ReadFloat();
				break;
			case 53u:
				TransformRoll = input.ReadFloat();
				break;
			case 61u:
				TransformSx = input.ReadFloat();
				break;
			case 69u:
				TransformSy = input.ReadFloat();
				break;
			case 77u:
				TransformSz = input.ReadFloat();
				break;
			}
		}
	}
}
