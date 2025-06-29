using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepCore.DataprepBoolFetcher", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepBoolFetcher : UDataprepFetcher
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
	[UMetaPath("/Script/DataprepCore.DataprepBoolFetcher:Fetch")]
	public unsafe bool Fetch(UObject Object, out bool bOutFetchSucceded)
	{
		CheckDestroyed();
		if (!Fetch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepBoolFetcher:Fetch");
			bOutFetchSucceded = false;
			return false;
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
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Fetch_ReturnValue_Offset), 0, Fetch_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool Fetch_Implementation(UObject Object, out bool bOutFetchSucceded)
	{
		CheckDestroyed();
		if (!Fetch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepBoolFetcher:Fetch");
			bOutFetchSucceded = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Fetch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Fetch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Fetch_Object_Offset), 0, Fetch_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, Fetch_FunctionAddress, intPtr, Fetch_ParamsSize);
		bOutFetchSucceded = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Fetch_bOutFetchSucceded_Offset), 0, Fetch_bOutFetchSucceded_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Fetch_ReturnValue_Offset), 0, Fetch_ReturnValue_PropertyAddress.Address);
	}

	static UDataprepBoolFetcher()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepBoolFetcher)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepBoolFetcher));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepBoolFetcher");
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
		Fetch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Fetch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Fetch_IsValid = Fetch_FunctionAddress != IntPtr.Zero && Fetch_Object_IsValid && Fetch_bOutFetchSucceded_IsValid && Fetch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepBoolFetcher:Fetch", Fetch_IsValid);
	}
}
