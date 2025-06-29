using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AudioVolume", "Engine", UnrealModuleType.Engine)]
public class AAudioVolume : AVolume
{
	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool AmbientZoneSettings_IsValid;

	private static int AmbientZoneSettings_Offset;

	private static bool SubmixSendSettings_IsValid;

	private static FFieldAddress SubmixSendSettings_PropertyAddress;

	private static int SubmixSendSettings_Offset;

	private TArrayReadOnlyMarshaler<FAudioVolumeSubmixSendSettings> SubmixSendSettings_MarshalerCached;

	private static bool SubmixOverrideSettings_IsValid;

	private static FFieldAddress SubmixOverrideSettings_PropertyAddress;

	private static int SubmixOverrideSettings_Offset;

	private TArrayReadOnlyMarshaler<FAudioVolumeSubmixOverrideSettings> SubmixOverrideSettings_MarshalerCached;

	private static bool SetSubmixSendSettings_IsValid;

	private static IntPtr SetSubmixSendSettings_FunctionAddress;

	private static int SetSubmixSendSettings_ParamsSize;

	private static bool SetSubmixSendSettings_NewSubmixSendSettings_IsValid;

	private static FFieldAddress SetSubmixSendSettings_NewSubmixSendSettings_PropertyAddress;

	private static int SetSubmixSendSettings_NewSubmixSendSettings_Offset;

	private static bool SetSubmixOverrideSettings_IsValid;

	private static IntPtr SetSubmixOverrideSettings_FunctionAddress;

	private static int SetSubmixOverrideSettings_ParamsSize;

	private static bool SetSubmixOverrideSettings_NewSubmixOverrideSettings_IsValid;

	private static FFieldAddress SetSubmixOverrideSettings_NewSubmixOverrideSettings_PropertyAddress;

	private static int SetSubmixOverrideSettings_NewSubmixOverrideSettings_Offset;

	private static bool SetReverbSettings_IsValid;

	private static IntPtr SetReverbSettings_FunctionAddress;

	private static int SetReverbSettings_ParamsSize;

	private static bool SetReverbSettings_NewReverbSettings_IsValid;

	private static FFieldAddress SetReverbSettings_NewReverbSettings_PropertyAddress;

	private static int SetReverbSettings_NewReverbSettings_Offset;

	private static bool SetPriority_IsValid;

	private static IntPtr SetPriority_FunctionAddress;

	private static int SetPriority_ParamsSize;

	private static bool SetPriority_NewPriority_IsValid;

	private static FFieldAddress SetPriority_NewPriority_PropertyAddress;

	private static int SetPriority_NewPriority_Offset;

	private static bool SetInteriorSettings_IsValid;

	private static IntPtr SetInteriorSettings_FunctionAddress;

	private static int SetInteriorSettings_ParamsSize;

	private static bool SetInteriorSettings_NewInteriorSettings_IsValid;

	private static FFieldAddress SetInteriorSettings_NewInteriorSettings_PropertyAddress;

	private static int SetInteriorSettings_NewInteriorSettings_Offset;

	private static bool SetEnabled_IsValid;

	private static IntPtr SetEnabled_FunctionAddress;

	private static int SetEnabled_ParamsSize;

	private static bool SetEnabled_bNewEnabled_IsValid;

	private static FFieldAddress SetEnabled_bNewEnabled_PropertyAddress;

	private static int SetEnabled_bNewEnabled_Offset;

