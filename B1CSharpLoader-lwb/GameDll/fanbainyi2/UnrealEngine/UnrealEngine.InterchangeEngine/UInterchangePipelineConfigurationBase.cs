using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeEngine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/InterchangeEngine.InterchangePipelineConfigurationBase", "InterchangeEngine", UnrealModuleType.Engine)]
public class UInterchangePipelineConfigurationBase : UObject
{
	private static bool ScriptedShowPipelineConfigurationDialog_IsValid;

	private IntPtr ScriptedShowPipelineConfigurationDialog_InstanceFunctionAddress;

	private static IntPtr ScriptedShowPipelineConfigurationDialog_FunctionAddress;

	private static int ScriptedShowPipelineConfigurationDialog_ParamsSize;

	private static bool ScriptedShowPipelineConfigurationDialog_ReturnValue_IsValid;

	private static FFieldAddress ScriptedShowPipelineConfigurationDialog_ReturnValue_PropertyAddress;

	private static int ScriptedShowPipelineConfigurationDialog_ReturnValue_Offset;

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/InterchangeEngine.InterchangePipelineConfigurationBase:ScriptedShowPipelineConfigurationDialog")]
	public unsafe EInterchangePipelineConfigurationDialogResult ScriptedShowPipelineConfigurationDialog()
	{
		CheckDestroyed();
		if (!ScriptedShowPipelineConfigurationDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangePipelineConfigurationBase:ScriptedShowPipelineConfigurationDialog");
			return EInterchangePipelineConfigurationDialogResult.Cancel;
		}
		if (ScriptedShowPipelineConfigurationDialog_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScriptedShowPipelineConfigurationDialog_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScriptedShowPipelineConfigurationDialog");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedShowPipelineConfigurationDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedShowPipelineConfigurationDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedShowPipelineConfigurationDialog_InstanceFunctionAddress, intPtr, ScriptedShowPipelineConfigurationDialog_ParamsSize);
		return EnumMarshaler<EInterchangePipelineConfigurationDialogResult>.FromNative(IntPtr.Add(intPtr, ScriptedShowPipelineConfigurationDialog_ReturnValue_Offset), 0, ScriptedShowPipelineConfigurationDialog_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual EInterchangePipelineConfigurationDialogResult ScriptedShowPipelineConfigurationDialog_Implementation()
	{
		CheckDestroyed();
		if (!ScriptedShowPipelineConfigurationDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeEngine.InterchangePipelineConfigurationBase:ScriptedShowPipelineConfigurationDialog");
			return EInterchangePipelineConfigurationDialogResult.Cancel;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedShowPipelineConfigurationDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedShowPipelineConfigurationDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedShowPipelineConfigurationDialog_FunctionAddress, intPtr, ScriptedShowPipelineConfigurationDialog_ParamsSize);
		return EnumMarshaler<EInterchangePipelineConfigurationDialogResult>.FromNative(IntPtr.Add(intPtr, ScriptedShowPipelineConfigurationDialog_ReturnValue_Offset), 0, ScriptedShowPipelineConfigurationDialog_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangePipelineConfigurationBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangePipelineConfigurationBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangePipelineConfigurationBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeEngine.InterchangePipelineConfigurationBase");
		ScriptedShowPipelineConfigurationDialog_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptedShowPipelineConfigurationDialog");
		ScriptedShowPipelineConfigurationDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptedShowPipelineConfigurationDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptedShowPipelineConfigurationDialog_ReturnValue_PropertyAddress, ScriptedShowPipelineConfigurationDialog_FunctionAddress, "ReturnValue");
		ScriptedShowPipelineConfigurationDialog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedShowPipelineConfigurationDialog_FunctionAddress, "ReturnValue");
		ScriptedShowPipelineConfigurationDialog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedShowPipelineConfigurationDialog_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		ScriptedShowPipelineConfigurationDialog_IsValid = ScriptedShowPipelineConfigurationDialog_FunctionAddress != IntPtr.Zero && ScriptedShowPipelineConfigurationDialog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeEngine.InterchangePipelineConfigurationBase:ScriptedShowPipelineConfigurationDialog", ScriptedShowPipelineConfigurationDialog_IsValid);
	}
}
