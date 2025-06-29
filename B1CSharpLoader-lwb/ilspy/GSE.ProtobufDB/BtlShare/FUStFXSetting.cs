using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStFXSetting : IMessage<FUStFXSetting>, IMessage, IEquatable<FUStFXSetting>, IDeepCloneable<FUStFXSetting>
{
	private static readonly MessageParser<FUStFXSetting> _parser = new MessageParser<FUStFXSetting>(() => new FUStFXSetting());

	private UnknownFieldSet _unknownFields;

	private string pSPath_ = "";

	private float scale_;

	private EGSYesNo isAttach_;

	private string attachName_ = "";

	private float worldOffsetX_;

	private float worldOffsetY_;

	private float worldOffsetZ_;

	private EGSYesNo useScaleFit_;

	private EGSYesNo isAttachToSkin_;

	private string skelMeshParamName_ = "";

	private string addTags_ = "";

	public static MessageParser<FUStFXSetting> Parser => _parser;

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

	public EGSYesNo IsAttach
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

	public EGSYesNo UseScaleFit
	{
		get
		{
			return useScaleFit_;
		}
		set
		{
			useScaleFit_ = value;
		}
	}

	public EGSYesNo IsAttachToSkin
	{
		get
		{
			return isAttachToSkin_;
		}
		set
		{
			isAttachToSkin_ = value;
		}
	}

	public string SkelMeshParamName
	{
		get
		{
			return skelMeshParamName_;
		}
		set
		{
			skelMeshParamName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AddTags
	{
		get
		{
			return addTags_;
		}
		set
		{
			addTags_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStFXSetting()
	{
	}

	public FUStFXSetting(FUStFXSetting other)
		: this()
	{
		pSPath_ = other.pSPath_;
		scale_ = other.scale_;
		isAttach_ = other.isAttach_;
		attachName_ = other.attachName_;
		worldOffsetX_ = other.worldOffsetX_;
		worldOffsetY_ = other.worldOffsetY_;
		worldOffsetZ_ = other.worldOffsetZ_;
		useScaleFit_ = other.useScaleFit_;
		isAttachToSkin_ = other.isAttachToSkin_;
		skelMeshParamName_ = other.skelMeshParamName_;
		addTags_ = other.addTags_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStFXSetting Clone()
	{
		return new FUStFXSetting(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStFXSetting);
	}

	public bool Equals(FUStFXSetting other)
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
		if (UseScaleFit != other.UseScaleFit)
		{
			return false;
		}
		if (IsAttachToSkin != other.IsAttachToSkin)
		{
			return false;
		}
		if (SkelMeshParamName != other.SkelMeshParamName)
		{
			return false;
		}
		if (AddTags != other.AddTags)
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
		if (IsAttach != EGSYesNo.No)
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
		if (UseScaleFit != EGSYesNo.No)
		{
			num ^= UseScaleFit.GetHashCode();
		}
		if (IsAttachToSkin != EGSYesNo.No)
		{
			num ^= IsAttachToSkin.GetHashCode();
		}
		if (SkelMeshParamName.Length != 0)
		{
			num ^= SkelMeshParamName.GetHashCode();
		}
		if (AddTags.Length != 0)
		{
			num ^= AddTags.GetHashCode();
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
		if (IsAttach != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IsAttach);
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
		if (UseScaleFit != EGSYesNo.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)UseScaleFit);
		}
		if (IsAttachToSkin != EGSYesNo.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)IsAttachToSkin);
		}
		if (SkelMeshParamName.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(SkelMeshParamName);
		}
		if (AddTags.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(AddTags);
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
		if (IsAttach != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsAttach);
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
		if (UseScaleFit != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UseScaleFit);
		}
		if (IsAttachToSkin != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsAttachToSkin);
		}
		if (SkelMeshParamName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkelMeshParamName);
		}
		if (AddTags.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AddTags);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStFXSetting other)
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
			if (other.IsAttach != EGSYesNo.No)
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
			if (other.UseScaleFit != EGSYesNo.No)
			{
				UseScaleFit = other.UseScaleFit;
			}
			if (other.IsAttachToSkin != EGSYesNo.No)
			{
				IsAttachToSkin = other.IsAttachToSkin;
			}
			if (other.SkelMeshParamName.Length != 0)
			{
				SkelMeshParamName = other.SkelMeshParamName;
			}
			if (other.AddTags.Length != 0)
			{
				AddTags = other.AddTags;
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
				IsAttach = (EGSYesNo)input.ReadEnum();
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
			case 64u:
				UseScaleFit = (EGSYesNo)input.ReadEnum();
				break;
			case 72u:
				IsAttachToSkin = (EGSYesNo)input.ReadEnum();
				break;
			case 82u:
				SkelMeshParamName = input.ReadString();
				break;
			case 90u:
				AddTags = input.ReadString();
				break;
			}
		}
	}
}
