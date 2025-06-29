using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/EditorScriptingUtilities.EditorLevelLibrary", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public class UEditorLevelLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SpawnActorFromObject_IsValid;

	private static IntPtr SpawnActorFromObject_FunctionAddress;

	private static int SpawnActorFromObject_ParamsSize;

	private static bool SpawnActorFromObject_ObjectToUse_IsValid;

	private static FFieldAddress SpawnActorFromObject_ObjectToUse_PropertyAddress;

	private static int SpawnActorFromObject_ObjectToUse_Offset;

	private static bool SpawnActorFromObject_Location_IsValid;

	private static FFieldAddress SpawnActorFromObject_Location_PropertyAddress;

	private static int SpawnActorFromObject_Location_Offset;

	private static bool SpawnActorFromObject_Rotation_IsValid;

	private static FFieldAddress SpawnActorFromObject_Rotation_PropertyAddress;

	private static int SpawnActorFromObject_Rotation_Offset;

	private static bool SpawnActorFromObject_bTransient_IsValid;

	private static FFieldAddress SpawnActorFromObject_bTransient_PropertyAddress;

	private static int SpawnActorFromObject_bTransient_Offset;

	private static bool SpawnActorFromObject_ReturnValue_IsValid;

	private static FFieldAddress SpawnActorFromObject_ReturnValue_PropertyAddress;

	private static int SpawnActorFromObject_ReturnValue_Offset;

	private static bool SpawnActorFromClass_IsValid;

	private static IntPtr SpawnActorFromClass_FunctionAddress;

	private static int SpawnActorFromClass_ParamsSize;

	private static bool SpawnActorFromClass_ActorClass_IsValid;

	private static FFieldAddress SpawnActorFromClass_ActorClass_PropertyAddress;

	private static int SpawnActorFromClass_ActorClass_Offset;

	private static bool SpawnActorFromClass_Location_IsValid;

	private static FFieldAddress SpawnActorFromClass_Location_PropertyAddress;

	private static int SpawnActorFromClass_Location_Offset;

	private static bool SpawnActorFromClass_Rotation_IsValid;

	private static FFieldAddress SpawnActorFromClass_Rotation_PropertyAddress;

	private static int SpawnActorFromClass_Rotation_Offset;

	private static bool SpawnActorFromClass_bTransient_IsValid;

	private static FFieldAddress SpawnActorFromClass_bTransient_PropertyAddress;

	private static int SpawnActorFromClass_bTransient_Offset;

	private static bool SpawnActorFromClass_ReturnValue_IsValid;

	private static FFieldAddress SpawnActorFromClass_ReturnValue_PropertyAddress;

	private static int SpawnActorFromClass_ReturnValue_Offset;

	private static bool ReplaceSelectedActors_IsValid;

	private static IntPtr ReplaceSelectedActors_FunctionAddress;

	private static int ReplaceSelectedActors_ParamsSize;

	private static bool ReplaceSelectedActors_InAssetPath_IsValid;

	private static FFieldAddress ReplaceSelectedActors_InAssetPath_PropertyAddress;

	private static int ReplaceSelectedActors_InAssetPath_Offset;

	private static bool GetPIEWorlds_IsValid;

	private static IntPtr GetPIEWorlds_FunctionAddress;

	private static int GetPIEWorlds_ParamsSize;

	private static bool GetPIEWorlds_bIncludeDedicatedServer_IsValid;

	private static FFieldAddress GetPIEWorlds_bIncludeDedicatedServer_PropertyAddress;

	private static int GetPIEWorlds_bIncludeDedicatedServer_Offset;

	private static bool GetPIEWorlds_ReturnValue_IsValid;

	private static FFieldAddress GetPIEWorlds_ReturnValue_PropertyAddress;

	private static int GetPIEWorlds_ReturnValue_Offset;

	private static bool EditorEndPlay_IsValid;

	private static IntPtr EditorEndPlay_FunctionAddress;

	private static int EditorEndPlay_ParamsSize;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorLevelLibrary:SpawnActorFromObject")]
	public unsafe static AActor SpawnActorFromObject(UObject ObjectToUse, FVector Location, FRotator Rotation, bool bTransient = false)
	{
		if (!SpawnActorFromObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorLevelLibrary:SpawnActorFromObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnActorFromObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnActorFromObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnActorFromObject_ObjectToUse_Offset), 0, SpawnActorFromObject_ObjectToUse_PropertyAddress.Address, ObjectToUse);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnActorFromObject_Location_Offset), 0, SpawnActorFromObject_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SpawnActorFromObject_Rotation_Offset), 0, SpawnActorFromObject_Rotation_PropertyAddress.Address, Rotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnActorFromObject_bTransient_Offset), 0, SpawnActorFromObject_bTransient_PropertyAddress.Address, bTransient);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnActorFromObject_FunctionAddress, intPtr, SpawnActorFromObject_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, SpawnActorFromObject_ReturnValue_Offset), 0, SpawnActorFromObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorLevelLibrary:SpawnActorFromClass")]
	public unsafe static AActor SpawnActorFromClass(TSubclassOf<AActor> ActorClass, FVector Location, FRotator Rotation, bool bTransient = false)
	{
		if (!SpawnActorFromClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorLevelLibrary:SpawnActorFromClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnActorFromClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnActorFromClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SpawnActorFromClass_ActorClass_Offset), 0, SpawnActorFromClass_ActorClass_PropertyAddress.Address, ActorClass);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnActorFromClass_Location_Offset), 0, SpawnActorFromClass_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SpawnActorFromClass_Rotation_Offset), 0, SpawnActorFromClass_Rotation_PropertyAddress.Address, Rotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnActorFromClass_bTransient_Offset), 0, SpawnActorFromClass_bTransient_PropertyAddress.Address, bTransient);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnActorFromClass_FunctionAddress, intPtr, SpawnActorFromClass_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, SpawnActorFromClass_ReturnValue_Offset), 0, SpawnActorFromClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorLevelLibrary:ReplaceSelectedActors")]
	public unsafe static void ReplaceSelectedActors(string InAssetPath)
	{
		if (!ReplaceSelectedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorLevelLibrary:ReplaceSelectedActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceSelectedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceSelectedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceSelectedActors_InAssetPath_Offset), 0, ReplaceSelectedActors_InAssetPath_PropertyAddress.Address, InAssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceSelectedActors_FunctionAddress, intPtr, ReplaceSelectedActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceSelectedActors_InAssetPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorLevelLibrary:GetPIEWorlds")]
	public unsafe static List<UWorld> GetPIEWorlds(bool bIncludeDedicatedServer)
	{
		if (!GetPIEWorlds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorLevelLibrary:GetPIEWorlds");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPIEWorlds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPIEWorlds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetPIEWorlds_bIncludeDedicatedServer_Offset), 0, GetPIEWorlds_bIncludeDedicatedServer_PropertyAddress.Address, bIncludeDedicatedServer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPIEWorlds_FunctionAddress, intPtr, GetPIEWorlds_ParamsSize);
		List<UWorld> result = new TArrayCopyMarshaler<UWorld>(1, GetPIEWorlds_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UWorld, UObjectMarshaler<UWorld>>.FromNative, CachedMarshalingDelegates<UWorld, UObjectMarshaler<UWorld>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPIEWorlds_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPIEWorlds_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorLevelLibrary:EditorEndPlay")]
	public unsafe static void EditorEndPlay()
	{
		if (!EditorEndPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorLevelLibrary:EditorEndPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorEndPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorEndPlay_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: EditorEndPlay_FunctionAddress, argsSize: EditorEndPlay_ParamsSize);
	}

	static UEditorLevelLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorLevelLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorLevelLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/EditorScriptingUtilities.EditorLevelLibrary");
		SpawnActorFromObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnActorFromObject");
		SpawnActorFromObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnActorFromObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_ObjectToUse_PropertyAddress, SpawnActorFromObject_FunctionAddress, "ObjectToUse");
		SpawnActorFromObject_ObjectToUse_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "ObjectToUse");
		SpawnActorFromObject_ObjectToUse_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "ObjectToUse", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_Location_PropertyAddress, SpawnActorFromObject_FunctionAddress, "Location");
		SpawnActorFromObject_Location_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "Location");
		SpawnActorFromObject_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_Rotation_PropertyAddress, SpawnActorFromObject_FunctionAddress, "Rotation");
		SpawnActorFromObject_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "Rotation");
		SpawnActorFromObject_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_bTransient_PropertyAddress, SpawnActorFromObject_FunctionAddress, "bTransient");
		SpawnActorFromObject_bTransient_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "bTransient");
		SpawnActorFromObject_bTransient_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "bTransient", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromObject_ReturnValue_PropertyAddress, SpawnActorFromObject_FunctionAddress, "ReturnValue");
		SpawnActorFromObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromObject_FunctionAddress, "ReturnValue");
		SpawnActorFromObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnActorFromObject_IsValid = SpawnActorFromObject_FunctionAddress != IntPtr.Zero && SpawnActorFromObject_ObjectToUse_IsValid && SpawnActorFromObject_Location_IsValid && SpawnActorFromObject_Rotation_IsValid && SpawnActorFromObject_bTransient_IsValid && SpawnActorFromObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorLevelLibrary:SpawnActorFromObject", SpawnActorFromObject_IsValid);
		SpawnActorFromClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnActorFromClass");
		SpawnActorFromClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnActorFromClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_ActorClass_PropertyAddress, SpawnActorFromClass_FunctionAddress, "ActorClass");
		SpawnActorFromClass_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "ActorClass");
		SpawnActorFromClass_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_Location_PropertyAddress, SpawnActorFromClass_FunctionAddress, "Location");
		SpawnActorFromClass_Location_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "Location");
		SpawnActorFromClass_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_Rotation_PropertyAddress, SpawnActorFromClass_FunctionAddress, "Rotation");
		SpawnActorFromClass_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "Rotation");
		SpawnActorFromClass_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_bTransient_PropertyAddress, SpawnActorFromClass_FunctionAddress, "bTransient");
		SpawnActorFromClass_bTransient_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "bTransient");
		SpawnActorFromClass_bTransient_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "bTransient", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromClass_ReturnValue_PropertyAddress, SpawnActorFromClass_FunctionAddress, "ReturnValue");
		SpawnActorFromClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromClass_FunctionAddress, "ReturnValue");
		SpawnActorFromClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnActorFromClass_IsValid = SpawnActorFromClass_FunctionAddress != IntPtr.Zero && SpawnActorFromClass_ActorClass_IsValid && SpawnActorFromClass_Location_IsValid && SpawnActorFromClass_Rotation_IsValid && SpawnActorFromClass_bTransient_IsValid && SpawnActorFromClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorLevelLibrary:SpawnActorFromClass", SpawnActorFromClass_IsValid);
		ReplaceSelectedActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceSelectedActors");
		ReplaceSelectedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceSelectedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSelectedActors_InAssetPath_PropertyAddress, ReplaceSelectedActors_FunctionAddress, "InAssetPath");
		ReplaceSelectedActors_InAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSelectedActors_FunctionAddress, "InAssetPath");
		ReplaceSelectedActors_InAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSelectedActors_FunctionAddress, "InAssetPath", Classes.FStrProperty);
		ReplaceSelectedActors_IsValid = ReplaceSelectedActors_FunctionAddress != IntPtr.Zero && ReplaceSelectedActors_InAssetPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorLevelLibrary:ReplaceSelectedActors", ReplaceSelectedActors_IsValid);
		GetPIEWorlds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPIEWorlds");
		GetPIEWorlds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPIEWorlds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPIEWorlds_bIncludeDedicatedServer_PropertyAddress, GetPIEWorlds_FunctionAddress, "bIncludeDedicatedServer");
		GetPIEWorlds_bIncludeDedicatedServer_Offset = NativeReflectionCached.GetPropertyOffset(GetPIEWorlds_FunctionAddress, "bIncludeDedicatedServer");
		GetPIEWorlds_bIncludeDedicatedServer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPIEWorlds_FunctionAddress, "bIncludeDedicatedServer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPIEWorlds_ReturnValue_PropertyAddress, GetPIEWorlds_FunctionAddress, "ReturnValue");
		GetPIEWorlds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPIEWorlds_FunctionAddress, "ReturnValue");
		GetPIEWorlds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPIEWorlds_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPIEWorlds_IsValid = GetPIEWorlds_FunctionAddress != IntPtr.Zero && GetPIEWorlds_bIncludeDedicatedServer_IsValid && GetPIEWorlds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorLevelLibrary:GetPIEWorlds", GetPIEWorlds_IsValid);
		EditorEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EditorEndPlay");
		EditorEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorEndPlay_FunctionAddress);
		EditorEndPlay_IsValid = EditorEndPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorLevelLibrary:EditorEndPlay", EditorEndPlay_IsValid);
	}
}
