using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperGroupedSpriteComponent", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperGroupedSpriteComponent : UMeshComponent
{
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

	private static bool UpdateInstanceColor_IsValid;

	private static IntPtr UpdateInstanceColor_FunctionAddress;

	private static int UpdateInstanceColor_ParamsSize;

	private static bool UpdateInstanceColor_InstanceIndex_IsValid;

	private static FFieldAddress UpdateInstanceColor_InstanceIndex_PropertyAddress;

	private static int UpdateInstanceColor_InstanceIndex_Offset;

	private static bool UpdateInstanceColor_NewInstanceColor_IsValid;

	private static FFieldAddress UpdateInstanceColor_NewInstanceColor_PropertyAddress;

	private static int UpdateInstanceColor_NewInstanceColor_Offset;

	private static bool UpdateInstanceColor_bMarkRenderStateDirty_IsValid;

	private static FFieldAddress UpdateInstanceColor_bMarkRenderStateDirty_PropertyAddress;

	private static int UpdateInstanceColor_bMarkRenderStateDirty_Offset;

	private static bool UpdateInstanceColor_ReturnValue_IsValid;

	private static FFieldAddress UpdateInstanceColor_ReturnValue_PropertyAddress;

	private static int UpdateInstanceColor_ReturnValue_Offset;

	private static bool SortInstancesAlongAxis_IsValid;

	private static IntPtr SortInstancesAlongAxis_FunctionAddress;

	private static int SortInstancesAlongAxis_ParamsSize;

	private static bool SortInstancesAlongAxis_WorldSpaceSortAxis_IsValid;

	private static FFieldAddress SortInstancesAlongAxis_WorldSpaceSortAxis_PropertyAddress;

	private static int SortInstancesAlongAxis_WorldSpaceSortAxis_Offset;

	private static bool RemoveInstance_IsValid;

	private static IntPtr RemoveInstance_FunctionAddress;

	private static int RemoveInstance_ParamsSize;

	private static bool RemoveInstance_InstanceIndex_IsValid;

	private static FFieldAddress RemoveInstance_InstanceIndex_PropertyAddress;

	private static int RemoveInstance_InstanceIndex_Offset;

	private static bool RemoveInstance_ReturnValue_IsValid;

	private static FFieldAddress RemoveInstance_ReturnValue_PropertyAddress;

	private static int RemoveInstance_ReturnValue_Offset;

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

	private static bool GetInstanceCount_IsValid;

	private static IntPtr GetInstanceCount_FunctionAddress;

	private static int GetInstanceCount_ParamsSize;

	private static bool GetInstanceCount_ReturnValue_IsValid;

	private static FFieldAddress GetInstanceCount_ReturnValue_PropertyAddress;

	private static int GetInstanceCount_ReturnValue_Offset;

	private static bool ClearInstances_IsValid;

	private static IntPtr ClearInstances_FunctionAddress;

	private static int ClearInstances_ParamsSize;

	private static bool AddInstance_IsValid;

	private static IntPtr AddInstance_FunctionAddress;

	private static int AddInstance_ParamsSize;

	private static bool AddInstance_Transform_IsValid;

	private static FFieldAddress AddInstance_Transform_PropertyAddress;

	private static int AddInstance_Transform_Offset;

	private static bool AddInstance_Sprite_IsValid;

	private static FFieldAddress AddInstance_Sprite_PropertyAddress;

	private static int AddInstance_Sprite_Offset;

	private static bool AddInstance_bWorldSpace_IsValid;

	private static FFieldAddress AddInstance_bWorldSpace_PropertyAddress;

	private static int AddInstance_bWorldSpace_Offset;

	private static bool AddInstance_Color_IsValid;

	private static FFieldAddress AddInstance_Color_PropertyAddress;

	private static int AddInstance_Color_Offset;

	private static bool AddInstance_ReturnValue_IsValid;

	private static FFieldAddress AddInstance_ReturnValue_PropertyAddress;

	private static int AddInstance_ReturnValue_Offset;

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Paper2D.PaperGroupedSpriteComponent:UpdateInstanceTransform")]
	public unsafe bool UpdateInstanceTransform(int InstanceIndex, FTransform NewInstanceTransform, bool bWorldSpace = false, bool bMarkRenderStateDirty = true, bool bTeleport = false)
	{
		CheckDestroyed();
		if (!UpdateInstanceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperGroupedSpriteComponent:UpdateInstanceTransform");
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

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Paper2D.PaperGroupedSpriteComponent:UpdateInstanceColor")]
	public unsafe bool UpdateInstanceColor(int InstanceIndex, FLinearColor NewInstanceColor, bool bMarkRenderStateDirty = true)
	{
		CheckDestroyed();
		if (!UpdateInstanceColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperGroupedSpriteComponent:UpdateInstanceColor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateInstanceColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateInstanceColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UpdateInstanceColor_InstanceIndex_Offset), 0, UpdateInstanceColor_InstanceIndex_PropertyAddress.Address, InstanceIndex);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, UpdateInstanceColor_NewInstanceColor_Offset), 0, UpdateInstanceColor_NewInstanceColor_PropertyAddress.Address, NewInstanceColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UpdateInstanceColor_bMarkRenderStateDirty_Offset), 0, UpdateInstanceColor_bMarkRenderStateDirty_PropertyAddress.Address, bMarkRenderStateDirty);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateInstanceColor_FunctionAddress, intPtr, UpdateInstanceColor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, UpdateInstanceColor_ReturnValue_Offset), 0, UpdateInstanceColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Paper2D.PaperGroupedSpriteComponent:SortInstancesAlongAxis")]
	public unsafe void SortInstancesAlongAxis(FVector WorldSpaceSortAxis)
	{
		CheckDestroyed();
		if (!SortInstancesAlongAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperGroupedSpriteComponent:SortInstancesAlongAxis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortInstancesAlongAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortInstancesAlongAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SortInstancesAlongAxis_WorldSpaceSortAxis_Offset), 0, SortInstancesAlongAxis_WorldSpaceSortAxis_PropertyAddress.Address, WorldSpaceSortAxis);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortInstancesAlongAxis_FunctionAddress, intPtr, SortInstancesAlongAxis_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Paper2D.PaperGroupedSpriteComponent:RemoveInstance")]
	public unsafe bool RemoveInstance(int InstanceIndex)
	{
		CheckDestroyed();
		if (!RemoveInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperGroupedSpriteComponent:RemoveInstance");
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

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Paper2D.PaperGroupedSpriteComponent:GetInstanceTransform")]
	public unsafe bool GetInstanceTransform(int InstanceIndex, out FTransform OutInstanceTransform, bool bWorldSpace = false)
	{
		CheckDestroyed();
		if (!GetInstanceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperGroupedSpriteComponent:GetInstanceTransform");
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

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperGroupedSpriteComponent:GetInstanceCount")]
	public unsafe int GetInstanceCount()
	{
		CheckDestroyed();
		if (!GetInstanceCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperGroupedSpriteComponent:GetInstanceCount");
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
	[UMetaPath("/Script/Paper2D.PaperGroupedSpriteComponent:ClearInstances")]
	public unsafe void ClearInstances()
	{
		CheckDestroyed();
		if (!ClearInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperGroupedSpriteComponent:ClearInstances");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearInstances_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearInstances_FunctionAddress, argsSize: ClearInstances_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Paper2D.PaperGroupedSpriteComponent:AddInstance")]
	public unsafe int AddInstance(FTransform Transform, UPaperSprite Sprite, bool bWorldSpace, FLinearColor Color)
	{
		CheckDestroyed();
		if (!AddInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperGroupedSpriteComponent:AddInstance");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddInstance_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddInstance_Transform_Offset), 0, AddInstance_Transform_PropertyAddress.Address, Transform);
		UObjectMarshaler<UPaperSprite>.ToNative(IntPtr.Add(intPtr, AddInstance_Sprite_Offset), 0, AddInstance_Sprite_PropertyAddress.Address, Sprite);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInstance_bWorldSpace_Offset), 0, AddInstance_bWorldSpace_PropertyAddress.Address, bWorldSpace);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, AddInstance_Color_Offset), 0, AddInstance_Color_PropertyAddress.Address, Color);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddInstance_FunctionAddress, intPtr, AddInstance_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddInstance_ReturnValue_Offset), 0, AddInstance_ReturnValue_PropertyAddress.Address);
	}

	static UPaperGroupedSpriteComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperGroupedSpriteComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperGroupedSpriteComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Paper2D.PaperGroupedSpriteComponent");
		UpdateInstanceTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateInstanceTransform");
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
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperGroupedSpriteComponent:UpdateInstanceTransform", UpdateInstanceTransform_IsValid);
		UpdateInstanceColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateInstanceColor");
		UpdateInstanceColor_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateInstanceColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceColor_InstanceIndex_PropertyAddress, UpdateInstanceColor_FunctionAddress, "InstanceIndex");
		UpdateInstanceColor_InstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceColor_FunctionAddress, "InstanceIndex");
		UpdateInstanceColor_InstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceColor_FunctionAddress, "InstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceColor_NewInstanceColor_PropertyAddress, UpdateInstanceColor_FunctionAddress, "NewInstanceColor");
		UpdateInstanceColor_NewInstanceColor_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceColor_FunctionAddress, "NewInstanceColor");
		UpdateInstanceColor_NewInstanceColor_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceColor_FunctionAddress, "NewInstanceColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceColor_bMarkRenderStateDirty_PropertyAddress, UpdateInstanceColor_FunctionAddress, "bMarkRenderStateDirty");
		UpdateInstanceColor_bMarkRenderStateDirty_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceColor_FunctionAddress, "bMarkRenderStateDirty");
		UpdateInstanceColor_bMarkRenderStateDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceColor_FunctionAddress, "bMarkRenderStateDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateInstanceColor_ReturnValue_PropertyAddress, UpdateInstanceColor_FunctionAddress, "ReturnValue");
		UpdateInstanceColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateInstanceColor_FunctionAddress, "ReturnValue");
		UpdateInstanceColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateInstanceColor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		UpdateInstanceColor_IsValid = UpdateInstanceColor_FunctionAddress != IntPtr.Zero && UpdateInstanceColor_InstanceIndex_IsValid && UpdateInstanceColor_NewInstanceColor_IsValid && UpdateInstanceColor_bMarkRenderStateDirty_IsValid && UpdateInstanceColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperGroupedSpriteComponent:UpdateInstanceColor", UpdateInstanceColor_IsValid);
		SortInstancesAlongAxis_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SortInstancesAlongAxis");
		SortInstancesAlongAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(SortInstancesAlongAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortInstancesAlongAxis_WorldSpaceSortAxis_PropertyAddress, SortInstancesAlongAxis_FunctionAddress, "WorldSpaceSortAxis");
		SortInstancesAlongAxis_WorldSpaceSortAxis_Offset = NativeReflectionCached.GetPropertyOffset(SortInstancesAlongAxis_FunctionAddress, "WorldSpaceSortAxis");
		SortInstancesAlongAxis_WorldSpaceSortAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(SortInstancesAlongAxis_FunctionAddress, "WorldSpaceSortAxis", Classes.FStructProperty);
		SortInstancesAlongAxis_IsValid = SortInstancesAlongAxis_FunctionAddress != IntPtr.Zero && SortInstancesAlongAxis_WorldSpaceSortAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperGroupedSpriteComponent:SortInstancesAlongAxis", SortInstancesAlongAxis_IsValid);
		RemoveInstance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveInstance");
		RemoveInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveInstance_InstanceIndex_PropertyAddress, RemoveInstance_FunctionAddress, "InstanceIndex");
		RemoveInstance_InstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInstance_FunctionAddress, "InstanceIndex");
		RemoveInstance_InstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInstance_FunctionAddress, "InstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInstance_ReturnValue_PropertyAddress, RemoveInstance_FunctionAddress, "ReturnValue");
		RemoveInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInstance_FunctionAddress, "ReturnValue");
		RemoveInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInstance_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveInstance_IsValid = RemoveInstance_FunctionAddress != IntPtr.Zero && RemoveInstance_InstanceIndex_IsValid && RemoveInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperGroupedSpriteComponent:RemoveInstance", RemoveInstance_IsValid);
		GetInstanceTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInstanceTransform");
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
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperGroupedSpriteComponent:GetInstanceTransform", GetInstanceTransform_IsValid);
		GetInstanceCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInstanceCount");
		GetInstanceCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstanceCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstanceCount_ReturnValue_PropertyAddress, GetInstanceCount_FunctionAddress, "ReturnValue");
		GetInstanceCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstanceCount_FunctionAddress, "ReturnValue");
		GetInstanceCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstanceCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetInstanceCount_IsValid = GetInstanceCount_FunctionAddress != IntPtr.Zero && GetInstanceCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperGroupedSpriteComponent:GetInstanceCount", GetInstanceCount_IsValid);
		ClearInstances_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearInstances");
		ClearInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearInstances_FunctionAddress);
		ClearInstances_IsValid = ClearInstances_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperGroupedSpriteComponent:ClearInstances", ClearInstances_IsValid);
		AddInstance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddInstance");
		AddInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInstance_Transform_PropertyAddress, AddInstance_FunctionAddress, "Transform");
		AddInstance_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AddInstance_FunctionAddress, "Transform");
		AddInstance_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstance_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstance_Sprite_PropertyAddress, AddInstance_FunctionAddress, "Sprite");
		AddInstance_Sprite_Offset = NativeReflectionCached.GetPropertyOffset(AddInstance_FunctionAddress, "Sprite");
		AddInstance_Sprite_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstance_FunctionAddress, "Sprite", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstance_bWorldSpace_PropertyAddress, AddInstance_FunctionAddress, "bWorldSpace");
		AddInstance_bWorldSpace_Offset = NativeReflectionCached.GetPropertyOffset(AddInstance_FunctionAddress, "bWorldSpace");
		AddInstance_bWorldSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstance_FunctionAddress, "bWorldSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstance_Color_PropertyAddress, AddInstance_FunctionAddress, "Color");
		AddInstance_Color_Offset = NativeReflectionCached.GetPropertyOffset(AddInstance_FunctionAddress, "Color");
		AddInstance_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstance_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstance_ReturnValue_PropertyAddress, AddInstance_FunctionAddress, "ReturnValue");
		AddInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddInstance_FunctionAddress, "ReturnValue");
		AddInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstance_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AddInstance_IsValid = AddInstance_FunctionAddress != IntPtr.Zero && AddInstance_Transform_IsValid && AddInstance_Sprite_IsValid && AddInstance_bWorldSpace_IsValid && AddInstance_Color_IsValid && AddInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperGroupedSpriteComponent:AddInstance", AddInstance_IsValid);
	}
}
