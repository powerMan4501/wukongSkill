using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Plugins.GeometryScriptingCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions", "GeometryScriptingEditor", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_NewAssetUtils : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool CreateUniqueNewAssetPathName_IsValid;

	private static IntPtr CreateUniqueNewAssetPathName_FunctionAddress;

	private static int CreateUniqueNewAssetPathName_ParamsSize;

	private static bool CreateUniqueNewAssetPathName_AssetFolderPath_IsValid;

	private static FFieldAddress CreateUniqueNewAssetPathName_AssetFolderPath_PropertyAddress;

	private static int CreateUniqueNewAssetPathName_AssetFolderPath_Offset;

	private static bool CreateUniqueNewAssetPathName_BaseAssetName_IsValid;

	private static FFieldAddress CreateUniqueNewAssetPathName_BaseAssetName_PropertyAddress;

	private static int CreateUniqueNewAssetPathName_BaseAssetName_Offset;

	private static bool CreateUniqueNewAssetPathName_UniqueAssetPathAndName_IsValid;

	private static FFieldAddress CreateUniqueNewAssetPathName_UniqueAssetPathAndName_PropertyAddress;

	private static int CreateUniqueNewAssetPathName_UniqueAssetPathAndName_Offset;

	private static bool CreateUniqueNewAssetPathName_UniqueAssetName_IsValid;

	private static FFieldAddress CreateUniqueNewAssetPathName_UniqueAssetName_PropertyAddress;

	private static int CreateUniqueNewAssetPathName_UniqueAssetName_Offset;

	private static bool CreateUniqueNewAssetPathName_Options_IsValid;

	private static FFieldAddress CreateUniqueNewAssetPathName_Options_PropertyAddress;

	private static int CreateUniqueNewAssetPathName_Options_Offset;

	private static bool CreateUniqueNewAssetPathName_Outcome_IsValid;

	private static FFieldAddress CreateUniqueNewAssetPathName_Outcome_PropertyAddress;

	private static int CreateUniqueNewAssetPathName_Outcome_Offset;

	private static bool CreateUniqueNewAssetPathName_Debug_IsValid;

	private static FFieldAddress CreateUniqueNewAssetPathName_Debug_PropertyAddress;

	private static int CreateUniqueNewAssetPathName_Debug_Offset;

	private static bool CreateNewVolumeFromMesh_IsValid;

	private static IntPtr CreateNewVolumeFromMesh_FunctionAddress;

	private static int CreateNewVolumeFromMesh_ParamsSize;

	private static bool CreateNewVolumeFromMesh_FromDynamicMesh_IsValid;

	private static FFieldAddress CreateNewVolumeFromMesh_FromDynamicMesh_PropertyAddress;

	private static int CreateNewVolumeFromMesh_FromDynamicMesh_Offset;

	private static bool CreateNewVolumeFromMesh_CreateInWorld_IsValid;

	private static FFieldAddress CreateNewVolumeFromMesh_CreateInWorld_PropertyAddress;

	private static int CreateNewVolumeFromMesh_CreateInWorld_Offset;

	private static bool CreateNewVolumeFromMesh_ActorTransform_IsValid;

	private static FFieldAddress CreateNewVolumeFromMesh_ActorTransform_PropertyAddress;

	private static int CreateNewVolumeFromMesh_ActorTransform_Offset;

	private static bool CreateNewVolumeFromMesh_BaseActorName_IsValid;

	private static FFieldAddress CreateNewVolumeFromMesh_BaseActorName_PropertyAddress;

	private static int CreateNewVolumeFromMesh_BaseActorName_Offset;

	private static bool CreateNewVolumeFromMesh_Options_IsValid;

	private static FFieldAddress CreateNewVolumeFromMesh_Options_PropertyAddress;

	private static int CreateNewVolumeFromMesh_Options_Offset;

	private static bool CreateNewVolumeFromMesh_Outcome_IsValid;

	private static FFieldAddress CreateNewVolumeFromMesh_Outcome_PropertyAddress;

	private static int CreateNewVolumeFromMesh_Outcome_Offset;

	private static bool CreateNewVolumeFromMesh_Debug_IsValid;

	private static FFieldAddress CreateNewVolumeFromMesh_Debug_PropertyAddress;

	private static int CreateNewVolumeFromMesh_Debug_Offset;

	private static bool CreateNewVolumeFromMesh_ReturnValue_IsValid;

	private static FFieldAddress CreateNewVolumeFromMesh_ReturnValue_PropertyAddress;

	private static int CreateNewVolumeFromMesh_ReturnValue_Offset;

	private static bool CreateNewStaticMeshAssetFromMesh_IsValid;

	private static IntPtr CreateNewStaticMeshAssetFromMesh_FunctionAddress;

	private static int CreateNewStaticMeshAssetFromMesh_ParamsSize;

	private static bool CreateNewStaticMeshAssetFromMesh_FromDynamicMesh_IsValid;

	private static FFieldAddress CreateNewStaticMeshAssetFromMesh_FromDynamicMesh_PropertyAddress;

	private static int CreateNewStaticMeshAssetFromMesh_FromDynamicMesh_Offset;

	private static bool CreateNewStaticMeshAssetFromMesh_AssetPathAndName_IsValid;

	private static FFieldAddress CreateNewStaticMeshAssetFromMesh_AssetPathAndName_PropertyAddress;

	private static int CreateNewStaticMeshAssetFromMesh_AssetPathAndName_Offset;

	private static bool CreateNewStaticMeshAssetFromMesh_Options_IsValid;

	private static FFieldAddress CreateNewStaticMeshAssetFromMesh_Options_PropertyAddress;

	private static int CreateNewStaticMeshAssetFromMesh_Options_Offset;

	private static bool CreateNewStaticMeshAssetFromMesh_Outcome_IsValid;

	private static FFieldAddress CreateNewStaticMeshAssetFromMesh_Outcome_PropertyAddress;

	private static int CreateNewStaticMeshAssetFromMesh_Outcome_Offset;

	private static bool CreateNewStaticMeshAssetFromMesh_Debug_IsValid;

	private static FFieldAddress CreateNewStaticMeshAssetFromMesh_Debug_PropertyAddress;

	private static int CreateNewStaticMeshAssetFromMesh_Debug_Offset;

	private static bool CreateNewStaticMeshAssetFromMesh_ReturnValue_IsValid;

	private static FFieldAddress CreateNewStaticMeshAssetFromMesh_ReturnValue_PropertyAddress;

	private static int CreateNewStaticMeshAssetFromMesh_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions:CreateUniqueNewAssetPathName")]
	public unsafe static void CreateUniqueNewAssetPathName(string AssetFolderPath, string BaseAssetName, out string UniqueAssetPathAndName, out string UniqueAssetName, FGeometryScriptUniqueAssetNameOptions Options, out EGeometryScriptOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!CreateUniqueNewAssetPathName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions:CreateUniqueNewAssetPathName");
			UniqueAssetPathAndName = FStringMarshaler.DefaultString;
			UniqueAssetName = FStringMarshaler.DefaultString;
			Outcome = EGeometryScriptOutcomePins.Failure;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateUniqueNewAssetPathName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateUniqueNewAssetPathName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateUniqueNewAssetPathName_AssetFolderPath_Offset), 0, CreateUniqueNewAssetPathName_AssetFolderPath_PropertyAddress.Address, AssetFolderPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateUniqueNewAssetPathName_BaseAssetName_Offset), 0, CreateUniqueNewAssetPathName_BaseAssetName_PropertyAddress.Address, BaseAssetName);
		NativeReflection.InitializeValue_InContainer(CreateUniqueNewAssetPathName_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptUniqueAssetNameOptions.ToNative(IntPtr.Add(intPtr, CreateUniqueNewAssetPathName_Options_Offset), 0, CreateUniqueNewAssetPathName_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CreateUniqueNewAssetPathName_Debug_Offset), 0, CreateUniqueNewAssetPathName_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateUniqueNewAssetPathName_FunctionAddress, intPtr, CreateUniqueNewAssetPathName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateUniqueNewAssetPathName_AssetFolderPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateUniqueNewAssetPathName_BaseAssetName_PropertyAddress.Address, intPtr);
		UniqueAssetPathAndName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, CreateUniqueNewAssetPathName_UniqueAssetPathAndName_Offset), 0, CreateUniqueNewAssetPathName_UniqueAssetPathAndName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateUniqueNewAssetPathName_UniqueAssetPathAndName_PropertyAddress.Address, intPtr);
		UniqueAssetName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, CreateUniqueNewAssetPathName_UniqueAssetName_Offset), 0, CreateUniqueNewAssetPathName_UniqueAssetName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateUniqueNewAssetPathName_UniqueAssetName_PropertyAddress.Address, intPtr);
		Outcome = EnumMarshaler<EGeometryScriptOutcomePins>.FromNative(IntPtr.Add(intPtr, CreateUniqueNewAssetPathName_Outcome_Offset), 0, CreateUniqueNewAssetPathName_Outcome_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions:CreateNewVolumeFromMesh")]
	public unsafe static AVolume CreateNewVolumeFromMesh(UDynamicMesh FromDynamicMesh, ref UWorld CreateInWorld, FTransform ActorTransform, string BaseActorName, FGeometryScriptCreateNewVolumeFromMeshOptions Options, out EGeometryScriptOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!CreateNewVolumeFromMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions:CreateNewVolumeFromMesh");
			Outcome = EGeometryScriptOutcomePins.Failure;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateNewVolumeFromMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateNewVolumeFromMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CreateNewVolumeFromMesh_FromDynamicMesh_Offset), 0, CreateNewVolumeFromMesh_FromDynamicMesh_PropertyAddress.Address, FromDynamicMesh);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, CreateNewVolumeFromMesh_CreateInWorld_Offset), 0, CreateNewVolumeFromMesh_CreateInWorld_PropertyAddress.Address, CreateInWorld);
		NativeReflection.InitializeValue_InContainer(CreateNewVolumeFromMesh_ActorTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CreateNewVolumeFromMesh_ActorTransform_Offset), 0, CreateNewVolumeFromMesh_ActorTransform_PropertyAddress.Address, ActorTransform);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateNewVolumeFromMesh_BaseActorName_Offset), 0, CreateNewVolumeFromMesh_BaseActorName_PropertyAddress.Address, BaseActorName);
		NativeReflection.InitializeValue_InContainer(CreateNewVolumeFromMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptCreateNewVolumeFromMeshOptions.ToNative(IntPtr.Add(intPtr, CreateNewVolumeFromMesh_Options_Offset), 0, CreateNewVolumeFromMesh_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CreateNewVolumeFromMesh_Debug_Offset), 0, CreateNewVolumeFromMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateNewVolumeFromMesh_FunctionAddress, intPtr, CreateNewVolumeFromMesh_ParamsSize);
		CreateInWorld = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, CreateNewVolumeFromMesh_CreateInWorld_Offset), 0, CreateNewVolumeFromMesh_CreateInWorld_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateNewVolumeFromMesh_BaseActorName_PropertyAddress.Address, intPtr);
		Outcome = EnumMarshaler<EGeometryScriptOutcomePins>.FromNative(IntPtr.Add(intPtr, CreateNewVolumeFromMesh_Outcome_Offset), 0, CreateNewVolumeFromMesh_Outcome_PropertyAddress.Address);
		return UObjectMarshaler<AVolume>.FromNative(IntPtr.Add(intPtr, CreateNewVolumeFromMesh_ReturnValue_Offset), 0, CreateNewVolumeFromMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions:CreateNewStaticMeshAssetFromMesh")]
	public unsafe static UStaticMesh CreateNewStaticMeshAssetFromMesh(UDynamicMesh FromDynamicMesh, string AssetPathAndName, FGeometryScriptCreateNewStaticMeshAssetOptions Options, out EGeometryScriptOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!CreateNewStaticMeshAssetFromMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions:CreateNewStaticMeshAssetFromMesh");
			Outcome = EGeometryScriptOutcomePins.Failure;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateNewStaticMeshAssetFromMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateNewStaticMeshAssetFromMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CreateNewStaticMeshAssetFromMesh_FromDynamicMesh_Offset), 0, CreateNewStaticMeshAssetFromMesh_FromDynamicMesh_PropertyAddress.Address, FromDynamicMesh);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateNewStaticMeshAssetFromMesh_AssetPathAndName_Offset), 0, CreateNewStaticMeshAssetFromMesh_AssetPathAndName_PropertyAddress.Address, AssetPathAndName);
		NativeReflection.InitializeValue_InContainer(CreateNewStaticMeshAssetFromMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptCreateNewStaticMeshAssetOptions.ToNative(IntPtr.Add(intPtr, CreateNewStaticMeshAssetFromMesh_Options_Offset), 0, CreateNewStaticMeshAssetFromMesh_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CreateNewStaticMeshAssetFromMesh_Debug_Offset), 0, CreateNewStaticMeshAssetFromMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateNewStaticMeshAssetFromMesh_FunctionAddress, intPtr, CreateNewStaticMeshAssetFromMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateNewStaticMeshAssetFromMesh_AssetPathAndName_PropertyAddress.Address, intPtr);
		Outcome = EnumMarshaler<EGeometryScriptOutcomePins>.FromNative(IntPtr.Add(intPtr, CreateNewStaticMeshAssetFromMesh_Outcome_Offset), 0, CreateNewStaticMeshAssetFromMesh_Outcome_PropertyAddress.Address);
		return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(intPtr, CreateNewStaticMeshAssetFromMesh_ReturnValue_Offset), 0, CreateNewStaticMeshAssetFromMesh_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_NewAssetUtils()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_NewAssetUtils)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_NewAssetUtils));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions");
		CreateUniqueNewAssetPathName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateUniqueNewAssetPathName");
		CreateUniqueNewAssetPathName_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateUniqueNewAssetPathName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueNewAssetPathName_AssetFolderPath_PropertyAddress, CreateUniqueNewAssetPathName_FunctionAddress, "AssetFolderPath");
		CreateUniqueNewAssetPathName_AssetFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueNewAssetPathName_FunctionAddress, "AssetFolderPath");
		CreateUniqueNewAssetPathName_AssetFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueNewAssetPathName_FunctionAddress, "AssetFolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueNewAssetPathName_BaseAssetName_PropertyAddress, CreateUniqueNewAssetPathName_FunctionAddress, "BaseAssetName");
		CreateUniqueNewAssetPathName_BaseAssetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueNewAssetPathName_FunctionAddress, "BaseAssetName");
		CreateUniqueNewAssetPathName_BaseAssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueNewAssetPathName_FunctionAddress, "BaseAssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueNewAssetPathName_UniqueAssetPathAndName_PropertyAddress, CreateUniqueNewAssetPathName_FunctionAddress, "UniqueAssetPathAndName");
		CreateUniqueNewAssetPathName_UniqueAssetPathAndName_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueNewAssetPathName_FunctionAddress, "UniqueAssetPathAndName");
		CreateUniqueNewAssetPathName_UniqueAssetPathAndName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueNewAssetPathName_FunctionAddress, "UniqueAssetPathAndName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueNewAssetPathName_UniqueAssetName_PropertyAddress, CreateUniqueNewAssetPathName_FunctionAddress, "UniqueAssetName");
		CreateUniqueNewAssetPathName_UniqueAssetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueNewAssetPathName_FunctionAddress, "UniqueAssetName");
		CreateUniqueNewAssetPathName_UniqueAssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueNewAssetPathName_FunctionAddress, "UniqueAssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueNewAssetPathName_Options_PropertyAddress, CreateUniqueNewAssetPathName_FunctionAddress, "Options");
		CreateUniqueNewAssetPathName_Options_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueNewAssetPathName_FunctionAddress, "Options");
		CreateUniqueNewAssetPathName_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueNewAssetPathName_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueNewAssetPathName_Outcome_PropertyAddress, CreateUniqueNewAssetPathName_FunctionAddress, "Outcome");
		CreateUniqueNewAssetPathName_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueNewAssetPathName_FunctionAddress, "Outcome");
		CreateUniqueNewAssetPathName_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueNewAssetPathName_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueNewAssetPathName_Debug_PropertyAddress, CreateUniqueNewAssetPathName_FunctionAddress, "Debug");
		CreateUniqueNewAssetPathName_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueNewAssetPathName_FunctionAddress, "Debug");
		CreateUniqueNewAssetPathName_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueNewAssetPathName_FunctionAddress, "Debug", Classes.FObjectProperty);
		CreateUniqueNewAssetPathName_IsValid = CreateUniqueNewAssetPathName_FunctionAddress != IntPtr.Zero && CreateUniqueNewAssetPathName_AssetFolderPath_IsValid && CreateUniqueNewAssetPathName_BaseAssetName_IsValid && CreateUniqueNewAssetPathName_UniqueAssetPathAndName_IsValid && CreateUniqueNewAssetPathName_UniqueAssetName_IsValid && CreateUniqueNewAssetPathName_Options_IsValid && CreateUniqueNewAssetPathName_Outcome_IsValid && CreateUniqueNewAssetPathName_Debug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions:CreateUniqueNewAssetPathName", CreateUniqueNewAssetPathName_IsValid);
		CreateNewVolumeFromMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateNewVolumeFromMesh");
		CreateNewVolumeFromMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateNewVolumeFromMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateNewVolumeFromMesh_FromDynamicMesh_PropertyAddress, CreateNewVolumeFromMesh_FunctionAddress, "FromDynamicMesh");
		CreateNewVolumeFromMesh_FromDynamicMesh_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewVolumeFromMesh_FunctionAddress, "FromDynamicMesh");
		CreateNewVolumeFromMesh_FromDynamicMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewVolumeFromMesh_FunctionAddress, "FromDynamicMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewVolumeFromMesh_CreateInWorld_PropertyAddress, CreateNewVolumeFromMesh_FunctionAddress, "CreateInWorld");
		CreateNewVolumeFromMesh_CreateInWorld_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewVolumeFromMesh_FunctionAddress, "CreateInWorld");
		CreateNewVolumeFromMesh_CreateInWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewVolumeFromMesh_FunctionAddress, "CreateInWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewVolumeFromMesh_ActorTransform_PropertyAddress, CreateNewVolumeFromMesh_FunctionAddress, "ActorTransform");
		CreateNewVolumeFromMesh_ActorTransform_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewVolumeFromMesh_FunctionAddress, "ActorTransform");
		CreateNewVolumeFromMesh_ActorTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewVolumeFromMesh_FunctionAddress, "ActorTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewVolumeFromMesh_BaseActorName_PropertyAddress, CreateNewVolumeFromMesh_FunctionAddress, "BaseActorName");
		CreateNewVolumeFromMesh_BaseActorName_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewVolumeFromMesh_FunctionAddress, "BaseActorName");
		CreateNewVolumeFromMesh_BaseActorName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewVolumeFromMesh_FunctionAddress, "BaseActorName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewVolumeFromMesh_Options_PropertyAddress, CreateNewVolumeFromMesh_FunctionAddress, "Options");
		CreateNewVolumeFromMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewVolumeFromMesh_FunctionAddress, "Options");
		CreateNewVolumeFromMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewVolumeFromMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewVolumeFromMesh_Outcome_PropertyAddress, CreateNewVolumeFromMesh_FunctionAddress, "Outcome");
		CreateNewVolumeFromMesh_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewVolumeFromMesh_FunctionAddress, "Outcome");
		CreateNewVolumeFromMesh_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewVolumeFromMesh_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewVolumeFromMesh_Debug_PropertyAddress, CreateNewVolumeFromMesh_FunctionAddress, "Debug");
		CreateNewVolumeFromMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewVolumeFromMesh_FunctionAddress, "Debug");
		CreateNewVolumeFromMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewVolumeFromMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewVolumeFromMesh_ReturnValue_PropertyAddress, CreateNewVolumeFromMesh_FunctionAddress, "ReturnValue");
		CreateNewVolumeFromMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewVolumeFromMesh_FunctionAddress, "ReturnValue");
		CreateNewVolumeFromMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewVolumeFromMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateNewVolumeFromMesh_IsValid = CreateNewVolumeFromMesh_FunctionAddress != IntPtr.Zero && CreateNewVolumeFromMesh_FromDynamicMesh_IsValid && CreateNewVolumeFromMesh_CreateInWorld_IsValid && CreateNewVolumeFromMesh_ActorTransform_IsValid && CreateNewVolumeFromMesh_BaseActorName_IsValid && CreateNewVolumeFromMesh_Options_IsValid && CreateNewVolumeFromMesh_Outcome_IsValid && CreateNewVolumeFromMesh_Debug_IsValid && CreateNewVolumeFromMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions:CreateNewVolumeFromMesh", CreateNewVolumeFromMesh_IsValid);
		CreateNewStaticMeshAssetFromMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateNewStaticMeshAssetFromMesh");
		CreateNewStaticMeshAssetFromMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateNewStaticMeshAssetFromMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateNewStaticMeshAssetFromMesh_FromDynamicMesh_PropertyAddress, CreateNewStaticMeshAssetFromMesh_FunctionAddress, "FromDynamicMesh");
		CreateNewStaticMeshAssetFromMesh_FromDynamicMesh_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "FromDynamicMesh");
		CreateNewStaticMeshAssetFromMesh_FromDynamicMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "FromDynamicMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewStaticMeshAssetFromMesh_AssetPathAndName_PropertyAddress, CreateNewStaticMeshAssetFromMesh_FunctionAddress, "AssetPathAndName");
		CreateNewStaticMeshAssetFromMesh_AssetPathAndName_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "AssetPathAndName");
		CreateNewStaticMeshAssetFromMesh_AssetPathAndName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "AssetPathAndName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewStaticMeshAssetFromMesh_Options_PropertyAddress, CreateNewStaticMeshAssetFromMesh_FunctionAddress, "Options");
		CreateNewStaticMeshAssetFromMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "Options");
		CreateNewStaticMeshAssetFromMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewStaticMeshAssetFromMesh_Outcome_PropertyAddress, CreateNewStaticMeshAssetFromMesh_FunctionAddress, "Outcome");
		CreateNewStaticMeshAssetFromMesh_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "Outcome");
		CreateNewStaticMeshAssetFromMesh_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewStaticMeshAssetFromMesh_Debug_PropertyAddress, CreateNewStaticMeshAssetFromMesh_FunctionAddress, "Debug");
		CreateNewStaticMeshAssetFromMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "Debug");
		CreateNewStaticMeshAssetFromMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewStaticMeshAssetFromMesh_ReturnValue_PropertyAddress, CreateNewStaticMeshAssetFromMesh_FunctionAddress, "ReturnValue");
		CreateNewStaticMeshAssetFromMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "ReturnValue");
		CreateNewStaticMeshAssetFromMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewStaticMeshAssetFromMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateNewStaticMeshAssetFromMesh_IsValid = CreateNewStaticMeshAssetFromMesh_FunctionAddress != IntPtr.Zero && CreateNewStaticMeshAssetFromMesh_FromDynamicMesh_IsValid && CreateNewStaticMeshAssetFromMesh_AssetPathAndName_IsValid && CreateNewStaticMeshAssetFromMesh_Options_IsValid && CreateNewStaticMeshAssetFromMesh_Outcome_IsValid && CreateNewStaticMeshAssetFromMesh_Debug_IsValid && CreateNewStaticMeshAssetFromMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingEditor.GeometryScriptLibrary_CreateNewAssetFunctions:CreateNewStaticMeshAssetFromMesh", CreateNewStaticMeshAssetFromMesh_IsValid);
	}
}
