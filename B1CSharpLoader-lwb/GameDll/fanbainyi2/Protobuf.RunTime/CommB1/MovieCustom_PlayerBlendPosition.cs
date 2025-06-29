using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_PlayerBlendPosition : IMessage<MovieCustom_PlayerBlendPosition>, IMessage, IEquatable<MovieCustom_PlayerBlendPosition>, IDeepCloneable<MovieCustom_PlayerBlendPosition>
{
	private static readonly MessageParser<MovieCustom_PlayerBlendPosition> _parser = new MessageParser<MovieCustom_PlayerBlendPosition>(() => new MovieCustom_PlayerBlendPosition());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CalliopeCustom_Transform> _repeated_alternativeTransforms_codec = FieldCodec.ForMessage(10u, CalliopeCustom_Transform.Parser);

	private readonly RepeatedField<CalliopeCustom_Transform> alternativeTransforms_ = new RepeatedField<CalliopeCustom_Transform>();

	private float blendMaxTime_;

	private float blendPositionAcceptRadius_;

	private int moveSpeedType_;

	private float blendPositionInterpTime_;

	private float teleportDistance_;

	public static MessageParser<MovieCustom_PlayerBlendPosition> Parser => _parser;

	public RepeatedField<CalliopeCustom_Transform> AlternativeTransforms => alternativeTransforms_;

	public float BlendMaxTime
	{
		get
		{
			return blendMaxTime_;
		}
		set
		{
			blendMaxTime_ = value;
		}
	}

	public float BlendPositionAcceptRadius
	{
		get
		{
			return blendPositionAcceptRadius_;
		}
		set
		{
			blendPositionAcceptRadius_ = value;
		}
	}

	public int MoveSpeedType
	{
		get
		{
			return moveSpeedType_;
		}
		set
		{
			moveSpeedType_ = value;
		}
	}

	public float BlendPositionInterpTime
	{
		get
		{
			return blendPositionInterpTime_;
		}
		set
		{
			blendPositionInterpTime_ = value;
		}
	}

	public float TeleportDistance
	{
		get
		{
			return teleportDistance_;
		}
		set
		{
			teleportDistance_ = value;
		}
	}

	public MovieCustom_PlayerBlendPosition()
	{
	}

	public MovieCustom_PlayerBlendPosition(MovieCustom_PlayerBlendPosition other)
		: this()
	{
		alternativeTransforms_ = other.alternativeTransforms_.Clone();
		blendMaxTime_ = other.blendMaxTime_;
		blendPositionAcceptRadius_ = other.blendPositionAcceptRadius_;
		moveSpeedType_ = other.moveSpeedType_;
		blendPositionInterpTime_ = other.blendPositionInterpTime_;
		teleportDistance_ = other.teleportDistance_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PlayerBlendPosition Clone()
	{
		return new MovieCustom_PlayerBlendPosition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PlayerBlendPosition);
	}

	public bool Equals(MovieCustom_PlayerBlendPosition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!alternativeTransforms_.Equals(other.alternativeTransforms_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BlendMaxTime, other.BlendMaxTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BlendPositionAcceptRadius, other.BlendPositionAcceptRadius))
		{
			return false;
		}
		if (MoveSpeedType != other.MoveSpeedType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BlendPositionInterpTime, other.BlendPositionInterpTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TeleportDistance, other.TeleportDistance))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= alternativeTransforms_.GetHashCode();
		if (BlendMaxTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BlendMaxTime);
		}
		if (BlendPositionAcceptRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BlendPositionAcceptRadius);
		}
		if (MoveSpeedType != 0)
		{
			num ^= MoveSpeedType.GetHashCode();
		}
		if (BlendPositionInterpTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BlendPositionInterpTime);
		}
		if (TeleportDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TeleportDistance);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		alternativeTransforms_.WriteTo(output, _repeated_alternativeTransforms_codec);
		if (BlendMaxTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(BlendMaxTime);
		}
		if (BlendPositionAcceptRadius != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(BlendPositionAcceptRadius);
		}
		if (MoveSpeedType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MoveSpeedType);
		}
		if (BlendPositionInterpTime != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(BlendPositionInterpTime);
		}
		if (TeleportDistance != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(TeleportDistance);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += alternativeTransforms_.CalculateSize(_repeated_alternativeTransforms_codec);
		if (BlendMaxTime != 0f)
		{
			num += 5;
		}
		if (BlendPositionAcceptRadius != 0f)
		{
			num += 5;
		}
		if (MoveSpeedType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MoveSpeedType);
		}
		if (BlendPositionInterpTime != 0f)
		{
			num += 5;
		}
		if (TeleportDistance != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PlayerBlendPosition other)
	{
		if (other != null)
		{
			alternativeTransforms_.Add(other.alternativeTransforms_);
			if (other.BlendMaxTime != 0f)
			{
				BlendMaxTime = other.BlendMaxTime;
			}
			if (other.BlendPositionAcceptRadius != 0f)
			{
				BlendPositionAcceptRadius = other.BlendPositionAcceptRadius;
			}
			if (other.MoveSpeedType != 0)
			{
				MoveSpeedType = other.MoveSpeedType;
			}
			if (other.BlendPositionInterpTime != 0f)
			{
				BlendPositionInterpTime = other.BlendPositionInterpTime;
			}
			if (other.TeleportDistance != 0f)
			{
				TeleportDistance = other.TeleportDistance;
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
				alternativeTransforms_.AddEntriesFrom(input, _repeated_alternativeTransforms_codec);
				break;
			case 21u:
				BlendMaxTime = input.ReadFloat();
				break;
			case 29u:
				BlendPositionAcceptRadius = input.ReadFloat();
				break;
			case 32u:
				MoveSpeedType = input.ReadInt32();
				break;
			case 45u:
				BlendPositionInterpTime = input.ReadFloat();
				break;
			case 53u:
				TeleportDistance = input.ReadFloat();
				break;
			}
		}
	}
}
