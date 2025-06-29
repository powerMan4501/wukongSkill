using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Persona;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Persona.AnimationSequenceBrowserContextMenuContext", "Persona", UnrealModuleType.Engine)]
public class UAnimationSequenceBrowserContextMenuContext : UObject
{
	private static bool GetSelectedObjects_IsValid;

	private static IntPtr GetSelectedObjects_FunctionAddress;

	private static int GetSelectedObjects_ParamsSize;

	private static bool GetSelectedObjects_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedObjects_ReturnValue_PropertyAddress;

	private static int GetSelectedObjects_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Persona.AnimationSequenceBrowserContextMenuContext:GetSelectedObjects")]
	public unsafe List<UObject> GetSelectedObjects()
	{
		CheckDestroyed();
		if (!GetSelectedObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Persona.AnimationSequenceBrowserContextMenuContext:GetSelectedObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedObjects_FunctionAddress, intPtr, GetSelectedObjects_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetSelectedObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAnimationSequenceBrowserContextMenuContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationSequenceBrowserContextMenuContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationSequenceBrowserContextMenuContext));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Persona.AnimationSequenceBrowserContextMenuContext");
		GetSelectedObjects_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSelectedObjects");
		GetSelectedObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedObjects_ReturnValue_PropertyAddress, GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedObjects_IsValid = GetSelectedObjects_FunctionAddress != IntPtr.Zero && GetSelectedObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Persona.AnimationSequenceBrowserContextMenuContext:GetSelectedObjects", GetSelectedObjects_IsValid);
	}
}
