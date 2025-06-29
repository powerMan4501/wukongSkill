using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.SubobjectDataInterface;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary", "SubobjectDataInterface", UnrealModuleType.Engine)]
public class USubobjectDataBlueprintFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsValid_IsValid;

	private static IntPtr IsValid_FunctionAddress;

	private static int IsValid_ParamsSize;

	private static bool IsValid_Data_IsValid;

	private static FFieldAddress IsValid_Data_PropertyAddress;

	private static int IsValid_Data_Offset;

	private static bool IsValid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_ReturnValue_PropertyAddress;

	private static int IsValid_ReturnValue_Offset;

	private static bool IsSceneComponent_IsValid;

	private static IntPtr IsSceneComponent_FunctionAddress;

	private static int IsSceneComponent_ParamsSize;

	private static bool IsSceneComponent_Data_IsValid;

	private static FFieldAddress IsSceneComponent_Data_PropertyAddress;

	private static int IsSceneComponent_Data_Offset;

	private static bool IsSceneComponent_ReturnValue_IsValid;

	private static FFieldAddress IsSceneComponent_ReturnValue_PropertyAddress;

	private static int IsSceneComponent_ReturnValue_Offset;

	private static bool IsRootComponent_IsValid;

	private static IntPtr IsRootComponent_FunctionAddress;

	private static int IsRootComponent_ParamsSize;

	private static bool IsRootComponent_Data_IsValid;

	private static FFieldAddress IsRootComponent_Data_PropertyAddress;

	private static int IsRootComponent_Data_Offset;

	private static bool IsRootComponent_ReturnValue_IsValid;

	private static FFieldAddress IsRootComponent_ReturnValue_PropertyAddress;

	private static int IsRootComponent_ReturnValue_Offset;

	private static bool IsRootActor_IsValid;

	private static IntPtr IsRootActor_FunctionAddress;

	private static int IsRootActor_ParamsSize;

	private static bool IsRootActor_Data_IsValid;

	private static FFieldAddress IsRootActor_Data_PropertyAddress;

	private static int IsRootActor_Data_Offset;

	private static bool IsRootActor_ReturnValue_IsValid;

	private static FFieldAddress IsRootActor_ReturnValue_PropertyAddress;

	private static int IsRootActor_ReturnValue_Offset;

	private static bool IsNativeComponent_IsValid;

	private static IntPtr IsNativeComponent_FunctionAddress;

	private static int IsNativeComponent_ParamsSize;

	private static bool IsNativeComponent_Data_IsValid;

	private static FFieldAddress IsNativeComponent_Data_PropertyAddress;

	private static int IsNativeComponent_Data_Offset;

	private static bool IsNativeComponent_ReturnValue_IsValid;

	private static FFieldAddress IsNativeComponent_ReturnValue_PropertyAddress;

	private static int IsNativeComponent_ReturnValue_Offset;

	private static bool IsInstancedComponent_IsValid;

	private static IntPtr IsInstancedComponent_FunctionAddress;

	private static int IsInstancedComponent_ParamsSize;

	private static bool IsInstancedComponent_Data_IsValid;

	private static FFieldAddress IsInstancedComponent_Data_PropertyAddress;

	private static int IsInstancedComponent_Data_Offset;

	private static bool IsInstancedComponent_ReturnValue_IsValid;

	private static FFieldAddress IsInstancedComponent_ReturnValue_PropertyAddress;

	private static int IsInstancedComponent_ReturnValue_Offset;

	private static bool IsInstancedActor_IsValid;

	private static IntPtr IsInstancedActor_FunctionAddress;

	private static int IsInstancedActor_ParamsSize;

	private static bool IsInstancedActor_Data_IsValid;

	private static FFieldAddress IsInstancedActor_Data_PropertyAddress;

	private static int IsInstancedActor_Data_Offset;

	private static bool IsInstancedActor_ReturnValue_IsValid;

	private static FFieldAddress IsInstancedActor_ReturnValue_PropertyAddress;

	private static int IsInstancedActor_ReturnValue_Offset;

	private static bool IsInheritedComponent_IsValid;

	private static IntPtr IsInheritedComponent_FunctionAddress;

	private static int IsInheritedComponent_ParamsSize;

	private static bool IsInheritedComponent_Data_IsValid;

	private static FFieldAddress IsInheritedComponent_Data_PropertyAddress;

	private static int IsInheritedComponent_Data_Offset;

	private static bool IsInheritedComponent_ReturnValue_IsValid;

	private static FFieldAddress IsInheritedComponent_ReturnValue_PropertyAddress;

	private static int IsInheritedComponent_ReturnValue_Offset;

	private static bool IsHandleValid_IsValid;

	private static IntPtr IsHandleValid_FunctionAddress;

	private static int IsHandleValid_ParamsSize;

	private static bool IsHandleValid_DataHandle_IsValid;

	private static FFieldAddress IsHandleValid_DataHandle_PropertyAddress;

	private static int IsHandleValid_DataHandle_Offset;

	private static bool IsHandleValid_ReturnValue_IsValid;

	private static FFieldAddress IsHandleValid_ReturnValue_PropertyAddress;

	private static int IsHandleValid_ReturnValue_Offset;

	private static bool IsDefaultSceneRoot_IsValid;

	private static IntPtr IsDefaultSceneRoot_FunctionAddress;

	private static int IsDefaultSceneRoot_ParamsSize;

	private static bool IsDefaultSceneRoot_Data_IsValid;

	private static FFieldAddress IsDefaultSceneRoot_Data_PropertyAddress;

	private static int IsDefaultSceneRoot_Data_Offset;

	private static bool IsDefaultSceneRoot_ReturnValue_IsValid;

	private static FFieldAddress IsDefaultSceneRoot_ReturnValue_PropertyAddress;

	private static int IsDefaultSceneRoot_ReturnValue_Offset;

	private static bool IsComponent_IsValid;

	private static IntPtr IsComponent_FunctionAddress;

	private static int IsComponent_ParamsSize;

	private static bool IsComponent_Data_IsValid;

	private static FFieldAddress IsComponent_Data_PropertyAddress;

	private static int IsComponent_Data_Offset;

	private static bool IsComponent_ReturnValue_IsValid;

	private static FFieldAddress IsComponent_ReturnValue_PropertyAddress;

	private static int IsComponent_ReturnValue_Offset;

	private static bool IsChildActor_IsValid;

	private static IntPtr IsChildActor_FunctionAddress;

	private static int IsChildActor_ParamsSize;

	private static bool IsChildActor_Data_IsValid;

	private static FFieldAddress IsChildActor_Data_PropertyAddress;

	private static int IsChildActor_Data_Offset;

	private static bool IsChildActor_ReturnValue_IsValid;

	private static FFieldAddress IsChildActor_ReturnValue_PropertyAddress;

	private static int IsChildActor_ReturnValue_Offset;

	private static bool IsAttachedTo_IsValid;

	private static IntPtr IsAttachedTo_FunctionAddress;

	private static int IsAttachedTo_ParamsSize;

	private static bool IsAttachedTo_Data_IsValid;

	private static FFieldAddress IsAttachedTo_Data_PropertyAddress;

	private static int IsAttachedTo_Data_Offset;

	private static bool IsAttachedTo_InHandle_IsValid;

	private static FFieldAddress IsAttachedTo_InHandle_PropertyAddress;

	private static int IsAttachedTo_InHandle_Offset;

	private static bool IsAttachedTo_ReturnValue_IsValid;

	private static FFieldAddress IsAttachedTo_ReturnValue_PropertyAddress;

	private static int IsAttachedTo_ReturnValue_Offset;

	private static bool IsActor_IsValid;

	private static IntPtr IsActor_FunctionAddress;

	private static int IsActor_ParamsSize;

	private static bool IsActor_Data_IsValid;

	private static FFieldAddress IsActor_Data_PropertyAddress;

	private static int IsActor_Data_Offset;

	private static bool IsActor_ReturnValue_IsValid;

	private static FFieldAddress IsActor_ReturnValue_PropertyAddress;

	private static int IsActor_ReturnValue_Offset;

	private static bool GetVariableName_IsValid;

	private static IntPtr GetVariableName_FunctionAddress;

	private static int GetVariableName_ParamsSize;

	private static bool GetVariableName_Data_IsValid;

	private static FFieldAddress GetVariableName_Data_PropertyAddress;

	private static int GetVariableName_Data_Offset;

	private static bool GetVariableName_ReturnValue_IsValid;

	private static FFieldAddress GetVariableName_ReturnValue_PropertyAddress;

	private static int GetVariableName_ReturnValue_Offset;

	private static bool GetObject_IsValid;

	private static IntPtr GetObject_FunctionAddress;

	private static int GetObject_ParamsSize;

	private static bool GetObject_Data_IsValid;

	private static FFieldAddress GetObject_Data_PropertyAddress;

	private static int GetObject_Data_Offset;

	private static bool GetObject_bEvenIfPendingKill_IsValid;

	private static FFieldAddress GetObject_bEvenIfPendingKill_PropertyAddress;

	private static int GetObject_bEvenIfPendingKill_Offset;

	private static bool GetObject_ReturnValue_IsValid;

	private static FFieldAddress GetObject_ReturnValue_PropertyAddress;

	private static int GetObject_ReturnValue_Offset;

	private static bool GetHandle_IsValid;

	private static IntPtr GetHandle_FunctionAddress;

	private static int GetHandle_ParamsSize;

	private static bool GetHandle_Data_IsValid;

	private static FFieldAddress GetHandle_Data_PropertyAddress;

	private static int GetHandle_Data_Offset;

	private static bool GetHandle_OutHandle_IsValid;

	private static FFieldAddress GetHandle_OutHandle_PropertyAddress;

	private static int GetHandle_OutHandle_Offset;

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_Data_IsValid;

	private static FFieldAddress GetDisplayName_Data_PropertyAddress;

	private static int GetDisplayName_Data_Offset;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	private static int GetDisplayName_ReturnValue_Offset;

	private static bool GetData_IsValid;

	private static IntPtr GetData_FunctionAddress;

	private static int GetData_ParamsSize;

	private static bool GetData_DataHandle_IsValid;

	private static FFieldAddress GetData_DataHandle_PropertyAddress;

	private static int GetData_DataHandle_Offset;

	private static bool GetData_OutData_IsValid;

	private static FFieldAddress GetData_OutData_PropertyAddress;

	private static int GetData_OutData_Offset;

	private static bool GetBlueprint_IsValid;

	private static IntPtr GetBlueprint_FunctionAddress;

	private static int GetBlueprint_ParamsSize;

	private static bool GetBlueprint_Data_IsValid;

	private static FFieldAddress GetBlueprint_Data_PropertyAddress;

	private static int GetBlueprint_Data_Offset;

	private static bool GetBlueprint_ReturnValue_IsValid;

	private static FFieldAddress GetBlueprint_ReturnValue_PropertyAddress;

	private static int GetBlueprint_ReturnValue_Offset;

	private static bool CanReparent_IsValid;

	private static IntPtr CanReparent_FunctionAddress;

	private static int CanReparent_ParamsSize;

	private static bool CanReparent_Data_IsValid;

	private static FFieldAddress CanReparent_Data_PropertyAddress;

	private static int CanReparent_Data_Offset;

	private static bool CanReparent_ReturnValue_IsValid;

	private static FFieldAddress CanReparent_ReturnValue_PropertyAddress;

	private static int CanReparent_ReturnValue_Offset;

	private static bool CanRename_IsValid;

	private static IntPtr CanRename_FunctionAddress;

	private static int CanRename_ParamsSize;

	private static bool CanRename_Data_IsValid;

	private static FFieldAddress CanRename_Data_PropertyAddress;

	private static int CanRename_Data_Offset;

	private static bool CanRename_ReturnValue_IsValid;

	private static FFieldAddress CanRename_ReturnValue_PropertyAddress;

	private static int CanRename_ReturnValue_Offset;

	private static bool CanEdit_IsValid;

	private static IntPtr CanEdit_FunctionAddress;

	private static int CanEdit_ParamsSize;

	private static bool CanEdit_Data_IsValid;

	private static FFieldAddress CanEdit_Data_PropertyAddress;

	private static int CanEdit_Data_Offset;

	private static bool CanEdit_ReturnValue_IsValid;

	private static FFieldAddress CanEdit_ReturnValue_PropertyAddress;

	private static int CanEdit_ReturnValue_Offset;

	private static bool CanDuplicate_IsValid;

	private static IntPtr CanDuplicate_FunctionAddress;

	private static int CanDuplicate_ParamsSize;

	private static bool CanDuplicate_Data_IsValid;

	private static FFieldAddress CanDuplicate_Data_PropertyAddress;

	private static int CanDuplicate_Data_Offset;

	private static bool CanDuplicate_ReturnValue_IsValid;

	private static FFieldAddress CanDuplicate_ReturnValue_PropertyAddress;

	private static int CanDuplicate_ReturnValue_Offset;

	private static bool CanDelete_IsValid;

	private static IntPtr CanDelete_FunctionAddress;

	private static int CanDelete_ParamsSize;

	private static bool CanDelete_Data_IsValid;

	private static FFieldAddress CanDelete_Data_PropertyAddress;

	private static int CanDelete_Data_Offset;

	private static bool CanDelete_ReturnValue_IsValid;

	private static FFieldAddress CanDelete_ReturnValue_PropertyAddress;

	private static int CanDelete_ReturnValue_Offset;

	private static bool CanCopy_IsValid;

	private static IntPtr CanCopy_FunctionAddress;

	private static int CanCopy_ParamsSize;

	private static bool CanCopy_Data_IsValid;

	private static FFieldAddress CanCopy_Data_PropertyAddress;

	private static int CanCopy_Data_Offset;

	private static bool CanCopy_ReturnValue_IsValid;

	private static FFieldAddress CanCopy_ReturnValue_PropertyAddress;

	private static int CanCopy_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsValid")]
	public unsafe static bool IsValid(FSubobjectData Data)
	{
		if (!IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsValid_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsValid_Data_Offset), 0, IsValid_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_FunctionAddress, intPtr, IsValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsValid_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_ReturnValue_Offset), 0, IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsSceneComponent")]
	public unsafe static bool IsSceneComponent(FSubobjectData Data)
	{
		if (!IsSceneComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsSceneComponent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSceneComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSceneComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsSceneComponent_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsSceneComponent_Data_Offset), 0, IsSceneComponent_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsSceneComponent_FunctionAddress, intPtr, IsSceneComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsSceneComponent_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSceneComponent_ReturnValue_Offset), 0, IsSceneComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsRootComponent")]
	public unsafe static bool IsRootComponent(FSubobjectData Data)
	{
		if (!IsRootComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsRootComponent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRootComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRootComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsRootComponent_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsRootComponent_Data_Offset), 0, IsRootComponent_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRootComponent_FunctionAddress, intPtr, IsRootComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsRootComponent_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRootComponent_ReturnValue_Offset), 0, IsRootComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsRootActor")]
	public unsafe static bool IsRootActor(FSubobjectData Data)
	{
		if (!IsRootActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsRootActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRootActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRootActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsRootActor_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsRootActor_Data_Offset), 0, IsRootActor_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRootActor_FunctionAddress, intPtr, IsRootActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsRootActor_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRootActor_ReturnValue_Offset), 0, IsRootActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsNativeComponent")]
	public unsafe static bool IsNativeComponent(FSubobjectData Data)
	{
		if (!IsNativeComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsNativeComponent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNativeComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNativeComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsNativeComponent_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsNativeComponent_Data_Offset), 0, IsNativeComponent_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsNativeComponent_FunctionAddress, intPtr, IsNativeComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsNativeComponent_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNativeComponent_ReturnValue_Offset), 0, IsNativeComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsInstancedComponent")]
	public unsafe static bool IsInstancedComponent(FSubobjectData Data)
	{
		if (!IsInstancedComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsInstancedComponent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInstancedComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInstancedComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsInstancedComponent_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsInstancedComponent_Data_Offset), 0, IsInstancedComponent_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsInstancedComponent_FunctionAddress, intPtr, IsInstancedComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsInstancedComponent_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInstancedComponent_ReturnValue_Offset), 0, IsInstancedComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsInstancedActor")]
	public unsafe static bool IsInstancedActor(FSubobjectData Data)
	{
		if (!IsInstancedActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsInstancedActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInstancedActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInstancedActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsInstancedActor_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsInstancedActor_Data_Offset), 0, IsInstancedActor_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsInstancedActor_FunctionAddress, intPtr, IsInstancedActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsInstancedActor_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInstancedActor_ReturnValue_Offset), 0, IsInstancedActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsInheritedComponent")]
	public unsafe static bool IsInheritedComponent(FSubobjectData Data)
	{
		if (!IsInheritedComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsInheritedComponent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInheritedComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInheritedComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsInheritedComponent_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsInheritedComponent_Data_Offset), 0, IsInheritedComponent_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsInheritedComponent_FunctionAddress, intPtr, IsInheritedComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsInheritedComponent_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInheritedComponent_ReturnValue_Offset), 0, IsInheritedComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsHandleValid")]
	public unsafe static bool IsHandleValid(FSubobjectDataHandle DataHandle)
	{
		if (!IsHandleValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsHandleValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsHandleValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsHandleValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsHandleValid_DataHandle_PropertyAddress.Address, intPtr);
		FSubobjectDataHandle.ToNative(IntPtr.Add(intPtr, IsHandleValid_DataHandle_Offset), 0, IsHandleValid_DataHandle_PropertyAddress.Address, DataHandle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsHandleValid_FunctionAddress, intPtr, IsHandleValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsHandleValid_DataHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsHandleValid_ReturnValue_Offset), 0, IsHandleValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsDefaultSceneRoot")]
	public unsafe static bool IsDefaultSceneRoot(FSubobjectData Data)
	{
		if (!IsDefaultSceneRoot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsDefaultSceneRoot");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDefaultSceneRoot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDefaultSceneRoot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsDefaultSceneRoot_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsDefaultSceneRoot_Data_Offset), 0, IsDefaultSceneRoot_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDefaultSceneRoot_FunctionAddress, intPtr, IsDefaultSceneRoot_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsDefaultSceneRoot_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDefaultSceneRoot_ReturnValue_Offset), 0, IsDefaultSceneRoot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsComponent")]
	public unsafe static bool IsComponent(FSubobjectData Data)
	{
		if (!IsComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsComponent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsComponent_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsComponent_Data_Offset), 0, IsComponent_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsComponent_FunctionAddress, intPtr, IsComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsComponent_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsComponent_ReturnValue_Offset), 0, IsComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsChildActor")]
	public unsafe static bool IsChildActor(FSubobjectData Data)
	{
		if (!IsChildActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsChildActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsChildActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsChildActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsChildActor_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsChildActor_Data_Offset), 0, IsChildActor_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsChildActor_FunctionAddress, intPtr, IsChildActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsChildActor_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsChildActor_ReturnValue_Offset), 0, IsChildActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsAttachedTo")]
	public unsafe static bool IsAttachedTo(FSubobjectData Data, FSubobjectDataHandle InHandle)
	{
		if (!IsAttachedTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsAttachedTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAttachedTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAttachedTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsAttachedTo_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsAttachedTo_Data_Offset), 0, IsAttachedTo_Data_PropertyAddress.Address, Data);
		NativeReflection.InitializeValue_InContainer(IsAttachedTo_InHandle_PropertyAddress.Address, intPtr);
		FSubobjectDataHandle.ToNative(IntPtr.Add(intPtr, IsAttachedTo_InHandle_Offset), 0, IsAttachedTo_InHandle_PropertyAddress.Address, InHandle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAttachedTo_FunctionAddress, intPtr, IsAttachedTo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsAttachedTo_Data_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsAttachedTo_InHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAttachedTo_ReturnValue_Offset), 0, IsAttachedTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsActor")]
	public unsafe static bool IsActor(FSubobjectData Data)
	{
		if (!IsActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsActor_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, IsActor_Data_Offset), 0, IsActor_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsActor_FunctionAddress, intPtr, IsActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsActor_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActor_ReturnValue_Offset), 0, IsActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetVariableName")]
	public unsafe static FName GetVariableName(FSubobjectData Data)
	{
		if (!GetVariableName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetVariableName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariableName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariableName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVariableName_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, GetVariableName_Data_Offset), 0, GetVariableName_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVariableName_FunctionAddress, intPtr, GetVariableName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVariableName_Data_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetVariableName_ReturnValue_Offset), 0, GetVariableName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetObject")]
	public unsafe static UObject GetObject(FSubobjectData Data, bool bEvenIfPendingKill = false)
	{
		if (!GetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetObject_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, GetObject_Data_Offset), 0, GetObject_Data_PropertyAddress.Address, Data);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetObject_bEvenIfPendingKill_Offset), 0, GetObject_bEvenIfPendingKill_PropertyAddress.Address, bEvenIfPendingKill);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetObject_FunctionAddress, intPtr, GetObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetObject_Data_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetObject_ReturnValue_Offset), 0, GetObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetHandle")]
	public unsafe static void GetHandle(FSubobjectData Data, out FSubobjectDataHandle OutHandle)
	{
		if (!GetHandle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetHandle");
			OutHandle = default(FSubobjectDataHandle);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHandle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHandle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetHandle_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, GetHandle_Data_Offset), 0, GetHandle_Data_PropertyAddress.Address, Data);
		NativeReflection.InitializeValue_InContainer(GetHandle_OutHandle_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHandle_FunctionAddress, intPtr, GetHandle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetHandle_Data_PropertyAddress.Address, intPtr);
		OutHandle = FSubobjectDataHandle.FromNative(IntPtr.Add(intPtr, GetHandle_OutHandle_Offset), 0, GetHandle_OutHandle_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetHandle_OutHandle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339870721u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetDisplayName")]
	public unsafe string GetDisplayName(FSubobjectData Data)
	{
		CheckDestroyed();
		if (!GetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDisplayName_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, GetDisplayName_Data_Offset), 0, GetDisplayName_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayName_FunctionAddress, intPtr, GetDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetDisplayName_Data_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayName_ReturnValue_Offset), 0, GetDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetData")]
	public unsafe static void GetData(FSubobjectDataHandle DataHandle, out FSubobjectData OutData)
	{
		if (!GetData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetData");
			OutData = default(FSubobjectData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetData_DataHandle_PropertyAddress.Address, intPtr);
		FSubobjectDataHandle.ToNative(IntPtr.Add(intPtr, GetData_DataHandle_Offset), 0, GetData_DataHandle_PropertyAddress.Address, DataHandle);
		NativeReflection.InitializeValue_InContainer(GetData_OutData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetData_FunctionAddress, intPtr, GetData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetData_DataHandle_PropertyAddress.Address, intPtr);
		OutData = FSubobjectData.FromNative(IntPtr.Add(intPtr, GetData_OutData_Offset), 0, GetData_OutData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetData_OutData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339870721u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetBlueprint")]
	public unsafe UBlueprint GetBlueprint(FSubobjectData Data)
	{
		CheckDestroyed();
		if (!GetBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetBlueprint");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBlueprint_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, GetBlueprint_Data_Offset), 0, GetBlueprint_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBlueprint_FunctionAddress, intPtr, GetBlueprint_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlueprint_Data_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(intPtr, GetBlueprint_ReturnValue_Offset), 0, GetBlueprint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanReparent")]
	public unsafe static bool CanReparent(FSubobjectData Data)
	{
		if (!CanReparent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanReparent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanReparent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanReparent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanReparent_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, CanReparent_Data_Offset), 0, CanReparent_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanReparent_FunctionAddress, intPtr, CanReparent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanReparent_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanReparent_ReturnValue_Offset), 0, CanReparent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanRename")]
	public unsafe static bool CanRename(FSubobjectData Data)
	{
		if (!CanRename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanRename");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanRename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanRename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanRename_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, CanRename_Data_Offset), 0, CanRename_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanRename_FunctionAddress, intPtr, CanRename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanRename_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanRename_ReturnValue_Offset), 0, CanRename_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanEdit")]
	public unsafe static bool CanEdit(FSubobjectData Data)
	{
		if (!CanEdit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanEdit");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanEdit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanEdit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanEdit_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, CanEdit_Data_Offset), 0, CanEdit_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanEdit_FunctionAddress, intPtr, CanEdit_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanEdit_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanEdit_ReturnValue_Offset), 0, CanEdit_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanDuplicate")]
	public unsafe static bool CanDuplicate(FSubobjectData Data)
	{
		if (!CanDuplicate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanDuplicate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanDuplicate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanDuplicate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanDuplicate_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, CanDuplicate_Data_Offset), 0, CanDuplicate_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanDuplicate_FunctionAddress, intPtr, CanDuplicate_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanDuplicate_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanDuplicate_ReturnValue_Offset), 0, CanDuplicate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanDelete")]
	public unsafe static bool CanDelete(FSubobjectData Data)
	{
		if (!CanDelete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanDelete");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanDelete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanDelete_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanDelete_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, CanDelete_Data_Offset), 0, CanDelete_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanDelete_FunctionAddress, intPtr, CanDelete_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanDelete_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanDelete_ReturnValue_Offset), 0, CanDelete_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanCopy")]
	public unsafe static bool CanCopy(FSubobjectData Data)
	{
		if (!CanCopy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanCopy");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanCopy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanCopy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanCopy_Data_PropertyAddress.Address, intPtr);
		FSubobjectData.ToNative(IntPtr.Add(intPtr, CanCopy_Data_Offset), 0, CanCopy_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanCopy_FunctionAddress, intPtr, CanCopy_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanCopy_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanCopy_ReturnValue_Offset), 0, CanCopy_ReturnValue_PropertyAddress.Address);
	}

	static USubobjectDataBlueprintFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubobjectDataBlueprintFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubobjectDataBlueprintFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary");
		IsValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid");
		IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_Data_PropertyAddress, IsValid_FunctionAddress, "Data");
		IsValid_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "Data");
		IsValid_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_ReturnValue_PropertyAddress, IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_IsValid = IsValid_FunctionAddress != IntPtr.Zero && IsValid_Data_IsValid && IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsValid", IsValid_IsValid);
		IsSceneComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSceneComponent");
		IsSceneComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSceneComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSceneComponent_Data_PropertyAddress, IsSceneComponent_FunctionAddress, "Data");
		IsSceneComponent_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsSceneComponent_FunctionAddress, "Data");
		IsSceneComponent_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSceneComponent_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSceneComponent_ReturnValue_PropertyAddress, IsSceneComponent_FunctionAddress, "ReturnValue");
		IsSceneComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSceneComponent_FunctionAddress, "ReturnValue");
		IsSceneComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSceneComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSceneComponent_IsValid = IsSceneComponent_FunctionAddress != IntPtr.Zero && IsSceneComponent_Data_IsValid && IsSceneComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsSceneComponent", IsSceneComponent_IsValid);
		IsRootComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRootComponent");
		IsRootComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRootComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRootComponent_Data_PropertyAddress, IsRootComponent_FunctionAddress, "Data");
		IsRootComponent_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsRootComponent_FunctionAddress, "Data");
		IsRootComponent_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootComponent_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRootComponent_ReturnValue_PropertyAddress, IsRootComponent_FunctionAddress, "ReturnValue");
		IsRootComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRootComponent_FunctionAddress, "ReturnValue");
		IsRootComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRootComponent_IsValid = IsRootComponent_FunctionAddress != IntPtr.Zero && IsRootComponent_Data_IsValid && IsRootComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsRootComponent", IsRootComponent_IsValid);
		IsRootActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRootActor");
		IsRootActor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRootActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRootActor_Data_PropertyAddress, IsRootActor_FunctionAddress, "Data");
		IsRootActor_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsRootActor_FunctionAddress, "Data");
		IsRootActor_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootActor_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRootActor_ReturnValue_PropertyAddress, IsRootActor_FunctionAddress, "ReturnValue");
		IsRootActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRootActor_FunctionAddress, "ReturnValue");
		IsRootActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRootActor_IsValid = IsRootActor_FunctionAddress != IntPtr.Zero && IsRootActor_Data_IsValid && IsRootActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsRootActor", IsRootActor_IsValid);
		IsNativeComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsNativeComponent");
		IsNativeComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNativeComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNativeComponent_Data_PropertyAddress, IsNativeComponent_FunctionAddress, "Data");
		IsNativeComponent_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsNativeComponent_FunctionAddress, "Data");
		IsNativeComponent_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNativeComponent_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNativeComponent_ReturnValue_PropertyAddress, IsNativeComponent_FunctionAddress, "ReturnValue");
		IsNativeComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNativeComponent_FunctionAddress, "ReturnValue");
		IsNativeComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNativeComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNativeComponent_IsValid = IsNativeComponent_FunctionAddress != IntPtr.Zero && IsNativeComponent_Data_IsValid && IsNativeComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsNativeComponent", IsNativeComponent_IsValid);
		IsInstancedComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsInstancedComponent");
		IsInstancedComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInstancedComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInstancedComponent_Data_PropertyAddress, IsInstancedComponent_FunctionAddress, "Data");
		IsInstancedComponent_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsInstancedComponent_FunctionAddress, "Data");
		IsInstancedComponent_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInstancedComponent_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInstancedComponent_ReturnValue_PropertyAddress, IsInstancedComponent_FunctionAddress, "ReturnValue");
		IsInstancedComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInstancedComponent_FunctionAddress, "ReturnValue");
		IsInstancedComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInstancedComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInstancedComponent_IsValid = IsInstancedComponent_FunctionAddress != IntPtr.Zero && IsInstancedComponent_Data_IsValid && IsInstancedComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsInstancedComponent", IsInstancedComponent_IsValid);
		IsInstancedActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsInstancedActor");
		IsInstancedActor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInstancedActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInstancedActor_Data_PropertyAddress, IsInstancedActor_FunctionAddress, "Data");
		IsInstancedActor_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsInstancedActor_FunctionAddress, "Data");
		IsInstancedActor_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInstancedActor_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInstancedActor_ReturnValue_PropertyAddress, IsInstancedActor_FunctionAddress, "ReturnValue");
		IsInstancedActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInstancedActor_FunctionAddress, "ReturnValue");
		IsInstancedActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInstancedActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInstancedActor_IsValid = IsInstancedActor_FunctionAddress != IntPtr.Zero && IsInstancedActor_Data_IsValid && IsInstancedActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsInstancedActor", IsInstancedActor_IsValid);
		IsInheritedComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsInheritedComponent");
		IsInheritedComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInheritedComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInheritedComponent_Data_PropertyAddress, IsInheritedComponent_FunctionAddress, "Data");
		IsInheritedComponent_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsInheritedComponent_FunctionAddress, "Data");
		IsInheritedComponent_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInheritedComponent_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInheritedComponent_ReturnValue_PropertyAddress, IsInheritedComponent_FunctionAddress, "ReturnValue");
		IsInheritedComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInheritedComponent_FunctionAddress, "ReturnValue");
		IsInheritedComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInheritedComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInheritedComponent_IsValid = IsInheritedComponent_FunctionAddress != IntPtr.Zero && IsInheritedComponent_Data_IsValid && IsInheritedComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsInheritedComponent", IsInheritedComponent_IsValid);
		IsHandleValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsHandleValid");
		IsHandleValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsHandleValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsHandleValid_DataHandle_PropertyAddress, IsHandleValid_FunctionAddress, "DataHandle");
		IsHandleValid_DataHandle_Offset = NativeReflectionCached.GetPropertyOffset(IsHandleValid_FunctionAddress, "DataHandle");
		IsHandleValid_DataHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(IsHandleValid_FunctionAddress, "DataHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsHandleValid_ReturnValue_PropertyAddress, IsHandleValid_FunctionAddress, "ReturnValue");
		IsHandleValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsHandleValid_FunctionAddress, "ReturnValue");
		IsHandleValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsHandleValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsHandleValid_IsValid = IsHandleValid_FunctionAddress != IntPtr.Zero && IsHandleValid_DataHandle_IsValid && IsHandleValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsHandleValid", IsHandleValid_IsValid);
		IsDefaultSceneRoot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDefaultSceneRoot");
		IsDefaultSceneRoot_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDefaultSceneRoot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDefaultSceneRoot_Data_PropertyAddress, IsDefaultSceneRoot_FunctionAddress, "Data");
		IsDefaultSceneRoot_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsDefaultSceneRoot_FunctionAddress, "Data");
		IsDefaultSceneRoot_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDefaultSceneRoot_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDefaultSceneRoot_ReturnValue_PropertyAddress, IsDefaultSceneRoot_FunctionAddress, "ReturnValue");
		IsDefaultSceneRoot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDefaultSceneRoot_FunctionAddress, "ReturnValue");
		IsDefaultSceneRoot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDefaultSceneRoot_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDefaultSceneRoot_IsValid = IsDefaultSceneRoot_FunctionAddress != IntPtr.Zero && IsDefaultSceneRoot_Data_IsValid && IsDefaultSceneRoot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsDefaultSceneRoot", IsDefaultSceneRoot_IsValid);
		IsComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsComponent");
		IsComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsComponent_Data_PropertyAddress, IsComponent_FunctionAddress, "Data");
		IsComponent_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsComponent_FunctionAddress, "Data");
		IsComponent_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsComponent_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsComponent_ReturnValue_PropertyAddress, IsComponent_FunctionAddress, "ReturnValue");
		IsComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsComponent_FunctionAddress, "ReturnValue");
		IsComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsComponent_IsValid = IsComponent_FunctionAddress != IntPtr.Zero && IsComponent_Data_IsValid && IsComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsComponent", IsComponent_IsValid);
		IsChildActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsChildActor");
		IsChildActor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsChildActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsChildActor_Data_PropertyAddress, IsChildActor_FunctionAddress, "Data");
		IsChildActor_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsChildActor_FunctionAddress, "Data");
		IsChildActor_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsChildActor_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsChildActor_ReturnValue_PropertyAddress, IsChildActor_FunctionAddress, "ReturnValue");
		IsChildActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsChildActor_FunctionAddress, "ReturnValue");
		IsChildActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsChildActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsChildActor_IsValid = IsChildActor_FunctionAddress != IntPtr.Zero && IsChildActor_Data_IsValid && IsChildActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsChildActor", IsChildActor_IsValid);
		IsAttachedTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAttachedTo");
		IsAttachedTo_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAttachedTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAttachedTo_Data_PropertyAddress, IsAttachedTo_FunctionAddress, "Data");
		IsAttachedTo_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsAttachedTo_FunctionAddress, "Data");
		IsAttachedTo_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAttachedTo_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAttachedTo_InHandle_PropertyAddress, IsAttachedTo_FunctionAddress, "InHandle");
		IsAttachedTo_InHandle_Offset = NativeReflectionCached.GetPropertyOffset(IsAttachedTo_FunctionAddress, "InHandle");
		IsAttachedTo_InHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAttachedTo_FunctionAddress, "InHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAttachedTo_ReturnValue_PropertyAddress, IsAttachedTo_FunctionAddress, "ReturnValue");
		IsAttachedTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAttachedTo_FunctionAddress, "ReturnValue");
		IsAttachedTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAttachedTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAttachedTo_IsValid = IsAttachedTo_FunctionAddress != IntPtr.Zero && IsAttachedTo_Data_IsValid && IsAttachedTo_InHandle_IsValid && IsAttachedTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsAttachedTo", IsAttachedTo_IsValid);
		IsActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsActor");
		IsActor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActor_Data_PropertyAddress, IsActor_FunctionAddress, "Data");
		IsActor_Data_Offset = NativeReflectionCached.GetPropertyOffset(IsActor_FunctionAddress, "Data");
		IsActor_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActor_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActor_ReturnValue_PropertyAddress, IsActor_FunctionAddress, "ReturnValue");
		IsActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActor_FunctionAddress, "ReturnValue");
		IsActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActor_IsValid = IsActor_FunctionAddress != IntPtr.Zero && IsActor_Data_IsValid && IsActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:IsActor", IsActor_IsValid);
		GetVariableName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVariableName");
		GetVariableName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariableName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariableName_Data_PropertyAddress, GetVariableName_FunctionAddress, "Data");
		GetVariableName_Data_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableName_FunctionAddress, "Data");
		GetVariableName_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableName_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVariableName_ReturnValue_PropertyAddress, GetVariableName_FunctionAddress, "ReturnValue");
		GetVariableName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableName_FunctionAddress, "ReturnValue");
		GetVariableName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetVariableName_IsValid = GetVariableName_FunctionAddress != IntPtr.Zero && GetVariableName_Data_IsValid && GetVariableName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetVariableName", GetVariableName_IsValid);
		GetObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetObject");
		GetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObject_Data_PropertyAddress, GetObject_FunctionAddress, "Data");
		GetObject_Data_Offset = NativeReflectionCached.GetPropertyOffset(GetObject_FunctionAddress, "Data");
		GetObject_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObject_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObject_bEvenIfPendingKill_PropertyAddress, GetObject_FunctionAddress, "bEvenIfPendingKill");
		GetObject_bEvenIfPendingKill_Offset = NativeReflectionCached.GetPropertyOffset(GetObject_FunctionAddress, "bEvenIfPendingKill");
		GetObject_bEvenIfPendingKill_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObject_FunctionAddress, "bEvenIfPendingKill", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObject_ReturnValue_PropertyAddress, GetObject_FunctionAddress, "ReturnValue");
		GetObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObject_FunctionAddress, "ReturnValue");
		GetObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetObject_IsValid = GetObject_FunctionAddress != IntPtr.Zero && GetObject_Data_IsValid && GetObject_bEvenIfPendingKill_IsValid && GetObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetObject", GetObject_IsValid);
		GetHandle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHandle");
		GetHandle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHandle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHandle_Data_PropertyAddress, GetHandle_FunctionAddress, "Data");
		GetHandle_Data_Offset = NativeReflectionCached.GetPropertyOffset(GetHandle_FunctionAddress, "Data");
		GetHandle_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHandle_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHandle_OutHandle_PropertyAddress, GetHandle_FunctionAddress, "OutHandle");
		GetHandle_OutHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetHandle_FunctionAddress, "OutHandle");
		GetHandle_OutHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHandle_FunctionAddress, "OutHandle", Classes.FStructProperty);
		GetHandle_IsValid = GetHandle_FunctionAddress != IntPtr.Zero && GetHandle_Data_IsValid && GetHandle_OutHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetHandle", GetHandle_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_Data_PropertyAddress, GetDisplayName_FunctionAddress, "Data");
		GetDisplayName_Data_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "Data");
		GetDisplayName_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_Data_IsValid && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetDisplayName", GetDisplayName_IsValid);
		GetData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetData");
		GetData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetData_DataHandle_PropertyAddress, GetData_FunctionAddress, "DataHandle");
		GetData_DataHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetData_FunctionAddress, "DataHandle");
		GetData_DataHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetData_FunctionAddress, "DataHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetData_OutData_PropertyAddress, GetData_FunctionAddress, "OutData");
		GetData_OutData_Offset = NativeReflectionCached.GetPropertyOffset(GetData_FunctionAddress, "OutData");
		GetData_OutData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetData_FunctionAddress, "OutData", Classes.FStructProperty);
		GetData_IsValid = GetData_FunctionAddress != IntPtr.Zero && GetData_DataHandle_IsValid && GetData_OutData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetData", GetData_IsValid);
		GetBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlueprint");
		GetBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprint_Data_PropertyAddress, GetBlueprint_FunctionAddress, "Data");
		GetBlueprint_Data_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprint_FunctionAddress, "Data");
		GetBlueprint_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprint_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprint_ReturnValue_PropertyAddress, GetBlueprint_FunctionAddress, "ReturnValue");
		GetBlueprint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprint_FunctionAddress, "ReturnValue");
		GetBlueprint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprint_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBlueprint_IsValid = GetBlueprint_FunctionAddress != IntPtr.Zero && GetBlueprint_Data_IsValid && GetBlueprint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:GetBlueprint", GetBlueprint_IsValid);
		CanReparent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanReparent");
		CanReparent_ParamsSize = NativeReflection.GetFunctionParamsSize(CanReparent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanReparent_Data_PropertyAddress, CanReparent_FunctionAddress, "Data");
		CanReparent_Data_Offset = NativeReflectionCached.GetPropertyOffset(CanReparent_FunctionAddress, "Data");
		CanReparent_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(CanReparent_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanReparent_ReturnValue_PropertyAddress, CanReparent_FunctionAddress, "ReturnValue");
		CanReparent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanReparent_FunctionAddress, "ReturnValue");
		CanReparent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanReparent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanReparent_IsValid = CanReparent_FunctionAddress != IntPtr.Zero && CanReparent_Data_IsValid && CanReparent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanReparent", CanReparent_IsValid);
		CanRename_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanRename");
		CanRename_ParamsSize = NativeReflection.GetFunctionParamsSize(CanRename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanRename_Data_PropertyAddress, CanRename_FunctionAddress, "Data");
		CanRename_Data_Offset = NativeReflectionCached.GetPropertyOffset(CanRename_FunctionAddress, "Data");
		CanRename_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(CanRename_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanRename_ReturnValue_PropertyAddress, CanRename_FunctionAddress, "ReturnValue");
		CanRename_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanRename_FunctionAddress, "ReturnValue");
		CanRename_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanRename_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanRename_IsValid = CanRename_FunctionAddress != IntPtr.Zero && CanRename_Data_IsValid && CanRename_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanRename", CanRename_IsValid);
		CanEdit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanEdit");
		CanEdit_ParamsSize = NativeReflection.GetFunctionParamsSize(CanEdit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanEdit_Data_PropertyAddress, CanEdit_FunctionAddress, "Data");
		CanEdit_Data_Offset = NativeReflectionCached.GetPropertyOffset(CanEdit_FunctionAddress, "Data");
		CanEdit_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(CanEdit_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanEdit_ReturnValue_PropertyAddress, CanEdit_FunctionAddress, "ReturnValue");
		CanEdit_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanEdit_FunctionAddress, "ReturnValue");
		CanEdit_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanEdit_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanEdit_IsValid = CanEdit_FunctionAddress != IntPtr.Zero && CanEdit_Data_IsValid && CanEdit_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanEdit", CanEdit_IsValid);
		CanDuplicate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanDuplicate");
		CanDuplicate_ParamsSize = NativeReflection.GetFunctionParamsSize(CanDuplicate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanDuplicate_Data_PropertyAddress, CanDuplicate_FunctionAddress, "Data");
		CanDuplicate_Data_Offset = NativeReflectionCached.GetPropertyOffset(CanDuplicate_FunctionAddress, "Data");
		CanDuplicate_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDuplicate_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanDuplicate_ReturnValue_PropertyAddress, CanDuplicate_FunctionAddress, "ReturnValue");
		CanDuplicate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanDuplicate_FunctionAddress, "ReturnValue");
		CanDuplicate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDuplicate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanDuplicate_IsValid = CanDuplicate_FunctionAddress != IntPtr.Zero && CanDuplicate_Data_IsValid && CanDuplicate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanDuplicate", CanDuplicate_IsValid);
		CanDelete_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanDelete");
		CanDelete_ParamsSize = NativeReflection.GetFunctionParamsSize(CanDelete_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanDelete_Data_PropertyAddress, CanDelete_FunctionAddress, "Data");
		CanDelete_Data_Offset = NativeReflectionCached.GetPropertyOffset(CanDelete_FunctionAddress, "Data");
		CanDelete_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDelete_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanDelete_ReturnValue_PropertyAddress, CanDelete_FunctionAddress, "ReturnValue");
		CanDelete_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanDelete_FunctionAddress, "ReturnValue");
		CanDelete_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDelete_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanDelete_IsValid = CanDelete_FunctionAddress != IntPtr.Zero && CanDelete_Data_IsValid && CanDelete_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanDelete", CanDelete_IsValid);
		CanCopy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanCopy");
		CanCopy_ParamsSize = NativeReflection.GetFunctionParamsSize(CanCopy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanCopy_Data_PropertyAddress, CanCopy_FunctionAddress, "Data");
		CanCopy_Data_Offset = NativeReflectionCached.GetPropertyOffset(CanCopy_FunctionAddress, "Data");
		CanCopy_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(CanCopy_FunctionAddress, "Data", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanCopy_ReturnValue_PropertyAddress, CanCopy_FunctionAddress, "ReturnValue");
		CanCopy_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanCopy_FunctionAddress, "ReturnValue");
		CanCopy_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanCopy_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanCopy_IsValid = CanCopy_FunctionAddress != IntPtr.Zero && CanCopy_Data_IsValid && CanCopy_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SubobjectDataInterface.SubobjectDataBlueprintFunctionLibrary:CanCopy", CanCopy_IsValid);
	}
}
