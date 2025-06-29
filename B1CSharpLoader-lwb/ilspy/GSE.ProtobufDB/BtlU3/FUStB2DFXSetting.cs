using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DFXSetting : IMessage<FUStB2DFXSetting>, IMessage, IEquatable<FUStB2DFXSetting>, IDeepCloneable<FUStB2DFXSetting>
{
	private static readonly MessageParser<FUStB2DFXSetting> _parser = new MessageParser<FUStB2DFXSetting>(() => new FUStB2DFXSetting());

	private UnknownFieldSet _unknownFields;

	private string pSPath_ = "";

	private float scale_;

	private int isAttach_;

	private string attachName_ = "";

	private float worldOffsetX_;

	private float worldOffsetY_;

	private float worldOffsetZ_;

	public static MessageParser<FUStB2DFXSetting> Parser => _parser;

	public string PSPath
	{
		get
		{
			return pSPath_;
		}
		set
		{
			pSPath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int IsAttach
	{
		get
		{
			return isAttach_;
		}
		set
		{
			isAttach_ = value;
		}
	}

	public string AttachName
	{
		get
		{
			return attachName_;
		}
		set
		{
			attachName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float WorldOffsetX
	{
		get
		{
			return worldOffsetX_;
		}
		set
		{
			worldOffsetX_ = value;
		}
	}

	public float WorldOffsetY
	{
		get
		{
			return worldOffsetY_;
		}
		set
		{
			worldOffsetY_ = value;
		}
	}

	public float WorldOffsetZ
	{
		get
		{
			return worldOffsetZ_;
		}
		set
		{
			worldOffsetZ_ = value;
		}
	}

	public FUStB2DFXSetting()
	{
	}

	public FUStB2DFXSetting(FUStB2DFXSetting other)
		: this()
	{
		pSPath_ = other.pSPath_;
		scale_ = other.scale_;
		isAttach_ = other.isAttach_;
		attachName_ = other.attachName_;
		worldOffsetX_ = other.worldOffsetX_;
		worldOffsetY_ = other.worldOffsetY_;
		worldOffsetZ_ = other.worldOffsetZ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DFXSetting Clone()
	{
		return new FUStB2DFXSetting(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DFXSetting);
	}

	public bool Equals(FUStB2DFXSetting other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PSPath != other.PSPath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Scale, other.Scale))
		{
			return false;
		}
		if (IsAttach != other.IsAttach)
		{
			return false;
		}
		if (AttachName != other.AttachName)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(WorldOffsetX, other.WorldOffsetX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(WorldOffsetY, other.WorldOffsetY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(WorldOffsetZ, other.WorldOffsetZ))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PSPath.Length != 0)
		{
			num ^= PSPath.GetHashCode();
		}
		if (Scale != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Scale);
		}
		if (IsAttach != 0)
		{
			num ^= IsAttach.GetHashCode();
		}
		if (AttachName.Length != 0)
		{
			num ^= AttachName.GetHashCode();
		}
		if (WorldOffsetX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(WorldOffsetX);
		}
		if (WorldOffsetY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(WorldOffsetY);
		}
		if (WorldOffsetZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(WorldOffsetZ);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PSPath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PSPath);
		}
		if (Scale != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Scale);
		}
		if (IsAttach != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(IsAttach);
		}
		if (AttachName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(AttachName);
		}
		if (WorldOffsetX != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(WorldOffsetX);
		}
		if (WorldOffsetY != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(WorldOffsetY);
		}
		if (WorldOffsetZ != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(WorldOffsetZ);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PSPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PSPath);
		}
		if (Scale != 0f)
		{
			num += 5;
		}
		if (IsAttach != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsAttach);
		}
		if (AttachName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AttachName);
		}
		if (WorldOffsetX != 0f)
		{
			num += 5;
		}
		if (WorldOffsetY != 0f)
		{
			num += 5;
		}
		if (WorldOffsetZ != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DFXSetting other)
	{
		if (other != null)
		{
			if (other.PSPath.Length != 0)
			{
				PSPath = other.PSPath;
			}
			if (other.Scale != 0f)
			{
				Scale = other.Scale;
			}
			if (other.IsAttach != 0)
			{
				IsAttach = other.IsAttach;
			}
			if (other.AttachName.Length != 0)
			{
				AttachName = other.AttachName;
			}
			if (other.WorldOffsetX != 0f)
			{
				WorldOffsetX = other.WorldOffsetX;
			}
			if (other.WorldOffsetY != 0f)
			{
				WorldOffsetY = other.WorldOffsetY;
			}
			if (other.WorldOffsetZ != 0f)
			{
				WorldOffsetZ = other.WorldOffsetZ;
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
				PSPath = input.ReadString();
				break;
			case 21u:
				Scale = input.ReadFloat();
				break;
			case 24u:
				IsAttach = input.ReadInt32();
				break;
			case 34u:
				AttachName = input.ReadString();
				break;
			case 45u:
				WorldOffsetX = input.ReadFloat();
				break;
			case 53u:
				WorldOffsetY = input.ReadFloat();
				break;
			case 61u:
				WorldOffsetZ = input.ReadFloat();
				break;
			}
		}
	}
}
