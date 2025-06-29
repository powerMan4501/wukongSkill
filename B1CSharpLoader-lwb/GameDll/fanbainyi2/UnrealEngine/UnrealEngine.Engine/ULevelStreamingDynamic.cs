using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818942112uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.LevelStreamingDynamic", "Engine", UnrealModuleType.Engine)]
public class ULevelStreamingDynamic : ULevelStreaming
{
	private static IntPtr classAddress;

	private static bool LoadLevelInstanceBySoftObjectPtr_IsValid;

	private static IntPtr LoadLevelInstanceBySoftObjectPtr_FunctionAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_ParamsSize;

	private static bool LoadLevelInstanceBySoftObjectPtr_WorldContextObject_IsValid;

	private static FFieldAddress LoadLevelInstanceBySoftObjectPtr_WorldContextObject_PropertyAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_WorldContextObject_Offset;

	private static bool LoadLevelInstanceBySoftObjectPtr_Level_IsValid;

	private static FFieldAddress LoadLevelInstanceBySoftObjectPtr_Level_PropertyAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_Level_Offset;

	private static bool LoadLevelInstanceBySoftObjectPtr_Location_IsValid;

	private static FFieldAddress LoadLevelInstanceBySoftObjectPtr_Location_PropertyAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_Location_Offset;

	private static bool LoadLevelInstanceBySoftObjectPtr_Rotation_IsValid;

	private static FFieldAddress LoadLevelInstanceBySoftObjectPtr_Rotation_PropertyAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_Rotation_Offset;

	private static bool LoadLevelInstanceBySoftObjectPtr_bOutSuccess_IsValid;

	private static FFieldAddress LoadLevelInstanceBySoftObjectPtr_bOutSuccess_PropertyAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_bOutSuccess_Offset;

	private static bool LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_IsValid;

	private static FFieldAddress LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_PropertyAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_Offset;

	private static bool LoadLevelInstanceBySoftObjectPtr_OptionalLevelStreamingClass_IsValid;

	private static FFieldAddress LoadLevelInstanceBySoftObjectPtr_OptionalLevelStreamingClass_PropertyAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_OptionalLevelStreamingClass_Offset;

	private static bool LoadLevelInstanceBySoftObjectPtr_bLoadAsTempPackage_IsValid;

	private static FFieldAddress LoadLevelInstanceBySoftObjectPtr_bLoadAsTempPackage_PropertyAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_bLoadAsTempPackage_Offset;

	private static bool LoadLevelInstanceBySoftObjectPtr_ReturnValue_IsValid;

	private static FFieldAddress LoadLevelInstanceBySoftObjectPtr_ReturnValue_PropertyAddress;

	private static int LoadLevelInstanceBySoftObjectPtr_ReturnValue_Offset;

	private static bool LoadLevelInstance_IsValid;

	private static IntPtr LoadLevelInstance_FunctionAddress;

	private static int LoadLevelInstance_ParamsSize;

	private static bool LoadLevelInstance_WorldContextObject_IsValid;

	private static FFieldAddress LoadLevelInstance_WorldContextObject_PropertyAddress;

	private static int LoadLevelInstance_WorldContextObject_Offset;

	private static bool LoadLevelInstance_LevelName_IsValid;

	private static FFieldAddress LoadLevelInstance_LevelName_PropertyAddress;

	private static int LoadLevelInstance_LevelName_Offset;

	private static bool LoadLevelInstance_Location_IsValid;

	private static FFieldAddress LoadLevelInstance_Location_PropertyAddress;

	private static int LoadLevelInstance_Location_Offset;

	private static bool LoadLevelInstance_Rotation_IsValid;

	private static FFieldAddress LoadLevelInstance_Rotation_PropertyAddress;

	private static int LoadLevelInstance_Rotation_Offset;

	private static bool LoadLevelInstance_bOutSuccess_IsValid;

	private static FFieldAddress LoadLevelInstance_bOutSuccess_PropertyAddress;

	private static int LoadLevelInstance_bOutSuccess_Offset;

	private static bool LoadLevelInstance_OptionalLevelNameOverride_IsValid;

	private static FFieldAddress LoadLevelInstance_OptionalLevelNameOverride_PropertyAddress;

	private static int LoadLevelInstance_OptionalLevelNameOverride_Offset;

	private static bool LoadLevelInstance_OptionalLevelStreamingClass_IsValid;