	[UProperty(Flags = (PropFlags)20266268116386325uL)]
	[UMetaPath("/Script/Engine.AudioVolume:Priority")]
	public float Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:Priority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:Priority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266271337611317uL)]
	[UMetaPath("/Script/Engine.AudioVolume:bEnabled")]
	public bool Enabled
	{
		get
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:bEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:bEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)18014467228958741uL)]
	[UMetaPath("/Script/Engine.AudioVolume:Settings")]
	public FReverbSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:Settings");
				return default(FReverbSettings);
			}
			return FReverbSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:Settings");
			}
			else
			{
				FReverbSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)18014467228958741uL)]
	[UMetaPath("/Script/Engine.AudioVolume:AmbientZoneSettings")]
	public FInteriorSettings AmbientZoneSettings
	{
		get
		{
			CheckDestroyed();
			if (!AmbientZoneSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:AmbientZoneSettings");
				return default(FInteriorSettings);
			}
			return FInteriorSettings.FromNative(IntPtr.Add(base.Address, AmbientZoneSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AmbientZoneSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:AmbientZoneSettings");
			}
			else
			{
				FInteriorSettings.ToNative(IntPtr.Add(base.Address, AmbientZoneSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)18014398509482517uL)]
	[UMetaPath("/Script/Engine.AudioVolume:SubmixSendSettings")]
	public TArrayReadOnly<FAudioVolumeSubmixSendSettings> SubmixSendSettings
	{
		get
		{
			CheckDestroyed();
			if (!SubmixSendSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:SubmixSendSettings");
				return null;
			}
			if (SubmixSendSettings_MarshalerCached == null)
			{
				SubmixSendSettings_MarshalerCached = new TArrayReadOnlyMarshaler<FAudioVolumeSubmixSendSettings>(1, SubmixSendSettings_PropertyAddress, CachedMarshalingDelegates<FAudioVolumeSubmixSendSettings, FAudioVolumeSubmixSendSettings>.FromNative, CachedMarshalingDelegates<FAudioVolumeSubmixSendSettings, FAudioVolumeSubmixSendSettings>.ToNative);
			}
			return SubmixSendSettings_MarshalerCached.FromNative(IntPtr.Add(base.Address, SubmixSendSettings_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)18014398509482517uL)]
	[UMetaPath("/Script/Engine.AudioVolume:SubmixOverrideSettings")]
	public TArrayReadOnly<FAudioVolumeSubmixOverrideSettings> SubmixOverrideSettings
	{
		get
		{
			CheckDestroyed();
			if (!SubmixOverrideSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioVolume:SubmixOverrideSettings");
				return null;
			}
			if (SubmixOverrideSettings_MarshalerCached == null)
			{
				SubmixOverrideSettings_MarshalerCached = new TArrayReadOnlyMarshaler<FAudioVolumeSubmixOverrideSettings>(1, SubmixOverrideSettings_PropertyAddress, CachedMarshalingDelegates<FAudioVolumeSubmixOverrideSettings, FAudioVolumeSubmixOverrideSettings>.FromNative, CachedMarshalingDelegates<FAudioVolumeSubmixOverrideSettings, FAudioVolumeSubmixOverrideSettings>.ToNative);
			}
			return SubmixOverrideSettings_MarshalerCached.FromNative(IntPtr.Add(base.Address, SubmixOverrideSettings_Offset));
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AudioVolume:SetSubmixSendSettings")]
	public unsafe void SetSubmixSendSettings(List<FAudioVolumeSubmixSendSettings> NewSubmixSendSettings)
	{
		CheckDestroyed();
		if (!SetSubmixSendSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioVolume:SetSubmixSendSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubmixSendSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubmixSendSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAudioVolumeSubmixSendSettings>(1, SetSubmixSendSettings_NewSubmixSendSettings_PropertyAddress, CachedMarshalingDelegates<FAudioVolumeSubmixSendSettings, FAudioVolumeSubmixSendSettings>.FromNative, CachedMarshalingDelegates<FAudioVolumeSubmixSendSettings, FAudioVolumeSubmixSendSettings>.ToNative).ToNative(IntPtr.Add(intPtr, SetSubmixSendSettings_NewSubmixSendSettings_Offset), NewSubmixSendSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSubmixSendSettings_FunctionAddress, intPtr, SetSubmixSendSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSubmixSendSettings_NewSubmixSendSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AudioVolume:SetSubmixOverrideSettings")]
	public unsafe void SetSubmixOverrideSettings(List<FAudioVolumeSubmixOverrideSettings> NewSubmixOverrideSettings)
	{
		CheckDestroyed();
		if (!SetSubmixOverrideSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioVolume:SetSubmixOverrideSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubmixOverrideSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubmixOverrideSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAudioVolumeSubmixOverrideSettings>(1, SetSubmixOverrideSettings_NewSubmixOverrideSettings_PropertyAddress, CachedMarshalingDelegates<FAudioVolumeSubmixOverrideSettings, FAudioVolumeSubmixOverrideSettings>.FromNative, CachedMarshalingDelegates<FAudioVolumeSubmixOverrideSettings, FAudioVolumeSubmixOverrideSettings>.ToNative).ToNative(IntPtr.Add(intPtr, SetSubmixOverrideSettings_NewSubmixOverrideSettings_Offset), NewSubmixOverrideSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSubmixOverrideSettings_FunctionAddress, intPtr, SetSubmixOverrideSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSubmixOverrideSettings_NewSubmixOverrideSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AudioVolume:SetReverbSettings")]
	public unsafe void SetReverbSettings(FReverbSettings NewReverbSettings)
	{
		CheckDestroyed();
		if (!SetReverbSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioVolume:SetReverbSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReverbSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReverbSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetReverbSettings_NewReverbSettings_PropertyAddress.Address, intPtr);
		FReverbSettings.ToNative(IntPtr.Add(intPtr, SetReverbSettings_NewReverbSettings_Offset), 0, SetReverbSettings_NewReverbSettings_PropertyAddress.Address, NewReverbSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReverbSettings_FunctionAddress, intPtr, SetReverbSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioVolume:SetPriority")]
	public unsafe void SetPriority(float NewPriority)
	{
		CheckDestroyed();
		if (!SetPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioVolume:SetPriority");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPriority_NewPriority_Offset), 0, SetPriority_NewPriority_PropertyAddress.Address, NewPriority);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPriority_FunctionAddress, intPtr, SetPriority_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AudioVolume:SetInteriorSettings")]
	public unsafe void SetInteriorSettings(FInteriorSettings NewInteriorSettings)
	{
		CheckDestroyed();
		if (!SetInteriorSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioVolume:SetInteriorSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInteriorSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInteriorSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetInteriorSettings_NewInteriorSettings_PropertyAddress.Address, intPtr);
		FInteriorSettings.ToNative(IntPtr.Add(intPtr, SetInteriorSettings_NewInteriorSettings_Offset), 0, SetInteriorSettings_NewInteriorSettings_PropertyAddress.Address, NewInteriorSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInteriorSettings_FunctionAddress, intPtr, SetInteriorSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioVolume:SetEnabled")]
	public unsafe void SetEnabled(bool bNewEnabled)
	{
		CheckDestroyed();
		if (!SetEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioVolume:SetEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnabled_bNewEnabled_Offset), 0, SetEnabled_bNewEnabled_PropertyAddress.Address, bNewEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnabled_FunctionAddress, intPtr, SetEnabled_ParamsSize);
	}

	static AAudioVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAudioVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAudioVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.AudioVolume");
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		AmbientZoneSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AmbientZoneSettings");
		AmbientZoneSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AmbientZoneSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SubmixSendSettings_PropertyAddress, intPtr, "SubmixSendSettings");
		SubmixSendSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixSendSettings");
		SubmixSendSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixSendSettings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SubmixOverrideSettings_PropertyAddress, intPtr, "SubmixOverrideSettings");
		SubmixOverrideSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixOverrideSettings");
		SubmixOverrideSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixOverrideSettings", Classes.FArrayProperty);
		SetSubmixSendSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSubmixSendSettings");
		SetSubmixSendSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubmixSendSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixSendSettings_NewSubmixSendSettings_PropertyAddress, SetSubmixSendSettings_FunctionAddress, "NewSubmixSendSettings");
		SetSubmixSendSettings_NewSubmixSendSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixSendSettings_FunctionAddress, "NewSubmixSendSettings");
		SetSubmixSendSettings_NewSubmixSendSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixSendSettings_FunctionAddress, "NewSubmixSendSettings", Classes.FArrayProperty);
		SetSubmixSendSettings_IsValid = SetSubmixSendSettings_FunctionAddress != IntPtr.Zero && SetSubmixSendSettings_NewSubmixSendSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioVolume:SetSubmixSendSettings", SetSubmixSendSettings_IsValid);
		SetSubmixOverrideSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSubmixOverrideSettings");
		SetSubmixOverrideSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubmixOverrideSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixOverrideSettings_NewSubmixOverrideSettings_PropertyAddress, SetSubmixOverrideSettings_FunctionAddress, "NewSubmixOverrideSettings");
		SetSubmixOverrideSettings_NewSubmixOverrideSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixOverrideSettings_FunctionAddress, "NewSubmixOverrideSettings");
		SetSubmixOverrideSettings_NewSubmixOverrideSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixOverrideSettings_FunctionAddress, "NewSubmixOverrideSettings", Classes.FArrayProperty);
		SetSubmixOverrideSettings_IsValid = SetSubmixOverrideSettings_FunctionAddress != IntPtr.Zero && SetSubmixOverrideSettings_NewSubmixOverrideSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioVolume:SetSubmixOverrideSettings", SetSubmixOverrideSettings_IsValid);
		SetReverbSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetReverbSettings");
		SetReverbSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReverbSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReverbSettings_NewReverbSettings_PropertyAddress, SetReverbSettings_FunctionAddress, "NewReverbSettings");
		SetReverbSettings_NewReverbSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetReverbSettings_FunctionAddress, "NewReverbSettings");
		SetReverbSettings_NewReverbSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReverbSettings_FunctionAddress, "NewReverbSettings", Classes.FStructProperty);
		SetReverbSettings_IsValid = SetReverbSettings_FunctionAddress != IntPtr.Zero && SetReverbSettings_NewReverbSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioVolume:SetReverbSettings", SetReverbSettings_IsValid);
		SetPriority_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPriority");
		SetPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPriority_NewPriority_PropertyAddress, SetPriority_FunctionAddress, "NewPriority");
		SetPriority_NewPriority_Offset = NativeReflectionCached.GetPropertyOffset(SetPriority_FunctionAddress, "NewPriority");
		SetPriority_NewPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPriority_FunctionAddress, "NewPriority", Classes.FFloatProperty);
		SetPriority_IsValid = SetPriority_FunctionAddress != IntPtr.Zero && SetPriority_NewPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioVolume:SetPriority", SetPriority_IsValid);
		SetInteriorSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInteriorSettings");
		SetInteriorSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInteriorSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInteriorSettings_NewInteriorSettings_PropertyAddress, SetInteriorSettings_FunctionAddress, "NewInteriorSettings");
		SetInteriorSettings_NewInteriorSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetInteriorSettings_FunctionAddress, "NewInteriorSettings");
		SetInteriorSettings_NewInteriorSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteriorSettings_FunctionAddress, "NewInteriorSettings", Classes.FStructProperty);
		SetInteriorSettings_IsValid = SetInteriorSettings_FunctionAddress != IntPtr.Zero && SetInteriorSettings_NewInteriorSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioVolume:SetInteriorSettings", SetInteriorSettings_IsValid);
		SetEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnabled");
		SetEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnabled_bNewEnabled_PropertyAddress, SetEnabled_FunctionAddress, "bNewEnabled");
		SetEnabled_bNewEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEnabled_FunctionAddress, "bNewEnabled");
		SetEnabled_bNewEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnabled_FunctionAddress, "bNewEnabled", Classes.FBoolProperty);
		SetEnabled_IsValid = SetEnabled_FunctionAddress != IntPtr.Zero && SetEnabled_bNewEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioVolume:SetEnabled", SetEnabled_IsValid);
	}
}
