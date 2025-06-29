using System;
using Google.Protobuf;

namespace ResB1;

public sealed class UISettingDeviceConfigDesc : IMessage<UISettingDeviceConfigDesc>, IMessage, IEquatable<UISettingDeviceConfigDesc>, IDeepCloneable<UISettingDeviceConfigDesc>
{
	private static readonly MessageParser<UISettingDeviceConfigDesc> _parser = new MessageParser<UISettingDeviceConfigDesc>(() => new UISettingDeviceConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string deviceName_ = "";

	private ESuperResolutionsampling superResolutionsampling_;

	private DeviceWhiteConfigType viewDistance_;

	private DeviceWhiteConfigType antiAliasing_;

	private DeviceWhiteConfigType postProcessing_;

	private DeviceWhiteConfigType shadowQuality_;

	private DeviceWhiteConfigType textureQuality_;

	private DeviceWhiteConfigType fxQuality_;

	private DeviceWhiteConfigType materialQuality_;

	private DeviceWhiteConfigType vegetationQuality_;

	private DeviceWhiteConfigType globalIllumination_;

	private DeviceWhiteConfigType reflectionQuality_;

	private int resolutionBaseY_;

	private EDeviceSettingType insertFrame_;

	private EDeviceSettingType rtx_;

	private int rtxLevel_;

	private EDevicePlatformType platformType_;

	public static MessageParser<UISettingDeviceConfigDesc> Parser => _parser;

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

	public string DeviceName
	{
		get
		{
			return deviceName_;
		}
		set
		{
			deviceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ESuperResolutionsampling SuperResolutionsampling
	{
		get
		{
			return superResolutionsampling_;
		}
		set
		{
			superResolutionsampling_ = value;
		}
	}

	public DeviceWhiteConfigType ViewDistance
	{
		get
		{
			return viewDistance_;
		}
		set
		{
			viewDistance_ = value;
		}
	}

	public DeviceWhiteConfigType AntiAliasing
	{
		get
		{
			return antiAliasing_;
		}
		set
		{
			antiAliasing_ = value;
		}
	}

	public DeviceWhiteConfigType PostProcessing
	{
		get
		{
			return postProcessing_;
		}
		set
		{
			postProcessing_ = value;
		}
	}

	public DeviceWhiteConfigType ShadowQuality
	{
		get
		{
			return shadowQuality_;
		}
		set
		{
			shadowQuality_ = value;
		}
	}

	public DeviceWhiteConfigType TextureQuality
	{
		get
		{
			return textureQuality_;
		}
		set
		{
			textureQuality_ = value;
		}
	}

	public DeviceWhiteConfigType FxQuality
	{
		get
		{
			return fxQuality_;
		}
		set
		{
			fxQuality_ = value;
		}
	}

	public DeviceWhiteConfigType MaterialQuality
	{
		get
		{
			return materialQuality_;
		}
		set
		{
			materialQuality_ = value;
		}
	}

	public DeviceWhiteConfigType VegetationQuality
	{
		get
		{
			return vegetationQuality_;
		}
		set
		{
			vegetationQuality_ = value;
		}
	}

	public DeviceWhiteConfigType GlobalIllumination
	{
		get
		{
			return globalIllumination_;
		}
		set
		{
			globalIllumination_ = value;
		}
	}

	public DeviceWhiteConfigType ReflectionQuality
	{
		get
		{
			return reflectionQuality_;
		}
		set
		{
			reflectionQuality_ = value;
		}
	}

	public int ResolutionBaseY
	{
		get
		{
			return resolutionBaseY_;
		}
		set
		{
			resolutionBaseY_ = value;
		}
	}

	public EDeviceSettingType InsertFrame
	{
		get
		{
			return insertFrame_;
		}
		set
		{
			insertFrame_ = value;
		}
	}

	public EDeviceSettingType Rtx
	{
		get
		{
			return rtx_;
		}
		set
		{
			rtx_ = value;
		}
	}

	public int RtxLevel
	{
		get
		{
			return rtxLevel_;
		}
		set
		{
			rtxLevel_ = value;
		}
	}

	public EDevicePlatformType PlatformType
	{
		get
		{
			return platformType_;
		}
		set
		{
			platformType_ = value;
		}
	}

	public UISettingDeviceConfigDesc()
	{
	}

	public UISettingDeviceConfigDesc(UISettingDeviceConfigDesc other)
		: this()
	{
		id_ = other.id_;
		deviceName_ = other.deviceName_;
		superResolutionsampling_ = other.superResolutionsampling_;
		viewDistance_ = other.viewDistance_;
		antiAliasing_ = other.antiAliasing_;
		postProcessing_ = other.postProcessing_;
		shadowQuality_ = other.shadowQuality_;
		textureQuality_ = other.textureQuality_;
		fxQuality_ = other.fxQuality_;
		materialQuality_ = other.materialQuality_;
		vegetationQuality_ = other.vegetationQuality_;
		globalIllumination_ = other.globalIllumination_;
		reflectionQuality_ = other.reflectionQuality_;
		resolutionBaseY_ = other.resolutionBaseY_;
		insertFrame_ = other.insertFrame_;
		rtx_ = other.rtx_;
		rtxLevel_ = other.rtxLevel_;
		platformType_ = other.platformType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UISettingDeviceConfigDesc Clone()
	{
		return new UISettingDeviceConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UISettingDeviceConfigDesc);
	}

	public bool Equals(UISettingDeviceConfigDesc other)
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
		if (DeviceName != other.DeviceName)
		{
			return false;
		}
		if (SuperResolutionsampling != other.SuperResolutionsampling)
		{
			return false;
		}
		if (ViewDistance != other.ViewDistance)
		{
			return false;
		}
		if (AntiAliasing != other.AntiAliasing)
		{
			return false;
		}
		if (PostProcessing != other.PostProcessing)
		{
			return false;
		}
		if (ShadowQuality != other.ShadowQuality)
		{
			return false;
		}
		if (TextureQuality != other.TextureQuality)
		{
			return false;
		}
		if (FxQuality != other.FxQuality)
		{
			return false;
		}
		if (MaterialQuality != other.MaterialQuality)
		{
			return false;
		}
		if (VegetationQuality != other.VegetationQuality)
		{
			return false;
		}
		if (GlobalIllumination != other.GlobalIllumination)
		{
			return false;
		}
		if (ReflectionQuality != other.ReflectionQuality)
		{
			return false;
		}
		if (ResolutionBaseY != other.ResolutionBaseY)
		{
			return false;
		}
		if (InsertFrame != other.InsertFrame)
		{
			return false;
		}
		if (Rtx != other.Rtx)
		{
			return false;
		}
		if (RtxLevel != other.RtxLevel)
		{
			return false;
		}
		if (PlatformType != other.PlatformType)
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
		if (DeviceName.Length != 0)
		{
			num ^= DeviceName.GetHashCode();
		}
		if (SuperResolutionsampling != ESuperResolutionsampling.Fsr)
		{
			num ^= SuperResolutionsampling.GetHashCode();
		}
		if (ViewDistance != DeviceWhiteConfigType.Min)
		{
			num ^= ViewDistance.GetHashCode();
		}
		if (AntiAliasing != DeviceWhiteConfigType.Min)
		{
			num ^= AntiAliasing.GetHashCode();
		}
		if (PostProcessing != DeviceWhiteConfigType.Min)
		{
			num ^= PostProcessing.GetHashCode();
		}
		if (ShadowQuality != DeviceWhiteConfigType.Min)
		{
			num ^= ShadowQuality.GetHashCode();
		}
		if (TextureQuality != DeviceWhiteConfigType.Min)
		{
			num ^= TextureQuality.GetHashCode();
		}
		if (FxQuality != DeviceWhiteConfigType.Min)
		{
			num ^= FxQuality.GetHashCode();
		}
		if (MaterialQuality != DeviceWhiteConfigType.Min)
		{
			num ^= MaterialQuality.GetHashCode();
		}
		if (VegetationQuality != DeviceWhiteConfigType.Min)
		{
			num ^= VegetationQuality.GetHashCode();
		}
		if (GlobalIllumination != DeviceWhiteConfigType.Min)
		{
			num ^= GlobalIllumination.GetHashCode();
		}
		if (ReflectionQuality != DeviceWhiteConfigType.Min)
		{
			num ^= ReflectionQuality.GetHashCode();
		}
		if (ResolutionBaseY != 0)
		{
			num ^= ResolutionBaseY.GetHashCode();
		}
		if (InsertFrame != EDeviceSettingType.Close)
		{
			num ^= InsertFrame.GetHashCode();
		}
		if (Rtx != EDeviceSettingType.Close)
		{
			num ^= Rtx.GetHashCode();
		}
		if (RtxLevel != 0)
		{
			num ^= RtxLevel.GetHashCode();
		}
		if (PlatformType != EDevicePlatformType.Pc)
		{
			num ^= PlatformType.GetHashCode();
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
		if (DeviceName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DeviceName);
		}
		if (SuperResolutionsampling != ESuperResolutionsampling.Fsr)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)SuperResolutionsampling);
		}
		if (ViewDistance != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ViewDistance);
		}
		if (AntiAliasing != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)AntiAliasing);
		}
		if (PostProcessing != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)PostProcessing);
		}
		if (ShadowQuality != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)ShadowQuality);
		}
		if (TextureQuality != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)TextureQuality);
		}
		if (FxQuality != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)FxQuality);
		}
		if (MaterialQuality != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)MaterialQuality);
		}
		if (VegetationQuality != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)VegetationQuality);
		}
		if (GlobalIllumination != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)GlobalIllumination);
		}
		if (ReflectionQuality != DeviceWhiteConfigType.Min)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)ReflectionQuality);
		}
		if (ResolutionBaseY != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(ResolutionBaseY);
		}
		if (InsertFrame != EDeviceSettingType.Close)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)InsertFrame);
		}
		if (Rtx != EDeviceSettingType.Close)
		{
			output.WriteRawTag(128, 1);
			output.WriteEnum((int)Rtx);
		}
		if (RtxLevel != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(RtxLevel);
		}
		if (PlatformType != EDevicePlatformType.Pc)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)PlatformType);
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
		if (DeviceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeviceName);
		}
		if (SuperResolutionsampling != ESuperResolutionsampling.Fsr)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SuperResolutionsampling);
		}
		if (ViewDistance != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ViewDistance);
		}
		if (AntiAliasing != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AntiAliasing);
		}
		if (PostProcessing != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PostProcessing);
		}
		if (ShadowQuality != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ShadowQuality);
		}
		if (TextureQuality != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TextureQuality);
		}
		if (FxQuality != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FxQuality);
		}
		if (MaterialQuality != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MaterialQuality);
		}
		if (VegetationQuality != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)VegetationQuality);
		}
		if (GlobalIllumination != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GlobalIllumination);
		}
		if (ReflectionQuality != DeviceWhiteConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ReflectionQuality);
		}
		if (ResolutionBaseY != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResolutionBaseY);
		}
		if (InsertFrame != EDeviceSettingType.Close)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)InsertFrame);
		}
		if (Rtx != EDeviceSettingType.Close)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)Rtx);
		}
		if (RtxLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RtxLevel);
		}
		if (PlatformType != EDevicePlatformType.Pc)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)PlatformType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UISettingDeviceConfigDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.DeviceName.Length != 0)
			{
				DeviceName = other.DeviceName;
			}
			if (other.SuperResolutionsampling != ESuperResolutionsampling.Fsr)
			{
				SuperResolutionsampling = other.SuperResolutionsampling;
			}
			if (other.ViewDistance != DeviceWhiteConfigType.Min)
			{
				ViewDistance = other.ViewDistance;
			}
			if (other.AntiAliasing != DeviceWhiteConfigType.Min)
			{
				AntiAliasing = other.AntiAliasing;
			}
			if (other.PostProcessing != DeviceWhiteConfigType.Min)
			{
				PostProcessing = other.PostProcessing;
			}
			if (other.ShadowQuality != DeviceWhiteConfigType.Min)
			{
				ShadowQuality = other.ShadowQuality;
			}
			if (other.TextureQuality != DeviceWhiteConfigType.Min)
			{
				TextureQuality = other.TextureQuality;
			}
			if (other.FxQuality != DeviceWhiteConfigType.Min)
			{
				FxQuality = other.FxQuality;
			}
			if (other.MaterialQuality != DeviceWhiteConfigType.Min)
			{
				MaterialQuality = other.MaterialQuality;
			}
			if (other.VegetationQuality != DeviceWhiteConfigType.Min)
			{
				VegetationQuality = other.VegetationQuality;
			}
			if (other.GlobalIllumination != DeviceWhiteConfigType.Min)
			{
				GlobalIllumination = other.GlobalIllumination;
			}
			if (other.ReflectionQuality != DeviceWhiteConfigType.Min)
			{
				ReflectionQuality = other.ReflectionQuality;
			}
			if (other.ResolutionBaseY != 0)
			{
				ResolutionBaseY = other.ResolutionBaseY;
			}
			if (other.InsertFrame != EDeviceSettingType.Close)
			{
				InsertFrame = other.InsertFrame;
			}
			if (other.Rtx != EDeviceSettingType.Close)
			{
				Rtx = other.Rtx;
			}
			if (other.RtxLevel != 0)
			{
				RtxLevel = other.RtxLevel;
			}
			if (other.PlatformType != EDevicePlatformType.Pc)
			{
				PlatformType = other.PlatformType;
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
			case 18u:
				DeviceName = input.ReadString();
				break;
			case 24u:
				SuperResolutionsampling = (ESuperResolutionsampling)input.ReadEnum();
				break;
			case 32u:
				ViewDistance = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 40u:
				AntiAliasing = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 48u:
				PostProcessing = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 56u:
				ShadowQuality = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 64u:
				TextureQuality = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 72u:
				FxQuality = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 80u:
				MaterialQuality = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 88u:
				VegetationQuality = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 96u:
				GlobalIllumination = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 104u:
				ReflectionQuality = (DeviceWhiteConfigType)input.ReadEnum();
				break;
			case 112u:
				ResolutionBaseY = input.ReadInt32();
				break;
			case 120u:
				InsertFrame = (EDeviceSettingType)input.ReadEnum();
				break;
			case 128u:
				Rtx = (EDeviceSettingType)input.ReadEnum();
				break;
			case 136u:
				RtxLevel = input.ReadInt32();
				break;
			case 144u:
				PlatformType = (EDevicePlatformType)input.ReadEnum();
				break;
			}
		}
	}
}
