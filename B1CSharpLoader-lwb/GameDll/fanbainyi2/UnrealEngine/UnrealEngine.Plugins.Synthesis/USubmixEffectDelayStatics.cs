using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Synthesis.SubmixEffectDelayStatics", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USubmixEffectDelayStatics : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetMaximumDelayLength_IsValid;

	private static IntPtr SetMaximumDelayLength_FunctionAddress;

	private static int SetMaximumDelayLength_ParamsSize;

	private static bool SetMaximumDelayLength_DelaySettings_IsValid;

	private static FFieldAddress SetMaximumDelayLength_DelaySettings_PropertyAddress;

	private static int SetMaximumDelayLength_DelaySettings_Offset;

	private static bool SetMaximumDelayLength_MaximumDelayLength_IsValid;

	private static FFieldAddress SetMaximumDelayLength_MaximumDelayLength_PropertyAddress;

	private static int SetMaximumDelayLength_MaximumDelayLength_Offset;

	private static bool SetMaximumDelayLength_ReturnValue_IsValid;

	private static FFieldAddress SetMaximumDelayLength_ReturnValue_PropertyAddress;

	private static int SetMaximumDelayLength_ReturnValue_Offset;

	private static bool SetInterpolationTime_IsValid;

	private static IntPtr SetInterpolationTime_FunctionAddress;

	private static int SetInterpolationTime_ParamsSize;

	private static bool SetInterpolationTime_DelaySettings_IsValid;

	private static FFieldAddress SetInterpolationTime_DelaySettings_PropertyAddress;

	private static int SetInterpolationTime_DelaySettings_Offset;

	private static bool SetInterpolationTime_InterpolationTime_IsValid;

	private static FFieldAddress SetInterpolationTime_InterpolationTime_PropertyAddress;

	private static int SetInterpolationTime_InterpolationTime_Offset;

	private static bool SetInterpolationTime_ReturnValue_IsValid;

	private static FFieldAddress SetInterpolationTime_ReturnValue_PropertyAddress;

	private static int SetInterpolationTime_ReturnValue_Offset;

	private static bool SetDelayLength_IsValid;

	private static IntPtr SetDelayLength_FunctionAddress;

	private static int SetDelayLength_ParamsSize;

	private static bool SetDelayLength_DelaySettings_IsValid;

	private static FFieldAddress SetDelayLength_DelaySettings_PropertyAddress;

	private static int SetDelayLength_DelaySettings_Offset;

	private static bool SetDelayLength_DelayLength_IsValid;

	private static FFieldAddress SetDelayLength_DelayLength_PropertyAddress;

	private static int SetDelayLength_DelayLength_Offset;

	private static bool SetDelayLength_ReturnValue_IsValid;

	private static FFieldAddress SetDelayLength_ReturnValue_PropertyAddress;

	private static int SetDelayLength_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelayStatics:SetMaximumDelayLength")]
	public unsafe static FSubmixEffectDelaySettings SetMaximumDelayLength(ref FSubmixEffectDelaySettings DelaySettings, float MaximumDelayLength)
	{
		if (!SetMaximumDelayLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectDelayStatics:SetMaximumDelayLength");
			return default(FSubmixEffectDelaySettings);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaximumDelayLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaximumDelayLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetMaximumDelayLength_DelaySettings_PropertyAddress.Address, intPtr);
		FSubmixEffectDelaySettings.ToNative(IntPtr.Add(intPtr, SetMaximumDelayLength_DelaySettings_Offset), 0, SetMaximumDelayLength_DelaySettings_PropertyAddress.Address, DelaySettings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaximumDelayLength_MaximumDelayLength_Offset), 0, SetMaximumDelayLength_MaximumDelayLength_PropertyAddress.Address, MaximumDelayLength);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMaximumDelayLength_FunctionAddress, intPtr, SetMaximumDelayLength_ParamsSize);
		DelaySettings = FSubmixEffectDelaySettings.FromNative(IntPtr.Add(intPtr, SetMaximumDelayLength_DelaySettings_Offset), 0, SetMaximumDelayLength_DelaySettings_PropertyAddress.Address);
		return FSubmixEffectDelaySettings.FromNative(IntPtr.Add(intPtr, SetMaximumDelayLength_ReturnValue_Offset), 0, SetMaximumDelayLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelayStatics:SetInterpolationTime")]
	public unsafe static FSubmixEffectDelaySettings SetInterpolationTime(ref FSubmixEffectDelaySettings DelaySettings, float InterpolationTime)
	{
		if (!SetInterpolationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectDelayStatics:SetInterpolationTime");
			return default(FSubmixEffectDelaySettings);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInterpolationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInterpolationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetInterpolationTime_DelaySettings_PropertyAddress.Address, intPtr);
		FSubmixEffectDelaySettings.ToNative(IntPtr.Add(intPtr, SetInterpolationTime_DelaySettings_Offset), 0, SetInterpolationTime_DelaySettings_PropertyAddress.Address, DelaySettings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetInterpolationTime_InterpolationTime_Offset), 0, SetInterpolationTime_InterpolationTime_PropertyAddress.Address, InterpolationTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInterpolationTime_FunctionAddress, intPtr, SetInterpolationTime_ParamsSize);
		DelaySettings = FSubmixEffectDelaySettings.FromNative(IntPtr.Add(intPtr, SetInterpolationTime_DelaySettings_Offset), 0, SetInterpolationTime_DelaySettings_PropertyAddress.Address);
		return FSubmixEffectDelaySettings.FromNative(IntPtr.Add(intPtr, SetInterpolationTime_ReturnValue_Offset), 0, SetInterpolationTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelayStatics:SetDelayLength")]
	public unsafe static FSubmixEffectDelaySettings SetDelayLength(ref FSubmixEffectDelaySettings DelaySettings, float DelayLength)
	{
		if (!SetDelayLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectDelayStatics:SetDelayLength");
			return default(FSubmixEffectDelaySettings);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDelayLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDelayLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDelayLength_DelaySettings_PropertyAddress.Address, intPtr);
		FSubmixEffectDelaySettings.ToNative(IntPtr.Add(intPtr, SetDelayLength_DelaySettings_Offset), 0, SetDelayLength_DelaySettings_PropertyAddress.Address, DelaySettings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDelayLength_DelayLength_Offset), 0, SetDelayLength_DelayLength_PropertyAddress.Address, DelayLength);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDelayLength_FunctionAddress, intPtr, SetDelayLength_ParamsSize);
		DelaySettings = FSubmixEffectDelaySettings.FromNative(IntPtr.Add(intPtr, SetDelayLength_DelaySettings_Offset), 0, SetDelayLength_DelaySettings_PropertyAddress.Address);
		return FSubmixEffectDelaySettings.FromNative(IntPtr.Add(intPtr, SetDelayLength_ReturnValue_Offset), 0, SetDelayLength_ReturnValue_PropertyAddress.Address);
	}

	static USubmixEffectDelayStatics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubmixEffectDelayStatics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubmixEffectDelayStatics));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Synthesis.SubmixEffectDelayStatics");
		SetMaximumDelayLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMaximumDelayLength");
		SetMaximumDelayLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaximumDelayLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaximumDelayLength_DelaySettings_PropertyAddress, SetMaximumDelayLength_FunctionAddress, "DelaySettings");
		SetMaximumDelayLength_DelaySettings_Offset = NativeReflectionCached.GetPropertyOffset(SetMaximumDelayLength_FunctionAddress, "DelaySettings");
		SetMaximumDelayLength_DelaySettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaximumDelayLength_FunctionAddress, "DelaySettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaximumDelayLength_MaximumDelayLength_PropertyAddress, SetMaximumDelayLength_FunctionAddress, "MaximumDelayLength");
		SetMaximumDelayLength_MaximumDelayLength_Offset = NativeReflectionCached.GetPropertyOffset(SetMaximumDelayLength_FunctionAddress, "MaximumDelayLength");
		SetMaximumDelayLength_MaximumDelayLength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaximumDelayLength_FunctionAddress, "MaximumDelayLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaximumDelayLength_ReturnValue_PropertyAddress, SetMaximumDelayLength_FunctionAddress, "ReturnValue");
		SetMaximumDelayLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMaximumDelayLength_FunctionAddress, "ReturnValue");
		SetMaximumDelayLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaximumDelayLength_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetMaximumDelayLength_IsValid = SetMaximumDelayLength_FunctionAddress != IntPtr.Zero && SetMaximumDelayLength_DelaySettings_IsValid && SetMaximumDelayLength_MaximumDelayLength_IsValid && SetMaximumDelayLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectDelayStatics:SetMaximumDelayLength", SetMaximumDelayLength_IsValid);
		SetInterpolationTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInterpolationTime");
		SetInterpolationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInterpolationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInterpolationTime_DelaySettings_PropertyAddress, SetInterpolationTime_FunctionAddress, "DelaySettings");
		SetInterpolationTime_DelaySettings_Offset = NativeReflectionCached.GetPropertyOffset(SetInterpolationTime_FunctionAddress, "DelaySettings");
		SetInterpolationTime_DelaySettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterpolationTime_FunctionAddress, "DelaySettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInterpolationTime_InterpolationTime_PropertyAddress, SetInterpolationTime_FunctionAddress, "InterpolationTime");
		SetInterpolationTime_InterpolationTime_Offset = NativeReflectionCached.GetPropertyOffset(SetInterpolationTime_FunctionAddress, "InterpolationTime");
		SetInterpolationTime_InterpolationTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterpolationTime_FunctionAddress, "InterpolationTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInterpolationTime_ReturnValue_PropertyAddress, SetInterpolationTime_FunctionAddress, "ReturnValue");
		SetInterpolationTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetInterpolationTime_FunctionAddress, "ReturnValue");
		SetInterpolationTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterpolationTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetInterpolationTime_IsValid = SetInterpolationTime_FunctionAddress != IntPtr.Zero && SetInterpolationTime_DelaySettings_IsValid && SetInterpolationTime_InterpolationTime_IsValid && SetInterpolationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectDelayStatics:SetInterpolationTime", SetInterpolationTime_IsValid);
		SetDelayLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDelayLength");
		SetDelayLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDelayLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDelayLength_DelaySettings_PropertyAddress, SetDelayLength_FunctionAddress, "DelaySettings");
		SetDelayLength_DelaySettings_Offset = NativeReflectionCached.GetPropertyOffset(SetDelayLength_FunctionAddress, "DelaySettings");
		SetDelayLength_DelaySettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDelayLength_FunctionAddress, "DelaySettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDelayLength_DelayLength_PropertyAddress, SetDelayLength_FunctionAddress, "DelayLength");
		SetDelayLength_DelayLength_Offset = NativeReflectionCached.GetPropertyOffset(SetDelayLength_FunctionAddress, "DelayLength");
		SetDelayLength_DelayLength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDelayLength_FunctionAddress, "DelayLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDelayLength_ReturnValue_PropertyAddress, SetDelayLength_FunctionAddress, "ReturnValue");
		SetDelayLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDelayLength_FunctionAddress, "ReturnValue");
		SetDelayLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDelayLength_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetDelayLength_IsValid = SetDelayLength_FunctionAddress != IntPtr.Zero && SetDelayLength_DelaySettings_IsValid && SetDelayLength_DelayLength_IsValid && SetDelayLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectDelayStatics:SetDelayLength", SetDelayLength_IsValid);
	}
}
