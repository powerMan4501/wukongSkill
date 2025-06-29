using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.AnimNotifyMirrorInspectionLibrary", "Engine", UnrealModuleType.Engine)]
public class UAnimNotifyMirrorInspectionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsTriggeredByMirroredAnimation_IsValid;

	private static IntPtr IsTriggeredByMirroredAnimation_FunctionAddress;

	private static int IsTriggeredByMirroredAnimation_ParamsSize;

	private static bool IsTriggeredByMirroredAnimation_EventReference_IsValid;

	private static FFieldAddress IsTriggeredByMirroredAnimation_EventReference_PropertyAddress;

	private static int IsTriggeredByMirroredAnimation_EventReference_Offset;

	private static bool IsTriggeredByMirroredAnimation_ReturnValue_IsValid;

	private static FFieldAddress IsTriggeredByMirroredAnimation_ReturnValue_PropertyAddress;

	private static int IsTriggeredByMirroredAnimation_ReturnValue_Offset;

	private static bool GetMirrorDataTable_IsValid;

	private static IntPtr GetMirrorDataTable_FunctionAddress;

	private static int GetMirrorDataTable_ParamsSize;

	private static bool GetMirrorDataTable_EventReference_IsValid;

	private static FFieldAddress GetMirrorDataTable_EventReference_PropertyAddress;

	private static int GetMirrorDataTable_EventReference_Offset;

	private static bool GetMirrorDataTable_ReturnValue_IsValid;

	private static FFieldAddress GetMirrorDataTable_ReturnValue_PropertyAddress;

	private static int GetMirrorDataTable_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.AnimNotifyMirrorInspectionLibrary:IsTriggeredByMirroredAnimation")]
	public unsafe static bool IsTriggeredByMirroredAnimation(FAnimNotifyEventReference EventReference)
	{
		if (!IsTriggeredByMirroredAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyMirrorInspectionLibrary:IsTriggeredByMirroredAnimation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTriggeredByMirroredAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTriggeredByMirroredAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTriggeredByMirroredAnimation_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, IsTriggeredByMirroredAnimation_EventReference_Offset), 0, IsTriggeredByMirroredAnimation_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsTriggeredByMirroredAnimation_FunctionAddress, intPtr, IsTriggeredByMirroredAnimation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsTriggeredByMirroredAnimation_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTriggeredByMirroredAnimation_ReturnValue_Offset), 0, IsTriggeredByMirroredAnimation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.AnimNotifyMirrorInspectionLibrary:GetMirrorDataTable")]
	public unsafe static UMirrorDataTable GetMirrorDataTable(FAnimNotifyEventReference EventReference)
	{
		if (!GetMirrorDataTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyMirrorInspectionLibrary:GetMirrorDataTable");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMirrorDataTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMirrorDataTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetMirrorDataTable_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, GetMirrorDataTable_EventReference_Offset), 0, GetMirrorDataTable_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMirrorDataTable_FunctionAddress, intPtr, GetMirrorDataTable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMirrorDataTable_EventReference_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMirrorDataTable>.FromNative(IntPtr.Add(intPtr, GetMirrorDataTable_ReturnValue_Offset), 0, GetMirrorDataTable_ReturnValue_PropertyAddress.Address);
	}

	static UAnimNotifyMirrorInspectionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyMirrorInspectionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyMirrorInspectionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.AnimNotifyMirrorInspectionLibrary");
		IsTriggeredByMirroredAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsTriggeredByMirroredAnimation");
		IsTriggeredByMirroredAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTriggeredByMirroredAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByMirroredAnimation_EventReference_PropertyAddress, IsTriggeredByMirroredAnimation_FunctionAddress, "EventReference");
		IsTriggeredByMirroredAnimation_EventReference_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByMirroredAnimation_FunctionAddress, "EventReference");
		IsTriggeredByMirroredAnimation_EventReference_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByMirroredAnimation_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByMirroredAnimation_ReturnValue_PropertyAddress, IsTriggeredByMirroredAnimation_FunctionAddress, "ReturnValue");
		IsTriggeredByMirroredAnimation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByMirroredAnimation_FunctionAddress, "ReturnValue");
		IsTriggeredByMirroredAnimation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByMirroredAnimation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTriggeredByMirroredAnimation_IsValid = IsTriggeredByMirroredAnimation_FunctionAddress != IntPtr.Zero && IsTriggeredByMirroredAnimation_EventReference_IsValid && IsTriggeredByMirroredAnimation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyMirrorInspectionLibrary:IsTriggeredByMirroredAnimation", IsTriggeredByMirroredAnimation_IsValid);
		GetMirrorDataTable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMirrorDataTable");
		GetMirrorDataTable_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMirrorDataTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMirrorDataTable_EventReference_PropertyAddress, GetMirrorDataTable_FunctionAddress, "EventReference");
		GetMirrorDataTable_EventReference_Offset = NativeReflectionCached.GetPropertyOffset(GetMirrorDataTable_FunctionAddress, "EventReference");
		GetMirrorDataTable_EventReference_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMirrorDataTable_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMirrorDataTable_ReturnValue_PropertyAddress, GetMirrorDataTable_FunctionAddress, "ReturnValue");
		GetMirrorDataTable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMirrorDataTable_FunctionAddress, "ReturnValue");
		GetMirrorDataTable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMirrorDataTable_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMirrorDataTable_IsValid = GetMirrorDataTable_FunctionAddress != IntPtr.Zero && GetMirrorDataTable_EventReference_IsValid && GetMirrorDataTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyMirrorInspectionLibrary:GetMirrorDataTable", GetMirrorDataTable_IsValid);
	}
}
