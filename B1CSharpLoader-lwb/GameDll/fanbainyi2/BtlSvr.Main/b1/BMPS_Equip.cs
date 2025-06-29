using System;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BMPS_Equip")]
public class BMPS_Equip : BMPS_Base
{
	private static bool MeshConfig_IsValid;

	private static int MeshConfig_Offset;

	private static bool AbpConfig_IsValid;

	private static int AbpConfig_Offset;

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

	[EditAnywhere]
	[UProperty]
	[Category("主角演员装备配置")]
	[DisplayName("装备部位模型")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BMPS_Equip:MeshConfig")]
	public FEquipMeshConfig MeshConfig
	{
		get
		{
			CheckDestroyed();
			if (!MeshConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_Equip:MeshConfig");
				return default(FEquipMeshConfig);
			}
			return FEquipMeshConfig.FromNative(IntPtr.Add(base.Address, MeshConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeshConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_Equip:MeshConfig");
			}
			else
			{
				FEquipMeshConfig.ToNative(IntPtr.Add(base.Address, MeshConfig_Offset), value);
			}
		}
	}

	[Category("主角演员装备配置")]
	[DisplayName("部位动画蓝图")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BMPS_Equip:AbpConfig")]
	public FEquipAbpConfig AbpConfig
	{
		get
		{
			CheckDestroyed();
			if (!AbpConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_Equip:AbpConfig");
				return default(FEquipAbpConfig);
			}
			return FEquipAbpConfig.FromNative(IntPtr.Add(base.Address, AbpConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AbpConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_Equip:AbpConfig");
			}
			else
			{
				FEquipAbpConfig.ToNative(IntPtr.Add(base.Address, AbpConfig_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BMPS_Equip:SetupForPipelineCS")]
	protected override void SetupForPipelineCS_Implementation(UMoviePipeline InPipeline)
	{
		BGW_EventCollection.Get(InPipeline)?.Evt_StorePlayerPerformerEquipConfig(MeshConfig, AbpConfig);
	}

	[USharpPath("/Script/b1-Managed.BMPS_Equip:GetDisplayTextCS")]
	protected override string GetDisplayTextCS_Implementation()
	{
		return "装备配置";
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_Equip:GetDisplayTextCS")]
	private static void GetDisplayTextCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_Equip bMPS_Equip = GCHelper.Find<BMPS_Equip>(obj);
		string displayTextCS_Implementation = bMPS_Equip.GetDisplayTextCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayTextCS_ReturnValue_Offset), displayTextCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_Equip:SetupForPipelineCS")]
	private static void SetupForPipelineCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_Equip bMPS_Equip = GCHelper.Find<BMPS_Equip>(obj);
		UMoviePipeline inPipeline = UObjectMarshaler<UMoviePipeline>.FromNative(IntPtr.Add(buffer, SetupForPipelineCS_InPipeline_Offset));
		bMPS_Equip.SetupForPipelineCS_Implementation(inPipeline);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BMPS_Equip");
		MeshConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "MeshConfig");
		MeshConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MeshConfig", Classes.FStructProperty);
		AbpConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbpConfig");
		AbpConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbpConfig", Classes.FStructProperty);
		GetDisplayTextCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayTextCS");
		GetDisplayTextCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayTextCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayTextCS_ReturnValue_PropertyAddress, GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayTextCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayTextCS_IsValid = GetDisplayTextCS_FunctionAddress != IntPtr.Zero && GetDisplayTextCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_Equip:GetDisplayTextCS", GetDisplayTextCS_IsValid);
		SetupForPipelineCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupForPipelineCS");
		SetupForPipelineCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupForPipelineCS_FunctionAddress);
		SetupForPipelineCS_InPipeline_Offset = NativeReflection.GetPropertyOffset(SetupForPipelineCS_FunctionAddress, "InPipeline");
		SetupForPipelineCS_InPipeline_IsValid = NativeReflection.ValidatePropertyClass(SetupForPipelineCS_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		SetupForPipelineCS_IsValid = SetupForPipelineCS_FunctionAddress != IntPtr.Zero && SetupForPipelineCS_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_Equip:SetupForPipelineCS", SetupForPipelineCS_IsValid);
	}

	static BMPS_Equip()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BMPS_Equip)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BMPS_Equip));
	}
}
