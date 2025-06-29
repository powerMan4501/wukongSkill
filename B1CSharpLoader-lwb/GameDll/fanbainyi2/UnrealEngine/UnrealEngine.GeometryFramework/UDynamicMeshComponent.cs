using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent", "GeometryFramework", UnrealModuleType.Engine)]
public class UDynamicMeshComponent : UBaseDynamicMeshComponent, IInterface_CollisionDataProvider, IInterface
{
	private static bool CollisionType_IsValid;

	private static FFieldAddress CollisionType_PropertyAddress;

	private static int CollisionType_Offset;

	private static bool EnableComplexCollision_IsValid;

	private static FFieldAddress EnableComplexCollision_PropertyAddress;

	private static int EnableComplexCollision_Offset;

	private static bool DeferCollisionUpdates_IsValid;

	private static FFieldAddress DeferCollisionUpdates_PropertyAddress;

	private static int DeferCollisionUpdates_Offset;

	private static bool ValidateMaterialSlots_IsValid;

	private static IntPtr ValidateMaterialSlots_FunctionAddress;

	private static int ValidateMaterialSlots_ParamsSize;

	private static bool ValidateMaterialSlots_bCreateIfMissing_IsValid;

	private static FFieldAddress ValidateMaterialSlots_bCreateIfMissing_PropertyAddress;

	private static int ValidateMaterialSlots_bCreateIfMissing_Offset;

	private static bool ValidateMaterialSlots_bDeleteExtraSlots_IsValid;

	private static FFieldAddress ValidateMaterialSlots_bDeleteExtraSlots_PropertyAddress;

	private static int ValidateMaterialSlots_bDeleteExtraSlots_Offset;

	private static bool ValidateMaterialSlots_ReturnValue_IsValid;

	private static FFieldAddress ValidateMaterialSlots_ReturnValue_PropertyAddress;

	private static int ValidateMaterialSlots_ReturnValue_Offset;

	private static bool UpdateCollision_IsValid;

	private static IntPtr UpdateCollision_FunctionAddress;

	private static int UpdateCollision_ParamsSize;

	private static bool UpdateCollision_bOnlyIfPending_IsValid;

	private static FFieldAddress UpdateCollision_bOnlyIfPending_PropertyAddress;

	private static int UpdateCollision_bOnlyIfPending_Offset;

	private static bool SetTangentsType_IsValid;

	private static IntPtr SetTangentsType_FunctionAddress;

	private static int SetTangentsType_ParamsSize;

	private static bool SetTangentsType_NewTangentsType_IsValid;

	private static FFieldAddress SetTangentsType_NewTangentsType_PropertyAddress;

	private static int SetTangentsType_NewTangentsType_Offset;

	private static bool SetDynamicMesh_IsValid;

	private static IntPtr SetDynamicMesh_FunctionAddress;

	private static int SetDynamicMesh_ParamsSize;

	private static bool SetDynamicMesh_NewMesh_IsValid;

	private static FFieldAddress SetDynamicMesh_NewMesh_PropertyAddress;

	private static int SetDynamicMesh_NewMesh_Offset;

	private static bool SetDeferredCollisionUpdatesEnabled_IsValid;

	private static IntPtr SetDeferredCollisionUpdatesEnabled_FunctionAddress;

	private static int SetDeferredCollisionUpdatesEnabled_ParamsSize;

	private static bool SetDeferredCollisionUpdatesEnabled_bEnabled_IsValid;

	private static FFieldAddress SetDeferredCollisionUpdatesEnabled_bEnabled_PropertyAddress;

	private static int SetDeferredCollisionUpdatesEnabled_bEnabled_Offset;

	private static bool SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_IsValid;

	private static FFieldAddress SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_PropertyAddress;

	private static int SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_Offset;

	private static bool SetComplexAsSimpleCollisionEnabled_IsValid;

	private static IntPtr SetComplexAsSimpleCollisionEnabled_FunctionAddress;

	private static int SetComplexAsSimpleCollisionEnabled_ParamsSize;

	private static bool SetComplexAsSimpleCollisionEnabled_bEnabled_IsValid;

	private static FFieldAddress SetComplexAsSimpleCollisionEnabled_bEnabled_PropertyAddress;

	private static int SetComplexAsSimpleCollisionEnabled_bEnabled_Offset;

	private static bool SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_IsValid;

