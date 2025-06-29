using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OpacityMicroMap;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/OpacityMicroMap.OMMBlueprintLibrary", "OpacityMicroMap", UnrealModuleType.EnginePlugin)]
public class UOMMBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RemoveOMMUserData_IsValid;

	private static IntPtr RemoveOMMUserData_FunctionAddress;

	private static int RemoveOMMUserData_ParamsSize;

	private static bool RemoveOMMUserData_StaticMesh_IsValid;

	private static FFieldAddress RemoveOMMUserData_StaticMesh_PropertyAddress;

	private static int RemoveOMMUserData_StaticMesh_Offset;

	private static bool IsThisDeviceSupportOMM_IsValid;

	private static IntPtr IsThisDeviceSupportOMM_FunctionAddress;

	private static int IsThisDeviceSupportOMM_ParamsSize;

	private static bool IsThisDeviceSupportOMM_WorldContextObject_IsValid;

	private static FFieldAddress IsThisDeviceSupportOMM_WorldContextObject_PropertyAddress;

	private static int IsThisDeviceSupportOMM_WorldContextObject_Offset;

	private static bool IsThisDeviceSupportOMM_ReturnValue_IsValid;

	private static FFieldAddress IsThisDeviceSupportOMM_ReturnValue_PropertyAddress;

	private static int IsThisDeviceSupportOMM_ReturnValue_Offset;

	private static bool CalculateCurrentWorldOMMTotalDataSize_IsValid;

	private static IntPtr CalculateCurrentWorldOMMTotalDataSize_FunctionAddress;

	private static int CalculateCurrentWorldOMMTotalDataSize_ParamsSize;

	private static bool CalculateCurrentWorldOMMTotalDataSize_WorldContextObject_IsValid;

	private static FFieldAddress CalculateCurrentWorldOMMTotalDataSize_WorldContextObject_PropertyAddress;

	private static int CalculateCurrentWorldOMMTotalDataSize_WorldContextObject_Offset;

	private static bool CalculateCurrentWorldOMMTotalDataSize_ReturnValue_IsValid;

	private static FFieldAddress CalculateCurrentWorldOMMTotalDataSize_ReturnValue_PropertyAddress;

	private static int CalculateCurrentWorldOMMTotalDataSize_ReturnValue_Offset;

	private static bool BuildAllStaticMesh_IsValid;

	private static IntPtr BuildAllStaticMesh_FunctionAddress;

	private static int BuildAllStaticMesh_ParamsSize;

	private static bool BuildAllStaticMesh_WorldContextObject_IsValid;

	private static FFieldAddress BuildAllStaticMesh_WorldContextObject_PropertyAddress;

	private static int BuildAllStaticMesh_WorldContextObject_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OpacityMicroMap.OMMBlueprintLibrary:RemoveOMMUserData")]
	public unsafe static void RemoveOMMUserData(UStaticMesh StaticMesh)
	{
		if (!RemoveOMMUserData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpacityMicroMap.OMMBlueprintLibrary:RemoveOMMUserData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveOMMUserData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveOMMUserData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, RemoveOMMUserData_StaticMesh_Offset), 0, RemoveOMMUserData_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveOMMUserData_FunctionAddress, intPtr, RemoveOMMUserData_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OpacityMicroMap.OMMBlueprintLibrary:IsThisDeviceSupportOMM")]
	public unsafe static bool IsThisDeviceSupportOMM(UObject WorldContextObject)
	{
		if (!IsThisDeviceSupportOMM_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpacityMicroMap.OMMBlueprintLibrary:IsThisDeviceSupportOMM");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsThisDeviceSupportOMM_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsThisDeviceSupportOMM_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsThisDeviceSupportOMM_WorldContextObject_Offset), 0, IsThisDeviceSupportOMM_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsThisDeviceSupportOMM_FunctionAddress, intPtr, IsThisDeviceSupportOMM_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsThisDeviceSupportOMM_ReturnValue_Offset), 0, IsThisDeviceSupportOMM_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OpacityMicroMap.OMMBlueprintLibrary:CalculateCurrentWorldOMMTotalDataSize")]
	public unsafe static float CalculateCurrentWorldOMMTotalDataSize(UObject WorldContextObject)
	{
		if (!CalculateCurrentWorldOMMTotalDataSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpacityMicroMap.OMMBlueprintLibrary:CalculateCurrentWorldOMMTotalDataSize");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateCurrentWorldOMMTotalDataSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateCurrentWorldOMMTotalDataSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CalculateCurrentWorldOMMTotalDataSize_WorldContextObject_Offset), 0, CalculateCurrentWorldOMMTotalDataSize_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateCurrentWorldOMMTotalDataSize_FunctionAddress, intPtr, CalculateCurrentWorldOMMTotalDataSize_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalculateCurrentWorldOMMTotalDataSize_ReturnValue_Offset), 0, CalculateCurrentWorldOMMTotalDataSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OpacityMicroMap.OMMBlueprintLibrary:BuildAllStaticMesh")]
	public unsafe static void BuildAllStaticMesh(UObject WorldContextObject)
	{
		if (!BuildAllStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpacityMicroMap.OMMBlueprintLibrary:BuildAllStaticMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildAllStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildAllStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BuildAllStaticMesh_WorldContextObject_Offset), 0, BuildAllStaticMesh_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildAllStaticMesh_FunctionAddress, intPtr, BuildAllStaticMesh_ParamsSize);
	}

	static UOMMBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOMMBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOMMBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/OpacityMicroMap.OMMBlueprintLibrary");
		RemoveOMMUserData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveOMMUserData");
		RemoveOMMUserData_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveOMMUserData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveOMMUserData_StaticMesh_PropertyAddress, RemoveOMMUserData_FunctionAddress, "StaticMesh");
		RemoveOMMUserData_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(RemoveOMMUserData_FunctionAddress, "StaticMesh");
		RemoveOMMUserData_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveOMMUserData_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		RemoveOMMUserData_IsValid = RemoveOMMUserData_FunctionAddress != IntPtr.Zero && RemoveOMMUserData_StaticMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpacityMicroMap.OMMBlueprintLibrary:RemoveOMMUserData", RemoveOMMUserData_IsValid);
		IsThisDeviceSupportOMM_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsThisDeviceSupportOMM");
		IsThisDeviceSupportOMM_ParamsSize = NativeReflection.GetFunctionParamsSize(IsThisDeviceSupportOMM_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsThisDeviceSupportOMM_WorldContextObject_PropertyAddress, IsThisDeviceSupportOMM_FunctionAddress, "WorldContextObject");
		IsThisDeviceSupportOMM_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(IsThisDeviceSupportOMM_FunctionAddress, "WorldContextObject");
		IsThisDeviceSupportOMM_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(IsThisDeviceSupportOMM_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsThisDeviceSupportOMM_ReturnValue_PropertyAddress, IsThisDeviceSupportOMM_FunctionAddress, "ReturnValue");
		IsThisDeviceSupportOMM_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsThisDeviceSupportOMM_FunctionAddress, "ReturnValue");
		IsThisDeviceSupportOMM_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsThisDeviceSupportOMM_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsThisDeviceSupportOMM_IsValid = IsThisDeviceSupportOMM_FunctionAddress != IntPtr.Zero && IsThisDeviceSupportOMM_WorldContextObject_IsValid && IsThisDeviceSupportOMM_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpacityMicroMap.OMMBlueprintLibrary:IsThisDeviceSupportOMM", IsThisDeviceSupportOMM_IsValid);
		CalculateCurrentWorldOMMTotalDataSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateCurrentWorldOMMTotalDataSize");
		CalculateCurrentWorldOMMTotalDataSize_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateCurrentWorldOMMTotalDataSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateCurrentWorldOMMTotalDataSize_WorldContextObject_PropertyAddress, CalculateCurrentWorldOMMTotalDataSize_FunctionAddress, "WorldContextObject");
		CalculateCurrentWorldOMMTotalDataSize_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CalculateCurrentWorldOMMTotalDataSize_FunctionAddress, "WorldContextObject");
		CalculateCurrentWorldOMMTotalDataSize_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateCurrentWorldOMMTotalDataSize_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateCurrentWorldOMMTotalDataSize_ReturnValue_PropertyAddress, CalculateCurrentWorldOMMTotalDataSize_FunctionAddress, "ReturnValue");
		CalculateCurrentWorldOMMTotalDataSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalculateCurrentWorldOMMTotalDataSize_FunctionAddress, "ReturnValue");
		CalculateCurrentWorldOMMTotalDataSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateCurrentWorldOMMTotalDataSize_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalculateCurrentWorldOMMTotalDataSize_IsValid = CalculateCurrentWorldOMMTotalDataSize_FunctionAddress != IntPtr.Zero && CalculateCurrentWorldOMMTotalDataSize_WorldContextObject_IsValid && CalculateCurrentWorldOMMTotalDataSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpacityMicroMap.OMMBlueprintLibrary:CalculateCurrentWorldOMMTotalDataSize", CalculateCurrentWorldOMMTotalDataSize_IsValid);
		BuildAllStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildAllStaticMesh");
		BuildAllStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildAllStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildAllStaticMesh_WorldContextObject_PropertyAddress, BuildAllStaticMesh_FunctionAddress, "WorldContextObject");
		BuildAllStaticMesh_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BuildAllStaticMesh_FunctionAddress, "WorldContextObject");
		BuildAllStaticMesh_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildAllStaticMesh_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		BuildAllStaticMesh_IsValid = BuildAllStaticMesh_FunctionAddress != IntPtr.Zero && BuildAllStaticMesh_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpacityMicroMap.OMMBlueprintLibrary:BuildAllStaticMesh", BuildAllStaticMesh_IsValid);
	}
}
