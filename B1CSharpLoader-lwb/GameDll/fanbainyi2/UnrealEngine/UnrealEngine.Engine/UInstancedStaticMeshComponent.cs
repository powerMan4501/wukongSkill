using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.InstancedStaticMeshComponent", "Engine", UnrealModuleType.Engine)]
public class UInstancedStaticMeshComponent : UStaticMeshComponent, ISMInstanceManager, IInterface
{
	private static bool InstancingRandomSeed_IsValid;

	private static int InstancingRandomSeed_Offset;

	private static bool InstanceStartCullDistance_IsValid;

	private static int InstanceStartCullDistance_Offset;

	private static bool InstanceEndCullDistance_IsValid;

	private static int InstanceEndCullDistance_Offset;

	private static bool UpdateInstanceTransform_IsValid;

	private static IntPtr UpdateInstanceTransform_FunctionAddress;

	private static int UpdateInstanceTransform_ParamsSize;

	private static bool UpdateInstanceTransform_InstanceIndex_IsValid;

	private static FFieldAddress UpdateInstanceTransform_InstanceIndex_PropertyAddress;

	private static int UpdateInstanceTransform_InstanceIndex_Offset;

	private static bool UpdateInstanceTransform_NewInstanceTransform_IsValid;

	private static FFieldAddress UpdateInstanceTransform_NewInstanceTransform_PropertyAddress;

	private static int UpdateInstanceTransform_NewInstanceTransform_Offset;

	private static bool UpdateInstanceTransform_bWorldSpace_IsValid;

	private static FFieldAddress UpdateInstanceTransform_bWorldSpace_PropertyAddress;

	private static int UpdateInstanceTransform_bWorldSpace_Offset;

	private static bool UpdateInstanceTransform_bMarkRenderStateDirty_IsValid;

	private static FFieldAddress UpdateInstanceTransform_bMarkRenderStateDirty_PropertyAddress;

	private static int UpdateInstanceTransform_bMarkRenderStateDirty_Offset;

	private static bool UpdateInstanceTransform_bTeleport_IsValid;

	private static FFieldAddress UpdateInstanceTransform_bTeleport_PropertyAddress;

	private static int UpdateInstanceTransform_bTeleport_Offset;

	private static bool UpdateInstanceTransform_ReturnValue_IsValid;

	private static FFieldAddress UpdateInstanceTransform_ReturnValue_PropertyAddress;

	private static int UpdateInstanceTransform_ReturnValue_Offset;

	private static bool SetCustomDataValue_IsValid;

	private static IntPtr SetCustomDataValue_FunctionAddress;

	private static int SetCustomDataValue_ParamsSize;

	private static bool SetCustomDataValue_InstanceIndex_IsValid;

	private static FFieldAddress SetCustomDataValue_InstanceIndex_PropertyAddress;

	private static int SetCustomDataValue_InstanceIndex_Offset;

	private static bool SetCustomDataValue_CustomDataIndex_IsValid;

	private static FFieldAddress SetCustomDataValue_CustomDataIndex_PropertyAddress;

	private static int SetCustomDataValue_CustomDataIndex_Offset;

	private static bool SetCustomDataValue_CustomDataValue_IsValid;

	private static FFieldAddress SetCustomDataValue_CustomDataValue_PropertyAddress;

	private static int SetCustomDataValue_CustomDataValue_Offset;

	private static bool SetCustomDataValue_bMarkRenderStateDirty_IsValid;

	private static FFieldAddress SetCustomDataValue_bMarkRenderStateDirty_PropertyAddress;

	private static int SetCustomDataValue_bMarkRenderStateDirty_Offset;

	private static bool SetCustomDataValue_ReturnValue_IsValid;

	private static FFieldAddress SetCustomDataValue_ReturnValue_PropertyAddress;

	private static int SetCustomDataValue_ReturnValue_Offset;

	private static bool SetCullDistances_IsValid;

	private static IntPtr SetCullDistances_FunctionAddress;

	private static int SetCullDistances_ParamsSize;

	private static bool SetCullDistances_StartCullDistance_IsValid;

	private static FFieldAddress SetCullDistances_StartCullDistance_PropertyAddress;

	private static int SetCullDistances_StartCullDistance_Offset;

	private static bool SetCullDistances_EndCullDistance_IsValid;

	private static FFieldAddress SetCullDistances_EndCullDistance_PropertyAddress;

	private static int SetCullDistances_EndCullDistance_Offset;

	private static bool RemoveInstances_IsValid;

	private static IntPtr RemoveInstances_FunctionAddress;

	private static int RemoveInstances_ParamsSize;

	private static bool RemoveInstances_InstancesToRemove_IsValid;

	private static FFieldAddress RemoveInstances_InstancesToRemove_PropertyAddress;

	private static int RemoveInstances_InstancesToRemove_Offset;

	private static bool RemoveInstances_ReturnValue_IsValid;

	private static FFieldAddress RemoveInstances_ReturnValue_PropertyAddress;

	private static int RemoveInstances_ReturnValue_Offset;

	private static bool RemoveInstance_IsValid;

	private static IntPtr RemoveInstance_FunctionAddress;

	private static int RemoveInstance_ParamsSize;

	private static bool RemoveInstance_InstanceIndex_IsValid;

	private static FFieldAddress RemoveInstance_InstanceIndex_PropertyAddress;

	private static int RemoveInstance_InstanceIndex_Offset;

	private static bool RemoveInstance_ReturnValue_IsValid;

	private static FFieldAddress RemoveInstance_ReturnValue_PropertyAddress;

	private static int RemoveInstance_ReturnValue_Offset;

	private static bool IsValidInstance_IsValid;

	private static IntPtr IsValidInstance_FunctionAddress;

	private static int IsValidInstance_ParamsSize;

	private static bool IsValidInstance_InstanceIndex_IsValid;

	private static FFieldAddress IsValidInstance_InstanceIndex_PropertyAddress;

	private static int IsValidInstance_InstanceIndex_Offset;

	private static bool IsValidInstance_ReturnValue_IsValid;

	private static FFieldAddress IsValidInstance_ReturnValue_PropertyAddress;

	private static int IsValidInstance_ReturnValue_Offset;

	private static bool GetInstanceTransform_IsValid;

	private static IntPtr GetInstanceTransform_FunctionAddress;

	private static int GetInstanceTransform_ParamsSize;

	private static bool GetInstanceTransform_InstanceIndex_IsValid;

	private static FFieldAddress GetInstanceTransform_InstanceIndex_PropertyAddress;

	private static int GetInstanceTransform_InstanceIndex_Offset;

