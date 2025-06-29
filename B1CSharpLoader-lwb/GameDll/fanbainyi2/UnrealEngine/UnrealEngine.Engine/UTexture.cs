using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818413729uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.Texture", "Engine", UnrealModuleType.Engine)]
public class UTexture : UStreamableRenderAsset, IInterface_AssetUserData, IInterface, IInterface_AsyncCompilation
{
	private static bool AdjustBrightness_IsValid;

	private static int AdjustBrightness_Offset;

	private static bool AdjustBrightnessCurve_IsValid;

	private static int AdjustBrightnessCurve_Offset;

	private static bool AdjustVibrance_IsValid;

	private static int AdjustVibrance_Offset;

	private static bool AdjustSaturation_IsValid;

	private static int AdjustSaturation_Offset;

	private static bool AdjustRGBCurve_IsValid;

	private static int AdjustRGBCurve_Offset;

	private static bool AdjustHue_IsValid;

	private static int AdjustHue_Offset;

	private static bool AdjustMinAlpha_IsValid;

	private static int AdjustMinAlpha_Offset;

	private static bool AdjustMaxAlpha_IsValid;

	private static int AdjustMaxAlpha_Offset;

	private static bool CompressionNoAlpha_IsValid;

	private static FFieldAddress CompressionNoAlpha_PropertyAddress;

	private static int CompressionNoAlpha_Offset;

	private static bool DeferCompression_IsValid;

	private static FFieldAddress DeferCompression_PropertyAddress;

	private static int DeferCompression_Offset;

	private static bool LossyCompressionAmount_IsValid;

	private static FFieldAddress LossyCompressionAmount_PropertyAddress;

	private static int LossyCompressionAmount_Offset;

	private static bool OodleTextureSdkVersion_IsValid;

	private static int OodleTextureSdkVersion_Offset;

	private static bool MaxTextureSize_IsValid;

	private static int MaxTextureSize_Offset;

	private static bool CompressionQuality_IsValid;

	private static FFieldAddress CompressionQuality_PropertyAddress;

	private static int CompressionQuality_Offset;

	private static bool DitherMipMapAlpha_IsValid;

	private static FFieldAddress DitherMipMapAlpha_PropertyAddress;

	private static int DitherMipMapAlpha_Offset;

	private static bool DoScaleMipsForAlphaCoverage_IsValid;

	private static FFieldAddress DoScaleMipsForAlphaCoverage_PropertyAddress;

	private static int DoScaleMipsForAlphaCoverage_Offset;

	private static bool AlphaCoverageThresholds_IsValid;

	private static int AlphaCoverageThresholds_Offset;

	private static bool PreserveBorder_IsValid;

	private static FFieldAddress PreserveBorder_PropertyAddress;

	private static int PreserveBorder_Offset;

	private static bool FlipGreenChannel_IsValid;

	private static FFieldAddress FlipGreenChannel_PropertyAddress;

	private static int FlipGreenChannel_Offset;

	private static bool PowerOfTwoMode_IsValid;

	private static FFieldAddress PowerOfTwoMode_PropertyAddress;

	private static int PowerOfTwoMode_Offset;

	private static bool PaddingColor_IsValid;

	private static int PaddingColor_Offset;

	private static bool ChromaKeyTexture_IsValid;

	private static FFieldAddress ChromaKeyTexture_PropertyAddress;

	private static int ChromaKeyTexture_Offset;

	private static bool ChromaKeyThreshold_IsValid;

	private static int ChromaKeyThreshold_Offset;

	private static bool ChromaKeyColor_IsValid;

	private static int ChromaKeyColor_Offset;

	private static bool MipGenSettings_IsValid;

	private static FFieldAddress MipGenSettings_PropertyAddress;

	private static int MipGenSettings_Offset;

	private static bool CompositeTexture_IsValid;

	private static int CompositeTexture_Offset;

	private static bool CompositeTextureMode_IsValid;