	private static FFieldAddress LoadLevelInstance_OptionalLevelStreamingClass_PropertyAddress;

	private static int LoadLevelInstance_OptionalLevelStreamingClass_Offset;

	private static bool LoadLevelInstance_bLoadAsTempPackage_IsValid;

	private static FFieldAddress LoadLevelInstance_bLoadAsTempPackage_PropertyAddress;

	private static int LoadLevelInstance_bLoadAsTempPackage_Offset;

	private static bool LoadLevelInstance_ReturnValue_IsValid;

	private static FFieldAddress LoadLevelInstance_ReturnValue_PropertyAddress;

	private static int LoadLevelInstance_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.LevelStreamingDynamic:LoadLevelInstanceBySoftObjectPtr")]
	public unsafe static ULevelStreamingDynamic LoadLevelInstanceBySoftObjectPtr(UObject WorldContextObject, TSoftObject<UWorld> Level, FVector Location, FRotator Rotation, out bool bOutSuccess, string OptionalLevelNameOverride, TSubclassOf<ULevelStreamingDynamic> OptionalLevelStreamingClass, bool bLoadAsTempPackage)
	{
		if (!LoadLevelInstanceBySoftObjectPtr_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreamingDynamic:LoadLevelInstanceBySoftObjectPtr");
			bOutSuccess = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadLevelInstanceBySoftObjectPtr_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadLevelInstanceBySoftObjectPtr_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LoadLevelInstanceBySoftObjectPtr_WorldContextObject_Offset), 0, LoadLevelInstanceBySoftObjectPtr_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(LoadLevelInstanceBySoftObjectPtr_Level_PropertyAddress.Address, intPtr);
		TSoftObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, LoadLevelInstanceBySoftObjectPtr_Level_Offset), 0, LoadLevelInstanceBySoftObjectPtr_Level_PropertyAddress.Address, Level);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LoadLevelInstanceBySoftObjectPtr_Location_Offset), 0, LoadLevelInstanceBySoftObjectPtr_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, LoadLevelInstanceBySoftObjectPtr_Rotation_Offset), 0, LoadLevelInstanceBySoftObjectPtr_Rotation_PropertyAddress.Address, Rotation);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_Offset), 0, LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_PropertyAddress.Address, OptionalLevelNameOverride);
		TSubclassOfMarshaler<ULevelStreamingDynamic>.ToNative(IntPtr.Add(intPtr, LoadLevelInstanceBySoftObjectPtr_OptionalLevelStreamingClass_Offset), 0, LoadLevelInstanceBySoftObjectPtr_OptionalLevelStreamingClass_PropertyAddress.Address, OptionalLevelStreamingClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LoadLevelInstanceBySoftObjectPtr_bLoadAsTempPackage_Offset), 0, LoadLevelInstanceBySoftObjectPtr_bLoadAsTempPackage_PropertyAddress.Address, bLoadAsTempPackage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, intPtr, LoadLevelInstanceBySoftObjectPtr_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadLevelInstanceBySoftObjectPtr_Level_PropertyAddress.Address, intPtr);
		bOutSuccess = BoolMarshaler.FromNative(IntPtr.Add(intPtr, LoadLevelInstanceBySoftObjectPtr_bOutSuccess_Offset), 0, LoadLevelInstanceBySoftObjectPtr_bOutSuccess_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<ULevelStreamingDynamic>.FromNative(IntPtr.Add(intPtr, LoadLevelInstanceBySoftObjectPtr_ReturnValue_Offset), 0, LoadLevelInstanceBySoftObjectPtr_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.LevelStreamingDynamic:LoadLevelInstance")]
	public unsafe static ULevelStreamingDynamic LoadLevelInstance(UObject WorldContextObject, string LevelName, FVector Location, FRotator Rotation, out bool bOutSuccess, string OptionalLevelNameOverride, TSubclassOf<ULevelStreamingDynamic> OptionalLevelStreamingClass, bool bLoadAsTempPackage)
	{
		if (!LoadLevelInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreamingDynamic:LoadLevelInstance");
			bOutSuccess = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadLevelInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadLevelInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LoadLevelInstance_WorldContextObject_Offset), 0, LoadLevelInstance_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadLevelInstance_LevelName_Offset), 0, LoadLevelInstance_LevelName_PropertyAddress.Address, LevelName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LoadLevelInstance_Location_Offset), 0, LoadLevelInstance_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, LoadLevelInstance_Rotation_Offset), 0, LoadLevelInstance_Rotation_PropertyAddress.Address, Rotation);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadLevelInstance_OptionalLevelNameOverride_Offset), 0, LoadLevelInstance_OptionalLevelNameOverride_PropertyAddress.Address, OptionalLevelNameOverride);
		TSubclassOfMarshaler<ULevelStreamingDynamic>.ToNative(IntPtr.Add(intPtr, LoadLevelInstance_OptionalLevelStreamingClass_Offset), 0, LoadLevelInstance_OptionalLevelStreamingClass_PropertyAddress.Address, OptionalLevelStreamingClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LoadLevelInstance_bLoadAsTempPackage_Offset), 0, LoadLevelInstance_bLoadAsTempPackage_PropertyAddress.Address, bLoadAsTempPackage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadLevelInstance_FunctionAddress, intPtr, LoadLevelInstance_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadLevelInstance_LevelName_PropertyAddress.Address, intPtr);
		bOutSuccess = BoolMarshaler.FromNative(IntPtr.Add(intPtr, LoadLevelInstance_bOutSuccess_Offset), 0, LoadLevelInstance_bOutSuccess_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LoadLevelInstance_OptionalLevelNameOverride_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<ULevelStreamingDynamic>.FromNative(IntPtr.Add(intPtr, LoadLevelInstance_ReturnValue_Offset), 0, LoadLevelInstance_ReturnValue_PropertyAddress.Address);
	}

	static ULevelStreamingDynamic()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelStreamingDynamic)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelStreamingDynamic));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.LevelStreamingDynamic");
		LoadLevelInstanceBySoftObjectPtr_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadLevelInstanceBySoftObjectPtr");
		LoadLevelInstanceBySoftObjectPtr_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadLevelInstanceBySoftObjectPtr_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstanceBySoftObjectPtr_WorldContextObject_PropertyAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "WorldContextObject");
		LoadLevelInstanceBySoftObjectPtr_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "WorldContextObject");
		LoadLevelInstanceBySoftObjectPtr_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstanceBySoftObjectPtr_Level_PropertyAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "Level");
		LoadLevelInstanceBySoftObjectPtr_Level_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "Level");
		LoadLevelInstanceBySoftObjectPtr_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "Level", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstanceBySoftObjectPtr_Location_PropertyAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "Location");
		LoadLevelInstanceBySoftObjectPtr_Location_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "Location");
		LoadLevelInstanceBySoftObjectPtr_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstanceBySoftObjectPtr_Rotation_PropertyAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "Rotation");
		LoadLevelInstanceBySoftObjectPtr_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "Rotation");
		LoadLevelInstanceBySoftObjectPtr_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstanceBySoftObjectPtr_bOutSuccess_PropertyAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "bOutSuccess");
		LoadLevelInstanceBySoftObjectPtr_bOutSuccess_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "bOutSuccess");
		LoadLevelInstanceBySoftObjectPtr_bOutSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "bOutSuccess", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_PropertyAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "OptionalLevelNameOverride");
		LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "OptionalLevelNameOverride");
		LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "OptionalLevelNameOverride", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstanceBySoftObjectPtr_OptionalLevelStreamingClass_PropertyAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "OptionalLevelStreamingClass");
		LoadLevelInstanceBySoftObjectPtr_OptionalLevelStreamingClass_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "OptionalLevelStreamingClass");
		LoadLevelInstanceBySoftObjectPtr_OptionalLevelStreamingClass_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "OptionalLevelStreamingClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstanceBySoftObjectPtr_bLoadAsTempPackage_PropertyAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "bLoadAsTempPackage");
		LoadLevelInstanceBySoftObjectPtr_bLoadAsTempPackage_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "bLoadAsTempPackage");
		LoadLevelInstanceBySoftObjectPtr_bLoadAsTempPackage_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "bLoadAsTempPackage", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstanceBySoftObjectPtr_ReturnValue_PropertyAddress, LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "ReturnValue");
		LoadLevelInstanceBySoftObjectPtr_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "ReturnValue");
		LoadLevelInstanceBySoftObjectPtr_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstanceBySoftObjectPtr_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadLevelInstanceBySoftObjectPtr_IsValid = LoadLevelInstanceBySoftObjectPtr_FunctionAddress != IntPtr.Zero && LoadLevelInstanceBySoftObjectPtr_WorldContextObject_IsValid && LoadLevelInstanceBySoftObjectPtr_Level_IsValid && LoadLevelInstanceBySoftObjectPtr_Location_IsValid && LoadLevelInstanceBySoftObjectPtr_Rotation_IsValid && LoadLevelInstanceBySoftObjectPtr_bOutSuccess_IsValid && LoadLevelInstanceBySoftObjectPtr_OptionalLevelNameOverride_IsValid && LoadLevelInstanceBySoftObjectPtr_OptionalLevelStreamingClass_IsValid && LoadLevelInstanceBySoftObjectPtr_bLoadAsTempPackage_IsValid && LoadLevelInstanceBySoftObjectPtr_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreamingDynamic:LoadLevelInstanceBySoftObjectPtr", LoadLevelInstanceBySoftObjectPtr_IsValid);
		LoadLevelInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadLevelInstance");
		LoadLevelInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadLevelInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstance_WorldContextObject_PropertyAddress, LoadLevelInstance_FunctionAddress, "WorldContextObject");
		LoadLevelInstance_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstance_FunctionAddress, "WorldContextObject");
		LoadLevelInstance_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstance_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstance_LevelName_PropertyAddress, LoadLevelInstance_FunctionAddress, "LevelName");
		LoadLevelInstance_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstance_FunctionAddress, "LevelName");
		LoadLevelInstance_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstance_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstance_Location_PropertyAddress, LoadLevelInstance_FunctionAddress, "Location");
		LoadLevelInstance_Location_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstance_FunctionAddress, "Location");
		LoadLevelInstance_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstance_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstance_Rotation_PropertyAddress, LoadLevelInstance_FunctionAddress, "Rotation");
		LoadLevelInstance_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstance_FunctionAddress, "Rotation");
		LoadLevelInstance_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstance_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstance_bOutSuccess_PropertyAddress, LoadLevelInstance_FunctionAddress, "bOutSuccess");
		LoadLevelInstance_bOutSuccess_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstance_FunctionAddress, "bOutSuccess");
		LoadLevelInstance_bOutSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstance_FunctionAddress, "bOutSuccess", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstance_OptionalLevelNameOverride_PropertyAddress, LoadLevelInstance_FunctionAddress, "OptionalLevelNameOverride");
		LoadLevelInstance_OptionalLevelNameOverride_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstance_FunctionAddress, "OptionalLevelNameOverride");
		LoadLevelInstance_OptionalLevelNameOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstance_FunctionAddress, "OptionalLevelNameOverride", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstance_OptionalLevelStreamingClass_PropertyAddress, LoadLevelInstance_FunctionAddress, "OptionalLevelStreamingClass");
		LoadLevelInstance_OptionalLevelStreamingClass_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstance_FunctionAddress, "OptionalLevelStreamingClass");
		LoadLevelInstance_OptionalLevelStreamingClass_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstance_FunctionAddress, "OptionalLevelStreamingClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstance_bLoadAsTempPackage_PropertyAddress, LoadLevelInstance_FunctionAddress, "bLoadAsTempPackage");
		LoadLevelInstance_bLoadAsTempPackage_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstance_FunctionAddress, "bLoadAsTempPackage");
		LoadLevelInstance_bLoadAsTempPackage_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstance_FunctionAddress, "bLoadAsTempPackage", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelInstance_ReturnValue_PropertyAddress, LoadLevelInstance_FunctionAddress, "ReturnValue");
		LoadLevelInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelInstance_FunctionAddress, "ReturnValue");
		LoadLevelInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadLevelInstance_IsValid = LoadLevelInstance_FunctionAddress != IntPtr.Zero && LoadLevelInstance_WorldContextObject_IsValid && LoadLevelInstance_LevelName_IsValid && LoadLevelInstance_Location_IsValid && LoadLevelInstance_Rotation_IsValid && LoadLevelInstance_bOutSuccess_IsValid && LoadLevelInstance_OptionalLevelNameOverride_IsValid && LoadLevelInstance_OptionalLevelStreamingClass_IsValid && LoadLevelInstance_bLoadAsTempPackage_IsValid && LoadLevelInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreamingDynamic:LoadLevelInstance", LoadLevelInstance_IsValid);
	}
}
