using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/DataprepCore.DataprepActionAsset", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepActionAsset : UObject
{
	private static bool Execute_IsValid;

	private static IntPtr Execute_FunctionAddress;

	private static int Execute_ParamsSize;

	private static bool Execute_InObjects_IsValid;

	private static FFieldAddress Execute_InObjects_PropertyAddress;

	private static int Execute_InObjects_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DataprepCore.DataprepActionAsset:Execute")]
	public unsafe void Execute(List<UObject> InObjects)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepActionAsset:Execute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, Execute_InObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, Execute_InObjects_Offset), InObjects);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_FunctionAddress, intPtr, Execute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Execute_InObjects_PropertyAddress.Address, intPtr);
	}

	static UDataprepActionAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepActionAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepActionAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepActionAsset");
		Execute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Execute");
		Execute_ParamsSize = NativeReflection.GetFunctionParamsSize(Execute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Execute_InObjects_PropertyAddress, Execute_FunctionAddress, "InObjects");
		Execute_InObjects_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "InObjects");
		Execute_InObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "InObjects", Classes.FArrayProperty);
		Execute_IsValid = Execute_FunctionAddress != IntPtr.Zero && Execute_InObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepActionAsset:Execute", Execute_IsValid);
	}
}
