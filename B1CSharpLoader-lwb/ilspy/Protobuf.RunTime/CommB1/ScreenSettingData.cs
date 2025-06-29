using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class ScreenSettingData : IMessage<ScreenSettingData>, IMessage, IEquatable<ScreenSettingData>, IDeepCloneable<ScreenSettingData>
{
	private static readonly MessageParser<ScreenSettingData> _parser = new MessageParser<ScreenSettingData>(() => new ScreenSettingData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float screenBrightness_;

	private int screenQuality_;

	private int screenMode_;

	private int screenResolution_;

	private int mainDisplay_;

	private int screenRatio_;

	private int refreshRate_;

	private YesNoType vsync_;

	private int lockFrameRate_;

	private YesNoType rtx_;

	private int graphicsQuality_;

	private YesNoType frameRateLow_;

	private float imageQuality_;

	private int viewDistance_;

	private int antiAliasing_;

	private int postProcessing_;

	private int shadowQuality_;

	private int textureQuality_;

	private int fxQuality_;

	private int materialQuality_;

	private int vegetationQuality_;

	private EColorClass colorClass_;

	private int colorSeverity_;

	private int globalIllumination_;

	private int reflectionQuality_;

	private YesNoType isOpenCinematic_;

	public static MessageParser<ScreenSettingData> Parser => _parser;

	public float ScreenBrightness
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return screenBrightness_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			screenBrightness_ = value;
		}
	}

	public bool HasScreenBrightness => (_hasBits0 & 1) != 0;

	public int ScreenQuality
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return screenQuality_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			screenQuality_ = value;
		}
	}

	public bool HasScreenQuality => (_hasBits0 & 2) != 0;

	public int ScreenMode
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return screenMode_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			screenMode_ = value;
		}
	}

	public bool HasScreenMode => (_hasBits0 & 4) != 0;

	public int ScreenResolution
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return screenResolution_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8;
			screenResolution_ = value;
		}
	}

	public bool HasScreenResolution => (_hasBits0 & 8) != 0;

	public int MainDisplay
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return mainDisplay_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 16;
			mainDisplay_ = value;
		}
	}

	public bool HasMainDisplay => (_hasBits0 & 0x10) != 0;

	public int ScreenRatio
	{
		get
		{
			if ((_hasBits0 & 0x20) != 0)
			{
				return screenRatio_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 32;
			screenRatio_ = value;
		}
	}

	public bool HasScreenRatio => (_hasBits0 & 0x20) != 0;

	public int RefreshRate
	{
		get
		{
			if ((_hasBits0 & 0x40) != 0)
			{
				return refreshRate_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 64;
			refreshRate_ = value;
		}
	}

	public bool HasRefreshRate => (_hasBits0 & 0x40) != 0;

	public YesNoType Vsync
	{
		get
		{
			if ((_hasBits0 & 0x80) != 0)
			{
				return vsync_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 128;
			vsync_ = value;
		}
	}

	public bool HasVsync => (_hasBits0 & 0x80) != 0;

	public int LockFrameRate
	{
		get
		{
			if ((_hasBits0 & 0x100) != 0)
			{
				return lockFrameRate_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 256;
			lockFrameRate_ = value;
		}
	}

	public bool HasLockFrameRate => (_hasBits0 & 0x100) != 0;

	public YesNoType Rtx
	{
		get
		{
			if ((_hasBits0 & 0x200) != 0)
			{
				return rtx_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 512;
			rtx_ = value;
		}
	}

	public bool HasRtx => (_hasBits0 & 0x200) != 0;

	public int GraphicsQuality
	{
		get
		{
			if ((_hasBits0 & 0x400) != 0)
			{
				return graphicsQuality_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1024;
			graphicsQuality_ = value;
		}
	}

	public bool HasGraphicsQuality => (_hasBits0 & 0x400) != 0;

	public YesNoType FrameRateLow
	{
		get
		{
			if ((_hasBits0 & 0x800) != 0)
			{
				return frameRateLow_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 2048;
			frameRateLow_ = value;
		}
	}

	public bool HasFrameRateLow => (_hasBits0 & 0x800) != 0;

	public float ImageQuality
	{
		get
		{
			if ((_hasBits0 & 0x1000) != 0)
			{
				return imageQuality_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 4096;
			imageQuality_ = value;
		}
	}

	public bool HasImageQuality => (_hasBits0 & 0x1000) != 0;

	public int ViewDistance
	{
		get
		{
			if ((_hasBits0 & 0x2000) != 0)
			{
				return viewDistance_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8192;
			viewDistance_ = value;
		}
	}

	public bool HasViewDistance => (_hasBits0 & 0x2000) != 0;

	public int AntiAliasing
	{
		get
		{
			if ((_hasBits0 & 0x4000) != 0)
			{
				return antiAliasing_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 16384;
			antiAliasing_ = value;
		}
	}

	public bool HasAntiAliasing => (_hasBits0 & 0x4000) != 0;

	public int PostProcessing
	{
		get
		{
			if ((_hasBits0 & 0x8000) != 0)
			{
				return postProcessing_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 32768;
			postProcessing_ = value;
		}
	}

	public bool HasPostProcessing => (_hasBits0 & 0x8000) != 0;

	public int ShadowQuality
	{
		get
		{
			if ((_hasBits0 & 0x10000) != 0)
			{
				return shadowQuality_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 65536;
			shadowQuality_ = value;
		}
	}

	public bool HasShadowQuality => (_hasBits0 & 0x10000) != 0;

	public int TextureQuality
	{
		get
		{
			if ((_hasBits0 & 0x20000) != 0)
			{
				return textureQuality_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 131072;
			textureQuality_ = value;
		}
	}

	public bool HasTextureQuality => (_hasBits0 & 0x20000) != 0;

	public int FxQuality
	{
		get
		{
			if ((_hasBits0 & 0x40000) != 0)
			{
				return fxQuality_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 262144;
			fxQuality_ = value;
		}
	}

	public bool HasFxQuality => (_hasBits0 & 0x40000) != 0;

	public int MaterialQuality
	{
		get
		{
			if ((_hasBits0 & 0x80000) != 0)
			{
				return materialQuality_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 524288;
			materialQuality_ = value;
		}
	}

	public bool HasMaterialQuality => (_hasBits0 & 0x80000) != 0;

	public int VegetationQuality
	{
		get
		{
			if ((_hasBits0 & 0x100000) != 0)
			{
				return vegetationQuality_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1048576;
			vegetationQuality_ = value;
		}
	}

	public bool HasVegetationQuality => (_hasBits0 & 0x100000) != 0;

	public EColorClass ColorClass
	{
		get
		{
			if ((_hasBits0 & 0x200000) != 0)
			{
				return colorClass_;
			}
			return EColorClass.NormalClass;
		}
		set
		{
			_hasBits0 |= 2097152;
			colorClass_ = value;
		}
	}

	public bool HasColorClass => (_hasBits0 & 0x200000) != 0;

	public int ColorSeverity
	{
		get
		{
			if ((_hasBits0 & 0x400000) != 0)
			{
				return colorSeverity_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4194304;
			colorSeverity_ = value;
		}
	}

	public bool HasColorSeverity => (_hasBits0 & 0x400000) != 0;

	public int GlobalIllumination
	{
		get
		{
			if ((_hasBits0 & 0x800000) != 0)
			{
				return globalIllumination_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8388608;
			globalIllumination_ = value;
		}
	}

	public bool HasGlobalIllumination => (_hasBits0 & 0x800000) != 0;

	public int ReflectionQuality
	{
		get
		{
			if ((_hasBits0 & 0x1000000) != 0)
			{
				return reflectionQuality_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 16777216;
			reflectionQuality_ = value;
		}
	}

	public bool HasReflectionQuality => (_hasBits0 & 0x1000000) != 0;

	public YesNoType IsOpenCinematic
	{
		get
		{
			if ((_hasBits0 & 0x2000000) != 0)
			{
				return isOpenCinematic_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 33554432;
			isOpenCinematic_ = value;
		}
	}

	public bool HasIsOpenCinematic => (_hasBits0 & 0x2000000) != 0;

	public ScreenSettingData()
	{
	}

	public ScreenSettingData(ScreenSettingData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		screenBrightness_ = other.screenBrightness_;
		screenQuality_ = other.screenQuality_;
		screenMode_ = other.screenMode_;
		screenResolution_ = other.screenResolution_;
		mainDisplay_ = other.mainDisplay_;
		screenRatio_ = other.screenRatio_;
		refreshRate_ = other.refreshRate_;
		vsync_ = other.vsync_;
		lockFrameRate_ = other.lockFrameRate_;
		rtx_ = other.rtx_;
		graphicsQuality_ = other.graphicsQuality_;
		frameRateLow_ = other.frameRateLow_;
		imageQuality_ = other.imageQuality_;
		viewDistance_ = other.viewDistance_;
		antiAliasing_ = other.antiAliasing_;
		postProcessing_ = other.postProcessing_;
		shadowQuality_ = other.shadowQuality_;
		textureQuality_ = other.textureQuality_;
		fxQuality_ = other.fxQuality_;
		materialQuality_ = other.materialQuality_;
		vegetationQuality_ = other.vegetationQuality_;
		colorClass_ = other.colorClass_;
		colorSeverity_ = other.colorSeverity_;
		globalIllumination_ = other.globalIllumination_;
		reflectionQuality_ = other.reflectionQuality_;
		isOpenCinematic_ = other.isOpenCinematic_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ScreenSettingData Clone()
	{
		return new ScreenSettingData(this);
	}

	public void ClearScreenBrightness()
	{
		_hasBits0 &= -2;
	}

	public void ClearScreenQuality()
	{
		_hasBits0 &= -3;
	}

	public void ClearScreenMode()
	{
		_hasBits0 &= -5;
	}

	public void ClearScreenResolution()
	{
		_hasBits0 &= -9;
	}

	public void ClearMainDisplay()
	{
		_hasBits0 &= -17;
	}

	public void ClearScreenRatio()
	{
		_hasBits0 &= -33;
	}

	public void ClearRefreshRate()
	{
		_hasBits0 &= -65;
	}

	public void ClearVsync()
	{
		_hasBits0 &= -129;
	}

	public void ClearLockFrameRate()
	{
		_hasBits0 &= -257;
	}

	public void ClearRtx()
	{
		_hasBits0 &= -513;
	}

	public void ClearGraphicsQuality()
	{
		_hasBits0 &= -1025;
	}

	public void ClearFrameRateLow()
	{
		_hasBits0 &= -2049;
	}

	public void ClearImageQuality()
	{
		_hasBits0 &= -4097;
	}

	public void ClearViewDistance()
	{
		_hasBits0 &= -8193;
	}

	public void ClearAntiAliasing()
	{
		_hasBits0 &= -16385;
	}

	public void ClearPostProcessing()
	{
		_hasBits0 &= -32769;
	}

	public void ClearShadowQuality()
	{
		_hasBits0 &= -65537;
	}

	public void ClearTextureQuality()
	{
		_hasBits0 &= -131073;
	}

	public void ClearFxQuality()
	{
		_hasBits0 &= -262145;
	}

	public void ClearMaterialQuality()
	{
		_hasBits0 &= -524289;
	}

	public void ClearVegetationQuality()
	{
		_hasBits0 &= -1048577;
	}

	public void ClearColorClass()
	{
		_hasBits0 &= -2097153;
	}

	public void ClearColorSeverity()
	{
		_hasBits0 &= -4194305;
	}

	public void ClearGlobalIllumination()
	{
		_hasBits0 &= -8388609;
	}

	public void ClearReflectionQuality()
	{
		_hasBits0 &= -16777217;
	}

	public void ClearIsOpenCinematic()
	{
		_hasBits0 &= -33554433;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ScreenSettingData);
	}

	public bool Equals(ScreenSettingData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ScreenBrightness, other.ScreenBrightness))
		{
			return false;
		}
		if (ScreenQuality != other.ScreenQuality)
		{
			return false;
		}
		if (ScreenMode != other.ScreenMode)
		{
			return false;
		}
		if (ScreenResolution != other.ScreenResolution)
		{
			return false;
		}
		if (MainDisplay != other.MainDisplay)
		{
			return false;
		}
		if (ScreenRatio != other.ScreenRatio)
		{
			return false;
		}
		if (RefreshRate != other.RefreshRate)
		{
			return false;
		}
		if (Vsync != other.Vsync)
		{
			return false;
		}
		if (LockFrameRate != other.LockFrameRate)
		{
			return false;
		}
		if (Rtx != other.Rtx)
		{
			return false;
		}
		if (GraphicsQuality != other.GraphicsQuality)
		{
			return false;
		}
		if (FrameRateLow != other.FrameRateLow)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ImageQuality, other.ImageQuality))
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
		if (ColorClass != other.ColorClass)
		{
			return false;
		}
		if (ColorSeverity != other.ColorSeverity)
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
		if (IsOpenCinematic != other.IsOpenCinematic)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasScreenBrightness)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ScreenBrightness);
		}
		if (HasScreenQuality)
		{
			num ^= ScreenQuality.GetHashCode();
		}
		if (HasScreenMode)
		{
			num ^= ScreenMode.GetHashCode();
		}
		if (HasScreenResolution)
		{
			num ^= ScreenResolution.GetHashCode();
		}
		if (HasMainDisplay)
		{
			num ^= MainDisplay.GetHashCode();
		}
		if (HasScreenRatio)
		{
			num ^= ScreenRatio.GetHashCode();
		}
		if (HasRefreshRate)
		{
			num ^= RefreshRate.GetHashCode();
		}
		if (HasVsync)
		{
			num ^= Vsync.GetHashCode();
		}
		if (HasLockFrameRate)
		{
			num ^= LockFrameRate.GetHashCode();
		}
		if (HasRtx)
		{
			num ^= Rtx.GetHashCode();
		}
		if (HasGraphicsQuality)
		{
			num ^= GraphicsQuality.GetHashCode();
		}
		if (HasFrameRateLow)
		{
			num ^= FrameRateLow.GetHashCode();
		}
		if (HasImageQuality)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ImageQuality);
		}
		if (HasViewDistance)
		{
			num ^= ViewDistance.GetHashCode();
		}
		if (HasAntiAliasing)
		{
			num ^= AntiAliasing.GetHashCode();
		}
		if (HasPostProcessing)
		{
			num ^= PostProcessing.GetHashCode();
		}
		if (HasShadowQuality)
		{
			num ^= ShadowQuality.GetHashCode();
		}
		if (HasTextureQuality)
		{
			num ^= TextureQuality.GetHashCode();
		}
		if (HasFxQuality)
		{
			num ^= FxQuality.GetHashCode();
		}
		if (HasMaterialQuality)
		{
			num ^= MaterialQuality.GetHashCode();
		}
		if (HasVegetationQuality)
		{
			num ^= VegetationQuality.GetHashCode();
		}
		if (HasColorClass)
		{
			num ^= ColorClass.GetHashCode();
		}
		if (HasColorSeverity)
		{
			num ^= ColorSeverity.GetHashCode();
		}
		if (HasGlobalIllumination)
		{
			num ^= GlobalIllumination.GetHashCode();
		}
		if (HasReflectionQuality)
		{
			num ^= ReflectionQuality.GetHashCode();
		}
		if (HasIsOpenCinematic)
		{
			num ^= IsOpenCinematic.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasScreenBrightness)
		{
			output.WriteRawTag(13);
			output.WriteFloat(ScreenBrightness);
		}
		if (HasScreenQuality)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ScreenQuality);
		}
		if (HasScreenMode)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ScreenMode);
		}
		if (HasScreenResolution)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ScreenResolution);
		}
		if (HasMainDisplay)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MainDisplay);
		}
		if (HasScreenRatio)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ScreenRatio);
		}
		if (HasRefreshRate)
		{
			output.WriteRawTag(56);
			output.WriteInt32(RefreshRate);
		}
		if (HasVsync)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Vsync);
		}
		if (HasLockFrameRate)
		{
			output.WriteRawTag(72);
			output.WriteInt32(LockFrameRate);
		}
		if (HasRtx)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)Rtx);
		}
		if (HasGraphicsQuality)
		{
			output.WriteRawTag(88);
			output.WriteInt32(GraphicsQuality);
		}
		if (HasFrameRateLow)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)FrameRateLow);
		}
		if (HasImageQuality)
		{
			output.WriteRawTag(109);
			output.WriteFloat(ImageQuality);
		}
		if (HasViewDistance)
		{
			output.WriteRawTag(112);
			output.WriteInt32(ViewDistance);
		}
		if (HasAntiAliasing)
		{
			output.WriteRawTag(120);
			output.WriteInt32(AntiAliasing);
		}
		if (HasPostProcessing)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(PostProcessing);
		}
		if (HasShadowQuality)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(ShadowQuality);
		}
		if (HasTextureQuality)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(TextureQuality);
		}
		if (HasFxQuality)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(FxQuality);
		}
		if (HasMaterialQuality)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(MaterialQuality);
		}
		if (HasVegetationQuality)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(VegetationQuality);
		}
		if (HasColorClass)
		{
			output.WriteRawTag(176, 1);
			output.WriteEnum((int)ColorClass);
		}
		if (HasColorSeverity)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(ColorSeverity);
		}
		if (HasGlobalIllumination)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(GlobalIllumination);
		}
		if (HasReflectionQuality)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(ReflectionQuality);
		}
		if (HasIsOpenCinematic)
		{
			output.WriteRawTag(208, 1);
			output.WriteEnum((int)IsOpenCinematic);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasScreenBrightness)
		{
			num += 5;
		}
		if (HasScreenQuality)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScreenQuality);
		}
		if (HasScreenMode)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScreenMode);
		}
		if (HasScreenResolution)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScreenResolution);
		}
		if (HasMainDisplay)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MainDisplay);
		}
		if (HasScreenRatio)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScreenRatio);
		}
		if (HasRefreshRate)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RefreshRate);
		}
		if (HasVsync)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Vsync);
		}
		if (HasLockFrameRate)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LockFrameRate);
		}
		if (HasRtx)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Rtx);
		}
		if (HasGraphicsQuality)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GraphicsQuality);
		}
		if (HasFrameRateLow)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FrameRateLow);
		}
		if (HasImageQuality)
		{
			num += 5;
		}
		if (HasViewDistance)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ViewDistance);
		}
		if (HasAntiAliasing)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AntiAliasing);
		}
		if (HasPostProcessing)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PostProcessing);
		}
		if (HasShadowQuality)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShadowQuality);
		}
		if (HasTextureQuality)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TextureQuality);
		}
		if (HasFxQuality)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(FxQuality);
		}
		if (HasMaterialQuality)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaterialQuality);
		}
		if (HasVegetationQuality)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(VegetationQuality);
		}
		if (HasColorClass)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ColorClass);
		}
		if (HasColorSeverity)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ColorSeverity);
		}
		if (HasGlobalIllumination)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GlobalIllumination);
		}
		if (HasReflectionQuality)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReflectionQuality);
		}
		if (HasIsOpenCinematic)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsOpenCinematic);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ScreenSettingData other)
	{
		if (other != null)
		{
			if (other.HasScreenBrightness)
			{
				ScreenBrightness = other.ScreenBrightness;
			}
			if (other.HasScreenQuality)
			{
				ScreenQuality = other.ScreenQuality;
			}
			if (other.HasScreenMode)
			{
				ScreenMode = other.ScreenMode;
			}
			if (other.HasScreenResolution)
			{
				ScreenResolution = other.ScreenResolution;
			}
			if (other.HasMainDisplay)
			{
				MainDisplay = other.MainDisplay;
			}
			if (other.HasScreenRatio)
			{
				ScreenRatio = other.ScreenRatio;
			}
			if (other.HasRefreshRate)
			{
				RefreshRate = other.RefreshRate;
			}
			if (other.HasVsync)
			{
				Vsync = other.Vsync;
			}
			if (other.HasLockFrameRate)
			{
				LockFrameRate = other.LockFrameRate;
			}
			if (other.HasRtx)
			{
				Rtx = other.Rtx;
			}
			if (other.HasGraphicsQuality)
			{
				GraphicsQuality = other.GraphicsQuality;
			}
			if (other.HasFrameRateLow)
			{
				FrameRateLow = other.FrameRateLow;
			}
			if (other.HasImageQuality)
			{
				ImageQuality = other.ImageQuality;
			}
			if (other.HasViewDistance)
			{
				ViewDistance = other.ViewDistance;
			}
			if (other.HasAntiAliasing)
			{
				AntiAliasing = other.AntiAliasing;
			}
			if (other.HasPostProcessing)
			{
				PostProcessing = other.PostProcessing;
			}
			if (other.HasShadowQuality)
			{
				ShadowQuality = other.ShadowQuality;
			}
			if (other.HasTextureQuality)
			{
				TextureQuality = other.TextureQuality;
			}
			if (other.HasFxQuality)
			{
				FxQuality = other.FxQuality;
			}
			if (other.HasMaterialQuality)
			{
				MaterialQuality = other.MaterialQuality;
			}
			if (other.HasVegetationQuality)
			{
				VegetationQuality = other.VegetationQuality;
			}
			if (other.HasColorClass)
			{
				ColorClass = other.ColorClass;
			}
			if (other.HasColorSeverity)
			{
				ColorSeverity = other.ColorSeverity;
			}
			if (other.HasGlobalIllumination)
			{
				GlobalIllumination = other.GlobalIllumination;
			}
			if (other.HasReflectionQuality)
			{
				ReflectionQuality = other.ReflectionQuality;
			}
			if (other.HasIsOpenCinematic)
			{
				IsOpenCinematic = other.IsOpenCinematic;
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
				ScreenBrightness = input.ReadFloat();
				break;
			case 16u:
				ScreenQuality = input.ReadInt32();
				break;
			case 24u:
				ScreenMode = input.ReadInt32();
				break;
			case 32u:
				ScreenResolution = input.ReadInt32();
				break;
			case 40u:
				MainDisplay = input.ReadInt32();
				break;
			case 48u:
				ScreenRatio = input.ReadInt32();
				break;
			case 56u:
				RefreshRate = input.ReadInt32();
				break;
			case 64u:
				Vsync = (YesNoType)input.ReadEnum();
				break;
			case 72u:
				LockFrameRate = input.ReadInt32();
				break;
			case 80u:
				Rtx = (YesNoType)input.ReadEnum();
				break;
			case 88u:
				GraphicsQuality = input.ReadInt32();
				break;
			case 96u:
				FrameRateLow = (YesNoType)input.ReadEnum();
				break;
			case 109u:
				ImageQuality = input.ReadFloat();
				break;
			case 112u:
				ViewDistance = input.ReadInt32();
				break;
			case 120u:
				AntiAliasing = input.ReadInt32();
				break;
			case 128u:
				PostProcessing = input.ReadInt32();
				break;
			case 136u:
				ShadowQuality = input.ReadInt32();
				break;
			case 144u:
				TextureQuality = input.ReadInt32();
				break;
			case 152u:
				FxQuality = input.ReadInt32();
				break;
			case 160u:
				MaterialQuality = input.ReadInt32();
				break;
			case 168u:
				VegetationQuality = input.ReadInt32();
				break;
			case 176u:
				ColorClass = (EColorClass)input.ReadEnum();
				break;
			case 184u:
				ColorSeverity = input.ReadInt32();
				break;
			case 192u:
				GlobalIllumination = input.ReadInt32();
				break;
			case 200u:
				ReflectionQuality = input.ReadInt32();
				break;
			case 208u:
				IsOpenCinematic = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
