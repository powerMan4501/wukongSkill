using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.EnvironmentSurfaceEffectMgr", "b1", UnrealModuleType.Game)]
public class AEnvironmentSurfaceEffectMgr : AActor
{
	private static bool DefaultEnvironmentSurfaceEffectID_IsValid;

	private static int DefaultEnvironmentSurfaceEffectID_Offset;

	private static bool WeatherType_IsValid;

	private static FFieldAddress WeatherType_PropertyAddress;

	private static int WeatherType_Offset;

	private static bool UnregisterVolume_IsValid;

	private static IntPtr UnregisterVolume_FunctionAddress;

	private static int UnregisterVolume_ParamsSize;

	private static bool UnregisterVolume_InVolume_IsValid;

	private static FFieldAddress UnregisterVolume_InVolume_PropertyAddress;

	private static int UnregisterVolume_InVolume_Offset;

	private static bool UnregisterVolume_IsDisableVolume_IsValid;

	private static FFieldAddress UnregisterVolume_IsDisableVolume_PropertyAddress;

	private static int UnregisterVolume_IsDisableVolume_Offset;

	private static bool RegisterVolume_IsValid;

	private static IntPtr RegisterVolume_FunctionAddress;

	private static int RegisterVolume_ParamsSize;

	private static bool RegisterVolume_InVolume_IsValid;

	private static FFieldAddress RegisterVolume_InVolume_PropertyAddress;

	private static int RegisterVolume_InVolume_Offset;

	private static bool GetEnvironmentSurfaceVolumeByLocation_IsValid;

	private static IntPtr GetEnvironmentSurfaceVolumeByLocation_FunctionAddress;

	private static int GetEnvironmentSurfaceVolumeByLocation_ParamsSize;

	private static bool GetEnvironmentSurfaceVolumeByLocation_Location_IsValid;

	private static FFieldAddress GetEnvironmentSurfaceVolumeByLocation_Location_PropertyAddress;

	private static int GetEnvironmentSurfaceVolumeByLocation_Location_Offset;

	private static bool GetEnvironmentSurfaceVolumeByLocation_ReturnValue_IsValid;

	private static FFieldAddress GetEnvironmentSurfaceVolumeByLocation_ReturnValue_PropertyAddress;