	private static bool GetInstanceTransform_OutInstanceTransform_IsValid;

	private static FFieldAddress GetInstanceTransform_OutInstanceTransform_PropertyAddress;

	private static int GetInstanceTransform_OutInstanceTransform_Offset;

	private static bool GetInstanceTransform_bWorldSpace_IsValid;

	private static FFieldAddress GetInstanceTransform_bWorldSpace_PropertyAddress;

	private static int GetInstanceTransform_bWorldSpace_Offset;

	private static bool GetInstanceTransform_ReturnValue_IsValid;

	private static FFieldAddress GetInstanceTransform_ReturnValue_PropertyAddress;

	private static int GetInstanceTransform_ReturnValue_Offset;

	private static bool GetInstancesOverlappingSphere_IsValid;

	private static IntPtr GetInstancesOverlappingSphere_FunctionAddress;

	private static int GetInstancesOverlappingSphere_ParamsSize;

	private static bool GetInstancesOverlappingSphere_Center_IsValid;

	private static FFieldAddress GetInstancesOverlappingSphere_Center_PropertyAddress;

	private static int GetInstancesOverlappingSphere_Center_Offset;

	private static bool GetInstancesOverlappingSphere_Radius_IsValid;

	private static FFieldAddress GetInstancesOverlappingSphere_Radius_PropertyAddress;

	private static int GetInstancesOverlappingSphere_Radius_Offset;

	private static bool GetInstancesOverlappingSphere_bSphereInWorldSpace_IsValid;

	private static FFieldAddress GetInstancesOverlappingSphere_bSphereInWorldSpace_PropertyAddress;

	private static int GetInstancesOverlappingSphere_bSphereInWorldSpace_Offset;

	private static bool GetInstancesOverlappingSphere_ReturnValue_IsValid;

	private static FFieldAddress GetInstancesOverlappingSphere_ReturnValue_PropertyAddress;

	private static int GetInstancesOverlappingSphere_ReturnValue_Offset;

	private static bool GetInstancesOverlappingBox_IsValid;

	private static IntPtr GetInstancesOverlappingBox_FunctionAddress;

	private static int GetInstancesOverlappingBox_ParamsSize;

	private static bool GetInstancesOverlappingBox_Box_IsValid;

	private static FFieldAddress GetInstancesOverlappingBox_Box_PropertyAddress;

	private static int GetInstancesOverlappingBox_Box_Offset;

	private static bool GetInstancesOverlappingBox_bBoxInWorldSpace_IsValid;

	private static FFieldAddress GetInstancesOverlappingBox_bBoxInWorldSpace_PropertyAddress;

	private static int GetInstancesOverlappingBox_bBoxInWorldSpace_Offset;

	private static bool GetInstancesOverlappingBox_ReturnValue_IsValid;

	private static FFieldAddress GetInstancesOverlappingBox_ReturnValue_PropertyAddress;

	private static int GetInstancesOverlappingBox_ReturnValue_Offset;

	private static bool GetInstanceCount_IsValid;

	private static IntPtr GetInstanceCount_FunctionAddress;

	private static int GetInstanceCount_ParamsSize;

	private static bool GetInstanceCount_ReturnValue_IsValid;

	private static FFieldAddress GetInstanceCount_ReturnValue_PropertyAddress;

	private static int GetInstanceCount_ReturnValue_Offset;

	private static bool ClearInstances_IsValid;

	private static IntPtr ClearInstances_FunctionAddress;

	private static int ClearInstances_ParamsSize;

	private static bool BatchUpdateInstancesTransforms_IsValid;

	private static IntPtr BatchUpdateInstancesTransforms_FunctionAddress;

	private static int BatchUpdateInstancesTransforms_ParamsSize;

	private static bool BatchUpdateInstancesTransforms_StartInstanceIndex_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransforms_StartInstanceIndex_PropertyAddress;

	private static int BatchUpdateInstancesTransforms_StartInstanceIndex_Offset;

	private static bool BatchUpdateInstancesTransforms_NewInstancesTransforms_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransforms_NewInstancesTransforms_PropertyAddress;

	private static int BatchUpdateInstancesTransforms_NewInstancesTransforms_Offset;

	private static bool BatchUpdateInstancesTransforms_bWorldSpace_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransforms_bWorldSpace_PropertyAddress;

	private static int BatchUpdateInstancesTransforms_bWorldSpace_Offset;

	private static bool BatchUpdateInstancesTransforms_bMarkRenderStateDirty_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransforms_bMarkRenderStateDirty_PropertyAddress;

	private static int BatchUpdateInstancesTransforms_bMarkRenderStateDirty_Offset;

	private static bool BatchUpdateInstancesTransforms_bTeleport_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransforms_bTeleport_PropertyAddress;

	private static int BatchUpdateInstancesTransforms_bTeleport_Offset;

	private static bool BatchUpdateInstancesTransforms_ReturnValue_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransforms_ReturnValue_PropertyAddress;

	private static int BatchUpdateInstancesTransforms_ReturnValue_Offset;

	private static bool BatchUpdateInstancesTransform_IsValid;

	private static IntPtr BatchUpdateInstancesTransform_FunctionAddress;

	private static int BatchUpdateInstancesTransform_ParamsSize;

	private static bool BatchUpdateInstancesTransform_StartInstanceIndex_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransform_StartInstanceIndex_PropertyAddress;

	private static int BatchUpdateInstancesTransform_StartInstanceIndex_Offset;

	private static bool BatchUpdateInstancesTransform_NumInstances_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransform_NumInstances_PropertyAddress;

	private static int BatchUpdateInstancesTransform_NumInstances_Offset;

	private static bool BatchUpdateInstancesTransform_NewInstancesTransform_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransform_NewInstancesTransform_PropertyAddress;

	private static int BatchUpdateInstancesTransform_NewInstancesTransform_Offset;

	private static bool BatchUpdateInstancesTransform_bWorldSpace_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransform_bWorldSpace_PropertyAddress;

	private static int BatchUpdateInstancesTransform_bWorldSpace_Offset;

	private static bool BatchUpdateInstancesTransform_bMarkRenderStateDirty_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransform_bMarkRenderStateDirty_PropertyAddress;

	private static int BatchUpdateInstancesTransform_bMarkRenderStateDirty_Offset;

	private static bool BatchUpdateInstancesTransform_bTeleport_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransform_bTeleport_PropertyAddress;

	private static int BatchUpdateInstancesTransform_bTeleport_Offset;

	private static bool BatchUpdateInstancesTransform_ReturnValue_IsValid;