	private static FFieldAddress CompositeTextureMode_PropertyAddress;

	private static int CompositeTextureMode_Offset;

	private static bool CompositePower_IsValid;

	private static int CompositePower_Offset;

	private static bool LODBias_IsValid;

	private static int LODBias_Offset;

	private static bool CompressionSettings_IsValid;

	private static FFieldAddress CompressionSettings_PropertyAddress;

	private static int CompressionSettings_Offset;

	private static bool Filter_IsValid;

	private static FFieldAddress Filter_PropertyAddress;

	private static int Filter_Offset;

	private static bool MipLoadOptions_IsValid;

	private static FFieldAddress MipLoadOptions_PropertyAddress;

	private static int MipLoadOptions_Offset;

	private static bool LODGroup_IsValid;

	private static FFieldAddress LODGroup_PropertyAddress;

	private static int LODGroup_Offset;

	private static bool SRGB_IsValid;

	private static FFieldAddress SRGB_PropertyAddress;

	private static int SRGB_Offset;

	private static bool SourceColorSettings_IsValid;

	private static int SourceColorSettings_Offset;

	private static bool UseLegacyGamma_IsValid;

	private static FFieldAddress UseLegacyGamma_PropertyAddress;

	private static int UseLegacyGamma_Offset;

	private static bool VirtualTextureStreaming_IsValid;

	private static FFieldAddress VirtualTextureStreaming_PropertyAddress;

	private static int VirtualTextureStreaming_Offset;

	private static bool AllowAllocatedInSysMemType_IsValid;

