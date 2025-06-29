using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_Collision : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetStaticMeshCollisionFromMesh_IsValid;

	private static IntPtr SetStaticMeshCollisionFromMesh_FunctionAddress;

	private static int SetStaticMeshCollisionFromMesh_ParamsSize;

	private static bool SetStaticMeshCollisionFromMesh_FromDynamicMesh_IsValid;

	private static FFieldAddress SetStaticMeshCollisionFromMesh_FromDynamicMesh_PropertyAddress;

	private static int SetStaticMeshCollisionFromMesh_FromDynamicMesh_Offset;

	private static bool SetStaticMeshCollisionFromMesh_ToStaticMeshAsset_IsValid;

	private static FFieldAddress SetStaticMeshCollisionFromMesh_ToStaticMeshAsset_PropertyAddress;

	private static int SetStaticMeshCollisionFromMesh_ToStaticMeshAsset_Offset;

	private static bool SetStaticMeshCollisionFromMesh_Options_IsValid;

	private static FFieldAddress SetStaticMeshCollisionFromMesh_Options_PropertyAddress;

	private static int SetStaticMeshCollisionFromMesh_Options_Offset;

	private static bool SetStaticMeshCollisionFromMesh_Debug_IsValid;

	private static FFieldAddress SetStaticMeshCollisionFromMesh_Debug_PropertyAddress;

	private static int SetStaticMeshCollisionFromMesh_Debug_Offset;

	private static bool SetStaticMeshCollisionFromMesh_ReturnValue_IsValid;

	private static FFieldAddress SetStaticMeshCollisionFromMesh_ReturnValue_PropertyAddress;

	private static int SetStaticMeshCollisionFromMesh_ReturnValue_Offset;

	private static bool SetStaticMeshCollisionFromComponent_IsValid;

	private static IntPtr SetStaticMeshCollisionFromComponent_FunctionAddress;

	private static int SetStaticMeshCollisionFromComponent_ParamsSize;

	private static bool SetStaticMeshCollisionFromComponent_StaticMeshAsset_IsValid;

	private static FFieldAddress SetStaticMeshCollisionFromComponent_StaticMeshAsset_PropertyAddress;

	private static int SetStaticMeshCollisionFromComponent_StaticMeshAsset_Offset;

	private static bool SetStaticMeshCollisionFromComponent_SourceComponent_IsValid;

	private static FFieldAddress SetStaticMeshCollisionFromComponent_SourceComponent_PropertyAddress;

	private static int SetStaticMeshCollisionFromComponent_SourceComponent_Offset;

	private static bool SetStaticMeshCollisionFromComponent_Options_IsValid;

	private static FFieldAddress SetStaticMeshCollisionFromComponent_Options_PropertyAddress;

	private static int SetStaticMeshCollisionFromComponent_Options_Offset;

	private static bool SetStaticMeshCollisionFromComponent_Debug_IsValid;

	private static FFieldAddress SetStaticMeshCollisionFromComponent_Debug_PropertyAddress;

	private static int SetStaticMeshCollisionFromComponent_Debug_Offset;

	private static bool SetDynamicMeshCollisionFromMesh_IsValid;

	private static IntPtr SetDynamicMeshCollisionFromMesh_FunctionAddress;

	private static int SetDynamicMeshCollisionFromMesh_ParamsSize;

	private static bool SetDynamicMeshCollisionFromMesh_FromDynamicMesh_IsValid;

	private static FFieldAddress SetDynamicMeshCollisionFromMesh_FromDynamicMesh_PropertyAddress;

	private static int SetDynamicMeshCollisionFromMesh_FromDynamicMesh_Offset;

	private static bool SetDynamicMeshCollisionFromMesh_ToDynamicMeshComponent_IsValid;

	private static FFieldAddress SetDynamicMeshCollisionFromMesh_ToDynamicMeshComponent_PropertyAddress;

	private static int SetDynamicMeshCollisionFromMesh_ToDynamicMeshComponent_Offset;

	private static bool SetDynamicMeshCollisionFromMesh_Options_IsValid;

	private static FFieldAddress SetDynamicMeshCollisionFromMesh_Options_PropertyAddress;

	private static int SetDynamicMeshCollisionFromMesh_Options_Offset;

	private static bool SetDynamicMeshCollisionFromMesh_Debug_IsValid;

	private static FFieldAddress SetDynamicMeshCollisionFromMesh_Debug_PropertyAddress;

	private static int SetDynamicMeshCollisionFromMesh_Debug_Offset;

	private static bool SetDynamicMeshCollisionFromMesh_ReturnValue_IsValid;

	private static FFieldAddress SetDynamicMeshCollisionFromMesh_ReturnValue_PropertyAddress;

	private static int SetDynamicMeshCollisionFromMesh_ReturnValue_Offset;

	private static bool ResetDynamicMeshCollision_IsValid;

	private static IntPtr ResetDynamicMeshCollision_FunctionAddress;

	private static int ResetDynamicMeshCollision_ParamsSize;

	private static bool ResetDynamicMeshCollision_Component_IsValid;

	private static FFieldAddress ResetDynamicMeshCollision_Component_PropertyAddress;

	private static int ResetDynamicMeshCollision_Component_Offset;

	private static bool ResetDynamicMeshCollision_bEmitTransaction_IsValid;

	private static FFieldAddress ResetDynamicMeshCollision_bEmitTransaction_PropertyAddress;

	private static int ResetDynamicMeshCollision_bEmitTransaction_Offset;

	private static bool ResetDynamicMeshCollision_Debug_IsValid;

	private static FFieldAddress ResetDynamicMeshCollision_Debug_PropertyAddress;

	private static int ResetDynamicMeshCollision_Debug_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:SetStaticMeshCollisionFromMesh")]
	public unsafe static UDynamicMesh SetStaticMeshCollisionFromMesh(UDynamicMesh FromDynamicMesh, UStaticMesh ToStaticMeshAsset, FGeometryScriptCollisionFromMeshOptions Options, UGeometryScriptDebug Debug)
	{
		if (!SetStaticMeshCollisionFromMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:SetStaticMeshCollisionFromMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMeshCollisionFromMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMeshCollisionFromMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetStaticMeshCollisionFromMesh_FromDynamicMesh_Offset), 0, SetStaticMeshCollisionFromMesh_FromDynamicMesh_PropertyAddress.Address, FromDynamicMesh);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetStaticMeshCollisionFromMesh_ToStaticMeshAsset_Offset), 0, SetStaticMeshCollisionFromMesh_ToStaticMeshAsset_PropertyAddress.Address, ToStaticMeshAsset);
		NativeReflection.InitializeValue_InContainer(SetStaticMeshCollisionFromMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptCollisionFromMeshOptions.ToNative(IntPtr.Add(intPtr, SetStaticMeshCollisionFromMesh_Options_Offset), 0, SetStaticMeshCollisionFromMesh_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetStaticMeshCollisionFromMesh_Debug_Offset), 0, SetStaticMeshCollisionFromMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStaticMeshCollisionFromMesh_FunctionAddress, intPtr, SetStaticMeshCollisionFromMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetStaticMeshCollisionFromMesh_ReturnValue_Offset), 0, SetStaticMeshCollisionFromMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:SetStaticMeshCollisionFromComponent")]
	public unsafe static void SetStaticMeshCollisionFromComponent(UStaticMesh StaticMeshAsset, UPrimitiveComponent SourceComponent, FGeometryScriptSetSimpleCollisionOptions Options, UGeometryScriptDebug Debug)
	{
		if (!SetStaticMeshCollisionFromComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:SetStaticMeshCollisionFromComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMeshCollisionFromComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMeshCollisionFromComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetStaticMeshCollisionFromComponent_StaticMeshAsset_Offset), 0, SetStaticMeshCollisionFromComponent_StaticMeshAsset_PropertyAddress.Address, StaticMeshAsset);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, SetStaticMeshCollisionFromComponent_SourceComponent_Offset), 0, SetStaticMeshCollisionFromComponent_SourceComponent_PropertyAddress.Address, SourceComponent);
		NativeReflection.InitializeValue_InContainer(SetStaticMeshCollisionFromComponent_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptSetSimpleCollisionOptions.ToNative(IntPtr.Add(intPtr, SetStaticMeshCollisionFromComponent_Options_Offset), 0, SetStaticMeshCollisionFromComponent_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetStaticMeshCollisionFromComponent_Debug_Offset), 0, SetStaticMeshCollisionFromComponent_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStaticMeshCollisionFromComponent_FunctionAddress, intPtr, SetStaticMeshCollisionFromComponent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:SetDynamicMeshCollisionFromMesh")]
	public unsafe static UDynamicMesh SetDynamicMeshCollisionFromMesh(UDynamicMesh FromDynamicMesh, UDynamicMeshComponent ToDynamicMeshComponent, FGeometryScriptCollisionFromMeshOptions Options, UGeometryScriptDebug Debug)
	{
		if (!SetDynamicMeshCollisionFromMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:SetDynamicMeshCollisionFromMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicMeshCollisionFromMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicMeshCollisionFromMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetDynamicMeshCollisionFromMesh_FromDynamicMesh_Offset), 0, SetDynamicMeshCollisionFromMesh_FromDynamicMesh_PropertyAddress.Address, FromDynamicMesh);
		UObjectMarshaler<UDynamicMeshComponent>.ToNative(IntPtr.Add(intPtr, SetDynamicMeshCollisionFromMesh_ToDynamicMeshComponent_Offset), 0, SetDynamicMeshCollisionFromMesh_ToDynamicMeshComponent_PropertyAddress.Address, ToDynamicMeshComponent);
		NativeReflection.InitializeValue_InContainer(SetDynamicMeshCollisionFromMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptCollisionFromMeshOptions.ToNative(IntPtr.Add(intPtr, SetDynamicMeshCollisionFromMesh_Options_Offset), 0, SetDynamicMeshCollisionFromMesh_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetDynamicMeshCollisionFromMesh_Debug_Offset), 0, SetDynamicMeshCollisionFromMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDynamicMeshCollisionFromMesh_FunctionAddress, intPtr, SetDynamicMeshCollisionFromMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetDynamicMeshCollisionFromMesh_ReturnValue_Offset), 0, SetDynamicMeshCollisionFromMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:ResetDynamicMeshCollision")]
	public unsafe static void ResetDynamicMeshCollision(UDynamicMeshComponent Component, bool bEmitTransaction, UGeometryScriptDebug Debug)
	{
		if (!ResetDynamicMeshCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:ResetDynamicMeshCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetDynamicMeshCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetDynamicMeshCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMeshComponent>.ToNative(IntPtr.Add(intPtr, ResetDynamicMeshCollision_Component_Offset), 0, ResetDynamicMeshCollision_Component_PropertyAddress.Address, Component);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ResetDynamicMeshCollision_bEmitTransaction_Offset), 0, ResetDynamicMeshCollision_bEmitTransaction_PropertyAddress.Address, bEmitTransaction);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ResetDynamicMeshCollision_Debug_Offset), 0, ResetDynamicMeshCollision_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetDynamicMeshCollision_FunctionAddress, intPtr, ResetDynamicMeshCollision_ParamsSize);
	}

	static UGeometryScript_Collision()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_Collision)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_Collision));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions");
		SetStaticMeshCollisionFromMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStaticMeshCollisionFromMesh");
		SetStaticMeshCollisionFromMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMeshCollisionFromMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshCollisionFromMesh_FromDynamicMesh_PropertyAddress, SetStaticMeshCollisionFromMesh_FunctionAddress, "FromDynamicMesh");
		SetStaticMeshCollisionFromMesh_FromDynamicMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshCollisionFromMesh_FunctionAddress, "FromDynamicMesh");
		SetStaticMeshCollisionFromMesh_FromDynamicMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshCollisionFromMesh_FunctionAddress, "FromDynamicMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshCollisionFromMesh_ToStaticMeshAsset_PropertyAddress, SetStaticMeshCollisionFromMesh_FunctionAddress, "ToStaticMeshAsset");
		SetStaticMeshCollisionFromMesh_ToStaticMeshAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshCollisionFromMesh_FunctionAddress, "ToStaticMeshAsset");
		SetStaticMeshCollisionFromMesh_ToStaticMeshAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshCollisionFromMesh_FunctionAddress, "ToStaticMeshAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshCollisionFromMesh_Options_PropertyAddress, SetStaticMeshCollisionFromMesh_FunctionAddress, "Options");
		SetStaticMeshCollisionFromMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshCollisionFromMesh_FunctionAddress, "Options");
		SetStaticMeshCollisionFromMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshCollisionFromMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshCollisionFromMesh_Debug_PropertyAddress, SetStaticMeshCollisionFromMesh_FunctionAddress, "Debug");
		SetStaticMeshCollisionFromMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshCollisionFromMesh_FunctionAddress, "Debug");
		SetStaticMeshCollisionFromMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshCollisionFromMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshCollisionFromMesh_ReturnValue_PropertyAddress, SetStaticMeshCollisionFromMesh_FunctionAddress, "ReturnValue");
		SetStaticMeshCollisionFromMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshCollisionFromMesh_FunctionAddress, "ReturnValue");
		SetStaticMeshCollisionFromMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshCollisionFromMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetStaticMeshCollisionFromMesh_IsValid = SetStaticMeshCollisionFromMesh_FunctionAddress != IntPtr.Zero && SetStaticMeshCollisionFromMesh_FromDynamicMesh_IsValid && SetStaticMeshCollisionFromMesh_ToStaticMeshAsset_IsValid && SetStaticMeshCollisionFromMesh_Options_IsValid && SetStaticMeshCollisionFromMesh_Debug_IsValid && SetStaticMeshCollisionFromMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:SetStaticMeshCollisionFromMesh", SetStaticMeshCollisionFromMesh_IsValid);
		SetStaticMeshCollisionFromComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStaticMeshCollisionFromComponent");
		SetStaticMeshCollisionFromComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMeshCollisionFromComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshCollisionFromComponent_StaticMeshAsset_PropertyAddress, SetStaticMeshCollisionFromComponent_FunctionAddress, "StaticMeshAsset");
		SetStaticMeshCollisionFromComponent_StaticMeshAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshCollisionFromComponent_FunctionAddress, "StaticMeshAsset");
		SetStaticMeshCollisionFromComponent_StaticMeshAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshCollisionFromComponent_FunctionAddress, "StaticMeshAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshCollisionFromComponent_SourceComponent_PropertyAddress, SetStaticMeshCollisionFromComponent_FunctionAddress, "SourceComponent");
		SetStaticMeshCollisionFromComponent_SourceComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshCollisionFromComponent_FunctionAddress, "SourceComponent");
		SetStaticMeshCollisionFromComponent_SourceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshCollisionFromComponent_FunctionAddress, "SourceComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshCollisionFromComponent_Options_PropertyAddress, SetStaticMeshCollisionFromComponent_FunctionAddress, "Options");
		SetStaticMeshCollisionFromComponent_Options_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshCollisionFromComponent_FunctionAddress, "Options");
		SetStaticMeshCollisionFromComponent_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshCollisionFromComponent_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshCollisionFromComponent_Debug_PropertyAddress, SetStaticMeshCollisionFromComponent_FunctionAddress, "Debug");
		SetStaticMeshCollisionFromComponent_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshCollisionFromComponent_FunctionAddress, "Debug");
		SetStaticMeshCollisionFromComponent_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshCollisionFromComponent_FunctionAddress, "Debug", Classes.FObjectProperty);
		SetStaticMeshCollisionFromComponent_IsValid = SetStaticMeshCollisionFromComponent_FunctionAddress != IntPtr.Zero && SetStaticMeshCollisionFromComponent_StaticMeshAsset_IsValid && SetStaticMeshCollisionFromComponent_SourceComponent_IsValid && SetStaticMeshCollisionFromComponent_Options_IsValid && SetStaticMeshCollisionFromComponent_Debug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:SetStaticMeshCollisionFromComponent", SetStaticMeshCollisionFromComponent_IsValid);
		SetDynamicMeshCollisionFromMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDynamicMeshCollisionFromMesh");
		SetDynamicMeshCollisionFromMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicMeshCollisionFromMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicMeshCollisionFromMesh_FromDynamicMesh_PropertyAddress, SetDynamicMeshCollisionFromMesh_FunctionAddress, "FromDynamicMesh");
		SetDynamicMeshCollisionFromMesh_FromDynamicMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicMeshCollisionFromMesh_FunctionAddress, "FromDynamicMesh");
		SetDynamicMeshCollisionFromMesh_FromDynamicMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicMeshCollisionFromMesh_FunctionAddress, "FromDynamicMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicMeshCollisionFromMesh_ToDynamicMeshComponent_PropertyAddress, SetDynamicMeshCollisionFromMesh_FunctionAddress, "ToDynamicMeshComponent");
		SetDynamicMeshCollisionFromMesh_ToDynamicMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicMeshCollisionFromMesh_FunctionAddress, "ToDynamicMeshComponent");
		SetDynamicMeshCollisionFromMesh_ToDynamicMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicMeshCollisionFromMesh_FunctionAddress, "ToDynamicMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicMeshCollisionFromMesh_Options_PropertyAddress, SetDynamicMeshCollisionFromMesh_FunctionAddress, "Options");
		SetDynamicMeshCollisionFromMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicMeshCollisionFromMesh_FunctionAddress, "Options");
		SetDynamicMeshCollisionFromMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicMeshCollisionFromMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicMeshCollisionFromMesh_Debug_PropertyAddress, SetDynamicMeshCollisionFromMesh_FunctionAddress, "Debug");
		SetDynamicMeshCollisionFromMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicMeshCollisionFromMesh_FunctionAddress, "Debug");
		SetDynamicMeshCollisionFromMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicMeshCollisionFromMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicMeshCollisionFromMesh_ReturnValue_PropertyAddress, SetDynamicMeshCollisionFromMesh_FunctionAddress, "ReturnValue");
		SetDynamicMeshCollisionFromMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicMeshCollisionFromMesh_FunctionAddress, "ReturnValue");
		SetDynamicMeshCollisionFromMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicMeshCollisionFromMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetDynamicMeshCollisionFromMesh_IsValid = SetDynamicMeshCollisionFromMesh_FunctionAddress != IntPtr.Zero && SetDynamicMeshCollisionFromMesh_FromDynamicMesh_IsValid && SetDynamicMeshCollisionFromMesh_ToDynamicMeshComponent_IsValid && SetDynamicMeshCollisionFromMesh_Options_IsValid && SetDynamicMeshCollisionFromMesh_Debug_IsValid && SetDynamicMeshCollisionFromMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:SetDynamicMeshCollisionFromMesh", SetDynamicMeshCollisionFromMesh_IsValid);
		ResetDynamicMeshCollision_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetDynamicMeshCollision");
		ResetDynamicMeshCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetDynamicMeshCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetDynamicMeshCollision_Component_PropertyAddress, ResetDynamicMeshCollision_FunctionAddress, "Component");
		ResetDynamicMeshCollision_Component_Offset = NativeReflectionCached.GetPropertyOffset(ResetDynamicMeshCollision_FunctionAddress, "Component");
		ResetDynamicMeshCollision_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetDynamicMeshCollision_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetDynamicMeshCollision_bEmitTransaction_PropertyAddress, ResetDynamicMeshCollision_FunctionAddress, "bEmitTransaction");
		ResetDynamicMeshCollision_bEmitTransaction_Offset = NativeReflectionCached.GetPropertyOffset(ResetDynamicMeshCollision_FunctionAddress, "bEmitTransaction");
		ResetDynamicMeshCollision_bEmitTransaction_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetDynamicMeshCollision_FunctionAddress, "bEmitTransaction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetDynamicMeshCollision_Debug_PropertyAddress, ResetDynamicMeshCollision_FunctionAddress, "Debug");
		ResetDynamicMeshCollision_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ResetDynamicMeshCollision_FunctionAddress, "Debug");
		ResetDynamicMeshCollision_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetDynamicMeshCollision_FunctionAddress, "Debug", Classes.FObjectProperty);
		ResetDynamicMeshCollision_IsValid = ResetDynamicMeshCollision_FunctionAddress != IntPtr.Zero && ResetDynamicMeshCollision_Component_IsValid && ResetDynamicMeshCollision_bEmitTransaction_IsValid && ResetDynamicMeshCollision_Debug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_CollisionFunctions:ResetDynamicMeshCollision", ResetDynamicMeshCollision_IsValid);
	}
}
