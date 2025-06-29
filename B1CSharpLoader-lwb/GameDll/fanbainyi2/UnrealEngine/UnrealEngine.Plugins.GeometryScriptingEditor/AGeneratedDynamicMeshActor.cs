using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingEditor;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor", "GeometryScriptingEditor", UnrealModuleType.EnginePlugin)]
public class AGeneratedDynamicMeshActor : ADynamicMeshActor
{
	private static bool ResetOnRebuild_IsValid;

	private static FFieldAddress ResetOnRebuild_PropertyAddress;

	private static int ResetOnRebuild_Offset;

	private static bool OnRebuildGeneratedMesh_IsValid;

	private IntPtr OnRebuildGeneratedMesh_InstanceFunctionAddress;

	private static IntPtr OnRebuildGeneratedMesh_FunctionAddress;

	private static int OnRebuildGeneratedMesh_ParamsSize;

	private static bool OnRebuildGeneratedMesh_TargetMesh_IsValid;

	private static FFieldAddress OnRebuildGeneratedMesh_TargetMesh_PropertyAddress;

	private static int OnRebuildGeneratedMesh_TargetMesh_Offset;

	private static bool CopyPropertiesToStaticMesh_IsValid;

	private static IntPtr CopyPropertiesToStaticMesh_FunctionAddress;

	private static int CopyPropertiesToStaticMesh_ParamsSize;

	private static bool CopyPropertiesToStaticMesh_StaticMeshActor_IsValid;

	private static FFieldAddress CopyPropertiesToStaticMesh_StaticMeshActor_PropertyAddress;

	private static int CopyPropertiesToStaticMesh_StaticMeshActor_Offset;

	private static bool CopyPropertiesToStaticMesh_bCopyComponentMaterials_IsValid;

	private static FFieldAddress CopyPropertiesToStaticMesh_bCopyComponentMaterials_PropertyAddress;

	private static int CopyPropertiesToStaticMesh_bCopyComponentMaterials_Offset;

	private static bool CopyPropertiesFromStaticMesh_IsValid;

	private static IntPtr CopyPropertiesFromStaticMesh_FunctionAddress;

	private static int CopyPropertiesFromStaticMesh_ParamsSize;

	private static bool CopyPropertiesFromStaticMesh_StaticMeshActor_IsValid;

	private static FFieldAddress CopyPropertiesFromStaticMesh_StaticMeshActor_PropertyAddress;

	private static int CopyPropertiesFromStaticMesh_StaticMeshActor_Offset;

	private static bool CopyPropertiesFromStaticMesh_bCopyComponentMaterials_IsValid;

	private static FFieldAddress CopyPropertiesFromStaticMesh_bCopyComponentMaterials_PropertyAddress;

