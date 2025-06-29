using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USubmixEffectTapDelayPreset : USoundEffectSubmixPreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetTap_IsValid;

	private static IntPtr SetTap_FunctionAddress;

	private static int SetTap_ParamsSize;

	private static bool SetTap_TapId_IsValid;

	private static FFieldAddress SetTap_TapId_PropertyAddress;

	private static int SetTap_TapId_Offset;

	private static bool SetTap_TapInfo_IsValid;

	private static FFieldAddress SetTap_TapInfo_PropertyAddress;

	private static int SetTap_TapInfo_Offset;

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

	private static bool RemoveTap_IsValid;

	private static IntPtr RemoveTap_FunctionAddress;

	private static int RemoveTap_ParamsSize;

	private static bool RemoveTap_TapId_IsValid;

	private static FFieldAddress RemoveTap_TapId_PropertyAddress;

	private static int RemoveTap_TapId_Offset;

	private static bool GetTapIds_IsValid;

	private static IntPtr GetTapIds_FunctionAddress;

	private static int GetTapIds_ParamsSize;

	private static bool GetTapIds_TapIds_IsValid;

	private static FFieldAddress GetTapIds_TapIds_PropertyAddress;

	private static int GetTapIds_TapIds_Offset;

	private static bool GetTap_IsValid;

	private static IntPtr GetTap_FunctionAddress;

	private static int GetTap_ParamsSize;

	private static bool GetTap_TapId_IsValid;

	private static FFieldAddress GetTap_TapId_PropertyAddress;

	private static int GetTap_TapId_Offset;

	private static bool GetTap_TapInfo_IsValid;

	private static FFieldAddress GetTap_TapInfo_PropertyAddress;

	private static int GetTap_TapInfo_Offset;

	private static bool GetMaxDelayInMilliseconds_IsValid;

	private static IntPtr GetMaxDelayInMilliseconds_FunctionAddress;

	private static int GetMaxDelayInMilliseconds_ParamsSize;

	private static bool GetMaxDelayInMilliseconds_ReturnValue_IsValid;

	private static FFieldAddress GetMaxDelayInMilliseconds_ReturnValue_PropertyAddress;

	private static int GetMaxDelayInMilliseconds_ReturnValue_Offset;

	private static bool AddTap_IsValid;

	private static IntPtr AddTap_FunctionAddress;

	private static int AddTap_ParamsSize;

	private static bool AddTap_TapId_IsValid;

	private static FFieldAddress AddTap_TapId_PropertyAddress;

	private static int AddTap_TapId_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset:Settings")]
	public FSubmixEffectTapDelaySettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:Settings");
				return default(FSubmixEffectTapDelaySettings);
			}
			return FSubmixEffectTapDelaySettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:Settings");
			}
			else
			{
				FSubmixEffectTapDelaySettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset:SetTap")]
	public unsafe void SetTap(int TapId, FTapDelayInfo TapInfo)
	{
		CheckDestroyed();
		if (!SetTap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:SetTap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTap_TapId_Offset), 0, SetTap_TapId_PropertyAddress.Address, TapId);
		NativeReflection.InitializeValue_InContainer(SetTap_TapInfo_PropertyAddress.Address, intPtr);
		FTapDelayInfo.ToNative(IntPtr.Add(intPtr, SetTap_TapInfo_Offset), 0, SetTap_TapInfo_PropertyAddress.Address, TapInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTap_FunctionAddress, intPtr, SetTap_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset:SetSettings")]
	public unsafe void SetSettings(FSubmixEffectTapDelaySettings InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
		FSubmixEffectTapDelaySettings.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset:SetInterpolationTime")]
	public unsafe void SetInterpolationTime(float Time)
	{
		CheckDestroyed();
		if (!SetInterpolationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:SetInterpolationTime");
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
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset:RemoveTap")]
	public unsafe void RemoveTap(int TapId)
	{
		CheckDestroyed();
		if (!RemoveTap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:RemoveTap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveTap_TapId_Offset), 0, RemoveTap_TapId_PropertyAddress.Address, TapId);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTap_FunctionAddress, intPtr, RemoveTap_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset:GetTapIds")]
	public unsafe void GetTapIds(out List<int> TapIds)
	{
		CheckDestroyed();
		if (!GetTapIds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:GetTapIds");
			TapIds = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTapIds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTapIds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTapIds_FunctionAddress, intPtr, GetTapIds_ParamsSize);
		TapIds = new TArrayCopyMarshaler<int>(1, GetTapIds_TapIds_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTapIds_TapIds_Offset));
		NativeReflection.DestroyValue_InContainer(GetTapIds_TapIds_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset:GetTap")]
	public unsafe void GetTap(int TapId, out FTapDelayInfo TapInfo)
	{
		CheckDestroyed();
		if (!GetTap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:GetTap");
			TapInfo = default(FTapDelayInfo);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTap_TapId_Offset), 0, GetTap_TapId_PropertyAddress.Address, TapId);
		NativeReflection.InitializeValue_InContainer(GetTap_TapInfo_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTap_FunctionAddress, intPtr, GetTap_ParamsSize);
		TapInfo = FTapDelayInfo.FromNative(IntPtr.Add(intPtr, GetTap_TapInfo_Offset), 0, GetTap_TapInfo_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset:GetMaxDelayInMilliseconds")]
	public unsafe float GetMaxDelayInMilliseconds()
	{
		CheckDestroyed();
		if (!GetMaxDelayInMilliseconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:GetMaxDelayInMilliseconds");
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

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectTapDelayPreset:AddTap")]
	public unsafe void AddTap(out int TapId)
	{
		CheckDestroyed();
		if (!AddTap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectTapDelayPreset:AddTap");
			TapId = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTap_FunctionAddress, intPtr, AddTap_ParamsSize);
		TapId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddTap_TapId_Offset), 0, AddTap_TapId_PropertyAddress.Address);
	}

	static USubmixEffectTapDelayPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubmixEffectTapDelayPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubmixEffectTapDelayPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SubmixEffectTapDelayPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetTap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTap");
		SetTap_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTap_TapId_PropertyAddress, SetTap_FunctionAddress, "TapId");
		SetTap_TapId_Offset = NativeReflectionCached.GetPropertyOffset(SetTap_FunctionAddress, "TapId");
		SetTap_TapId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTap_FunctionAddress, "TapId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTap_TapInfo_PropertyAddress, SetTap_FunctionAddress, "TapInfo");
		SetTap_TapInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetTap_FunctionAddress, "TapInfo");
		SetTap_TapInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTap_FunctionAddress, "TapInfo", Classes.FStructProperty);
		SetTap_IsValid = SetTap_FunctionAddress != IntPtr.Zero && SetTap_TapId_IsValid && SetTap_TapInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectTapDelayPreset:SetTap", SetTap_IsValid);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectTapDelayPreset:SetSettings", SetSettings_IsValid);
		SetInterpolationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInterpolationTime");
		SetInterpolationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInterpolationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInterpolationTime_Time_PropertyAddress, SetInterpolationTime_FunctionAddress, "Time");
		SetInterpolationTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(SetInterpolationTime_FunctionAddress, "Time");
		SetInterpolationTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterpolationTime_FunctionAddress, "Time", Classes.FFloatProperty);
		SetInterpolationTime_IsValid = SetInterpolationTime_FunctionAddress != IntPtr.Zero && SetInterpolationTime_Time_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectTapDelayPreset:SetInterpolationTime", SetInterpolationTime_IsValid);
		RemoveTap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveTap");
		RemoveTap_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTap_TapId_PropertyAddress, RemoveTap_FunctionAddress, "TapId");
		RemoveTap_TapId_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTap_FunctionAddress, "TapId");
		RemoveTap_TapId_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTap_FunctionAddress, "TapId", Classes.FIntProperty);
		RemoveTap_IsValid = RemoveTap_FunctionAddress != IntPtr.Zero && RemoveTap_TapId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectTapDelayPreset:RemoveTap", RemoveTap_IsValid);
		GetTapIds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTapIds");
		GetTapIds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTapIds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTapIds_TapIds_PropertyAddress, GetTapIds_FunctionAddress, "TapIds");
		GetTapIds_TapIds_Offset = NativeReflectionCached.GetPropertyOffset(GetTapIds_FunctionAddress, "TapIds");
		GetTapIds_TapIds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTapIds_FunctionAddress, "TapIds", Classes.FArrayProperty);
		GetTapIds_IsValid = GetTapIds_FunctionAddress != IntPtr.Zero && GetTapIds_TapIds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectTapDelayPreset:GetTapIds", GetTapIds_IsValid);
		GetTap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTap");
		GetTap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTap_TapId_PropertyAddress, GetTap_FunctionAddress, "TapId");
		GetTap_TapId_Offset = NativeReflectionCached.GetPropertyOffset(GetTap_FunctionAddress, "TapId");
		GetTap_TapId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTap_FunctionAddress, "TapId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTap_TapInfo_PropertyAddress, GetTap_FunctionAddress, "TapInfo");
		GetTap_TapInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetTap_FunctionAddress, "TapInfo");
		GetTap_TapInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTap_FunctionAddress, "TapInfo", Classes.FStructProperty);
		GetTap_IsValid = GetTap_FunctionAddress != IntPtr.Zero && GetTap_TapId_IsValid && GetTap_TapInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectTapDelayPreset:GetTap", GetTap_IsValid);
		GetMaxDelayInMilliseconds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxDelayInMilliseconds");
		GetMaxDelayInMilliseconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxDelayInMilliseconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxDelayInMilliseconds_ReturnValue_PropertyAddress, GetMaxDelayInMilliseconds_FunctionAddress, "ReturnValue");
		GetMaxDelayInMilliseconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxDelayInMilliseconds_FunctionAddress, "ReturnValue");
		GetMaxDelayInMilliseconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxDelayInMilliseconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMaxDelayInMilliseconds_IsValid = GetMaxDelayInMilliseconds_FunctionAddress != IntPtr.Zero && GetMaxDelayInMilliseconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectTapDelayPreset:GetMaxDelayInMilliseconds", GetMaxDelayInMilliseconds_IsValid);
		AddTap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddTap");
		AddTap_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTap_TapId_PropertyAddress, AddTap_FunctionAddress, "TapId");
		AddTap_TapId_Offset = NativeReflectionCached.GetPropertyOffset(AddTap_FunctionAddress, "TapId");
		AddTap_TapId_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTap_FunctionAddress, "TapId", Classes.FIntProperty);
		AddTap_IsValid = AddTap_FunctionAddress != IntPtr.Zero && AddTap_TapId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectTapDelayPreset:AddTap", AddTap_IsValid);
	}
}
