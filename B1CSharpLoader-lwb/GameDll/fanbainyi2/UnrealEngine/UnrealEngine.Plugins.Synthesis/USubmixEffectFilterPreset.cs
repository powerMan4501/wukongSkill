using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectFilterPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USubmixEffectFilterPreset : USoundEffectSubmixPreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_InSettings_IsValid;

	private static FFieldAddress SetSettings_InSettings_PropertyAddress;

	private static int SetSettings_InSettings_Offset;

	private static bool SetFilterType_IsValid;

	private static IntPtr SetFilterType_FunctionAddress;

	private static int SetFilterType_ParamsSize;

	private static bool SetFilterType_InType_IsValid;

	private static FFieldAddress SetFilterType_InType_PropertyAddress;

	private static int SetFilterType_InType_Offset;

	private static bool SetFilterQMod_IsValid;

	private static IntPtr SetFilterQMod_FunctionAddress;

	private static int SetFilterQMod_ParamsSize;

	private static bool SetFilterQMod_InQ_IsValid;

	private static FFieldAddress SetFilterQMod_InQ_PropertyAddress;

	private static int SetFilterQMod_InQ_Offset;

	private static bool SetFilterQ_IsValid;

	private static IntPtr SetFilterQ_FunctionAddress;

	private static int SetFilterQ_ParamsSize;

	private static bool SetFilterQ_InQ_IsValid;

	private static FFieldAddress SetFilterQ_InQ_PropertyAddress;

	private static int SetFilterQ_InQ_Offset;

	private static bool SetFilterCutoffFrequencyMod_IsValid;

	private static IntPtr SetFilterCutoffFrequencyMod_FunctionAddress;

	private static int SetFilterCutoffFrequencyMod_ParamsSize;

	private static bool SetFilterCutoffFrequencyMod_InFrequency_IsValid;

	private static FFieldAddress SetFilterCutoffFrequencyMod_InFrequency_PropertyAddress;

	private static int SetFilterCutoffFrequencyMod_InFrequency_Offset;

	private static bool SetFilterCutoffFrequency_IsValid;

	private static IntPtr SetFilterCutoffFrequency_FunctionAddress;

	private static int SetFilterCutoffFrequency_ParamsSize;

	private static bool SetFilterCutoffFrequency_InFrequency_IsValid;

	private static FFieldAddress SetFilterCutoffFrequency_InFrequency_PropertyAddress;

	private static int SetFilterCutoffFrequency_InFrequency_Offset;

	private static bool SetFilterAlgorithm_IsValid;

	private static IntPtr SetFilterAlgorithm_FunctionAddress;

	private static int SetFilterAlgorithm_ParamsSize;

	private static bool SetFilterAlgorithm_InAlgorithm_IsValid;

	private static FFieldAddress SetFilterAlgorithm_InAlgorithm_PropertyAddress;

	private static int SetFilterAlgorithm_InAlgorithm_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterPreset:Settings")]
	public FSubmixEffectFilterSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectFilterPreset:Settings");
				return default(FSubmixEffectFilterSettings);
			}
			return FSubmixEffectFilterSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectFilterPreset:Settings");
			}
			else
			{
				FSubmixEffectFilterSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterPreset:SetSettings")]
	public unsafe void SetSettings(FSubmixEffectFilterSettings InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectFilterPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
		FSubmixEffectFilterSettings.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterType")]
	public unsafe void SetFilterType(ESubmixFilterType InType)
	{
		CheckDestroyed();
		if (!SetFilterType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESubmixFilterType>.ToNative(IntPtr.Add(intPtr, SetFilterType_InType_Offset), 0, SetFilterType_InType_PropertyAddress.Address, InType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterType_FunctionAddress, intPtr, SetFilterType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterQMod")]
	public unsafe void SetFilterQMod(float InQ)
	{
		CheckDestroyed();
		if (!SetFilterQMod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterQMod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterQMod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterQMod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterQMod_InQ_Offset), 0, SetFilterQMod_InQ_PropertyAddress.Address, InQ);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterQMod_FunctionAddress, intPtr, SetFilterQMod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterQ")]
	public unsafe void SetFilterQ(float InQ)
	{
		CheckDestroyed();
		if (!SetFilterQ_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterQ");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterQ_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterQ_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterQ_InQ_Offset), 0, SetFilterQ_InQ_PropertyAddress.Address, InQ);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterQ_FunctionAddress, intPtr, SetFilterQ_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterCutoffFrequencyMod")]
	public unsafe void SetFilterCutoffFrequencyMod(float InFrequency)
	{
		CheckDestroyed();
		if (!SetFilterCutoffFrequencyMod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterCutoffFrequencyMod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterCutoffFrequencyMod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterCutoffFrequencyMod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterCutoffFrequencyMod_InFrequency_Offset), 0, SetFilterCutoffFrequencyMod_InFrequency_PropertyAddress.Address, InFrequency);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterCutoffFrequencyMod_FunctionAddress, intPtr, SetFilterCutoffFrequencyMod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterCutoffFrequency")]
	public unsafe void SetFilterCutoffFrequency(float InFrequency)
	{
		CheckDestroyed();
		if (!SetFilterCutoffFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterCutoffFrequency");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterCutoffFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterCutoffFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterCutoffFrequency_InFrequency_Offset), 0, SetFilterCutoffFrequency_InFrequency_PropertyAddress.Address, InFrequency);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterCutoffFrequency_FunctionAddress, intPtr, SetFilterCutoffFrequency_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterAlgorithm")]
	public unsafe void SetFilterAlgorithm(ESubmixFilterAlgorithm InAlgorithm)
	{
		CheckDestroyed();
		if (!SetFilterAlgorithm_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterAlgorithm");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterAlgorithm_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterAlgorithm_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESubmixFilterAlgorithm>.ToNative(IntPtr.Add(intPtr, SetFilterAlgorithm_InAlgorithm_Offset), 0, SetFilterAlgorithm_InAlgorithm_PropertyAddress.Address, InAlgorithm);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterAlgorithm_FunctionAddress, intPtr, SetFilterAlgorithm_ParamsSize);
	}

	static USubmixEffectFilterPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubmixEffectFilterPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubmixEffectFilterPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SubmixEffectFilterPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectFilterPreset:SetSettings", SetSettings_IsValid);
		SetFilterType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterType");
		SetFilterType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterType_InType_PropertyAddress, SetFilterType_FunctionAddress, "InType");
		SetFilterType_InType_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterType_FunctionAddress, "InType");
		SetFilterType_InType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterType_FunctionAddress, "InType", Classes.FEnumProperty);
		SetFilterType_IsValid = SetFilterType_FunctionAddress != IntPtr.Zero && SetFilterType_InType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterType", SetFilterType_IsValid);
		SetFilterQMod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterQMod");
		SetFilterQMod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterQMod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterQMod_InQ_PropertyAddress, SetFilterQMod_FunctionAddress, "InQ");
		SetFilterQMod_InQ_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterQMod_FunctionAddress, "InQ");
		SetFilterQMod_InQ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterQMod_FunctionAddress, "InQ", Classes.FFloatProperty);
		SetFilterQMod_IsValid = SetFilterQMod_FunctionAddress != IntPtr.Zero && SetFilterQMod_InQ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterQMod", SetFilterQMod_IsValid);
		SetFilterQ_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterQ");
		SetFilterQ_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterQ_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterQ_InQ_PropertyAddress, SetFilterQ_FunctionAddress, "InQ");
		SetFilterQ_InQ_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterQ_FunctionAddress, "InQ");
		SetFilterQ_InQ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterQ_FunctionAddress, "InQ", Classes.FFloatProperty);
		SetFilterQ_IsValid = SetFilterQ_FunctionAddress != IntPtr.Zero && SetFilterQ_InQ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterQ", SetFilterQ_IsValid);
		SetFilterCutoffFrequencyMod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterCutoffFrequencyMod");
		SetFilterCutoffFrequencyMod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterCutoffFrequencyMod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterCutoffFrequencyMod_InFrequency_PropertyAddress, SetFilterCutoffFrequencyMod_FunctionAddress, "InFrequency");
		SetFilterCutoffFrequencyMod_InFrequency_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterCutoffFrequencyMod_FunctionAddress, "InFrequency");
		SetFilterCutoffFrequencyMod_InFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterCutoffFrequencyMod_FunctionAddress, "InFrequency", Classes.FFloatProperty);
		SetFilterCutoffFrequencyMod_IsValid = SetFilterCutoffFrequencyMod_FunctionAddress != IntPtr.Zero && SetFilterCutoffFrequencyMod_InFrequency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterCutoffFrequencyMod", SetFilterCutoffFrequencyMod_IsValid);
		SetFilterCutoffFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterCutoffFrequency");
		SetFilterCutoffFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterCutoffFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterCutoffFrequency_InFrequency_PropertyAddress, SetFilterCutoffFrequency_FunctionAddress, "InFrequency");
		SetFilterCutoffFrequency_InFrequency_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterCutoffFrequency_FunctionAddress, "InFrequency");
		SetFilterCutoffFrequency_InFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterCutoffFrequency_FunctionAddress, "InFrequency", Classes.FFloatProperty);
		SetFilterCutoffFrequency_IsValid = SetFilterCutoffFrequency_FunctionAddress != IntPtr.Zero && SetFilterCutoffFrequency_InFrequency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterCutoffFrequency", SetFilterCutoffFrequency_IsValid);
		SetFilterAlgorithm_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterAlgorithm");
		SetFilterAlgorithm_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterAlgorithm_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterAlgorithm_InAlgorithm_PropertyAddress, SetFilterAlgorithm_FunctionAddress, "InAlgorithm");
		SetFilterAlgorithm_InAlgorithm_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterAlgorithm_FunctionAddress, "InAlgorithm");
		SetFilterAlgorithm_InAlgorithm_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterAlgorithm_FunctionAddress, "InAlgorithm", Classes.FEnumProperty);
		SetFilterAlgorithm_IsValid = SetFilterAlgorithm_FunctionAddress != IntPtr.Zero && SetFilterAlgorithm_InAlgorithm_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectFilterPreset:SetFilterAlgorithm", SetFilterAlgorithm_IsValid);
	}
}
