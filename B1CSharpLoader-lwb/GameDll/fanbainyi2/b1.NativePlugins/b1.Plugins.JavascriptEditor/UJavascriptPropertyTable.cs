using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptPropertyTable", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptPropertyTable : UWidget
{
	private static bool SetEditingObjects_IsValid;

	private static IntPtr SetEditingObjects_FunctionAddress;

	private static int SetEditingObjects_ParamsSize;

	private static bool SetEditingObjects_InEditingObjects_IsValid;

	private static FFieldAddress SetEditingObjects_InEditingObjects_PropertyAddress;

	private static int SetEditingObjects_InEditingObjects_Offset;

	private static bool GetSelectedTableObjects_IsValid;

	private static IntPtr GetSelectedTableObjects_FunctionAddress;

	private static int GetSelectedTableObjects_ParamsSize;

	private static bool GetSelectedTableObjects_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedTableObjects_ReturnValue_PropertyAddress;

	private static int GetSelectedTableObjects_ReturnValue_Offset;

	private static bool GetEditingObjects_IsValid;

	private static IntPtr GetEditingObjects_FunctionAddress;

	private static int GetEditingObjects_ParamsSize;

	private static bool GetEditingObjects_ReturnValue_IsValid;

	private static FFieldAddress GetEditingObjects_ReturnValue_PropertyAddress;

	private static int GetEditingObjects_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptPropertyTable:SetEditingObjects")]
	public unsafe void SetEditingObjects(List<UObject> InEditingObjects)
	{
		CheckDestroyed();
		if (!SetEditingObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptPropertyTable:SetEditingObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEditingObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEditingObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetEditingObjects_InEditingObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetEditingObjects_InEditingObjects_Offset), InEditingObjects);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEditingObjects_FunctionAddress, intPtr, SetEditingObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetEditingObjects_InEditingObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptPropertyTable:GetSelectedTableObjects")]
	public unsafe List<UObject> GetSelectedTableObjects()
	{
		CheckDestroyed();
		if (!GetSelectedTableObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptPropertyTable:GetSelectedTableObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedTableObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedTableObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedTableObjects_FunctionAddress, intPtr, GetSelectedTableObjects_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetSelectedTableObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedTableObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedTableObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptPropertyTable:GetEditingObjects")]
	public unsafe List<UObject> GetEditingObjects()
	{
		CheckDestroyed();
		if (!GetEditingObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptPropertyTable:GetEditingObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEditingObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEditingObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEditingObjects_FunctionAddress, intPtr, GetEditingObjects_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetEditingObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetEditingObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetEditingObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UJavascriptPropertyTable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptPropertyTable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptPropertyTable));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptPropertyTable");
		SetEditingObjects_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEditingObjects");
		SetEditingObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEditingObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEditingObjects_InEditingObjects_PropertyAddress, SetEditingObjects_FunctionAddress, "InEditingObjects");
		SetEditingObjects_InEditingObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetEditingObjects_FunctionAddress, "InEditingObjects");
		SetEditingObjects_InEditingObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEditingObjects_FunctionAddress, "InEditingObjects", Classes.FArrayProperty);
		SetEditingObjects_IsValid = SetEditingObjects_FunctionAddress != IntPtr.Zero && SetEditingObjects_InEditingObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptPropertyTable:SetEditingObjects", SetEditingObjects_IsValid);
		GetSelectedTableObjects_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSelectedTableObjects");
		GetSelectedTableObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedTableObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedTableObjects_ReturnValue_PropertyAddress, GetSelectedTableObjects_FunctionAddress, "ReturnValue");
		GetSelectedTableObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedTableObjects_FunctionAddress, "ReturnValue");
		GetSelectedTableObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedTableObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedTableObjects_IsValid = GetSelectedTableObjects_FunctionAddress != IntPtr.Zero && GetSelectedTableObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptPropertyTable:GetSelectedTableObjects", GetSelectedTableObjects_IsValid);
		GetEditingObjects_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEditingObjects");
		GetEditingObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditingObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditingObjects_ReturnValue_PropertyAddress, GetEditingObjects_FunctionAddress, "ReturnValue");
		GetEditingObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditingObjects_FunctionAddress, "ReturnValue");
		GetEditingObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditingObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetEditingObjects_IsValid = GetEditingObjects_FunctionAddress != IntPtr.Zero && GetEditingObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptPropertyTable:GetEditingObjects", GetEditingObjects_IsValid);
	}
}
