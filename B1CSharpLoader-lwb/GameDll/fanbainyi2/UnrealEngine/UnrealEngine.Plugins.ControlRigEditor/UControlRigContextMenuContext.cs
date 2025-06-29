using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Plugins.ControlRig;
using UnrealEngine.Plugins.ControlRigDeveloper;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.ControlRigContextMenuContext", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public class UControlRigContextMenuContext : UObject
{
	private static bool IsAltDown_IsValid;

	private static IntPtr IsAltDown_FunctionAddress;

	private static int IsAltDown_ParamsSize;

	private static bool IsAltDown_ReturnValue_IsValid;

	private static FFieldAddress IsAltDown_ReturnValue_PropertyAddress;

	private static int IsAltDown_ReturnValue_Offset;

	private static bool GetRigHierarchyToGraphDragAndDropContext_IsValid;

	private static IntPtr GetRigHierarchyToGraphDragAndDropContext_FunctionAddress;

	private static int GetRigHierarchyToGraphDragAndDropContext_ParamsSize;

	private static bool GetRigHierarchyToGraphDragAndDropContext_ReturnValue_IsValid;

	private static FFieldAddress GetRigHierarchyToGraphDragAndDropContext_ReturnValue_PropertyAddress;

	private static int GetRigHierarchyToGraphDragAndDropContext_ReturnValue_Offset;

	private static bool GetRigHierarchyDragAndDropContext_IsValid;

	private static IntPtr GetRigHierarchyDragAndDropContext_FunctionAddress;

	private static int GetRigHierarchyDragAndDropContext_ParamsSize;

	private static bool GetRigHierarchyDragAndDropContext_ReturnValue_IsValid;

	private static FFieldAddress GetRigHierarchyDragAndDropContext_ReturnValue_PropertyAddress;

	private static int GetRigHierarchyDragAndDropContext_ReturnValue_Offset;

	private static bool GetGraphNodeContextMenuContext_IsValid;

	private static IntPtr GetGraphNodeContextMenuContext_FunctionAddress;

	private static int GetGraphNodeContextMenuContext_ParamsSize;

	private static bool GetGraphNodeContextMenuContext_ReturnValue_IsValid;

	private static FFieldAddress GetGraphNodeContextMenuContext_ReturnValue_PropertyAddress;

	private static int GetGraphNodeContextMenuContext_ReturnValue_Offset;

	private static bool GetControlRigBlueprint_IsValid;

	private static IntPtr GetControlRigBlueprint_FunctionAddress;

	private static int GetControlRigBlueprint_ParamsSize;

	private static bool GetControlRigBlueprint_ReturnValue_IsValid;

	private static FFieldAddress GetControlRigBlueprint_ReturnValue_PropertyAddress;

	private static int GetControlRigBlueprint_ReturnValue_Offset;

	private static bool GetControlRig_IsValid;

	private static IntPtr GetControlRig_FunctionAddress;

	private static int GetControlRig_ParamsSize;

	private static bool GetControlRig_ReturnValue_IsValid;

	private static FFieldAddress GetControlRig_ReturnValue_PropertyAddress;

	private static int GetControlRig_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigContextMenuContext:IsAltDown")]
	public unsafe bool IsAltDown()
	{
		CheckDestroyed();
		if (!IsAltDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigContextMenuContext:IsAltDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAltDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAltDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsAltDown_FunctionAddress, intPtr, IsAltDown_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAltDown_ReturnValue_Offset), 0, IsAltDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigContextMenuContext:GetRigHierarchyToGraphDragAndDropContext")]
	public unsafe FControlRigRigHierarchyToGraphDragAndDropContext GetRigHierarchyToGraphDragAndDropContext()
	{
		CheckDestroyed();
		if (!GetRigHierarchyToGraphDragAndDropContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigContextMenuContext:GetRigHierarchyToGraphDragAndDropContext");
			return default(FControlRigRigHierarchyToGraphDragAndDropContext);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRigHierarchyToGraphDragAndDropContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRigHierarchyToGraphDragAndDropContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRigHierarchyToGraphDragAndDropContext_FunctionAddress, intPtr, GetRigHierarchyToGraphDragAndDropContext_ParamsSize);
		FControlRigRigHierarchyToGraphDragAndDropContext result = FControlRigRigHierarchyToGraphDragAndDropContext.FromNative(IntPtr.Add(intPtr, GetRigHierarchyToGraphDragAndDropContext_ReturnValue_Offset), 0, GetRigHierarchyToGraphDragAndDropContext_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetRigHierarchyToGraphDragAndDropContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigContextMenuContext:GetRigHierarchyDragAndDropContext")]
	public unsafe FControlRigRigHierarchyDragAndDropContext GetRigHierarchyDragAndDropContext()
	{
		CheckDestroyed();
		if (!GetRigHierarchyDragAndDropContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigContextMenuContext:GetRigHierarchyDragAndDropContext");
			return default(FControlRigRigHierarchyDragAndDropContext);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRigHierarchyDragAndDropContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRigHierarchyDragAndDropContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRigHierarchyDragAndDropContext_FunctionAddress, intPtr, GetRigHierarchyDragAndDropContext_ParamsSize);
		FControlRigRigHierarchyDragAndDropContext result = FControlRigRigHierarchyDragAndDropContext.FromNative(IntPtr.Add(intPtr, GetRigHierarchyDragAndDropContext_ReturnValue_Offset), 0, GetRigHierarchyDragAndDropContext_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetRigHierarchyDragAndDropContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigContextMenuContext:GetGraphNodeContextMenuContext")]
	public unsafe FControlRigGraphNodeContextMenuContext GetGraphNodeContextMenuContext()
	{
		CheckDestroyed();
		if (!GetGraphNodeContextMenuContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigContextMenuContext:GetGraphNodeContextMenuContext");
			return default(FControlRigGraphNodeContextMenuContext);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraphNodeContextMenuContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraphNodeContextMenuContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraphNodeContextMenuContext_FunctionAddress, intPtr, GetGraphNodeContextMenuContext_ParamsSize);
		return FControlRigGraphNodeContextMenuContext.FromNative(IntPtr.Add(intPtr, GetGraphNodeContextMenuContext_ReturnValue_Offset), 0, GetGraphNodeContextMenuContext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigContextMenuContext:GetControlRigBlueprint")]
	public unsafe UControlRigBlueprint GetControlRigBlueprint()
	{
		CheckDestroyed();
		if (!GetControlRigBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigContextMenuContext:GetControlRigBlueprint");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlRigBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlRigBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlRigBlueprint_FunctionAddress, intPtr, GetControlRigBlueprint_ParamsSize);
		return UObjectMarshaler<UControlRigBlueprint>.FromNative(IntPtr.Add(intPtr, GetControlRigBlueprint_ReturnValue_Offset), 0, GetControlRigBlueprint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigContextMenuContext:GetControlRig")]
	public unsafe UControlRig GetControlRig()
	{
		CheckDestroyed();
		if (!GetControlRig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRigEditor.ControlRigContextMenuContext:GetControlRig");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlRig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlRig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlRig_FunctionAddress, intPtr, GetControlRig_ParamsSize);
		return UObjectMarshaler<UControlRig>.FromNative(IntPtr.Add(intPtr, GetControlRig_ReturnValue_Offset), 0, GetControlRig_ReturnValue_PropertyAddress.Address);
	}

	static UControlRigContextMenuContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UControlRigContextMenuContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UControlRigContextMenuContext));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ControlRigEditor.ControlRigContextMenuContext");
		IsAltDown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsAltDown");
		IsAltDown_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAltDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAltDown_ReturnValue_PropertyAddress, IsAltDown_FunctionAddress, "ReturnValue");
		IsAltDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAltDown_FunctionAddress, "ReturnValue");
		IsAltDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAltDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAltDown_IsValid = IsAltDown_FunctionAddress != IntPtr.Zero && IsAltDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigContextMenuContext:IsAltDown", IsAltDown_IsValid);
		GetRigHierarchyToGraphDragAndDropContext_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRigHierarchyToGraphDragAndDropContext");
		GetRigHierarchyToGraphDragAndDropContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRigHierarchyToGraphDragAndDropContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRigHierarchyToGraphDragAndDropContext_ReturnValue_PropertyAddress, GetRigHierarchyToGraphDragAndDropContext_FunctionAddress, "ReturnValue");
		GetRigHierarchyToGraphDragAndDropContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRigHierarchyToGraphDragAndDropContext_FunctionAddress, "ReturnValue");
		GetRigHierarchyToGraphDragAndDropContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRigHierarchyToGraphDragAndDropContext_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRigHierarchyToGraphDragAndDropContext_IsValid = GetRigHierarchyToGraphDragAndDropContext_FunctionAddress != IntPtr.Zero && GetRigHierarchyToGraphDragAndDropContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigContextMenuContext:GetRigHierarchyToGraphDragAndDropContext", GetRigHierarchyToGraphDragAndDropContext_IsValid);
		GetRigHierarchyDragAndDropContext_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRigHierarchyDragAndDropContext");
		GetRigHierarchyDragAndDropContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRigHierarchyDragAndDropContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRigHierarchyDragAndDropContext_ReturnValue_PropertyAddress, GetRigHierarchyDragAndDropContext_FunctionAddress, "ReturnValue");
		GetRigHierarchyDragAndDropContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRigHierarchyDragAndDropContext_FunctionAddress, "ReturnValue");
		GetRigHierarchyDragAndDropContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRigHierarchyDragAndDropContext_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRigHierarchyDragAndDropContext_IsValid = GetRigHierarchyDragAndDropContext_FunctionAddress != IntPtr.Zero && GetRigHierarchyDragAndDropContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigContextMenuContext:GetRigHierarchyDragAndDropContext", GetRigHierarchyDragAndDropContext_IsValid);
		GetGraphNodeContextMenuContext_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGraphNodeContextMenuContext");
		GetGraphNodeContextMenuContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraphNodeContextMenuContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraphNodeContextMenuContext_ReturnValue_PropertyAddress, GetGraphNodeContextMenuContext_FunctionAddress, "ReturnValue");
		GetGraphNodeContextMenuContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphNodeContextMenuContext_FunctionAddress, "ReturnValue");
		GetGraphNodeContextMenuContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphNodeContextMenuContext_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGraphNodeContextMenuContext_IsValid = GetGraphNodeContextMenuContext_FunctionAddress != IntPtr.Zero && GetGraphNodeContextMenuContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigContextMenuContext:GetGraphNodeContextMenuContext", GetGraphNodeContextMenuContext_IsValid);
		GetControlRigBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetControlRigBlueprint");
		GetControlRigBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlRigBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlRigBlueprint_ReturnValue_PropertyAddress, GetControlRigBlueprint_FunctionAddress, "ReturnValue");
		GetControlRigBlueprint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlRigBlueprint_FunctionAddress, "ReturnValue");
		GetControlRigBlueprint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlRigBlueprint_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetControlRigBlueprint_IsValid = GetControlRigBlueprint_FunctionAddress != IntPtr.Zero && GetControlRigBlueprint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigContextMenuContext:GetControlRigBlueprint", GetControlRigBlueprint_IsValid);
		GetControlRig_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetControlRig");
		GetControlRig_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlRig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlRig_ReturnValue_PropertyAddress, GetControlRig_FunctionAddress, "ReturnValue");
		GetControlRig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlRig_FunctionAddress, "ReturnValue");
		GetControlRig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlRig_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetControlRig_IsValid = GetControlRig_FunctionAddress != IntPtr.Zero && GetControlRig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRigEditor.ControlRigContextMenuContext:GetControlRig", GetControlRig_IsValid);
	}
}
