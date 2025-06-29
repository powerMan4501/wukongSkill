using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_PerformerSetTransform : IMessage<MovieCustom_PerformerSetTransform>, IMessage, IEquatable<MovieCustom_PerformerSetTransform>, IDeepCloneable<MovieCustom_PerformerSetTransform>
{
	private static readonly MessageParser<MovieCustom_PerformerSetTransform> _parser = new MessageParser<MovieCustom_PerformerSetTransform>(() => new MovieCustom_PerformerSetTransform());

	private UnknownFieldSet _unknownFields;

	private string performerGuid_ = "";

	private float transformX_;

	private float transformY_;

	private float transformZ_;

	private float transformPitch_;

	private float transformYaw_;

	private float transformRoll_;

	private float transformSx_;

	private float transformSy_;

	private float transformSz_;

	private bool isPlayerAsPerformer_;

	public static MessageParser<MovieCustom_PerformerSetTransform> Parser => _parser;

	public string PerformerGuid
	{
		get
		{
			return performerGuid_;
		}
		set
		{
			performerGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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

	public bool IsPlayerAsPerformer
	{
		get
		{
			return isPlayerAsPerformer_;
		}
		set
		{
			isPlayerAsPerformer_ = value;
		}
	}

	public MovieCustom_PerformerSetTransform()
	{
	}

	public MovieCustom_PerformerSetTransform(MovieCustom_PerformerSetTransform other)
		: this()
	{
		performerGuid_ = other.performerGuid_;
		transformX_ = other.transformX_;
		transformY_ = other.transformY_;
		transformZ_ = other.transformZ_;
		transformPitch_ = other.transformPitch_;
		transformYaw_ = other.transformYaw_;
		transformRoll_ = other.transformRoll_;
		transformSx_ = other.transformSx_;
		transformSy_ = other.transformSy_;
		transformSz_ = other.transformSz_;
		isPlayerAsPerformer_ = other.isPlayerAsPerformer_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PerformerSetTransform Clone()
	{
		return new MovieCustom_PerformerSetTransform(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PerformerSetTransform);
	}

	public bool Equals(MovieCustom_PerformerSetTransform other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformerGuid != other.PerformerGuid)
		{
			return false;
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
		if (IsPlayerAsPerformer != other.IsPlayerAsPerformer)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PerformerGuid.Length != 0)
		{
			num ^= PerformerGuid.GetHashCode();
		}
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
		if (IsPlayerAsPerformer)
		{
			num ^= IsPlayerAsPerformer.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PerformerGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PerformerGuid);
		}
		if (TransformX != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(TransformX);
		}
		if (TransformY != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(TransformY);
		}
		if (TransformZ != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(TransformZ);
		}
		if (TransformPitch != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(TransformPitch);
		}
		if (TransformYaw != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(TransformYaw);
		}
		if (TransformRoll != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(TransformRoll);
		}
		if (TransformSx != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(TransformSx);
		}
		if (TransformSy != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(TransformSy);
		}
		if (TransformSz != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(TransformSz);
		}
		if (IsPlayerAsPerformer)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsPlayerAsPerformer);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PerformerGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PerformerGuid);
		}
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
		if (IsPlayerAsPerformer)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PerformerSetTransform other)
	{
		if (other != null)
		{
			if (other.PerformerGuid.Length != 0)
			{
				PerformerGuid = other.PerformerGuid;
			}
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
			if (other.IsPlayerAsPerformer)
			{
				IsPlayerAsPerformer = other.IsPlayerAsPerformer;
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
			case 10u:
				PerformerGuid = input.ReadString();
				break;
			case 21u:
				TransformX = input.ReadFloat();
				break;
			case 29u:
				TransformY = input.ReadFloat();
				break;
			case 37u:
				TransformZ = input.ReadFloat();
				break;
			case 45u:
				TransformPitch = input.ReadFloat();
				break;
			case 53u:
				TransformYaw = input.ReadFloat();
				break;
			case 61u:
				TransformRoll = input.ReadFloat();
				break;
			case 69u:
				TransformSx = input.ReadFloat();
				break;
			case 77u:
				TransformSy = input.ReadFloat();
				break;
			case 85u:
				TransformSz = input.ReadFloat();
				break;
			case 88u:
				IsPlayerAsPerformer = input.ReadBool();
				break;
			}
		}
	}
}