	private static FFieldAddress SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_PropertyAddress;

	private static int SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_Offset;

	private static bool GetTangentsType_IsValid;

	private static IntPtr GetTangentsType_FunctionAddress;

	private static int GetTangentsType_ParamsSize;

	private static bool GetTangentsType_ReturnValue_IsValid;

	private static FFieldAddress GetTangentsType_ReturnValue_PropertyAddress;

	private static int GetTangentsType_ReturnValue_Offset;

	private static bool EnableComplexAsSimpleCollision_IsValid;

	private static IntPtr EnableComplexAsSimpleCollision_FunctionAddress;

	private static int EnableComplexAsSimpleCollision_ParamsSize;

	private static bool ConfigureMaterialSet_IsValid;

	private static IntPtr ConfigureMaterialSet_FunctionAddress;

	private static int ConfigureMaterialSet_ParamsSize;

	private static bool ConfigureMaterialSet_NewMaterialSet_IsValid;

	private static FFieldAddress ConfigureMaterialSet_NewMaterialSet_PropertyAddress;

	private static int ConfigureMaterialSet_NewMaterialSet_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:CollisionType")]
	public ECollisionTraceFlag CollisionType
	{
		get
		{
			CheckDestroyed();
			if (!CollisionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshComponent:CollisionType");
				return ECollisionTraceFlag.CTF_UseDefault;
			}
			return EnumMarshaler<ECollisionTraceFlag>.FromNative(IntPtr.Add(base.Address, CollisionType_Offset), 0, CollisionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CollisionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshComponent:CollisionType");
			}
			else
			{
				EnumMarshaler<ECollisionTraceFlag>.ToNative(IntPtr.Add(base.Address, CollisionType_Offset), 0, CollisionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:bEnableComplexCollision")]
	public bool EnableComplexCollision
	{
		get
		{
			CheckDestroyed();
			if (!EnableComplexCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshComponent:bEnableComplexCollision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableComplexCollision_Offset), 0, EnableComplexCollision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableComplexCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshComponent:bEnableComplexCollision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableComplexCollision_Offset), 0, EnableComplexCollision_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:bDeferCollisionUpdates")]
	public bool DeferCollisionUpdates
	{
		get
		{
			CheckDestroyed();
			if (!DeferCollisionUpdates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshComponent:bDeferCollisionUpdates");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DeferCollisionUpdates_Offset), 0, DeferCollisionUpdates_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DeferCollisionUpdates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryFramework.DynamicMeshComponent:bDeferCollisionUpdates");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DeferCollisionUpdates_Offset), 0, DeferCollisionUpdates_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:ValidateMaterialSlots")]
	public unsafe bool ValidateMaterialSlots(bool bCreateIfMissing = true, bool bDeleteExtraSlots = true)
	{
		CheckDestroyed();
		if (!ValidateMaterialSlots_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshComponent:ValidateMaterialSlots");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ValidateMaterialSlots_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ValidateMaterialSlots_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ValidateMaterialSlots_bCreateIfMissing_Offset), 0, ValidateMaterialSlots_bCreateIfMissing_PropertyAddress.Address, bCreateIfMissing);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ValidateMaterialSlots_bDeleteExtraSlots_Offset), 0, ValidateMaterialSlots_bDeleteExtraSlots_PropertyAddress.Address, bDeleteExtraSlots);
		NativeReflection.InvokeFunctionOptimized(base.Address, ValidateMaterialSlots_FunctionAddress, intPtr, ValidateMaterialSlots_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ValidateMaterialSlots_ReturnValue_Offset), 0, ValidateMaterialSlots_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:UpdateCollision")]
	public unsafe void UpdateCollision(bool bOnlyIfPending = true)
	{
		CheckDestroyed();
		if (!UpdateCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshComponent:UpdateCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UpdateCollision_bOnlyIfPending_Offset), 0, UpdateCollision_bOnlyIfPending_PropertyAddress.Address, bOnlyIfPending);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateCollision_FunctionAddress, intPtr, UpdateCollision_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:SetTangentsType")]
	public unsafe void SetTangentsType(EDynamicMeshComponentTangentsMode NewTangentsType)
	{
		CheckDestroyed();
		if (!SetTangentsType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshComponent:SetTangentsType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTangentsType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTangentsType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EDynamicMeshComponentTangentsMode>.ToNative(IntPtr.Add(intPtr, SetTangentsType_NewTangentsType_Offset), 0, SetTangentsType_NewTangentsType_PropertyAddress.Address, NewTangentsType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTangentsType_FunctionAddress, intPtr, SetTangentsType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:SetDynamicMesh")]
	public unsafe void SetDynamicMesh(UDynamicMesh NewMesh)
	{
		CheckDestroyed();
		if (!SetDynamicMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshComponent:SetDynamicMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetDynamicMesh_NewMesh_Offset), 0, SetDynamicMesh_NewMesh_PropertyAddress.Address, NewMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicMesh_FunctionAddress, intPtr, SetDynamicMesh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:SetDeferredCollisionUpdatesEnabled")]
	public unsafe void SetDeferredCollisionUpdatesEnabled(bool bEnabled, bool bImmediateUpdate = true)
	{
		CheckDestroyed();
		if (!SetDeferredCollisionUpdatesEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshComponent:SetDeferredCollisionUpdatesEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDeferredCollisionUpdatesEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDeferredCollisionUpdatesEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDeferredCollisionUpdatesEnabled_bEnabled_Offset), 0, SetDeferredCollisionUpdatesEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_Offset), 0, SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_PropertyAddress.Address, bImmediateUpdate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDeferredCollisionUpdatesEnabled_FunctionAddress, intPtr, SetDeferredCollisionUpdatesEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:SetComplexAsSimpleCollisionEnabled")]
	public unsafe void SetComplexAsSimpleCollisionEnabled(bool bEnabled, bool bImmediateUpdate = true)
	{
		CheckDestroyed();
		if (!SetComplexAsSimpleCollisionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshComponent:SetComplexAsSimpleCollisionEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetComplexAsSimpleCollisionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetComplexAsSimpleCollisionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetComplexAsSimpleCollisionEnabled_bEnabled_Offset), 0, SetComplexAsSimpleCollisionEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_Offset), 0, SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_PropertyAddress.Address, bImmediateUpdate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetComplexAsSimpleCollisionEnabled_FunctionAddress, intPtr, SetComplexAsSimpleCollisionEnabled_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:GetTangentsType")]
	public unsafe EDynamicMeshComponentTangentsMode GetTangentsType()
	{
		CheckDestroyed();
		if (!GetTangentsType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshComponent:GetTangentsType");
			return EDynamicMeshComponentTangentsMode.NoTangents;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentsType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentsType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentsType_FunctionAddress, intPtr, GetTangentsType_ParamsSize);
		return EnumMarshaler<EDynamicMeshComponentTangentsMode>.FromNative(IntPtr.Add(intPtr, GetTangentsType_ReturnValue_Offset), 0, GetTangentsType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:EnableComplexAsSimpleCollision")]
	public unsafe void EnableComplexAsSimpleCollision()
	{
		CheckDestroyed();
		if (!EnableComplexAsSimpleCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshComponent:EnableComplexAsSimpleCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableComplexAsSimpleCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableComplexAsSimpleCollision_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EnableComplexAsSimpleCollision_FunctionAddress, argsSize: EnableComplexAsSimpleCollision_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshComponent:ConfigureMaterialSet")]
	public unsafe void ConfigureMaterialSet(List<UMaterialInterface> NewMaterialSet)
	{
		CheckDestroyed();
		if (!ConfigureMaterialSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.DynamicMeshComponent:ConfigureMaterialSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConfigureMaterialSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConfigureMaterialSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMaterialInterface>(1, ConfigureMaterialSet_NewMaterialSet_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).ToNative(IntPtr.Add(intPtr, ConfigureMaterialSet_NewMaterialSet_Offset), NewMaterialSet);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConfigureMaterialSet_FunctionAddress, intPtr, ConfigureMaterialSet_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConfigureMaterialSet_NewMaterialSet_PropertyAddress.Address, intPtr);
	}

	static UDynamicMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDynamicMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDynamicMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryFramework.DynamicMeshComponent");
		NativeReflectionCached.GetPropertyRef(ref CollisionType_PropertyAddress, intPtr, "CollisionType");
		CollisionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionType");
		CollisionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableComplexCollision_PropertyAddress, intPtr, "bEnableComplexCollision");
		EnableComplexCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableComplexCollision");
		EnableComplexCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableComplexCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeferCollisionUpdates_PropertyAddress, intPtr, "bDeferCollisionUpdates");
		DeferCollisionUpdates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDeferCollisionUpdates");
		DeferCollisionUpdates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDeferCollisionUpdates", Classes.FBoolProperty);
		ValidateMaterialSlots_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ValidateMaterialSlots");
		ValidateMaterialSlots_ParamsSize = NativeReflection.GetFunctionParamsSize(ValidateMaterialSlots_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ValidateMaterialSlots_bCreateIfMissing_PropertyAddress, ValidateMaterialSlots_FunctionAddress, "bCreateIfMissing");
		ValidateMaterialSlots_bCreateIfMissing_Offset = NativeReflectionCached.GetPropertyOffset(ValidateMaterialSlots_FunctionAddress, "bCreateIfMissing");
		ValidateMaterialSlots_bCreateIfMissing_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidateMaterialSlots_FunctionAddress, "bCreateIfMissing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ValidateMaterialSlots_bDeleteExtraSlots_PropertyAddress, ValidateMaterialSlots_FunctionAddress, "bDeleteExtraSlots");
		ValidateMaterialSlots_bDeleteExtraSlots_Offset = NativeReflectionCached.GetPropertyOffset(ValidateMaterialSlots_FunctionAddress, "bDeleteExtraSlots");
		ValidateMaterialSlots_bDeleteExtraSlots_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidateMaterialSlots_FunctionAddress, "bDeleteExtraSlots", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ValidateMaterialSlots_ReturnValue_PropertyAddress, ValidateMaterialSlots_FunctionAddress, "ReturnValue");
		ValidateMaterialSlots_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ValidateMaterialSlots_FunctionAddress, "ReturnValue");
		ValidateMaterialSlots_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidateMaterialSlots_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ValidateMaterialSlots_IsValid = ValidateMaterialSlots_FunctionAddress != IntPtr.Zero && ValidateMaterialSlots_bCreateIfMissing_IsValid && ValidateMaterialSlots_bDeleteExtraSlots_IsValid && ValidateMaterialSlots_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshComponent:ValidateMaterialSlots", ValidateMaterialSlots_IsValid);
		UpdateCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateCollision");
		UpdateCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateCollision_bOnlyIfPending_PropertyAddress, UpdateCollision_FunctionAddress, "bOnlyIfPending");
		UpdateCollision_bOnlyIfPending_Offset = NativeReflectionCached.GetPropertyOffset(UpdateCollision_FunctionAddress, "bOnlyIfPending");
		UpdateCollision_bOnlyIfPending_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateCollision_FunctionAddress, "bOnlyIfPending", Classes.FBoolProperty);
		UpdateCollision_IsValid = UpdateCollision_FunctionAddress != IntPtr.Zero && UpdateCollision_bOnlyIfPending_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshComponent:UpdateCollision", UpdateCollision_IsValid);
		SetTangentsType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTangentsType");
		SetTangentsType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTangentsType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTangentsType_NewTangentsType_PropertyAddress, SetTangentsType_FunctionAddress, "NewTangentsType");
		SetTangentsType_NewTangentsType_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentsType_FunctionAddress, "NewTangentsType");
		SetTangentsType_NewTangentsType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentsType_FunctionAddress, "NewTangentsType", Classes.FEnumProperty);
		SetTangentsType_IsValid = SetTangentsType_FunctionAddress != IntPtr.Zero && SetTangentsType_NewTangentsType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshComponent:SetTangentsType", SetTangentsType_IsValid);
		SetDynamicMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamicMesh");
		SetDynamicMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicMesh_NewMesh_PropertyAddress, SetDynamicMesh_FunctionAddress, "NewMesh");
		SetDynamicMesh_NewMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicMesh_FunctionAddress, "NewMesh");
		SetDynamicMesh_NewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicMesh_FunctionAddress, "NewMesh", Classes.FObjectProperty);
		SetDynamicMesh_IsValid = SetDynamicMesh_FunctionAddress != IntPtr.Zero && SetDynamicMesh_NewMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshComponent:SetDynamicMesh", SetDynamicMesh_IsValid);
		SetDeferredCollisionUpdatesEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDeferredCollisionUpdatesEnabled");
		SetDeferredCollisionUpdatesEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDeferredCollisionUpdatesEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDeferredCollisionUpdatesEnabled_bEnabled_PropertyAddress, SetDeferredCollisionUpdatesEnabled_FunctionAddress, "bEnabled");
		SetDeferredCollisionUpdatesEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetDeferredCollisionUpdatesEnabled_FunctionAddress, "bEnabled");
		SetDeferredCollisionUpdatesEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDeferredCollisionUpdatesEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_PropertyAddress, SetDeferredCollisionUpdatesEnabled_FunctionAddress, "bImmediateUpdate");
		SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_Offset = NativeReflectionCached.GetPropertyOffset(SetDeferredCollisionUpdatesEnabled_FunctionAddress, "bImmediateUpdate");
		SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDeferredCollisionUpdatesEnabled_FunctionAddress, "bImmediateUpdate", Classes.FBoolProperty);
		SetDeferredCollisionUpdatesEnabled_IsValid = SetDeferredCollisionUpdatesEnabled_FunctionAddress != IntPtr.Zero && SetDeferredCollisionUpdatesEnabled_bEnabled_IsValid && SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshComponent:SetDeferredCollisionUpdatesEnabled", SetDeferredCollisionUpdatesEnabled_IsValid);
		SetComplexAsSimpleCollisionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetComplexAsSimpleCollisionEnabled");
		SetComplexAsSimpleCollisionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetComplexAsSimpleCollisionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetComplexAsSimpleCollisionEnabled_bEnabled_PropertyAddress, SetComplexAsSimpleCollisionEnabled_FunctionAddress, "bEnabled");
		SetComplexAsSimpleCollisionEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetComplexAsSimpleCollisionEnabled_FunctionAddress, "bEnabled");
		SetComplexAsSimpleCollisionEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComplexAsSimpleCollisionEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_PropertyAddress, SetComplexAsSimpleCollisionEnabled_FunctionAddress, "bImmediateUpdate");
		SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_Offset = NativeReflectionCached.GetPropertyOffset(SetComplexAsSimpleCollisionEnabled_FunctionAddress, "bImmediateUpdate");
		SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComplexAsSimpleCollisionEnabled_FunctionAddress, "bImmediateUpdate", Classes.FBoolProperty);
		SetComplexAsSimpleCollisionEnabled_IsValid = SetComplexAsSimpleCollisionEnabled_FunctionAddress != IntPtr.Zero && SetComplexAsSimpleCollisionEnabled_bEnabled_IsValid && SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshComponent:SetComplexAsSimpleCollisionEnabled", SetComplexAsSimpleCollisionEnabled_IsValid);
		GetTangentsType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTangentsType");
		GetTangentsType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentsType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentsType_ReturnValue_PropertyAddress, GetTangentsType_FunctionAddress, "ReturnValue");
		GetTangentsType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentsType_FunctionAddress, "ReturnValue");
		GetTangentsType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentsType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetTangentsType_IsValid = GetTangentsType_FunctionAddress != IntPtr.Zero && GetTangentsType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshComponent:GetTangentsType", GetTangentsType_IsValid);
		EnableComplexAsSimpleCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableComplexAsSimpleCollision");
		EnableComplexAsSimpleCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableComplexAsSimpleCollision_FunctionAddress);
		EnableComplexAsSimpleCollision_IsValid = EnableComplexAsSimpleCollision_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshComponent:EnableComplexAsSimpleCollision", EnableComplexAsSimpleCollision_IsValid);
		ConfigureMaterialSet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConfigureMaterialSet");
		ConfigureMaterialSet_ParamsSize = NativeReflection.GetFunctionParamsSize(ConfigureMaterialSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConfigureMaterialSet_NewMaterialSet_PropertyAddress, ConfigureMaterialSet_FunctionAddress, "NewMaterialSet");
		ConfigureMaterialSet_NewMaterialSet_Offset = NativeReflectionCached.GetPropertyOffset(ConfigureMaterialSet_FunctionAddress, "NewMaterialSet");
		ConfigureMaterialSet_NewMaterialSet_IsValid = NativeReflectionCached.ValidatePropertyClass(ConfigureMaterialSet_FunctionAddress, "NewMaterialSet", Classes.FArrayProperty);
		ConfigureMaterialSet_IsValid = ConfigureMaterialSet_FunctionAddress != IntPtr.Zero && ConfigureMaterialSet_NewMaterialSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.DynamicMeshComponent:ConfigureMaterialSet", ConfigureMaterialSet_IsValid);
	}
}
