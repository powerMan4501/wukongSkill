using System;
using b1;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor")]
public class BWS_DispLibImageProcessor : UObject
{
	private const string ImageProcessConfPath = "/Game/GSMobileMatLib/Configs/DA_ImageProcessorConf.DA_ImageProcessorConf";

	private static bool KawaseBlurMatInst_IsValid;

	private static int KawaseBlurMatInst_Offset;

	private static bool BlitMatInst_IsValid;

	private static int BlitMatInst_Offset;

	private static bool CombineRGBMatInst_IsValid;

	private static int CombineRGBMatInst_Offset;

	private static bool CombineMatInst_IsValid;

	private static int CombineMatInst_Offset;

	private static bool Config_IsValid;

	private static int Config_Offset;

	private static bool RenderTarget0_IsValid;

	private static int RenderTarget0_Offset;

	private static bool RenderTarget1_IsValid;

	private static int RenderTarget1_Offset;

	private static bool SourceTexName_IsValid;

	private static int SourceTexName_Offset;

	private static bool ShiftName_IsValid;

	private static int ShiftName_Offset;

	private static bool IsFlipVerticalAxisName_IsValid;

	private static int IsFlipVerticalAxisName_Offset;

	private static bool BlendTexName_IsValid;

	private static int BlendTexName_Offset;

	private static bool BlendAlphaName_IsValid;

	private static int BlendAlphaName_Offset;

	private static bool RChannelName_IsValid;

	private static int RChannelName_Offset;

	private static bool GChannelName_IsValid;

	private static int GChannelName_Offset;

	private static bool BChannelName_IsValid;

	private static int BChannelName_Offset;

	private static bool Blit_IsValid;

	private static IntPtr Blit_FunctionAddress;

	private static int Blit_ParamsSize;

	private static bool Blit_SrcTex_IsValid;

	private static int Blit_SrcTex_Offset;

	private static bool Blit_BlendTex_IsValid;

	private static int Blit_BlendTex_Offset;

	private static bool Blit_DstTex_IsValid;

	private static int Blit_DstTex_Offset;

	private static bool Blit_BlendAlpha_IsValid;

	private static int Blit_BlendAlpha_Offset;

	private static bool Blit_IsFlipVerticalAxis_IsValid;

	private static int Blit_IsFlipVerticalAxis_Offset;

	private static FFieldAddress Blit_IsFlipVerticalAxis_PropertyAddress;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_WorldContext_IsValid;

	private static int Init_WorldContext_Offset;

	private static bool Init_ConfigPath_IsValid;

	private static int Init_ConfigPath_Offset;

	private static FFieldAddress Init_ConfigPath_PropertyAddress;

	private static bool KawaseBlur_IsValid;

	private static IntPtr KawaseBlur_FunctionAddress;

	private static int KawaseBlur_ParamsSize;

	private static bool KawaseBlur_SrcTex_IsValid;

	private static int KawaseBlur_SrcTex_Offset;

	private static bool KawaseBlur_DstTex_IsValid;

	private static int KawaseBlur_DstTex_Offset;

	private static bool KawaseBlur_IsFlipVerticalAxis_IsValid;

	private static int KawaseBlur_IsFlipVerticalAxis_Offset;

	private static FFieldAddress KawaseBlur_IsFlipVerticalAxis_PropertyAddress;

	private static bool CombileRGB_IsValid;

	private static IntPtr CombileRGB_FunctionAddress;

	private static int CombileRGB_ParamsSize;

	private static bool CombileRGB_RChannel_IsValid;

	private static int CombileRGB_RChannel_Offset;

	private static bool CombileRGB_GChannel_IsValid;

	private static int CombileRGB_GChannel_Offset;

	private static bool CombileRGB_BChannel_IsValid;

	private static int CombileRGB_BChannel_Offset;

	private static bool CombileRGB_DstTex_IsValid;

	private static int CombileRGB_DstTex_Offset;

	private static bool CombileRGB_IsFlipVerticalAxis_IsValid;

	private static int CombileRGB_IsFlipVerticalAxis_Offset;

