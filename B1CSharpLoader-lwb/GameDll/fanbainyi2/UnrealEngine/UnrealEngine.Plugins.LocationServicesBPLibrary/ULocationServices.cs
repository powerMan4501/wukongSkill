using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LocationServicesBPLibrary;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/LocationServicesBPLibrary.LocationServices", "LocationServicesBPLibrary", UnrealModuleType.EnginePlugin)]
public class ULocationServices : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StopLocationServices_IsValid;

	private static IntPtr StopLocationServices_FunctionAddress;

	private static int StopLocationServices_ParamsSize;

	private static bool StopLocationServices_ReturnValue_IsValid;

	private static FFieldAddress StopLocationServices_ReturnValue_PropertyAddress;

	private static int StopLocationServices_ReturnValue_Offset;

	private static bool StartLocationServices_IsValid;

	private static IntPtr StartLocationServices_FunctionAddress;

	private static int StartLocationServices_ParamsSize;

	private static bool StartLocationServices_ReturnValue_IsValid;

	private static FFieldAddress StartLocationServices_ReturnValue_PropertyAddress;

	private static int StartLocationServices_ReturnValue_Offset;

	private static bool IsLocationAccuracyAvailable_IsValid;

	private static IntPtr IsLocationAccuracyAvailable_FunctionAddress;

	private static int IsLocationAccuracyAvailable_ParamsSize;

	private static bool IsLocationAccuracyAvailable_Accuracy_IsValid;

	private static FFieldAddress IsLocationAccuracyAvailable_Accuracy_PropertyAddress;

	private static int IsLocationAccuracyAvailable_Accuracy_Offset;

	private static bool IsLocationAccuracyAvailable_ReturnValue_IsValid;

	private static FFieldAddress IsLocationAccuracyAvailable_ReturnValue_PropertyAddress;

	private static int IsLocationAccuracyAvailable_ReturnValue_Offset;

	private static bool InitLocationServices_IsValid;

	private static IntPtr InitLocationServices_FunctionAddress;

	private static int InitLocationServices_ParamsSize;

	private static bool InitLocationServices_Accuracy_IsValid;

	private static FFieldAddress InitLocationServices_Accuracy_PropertyAddress;

	private static int InitLocationServices_Accuracy_Offset;

	private static bool InitLocationServices_UpdateFrequency_IsValid;

	private static FFieldAddress InitLocationServices_UpdateFrequency_PropertyAddress;

	private static int InitLocationServices_UpdateFrequency_Offset;

	private static bool InitLocationServices_MinDistanceFilter_IsValid;

	private static FFieldAddress InitLocationServices_MinDistanceFilter_PropertyAddress;

	private static int InitLocationServices_MinDistanceFilter_Offset;

	private static bool InitLocationServices_ReturnValue_IsValid;

	private static FFieldAddress InitLocationServices_ReturnValue_PropertyAddress;

	private static int InitLocationServices_ReturnValue_Offset;

	private static bool GetLocationServicesImpl_IsValid;

	private static IntPtr GetLocationServicesImpl_FunctionAddress;

	private static int GetLocationServicesImpl_ParamsSize;

	private static bool GetLocationServicesImpl_ReturnValue_IsValid;

	private static FFieldAddress GetLocationServicesImpl_ReturnValue_PropertyAddress;

	private static int GetLocationServicesImpl_ReturnValue_Offset;

	private static bool GetLastKnownLocation_IsValid;

	private static IntPtr GetLastKnownLocation_FunctionAddress;

	private static int GetLastKnownLocation_ParamsSize;

	private static bool GetLastKnownLocation_ReturnValue_IsValid;

	private static FFieldAddress GetLastKnownLocation_ReturnValue_PropertyAddress;

	private static int GetLastKnownLocation_ReturnValue_Offset;

	private static bool AreLocationServicesEnabled_IsValid;

	private static IntPtr AreLocationServicesEnabled_FunctionAddress;

	private static int AreLocationServicesEnabled_ParamsSize;

	private static bool AreLocationServicesEnabled_ReturnValue_IsValid;

	private static FFieldAddress AreLocationServicesEnabled_ReturnValue_PropertyAddress;

	private static int AreLocationServicesEnabled_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServices:StopLocationServices")]
	public unsafe static bool StopLocationServices()
	{
		if (!StopLocationServices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LocationServicesBPLibrary.LocationServices:StopLocationServices");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopLocationServices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopLocationServices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopLocationServices_FunctionAddress, intPtr, StopLocationServices_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StopLocationServices_ReturnValue_Offset), 0, StopLocationServices_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServices:StartLocationServices")]
	public unsafe static bool StartLocationServices()
	{
		if (!StartLocationServices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LocationServicesBPLibrary.LocationServices:StartLocationServices");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartLocationServices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartLocationServices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartLocationServices_FunctionAddress, intPtr, StartLocationServices_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StartLocationServices_ReturnValue_Offset), 0, StartLocationServices_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServices:IsLocationAccuracyAvailable")]
	public unsafe static bool IsLocationAccuracyAvailable(ELocationAccuracy Accuracy)
	{
		if (!IsLocationAccuracyAvailable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LocationServicesBPLibrary.LocationServices:IsLocationAccuracyAvailable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocationAccuracyAvailable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocationAccuracyAvailable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELocationAccuracy>.ToNative(IntPtr.Add(intPtr, IsLocationAccuracyAvailable_Accuracy_Offset), 0, IsLocationAccuracyAvailable_Accuracy_PropertyAddress.Address, Accuracy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsLocationAccuracyAvailable_FunctionAddress, intPtr, IsLocationAccuracyAvailable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocationAccuracyAvailable_ReturnValue_Offset), 0, IsLocationAccuracyAvailable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServices:InitLocationServices")]
	public unsafe static bool InitLocationServices(ELocationAccuracy Accuracy, float UpdateFrequency, float MinDistanceFilter)
	{
		if (!InitLocationServices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LocationServicesBPLibrary.LocationServices:InitLocationServices");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitLocationServices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitLocationServices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELocationAccuracy>.ToNative(IntPtr.Add(intPtr, InitLocationServices_Accuracy_Offset), 0, InitLocationServices_Accuracy_PropertyAddress.Address, Accuracy);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitLocationServices_UpdateFrequency_Offset), 0, InitLocationServices_UpdateFrequency_PropertyAddress.Address, UpdateFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitLocationServices_MinDistanceFilter_Offset), 0, InitLocationServices_MinDistanceFilter_PropertyAddress.Address, MinDistanceFilter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InitLocationServices_FunctionAddress, intPtr, InitLocationServices_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InitLocationServices_ReturnValue_Offset), 0, InitLocationServices_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServices:GetLocationServicesImpl")]
	public unsafe static ULocationServicesImpl GetLocationServicesImpl()
	{
		if (!GetLocationServicesImpl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LocationServicesBPLibrary.LocationServices:GetLocationServicesImpl");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationServicesImpl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationServicesImpl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocationServicesImpl_FunctionAddress, intPtr, GetLocationServicesImpl_ParamsSize);
		return UObjectMarshaler<ULocationServicesImpl>.FromNative(IntPtr.Add(intPtr, GetLocationServicesImpl_ReturnValue_Offset), 0, GetLocationServicesImpl_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServices:GetLastKnownLocation")]
	public unsafe static FLocationServicesData GetLastKnownLocation()
	{
		if (!GetLastKnownLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LocationServicesBPLibrary.LocationServices:GetLastKnownLocation");
			return default(FLocationServicesData);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastKnownLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastKnownLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLastKnownLocation_FunctionAddress, intPtr, GetLastKnownLocation_ParamsSize);
		return FLocationServicesData.FromNative(IntPtr.Add(intPtr, GetLastKnownLocation_ReturnValue_Offset), 0, GetLastKnownLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServices:AreLocationServicesEnabled")]
	public unsafe static bool AreLocationServicesEnabled()
	{
		if (!AreLocationServicesEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LocationServicesBPLibrary.LocationServices:AreLocationServicesEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AreLocationServicesEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AreLocationServicesEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AreLocationServicesEnabled_FunctionAddress, intPtr, AreLocationServicesEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AreLocationServicesEnabled_ReturnValue_Offset), 0, AreLocationServicesEnabled_ReturnValue_PropertyAddress.Address);
	}

	static ULocationServices()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULocationServices)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULocationServices));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/LocationServicesBPLibrary.LocationServices");
		StopLocationServices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopLocationServices");
		StopLocationServices_ParamsSize = NativeReflection.GetFunctionParamsSize(StopLocationServices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopLocationServices_ReturnValue_PropertyAddress, StopLocationServices_FunctionAddress, "ReturnValue");
		StopLocationServices_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StopLocationServices_FunctionAddress, "ReturnValue");
		StopLocationServices_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StopLocationServices_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StopLocationServices_IsValid = StopLocationServices_FunctionAddress != IntPtr.Zero && StopLocationServices_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LocationServicesBPLibrary.LocationServices:StopLocationServices", StopLocationServices_IsValid);
		StartLocationServices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartLocationServices");
		StartLocationServices_ParamsSize = NativeReflection.GetFunctionParamsSize(StartLocationServices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartLocationServices_ReturnValue_PropertyAddress, StartLocationServices_FunctionAddress, "ReturnValue");
		StartLocationServices_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartLocationServices_FunctionAddress, "ReturnValue");
		StartLocationServices_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartLocationServices_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StartLocationServices_IsValid = StartLocationServices_FunctionAddress != IntPtr.Zero && StartLocationServices_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LocationServicesBPLibrary.LocationServices:StartLocationServices", StartLocationServices_IsValid);
		IsLocationAccuracyAvailable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsLocationAccuracyAvailable");
		IsLocationAccuracyAvailable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocationAccuracyAvailable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocationAccuracyAvailable_Accuracy_PropertyAddress, IsLocationAccuracyAvailable_FunctionAddress, "Accuracy");
		IsLocationAccuracyAvailable_Accuracy_Offset = NativeReflectionCached.GetPropertyOffset(IsLocationAccuracyAvailable_FunctionAddress, "Accuracy");
		IsLocationAccuracyAvailable_Accuracy_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocationAccuracyAvailable_FunctionAddress, "Accuracy", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLocationAccuracyAvailable_ReturnValue_PropertyAddress, IsLocationAccuracyAvailable_FunctionAddress, "ReturnValue");
		IsLocationAccuracyAvailable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocationAccuracyAvailable_FunctionAddress, "ReturnValue");
		IsLocationAccuracyAvailable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocationAccuracyAvailable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocationAccuracyAvailable_IsValid = IsLocationAccuracyAvailable_FunctionAddress != IntPtr.Zero && IsLocationAccuracyAvailable_Accuracy_IsValid && IsLocationAccuracyAvailable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LocationServicesBPLibrary.LocationServices:IsLocationAccuracyAvailable", IsLocationAccuracyAvailable_IsValid);
		InitLocationServices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InitLocationServices");
		InitLocationServices_ParamsSize = NativeReflection.GetFunctionParamsSize(InitLocationServices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitLocationServices_Accuracy_PropertyAddress, InitLocationServices_FunctionAddress, "Accuracy");
		InitLocationServices_Accuracy_Offset = NativeReflectionCached.GetPropertyOffset(InitLocationServices_FunctionAddress, "Accuracy");
		InitLocationServices_Accuracy_IsValid = NativeReflectionCached.ValidatePropertyClass(InitLocationServices_FunctionAddress, "Accuracy", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InitLocationServices_UpdateFrequency_PropertyAddress, InitLocationServices_FunctionAddress, "UpdateFrequency");
		InitLocationServices_UpdateFrequency_Offset = NativeReflectionCached.GetPropertyOffset(InitLocationServices_FunctionAddress, "UpdateFrequency");
		InitLocationServices_UpdateFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(InitLocationServices_FunctionAddress, "UpdateFrequency", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitLocationServices_MinDistanceFilter_PropertyAddress, InitLocationServices_FunctionAddress, "MinDistanceFilter");
		InitLocationServices_MinDistanceFilter_Offset = NativeReflectionCached.GetPropertyOffset(InitLocationServices_FunctionAddress, "MinDistanceFilter");
		InitLocationServices_MinDistanceFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(InitLocationServices_FunctionAddress, "MinDistanceFilter", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitLocationServices_ReturnValue_PropertyAddress, InitLocationServices_FunctionAddress, "ReturnValue");
		InitLocationServices_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InitLocationServices_FunctionAddress, "ReturnValue");
		InitLocationServices_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InitLocationServices_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InitLocationServices_IsValid = InitLocationServices_FunctionAddress != IntPtr.Zero && InitLocationServices_Accuracy_IsValid && InitLocationServices_UpdateFrequency_IsValid && InitLocationServices_MinDistanceFilter_IsValid && InitLocationServices_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LocationServicesBPLibrary.LocationServices:InitLocationServices", InitLocationServices_IsValid);
		GetLocationServicesImpl_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocationServicesImpl");
		GetLocationServicesImpl_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationServicesImpl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationServicesImpl_ReturnValue_PropertyAddress, GetLocationServicesImpl_FunctionAddress, "ReturnValue");
		GetLocationServicesImpl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationServicesImpl_FunctionAddress, "ReturnValue");
		GetLocationServicesImpl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationServicesImpl_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLocationServicesImpl_IsValid = GetLocationServicesImpl_FunctionAddress != IntPtr.Zero && GetLocationServicesImpl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LocationServicesBPLibrary.LocationServices:GetLocationServicesImpl", GetLocationServicesImpl_IsValid);
		GetLastKnownLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLastKnownLocation");
		GetLastKnownLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastKnownLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastKnownLocation_ReturnValue_PropertyAddress, GetLastKnownLocation_FunctionAddress, "ReturnValue");
		GetLastKnownLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastKnownLocation_FunctionAddress, "ReturnValue");
		GetLastKnownLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastKnownLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastKnownLocation_IsValid = GetLastKnownLocation_FunctionAddress != IntPtr.Zero && GetLastKnownLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LocationServicesBPLibrary.LocationServices:GetLastKnownLocation", GetLastKnownLocation_IsValid);
		AreLocationServicesEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AreLocationServicesEnabled");
		AreLocationServicesEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(AreLocationServicesEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AreLocationServicesEnabled_ReturnValue_PropertyAddress, AreLocationServicesEnabled_FunctionAddress, "ReturnValue");
		AreLocationServicesEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AreLocationServicesEnabled_FunctionAddress, "ReturnValue");
		AreLocationServicesEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AreLocationServicesEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AreLocationServicesEnabled_IsValid = AreLocationServicesEnabled_FunctionAddress != IntPtr.Zero && AreLocationServicesEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LocationServicesBPLibrary.LocationServices:AreLocationServicesEnabled", AreLocationServicesEnabled_IsValid);
	}
}
