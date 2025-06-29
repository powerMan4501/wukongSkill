using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.NetPushModelHelpers", "Engine", UnrealModuleType.Engine)]
public class UNetPushModelHelpers : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool MarkPropertyDirty_IsValid;

	private static IntPtr MarkPropertyDirty_FunctionAddress;

	private static int MarkPropertyDirty_ParamsSize;

	private static bool MarkPropertyDirty_Object_IsValid;

	private static FFieldAddress MarkPropertyDirty_Object_PropertyAddress;

	private static int MarkPropertyDirty_Object_Offset;

	private static bool MarkPropertyDirty_PropertyName_IsValid;

	private static FFieldAddress MarkPropertyDirty_PropertyName_PropertyAddress;

	private static int MarkPropertyDirty_PropertyName_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.NetPushModelHelpers:MarkPropertyDirty")]
	public unsafe static void MarkPropertyDirty(UObject Object, FName PropertyName)
	{
		if (!MarkPropertyDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.NetPushModelHelpers:MarkPropertyDirty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkPropertyDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkPropertyDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, MarkPropertyDirty_Object_Offset), 0, MarkPropertyDirty_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, MarkPropertyDirty_PropertyName_Offset), 0, MarkPropertyDirty_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkPropertyDirty_FunctionAddress, intPtr, MarkPropertyDirty_ParamsSize);
	}

	static UNetPushModelHelpers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNetPushModelHelpers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNetPushModelHelpers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.NetPushModelHelpers");
		MarkPropertyDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkPropertyDirty");
		MarkPropertyDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkPropertyDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkPropertyDirty_Object_PropertyAddress, MarkPropertyDirty_FunctionAddress, "Object");
		MarkPropertyDirty_Object_Offset = NativeReflectionCached.GetPropertyOffset(MarkPropertyDirty_FunctionAddress, "Object");
		MarkPropertyDirty_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkPropertyDirty_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MarkPropertyDirty_PropertyName_PropertyAddress, MarkPropertyDirty_FunctionAddress, "PropertyName");
		MarkPropertyDirty_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(MarkPropertyDirty_FunctionAddress, "PropertyName");
		MarkPropertyDirty_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkPropertyDirty_FunctionAddress, "PropertyName", Classes.FNameProperty);
		MarkPropertyDirty_IsValid = MarkPropertyDirty_FunctionAddress != IntPtr.Zero && MarkPropertyDirty_Object_IsValid && MarkPropertyDirty_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.NetPushModelHelpers:MarkPropertyDirty", MarkPropertyDirty_IsValid);
	}
}
