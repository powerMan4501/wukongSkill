using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStCameraConversionParamConfigDesc : IMessage<FUStCameraConversionParamConfigDesc>, IMessage, IEquatable<FUStCameraConversionParamConfigDesc>, IDeepCloneable<FUStCameraConversionParamConfigDesc>
{
	private static readonly MessageParser<FUStCameraConversionParamConfigDesc> _parser = new MessageParser<FUStCameraConversionParamConfigDesc>(() => new FUStCameraConversionParamConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float scale_;

	private float meshHeight_;

	private float capsuleHalfHeight_;

	private float pelvisHeight_;

	private float rearFootOffset_;

	private float blendTime_;

	public static MessageParser<FUStCameraConversionParamConfigDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public float Scale
	{
		get
		{
			return scale_;
		}
		set
		{
			scale_ = value;
		}
	}

	public float MeshHeight
	{
		get
		{
			return meshHeight_;
		}
		set
		{
			meshHeight_ = value;
		}
	}

	public float CapsuleHalfHeight
	{
		get
		{
			return capsuleHalfHeight_;
		}
		set
		{
			capsuleHalfHeight_ = value;
		}
	}

	public float PelvisHeight
	{
		get
		{
			return pelvisHeight_;
		}
		set
		{
			pelvisHeight_ = value;
		}
	}

	public float RearFootOffset
	{
		get
		{
			return rearFootOffset_;
		}
		set
		{
			rearFootOffset_ = value;
		}
	}

	public float BlendTime
	{
		get
		{
			return blendTime_;
		}
		set
		{
			blendTime_ = value;
		}
	}

	public FUStCameraConversionParamConfigDesc()
	{
	}

	public FUStCameraConversionParamConfigDesc(FUStCameraConversionParamConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		scale_ = other.scale_;
		meshHeight_ = other.meshHeight_;
		capsuleHalfHeight_ = other.capsuleHalfHeight_;
		pelvisHeight_ = other.pelvisHeight_;
		rearFootOffset_ = other.rearFootOffset_;
		blendTime_ = other.blendTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStCameraConversionParamConfigDesc Clone()
	{
		return new FUStCameraConversionParamConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStCameraConversionParamConfigDesc);
	}

	public bool Equals(FUStCameraConversionParamConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Scale, other.Scale))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MeshHeight, other.MeshHeight))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CapsuleHalfHeight, other.CapsuleHalfHeight))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PelvisHeight, other.PelvisHeight))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RearFootOffset, other.RearFootOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BlendTime, other.BlendTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (Scale != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Scale);
		}
		if (MeshHeight != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MeshHeight);
		}
		if (CapsuleHalfHeight != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CapsuleHalfHeight);
		}
		if (PelvisHeight != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PelvisHeight);
		}
		if (RearFootOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RearFootOffset);
		}
		if (BlendTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BlendTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (Scale != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Scale);
		}
		if (MeshHeight != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(MeshHeight);
		}
		if (CapsuleHalfHeight != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(CapsuleHalfHeight);
		}
		if (PelvisHeight != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(PelvisHeight);
		}
		if (RearFootOffset != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(RearFootOffset);
		}
		if (BlendTime != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(BlendTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (Scale != 0f)
		{
			num += 5;
		}
		if (MeshHeight != 0f)
		{
			num += 5;
		}
		if (CapsuleHalfHeight != 0f)
		{
			num += 5;
		}
		if (PelvisHeight != 0f)
		{
			num += 5;
		}
		if (RearFootOffset != 0f)
		{
			num += 5;
		}
		if (BlendTime != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStCameraConversionParamConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Scale != 0f)
			{
				Scale = other.Scale;
			}
			if (other.MeshHeight != 0f)
			{
				MeshHeight = other.MeshHeight;
			}
			if (other.CapsuleHalfHeight != 0f)
			{
				CapsuleHalfHeight = other.CapsuleHalfHeight;
			}
			if (other.PelvisHeight != 0f)
			{
				PelvisHeight = other.PelvisHeight;
			}
			if (other.RearFootOffset != 0f)
			{
				RearFootOffset = other.RearFootOffset;
			}
			if (other.BlendTime != 0f)
			{
				BlendTime = other.BlendTime;
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
				ID = input.ReadInt32();
				break;
			case 21u:
				Scale = input.ReadFloat();
				break;
			case 29u:
				MeshHeight = input.ReadFloat();
				break;
			case 37u:
				CapsuleHalfHeight = input.ReadFloat();
				break;
			case 45u:
				PelvisHeight = input.ReadFloat();
				break;
			case 53u:
				RearFootOffset = input.ReadFloat();
				break;
			case 61u:
				BlendTime = input.ReadFloat();
				break;
			}
		}
	}
}
