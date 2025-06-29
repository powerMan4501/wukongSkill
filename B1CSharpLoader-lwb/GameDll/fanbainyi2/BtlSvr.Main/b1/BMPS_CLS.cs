using System;
using b1.Plugins.CustomLightSystem;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BMPS_CLS")]
public class BMPS_CLS : BMPS_Base
{
	private static bool bOverrideBlendInSpeed_IsValid;

	private static int bOverrideBlendInSpeed_Offset;

	private static FFieldAddress bOverrideBlendInSpeed_PropertyAddress;

	private static bool BlendInSpeed_IsValid;

	private static int BlendInSpeed_Offset;

	private static bool GetDisplayTextCS_IsValid;

	private static IntPtr GetDisplayTextCS_FunctionAddress;

	private static int GetDisplayTextCS_ParamsSize;

	private static bool GetDisplayTextCS_ReturnValue_IsValid;

	private static int GetDisplayTextCS_ReturnValue_Offset;

	private static FFieldAddress GetDisplayTextCS_ReturnValue_PropertyAddress;

	private static bool SetupForPipelineCS_IsValid;

	private static IntPtr SetupForPipelineCS_FunctionAddress;

	private static int SetupForPipelineCS_ParamsSize;

	private static bool SetupForPipelineCS_InPipeline_IsValid;

	private static int SetupForPipelineCS_InPipeline_Offset;

	private static bool TeardownForPipelineCS_IsValid;

	private static IntPtr TeardownForPipelineCS_FunctionAddress;

	private static int TeardownForPipelineCS_ParamsSize;

	private static bool TeardownForPipelineCS_InPipeline_IsValid;

	private static int TeardownForPipelineCS_InPipeline_Offset;

	private static bool IgnoreTransientFiltersCS_IsValid;

	private static IntPtr IgnoreTransientFiltersCS_FunctionAddress;

	private static int IgnoreTransientFiltersCS_ParamsSize;

	private static bool IgnoreTransientFiltersCS_ReturnValue_IsValid;

	private static int IgnoreTransientFiltersCS_ReturnValue_Offset;

