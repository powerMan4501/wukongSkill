using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_AssetUtils : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetSectionMaterialListFromStaticMesh_IsValid;

	private static IntPtr GetSectionMaterialListFromStaticMesh_FunctionAddress;

	private static int GetSectionMaterialListFromStaticMesh_ParamsSize;

	private static bool GetSectionMaterialListFromStaticMesh_FromStaticMeshAsset_IsValid;

	private static FFieldAddress GetSectionMaterialListFromStaticMesh_FromStaticMeshAsset_PropertyAddress;

	private static int GetSectionMaterialListFromStaticMesh_FromStaticMeshAsset_Offset;

	private static bool GetSectionMaterialListFromStaticMesh_RequestedLOD_IsValid;

	private static FFieldAddress GetSectionMaterialListFromStaticMesh_RequestedLOD_PropertyAddress;

	private static int GetSectionMaterialListFromStaticMesh_RequestedLOD_Offset;

	private static bool GetSectionMaterialListFromStaticMesh_MaterialList_IsValid;

	private static FFieldAddress GetSectionMaterialListFromStaticMesh_MaterialList_PropertyAddress;

	private static int GetSectionMaterialListFromStaticMesh_MaterialList_Offset;

	private static bool GetSectionMaterialListFromStaticMesh_MaterialIndex_IsValid;

	private static FFieldAddress GetSectionMaterialListFromStaticMesh_MaterialIndex_PropertyAddress;

	private static int GetSectionMaterialListFromStaticMesh_MaterialIndex_Offset;

	private static bool GetSectionMaterialListFromStaticMesh_Outcome_IsValid;

	private static FFieldAddress GetSectionMaterialListFromStaticMesh_Outcome_PropertyAddress;

	private static int GetSectionMaterialListFromStaticMesh_Outcome_Offset;

	private static bool GetSectionMaterialListFromStaticMesh_Debug_IsValid;

	private static FFieldAddress GetSectionMaterialListFromStaticMesh_Debug_PropertyAddress;

	private static int GetSectionMaterialListFromStaticMesh_Debug_Offset;

	private static bool CopyMeshToStaticMesh_IsValid;

	private static IntPtr CopyMeshToStaticMesh_FunctionAddress;

	private static int CopyMeshToStaticMesh_ParamsSize;

	private static bool CopyMeshToStaticMesh_FromDynamicMesh_IsValid;

	private static FFieldAddress CopyMeshToStaticMesh_FromDynamicMesh_PropertyAddress;

	private static int CopyMeshToStaticMesh_FromDynamicMesh_Offset;

	private static bool CopyMeshToStaticMesh_ToStaticMeshAsset_IsValid;

	private static FFieldAddress CopyMeshToStaticMesh_ToStaticMeshAsset_PropertyAddress;

	private static int CopyMeshToStaticMesh_ToStaticMeshAsset_Offset;

	private static bool CopyMeshToStaticMesh_Options_IsValid;

	private static FFieldAddress CopyMeshToStaticMesh_Options_PropertyAddress;

	private static int CopyMeshToStaticMesh_Options_Offset;

	private static bool CopyMeshToStaticMesh_TargetLOD_IsValid;

	private static FFieldAddress CopyMeshToStaticMesh_TargetLOD_PropertyAddress;

	private static int CopyMeshToStaticMesh_TargetLOD_Offset;

	private static bool CopyMeshToStaticMesh_Outcome_IsValid;

	private static FFieldAddress CopyMeshToStaticMesh_Outcome_PropertyAddress;

	private static int CopyMeshToStaticMesh_Outcome_Offset;

	private static bool CopyMeshToStaticMesh_Debug_IsValid;

	private static FFieldAddress CopyMeshToStaticMesh_Debug_PropertyAddress;

	private static int CopyMeshToStaticMesh_Debug_Offset;

	private static bool CopyMeshToStaticMesh_ReturnValue_IsValid;

	private static FFieldAddress CopyMeshToStaticMesh_ReturnValue_PropertyAddress;

	private static int CopyMeshToStaticMesh_ReturnValue_Offset;

	private static bool CopyMeshFromStaticMesh_IsValid;

	private static IntPtr CopyMeshFromStaticMesh_FunctionAddress;

	private static int CopyMeshFromStaticMesh_ParamsSize;

	private static bool CopyMeshFromStaticMesh_FromStaticMeshAsset_IsValid;

	private static FFieldAddress CopyMeshFromStaticMesh_FromStaticMeshAsset_PropertyAddress;

	private static int CopyMeshFromStaticMesh_FromStaticMeshAsset_Offset;

	private static bool CopyMeshFromStaticMesh_ToDynamicMesh_IsValid;

	private static FFieldAddress CopyMeshFromStaticMesh_ToDynamicMesh_PropertyAddress;

	private static int CopyMeshFromStaticMesh_ToDynamicMesh_Offset;

	private static bool CopyMeshFromStaticMesh_AssetOptions_IsValid;

	private static FFieldAddress CopyMeshFromStaticMesh_AssetOptions_PropertyAddress;

	private static int CopyMeshFromStaticMesh_AssetOptions_Offset;

	private static bool CopyMeshFromStaticMesh_RequestedLOD_IsValid;

	private static FFieldAddress CopyMeshFromStaticMesh_RequestedLOD_PropertyAddress;

	private static int CopyMeshFromStaticMesh_RequestedLOD_Offset;

	private static bool CopyMeshFromStaticMesh_Outcome_IsValid;

	private static FFieldAddress CopyMeshFromStaticMesh_Outcome_PropertyAddress;

	private static int CopyMeshFromStaticMesh_Outcome_Offset;

	private static bool CopyMeshFromStaticMesh_Debug_IsValid;

	private static FFieldAddress CopyMeshFromStaticMesh_Debug_PropertyAddress;

	private static int CopyMeshFromStaticMesh_Debug_Offset;

	private static bool CopyMeshFromStaticMesh_ReturnValue_IsValid;

	private static FFieldAddress CopyMeshFromStaticMesh_ReturnValue_PropertyAddress;

	private static int CopyMeshFromStaticMesh_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions:GetSectionMaterialListFromStaticMesh")]
	public unsafe static void GetSectionMaterialListFromStaticMesh(UStaticMesh FromStaticMeshAsset, FGeometryScriptMeshReadLOD RequestedLOD, out List<UMaterialInterface> MaterialList, out List<int> MaterialIndex, out EGeometryScriptOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!GetSectionMaterialListFromStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions:GetSectionMaterialListFromStaticMesh");
			MaterialList = null;
			MaterialIndex = null;
			Outcome = EGeometryScriptOutcomePins.Failure;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSectionMaterialListFromStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSectionMaterialListFromStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetSectionMaterialListFromStaticMesh_FromStaticMeshAsset_Offset), 0, GetSectionMaterialListFromStaticMesh_FromStaticMeshAsset_PropertyAddress.Address, FromStaticMeshAsset);
		NativeReflection.InitializeValue_InContainer(GetSectionMaterialListFromStaticMesh_RequestedLOD_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshReadLOD.ToNative(IntPtr.Add(intPtr, GetSectionMaterialListFromStaticMesh_RequestedLOD_Offset), 0, GetSectionMaterialListFromStaticMesh_RequestedLOD_PropertyAddress.Address, RequestedLOD);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, GetSectionMaterialListFromStaticMesh_Debug_Offset), 0, GetSectionMaterialListFromStaticMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSectionMaterialListFromStaticMesh_FunctionAddress, intPtr, GetSectionMaterialListFromStaticMesh_ParamsSize);
		MaterialList = new TArrayCopyMarshaler<UMaterialInterface>(1, GetSectionMaterialListFromStaticMesh_MaterialList_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionMaterialListFromStaticMesh_MaterialList_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionMaterialListFromStaticMesh_MaterialList_PropertyAddress.Address, intPtr);
		MaterialIndex = new TArrayCopyMarshaler<int>(1, GetSectionMaterialListFromStaticMesh_MaterialIndex_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSectionMaterialListFromStaticMesh_MaterialIndex_Offset));
		NativeReflection.DestroyValue_InContainer(GetSectionMaterialListFromStaticMesh_MaterialIndex_PropertyAddress.Address, intPtr);
		Outcome = EnumMarshaler<EGeometryScriptOutcomePins>.FromNative(IntPtr.Add(intPtr, GetSectionMaterialListFromStaticMesh_Outcome_Offset), 0, GetSectionMaterialListFromStaticMesh_Outcome_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions:CopyMeshToStaticMesh")]
	public unsafe static UDynamicMesh CopyMeshToStaticMesh(UDynamicMesh FromDynamicMesh, UStaticMesh ToStaticMeshAsset, FGeometryScriptCopyMeshToAssetOptions Options, FGeometryScriptMeshWriteLOD TargetLOD, out EGeometryScriptOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!CopyMeshToStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions:CopyMeshToStaticMesh");
			Outcome = EGeometryScriptOutcomePins.Failure;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyMeshToStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyMeshToStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CopyMeshToStaticMesh_FromDynamicMesh_Offset), 0, CopyMeshToStaticMesh_FromDynamicMesh_PropertyAddress.Address, FromDynamicMesh);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, CopyMeshToStaticMesh_ToStaticMeshAsset_Offset), 0, CopyMeshToStaticMesh_ToStaticMeshAsset_PropertyAddress.Address, ToStaticMeshAsset);
		NativeReflection.InitializeValue_InContainer(CopyMeshToStaticMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptCopyMeshToAssetOptions.ToNative(IntPtr.Add(intPtr, CopyMeshToStaticMesh_Options_Offset), 0, CopyMeshToStaticMesh_Options_PropertyAddress.Address, Options);
		NativeReflection.InitializeValue_InContainer(CopyMeshToStaticMesh_TargetLOD_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshWriteLOD.ToNative(IntPtr.Add(intPtr, CopyMeshToStaticMesh_TargetLOD_Offset), 0, CopyMeshToStaticMesh_TargetLOD_PropertyAddress.Address, TargetLOD);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CopyMeshToStaticMesh_Debug_Offset), 0, CopyMeshToStaticMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyMeshToStaticMesh_FunctionAddress, intPtr, CopyMeshToStaticMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CopyMeshToStaticMesh_Options_PropertyAddress.Address, intPtr);
		Outcome = EnumMarshaler<EGeometryScriptOutcomePins>.FromNative(IntPtr.Add(intPtr, CopyMeshToStaticMesh_Outcome_Offset), 0, CopyMeshToStaticMesh_Outcome_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CopyMeshToStaticMesh_ReturnValue_Offset), 0, CopyMeshToStaticMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions:CopyMeshFromStaticMesh")]
	public unsafe static UDynamicMesh CopyMeshFromStaticMesh(UStaticMesh FromStaticMeshAsset, UDynamicMesh ToDynamicMesh, FGeometryScriptCopyMeshFromAssetOptions AssetOptions, FGeometryScriptMeshReadLOD RequestedLOD, out EGeometryScriptOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!CopyMeshFromStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions:CopyMeshFromStaticMesh");
			Outcome = EGeometryScriptOutcomePins.Failure;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyMeshFromStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyMeshFromStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, CopyMeshFromStaticMesh_FromStaticMeshAsset_Offset), 0, CopyMeshFromStaticMesh_FromStaticMeshAsset_PropertyAddress.Address, FromStaticMeshAsset);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CopyMeshFromStaticMesh_ToDynamicMesh_Offset), 0, CopyMeshFromStaticMesh_ToDynamicMesh_PropertyAddress.Address, ToDynamicMesh);
		NativeReflection.InitializeValue_InContainer(CopyMeshFromStaticMesh_AssetOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptCopyMeshFromAssetOptions.ToNative(IntPtr.Add(intPtr, CopyMeshFromStaticMesh_AssetOptions_Offset), 0, CopyMeshFromStaticMesh_AssetOptions_PropertyAddress.Address, AssetOptions);
		NativeReflection.InitializeValue_InContainer(CopyMeshFromStaticMesh_RequestedLOD_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshReadLOD.ToNative(IntPtr.Add(intPtr, CopyMeshFromStaticMesh_RequestedLOD_Offset), 0, CopyMeshFromStaticMesh_RequestedLOD_PropertyAddress.Address, RequestedLOD);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CopyMeshFromStaticMesh_Debug_Offset), 0, CopyMeshFromStaticMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyMeshFromStaticMesh_FunctionAddress, intPtr, CopyMeshFromStaticMesh_ParamsSize);
		Outcome = EnumMarshaler<EGeometryScriptOutcomePins>.FromNative(IntPtr.Add(intPtr, CopyMeshFromStaticMesh_Outcome_Offset), 0, CopyMeshFromStaticMesh_Outcome_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CopyMeshFromStaticMesh_ReturnValue_Offset), 0, CopyMeshFromStaticMesh_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_AssetUtils()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_AssetUtils)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_AssetUtils));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions");
		GetSectionMaterialListFromStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSectionMaterialListFromStaticMesh");
		GetSectionMaterialListFromStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSectionMaterialListFromStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSectionMaterialListFromStaticMesh_FromStaticMeshAsset_PropertyAddress, GetSectionMaterialListFromStaticMesh_FunctionAddress, "FromStaticMeshAsset");
		GetSectionMaterialListFromStaticMesh_FromStaticMeshAsset_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionMaterialListFromStaticMesh_FunctionAddress, "FromStaticMeshAsset");
		GetSectionMaterialListFromStaticMesh_FromStaticMeshAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionMaterialListFromStaticMesh_FunctionAddress, "FromStaticMeshAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionMaterialListFromStaticMesh_RequestedLOD_PropertyAddress, GetSectionMaterialListFromStaticMesh_FunctionAddress, "RequestedLOD");
		GetSectionMaterialListFromStaticMesh_RequestedLOD_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionMaterialListFromStaticMesh_FunctionAddress, "RequestedLOD");
		GetSectionMaterialListFromStaticMesh_RequestedLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionMaterialListFromStaticMesh_FunctionAddress, "RequestedLOD", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionMaterialListFromStaticMesh_MaterialList_PropertyAddress, GetSectionMaterialListFromStaticMesh_FunctionAddress, "MaterialList");
		GetSectionMaterialListFromStaticMesh_MaterialList_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionMaterialListFromStaticMesh_FunctionAddress, "MaterialList");
		GetSectionMaterialListFromStaticMesh_MaterialList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionMaterialListFromStaticMesh_FunctionAddress, "MaterialList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionMaterialListFromStaticMesh_MaterialIndex_PropertyAddress, GetSectionMaterialListFromStaticMesh_FunctionAddress, "MaterialIndex");
		GetSectionMaterialListFromStaticMesh_MaterialIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionMaterialListFromStaticMesh_FunctionAddress, "MaterialIndex");
		GetSectionMaterialListFromStaticMesh_MaterialIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionMaterialListFromStaticMesh_FunctionAddress, "MaterialIndex", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionMaterialListFromStaticMesh_Outcome_PropertyAddress, GetSectionMaterialListFromStaticMesh_FunctionAddress, "Outcome");
		GetSectionMaterialListFromStaticMesh_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionMaterialListFromStaticMesh_FunctionAddress, "Outcome");
		GetSectionMaterialListFromStaticMesh_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionMaterialListFromStaticMesh_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionMaterialListFromStaticMesh_Debug_PropertyAddress, GetSectionMaterialListFromStaticMesh_FunctionAddress, "Debug");
		GetSectionMaterialListFromStaticMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionMaterialListFromStaticMesh_FunctionAddress, "Debug");
		GetSectionMaterialListFromStaticMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionMaterialListFromStaticMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		GetSectionMaterialListFromStaticMesh_IsValid = GetSectionMaterialListFromStaticMesh_FunctionAddress != IntPtr.Zero && GetSectionMaterialListFromStaticMesh_FromStaticMeshAsset_IsValid && GetSectionMaterialListFromStaticMesh_RequestedLOD_IsValid && GetSectionMaterialListFromStaticMesh_MaterialList_IsValid && GetSectionMaterialListFromStaticMesh_MaterialIndex_IsValid && GetSectionMaterialListFromStaticMesh_Outcome_IsValid && GetSectionMaterialListFromStaticMesh_Debug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions:GetSectionMaterialListFromStaticMesh", GetSectionMaterialListFromStaticMesh_IsValid);
		CopyMeshToStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyMeshToStaticMesh");
		CopyMeshToStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyMeshToStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToStaticMesh_FromDynamicMesh_PropertyAddress, CopyMeshToStaticMesh_FunctionAddress, "FromDynamicMesh");
		CopyMeshToStaticMesh_FromDynamicMesh_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToStaticMesh_FunctionAddress, "FromDynamicMesh");
		CopyMeshToStaticMesh_FromDynamicMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToStaticMesh_FunctionAddress, "FromDynamicMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToStaticMesh_ToStaticMeshAsset_PropertyAddress, CopyMeshToStaticMesh_FunctionAddress, "ToStaticMeshAsset");
		CopyMeshToStaticMesh_ToStaticMeshAsset_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToStaticMesh_FunctionAddress, "ToStaticMeshAsset");
		CopyMeshToStaticMesh_ToStaticMeshAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToStaticMesh_FunctionAddress, "ToStaticMeshAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToStaticMesh_Options_PropertyAddress, CopyMeshToStaticMesh_FunctionAddress, "Options");
		CopyMeshToStaticMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToStaticMesh_FunctionAddress, "Options");
		CopyMeshToStaticMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToStaticMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToStaticMesh_TargetLOD_PropertyAddress, CopyMeshToStaticMesh_FunctionAddress, "TargetLOD");
		CopyMeshToStaticMesh_TargetLOD_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToStaticMesh_FunctionAddress, "TargetLOD");
		CopyMeshToStaticMesh_TargetLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToStaticMesh_FunctionAddress, "TargetLOD", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToStaticMesh_Outcome_PropertyAddress, CopyMeshToStaticMesh_FunctionAddress, "Outcome");
		CopyMeshToStaticMesh_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToStaticMesh_FunctionAddress, "Outcome");
		CopyMeshToStaticMesh_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToStaticMesh_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToStaticMesh_Debug_PropertyAddress, CopyMeshToStaticMesh_FunctionAddress, "Debug");
		CopyMeshToStaticMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToStaticMesh_FunctionAddress, "Debug");
		CopyMeshToStaticMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToStaticMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToStaticMesh_ReturnValue_PropertyAddress, CopyMeshToStaticMesh_FunctionAddress, "ReturnValue");
		CopyMeshToStaticMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToStaticMesh_FunctionAddress, "ReturnValue");
		CopyMeshToStaticMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToStaticMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyMeshToStaticMesh_IsValid = CopyMeshToStaticMesh_FunctionAddress != IntPtr.Zero && CopyMeshToStaticMesh_FromDynamicMesh_IsValid && CopyMeshToStaticMesh_ToStaticMeshAsset_IsValid && CopyMeshToStaticMesh_Options_IsValid && CopyMeshToStaticMesh_TargetLOD_IsValid && CopyMeshToStaticMesh_Outcome_IsValid && CopyMeshToStaticMesh_Debug_IsValid && CopyMeshToStaticMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions:CopyMeshToStaticMesh", CopyMeshToStaticMesh_IsValid);
		CopyMeshFromStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyMeshFromStaticMesh");
		CopyMeshFromStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyMeshFromStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromStaticMesh_FromStaticMeshAsset_PropertyAddress, CopyMeshFromStaticMesh_FunctionAddress, "FromStaticMeshAsset");
		CopyMeshFromStaticMesh_FromStaticMeshAsset_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromStaticMesh_FunctionAddress, "FromStaticMeshAsset");
		CopyMeshFromStaticMesh_FromStaticMeshAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromStaticMesh_FunctionAddress, "FromStaticMeshAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromStaticMesh_ToDynamicMesh_PropertyAddress, CopyMeshFromStaticMesh_FunctionAddress, "ToDynamicMesh");
		CopyMeshFromStaticMesh_ToDynamicMesh_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromStaticMesh_FunctionAddress, "ToDynamicMesh");
		CopyMeshFromStaticMesh_ToDynamicMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromStaticMesh_FunctionAddress, "ToDynamicMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromStaticMesh_AssetOptions_PropertyAddress, CopyMeshFromStaticMesh_FunctionAddress, "AssetOptions");
		CopyMeshFromStaticMesh_AssetOptions_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromStaticMesh_FunctionAddress, "AssetOptions");
		CopyMeshFromStaticMesh_AssetOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromStaticMesh_FunctionAddress, "AssetOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromStaticMesh_RequestedLOD_PropertyAddress, CopyMeshFromStaticMesh_FunctionAddress, "RequestedLOD");
		CopyMeshFromStaticMesh_RequestedLOD_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromStaticMesh_FunctionAddress, "RequestedLOD");
		CopyMeshFromStaticMesh_RequestedLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromStaticMesh_FunctionAddress, "RequestedLOD", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromStaticMesh_Outcome_PropertyAddress, CopyMeshFromStaticMesh_FunctionAddress, "Outcome");
		CopyMeshFromStaticMesh_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromStaticMesh_FunctionAddress, "Outcome");
		CopyMeshFromStaticMesh_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromStaticMesh_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromStaticMesh_Debug_PropertyAddress, CopyMeshFromStaticMesh_FunctionAddress, "Debug");
		CopyMeshFromStaticMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromStaticMesh_FunctionAddress, "Debug");
		CopyMeshFromStaticMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromStaticMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshFromStaticMesh_ReturnValue_PropertyAddress, CopyMeshFromStaticMesh_FunctionAddress, "ReturnValue");
		CopyMeshFromStaticMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshFromStaticMesh_FunctionAddress, "ReturnValue");
		CopyMeshFromStaticMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshFromStaticMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyMeshFromStaticMesh_IsValid = CopyMeshFromStaticMesh_FunctionAddress != IntPtr.Zero && CopyMeshFromStaticMesh_FromStaticMeshAsset_IsValid && CopyMeshFromStaticMesh_ToDynamicMesh_IsValid && CopyMeshFromStaticMesh_AssetOptions_IsValid && CopyMeshFromStaticMesh_RequestedLOD_IsValid && CopyMeshFromStaticMesh_Outcome_IsValid && CopyMeshFromStaticMesh_Debug_IsValid && CopyMeshFromStaticMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_StaticMeshFunctions:CopyMeshFromStaticMesh", CopyMeshFromStaticMesh_IsValid);
	}
}
