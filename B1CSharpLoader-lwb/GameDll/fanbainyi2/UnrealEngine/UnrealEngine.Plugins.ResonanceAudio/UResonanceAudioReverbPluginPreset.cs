using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ResonanceAudio;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset", "ResonanceAudio", UnrealModuleType.EnginePlugin)]
public class UResonanceAudioReverbPluginPreset : USoundEffectSubmixPreset
{
	private static bool SetRoomRotation_IsValid;

	private static IntPtr SetRoomRotation_FunctionAddress;

	private static int SetRoomRotation_ParamsSize;

	private static bool SetRoomRotation_InRotation_IsValid;

	private static FFieldAddress SetRoomRotation_InRotation_PropertyAddress;

	private static int SetRoomRotation_InRotation_Offset;

	private static bool SetRoomPosition_IsValid;

	private static IntPtr SetRoomPosition_FunctionAddress;

	private static int SetRoomPosition_ParamsSize;

	private static bool SetRoomPosition_InPosition_IsValid;

	private static FFieldAddress SetRoomPosition_InPosition_PropertyAddress;

	private static int SetRoomPosition_InPosition_Offset;

	private static bool SetRoomMaterials_IsValid;

	private static IntPtr SetRoomMaterials_FunctionAddress;

	private static int SetRoomMaterials_ParamsSize;

	private static bool SetRoomMaterials_InMaterials_IsValid;

	private static FFieldAddress SetRoomMaterials_InMaterials_PropertyAddress;

	private static int SetRoomMaterials_InMaterials_Offset;

	private static bool SetRoomDimensions_IsValid;

	private static IntPtr SetRoomDimensions_FunctionAddress;

	private static int SetRoomDimensions_ParamsSize;

	private static bool SetRoomDimensions_InDimensions_IsValid;

	private static FFieldAddress SetRoomDimensions_InDimensions_PropertyAddress;

	private static int SetRoomDimensions_InDimensions_Offset;

	private static bool SetReverbTimeModifier_IsValid;

	private static IntPtr SetReverbTimeModifier_FunctionAddress;

	private static int SetReverbTimeModifier_ParamsSize;

	private static bool SetReverbTimeModifier_InReverbTimeModifier_IsValid;

	private static FFieldAddress SetReverbTimeModifier_InReverbTimeModifier_PropertyAddress;

	private static int SetReverbTimeModifier_InReverbTimeModifier_Offset;

	private static bool SetReverbGain_IsValid;

	private static IntPtr SetReverbGain_FunctionAddress;

	private static int SetReverbGain_ParamsSize;

	private static bool SetReverbGain_InReverbGain_IsValid;

	private static FFieldAddress SetReverbGain_InReverbGain_PropertyAddress;

	private static int SetReverbGain_InReverbGain_Offset;

	private static bool SetReverbBrightness_IsValid;

	private static IntPtr SetReverbBrightness_FunctionAddress;

	private static int SetReverbBrightness_ParamsSize;

	private static bool SetReverbBrightness_InReverbBrightness_IsValid;

	private static FFieldAddress SetReverbBrightness_InReverbBrightness_PropertyAddress;

	private static int SetReverbBrightness_InReverbBrightness_Offset;

	private static bool SetReflectionScalar_IsValid;

	private static IntPtr SetReflectionScalar_FunctionAddress;

	private static int SetReflectionScalar_ParamsSize;

	private static bool SetReflectionScalar_InReflectionScalar_IsValid;

	private static FFieldAddress SetReflectionScalar_InReflectionScalar_PropertyAddress;

	private static int SetReflectionScalar_InReflectionScalar_Offset;

	private static bool SetEnableRoomEffects_IsValid;

	private static IntPtr SetEnableRoomEffects_FunctionAddress;

	private static int SetEnableRoomEffects_ParamsSize;

	private static bool SetEnableRoomEffects_bInEnableRoomEffects_IsValid;

	private static FFieldAddress SetEnableRoomEffects_bInEnableRoomEffects_PropertyAddress;

