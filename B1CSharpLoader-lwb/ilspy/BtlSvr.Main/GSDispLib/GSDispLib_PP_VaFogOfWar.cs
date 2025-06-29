using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar")]
public class GSDispLib_PP_VaFogOfWar : GSDispLib_PostProcessActor
{
	private bool bPingpongRT;

	private float SearchTimer;

	private float SearchInterval = 0.2f;

	private static bool FoWTex1_IsValid;

	private static int FoWTex1_Offset;

	private static bool FoWTex2_IsValid;

	private static int FoWTex2_Offset;

	private static bool FoWTex3_IsValid;

	private static int FoWTex3_Offset;

	private static bool FoWOpaqueColor_IsValid;

	private static int FoWOpaqueColor_Offset;

	private static bool FoWTranslucentColor_IsValid;

	private static int FoWTranslucentColor_Offset;

	private static bool FoWTexName_IsValid;

	private static int FoWTexName_Offset;

	private static bool FoWTex2Name_IsValid;

	private static int FoWTex2Name_Offset;

	private static bool FoWOpaqueColorName_IsValid;

	private static int FoWOpaqueColorName_Offset;

	private static bool FoWTranslucentColorName_IsValid;

	private static int FoWTranslucentColorName_Offset;

	private static bool FoWVolumePosSizeName_IsValid;

	private static int FoWVolumePosSizeName_Offset;

	private static bool FoWIsDebug_IsValid;

	private static int FoWIsDebug_Offset;

	private static bool FoWCombineTexName_IsValid;

	private static int FoWCombineTexName_Offset;

	private static bool OnInit_IsValid;

	private static IntPtr OnInit_FunctionAddress;

	private static int OnInit_ParamsSize;

	private static bool OnInit_Context_IsValid;

	private static int OnInit_Context_Offset;

	private static bool OnInit_Conf_IsValid;

	private static int OnInit_Conf_Offset;

	private static FFieldAddress OnInit_Conf_PropertyAddress;

	private static bool OnEndBegin_IsValid;

	private static IntPtr OnEndBegin_FunctionAddress;

	private static int OnEndBegin_ParamsSize;

	private static bool OnEndBegin_Context_IsValid;

	private static int OnEndBegin_Context_Offset;

	private static bool OnEndFinish_IsValid;

	private static IntPtr OnEndFinish_FunctionAddress;

	private static int OnEndFinish_ParamsSize;

	private static bool OnEndFinish_Context_IsValid;

	private static int OnEndFinish_Context_Offset;

	private static bool OnEnterBegin_IsValid;

	private static IntPtr OnEnterBegin_FunctionAddress;

	private static int OnEnterBegin_ParamsSize;

	private static bool OnEnterBegin_Context_IsValid;

	private static int OnEnterBegin_Context_Offset;

	private static bool OnEffectTick_IsValid;

	private static IntPtr OnEffectTick_FunctionAddress;

	private static int OnEffectTick_ParamsSize;

	private static bool OnEffectTick_DeltaTime_IsValid;

	private static int OnEffectTick_DeltaTime_Offset;

	private static bool OnEffectTick_Progress_IsValid;

	private static int OnEffectTick_Progress_Offset;

	private static bool OnEffectTick_Context_IsValid;

	private static int OnEffectTick_Context_Offset;

	private static bool OnEnterFinish_IsValid;

	private static IntPtr OnEnterFinish_FunctionAddress;

	private static int OnEnterFinish_ParamsSize;

	private static bool OnEnterFinish_Context_IsValid;

	private static int OnEnterFinish_Context_Offset;

	private static bool OnAlreadyBegin_IsValid;

	private static IntPtr OnAlreadyBegin_FunctionAddress;

	private static int OnAlreadyBegin_ParamsSize;

	private static bool OnAlreadyBegin_Context_IsValid;

