using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectDelayPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USubmixEffectDelayPreset : USoundEffectSubmixPreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_InSettings_IsValid;

	private static FFieldAddress SetSettings_InSettings_PropertyAddress;

	private static int SetSettings_InSettings_Offset;

	private static bool SetInterpolationTime_IsValid;

	private static IntPtr SetInterpolationTime_FunctionAddress;

	private static int SetInterpolationTime_ParamsSize;

	private static bool SetInterpolationTime_Time_IsValid;

	private static FFieldAddress SetInterpolationTime_Time_PropertyAddress;

	private static int SetInterpolationTime_Time_Offset;

	private static bool SetDelay_IsValid;

	private static IntPtr SetDelay_FunctionAddress;

	private static int SetDelay_ParamsSize;

	private static bool SetDelay_Length_IsValid;

	private static FFieldAddress SetDelay_Length_PropertyAddress;

	private static int SetDelay_Length_Offset;

	private static bool SetDefaultSettings_IsValid;

	private static IntPtr SetDefaultSettings_FunctionAddress;

	private static int SetDefaultSettings_ParamsSize;

	private static bool SetDefaultSettings_InSettings_IsValid;

	private static FFieldAddress SetDefaultSettings_InSettings_PropertyAddress;

	private static int SetDefaultSettings_InSettings_Offset;

	private static bool GetMaxDelayInMilliseconds_IsValid;

	private static IntPtr GetMaxDelayInMilliseconds_FunctionAddress;

	private static int GetMaxDelayInMilliseconds_ParamsSize;

	private static bool GetMaxDelayInMilliseconds_ReturnValue_IsValid;

	private static FFieldAddress GetMaxDelayInMilliseconds_ReturnValue_PropertyAddress;

	private static int GetMaxDelayInMilliseconds_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelayPreset:Settings")]
	public FSubmixEffectDelaySettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectDelayPreset:Settings");
				return default(FSubmixEffectDelaySettings);
			}
			return FSubmixEffectDelaySettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectDelayPreset:Settings");
			}
			else
			{
				FSubmixEffectDelaySettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelayPreset:SetSettings")]
	public unsafe void SetSettings(FSubmixEffectDelaySettings InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectDelayPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
		FSubmixEffectDelaySettings.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelayPreset:SetInterpolationTime")]
	public unsafe void SetInterpolationTime(float Time)
	{
		CheckDestroyed();
		if (!SetInterpolationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectDelayPreset:SetInterpolationTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInterpolationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInterpolationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetInterpolationTime_Time_Offset), 0, SetInterpolationTime_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInterpolationTime_FunctionAddress, intPtr, SetInterpolationTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelayPreset:SetDelay")]
	public unsafe void SetDelay(float Length)
	{
		CheckDestroyed();
		if (!SetDelay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectDelayPreset:SetDelay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDelay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDelay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDelay_Length_Offset), 0, SetDelay_Length_PropertyAddress.Address, Length);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDelay_FunctionAddress, intPtr, SetDelay_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelayPreset:SetDefaultSettings")]
	public unsafe void SetDefaultSettings(FSubmixEffectDelaySettings InSettings)
	{
		CheckDestroyed();
		if (!SetDefaultSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectDelayPreset:SetDefaultSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDefaultSettings_InSettings_PropertyAddress.Address, intPtr);
		FSubmixEffectDelaySettings.ToNative(IntPtr.Add(intPtr, SetDefaultSettings_InSettings_Offset), 0, SetDefaultSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultSettings_FunctionAddress, intPtr, SetDefaultSettings_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelayPreset:GetMaxDelayInMilliseconds")]
	public unsafe float GetMaxDelayInMilliseconds()
	{
		CheckDestroyed();
		if (!GetMaxDelayInMilliseconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectDelayPreset:GetMaxDelayInMilliseconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxDelayInMilliseconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxDelayInMilliseconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxDelayInMilliseconds_FunctionAddress, intPtr, GetMaxDelayInMilliseconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMaxDelayInMilliseconds_ReturnValue_Offset), 0, GetMaxDelayInMilliseconds_ReturnValue_PropertyAddress.Address);
	}

	static USubmixEffectDelayPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubmixEffectDelayPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubmixEffectDelayPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SubmixEffectDelayPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectDelayPreset:SetSettings", SetSettings_IsValid);
		SetInterpolationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInterpolationTime");
		SetInterpolationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInterpolationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInterpolationTime_Time_PropertyAddress, SetInterpolationTime_FunctionAddress, "Time");
		SetInterpolationTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(SetInterpolationTime_FunctionAddress, "Time");
		SetInterpolationTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterpolationTime_FunctionAddress, "Time", Classes.FFloatProperty);
		SetInterpolationTime_IsValid = SetInterpolationTime_FunctionAddress != IntPtr.Zero && SetInterpolationTime_Time_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectDelayPreset:SetInterpolationTime", SetInterpolationTime_IsValid);
		SetDelay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDelay");
		SetDelay_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDelay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDelay_Length_PropertyAddress, SetDelay_FunctionAddress, "Length");
		SetDelay_Length_Offset = NativeReflectionCached.GetPropertyOffset(SetDelay_FunctionAddress, "Length");
		SetDelay_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDelay_FunctionAddress, "Length", Classes.FFloatProperty);
		SetDelay_IsValid = SetDelay_FunctionAddress != IntPtr.Zero && SetDelay_Length_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectDelayPreset:SetDelay", SetDelay_IsValid);
		SetDefaultSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultSettings");
		SetDefaultSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultSettings_InSettings_PropertyAddress, SetDefaultSettings_FunctionAddress, "InSettings");
		SetDefaultSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultSettings_FunctionAddress, "InSettings");
		SetDefaultSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetDefaultSettings_IsValid = SetDefaultSettings_FunctionAddress != IntPtr.Zero && SetDefaultSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectDelayPreset:SetDefaultSettings", SetDefaultSettings_IsValid);
		GetMaxDelayInMilliseconds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxDelayInMilliseconds");
		GetMaxDelayInMilliseconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxDelayInMilliseconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxDelayInMilliseconds_ReturnValue_PropertyAddress, GetMaxDelayInMilliseconds_FunctionAddress, "ReturnValue");
		GetMaxDelayInMilliseconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxDelayInMilliseconds_FunctionAddress, "ReturnValue");
		GetMaxDelayInMilliseconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxDelayInMilliseconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMaxDelayInMilliseconds_IsValid = GetMaxDelayInMilliseconds_FunctionAddress != IntPtr.Zero && GetMaxDelayInMilliseconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectDelayPreset:GetMaxDelayInMilliseconds", GetMaxDelayInMilliseconds_IsValid);
	}
}