	private static int SetEnableRoomEffects_bInEnableRoomEffects_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomRotation")]
	public unsafe void SetRoomRotation(FQuat InRotation)
	{
		CheckDestroyed();
		if (!SetRoomRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRoomRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRoomRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRoomRotation_InRotation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetRoomRotation_InRotation_Offset), 0, SetRoomRotation_InRotation_PropertyAddress.Address, InRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRoomRotation_FunctionAddress, intPtr, SetRoomRotation_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomPosition")]
	public unsafe void SetRoomPosition(FVector InPosition)
	{
		CheckDestroyed();
		if (!SetRoomPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRoomPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRoomPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetRoomPosition_InPosition_Offset), 0, SetRoomPosition_InPosition_PropertyAddress.Address, InPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRoomPosition_FunctionAddress, intPtr, SetRoomPosition_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomMaterials")]
	public unsafe void SetRoomMaterials(List<ERaMaterialName> InMaterials)
	{
		CheckDestroyed();
		if (!SetRoomMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRoomMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRoomMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<ERaMaterialName>(1, SetRoomMaterials_InMaterials_PropertyAddress, CachedMarshalingDelegates<ERaMaterialName, EnumMarshaler<ERaMaterialName>>.FromNative, CachedMarshalingDelegates<ERaMaterialName, EnumMarshaler<ERaMaterialName>>.ToNative).ToNative(IntPtr.Add(intPtr, SetRoomMaterials_InMaterials_Offset), InMaterials);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRoomMaterials_FunctionAddress, intPtr, SetRoomMaterials_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetRoomMaterials_InMaterials_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomDimensions")]
	public unsafe void SetRoomDimensions(FVector InDimensions)
	{
		CheckDestroyed();
		if (!SetRoomDimensions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomDimensions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRoomDimensions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRoomDimensions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetRoomDimensions_InDimensions_Offset), 0, SetRoomDimensions_InDimensions_PropertyAddress.Address, InDimensions);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRoomDimensions_FunctionAddress, intPtr, SetRoomDimensions_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbTimeModifier")]
	public unsafe void SetReverbTimeModifier(float InReverbTimeModifier)
	{
		CheckDestroyed();
		if (!SetReverbTimeModifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbTimeModifier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReverbTimeModifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReverbTimeModifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetReverbTimeModifier_InReverbTimeModifier_Offset), 0, SetReverbTimeModifier_InReverbTimeModifier_PropertyAddress.Address, InReverbTimeModifier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReverbTimeModifier_FunctionAddress, intPtr, SetReverbTimeModifier_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbGain")]
	public unsafe void SetReverbGain(float InReverbGain)
	{
		CheckDestroyed();
		if (!SetReverbGain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbGain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReverbGain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReverbGain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetReverbGain_InReverbGain_Offset), 0, SetReverbGain_InReverbGain_PropertyAddress.Address, InReverbGain);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReverbGain_FunctionAddress, intPtr, SetReverbGain_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbBrightness")]
	public unsafe void SetReverbBrightness(float InReverbBrightness)
	{
		CheckDestroyed();
		if (!SetReverbBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbBrightness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReverbBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReverbBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetReverbBrightness_InReverbBrightness_Offset), 0, SetReverbBrightness_InReverbBrightness_PropertyAddress.Address, InReverbBrightness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReverbBrightness_FunctionAddress, intPtr, SetReverbBrightness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReflectionScalar")]
	public unsafe void SetReflectionScalar(float InReflectionScalar)
	{
		CheckDestroyed();
		if (!SetReflectionScalar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReflectionScalar");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReflectionScalar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReflectionScalar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetReflectionScalar_InReflectionScalar_Offset), 0, SetReflectionScalar_InReflectionScalar_PropertyAddress.Address, InReflectionScalar);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReflectionScalar_FunctionAddress, intPtr, SetReflectionScalar_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetEnableRoomEffects")]
	public unsafe void SetEnableRoomEffects(bool bInEnableRoomEffects)
	{
		CheckDestroyed();
		if (!SetEnableRoomEffects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetEnableRoomEffects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableRoomEffects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableRoomEffects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableRoomEffects_bInEnableRoomEffects_Offset), 0, SetEnableRoomEffects_bInEnableRoomEffects_PropertyAddress.Address, bInEnableRoomEffects);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableRoomEffects_FunctionAddress, intPtr, SetEnableRoomEffects_ParamsSize);
	}

	static UResonanceAudioReverbPluginPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UResonanceAudioReverbPluginPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UResonanceAudioReverbPluginPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset");
		SetRoomRotation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRoomRotation");
		SetRoomRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRoomRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRoomRotation_InRotation_PropertyAddress, SetRoomRotation_FunctionAddress, "InRotation");
		SetRoomRotation_InRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetRoomRotation_FunctionAddress, "InRotation");
		SetRoomRotation_InRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRoomRotation_FunctionAddress, "InRotation", Classes.FStructProperty);
		SetRoomRotation_IsValid = SetRoomRotation_FunctionAddress != IntPtr.Zero && SetRoomRotation_InRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomRotation", SetRoomRotation_IsValid);
		SetRoomPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRoomPosition");
		SetRoomPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRoomPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRoomPosition_InPosition_PropertyAddress, SetRoomPosition_FunctionAddress, "InPosition");
		SetRoomPosition_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetRoomPosition_FunctionAddress, "InPosition");
		SetRoomPosition_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRoomPosition_FunctionAddress, "InPosition", Classes.FStructProperty);
		SetRoomPosition_IsValid = SetRoomPosition_FunctionAddress != IntPtr.Zero && SetRoomPosition_InPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomPosition", SetRoomPosition_IsValid);
		SetRoomMaterials_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRoomMaterials");
		SetRoomMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRoomMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRoomMaterials_InMaterials_PropertyAddress, SetRoomMaterials_FunctionAddress, "InMaterials");
		SetRoomMaterials_InMaterials_Offset = NativeReflectionCached.GetPropertyOffset(SetRoomMaterials_FunctionAddress, "InMaterials");
		SetRoomMaterials_InMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRoomMaterials_FunctionAddress, "InMaterials", Classes.FArrayProperty);
		SetRoomMaterials_IsValid = SetRoomMaterials_FunctionAddress != IntPtr.Zero && SetRoomMaterials_InMaterials_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomMaterials", SetRoomMaterials_IsValid);
		SetRoomDimensions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRoomDimensions");
		SetRoomDimensions_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRoomDimensions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRoomDimensions_InDimensions_PropertyAddress, SetRoomDimensions_FunctionAddress, "InDimensions");
		SetRoomDimensions_InDimensions_Offset = NativeReflectionCached.GetPropertyOffset(SetRoomDimensions_FunctionAddress, "InDimensions");
		SetRoomDimensions_InDimensions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRoomDimensions_FunctionAddress, "InDimensions", Classes.FStructProperty);
		SetRoomDimensions_IsValid = SetRoomDimensions_FunctionAddress != IntPtr.Zero && SetRoomDimensions_InDimensions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetRoomDimensions", SetRoomDimensions_IsValid);
		SetReverbTimeModifier_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetReverbTimeModifier");
		SetReverbTimeModifier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReverbTimeModifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReverbTimeModifier_InReverbTimeModifier_PropertyAddress, SetReverbTimeModifier_FunctionAddress, "InReverbTimeModifier");
		SetReverbTimeModifier_InReverbTimeModifier_Offset = NativeReflectionCached.GetPropertyOffset(SetReverbTimeModifier_FunctionAddress, "InReverbTimeModifier");
		SetReverbTimeModifier_InReverbTimeModifier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReverbTimeModifier_FunctionAddress, "InReverbTimeModifier", Classes.FFloatProperty);
		SetReverbTimeModifier_IsValid = SetReverbTimeModifier_FunctionAddress != IntPtr.Zero && SetReverbTimeModifier_InReverbTimeModifier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbTimeModifier", SetReverbTimeModifier_IsValid);
		SetReverbGain_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetReverbGain");
		SetReverbGain_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReverbGain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReverbGain_InReverbGain_PropertyAddress, SetReverbGain_FunctionAddress, "InReverbGain");
		SetReverbGain_InReverbGain_Offset = NativeReflectionCached.GetPropertyOffset(SetReverbGain_FunctionAddress, "InReverbGain");
		SetReverbGain_InReverbGain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReverbGain_FunctionAddress, "InReverbGain", Classes.FFloatProperty);
		SetReverbGain_IsValid = SetReverbGain_FunctionAddress != IntPtr.Zero && SetReverbGain_InReverbGain_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbGain", SetReverbGain_IsValid);
		SetReverbBrightness_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetReverbBrightness");
		SetReverbBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReverbBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReverbBrightness_InReverbBrightness_PropertyAddress, SetReverbBrightness_FunctionAddress, "InReverbBrightness");
		SetReverbBrightness_InReverbBrightness_Offset = NativeReflectionCached.GetPropertyOffset(SetReverbBrightness_FunctionAddress, "InReverbBrightness");
		SetReverbBrightness_InReverbBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReverbBrightness_FunctionAddress, "InReverbBrightness", Classes.FFloatProperty);
		SetReverbBrightness_IsValid = SetReverbBrightness_FunctionAddress != IntPtr.Zero && SetReverbBrightness_InReverbBrightness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReverbBrightness", SetReverbBrightness_IsValid);
		SetReflectionScalar_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetReflectionScalar");
		SetReflectionScalar_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReflectionScalar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReflectionScalar_InReflectionScalar_PropertyAddress, SetReflectionScalar_FunctionAddress, "InReflectionScalar");
		SetReflectionScalar_InReflectionScalar_Offset = NativeReflectionCached.GetPropertyOffset(SetReflectionScalar_FunctionAddress, "InReflectionScalar");
		SetReflectionScalar_InReflectionScalar_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReflectionScalar_FunctionAddress, "InReflectionScalar", Classes.FFloatProperty);
		SetReflectionScalar_IsValid = SetReflectionScalar_FunctionAddress != IntPtr.Zero && SetReflectionScalar_InReflectionScalar_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetReflectionScalar", SetReflectionScalar_IsValid);
		SetEnableRoomEffects_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEnableRoomEffects");
		SetEnableRoomEffects_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableRoomEffects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableRoomEffects_bInEnableRoomEffects_PropertyAddress, SetEnableRoomEffects_FunctionAddress, "bInEnableRoomEffects");
		SetEnableRoomEffects_bInEnableRoomEffects_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableRoomEffects_FunctionAddress, "bInEnableRoomEffects");
		SetEnableRoomEffects_bInEnableRoomEffects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableRoomEffects_FunctionAddress, "bInEnableRoomEffects", Classes.FBoolProperty);
		SetEnableRoomEffects_IsValid = SetEnableRoomEffects_FunctionAddress != IntPtr.Zero && SetEnableRoomEffects_bInEnableRoomEffects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset:SetEnableRoomEffects", SetEnableRoomEffects_IsValid);
	}
}