	private static int CopyPropertiesFromStaticMesh_bCopyComponentMaterials_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:bResetOnRebuild")]
	public bool ResetOnRebuild
	{
		get
		{
			CheckDestroyed();
			if (!ResetOnRebuild_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:bResetOnRebuild");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ResetOnRebuild_Offset), 0, ResetOnRebuild_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ResetOnRebuild_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:bResetOnRebuild");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ResetOnRebuild_Offset), 0, ResetOnRebuild_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:OnRebuildGeneratedMesh")]
	public unsafe void OnRebuildGeneratedMesh(UDynamicMesh TargetMesh)
	{
		CheckDestroyed();
		if (!OnRebuildGeneratedMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:OnRebuildGeneratedMesh");
			return;
		}
		if (OnRebuildGeneratedMesh_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRebuildGeneratedMesh_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRebuildGeneratedMesh");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRebuildGeneratedMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRebuildGeneratedMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, OnRebuildGeneratedMesh_TargetMesh_Offset), 0, OnRebuildGeneratedMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRebuildGeneratedMesh_InstanceFunctionAddress, intPtr, OnRebuildGeneratedMesh_ParamsSize);
	}

	protected unsafe virtual void OnRebuildGeneratedMesh_Implementation(UDynamicMesh TargetMesh)
	{
		CheckDestroyed();
		if (!OnRebuildGeneratedMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:OnRebuildGeneratedMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRebuildGeneratedMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRebuildGeneratedMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, OnRebuildGeneratedMesh_TargetMesh_Offset), 0, OnRebuildGeneratedMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRebuildGeneratedMesh_FunctionAddress, intPtr, OnRebuildGeneratedMesh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:CopyPropertiesToStaticMesh")]
	public unsafe void CopyPropertiesToStaticMesh(AStaticMeshActor StaticMeshActor, bool bCopyComponentMaterials = false)
	{
		CheckDestroyed();
		if (!CopyPropertiesToStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:CopyPropertiesToStaticMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyPropertiesToStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyPropertiesToStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AStaticMeshActor>.ToNative(IntPtr.Add(intPtr, CopyPropertiesToStaticMesh_StaticMeshActor_Offset), 0, CopyPropertiesToStaticMesh_StaticMeshActor_PropertyAddress.Address, StaticMeshActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyPropertiesToStaticMesh_bCopyComponentMaterials_Offset), 0, CopyPropertiesToStaticMesh_bCopyComponentMaterials_PropertyAddress.Address, bCopyComponentMaterials);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyPropertiesToStaticMesh_FunctionAddress, intPtr, CopyPropertiesToStaticMesh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:CopyPropertiesFromStaticMesh")]
	public unsafe void CopyPropertiesFromStaticMesh(AStaticMeshActor StaticMeshActor, bool bCopyComponentMaterials = false)
	{
		CheckDestroyed();
		if (!CopyPropertiesFromStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:CopyPropertiesFromStaticMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyPropertiesFromStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyPropertiesFromStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AStaticMeshActor>.ToNative(IntPtr.Add(intPtr, CopyPropertiesFromStaticMesh_StaticMeshActor_Offset), 0, CopyPropertiesFromStaticMesh_StaticMeshActor_PropertyAddress.Address, StaticMeshActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyPropertiesFromStaticMesh_bCopyComponentMaterials_Offset), 0, CopyPropertiesFromStaticMesh_bCopyComponentMaterials_PropertyAddress.Address, bCopyComponentMaterials);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyPropertiesFromStaticMesh_FunctionAddress, intPtr, CopyPropertiesFromStaticMesh_ParamsSize);
	}

	static AGeneratedDynamicMeshActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGeneratedDynamicMeshActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGeneratedDynamicMeshActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor");
		NativeReflectionCached.GetPropertyRef(ref ResetOnRebuild_PropertyAddress, intPtr, "bResetOnRebuild");
		ResetOnRebuild_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bResetOnRebuild");
		ResetOnRebuild_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bResetOnRebuild", Classes.FBoolProperty);
		OnRebuildGeneratedMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRebuildGeneratedMesh");
		OnRebuildGeneratedMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRebuildGeneratedMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRebuildGeneratedMesh_TargetMesh_PropertyAddress, OnRebuildGeneratedMesh_FunctionAddress, "TargetMesh");
		OnRebuildGeneratedMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(OnRebuildGeneratedMesh_FunctionAddress, "TargetMesh");
		OnRebuildGeneratedMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRebuildGeneratedMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		OnRebuildGeneratedMesh_IsValid = OnRebuildGeneratedMesh_FunctionAddress != IntPtr.Zero && OnRebuildGeneratedMesh_TargetMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:OnRebuildGeneratedMesh", OnRebuildGeneratedMesh_IsValid);
		CopyPropertiesToStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyPropertiesToStaticMesh");
		CopyPropertiesToStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPropertiesToStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyPropertiesToStaticMesh_StaticMeshActor_PropertyAddress, CopyPropertiesToStaticMesh_FunctionAddress, "StaticMeshActor");
		CopyPropertiesToStaticMesh_StaticMeshActor_Offset = NativeReflectionCached.GetPropertyOffset(CopyPropertiesToStaticMesh_FunctionAddress, "StaticMeshActor");
		CopyPropertiesToStaticMesh_StaticMeshActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPropertiesToStaticMesh_FunctionAddress, "StaticMeshActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPropertiesToStaticMesh_bCopyComponentMaterials_PropertyAddress, CopyPropertiesToStaticMesh_FunctionAddress, "bCopyComponentMaterials");
		CopyPropertiesToStaticMesh_bCopyComponentMaterials_Offset = NativeReflectionCached.GetPropertyOffset(CopyPropertiesToStaticMesh_FunctionAddress, "bCopyComponentMaterials");
		CopyPropertiesToStaticMesh_bCopyComponentMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPropertiesToStaticMesh_FunctionAddress, "bCopyComponentMaterials", Classes.FBoolProperty);
		CopyPropertiesToStaticMesh_IsValid = CopyPropertiesToStaticMesh_FunctionAddress != IntPtr.Zero && CopyPropertiesToStaticMesh_StaticMeshActor_IsValid && CopyPropertiesToStaticMesh_bCopyComponentMaterials_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:CopyPropertiesToStaticMesh", CopyPropertiesToStaticMesh_IsValid);
		CopyPropertiesFromStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyPropertiesFromStaticMesh");
		CopyPropertiesFromStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPropertiesFromStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyPropertiesFromStaticMesh_StaticMeshActor_PropertyAddress, CopyPropertiesFromStaticMesh_FunctionAddress, "StaticMeshActor");
		CopyPropertiesFromStaticMesh_StaticMeshActor_Offset = NativeReflectionCached.GetPropertyOffset(CopyPropertiesFromStaticMesh_FunctionAddress, "StaticMeshActor");
		CopyPropertiesFromStaticMesh_StaticMeshActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPropertiesFromStaticMesh_FunctionAddress, "StaticMeshActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPropertiesFromStaticMesh_bCopyComponentMaterials_PropertyAddress, CopyPropertiesFromStaticMesh_FunctionAddress, "bCopyComponentMaterials");
		CopyPropertiesFromStaticMesh_bCopyComponentMaterials_Offset = NativeReflectionCached.GetPropertyOffset(CopyPropertiesFromStaticMesh_FunctionAddress, "bCopyComponentMaterials");
		CopyPropertiesFromStaticMesh_bCopyComponentMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPropertiesFromStaticMesh_FunctionAddress, "bCopyComponentMaterials", Classes.FBoolProperty);
		CopyPropertiesFromStaticMesh_IsValid = CopyPropertiesFromStaticMesh_FunctionAddress != IntPtr.Zero && CopyPropertiesFromStaticMesh_StaticMeshActor_IsValid && CopyPropertiesFromStaticMesh_bCopyComponentMaterials_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingEditor.GeneratedDynamicMeshActor:CopyPropertiesFromStaticMesh", CopyPropertiesFromStaticMesh_IsValid);
	}
}