	private static int OnAlreadyBegin_Context_Offset;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex1")]
	public UTextureRenderTarget2D FoWTex1
	{
		get
		{
			CheckDestroyed();
			if (!FoWTex1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex1");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, FoWTex1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWTex1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex1");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, FoWTex1_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex2")]
	public UTextureRenderTarget2D FoWTex2
	{
		get
		{
			CheckDestroyed();
			if (!FoWTex2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex2");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, FoWTex2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWTex2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex2");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, FoWTex2_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex3")]
	public UTextureRenderTarget2D FoWTex3
	{
		get
		{
			CheckDestroyed();
			if (!FoWTex3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex3");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, FoWTex3_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWTex3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex3");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, FoWTex3_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWOpaqueColor")]
	public FLinearColor FoWOpaqueColor
	{
		get
		{
			CheckDestroyed();
			if (!FoWOpaqueColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWOpaqueColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, FoWOpaqueColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWOpaqueColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWOpaqueColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, FoWOpaqueColor_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTranslucentColor")]
	public FLinearColor FoWTranslucentColor
	{
		get
		{
			CheckDestroyed();
			if (!FoWTranslucentColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTranslucentColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, FoWTranslucentColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWTranslucentColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTranslucentColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, FoWTranslucentColor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTexName")]
	private FName FoWTexName
	{
		get
		{
			CheckDestroyed();
			if (!FoWTexName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTexName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FoWTexName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWTexName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTexName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FoWTexName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex2Name")]
	private FName FoWTex2Name
	{
		get
		{
			CheckDestroyed();
			if (!FoWTex2Name_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex2Name");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FoWTex2Name_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWTex2Name_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTex2Name");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FoWTex2Name_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWOpaqueColorName")]
	private FName FoWOpaqueColorName
	{
		get
		{
			CheckDestroyed();
			if (!FoWOpaqueColorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWOpaqueColorName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FoWOpaqueColorName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWOpaqueColorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWOpaqueColorName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FoWOpaqueColorName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTranslucentColorName")]
	private FName FoWTranslucentColorName
	{
		get
		{
			CheckDestroyed();
			if (!FoWTranslucentColorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTranslucentColorName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FoWTranslucentColorName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWTranslucentColorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWTranslucentColorName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FoWTranslucentColorName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWVolumePosSizeName")]
	private FName FoWVolumePosSizeName
	{
		get
		{
			CheckDestroyed();
			if (!FoWVolumePosSizeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWVolumePosSizeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FoWVolumePosSizeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWVolumePosSizeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWVolumePosSizeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FoWVolumePosSizeName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWIsDebug")]
	private FName FoWIsDebug
	{
		get
		{
			CheckDestroyed();
			if (!FoWIsDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWIsDebug");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FoWIsDebug_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWIsDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWIsDebug");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FoWIsDebug_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWCombineTexName")]
	private FName FoWCombineTexName
	{
		get
		{
			CheckDestroyed();
			if (!FoWCombineTexName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWCombineTexName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FoWCombineTexName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoWCombineTexName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:FoWCombineTexName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FoWCombineTexName_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnInit")]
	public override void OnInit_Implementation(GSDispLib_PostProcessContext Context, UDispLib_PostPorcessCommonConf Conf)
	{
		base.OnInit_Implementation(Context, Conf);
		FoWTexName = B1GlobalFNames.FoWTex1;
		FoWTex2Name = B1GlobalFNames.FoWTex2;
		FoWOpaqueColorName = B1GlobalFNames.FoWOpaqueColor;
		FoWTranslucentColorName = B1GlobalFNames.FoWTranslucentColor;
		FoWVolumePosSizeName = B1GlobalFNames.FoWVolumePosSize;
		FoWIsDebug = B1GlobalFNames.FoWIsDebug;
		FoWCombineTexName = B1GlobalFNames.FoWCombineTex;
	}

	private void RefreshFowContext()
	{
		if (base.Parameters != null && base.Parameters.VectorParams.Count > 2)
		{
			FoWOpaqueColor = new FLinearColor(base.Parameters.VectorParams[0]);
			FoWTranslucentColor = new FLinearColor(base.Parameters.VectorParams[1]);
		}
		if (FoWTex1 != null)
		{
			URenderingLibrary.ClearRenderTarget2D(this, FoWTex1, FLinearColor.Black);
		}
		if (FoWTex2 != null)
		{
			URenderingLibrary.ClearRenderTarget2D(this, FoWTex2, FLinearColor.Black);
		}
		if (FoWTex3 != null)
		{
			URenderingLibrary.ClearRenderTarget2D(this, FoWTex3, FLinearColor.Black);
		}
	}

	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnAlreadyBegin")]
	public override void OnAlreadyBegin_Implementation(GSDispLib_PostProcessContext Context)
	{
		base.OnAlreadyBegin_Implementation(Context);
		RefreshFowContext();
	}

	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEnterBegin")]
	public override void OnEnterBegin_Implementation(GSDispLib_PostProcessContext Context)
	{
		base.OnEnterBegin_Implementation(Context);
		SearchTimer = 0f;
		RefreshFowContext();
	}

	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEndBegin")]
	public override void OnEndBegin_Implementation(GSDispLib_PostProcessContext Context)
	{
		base.OnEndBegin_Implementation(Context);
	}

	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEnterFinish")]
	public override void OnEnterFinish_Implementation(GSDispLib_PostProcessContext Context)
	{
		base.OnEnterFinish_Implementation(Context);
	}

	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEndFinish")]
	public override void OnEndFinish_Implementation(GSDispLib_PostProcessContext Context)
	{
		base.OnEndFinish_Implementation(Context);
	}

	[USharpPath("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEffectTick")]
	public override void OnEffectTick_Implementation(float DeltaTime, float Progress, GSDispLib_PostProcessContext Context)
	{
		base.OnEffectTick_Implementation(DeltaTime, Progress, Context);
	}

	private void BlurFogTexture(UTexture2D OpaqueTex, UTexture2D TranlucentTex, BWS_DispLibImageProcessor ImageProcessor, float DeltaTime, int RTScale = 1, bool IsDebug = false)
	{
		OpaqueTex.Blueprint_GetSizeX();
		OpaqueTex.Blueprint_GetSizeY();
		_ = FoWTex1;
		_ = FoWTex3;
		if (bPingpongRT)
		{
			_ = FoWTex3;
			_ = FoWTex1;
		}
		bPingpongRT = !bPingpongRT;
	}

	private void UpdateCombinedMaterial(UTexture FoWTex, FLinearColor VolumePosSize, FLinearColor OpaqueColor, FLinearColor TranslucentColor, bool IsDebug = false)
	{
		base.MaterialInstDynamic.SetTextureParameterValue(FoWTexName, FoWTex);
		base.MaterialInstDynamic.SetVectorParameterValue(FoWVolumePosSizeName, VolumePosSize);
		base.MaterialInstDynamic.SetVectorParameterValue(FoWOpaqueColorName, OpaqueColor);
		base.MaterialInstDynamic.SetVectorParameterValue(FoWTranslucentColorName, TranslucentColor);
		base.MaterialInstDynamic.SetScalarParameterValue(FoWIsDebug, IsDebug ? 1f : 0f);
		base.MaterialInstDynamic.SetScalarParameterValue(FoWCombineTexName, 1f);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnInit")]
	private static void OnInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PP_VaFogOfWar gSDispLib_PP_VaFogOfWar = GCHelper.Find<GSDispLib_PP_VaFogOfWar>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnInit_Context_Offset));
		UDispLib_PostPorcessCommonConf conf = UDispLib_PostPorcessCommonConf.FromNative(IntPtr.Add(buffer, OnInit_Conf_Offset));
		gSDispLib_PP_VaFogOfWar.OnInit_Implementation(context, conf);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEndBegin")]
	private static void OnEndBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PP_VaFogOfWar gSDispLib_PP_VaFogOfWar = GCHelper.Find<GSDispLib_PP_VaFogOfWar>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEndBegin_Context_Offset));
		gSDispLib_PP_VaFogOfWar.OnEndBegin_Implementation(context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEndFinish")]
	private static void OnEndFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PP_VaFogOfWar gSDispLib_PP_VaFogOfWar = GCHelper.Find<GSDispLib_PP_VaFogOfWar>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEndFinish_Context_Offset));
		gSDispLib_PP_VaFogOfWar.OnEndFinish_Implementation(context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEnterBegin")]
	private static void OnEnterBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PP_VaFogOfWar gSDispLib_PP_VaFogOfWar = GCHelper.Find<GSDispLib_PP_VaFogOfWar>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEnterBegin_Context_Offset));
		gSDispLib_PP_VaFogOfWar.OnEnterBegin_Implementation(context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEffectTick")]
	private static void OnEffectTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PP_VaFogOfWar gSDispLib_PP_VaFogOfWar = GCHelper.Find<GSDispLib_PP_VaFogOfWar>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnEffectTick_DeltaTime_Offset));
		float progress = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnEffectTick_Progress_Offset));
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEffectTick_Context_Offset));
		gSDispLib_PP_VaFogOfWar.OnEffectTick_Implementation(deltaTime, progress, context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEnterFinish")]
	private static void OnEnterFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PP_VaFogOfWar gSDispLib_PP_VaFogOfWar = GCHelper.Find<GSDispLib_PP_VaFogOfWar>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnEnterFinish_Context_Offset));
		gSDispLib_PP_VaFogOfWar.OnEnterFinish_Implementation(context);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnAlreadyBegin")]
	private static void OnAlreadyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib_PP_VaFogOfWar gSDispLib_PP_VaFogOfWar = GCHelper.Find<GSDispLib_PP_VaFogOfWar>(obj);
		GSDispLib_PostProcessContext context = UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(buffer, OnAlreadyBegin_Context_Offset));
		gSDispLib_PP_VaFogOfWar.OnAlreadyBegin_Implementation(context);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar");
		FoWTex1_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWTex1");
		FoWTex1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWTex1", Classes.FObjectProperty);
		FoWTex2_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWTex2");
		FoWTex2_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWTex2", Classes.FObjectProperty);
		FoWTex3_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWTex3");
		FoWTex3_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWTex3", Classes.FObjectProperty);
		FoWOpaqueColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWOpaqueColor");
		FoWOpaqueColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWOpaqueColor", Classes.FStructProperty);
		FoWTranslucentColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWTranslucentColor");
		FoWTranslucentColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWTranslucentColor", Classes.FStructProperty);
		FoWTexName_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWTexName");
		FoWTexName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWTexName", Classes.FNameProperty);
		FoWTex2Name_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWTex2Name");
		FoWTex2Name_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWTex2Name", Classes.FNameProperty);
		FoWOpaqueColorName_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWOpaqueColorName");
		FoWOpaqueColorName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWOpaqueColorName", Classes.FNameProperty);
		FoWTranslucentColorName_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWTranslucentColorName");
		FoWTranslucentColorName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWTranslucentColorName", Classes.FNameProperty);
		FoWVolumePosSizeName_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWVolumePosSizeName");
		FoWVolumePosSizeName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWVolumePosSizeName", Classes.FNameProperty);
		FoWIsDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWIsDebug");
		FoWIsDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWIsDebug", Classes.FNameProperty);
		FoWCombineTexName_Offset = NativeReflection.GetPropertyOffset(intPtr, "FoWCombineTexName");
		FoWCombineTexName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FoWCombineTexName", Classes.FNameProperty);
		OnInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInit");
		OnInit_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInit_FunctionAddress);
		OnInit_Context_Offset = NativeReflection.GetPropertyOffset(OnInit_FunctionAddress, "Context");
		OnInit_Context_IsValid = NativeReflection.ValidatePropertyClass(OnInit_FunctionAddress, "Context", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnInit_Conf_PropertyAddress, OnInit_FunctionAddress, "Conf");
		OnInit_Conf_Offset = NativeReflection.GetPropertyOffset(OnInit_FunctionAddress, "Conf");
		OnInit_Conf_IsValid = NativeReflection.ValidatePropertyClass(OnInit_FunctionAddress, "Conf", Classes.FStructProperty);
		OnInit_IsValid = OnInit_FunctionAddress != IntPtr.Zero && OnInit_Context_IsValid && OnInit_Conf_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnInit", OnInit_IsValid);
		OnEndBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEndBegin");
		OnEndBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndBegin_FunctionAddress);
		OnEndBegin_Context_Offset = NativeReflection.GetPropertyOffset(OnEndBegin_FunctionAddress, "Context");
		OnEndBegin_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEndBegin_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEndBegin_IsValid = OnEndBegin_FunctionAddress != IntPtr.Zero && OnEndBegin_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEndBegin", OnEndBegin_IsValid);
		OnEndFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEndFinish");
		OnEndFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndFinish_FunctionAddress);
		OnEndFinish_Context_Offset = NativeReflection.GetPropertyOffset(OnEndFinish_FunctionAddress, "Context");
		OnEndFinish_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEndFinish_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEndFinish_IsValid = OnEndFinish_FunctionAddress != IntPtr.Zero && OnEndFinish_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEndFinish", OnEndFinish_IsValid);
		OnEnterBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEnterBegin");
		OnEnterBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnterBegin_FunctionAddress);
		OnEnterBegin_Context_Offset = NativeReflection.GetPropertyOffset(OnEnterBegin_FunctionAddress, "Context");
		OnEnterBegin_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEnterBegin_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEnterBegin_IsValid = OnEnterBegin_FunctionAddress != IntPtr.Zero && OnEnterBegin_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEnterBegin", OnEnterBegin_IsValid);
		OnEffectTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEffectTick");
		OnEffectTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEffectTick_FunctionAddress);
		OnEffectTick_DeltaTime_Offset = NativeReflection.GetPropertyOffset(OnEffectTick_FunctionAddress, "DeltaTime");
		OnEffectTick_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(OnEffectTick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnEffectTick_Progress_Offset = NativeReflection.GetPropertyOffset(OnEffectTick_FunctionAddress, "Progress");
		OnEffectTick_Progress_IsValid = NativeReflection.ValidatePropertyClass(OnEffectTick_FunctionAddress, "Progress", Classes.FFloatProperty);
		OnEffectTick_Context_Offset = NativeReflection.GetPropertyOffset(OnEffectTick_FunctionAddress, "Context");
		OnEffectTick_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEffectTick_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEffectTick_IsValid = OnEffectTick_FunctionAddress != IntPtr.Zero && OnEffectTick_DeltaTime_IsValid && OnEffectTick_Progress_IsValid && OnEffectTick_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEffectTick", OnEffectTick_IsValid);
		OnEnterFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEnterFinish");
		OnEnterFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnterFinish_FunctionAddress);
		OnEnterFinish_Context_Offset = NativeReflection.GetPropertyOffset(OnEnterFinish_FunctionAddress, "Context");
		OnEnterFinish_Context_IsValid = NativeReflection.ValidatePropertyClass(OnEnterFinish_FunctionAddress, "Context", Classes.FObjectProperty);
		OnEnterFinish_IsValid = OnEnterFinish_FunctionAddress != IntPtr.Zero && OnEnterFinish_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnEnterFinish", OnEnterFinish_IsValid);
		OnAlreadyBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAlreadyBegin");
		OnAlreadyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAlreadyBegin_FunctionAddress);
		OnAlreadyBegin_Context_Offset = NativeReflection.GetPropertyOffset(OnAlreadyBegin_FunctionAddress, "Context");
		OnAlreadyBegin_Context_IsValid = NativeReflection.ValidatePropertyClass(OnAlreadyBegin_FunctionAddress, "Context", Classes.FObjectProperty);
		OnAlreadyBegin_IsValid = OnAlreadyBegin_FunctionAddress != IntPtr.Zero && OnAlreadyBegin_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PP_VaFogOfWar:OnAlreadyBegin", OnAlreadyBegin_IsValid);
	}

	static GSDispLib_PP_VaFogOfWar()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib_PP_VaFogOfWar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib_PP_VaFogOfWar));
	}
}