	private static int GetEnvironmentSurfaceVolumeByLocation_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.EnvironmentSurfaceEffectMgr:DefaultEnvironmentSurfaceEffectID")]
	public int DefaultEnvironmentSurfaceEffectID
	{
		get
		{
			CheckDestroyed();
			if (!DefaultEnvironmentSurfaceEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.EnvironmentSurfaceEffectMgr:DefaultEnvironmentSurfaceEffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefaultEnvironmentSurfaceEffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultEnvironmentSurfaceEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.EnvironmentSurfaceEffectMgr:DefaultEnvironmentSurfaceEffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefaultEnvironmentSurfaceEffectID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.EnvironmentSurfaceEffectMgr:WeatherType")]
	public EWeatherType WeatherType
	{
		get
		{
			CheckDestroyed();
			if (!WeatherType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.EnvironmentSurfaceEffectMgr:WeatherType");
				return EWeatherType.None;
			}
			return EnumMarshaler<EWeatherType>.FromNative(IntPtr.Add(base.Address, WeatherType_Offset), 0, WeatherType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WeatherType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.EnvironmentSurfaceEffectMgr:WeatherType");
			}
			else
			{
				EnumMarshaler<EWeatherType>.ToNative(IntPtr.Add(base.Address, WeatherType_Offset), 0, WeatherType_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.EnvironmentSurfaceEffectMgr:UnregisterVolume")]
	public unsafe void UnregisterVolume(TSoftObject<ABGWEnvironmentSurfaceVolume> InVolume, bool IsDisableVolume = true)
	{
		CheckDestroyed();
		if (!UnregisterVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.EnvironmentSurfaceEffectMgr:UnregisterVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(UnregisterVolume_InVolume_PropertyAddress.Address, intPtr);
		TSoftObjectMarshaler<ABGWEnvironmentSurfaceVolume>.ToNative(IntPtr.Add(intPtr, UnregisterVolume_InVolume_Offset), 0, UnregisterVolume_InVolume_PropertyAddress.Address, InVolume);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UnregisterVolume_IsDisableVolume_Offset), 0, UnregisterVolume_IsDisableVolume_PropertyAddress.Address, IsDisableVolume);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnregisterVolume_FunctionAddress, intPtr, UnregisterVolume_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnregisterVolume_InVolume_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.EnvironmentSurfaceEffectMgr:RegisterVolume")]
	public unsafe void RegisterVolume(TSoftObject<ABGWEnvironmentSurfaceVolume> InVolume)
	{
		CheckDestroyed();
		if (!RegisterVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.EnvironmentSurfaceEffectMgr:RegisterVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RegisterVolume_InVolume_PropertyAddress.Address, intPtr);
		TSoftObjectMarshaler<ABGWEnvironmentSurfaceVolume>.ToNative(IntPtr.Add(intPtr, RegisterVolume_InVolume_Offset), 0, RegisterVolume_InVolume_PropertyAddress.Address, InVolume);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterVolume_FunctionAddress, intPtr, RegisterVolume_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RegisterVolume_InVolume_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.EnvironmentSurfaceEffectMgr:GetEnvironmentSurfaceVolumeByLocation")]
	public unsafe ABGWEnvironmentSurfaceVolume GetEnvironmentSurfaceVolumeByLocation(FVector Location)
	{
		CheckDestroyed();
		if (!GetEnvironmentSurfaceVolumeByLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.EnvironmentSurfaceEffectMgr:GetEnvironmentSurfaceVolumeByLocation");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEnvironmentSurfaceVolumeByLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEnvironmentSurfaceVolumeByLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetEnvironmentSurfaceVolumeByLocation_Location_Offset), 0, GetEnvironmentSurfaceVolumeByLocation_Location_PropertyAddress.Address, Location);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEnvironmentSurfaceVolumeByLocation_FunctionAddress, intPtr, GetEnvironmentSurfaceVolumeByLocation_ParamsSize);
		return UObjectMarshaler<ABGWEnvironmentSurfaceVolume>.FromNative(IntPtr.Add(intPtr, GetEnvironmentSurfaceVolumeByLocation_ReturnValue_Offset), 0, GetEnvironmentSurfaceVolumeByLocation_ReturnValue_PropertyAddress.Address);
	}

	static AEnvironmentSurfaceEffectMgr()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AEnvironmentSurfaceEffectMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AEnvironmentSurfaceEffectMgr));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.EnvironmentSurfaceEffectMgr");
		DefaultEnvironmentSurfaceEffectID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultEnvironmentSurfaceEffectID");
		DefaultEnvironmentSurfaceEffectID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultEnvironmentSurfaceEffectID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref WeatherType_PropertyAddress, intPtr, "WeatherType");
		WeatherType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeatherType");
		WeatherType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeatherType", Classes.FEnumProperty);
		UnregisterVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnregisterVolume");
		UnregisterVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterVolume_InVolume_PropertyAddress, UnregisterVolume_FunctionAddress, "InVolume");
		UnregisterVolume_InVolume_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterVolume_FunctionAddress, "InVolume");
		UnregisterVolume_InVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterVolume_FunctionAddress, "InVolume", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UnregisterVolume_IsDisableVolume_PropertyAddress, UnregisterVolume_FunctionAddress, "IsDisableVolume");
		UnregisterVolume_IsDisableVolume_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterVolume_FunctionAddress, "IsDisableVolume");
		UnregisterVolume_IsDisableVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterVolume_FunctionAddress, "IsDisableVolume", Classes.FBoolProperty);
		UnregisterVolume_IsValid = UnregisterVolume_FunctionAddress != IntPtr.Zero && UnregisterVolume_InVolume_IsValid && UnregisterVolume_IsDisableVolume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.EnvironmentSurfaceEffectMgr:UnregisterVolume", UnregisterVolume_IsValid);
		RegisterVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterVolume");
		RegisterVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterVolume_InVolume_PropertyAddress, RegisterVolume_FunctionAddress, "InVolume");
		RegisterVolume_InVolume_Offset = NativeReflectionCached.GetPropertyOffset(RegisterVolume_FunctionAddress, "InVolume");
		RegisterVolume_InVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterVolume_FunctionAddress, "InVolume", Classes.FSoftObjectProperty);
		RegisterVolume_IsValid = RegisterVolume_FunctionAddress != IntPtr.Zero && RegisterVolume_InVolume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.EnvironmentSurfaceEffectMgr:RegisterVolume", RegisterVolume_IsValid);
		GetEnvironmentSurfaceVolumeByLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetEnvironmentSurfaceVolumeByLocation");
		GetEnvironmentSurfaceVolumeByLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEnvironmentSurfaceVolumeByLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEnvironmentSurfaceVolumeByLocation_Location_PropertyAddress, GetEnvironmentSurfaceVolumeByLocation_FunctionAddress, "Location");
		GetEnvironmentSurfaceVolumeByLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(GetEnvironmentSurfaceVolumeByLocation_FunctionAddress, "Location");
		GetEnvironmentSurfaceVolumeByLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnvironmentSurfaceVolumeByLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEnvironmentSurfaceVolumeByLocation_ReturnValue_PropertyAddress, GetEnvironmentSurfaceVolumeByLocation_FunctionAddress, "ReturnValue");
		GetEnvironmentSurfaceVolumeByLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEnvironmentSurfaceVolumeByLocation_FunctionAddress, "ReturnValue");
		GetEnvironmentSurfaceVolumeByLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnvironmentSurfaceVolumeByLocation_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEnvironmentSurfaceVolumeByLocation_IsValid = GetEnvironmentSurfaceVolumeByLocation_FunctionAddress != IntPtr.Zero && GetEnvironmentSurfaceVolumeByLocation_Location_IsValid && GetEnvironmentSurfaceVolumeByLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.EnvironmentSurfaceEffectMgr:GetEnvironmentSurfaceVolumeByLocation", GetEnvironmentSurfaceVolumeByLocation_IsValid);
	}
}