	private static FFieldAddress BatchUpdateInstancesTransform_ReturnValue_PropertyAddress;

	private static int BatchUpdateInstancesTransform_ReturnValue_Offset;

	private static bool AddInstances_IsValid;

	private static IntPtr AddInstances_FunctionAddress;

	private static int AddInstances_ParamsSize;

	private static bool AddInstances_InstanceTransforms_IsValid;

	private static FFieldAddress AddInstances_InstanceTransforms_PropertyAddress;

	private static int AddInstances_InstanceTransforms_Offset;

	private static bool AddInstances_bShouldReturnIndices_IsValid;

	private static FFieldAddress AddInstances_bShouldReturnIndices_PropertyAddress;

	private static int AddInstances_bShouldReturnIndices_Offset;

	private static bool AddInstances_bWorldSpace_IsValid;

	private static FFieldAddress AddInstances_bWorldSpace_PropertyAddress;

	private static int AddInstances_bWorldSpace_Offset;

	private static bool AddInstances_ReturnValue_IsValid;

	private static FFieldAddress AddInstances_ReturnValue_PropertyAddress;

	private static int AddInstances_ReturnValue_Offset;

	private static bool AddInstance_IsValid;

	private static IntPtr AddInstance_FunctionAddress;

	private static int AddInstance_ParamsSize;

	private static bool AddInstance_InstanceTransform_IsValid;

	private static FFieldAddress AddInstance_InstanceTransform_PropertyAddress;

	private static int AddInstance_InstanceTransform_Offset;

	private static bool AddInstance_bWorldSpace_IsValid;

	private static FFieldAddress AddInstance_bWorldSpace_PropertyAddress;

	private static int AddInstance_bWorldSpace_Offset;

	private static bool AddInstance_ReturnValue_IsValid;

	private static FFieldAddress AddInstance_ReturnValue_PropertyAddress;