	private static int AllowAllocatedInSysMemType_Offset;

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:AdjustBrightness")]
	public float AdjustBrightness
	{
		get
		{
			CheckDestroyed();
			if (!AdjustBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustBrightness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdjustBrightness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustBrightness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdjustBrightness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:AdjustBrightnessCurve")]
	public float AdjustBrightnessCurve
	{
		get
		{
			CheckDestroyed();
			if (!AdjustBrightnessCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustBrightnessCurve");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdjustBrightnessCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustBrightnessCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustBrightnessCurve");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdjustBrightnessCurve_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:AdjustVibrance")]
	public float AdjustVibrance
	{
		get
		{
			CheckDestroyed();
			if (!AdjustVibrance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustVibrance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdjustVibrance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustVibrance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustVibrance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdjustVibrance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:AdjustSaturation")]
	public float AdjustSaturation
	{
		get
		{
			CheckDestroyed();
			if (!AdjustSaturation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustSaturation");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdjustSaturation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustSaturation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustSaturation");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdjustSaturation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:AdjustRGBCurve")]
	public float AdjustRGBCurve
	{
		get
		{
			CheckDestroyed();
			if (!AdjustRGBCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustRGBCurve");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdjustRGBCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustRGBCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustRGBCurve");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdjustRGBCurve_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:AdjustHue")]
	public float AdjustHue
	{
		get
		{
			CheckDestroyed();
			if (!AdjustHue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustHue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdjustHue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustHue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustHue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdjustHue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:AdjustMinAlpha")]
	public float AdjustMinAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AdjustMinAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustMinAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdjustMinAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustMinAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustMinAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdjustMinAlpha_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:AdjustMaxAlpha")]
	public float AdjustMaxAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AdjustMaxAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustMaxAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdjustMaxAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustMaxAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AdjustMaxAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdjustMaxAlpha_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755502520270853uL)]
	[UMetaPath("/Script/Engine.Texture:CompressionNoAlpha")]
	public bool CompressionNoAlpha
	{
		get
		{
			CheckDestroyed();
			if (!CompressionNoAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompressionNoAlpha");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CompressionNoAlpha_Offset), 0, CompressionNoAlpha_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompressionNoAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompressionNoAlpha");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CompressionNoAlpha_Offset), 0, CompressionNoAlpha_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755502520270853uL)]
	[UMetaPath("/Script/Engine.Texture:DeferCompression")]
	public bool DeferCompression
	{
		get
		{
			CheckDestroyed();
			if (!DeferCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:DeferCompression");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DeferCompression_Offset), 0, DeferCompression_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DeferCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:DeferCompression");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DeferCompression_Offset), 0, DeferCompression_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/Engine.Texture:LossyCompressionAmount")]
	public ETextureLossyCompressionAmount LossyCompressionAmount
	{
		get
		{
			CheckDestroyed();
			if (!LossyCompressionAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:LossyCompressionAmount");
				return ETextureLossyCompressionAmount.TLCA_Default;
			}
			return EnumMarshaler<ETextureLossyCompressionAmount>.FromNative(IntPtr.Add(base.Address, LossyCompressionAmount_Offset), 0, LossyCompressionAmount_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LossyCompressionAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:LossyCompressionAmount");
			}
			else
			{
				EnumMarshaler<ETextureLossyCompressionAmount>.ToNative(IntPtr.Add(base.Address, LossyCompressionAmount_Offset), 0, LossyCompressionAmount_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/Engine.Texture:OodleTextureSdkVersion")]
	public FName OodleTextureSdkVersion
	{
		get
		{
			CheckDestroyed();
			if (!OodleTextureSdkVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:OodleTextureSdkVersion");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OodleTextureSdkVersion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OodleTextureSdkVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:OodleTextureSdkVersion");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OodleTextureSdkVersion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524309uL)]
	[UMetaPath("/Script/Engine.Texture:MaxTextureSize")]
	public int MaxTextureSize
	{
		get
		{
			CheckDestroyed();
			if (!MaxTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:MaxTextureSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxTextureSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:MaxTextureSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxTextureSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/Engine.Texture:CompressionQuality")]
	public ETextureCompressionQuality CompressionQuality
	{
		get
		{
			CheckDestroyed();
			if (!CompressionQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompressionQuality");
				return ETextureCompressionQuality.TCQ_Default;
			}
			return EnumMarshaler<ETextureCompressionQuality>.FromNative(IntPtr.Add(base.Address, CompressionQuality_Offset), 0, CompressionQuality_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompressionQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompressionQuality");
			}
			else
			{
				EnumMarshaler<ETextureCompressionQuality>.ToNative(IntPtr.Add(base.Address, CompressionQuality_Offset), 0, CompressionQuality_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759900566781957uL)]
	[UMetaPath("/Script/Engine.Texture:bDitherMipMapAlpha")]
	public bool DitherMipMapAlpha
	{
		get
		{
			CheckDestroyed();
			if (!DitherMipMapAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bDitherMipMapAlpha");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DitherMipMapAlpha_Offset), 0, DitherMipMapAlpha_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DitherMipMapAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bDitherMipMapAlpha");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DitherMipMapAlpha_Offset), 0, DitherMipMapAlpha_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/Engine.Texture:bDoScaleMipsForAlphaCoverage")]
	public bool DoScaleMipsForAlphaCoverage
	{
		get
		{
			CheckDestroyed();
			if (!DoScaleMipsForAlphaCoverage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bDoScaleMipsForAlphaCoverage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DoScaleMipsForAlphaCoverage_Offset), 0, DoScaleMipsForAlphaCoverage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DoScaleMipsForAlphaCoverage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bDoScaleMipsForAlphaCoverage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DoScaleMipsForAlphaCoverage_Offset), 0, DoScaleMipsForAlphaCoverage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/Engine.Texture:AlphaCoverageThresholds")]
	public FVector4 AlphaCoverageThresholds
	{
		get
		{
			CheckDestroyed();
			if (!AlphaCoverageThresholds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AlphaCoverageThresholds");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, AlphaCoverageThresholds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AlphaCoverageThresholds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AlphaCoverageThresholds");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, AlphaCoverageThresholds_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759900566781957uL)]
	[UMetaPath("/Script/Engine.Texture:bPreserveBorder")]
	public bool PreserveBorder
	{
		get
		{
			CheckDestroyed();
			if (!PreserveBorder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bPreserveBorder");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PreserveBorder_Offset), 0, PreserveBorder_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreserveBorder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bPreserveBorder");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PreserveBorder_Offset), 0, PreserveBorder_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759900566781957uL)]
	[UMetaPath("/Script/Engine.Texture:bFlipGreenChannel")]
	public bool FlipGreenChannel
	{
		get
		{
			CheckDestroyed();
			if (!FlipGreenChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bFlipGreenChannel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FlipGreenChannel_Offset), 0, FlipGreenChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FlipGreenChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bFlipGreenChannel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FlipGreenChannel_Offset), 0, FlipGreenChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:PowerOfTwoMode")]
	public ETexturePowerOfTwoSetting PowerOfTwoMode
	{
		get
		{
			CheckDestroyed();
			if (!PowerOfTwoMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:PowerOfTwoMode");
				return ETexturePowerOfTwoSetting.None;
			}
			return EnumMarshaler<ETexturePowerOfTwoSetting>.FromNative(IntPtr.Add(base.Address, PowerOfTwoMode_Offset), 0, PowerOfTwoMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PowerOfTwoMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:PowerOfTwoMode");
			}
			else
			{
				EnumMarshaler<ETexturePowerOfTwoSetting>.ToNative(IntPtr.Add(base.Address, PowerOfTwoMode_Offset), 0, PowerOfTwoMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:PaddingColor")]
	public FColor PaddingColor
	{
		get
		{
			CheckDestroyed();
			if (!PaddingColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:PaddingColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, PaddingColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PaddingColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:PaddingColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, PaddingColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:bChromaKeyTexture")]
	public bool ChromaKeyTexture
	{
		get
		{
			CheckDestroyed();
			if (!ChromaKeyTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bChromaKeyTexture");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ChromaKeyTexture_Offset), 0, ChromaKeyTexture_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ChromaKeyTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bChromaKeyTexture");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ChromaKeyTexture_Offset), 0, ChromaKeyTexture_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:ChromaKeyThreshold")]
	public float ChromaKeyThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ChromaKeyThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:ChromaKeyThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ChromaKeyThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChromaKeyThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:ChromaKeyThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ChromaKeyThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:ChromaKeyColor")]
	public FColor ChromaKeyColor
	{
		get
		{
			CheckDestroyed();
			if (!ChromaKeyColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:ChromaKeyColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, ChromaKeyColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChromaKeyColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:ChromaKeyColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, ChromaKeyColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Texture:MipGenSettings")]
	public ETextureMipGenSettings MipGenSettings
	{
		get
		{
			CheckDestroyed();
			if (!MipGenSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:MipGenSettings");
				return ETextureMipGenSettings.TMGS_FromTextureGroup;
			}
			return EnumMarshaler<ETextureMipGenSettings>.FromNative(IntPtr.Add(base.Address, MipGenSettings_Offset), 0, MipGenSettings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MipGenSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:MipGenSettings");
			}
			else
			{
				EnumMarshaler<ETextureMipGenSettings>.ToNative(IntPtr.Add(base.Address, MipGenSettings_Offset), 0, MipGenSettings_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881403500855813uL)]
	[UMetaPath("/Script/Engine.Texture:CompositeTexture")]
	public UTexture CompositeTexture
	{
		get
		{
			CheckDestroyed();
			if (!CompositeTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompositeTexture");
				return null;
			}
			return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(base.Address, CompositeTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompositeTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompositeTexture");
			}
			else
			{
				UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(base.Address, CompositeTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/Engine.Texture:CompositeTextureMode")]
	public ECompositeTextureMode CompositeTextureMode
	{
		get
		{
			CheckDestroyed();
			if (!CompositeTextureMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompositeTextureMode");
				return ECompositeTextureMode.CTM_Disabled;
			}
			return EnumMarshaler<ECompositeTextureMode>.FromNative(IntPtr.Add(base.Address, CompositeTextureMode_Offset), 0, CompositeTextureMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompositeTextureMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompositeTextureMode");
			}
			else
			{
				EnumMarshaler<ECompositeTextureMode>.ToNative(IntPtr.Add(base.Address, CompositeTextureMode_Offset), 0, CompositeTextureMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/Engine.Texture:CompositePower")]
	public float CompositePower
	{
		get
		{
			CheckDestroyed();
			if (!CompositePower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompositePower");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CompositePower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompositePower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompositePower");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CompositePower_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.Texture:LODBias")]
	public int LODBias
	{
		get
		{
			CheckDestroyed();
			if (!LODBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:LODBias");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LODBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LODBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:LODBias");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LODBias_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.Texture:CompressionSettings")]
	public ETextureCompressionSettings CompressionSettings
	{
		get
		{
			CheckDestroyed();
			if (!CompressionSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompressionSettings");
				return ETextureCompressionSettings.TC_Default;
			}
			return EnumMarshaler<ETextureCompressionSettings>.FromNative(IntPtr.Add(base.Address, CompressionSettings_Offset), 0, CompressionSettings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompressionSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:CompressionSettings");
			}
			else
			{
				EnumMarshaler<ETextureCompressionSettings>.ToNative(IntPtr.Add(base.Address, CompressionSettings_Offset), 0, CompressionSettings_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760966792413701uL)]
	[UMetaPath("/Script/Engine.Texture:Filter")]
	public ETextureFilter Filter
	{
		get
		{
			CheckDestroyed();
			if (!Filter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:Filter");
				return ETextureFilter.TF_Nearest;
			}
			return EnumMarshaler<ETextureFilter>.FromNative(IntPtr.Add(base.Address, Filter_Offset), 0, Filter_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Filter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:Filter");
			}
			else
			{
				EnumMarshaler<ETextureFilter>.ToNative(IntPtr.Add(base.Address, Filter_Offset), 0, Filter_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760966792413701uL)]
	[UMetaPath("/Script/Engine.Texture:MipLoadOptions")]
	public ETextureMipLoadOptions MipLoadOptions
	{
		get
		{
			CheckDestroyed();
			if (!MipLoadOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:MipLoadOptions");
				return ETextureMipLoadOptions.Default;
			}
			return EnumMarshaler<ETextureMipLoadOptions>.FromNative(IntPtr.Add(base.Address, MipLoadOptions_Offset), 0, MipLoadOptions_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MipLoadOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:MipLoadOptions");
			}
			else
			{
				EnumMarshaler<ETextureMipLoadOptions>.ToNative(IntPtr.Add(base.Address, MipLoadOptions_Offset), 0, MipLoadOptions_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.Texture:LODGroup")]
	public ETextureGroup LODGroup
	{
		get
		{
			CheckDestroyed();
			if (!LODGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:LODGroup");
				return ETextureGroup.TEXTUREGROUP_World;
			}
			return EnumMarshaler<ETextureGroup>.FromNative(IntPtr.Add(base.Address, LODGroup_Offset), 0, LODGroup_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LODGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:LODGroup");
			}
			else
			{
				EnumMarshaler<ETextureGroup>.ToNative(IntPtr.Add(base.Address, LODGroup_Offset), 0, LODGroup_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756567672160261uL)]
	[UMetaPath("/Script/Engine.Texture:SRGB")]
	public bool SRGB
	{
		get
		{
			CheckDestroyed();
			if (!SRGB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:SRGB");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SRGB_Offset), 0, SRGB_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SRGB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:SRGB");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SRGB_Offset), 0, SRGB_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508100753096709uL)]
	[UMetaPath("/Script/Engine.Texture:SourceColorSettings")]
	public FTextureSourceColorSettings SourceColorSettings
	{
		get
		{
			CheckDestroyed();
			if (!SourceColorSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:SourceColorSettings");
				return default(FTextureSourceColorSettings);
			}
			return FTextureSourceColorSettings.FromNative(IntPtr.Add(base.Address, SourceColorSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceColorSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:SourceColorSettings");
			}
			else
			{
				FTextureSourceColorSettings.ToNative(IntPtr.Add(base.Address, SourceColorSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759900566781957uL)]
	[UMetaPath("/Script/Engine.Texture:bUseLegacyGamma")]
	public bool UseLegacyGamma
	{
		get
		{
			CheckDestroyed();
			if (!UseLegacyGamma_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bUseLegacyGamma");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseLegacyGamma_Offset), 0, UseLegacyGamma_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseLegacyGamma_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:bUseLegacyGamma");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseLegacyGamma_Offset), 0, UseLegacyGamma_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760965718671381uL)]
	[UMetaPath("/Script/Engine.Texture:VirtualTextureStreaming")]
	public bool VirtualTextureStreaming
	{
		get
		{
			CheckDestroyed();
			if (!VirtualTextureStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:VirtualTextureStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, VirtualTextureStreaming_Offset), 0, VirtualTextureStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VirtualTextureStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:VirtualTextureStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, VirtualTextureStreaming_Offset), 0, VirtualTextureStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/Engine.Texture:AllowAllocatedInSysMemType")]
	public int AllowAllocatedInSysMemType
	{
		get
		{
			CheckDestroyed();
			if (!AllowAllocatedInSysMemType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AllowAllocatedInSysMemType");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AllowAllocatedInSysMemType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AllowAllocatedInSysMemType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Texture:AllowAllocatedInSysMemType");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AllowAllocatedInSysMemType_Offset), value);
			}
		}
	}

	static UTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.Texture");
		AdjustBrightness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdjustBrightness");
		AdjustBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdjustBrightness", Classes.FFloatProperty);
		AdjustBrightnessCurve_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdjustBrightnessCurve");
		AdjustBrightnessCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdjustBrightnessCurve", Classes.FFloatProperty);
		AdjustVibrance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdjustVibrance");
		AdjustVibrance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdjustVibrance", Classes.FFloatProperty);
		AdjustSaturation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdjustSaturation");
		AdjustSaturation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdjustSaturation", Classes.FFloatProperty);
		AdjustRGBCurve_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdjustRGBCurve");
		AdjustRGBCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdjustRGBCurve", Classes.FFloatProperty);
		AdjustHue_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdjustHue");
		AdjustHue_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdjustHue", Classes.FFloatProperty);
		AdjustMinAlpha_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdjustMinAlpha");
		AdjustMinAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdjustMinAlpha", Classes.FFloatProperty);
		AdjustMaxAlpha_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdjustMaxAlpha");
		AdjustMaxAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdjustMaxAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CompressionNoAlpha_PropertyAddress, unrealStruct, "CompressionNoAlpha");
		CompressionNoAlpha_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CompressionNoAlpha");
		CompressionNoAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CompressionNoAlpha", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeferCompression_PropertyAddress, unrealStruct, "DeferCompression");
		DeferCompression_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DeferCompression");
		DeferCompression_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DeferCompression", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LossyCompressionAmount_PropertyAddress, unrealStruct, "LossyCompressionAmount");
		LossyCompressionAmount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LossyCompressionAmount");
		LossyCompressionAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LossyCompressionAmount", Classes.FByteProperty);
		OodleTextureSdkVersion_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OodleTextureSdkVersion");
		OodleTextureSdkVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OodleTextureSdkVersion", Classes.FNameProperty);
		MaxTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxTextureSize");
		MaxTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxTextureSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CompressionQuality_PropertyAddress, unrealStruct, "CompressionQuality");
		CompressionQuality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CompressionQuality");
		CompressionQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CompressionQuality", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DitherMipMapAlpha_PropertyAddress, unrealStruct, "bDitherMipMapAlpha");
		DitherMipMapAlpha_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDitherMipMapAlpha");
		DitherMipMapAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDitherMipMapAlpha", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DoScaleMipsForAlphaCoverage_PropertyAddress, unrealStruct, "bDoScaleMipsForAlphaCoverage");
		DoScaleMipsForAlphaCoverage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDoScaleMipsForAlphaCoverage");
		DoScaleMipsForAlphaCoverage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDoScaleMipsForAlphaCoverage", Classes.FBoolProperty);
		AlphaCoverageThresholds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AlphaCoverageThresholds");
		AlphaCoverageThresholds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AlphaCoverageThresholds", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PreserveBorder_PropertyAddress, unrealStruct, "bPreserveBorder");
		PreserveBorder_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPreserveBorder");
		PreserveBorder_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPreserveBorder", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FlipGreenChannel_PropertyAddress, unrealStruct, "bFlipGreenChannel");
		FlipGreenChannel_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bFlipGreenChannel");
		FlipGreenChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bFlipGreenChannel", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PowerOfTwoMode_PropertyAddress, unrealStruct, "PowerOfTwoMode");
		PowerOfTwoMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PowerOfTwoMode");
		PowerOfTwoMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PowerOfTwoMode", Classes.FByteProperty);
		PaddingColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PaddingColor");
		PaddingColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PaddingColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ChromaKeyTexture_PropertyAddress, unrealStruct, "bChromaKeyTexture");
		ChromaKeyTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bChromaKeyTexture");
		ChromaKeyTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bChromaKeyTexture", Classes.FBoolProperty);
		ChromaKeyThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ChromaKeyThreshold");
		ChromaKeyThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ChromaKeyThreshold", Classes.FFloatProperty);
		ChromaKeyColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ChromaKeyColor");
		ChromaKeyColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ChromaKeyColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MipGenSettings_PropertyAddress, unrealStruct, "MipGenSettings");
		MipGenSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MipGenSettings");
		MipGenSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MipGenSettings", Classes.FByteProperty);
		CompositeTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CompositeTexture");
		CompositeTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CompositeTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CompositeTextureMode_PropertyAddress, unrealStruct, "CompositeTextureMode");
		CompositeTextureMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CompositeTextureMode");
		CompositeTextureMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CompositeTextureMode", Classes.FByteProperty);
		CompositePower_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CompositePower");
		CompositePower_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CompositePower", Classes.FFloatProperty);
		LODBias_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LODBias");
		LODBias_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LODBias", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CompressionSettings_PropertyAddress, unrealStruct, "CompressionSettings");
		CompressionSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CompressionSettings");
		CompressionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CompressionSettings", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Filter_PropertyAddress, unrealStruct, "Filter");
		Filter_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Filter");
		Filter_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Filter", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MipLoadOptions_PropertyAddress, unrealStruct, "MipLoadOptions");
		MipLoadOptions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MipLoadOptions");
		MipLoadOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MipLoadOptions", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LODGroup_PropertyAddress, unrealStruct, "LODGroup");
		LODGroup_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LODGroup");
		LODGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LODGroup", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SRGB_PropertyAddress, unrealStruct, "SRGB");
		SRGB_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SRGB");
		SRGB_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SRGB", Classes.FBoolProperty);
		SourceColorSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceColorSettings");
		SourceColorSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceColorSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseLegacyGamma_PropertyAddress, unrealStruct, "bUseLegacyGamma");
		UseLegacyGamma_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseLegacyGamma");
		UseLegacyGamma_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseLegacyGamma", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VirtualTextureStreaming_PropertyAddress, unrealStruct, "VirtualTextureStreaming");
		VirtualTextureStreaming_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VirtualTextureStreaming");
		VirtualTextureStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VirtualTextureStreaming", Classes.FBoolProperty);
		AllowAllocatedInSysMemType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AllowAllocatedInSysMemType");
		AllowAllocatedInSysMemType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AllowAllocatedInSysMemType", Classes.FIntProperty);
	}
}