	private static FFieldAddress IgnoreTransientFiltersCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否覆盖CLS切换速度")]
	[USharpPath("/Script/b1-Managed.BMPS_CLS:bOverrideBlendInSpeed")]
	public bool bOverrideBlendInSpeed
	{
		get
		{
			CheckDestroyed();
			if (!bOverrideBlendInSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_CLS:bOverrideBlendInSpeed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bOverrideBlendInSpeed_Offset), 0, bOverrideBlendInSpeed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bOverrideBlendInSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_CLS:bOverrideBlendInSpeed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bOverrideBlendInSpeed_Offset), 0, bOverrideBlendInSpeed_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("CLS切换")]
	[USharpPath("/Script/b1-Managed.BMPS_CLS:BlendInSpeed")]
	public float BlendInSpeed
	{
		get
		{
			CheckDestroyed();
			if (!BlendInSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_CLS:BlendInSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_CLS:BlendInSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInSpeed_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		bOverrideBlendInSpeed = true;
		BlendInSpeed = 100f;
	}

	[USharpPath("/Script/b1-Managed.BMPS_CLS:SetupForPipelineCS")]
	protected override void SetupForPipelineCS_Implementation(UMoviePipeline InPipeline)
	{
		if (bOverrideBlendInSpeed)
		{
			UCLSFunctionLibrary.OverrideEnvLightBlendInSpeed(bOverride: true, BlendInSpeed);
		}
	}

	[USharpPath("/Script/b1-Managed.BMPS_CLS:TeardownForPipelineCS")]
	protected override void TeardownForPipelineCS_Implementation(UMoviePipeline InPipeline)
	{
		if (bOverrideBlendInSpeed)
		{
			UCLSFunctionLibrary.OverrideEnvLightBlendInSpeed(bOverride: false, BlendInSpeed);
		}
	}

	[USharpPath("/Script/b1-Managed.BMPS_CLS:GetDisplayTextCS")]
	protected override string GetDisplayTextCS_Implementation()
	{
		return "CLS配置";
	}

	[USharpPath("/Script/b1-Managed.BMPS_CLS:IgnoreTransientFiltersCS")]
	protected override bool IgnoreTransientFiltersCS_Implementation()
	{
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_CLS:GetDisplayTextCS")]
	private static void GetDisplayTextCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_CLS bMPS_CLS = GCHelper.Find<BMPS_CLS>(obj);
		string displayTextCS_Implementation = bMPS_CLS.GetDisplayTextCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayTextCS_ReturnValue_Offset), displayTextCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_CLS:SetupForPipelineCS")]
	private static void SetupForPipelineCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_CLS bMPS_CLS = GCHelper.Find<BMPS_CLS>(obj);
		UMoviePipeline inPipeline = UObjectMarshaler<UMoviePipeline>.FromNative(IntPtr.Add(buffer, SetupForPipelineCS_InPipeline_Offset));
		bMPS_CLS.SetupForPipelineCS_Implementation(inPipeline);
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_CLS:TeardownForPipelineCS")]
	private static void TeardownForPipelineCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_CLS bMPS_CLS = GCHelper.Find<BMPS_CLS>(obj);
		UMoviePipeline inPipeline = UObjectMarshaler<UMoviePipeline>.FromNative(IntPtr.Add(buffer, TeardownForPipelineCS_InPipeline_Offset));
		bMPS_CLS.TeardownForPipelineCS_Implementation(inPipeline);
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_CLS:IgnoreTransientFiltersCS")]
	private static void IgnoreTransientFiltersCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_CLS bMPS_CLS = GCHelper.Find<BMPS_CLS>(obj);
		bool value = bMPS_CLS.IgnoreTransientFiltersCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IgnoreTransientFiltersCS_ReturnValue_Offset), 0, IgnoreTransientFiltersCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BMPS_CLS");
		NativeReflection.GetPropertyRef(ref bOverrideBlendInSpeed_PropertyAddress, intPtr, "bOverrideBlendInSpeed");
		bOverrideBlendInSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "bOverrideBlendInSpeed");
		bOverrideBlendInSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bOverrideBlendInSpeed", Classes.FBoolProperty);
		BlendInSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInSpeed");
		BlendInSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInSpeed", Classes.FFloatProperty);
		GetDisplayTextCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayTextCS");
		GetDisplayTextCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayTextCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayTextCS_ReturnValue_PropertyAddress, GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayTextCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayTextCS_IsValid = GetDisplayTextCS_FunctionAddress != IntPtr.Zero && GetDisplayTextCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_CLS:GetDisplayTextCS", GetDisplayTextCS_IsValid);
		SetupForPipelineCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupForPipelineCS");
		SetupForPipelineCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupForPipelineCS_FunctionAddress);
		SetupForPipelineCS_InPipeline_Offset = NativeReflection.GetPropertyOffset(SetupForPipelineCS_FunctionAddress, "InPipeline");
		SetupForPipelineCS_InPipeline_IsValid = NativeReflection.ValidatePropertyClass(SetupForPipelineCS_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		SetupForPipelineCS_IsValid = SetupForPipelineCS_FunctionAddress != IntPtr.Zero && SetupForPipelineCS_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_CLS:SetupForPipelineCS", SetupForPipelineCS_IsValid);
		TeardownForPipelineCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TeardownForPipelineCS");
		TeardownForPipelineCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TeardownForPipelineCS_FunctionAddress);
		TeardownForPipelineCS_InPipeline_Offset = NativeReflection.GetPropertyOffset(TeardownForPipelineCS_FunctionAddress, "InPipeline");
		TeardownForPipelineCS_InPipeline_IsValid = NativeReflection.ValidatePropertyClass(TeardownForPipelineCS_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		TeardownForPipelineCS_IsValid = TeardownForPipelineCS_FunctionAddress != IntPtr.Zero && TeardownForPipelineCS_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_CLS:TeardownForPipelineCS", TeardownForPipelineCS_IsValid);
		IgnoreTransientFiltersCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IgnoreTransientFiltersCS");
		IgnoreTransientFiltersCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IgnoreTransientFiltersCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IgnoreTransientFiltersCS_ReturnValue_PropertyAddress, IgnoreTransientFiltersCS_FunctionAddress, "ReturnValue");
		IgnoreTransientFiltersCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IgnoreTransientFiltersCS_FunctionAddress, "ReturnValue");
		IgnoreTransientFiltersCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IgnoreTransientFiltersCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IgnoreTransientFiltersCS_IsValid = IgnoreTransientFiltersCS_FunctionAddress != IntPtr.Zero && IgnoreTransientFiltersCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_CLS:IgnoreTransientFiltersCS", IgnoreTransientFiltersCS_IsValid);
	}

	static BMPS_CLS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BMPS_CLS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BMPS_CLS));
	}
}