	private static FFieldAddress CombileRGB_IsFlipVerticalAxis_PropertyAddress;

	private static bool InitParameters_IsValid;

	private static IntPtr InitParameters_FunctionAddress;

	private static int InitParameters_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:KawaseBlurMatInst")]
	public UMaterialInstanceDynamic KawaseBlurMatInst
	{
		get
		{
			CheckDestroyed();
			if (!KawaseBlurMatInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:KawaseBlurMatInst");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, KawaseBlurMatInst_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KawaseBlurMatInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:KawaseBlurMatInst");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, KawaseBlurMatInst_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:BlitMatInst")]
	public UMaterialInstanceDynamic BlitMatInst
	{
		get
		{
			CheckDestroyed();
			if (!BlitMatInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:BlitMatInst");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, BlitMatInst_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlitMatInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:BlitMatInst");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, BlitMatInst_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:CombineRGBMatInst")]
	public UMaterialInstanceDynamic CombineRGBMatInst
	{
		get
		{
			CheckDestroyed();
			if (!CombineRGBMatInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:CombineRGBMatInst");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, CombineRGBMatInst_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CombineRGBMatInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:CombineRGBMatInst");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, CombineRGBMatInst_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:CombineMatInst")]
	public UMaterialInstanceDynamic CombineMatInst
	{
		get
		{
			CheckDestroyed();
			if (!CombineMatInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:CombineMatInst");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, CombineMatInst_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CombineMatInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:CombineMatInst");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, CombineMatInst_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:Config")]
	public BWS_DispLibImageProcessorConfig Config
	{
		get
		{
			CheckDestroyed();
			if (!Config_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:Config");
				return null;
			}
			return UObjectMarshaler<BWS_DispLibImageProcessorConfig>.FromNative(IntPtr.Add(base.Address, Config_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Config_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:Config");
			}
			else
			{
				UObjectMarshaler<BWS_DispLibImageProcessorConfig>.ToNative(IntPtr.Add(base.Address, Config_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:RenderTarget0")]
	public UTextureRenderTarget2D RenderTarget0
	{
		get
		{
			CheckDestroyed();
			if (!RenderTarget0_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:RenderTarget0");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RenderTarget0_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderTarget0_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:RenderTarget0");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RenderTarget0_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:RenderTarget1")]
	public UTextureRenderTarget2D RenderTarget1
	{
		get
		{
			CheckDestroyed();
			if (!RenderTarget1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:RenderTarget1");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RenderTarget1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderTarget1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:RenderTarget1");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RenderTarget1_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:SourceTexName")]
	private FName SourceTexName
	{
		get
		{
			CheckDestroyed();
			if (!SourceTexName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:SourceTexName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SourceTexName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceTexName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:SourceTexName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SourceTexName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:ShiftName")]
	private FName ShiftName
	{
		get
		{
			CheckDestroyed();
			if (!ShiftName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:ShiftName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ShiftName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShiftName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:ShiftName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ShiftName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:IsFlipVerticalAxisName")]
	private FName IsFlipVerticalAxisName
	{
		get
		{
			CheckDestroyed();
			if (!IsFlipVerticalAxisName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:IsFlipVerticalAxisName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, IsFlipVerticalAxisName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IsFlipVerticalAxisName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:IsFlipVerticalAxisName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, IsFlipVerticalAxisName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:BlendTexName")]
	private FName BlendTexName
	{
		get
		{
			CheckDestroyed();
			if (!BlendTexName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:BlendTexName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BlendTexName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendTexName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:BlendTexName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BlendTexName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:BlendAlphaName")]
	private FName BlendAlphaName
	{
		get
		{
			CheckDestroyed();
			if (!BlendAlphaName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:BlendAlphaName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BlendAlphaName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendAlphaName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:BlendAlphaName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BlendAlphaName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:RChannelName")]
	private FName RChannelName
	{
		get
		{
			CheckDestroyed();
			if (!RChannelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:RChannelName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RChannelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RChannelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:RChannelName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RChannelName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:GChannelName")]
	private FName GChannelName
	{
		get
		{
			CheckDestroyed();
			if (!GChannelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:GChannelName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, GChannelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GChannelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:GChannelName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, GChannelName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:BChannelName")]
	private FName BChannelName
	{
		get
		{
			CheckDestroyed();
			if (!BChannelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:BChannelName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BChannelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BChannelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessor:BChannelName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BChannelName_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:InitParameters")]
	public void InitParameters()
	{
		SourceTexName = B1GlobalFNames.SourceTex;
		ShiftName = B1GlobalFNames.Shift;
		IsFlipVerticalAxisName = B1GlobalFNames.FlipVerticalAxis;
		BlendTexName = B1GlobalFNames.BlendTex;
		BlendAlphaName = B1GlobalFNames.BlendAlpha;
		RChannelName = B1GlobalFNames.RChannel;
		GChannelName = B1GlobalFNames.GChannel;
		BChannelName = B1GlobalFNames.BChannel;
	}

	public void Clear()
	{
		if (RenderTarget0 != null && !RenderTarget0.IsPendingKill)
		{
			URenderingLibrary.ReleaseRenderTarget2D(RenderTarget0);
		}
		if (RenderTarget1 != null && !RenderTarget1.IsPendingKill)
		{
			URenderingLibrary.ReleaseRenderTarget2D(RenderTarget1);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:Init")]
	public void Init(UObject WorldContext, string ConfigPath)
	{
		if (Config == null)
		{
			if (ConfigPath == null || ConfigPath.Length == 0)
			{
				ConfigPath = "/Game/GSMobileMatLib/Configs/DA_ImageProcessorConf.DA_ImageProcessorConf";
			}
			Config = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<BWS_DispLibImageProcessorConfig>(ConfigPath, ELoadResourceType.SyncLoadAndCache);
		}
		InitParameters();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:Blit")]
	public void Blit(UTexture SrcTex, UTexture BlendTex, UTextureRenderTarget2D DstTex, float BlendAlpha, bool IsFlipVerticalAxis)
	{
		if (BlitMatInst == null)
		{
			BlitMatInst = UMaterialLibrary.CreateDynamicMaterialInstance(this, Config.BlitMaterialPrototype, B1GlobalFNames.Blit, EMIDCreationFlags.None);
		}
		if (BlitMatInst != null)
		{
			BlitMatInst.SetTextureParameterValue(SourceTexName, SrcTex);
			BlitMatInst.SetTextureParameterValue(BlendTexName, BlendTex);
			BlitMatInst.SetScalarParameterValue(IsFlipVerticalAxisName, IsFlipVerticalAxis ? 1f : 0f);
			BlitMatInst.SetScalarParameterValue(BlendAlphaName, BlendAlpha);
			URenderingLibrary.DrawMaterialToRenderTarget(this, DstTex, BlitMatInst);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:CombileRGB")]
	public void CombileRGB(UTexture RChannel, UTexture GChannel, UTexture BChannel, UTextureRenderTarget2D DstTex, bool IsFlipVerticalAxis)
	{
		if (CombineRGBMatInst == null)
		{
			CombineRGBMatInst = UMaterialLibrary.CreateDynamicMaterialInstance(this, Config.CombineRGBMaterialPrototype, B1GlobalFNames.CombineRGB, EMIDCreationFlags.None);
		}
		if (CombineRGBMatInst != null && (RChannel != null || GChannel != null || BChannel != null))
		{
			if (RChannel != null)
			{
				CombineRGBMatInst.SetTextureParameterValue(RChannelName, RChannel);
			}
			if (GChannel != null)
			{
				CombineRGBMatInst.SetTextureParameterValue(GChannelName, GChannel);
			}
			if (BChannel != null)
			{
				CombineRGBMatInst.SetTextureParameterValue(BChannelName, BChannel);
			}
			CombineRGBMatInst.SetScalarParameterValue(IsFlipVerticalAxisName, IsFlipVerticalAxis ? 1f : 0f);
			URenderingLibrary.DrawMaterialToRenderTarget(this, DstTex, CombineRGBMatInst);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessor:KawaseBlur")]
	public void KawaseBlur(UTexture SrcTex, UTextureRenderTarget2D DstTex, bool IsFlipVerticalAxis)
	{
		if (DstTex == null || DstTex.IsPendingKill)
		{
			return;
		}
		if (KawaseBlurMatInst == null)
		{
			KawaseBlurMatInst = UMaterialLibrary.CreateDynamicMaterialInstance(this, Config.KawaseMaterialPrototype, B1GlobalFNames.KawaseBlur, EMIDCreationFlags.None);
		}
		int sizeX = DstTex.SizeX;
		int sizeY = DstTex.SizeY;
		ETextureRenderTargetFormat renderTargetFormat = DstTex.RenderTargetFormat;
		if (RenderTarget0 == null || RenderTarget0.SizeX != sizeX || RenderTarget0.SizeY != sizeY || RenderTarget0.RenderTargetFormat != renderTargetFormat)
		{
			if (RenderTarget0 != null)
			{
				URenderingLibrary.ReleaseRenderTarget2D(RenderTarget0);
			}
			RenderTarget0 = URenderingLibrary.CreateRenderTarget2D(this, sizeX, sizeY, renderTargetFormat, FLinearColor.Black, bAutoGenerateMipMaps: false);
			RenderTarget0.SRGB = false;
		}
		int num = DstTex.SizeX / 2;
		int num2 = DstTex.SizeY / 2;
		if (RenderTarget1 == null || RenderTarget1.SizeX != num || RenderTarget1.SizeY != num2 || RenderTarget1.RenderTargetFormat != renderTargetFormat)
		{
			if (RenderTarget1 != null)
			{
				URenderingLibrary.ReleaseRenderTarget2D(RenderTarget1);
			}
			RenderTarget1 = URenderingLibrary.CreateRenderTarget2D(this, num, num2, renderTargetFormat, FLinearColor.Black, bAutoGenerateMipMaps: false);
			RenderTarget1.SRGB = false;
		}
		float value = (IsFlipVerticalAxis ? 1f : 0f);
		if (KawaseBlurMatInst != null)
		{
			KawaseBlurMatInst.SetTextureParameterValue(SourceTexName, SrcTex);
			KawaseBlurMatInst.SetScalarParameterValue(IsFlipVerticalAxisName, value);
			KawaseBlurMatInst.SetScalarParameterValue(ShiftName, 0.5f);
			URenderingLibrary.DrawMaterialToRenderTarget(this, Config.RenderTarget0, KawaseBlurMatInst);
			KawaseBlurMatInst.SetTextureParameterValue(SourceTexName, Config.RenderTarget0);
			KawaseBlurMatInst.SetScalarParameterValue(IsFlipVerticalAxisName, value);
			KawaseBlurMatInst.SetScalarParameterValue(ShiftName, 1.5f);
			URenderingLibrary.DrawMaterialToRenderTarget(this, Config.RenderTarget1, KawaseBlurMatInst);
			KawaseBlurMatInst.SetTextureParameterValue(SourceTexName, Config.RenderTarget1);
			KawaseBlurMatInst.SetScalarParameterValue(IsFlipVerticalAxisName, value);
			KawaseBlurMatInst.SetScalarParameterValue(ShiftName, 2.5f);
			URenderingLibrary.DrawMaterialToRenderTarget(this, DstTex, KawaseBlurMatInst);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_DispLibImageProcessor:Blit")]
	private static void Blit__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_DispLibImageProcessor bWS_DispLibImageProcessor = GCHelper.Find<BWS_DispLibImageProcessor>(obj);
		UTexture srcTex = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(buffer, Blit_SrcTex_Offset));
		UTexture blendTex = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(buffer, Blit_BlendTex_Offset));
		UTextureRenderTarget2D dstTex = UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(buffer, Blit_DstTex_Offset));
		float blendAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Blit_BlendAlpha_Offset));
		bool isFlipVerticalAxis = BoolMarshaler.FromNative(IntPtr.Add(buffer, Blit_IsFlipVerticalAxis_Offset), 0, Blit_IsFlipVerticalAxis_PropertyAddress.Address);
		bWS_DispLibImageProcessor.Blit(srcTex, blendTex, dstTex, blendAlpha, isFlipVerticalAxis);
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_DispLibImageProcessor:Init")]
	private static void Init__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_DispLibImageProcessor bWS_DispLibImageProcessor = GCHelper.Find<BWS_DispLibImageProcessor>(obj);
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, Init_WorldContext_Offset));
		string configPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, Init_ConfigPath_Offset));
		bWS_DispLibImageProcessor.Init(worldContext, configPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_DispLibImageProcessor:KawaseBlur")]
	private static void KawaseBlur__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_DispLibImageProcessor bWS_DispLibImageProcessor = GCHelper.Find<BWS_DispLibImageProcessor>(obj);
		UTexture srcTex = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(buffer, KawaseBlur_SrcTex_Offset));
		UTextureRenderTarget2D dstTex = UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(buffer, KawaseBlur_DstTex_Offset));
		bool isFlipVerticalAxis = BoolMarshaler.FromNative(IntPtr.Add(buffer, KawaseBlur_IsFlipVerticalAxis_Offset), 0, KawaseBlur_IsFlipVerticalAxis_PropertyAddress.Address);
		bWS_DispLibImageProcessor.KawaseBlur(srcTex, dstTex, isFlipVerticalAxis);
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_DispLibImageProcessor:CombileRGB")]
	private static void CombileRGB__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_DispLibImageProcessor bWS_DispLibImageProcessor = GCHelper.Find<BWS_DispLibImageProcessor>(obj);
		UTexture rChannel = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(buffer, CombileRGB_RChannel_Offset));
		UTexture gChannel = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(buffer, CombileRGB_GChannel_Offset));
		UTexture bChannel = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(buffer, CombileRGB_BChannel_Offset));
		UTextureRenderTarget2D dstTex = UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(buffer, CombileRGB_DstTex_Offset));
		bool isFlipVerticalAxis = BoolMarshaler.FromNative(IntPtr.Add(buffer, CombileRGB_IsFlipVerticalAxis_Offset), 0, CombileRGB_IsFlipVerticalAxis_PropertyAddress.Address);
		bWS_DispLibImageProcessor.CombileRGB(rChannel, gChannel, bChannel, dstTex, isFlipVerticalAxis);
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_DispLibImageProcessor:InitParameters")]
	private static void InitParameters__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_DispLibImageProcessor bWS_DispLibImageProcessor = GCHelper.Find<BWS_DispLibImageProcessor>(obj);
		bWS_DispLibImageProcessor.InitParameters();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BWS_DispLibImageProcessor");
		KawaseBlurMatInst_Offset = NativeReflection.GetPropertyOffset(intPtr, "KawaseBlurMatInst");
		KawaseBlurMatInst_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "KawaseBlurMatInst", Classes.FObjectProperty);
		BlitMatInst_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlitMatInst");
		BlitMatInst_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlitMatInst", Classes.FObjectProperty);
		CombineRGBMatInst_Offset = NativeReflection.GetPropertyOffset(intPtr, "CombineRGBMatInst");
		CombineRGBMatInst_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CombineRGBMatInst", Classes.FObjectProperty);
		CombineMatInst_Offset = NativeReflection.GetPropertyOffset(intPtr, "CombineMatInst");
		CombineMatInst_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CombineMatInst", Classes.FObjectProperty);
		Config_Offset = NativeReflection.GetPropertyOffset(intPtr, "Config");
		Config_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Config", Classes.FObjectProperty);
		RenderTarget0_Offset = NativeReflection.GetPropertyOffset(intPtr, "RenderTarget0");
		RenderTarget0_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RenderTarget0", Classes.FObjectProperty);
		RenderTarget1_Offset = NativeReflection.GetPropertyOffset(intPtr, "RenderTarget1");
		RenderTarget1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RenderTarget1", Classes.FObjectProperty);
		SourceTexName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SourceTexName");
		SourceTexName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SourceTexName", Classes.FNameProperty);
		ShiftName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShiftName");
		ShiftName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShiftName", Classes.FNameProperty);
		IsFlipVerticalAxisName_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsFlipVerticalAxisName");
		IsFlipVerticalAxisName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsFlipVerticalAxisName", Classes.FNameProperty);
		BlendTexName_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendTexName");
		BlendTexName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendTexName", Classes.FNameProperty);
		BlendAlphaName_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendAlphaName");
		BlendAlphaName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendAlphaName", Classes.FNameProperty);
		RChannelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "RChannelName");
		RChannelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RChannelName", Classes.FNameProperty);
		GChannelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "GChannelName");
		GChannelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GChannelName", Classes.FNameProperty);
		BChannelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "BChannelName");
		BChannelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BChannelName", Classes.FNameProperty);
		Blit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Blit");
		Blit_ParamsSize = NativeReflection.GetFunctionParamsSize(Blit_FunctionAddress);
		Blit_SrcTex_Offset = NativeReflection.GetPropertyOffset(Blit_FunctionAddress, "SrcTex");
		Blit_SrcTex_IsValid = NativeReflection.ValidatePropertyClass(Blit_FunctionAddress, "SrcTex", Classes.FObjectProperty);
		Blit_BlendTex_Offset = NativeReflection.GetPropertyOffset(Blit_FunctionAddress, "BlendTex");
		Blit_BlendTex_IsValid = NativeReflection.ValidatePropertyClass(Blit_FunctionAddress, "BlendTex", Classes.FObjectProperty);
		Blit_DstTex_Offset = NativeReflection.GetPropertyOffset(Blit_FunctionAddress, "DstTex");
		Blit_DstTex_IsValid = NativeReflection.ValidatePropertyClass(Blit_FunctionAddress, "DstTex", Classes.FObjectProperty);
		Blit_BlendAlpha_Offset = NativeReflection.GetPropertyOffset(Blit_FunctionAddress, "BlendAlpha");
		Blit_BlendAlpha_IsValid = NativeReflection.ValidatePropertyClass(Blit_FunctionAddress, "BlendAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref Blit_IsFlipVerticalAxis_PropertyAddress, Blit_FunctionAddress, "IsFlipVerticalAxis");
		Blit_IsFlipVerticalAxis_Offset = NativeReflection.GetPropertyOffset(Blit_FunctionAddress, "IsFlipVerticalAxis");
		Blit_IsFlipVerticalAxis_IsValid = NativeReflection.ValidatePropertyClass(Blit_FunctionAddress, "IsFlipVerticalAxis", Classes.FBoolProperty);
		Blit_IsValid = Blit_FunctionAddress != IntPtr.Zero && Blit_SrcTex_IsValid && Blit_BlendTex_IsValid && Blit_DstTex_IsValid && Blit_BlendAlpha_IsValid && Blit_IsFlipVerticalAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_DispLibImageProcessor:Blit", Blit_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		Init_WorldContext_Offset = NativeReflection.GetPropertyOffset(Init_FunctionAddress, "WorldContext");
		Init_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(Init_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Init_ConfigPath_PropertyAddress, Init_FunctionAddress, "ConfigPath");
		Init_ConfigPath_Offset = NativeReflection.GetPropertyOffset(Init_FunctionAddress, "ConfigPath");
		Init_ConfigPath_IsValid = NativeReflection.ValidatePropertyClass(Init_FunctionAddress, "ConfigPath", Classes.FStrProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_WorldContext_IsValid && Init_ConfigPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_DispLibImageProcessor:Init", Init_IsValid);
		KawaseBlur_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "KawaseBlur");
		KawaseBlur_ParamsSize = NativeReflection.GetFunctionParamsSize(KawaseBlur_FunctionAddress);
		KawaseBlur_SrcTex_Offset = NativeReflection.GetPropertyOffset(KawaseBlur_FunctionAddress, "SrcTex");
		KawaseBlur_SrcTex_IsValid = NativeReflection.ValidatePropertyClass(KawaseBlur_FunctionAddress, "SrcTex", Classes.FObjectProperty);
		KawaseBlur_DstTex_Offset = NativeReflection.GetPropertyOffset(KawaseBlur_FunctionAddress, "DstTex");
		KawaseBlur_DstTex_IsValid = NativeReflection.ValidatePropertyClass(KawaseBlur_FunctionAddress, "DstTex", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref KawaseBlur_IsFlipVerticalAxis_PropertyAddress, KawaseBlur_FunctionAddress, "IsFlipVerticalAxis");
		KawaseBlur_IsFlipVerticalAxis_Offset = NativeReflection.GetPropertyOffset(KawaseBlur_FunctionAddress, "IsFlipVerticalAxis");
		KawaseBlur_IsFlipVerticalAxis_IsValid = NativeReflection.ValidatePropertyClass(KawaseBlur_FunctionAddress, "IsFlipVerticalAxis", Classes.FBoolProperty);
		KawaseBlur_IsValid = KawaseBlur_FunctionAddress != IntPtr.Zero && KawaseBlur_SrcTex_IsValid && KawaseBlur_DstTex_IsValid && KawaseBlur_IsFlipVerticalAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_DispLibImageProcessor:KawaseBlur", KawaseBlur_IsValid);
		CombileRGB_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CombileRGB");
		CombileRGB_ParamsSize = NativeReflection.GetFunctionParamsSize(CombileRGB_FunctionAddress);
		CombileRGB_RChannel_Offset = NativeReflection.GetPropertyOffset(CombileRGB_FunctionAddress, "RChannel");
		CombileRGB_RChannel_IsValid = NativeReflection.ValidatePropertyClass(CombileRGB_FunctionAddress, "RChannel", Classes.FObjectProperty);
		CombileRGB_GChannel_Offset = NativeReflection.GetPropertyOffset(CombileRGB_FunctionAddress, "GChannel");
		CombileRGB_GChannel_IsValid = NativeReflection.ValidatePropertyClass(CombileRGB_FunctionAddress, "GChannel", Classes.FObjectProperty);
		CombileRGB_BChannel_Offset = NativeReflection.GetPropertyOffset(CombileRGB_FunctionAddress, "BChannel");
		CombileRGB_BChannel_IsValid = NativeReflection.ValidatePropertyClass(CombileRGB_FunctionAddress, "BChannel", Classes.FObjectProperty);
		CombileRGB_DstTex_Offset = NativeReflection.GetPropertyOffset(CombileRGB_FunctionAddress, "DstTex");
		CombileRGB_DstTex_IsValid = NativeReflection.ValidatePropertyClass(CombileRGB_FunctionAddress, "DstTex", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CombileRGB_IsFlipVerticalAxis_PropertyAddress, CombileRGB_FunctionAddress, "IsFlipVerticalAxis");
		CombileRGB_IsFlipVerticalAxis_Offset = NativeReflection.GetPropertyOffset(CombileRGB_FunctionAddress, "IsFlipVerticalAxis");
		CombileRGB_IsFlipVerticalAxis_IsValid = NativeReflection.ValidatePropertyClass(CombileRGB_FunctionAddress, "IsFlipVerticalAxis", Classes.FBoolProperty);
		CombileRGB_IsValid = CombileRGB_FunctionAddress != IntPtr.Zero && CombileRGB_RChannel_IsValid && CombileRGB_GChannel_IsValid && CombileRGB_BChannel_IsValid && CombileRGB_DstTex_IsValid && CombileRGB_IsFlipVerticalAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_DispLibImageProcessor:CombileRGB", CombileRGB_IsValid);
		InitParameters_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitParameters");
		InitParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(InitParameters_FunctionAddress);
		InitParameters_IsValid = InitParameters_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_DispLibImageProcessor:InitParameters", InitParameters_IsValid);
	}

	static BWS_DispLibImageProcessor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BWS_DispLibImageProcessor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BWS_DispLibImageProcessor));
	}
}
