using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepCore.DataprepStringsArrayFetcher", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepStringsArrayFetcher : UDataprepFetcher
{
	private static bool Fetch_IsValid;

	private IntPtr Fetch_InstanceFunctionAddress;

	private static IntPtr Fetch_FunctionAddress;

	private static int Fetch_ParamsSize;

	private static bool Fetch_Object_IsValid;

	private static FFieldAddress Fetch_Object_PropertyAddress;

	private static int Fetch_Object_Offset;

	private static bool Fetch_bOutFetchSucceded_IsValid;

	private static FFieldAddress Fetch_bOutFetchSucceded_PropertyAddress;

	private static int Fetch_bOutFetchSucceded_Offset;

	private static bool Fetch_ReturnValue_IsValid;

	private static FFieldAddress Fetch_ReturnValue_PropertyAddress;

	private static int Fetch_ReturnValue_Offset;

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/DataprepCore.DataprepStringsArrayFetcher:Fetch")]
	public unsafe List<string> Fetch(UObject Object, out bool bOutFetchSucceded)
	{
		CheckDestroyed();
		if (!Fetch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepStringsArrayFetcher:Fetch");
			bOutFetchSucceded = false;
			return null;
		}
		if (Fetch_InstanceFunctionAddress == IntPtr.Zero)
		{
			Fetch_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Fetch");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Fetch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Fetch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Fetch_Object_Offset), 0, Fetch_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, Fetch_InstanceFunctionAddress, intPtr, Fetch_ParamsSize);
		bOutFetchSucceded = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Fetch_bOutFetchSucceded_Offset), 0, Fetch_bOutFetchSucceded_PropertyAddress.Address);
		List<string> result = new TArrayCopyMarshaler<string>(1, Fetch_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, Fetch_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(Fetch_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<string> Fetch_Implementation(UObject Object, out bool bOutFetchSucceded)
	{
		CheckDestroyed();
		if (!Fetch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepStringsArrayFetcher:Fetch");
			bOutFetchSucceded = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Fetch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Fetch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Fetch_Object_Offset), 0, Fetch_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, Fetch_FunctionAddress, intPtr, Fetch_ParamsSize);
		bOutFetchSucceded = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Fetch_bOutFetchSucceded_Offset), 0, Fetch_bOutFetchSucceded_PropertyAddress.Address);
		List<string> result = new TArrayCopyMarshaler<string>(1, Fetch_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, Fetch_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(Fetch_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UDataprepStringsArrayFetcher()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepStringsArrayFetcher)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepStringsArrayFetcher));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepStringsArrayFetcher");
		Fetch_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Fetch");
		Fetch_ParamsSize = NativeReflection.GetFunctionParamsSize(Fetch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Fetch_Object_PropertyAddress, Fetch_FunctionAddress, "Object");
		Fetch_Object_Offset = NativeReflectionCached.GetPropertyOffset(Fetch_FunctionAddress, "Object");
		Fetch_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(Fetch_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Fetch_bOutFetchSucceded_PropertyAddress, Fetch_FunctionAddress, "bOutFetchSucceded");
		Fetch_bOutFetchSucceded_Offset = NativeReflectionCached.GetPropertyOffset(Fetch_FunctionAddress, "bOutFetchSucceded");
		Fetch_bOutFetchSucceded_IsValid = NativeReflectionCached.ValidatePropertyClass(Fetch_FunctionAddress, "bOutFetchSucceded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Fetch_ReturnValue_PropertyAddress, Fetch_FunctionAddress, "ReturnValue");
		Fetch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Fetch_FunctionAddress, "ReturnValue");
		Fetch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Fetch_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		Fetch_IsValid = Fetch_FunctionAddress != IntPtr.Zero && Fetch_Object_IsValid && Fetch_bOutFetchSucceded_IsValid && Fetch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepStringsArrayFetcher:Fetch", Fetch_IsValid);
	}
}