	private static int AddInstance_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:InstancingRandomSeed")]
	public int InstancingRandomSeed
	{
		get
		{
			CheckDestroyed();
			if (!InstancingRandomSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InstancedStaticMeshComponent:InstancingRandomSeed");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InstancingRandomSeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InstancingRandomSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InstancedStaticMeshComponent:InstancingRandomSeed");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InstancingRandomSeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:InstanceStartCullDistance")]
	public int InstanceStartCullDistance
	{
		get
		{
			CheckDestroyed();
			if (!InstanceStartCullDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InstancedStaticMeshComponent:InstanceStartCullDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InstanceStartCullDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InstanceStartCullDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InstancedStaticMeshComponent:InstanceStartCullDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InstanceStartCullDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:InstanceEndCullDistance")]
	public int InstanceEndCullDistance
	{
		get
		{
			CheckDestroyed();
			if (!InstanceEndCullDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InstancedStaticMeshComponent:InstanceEndCullDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InstanceEndCullDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InstanceEndCullDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.InstancedStaticMeshComponent:InstanceEndCullDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InstanceEndCullDistance_Offset), value);
			}
		}
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:UpdateInstanceTransform")]
	public unsafe bool UpdateInstanceTransform(int InstanceIndex, FTransform NewInstanceTransform, bool bWorldSpace = false, bool bMarkRenderStateDirty = false, bool bTeleport = false)
	{
		CheckDestroyed();
		if (!UpdateInstanceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:UpdateInstanceTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateInstanceTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateInstanceTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UpdateInstanceTransform_InstanceIndex_Offset), 0, UpdateInstanceTransform_InstanceIndex_PropertyAddress.Address, InstanceIndex);
		NativeReflection.InitializeValue_InContainer(UpdateInstanceTransform_NewInstanceTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, UpdateInstanceTransform_NewInstanceTransform_Offset), 0, UpdateInstanceTransform_NewInstanceTransform_PropertyAddress.Address, NewInstanceTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UpdateInstanceTransform_bWorldSpace_Offset), 0, UpdateInstanceTransform_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UpdateInstanceTransform_bMarkRenderStateDirty_Offset), 0, UpdateInstanceTransform_bMarkRenderStateDirty_PropertyAddress.Address, bMarkRenderStateDirty);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UpdateInstanceTransform_bTeleport_Offset), 0, UpdateInstanceTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateInstanceTransform_FunctionAddress, intPtr, UpdateInstanceTransform_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, UpdateInstanceTransform_ReturnValue_Offset), 0, UpdateInstanceTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:SetCustomDataValue")]
	public unsafe bool SetCustomDataValue(int InstanceIndex, int CustomDataIndex, float CustomDataValue, bool bMarkRenderStateDirty = false)
	{
		CheckDestroyed();
		if (!SetCustomDataValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:SetCustomDataValue");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomDataValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomDataValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomDataValue_InstanceIndex_Offset), 0, SetCustomDataValue_InstanceIndex_PropertyAddress.Address, InstanceIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomDataValue_CustomDataIndex_Offset), 0, SetCustomDataValue_CustomDataIndex_PropertyAddress.Address, CustomDataIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCustomDataValue_CustomDataValue_Offset), 0, SetCustomDataValue_CustomDataValue_PropertyAddress.Address, CustomDataValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomDataValue_bMarkRenderStateDirty_Offset), 0, SetCustomDataValue_bMarkRenderStateDirty_PropertyAddress.Address, bMarkRenderStateDirty);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomDataValue_FunctionAddress, intPtr, SetCustomDataValue_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomDataValue_ReturnValue_Offset), 0, SetCustomDataValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:SetCullDistances")]
	public unsafe void SetCullDistances(int StartCullDistance, int EndCullDistance)
	{
		CheckDestroyed();
		if (!SetCullDistances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:SetCullDistances");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCullDistances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCullDistances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCullDistances_StartCullDistance_Offset), 0, SetCullDistances_StartCullDistance_PropertyAddress.Address, StartCullDistance);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCullDistances_EndCullDistance_Offset), 0, SetCullDistances_EndCullDistance_PropertyAddress.Address, EndCullDistance);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCullDistances_FunctionAddress, intPtr, SetCullDistances_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:RemoveInstances")]
	public unsafe bool RemoveInstances(List<int> InstancesToRemove)
	{
		CheckDestroyed();
		if (!RemoveInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:RemoveInstances");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<int>(1, RemoveInstances_InstancesToRemove_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, RemoveInstances_InstancesToRemove_Offset), InstancesToRemove);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveInstances_FunctionAddress, intPtr, RemoveInstances_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveInstances_InstancesToRemove_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveInstances_ReturnValue_Offset), 0, RemoveInstances_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:RemoveInstance")]
	public unsafe bool RemoveInstance(int InstanceIndex)
	{
		CheckDestroyed();
		if (!RemoveInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:RemoveInstance");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveInstance_InstanceIndex_Offset), 0, RemoveInstance_InstanceIndex_PropertyAddress.Address, InstanceIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveInstance_FunctionAddress, intPtr, RemoveInstance_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveInstance_ReturnValue_Offset), 0, RemoveInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:IsValidInstance")]
	public unsafe bool IsValidInstance(int InstanceIndex)
	{
		CheckDestroyed();
		if (!IsValidInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:IsValidInstance");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsValidInstance_InstanceIndex_Offset), 0, IsValidInstance_InstanceIndex_PropertyAddress.Address, InstanceIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsValidInstance_FunctionAddress, intPtr, IsValidInstance_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidInstance_ReturnValue_Offset), 0, IsValidInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:GetInstanceTransform")]
	public unsafe bool GetInstanceTransform(int InstanceIndex, out FTransform OutInstanceTransform, bool bWorldSpace = false)
	{
		CheckDestroyed();
		if (!GetInstanceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:GetInstanceTransform");
			OutInstanceTransform = default(FTransform);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstanceTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstanceTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetInstanceTransform_InstanceIndex_Offset), 0, GetInstanceTransform_InstanceIndex_PropertyAddress.Address, InstanceIndex);
		NativeReflection.InitializeValue_InContainer(GetInstanceTransform_OutInstanceTransform_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetInstanceTransform_bWorldSpace_Offset), 0, GetInstanceTransform_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstanceTransform_FunctionAddress, intPtr, GetInstanceTransform_ParamsSize);
		OutInstanceTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetInstanceTransform_OutInstanceTransform_Offset), 0, GetInstanceTransform_OutInstanceTransform_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetInstanceTransform_ReturnValue_Offset), 0, GetInstanceTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:GetInstancesOverlappingSphere")]
	public unsafe List<int> GetInstancesOverlappingSphere(FVector Center, float Radius, bool bSphereInWorldSpace = true)
	{
		CheckDestroyed();
		if (!GetInstancesOverlappingSphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:GetInstancesOverlappingSphere");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstancesOverlappingSphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstancesOverlappingSphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetInstancesOverlappingSphere_Center_Offset), 0, GetInstancesOverlappingSphere_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetInstancesOverlappingSphere_Radius_Offset), 0, GetInstancesOverlappingSphere_Radius_PropertyAddress.Address, Radius);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetInstancesOverlappingSphere_bSphereInWorldSpace_Offset), 0, GetInstancesOverlappingSphere_bSphereInWorldSpace_PropertyAddress.Address, bSphereInWorldSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstancesOverlappingSphere_FunctionAddress, intPtr, GetInstancesOverlappingSphere_ParamsSize);
		List<int> result = new TArrayCopyMarshaler<int>(1, GetInstancesOverlappingSphere_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetInstancesOverlappingSphere_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInstancesOverlappingSphere_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:GetInstancesOverlappingBox")]
	public unsafe List<int> GetInstancesOverlappingBox(FBox Box, bool bBoxInWorldSpace = true)
	{
		CheckDestroyed();
		if (!GetInstancesOverlappingBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:GetInstancesOverlappingBox");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstancesOverlappingBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstancesOverlappingBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, GetInstancesOverlappingBox_Box_Offset), 0, GetInstancesOverlappingBox_Box_PropertyAddress.Address, Box);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetInstancesOverlappingBox_bBoxInWorldSpace_Offset), 0, GetInstancesOverlappingBox_bBoxInWorldSpace_PropertyAddress.Address, bBoxInWorldSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstancesOverlappingBox_FunctionAddress, intPtr, GetInstancesOverlappingBox_ParamsSize);
		List<int> result = new TArrayCopyMarshaler<int>(1, GetInstancesOverlappingBox_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetInstancesOverlappingBox_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInstancesOverlappingBox_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:GetInstanceCount")]
	public unsafe int GetInstanceCount()
	{
		CheckDestroyed();
		if (!GetInstanceCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:GetInstanceCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstanceCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstanceCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstanceCount_FunctionAddress, intPtr, GetInstanceCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetInstanceCount_ReturnValue_Offset), 0, GetInstanceCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:ClearInstances")]
	public unsafe void ClearInstances()
	{
		CheckDestroyed();
		if (!ClearInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:ClearInstances");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearInstances_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearInstances_FunctionAddress, argsSize: ClearInstances_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:BatchUpdateInstancesTransforms")]
	public unsafe bool BatchUpdateInstancesTransforms(int StartInstanceIndex, List<FTransform> NewInstancesTransforms, bool bWorldSpace = false, bool bMarkRenderStateDirty = false, bool bTeleport = false)
	{
		CheckDestroyed();
		if (!BatchUpdateInstancesTransforms_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:BatchUpdateInstancesTransforms");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BatchUpdateInstancesTransforms_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BatchUpdateInstancesTransforms_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransforms_StartInstanceIndex_Offset), 0, BatchUpdateInstancesTransforms_StartInstanceIndex_PropertyAddress.Address, StartInstanceIndex);
		new TArrayCopyMarshaler<FTransform>(1, BatchUpdateInstancesTransforms_NewInstancesTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransforms_NewInstancesTransforms_Offset), NewInstancesTransforms);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransforms_bWorldSpace_Offset), 0, BatchUpdateInstancesTransforms_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransforms_bMarkRenderStateDirty_Offset), 0, BatchUpdateInstancesTransforms_bMarkRenderStateDirty_PropertyAddress.Address, bMarkRenderStateDirty);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransforms_bTeleport_Offset), 0, BatchUpdateInstancesTransforms_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, BatchUpdateInstancesTransforms_FunctionAddress, intPtr, BatchUpdateInstancesTransforms_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BatchUpdateInstancesTransforms_NewInstancesTransforms_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransforms_ReturnValue_Offset), 0, BatchUpdateInstancesTransforms_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:BatchUpdateInstancesTransform")]
	public unsafe bool BatchUpdateInstancesTransform(int StartInstanceIndex, int NumInstances, FTransform NewInstancesTransform, bool bWorldSpace = false, bool bMarkRenderStateDirty = false, bool bTeleport = false)
	{
		CheckDestroyed();
		if (!BatchUpdateInstancesTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:BatchUpdateInstancesTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BatchUpdateInstancesTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BatchUpdateInstancesTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransform_StartInstanceIndex_Offset), 0, BatchUpdateInstancesTransform_StartInstanceIndex_PropertyAddress.Address, StartInstanceIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransform_NumInstances_Offset), 0, BatchUpdateInstancesTransform_NumInstances_PropertyAddress.Address, NumInstances);
		NativeReflection.InitializeValue_InContainer(BatchUpdateInstancesTransform_NewInstancesTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransform_NewInstancesTransform_Offset), 0, BatchUpdateInstancesTransform_NewInstancesTransform_PropertyAddress.Address, NewInstancesTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransform_bWorldSpace_Offset), 0, BatchUpdateInstancesTransform_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransform_bMarkRenderStateDirty_Offset), 0, BatchUpdateInstancesTransform_bMarkRenderStateDirty_PropertyAddress.Address, bMarkRenderStateDirty);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransform_bTeleport_Offset), 0, BatchUpdateInstancesTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, BatchUpdateInstancesTransform_FunctionAddress, intPtr, BatchUpdateInstancesTransform_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BatchUpdateInstancesTransform_ReturnValue_Offset), 0, BatchUpdateInstancesTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:AddInstances")]
	public unsafe List<int> AddInstances(List<FTransform> InstanceTransforms, bool bShouldReturnIndices, bool bWorldSpace = false)
	{
		CheckDestroyed();
		if (!AddInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:AddInstances");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FTransform>(1, AddInstances_InstanceTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, AddInstances_InstanceTransforms_Offset), InstanceTransforms);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInstances_bShouldReturnIndices_Offset), 0, AddInstances_bShouldReturnIndices_PropertyAddress.Address, bShouldReturnIndices);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInstances_bWorldSpace_Offset), 0, AddInstances_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddInstances_FunctionAddress, intPtr, AddInstances_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddInstances_InstanceTransforms_PropertyAddress.Address, intPtr);
		List<int> result = new TArrayCopyMarshaler<int>(1, AddInstances_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, AddInstances_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(AddInstances_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.InstancedStaticMeshComponent:AddInstance")]
	public unsafe int AddInstance(FTransform InstanceTransform, bool bWorldSpace = false)
	{
		CheckDestroyed();
		if (!AddInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstancedStaticMeshComponent:AddInstance");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddInstance_InstanceTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddInstance_InstanceTransform_Offset), 0, AddInstance_InstanceTransform_PropertyAddress.Address, InstanceTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInstance_bWorldSpace_Offset), 0, AddInstance_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddInstance_FunctionAddress, intPtr, AddInstance_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddInstance_ReturnValue_Offset), 0, AddInstance_ReturnValue_PropertyAddress.Address);
	}

	static UInstancedStaticMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInstancedStaticMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInstancedStaticMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.InstancedStaticMeshComponent");
		InstancingRandomSeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstancingRandomSeed");
		InstancingRandomSeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstancingRandomSeed", Classes.FIntProperty);
		InstanceStartCullDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstanceStartCullDistance");
		InstanceStartCullDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstanceStartCullDistance", Classes.FIntProperty);
		InstanceEndCullDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstanceEndCullDistance");
		InstanceEndCullDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstanceEndCullDistance", Classes.FIntProperty);
		UpdateInstanceTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateInstanceTransform");
		UpdateInstanceTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateInstanceTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceTransform_InstanceIndex_PropertyAddress, UpdateInstanceTransform_FunctionAddress, "InstanceIndex");
		UpdateInstanceTransform_InstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceTransform_FunctionAddress, "InstanceIndex");
		UpdateInstanceTransform_InstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceTransform_FunctionAddress, "InstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceTransform_NewInstanceTransform_PropertyAddress, UpdateInstanceTransform_FunctionAddress, "NewInstanceTransform");
		UpdateInstanceTransform_NewInstanceTransform_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceTransform_FunctionAddress, "NewInstanceTransform");
		UpdateInstanceTransform_NewInstanceTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceTransform_FunctionAddress, "NewInstanceTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceTransform_bWorldSpace_PropertyAddress, UpdateInstanceTransform_FunctionAddress, "bWorldSpace");
		UpdateInstanceTransform_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceTransform_FunctionAddress, "bWorldSpace");
		UpdateInstanceTransform_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceTransform_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceTransform_bMarkRenderStateDirty_PropertyAddress, UpdateInstanceTransform_FunctionAddress, "bMarkRenderStateDirty");
		UpdateInstanceTransform_bMarkRenderStateDirty_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceTransform_FunctionAddress, "bMarkRenderStateDirty");
		UpdateInstanceTransform_bMarkRenderStateDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceTransform_FunctionAddress, "bMarkRenderStateDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceTransform_bTeleport_PropertyAddress, UpdateInstanceTransform_FunctionAddress, "bTeleport");
		UpdateInstanceTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceTransform_FunctionAddress, "bTeleport");
		UpdateInstanceTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceTransform_ReturnValue_PropertyAddress, UpdateInstanceTransform_FunctionAddress, "ReturnValue");
		UpdateInstanceTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceTransform_FunctionAddress, "ReturnValue");
		UpdateInstanceTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		UpdateInstanceTransform_IsValid = UpdateInstanceTransform_FunctionAddress != IntPtr.Zero && UpdateInstanceTransform_InstanceIndex_IsValid && UpdateInstanceTransform_NewInstanceTransform_IsValid && UpdateInstanceTransform_bWorldSpace_IsValid && UpdateInstanceTransform_bMarkRenderStateDirty_IsValid && UpdateInstanceTransform_bTeleport_IsValid && UpdateInstanceTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:UpdateInstanceTransform", UpdateInstanceTransform_IsValid);
		SetCustomDataValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomDataValue");
		SetCustomDataValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomDataValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomDataValue_InstanceIndex_PropertyAddress, SetCustomDataValue_FunctionAddress, "InstanceIndex");
		SetCustomDataValue_InstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomDataValue_FunctionAddress, "InstanceIndex");
		SetCustomDataValue_InstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomDataValue_FunctionAddress, "InstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomDataValue_CustomDataIndex_PropertyAddress, SetCustomDataValue_FunctionAddress, "CustomDataIndex");
		SetCustomDataValue_CustomDataIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomDataValue_FunctionAddress, "CustomDataIndex");
		SetCustomDataValue_CustomDataIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomDataValue_FunctionAddress, "CustomDataIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomDataValue_CustomDataValue_PropertyAddress, SetCustomDataValue_FunctionAddress, "CustomDataValue");
		SetCustomDataValue_CustomDataValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomDataValue_FunctionAddress, "CustomDataValue");
		SetCustomDataValue_CustomDataValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomDataValue_FunctionAddress, "CustomDataValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomDataValue_bMarkRenderStateDirty_PropertyAddress, SetCustomDataValue_FunctionAddress, "bMarkRenderStateDirty");
		SetCustomDataValue_bMarkRenderStateDirty_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomDataValue_FunctionAddress, "bMarkRenderStateDirty");
		SetCustomDataValue_bMarkRenderStateDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomDataValue_FunctionAddress, "bMarkRenderStateDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomDataValue_ReturnValue_PropertyAddress, SetCustomDataValue_FunctionAddress, "ReturnValue");
		SetCustomDataValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomDataValue_FunctionAddress, "ReturnValue");
		SetCustomDataValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomDataValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomDataValue_IsValid = SetCustomDataValue_FunctionAddress != IntPtr.Zero && SetCustomDataValue_InstanceIndex_IsValid && SetCustomDataValue_CustomDataIndex_IsValid && SetCustomDataValue_CustomDataValue_IsValid && SetCustomDataValue_bMarkRenderStateDirty_IsValid && SetCustomDataValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:SetCustomDataValue", SetCustomDataValue_IsValid);
		SetCullDistances_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCullDistances");
		SetCullDistances_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCullDistances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCullDistances_StartCullDistance_PropertyAddress, SetCullDistances_FunctionAddress, "StartCullDistance");
		SetCullDistances_StartCullDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetCullDistances_FunctionAddress, "StartCullDistance");
		SetCullDistances_StartCullDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullDistances_FunctionAddress, "StartCullDistance", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCullDistances_EndCullDistance_PropertyAddress, SetCullDistances_FunctionAddress, "EndCullDistance");
		SetCullDistances_EndCullDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetCullDistances_FunctionAddress, "EndCullDistance");
		SetCullDistances_EndCullDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullDistances_FunctionAddress, "EndCullDistance", Classes.FIntProperty);
		SetCullDistances_IsValid = SetCullDistances_FunctionAddress != IntPtr.Zero && SetCullDistances_StartCullDistance_IsValid && SetCullDistances_EndCullDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:SetCullDistances", SetCullDistances_IsValid);
		RemoveInstances_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveInstances");
		RemoveInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveInstances_InstancesToRemove_PropertyAddress, RemoveInstances_FunctionAddress, "InstancesToRemove");
		RemoveInstances_InstancesToRemove_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInstances_FunctionAddress, "InstancesToRemove");
		RemoveInstances_InstancesToRemove_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInstances_FunctionAddress, "InstancesToRemove", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInstances_ReturnValue_PropertyAddress, RemoveInstances_FunctionAddress, "ReturnValue");
		RemoveInstances_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInstances_FunctionAddress, "ReturnValue");
		RemoveInstances_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInstances_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveInstances_IsValid = RemoveInstances_FunctionAddress != IntPtr.Zero && RemoveInstances_InstancesToRemove_IsValid && RemoveInstances_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:RemoveInstances", RemoveInstances_IsValid);
		RemoveInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveInstance");
		RemoveInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveInstance_InstanceIndex_PropertyAddress, RemoveInstance_FunctionAddress, "InstanceIndex");
		RemoveInstance_InstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInstance_FunctionAddress, "InstanceIndex");
		RemoveInstance_InstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInstance_FunctionAddress, "InstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInstance_ReturnValue_PropertyAddress, RemoveInstance_FunctionAddress, "ReturnValue");
		RemoveInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInstance_FunctionAddress, "ReturnValue");
		RemoveInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInstance_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveInstance_IsValid = RemoveInstance_FunctionAddress != IntPtr.Zero && RemoveInstance_InstanceIndex_IsValid && RemoveInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:RemoveInstance", RemoveInstance_IsValid);
		IsValidInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsValidInstance");
		IsValidInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidInstance_InstanceIndex_PropertyAddress, IsValidInstance_FunctionAddress, "InstanceIndex");
		IsValidInstance_InstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(IsValidInstance_FunctionAddress, "InstanceIndex");
		IsValidInstance_InstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidInstance_FunctionAddress, "InstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidInstance_ReturnValue_PropertyAddress, IsValidInstance_FunctionAddress, "ReturnValue");
		IsValidInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidInstance_FunctionAddress, "ReturnValue");
		IsValidInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidInstance_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidInstance_IsValid = IsValidInstance_FunctionAddress != IntPtr.Zero && IsValidInstance_InstanceIndex_IsValid && IsValidInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:IsValidInstance", IsValidInstance_IsValid);
		GetInstanceTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInstanceTransform");
		GetInstanceTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstanceTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstanceTransform_InstanceIndex_PropertyAddress, GetInstanceTransform_FunctionAddress, "InstanceIndex");
		GetInstanceTransform_InstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetInstanceTransform_FunctionAddress, "InstanceIndex");
		GetInstanceTransform_InstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstanceTransform_FunctionAddress, "InstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInstanceTransform_OutInstanceTransform_PropertyAddress, GetInstanceTransform_FunctionAddress, "OutInstanceTransform");
		GetInstanceTransform_OutInstanceTransform_Offset = NativeReflectionCached.GetPropertyOffset(GetInstanceTransform_FunctionAddress, "OutInstanceTransform");
		GetInstanceTransform_OutInstanceTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstanceTransform_FunctionAddress, "OutInstanceTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInstanceTransform_bWorldSpace_PropertyAddress, GetInstanceTransform_FunctionAddress, "bWorldSpace");
		GetInstanceTransform_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetInstanceTransform_FunctionAddress, "bWorldSpace");
		GetInstanceTransform_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstanceTransform_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInstanceTransform_ReturnValue_PropertyAddress, GetInstanceTransform_FunctionAddress, "ReturnValue");
		GetInstanceTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstanceTransform_FunctionAddress, "ReturnValue");
		GetInstanceTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstanceTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetInstanceTransform_IsValid = GetInstanceTransform_FunctionAddress != IntPtr.Zero && GetInstanceTransform_InstanceIndex_IsValid && GetInstanceTransform_OutInstanceTransform_IsValid && GetInstanceTransform_bWorldSpace_IsValid && GetInstanceTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:GetInstanceTransform", GetInstanceTransform_IsValid);
		GetInstancesOverlappingSphere_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInstancesOverlappingSphere");
		GetInstancesOverlappingSphere_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstancesOverlappingSphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstancesOverlappingSphere_Center_PropertyAddress, GetInstancesOverlappingSphere_FunctionAddress, "Center");
		GetInstancesOverlappingSphere_Center_Offset = NativeReflectionCached.GetPropertyOffset(GetInstancesOverlappingSphere_FunctionAddress, "Center");
		GetInstancesOverlappingSphere_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstancesOverlappingSphere_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInstancesOverlappingSphere_Radius_PropertyAddress, GetInstancesOverlappingSphere_FunctionAddress, "Radius");
		GetInstancesOverlappingSphere_Radius_Offset = NativeReflectionCached.GetPropertyOffset(GetInstancesOverlappingSphere_FunctionAddress, "Radius");
		GetInstancesOverlappingSphere_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstancesOverlappingSphere_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInstancesOverlappingSphere_bSphereInWorldSpace_PropertyAddress, GetInstancesOverlappingSphere_FunctionAddress, "bSphereInWorldSpace");
		GetInstancesOverlappingSphere_bSphereInWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetInstancesOverlappingSphere_FunctionAddress, "bSphereInWorldSpace");
		GetInstancesOverlappingSphere_bSphereInWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstancesOverlappingSphere_FunctionAddress, "bSphereInWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInstancesOverlappingSphere_ReturnValue_PropertyAddress, GetInstancesOverlappingSphere_FunctionAddress, "ReturnValue");
		GetInstancesOverlappingSphere_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstancesOverlappingSphere_FunctionAddress, "ReturnValue");
		GetInstancesOverlappingSphere_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstancesOverlappingSphere_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInstancesOverlappingSphere_IsValid = GetInstancesOverlappingSphere_FunctionAddress != IntPtr.Zero && GetInstancesOverlappingSphere_Center_IsValid && GetInstancesOverlappingSphere_Radius_IsValid && GetInstancesOverlappingSphere_bSphereInWorldSpace_IsValid && GetInstancesOverlappingSphere_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:GetInstancesOverlappingSphere", GetInstancesOverlappingSphere_IsValid);
		GetInstancesOverlappingBox_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInstancesOverlappingBox");
		GetInstancesOverlappingBox_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstancesOverlappingBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstancesOverlappingBox_Box_PropertyAddress, GetInstancesOverlappingBox_FunctionAddress, "Box");
		GetInstancesOverlappingBox_Box_Offset = NativeReflectionCached.GetPropertyOffset(GetInstancesOverlappingBox_FunctionAddress, "Box");
		GetInstancesOverlappingBox_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstancesOverlappingBox_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInstancesOverlappingBox_bBoxInWorldSpace_PropertyAddress, GetInstancesOverlappingBox_FunctionAddress, "bBoxInWorldSpace");
		GetInstancesOverlappingBox_bBoxInWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetInstancesOverlappingBox_FunctionAddress, "bBoxInWorldSpace");
		GetInstancesOverlappingBox_bBoxInWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstancesOverlappingBox_FunctionAddress, "bBoxInWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInstancesOverlappingBox_ReturnValue_PropertyAddress, GetInstancesOverlappingBox_FunctionAddress, "ReturnValue");
		GetInstancesOverlappingBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstancesOverlappingBox_FunctionAddress, "ReturnValue");
		GetInstancesOverlappingBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstancesOverlappingBox_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInstancesOverlappingBox_IsValid = GetInstancesOverlappingBox_FunctionAddress != IntPtr.Zero && GetInstancesOverlappingBox_Box_IsValid && GetInstancesOverlappingBox_bBoxInWorldSpace_IsValid && GetInstancesOverlappingBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:GetInstancesOverlappingBox", GetInstancesOverlappingBox_IsValid);
		GetInstanceCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInstanceCount");
		GetInstanceCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstanceCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstanceCount_ReturnValue_PropertyAddress, GetInstanceCount_FunctionAddress, "ReturnValue");
		GetInstanceCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstanceCount_FunctionAddress, "ReturnValue");
		GetInstanceCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstanceCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetInstanceCount_IsValid = GetInstanceCount_FunctionAddress != IntPtr.Zero && GetInstanceCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:GetInstanceCount", GetInstanceCount_IsValid);
		ClearInstances_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearInstances");
		ClearInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearInstances_FunctionAddress);
		ClearInstances_IsValid = ClearInstances_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:ClearInstances", ClearInstances_IsValid);
		BatchUpdateInstancesTransforms_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BatchUpdateInstancesTransforms");
		BatchUpdateInstancesTransforms_ParamsSize = NativeReflection.GetFunctionParamsSize(BatchUpdateInstancesTransforms_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransforms_StartInstanceIndex_PropertyAddress, BatchUpdateInstancesTransforms_FunctionAddress, "StartInstanceIndex");
		BatchUpdateInstancesTransforms_StartInstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransforms_FunctionAddress, "StartInstanceIndex");
		BatchUpdateInstancesTransforms_StartInstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransforms_FunctionAddress, "StartInstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransforms_NewInstancesTransforms_PropertyAddress, BatchUpdateInstancesTransforms_FunctionAddress, "NewInstancesTransforms");
		BatchUpdateInstancesTransforms_NewInstancesTransforms_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransforms_FunctionAddress, "NewInstancesTransforms");
		BatchUpdateInstancesTransforms_NewInstancesTransforms_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransforms_FunctionAddress, "NewInstancesTransforms", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransforms_bWorldSpace_PropertyAddress, BatchUpdateInstancesTransforms_FunctionAddress, "bWorldSpace");
		BatchUpdateInstancesTransforms_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransforms_FunctionAddress, "bWorldSpace");
		BatchUpdateInstancesTransforms_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransforms_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransforms_bMarkRenderStateDirty_PropertyAddress, BatchUpdateInstancesTransforms_FunctionAddress, "bMarkRenderStateDirty");
		BatchUpdateInstancesTransforms_bMarkRenderStateDirty_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransforms_FunctionAddress, "bMarkRenderStateDirty");
		BatchUpdateInstancesTransforms_bMarkRenderStateDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransforms_FunctionAddress, "bMarkRenderStateDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransforms_bTeleport_PropertyAddress, BatchUpdateInstancesTransforms_FunctionAddress, "bTeleport");
		BatchUpdateInstancesTransforms_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransforms_FunctionAddress, "bTeleport");
		BatchUpdateInstancesTransforms_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransforms_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransforms_ReturnValue_PropertyAddress, BatchUpdateInstancesTransforms_FunctionAddress, "ReturnValue");
		BatchUpdateInstancesTransforms_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransforms_FunctionAddress, "ReturnValue");
		BatchUpdateInstancesTransforms_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransforms_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BatchUpdateInstancesTransforms_IsValid = BatchUpdateInstancesTransforms_FunctionAddress != IntPtr.Zero && BatchUpdateInstancesTransforms_StartInstanceIndex_IsValid && BatchUpdateInstancesTransforms_NewInstancesTransforms_IsValid && BatchUpdateInstancesTransforms_bWorldSpace_IsValid && BatchUpdateInstancesTransforms_bMarkRenderStateDirty_IsValid && BatchUpdateInstancesTransforms_bTeleport_IsValid && BatchUpdateInstancesTransforms_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:BatchUpdateInstancesTransforms", BatchUpdateInstancesTransforms_IsValid);
		BatchUpdateInstancesTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BatchUpdateInstancesTransform");
		BatchUpdateInstancesTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(BatchUpdateInstancesTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransform_StartInstanceIndex_PropertyAddress, BatchUpdateInstancesTransform_FunctionAddress, "StartInstanceIndex");
		BatchUpdateInstancesTransform_StartInstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransform_FunctionAddress, "StartInstanceIndex");
		BatchUpdateInstancesTransform_StartInstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransform_FunctionAddress, "StartInstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransform_NumInstances_PropertyAddress, BatchUpdateInstancesTransform_FunctionAddress, "NumInstances");
		BatchUpdateInstancesTransform_NumInstances_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransform_FunctionAddress, "NumInstances");
		BatchUpdateInstancesTransform_NumInstances_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransform_FunctionAddress, "NumInstances", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransform_NewInstancesTransform_PropertyAddress, BatchUpdateInstancesTransform_FunctionAddress, "NewInstancesTransform");
		BatchUpdateInstancesTransform_NewInstancesTransform_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransform_FunctionAddress, "NewInstancesTransform");
		BatchUpdateInstancesTransform_NewInstancesTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransform_FunctionAddress, "NewInstancesTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransform_bWorldSpace_PropertyAddress, BatchUpdateInstancesTransform_FunctionAddress, "bWorldSpace");
		BatchUpdateInstancesTransform_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransform_FunctionAddress, "bWorldSpace");
		BatchUpdateInstancesTransform_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransform_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransform_bMarkRenderStateDirty_PropertyAddress, BatchUpdateInstancesTransform_FunctionAddress, "bMarkRenderStateDirty");
		BatchUpdateInstancesTransform_bMarkRenderStateDirty_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransform_FunctionAddress, "bMarkRenderStateDirty");
		BatchUpdateInstancesTransform_bMarkRenderStateDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransform_FunctionAddress, "bMarkRenderStateDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransform_bTeleport_PropertyAddress, BatchUpdateInstancesTransform_FunctionAddress, "bTeleport");
		BatchUpdateInstancesTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransform_FunctionAddress, "bTeleport");
		BatchUpdateInstancesTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BatchUpdateInstancesTransform_ReturnValue_PropertyAddress, BatchUpdateInstancesTransform_FunctionAddress, "ReturnValue");
		BatchUpdateInstancesTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BatchUpdateInstancesTransform_FunctionAddress, "ReturnValue");
		BatchUpdateInstancesTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BatchUpdateInstancesTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BatchUpdateInstancesTransform_IsValid = BatchUpdateInstancesTransform_FunctionAddress != IntPtr.Zero && BatchUpdateInstancesTransform_StartInstanceIndex_IsValid && BatchUpdateInstancesTransform_NumInstances_IsValid && BatchUpdateInstancesTransform_NewInstancesTransform_IsValid && BatchUpdateInstancesTransform_bWorldSpace_IsValid && BatchUpdateInstancesTransform_bMarkRenderStateDirty_IsValid && BatchUpdateInstancesTransform_bTeleport_IsValid && BatchUpdateInstancesTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:BatchUpdateInstancesTransform", BatchUpdateInstancesTransform_IsValid);
		AddInstances_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddInstances");
		AddInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInstances_InstanceTransforms_PropertyAddress, AddInstances_FunctionAddress, "InstanceTransforms");
		AddInstances_InstanceTransforms_Offset = NativeReflectionCached.GetPropertyOffset(AddInstances_FunctionAddress, "InstanceTransforms");
		AddInstances_InstanceTransforms_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstances_FunctionAddress, "InstanceTransforms", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstances_bShouldReturnIndices_PropertyAddress, AddInstances_FunctionAddress, "bShouldReturnIndices");
		AddInstances_bShouldReturnIndices_Offset = NativeReflectionCached.GetPropertyOffset(AddInstances_FunctionAddress, "bShouldReturnIndices");
		AddInstances_bShouldReturnIndices_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstances_FunctionAddress, "bShouldReturnIndices", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstances_bWorldSpace_PropertyAddress, AddInstances_FunctionAddress, "bWorldSpace");
		AddInstances_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(AddInstances_FunctionAddress, "bWorldSpace");
		AddInstances_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstances_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstances_ReturnValue_PropertyAddress, AddInstances_FunctionAddress, "ReturnValue");
		AddInstances_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddInstances_FunctionAddress, "ReturnValue");
		AddInstances_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstances_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		AddInstances_IsValid = AddInstances_FunctionAddress != IntPtr.Zero && AddInstances_InstanceTransforms_IsValid && AddInstances_bShouldReturnIndices_IsValid && AddInstances_bWorldSpace_IsValid && AddInstances_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:AddInstances", AddInstances_IsValid);
		AddInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddInstance");
		AddInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInstance_InstanceTransform_PropertyAddress, AddInstance_FunctionAddress, "InstanceTransform");
		AddInstance_InstanceTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddInstance_FunctionAddress, "InstanceTransform");
		AddInstance_InstanceTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstance_FunctionAddress, "InstanceTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstance_bWorldSpace_PropertyAddress, AddInstance_FunctionAddress, "bWorldSpace");
		AddInstance_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(AddInstance_FunctionAddress, "bWorldSpace");
		AddInstance_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstance_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstance_ReturnValue_PropertyAddress, AddInstance_FunctionAddress, "ReturnValue");
		AddInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddInstance_FunctionAddress, "ReturnValue");
		AddInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstance_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AddInstance_IsValid = AddInstance_FunctionAddress != IntPtr.Zero && AddInstance_InstanceTransform_IsValid && AddInstance_bWorldSpace_IsValid && AddInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstancedStaticMeshComponent:AddInstance", AddInstance_IsValid);
	}
}
