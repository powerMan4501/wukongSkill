using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementRuntime;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TypedElementRuntime.TypedElementIsSelectedOptions", "TypedElementRuntime", UnrealModuleType.Engine)]
public struct FTypedElementIsSelectedOptions
{
	private static bool AllowIndirect_IsValid;

	private static FFieldAddress AllowIndirect_PropertyAddress;

	private static int AllowIndirect_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementIsSelectedOptions:bAllowIndirect")]
	public bool AllowIndirect;

	private static bool FTypedElementIsSelectedOptions_IsValid;

	private static int FTypedElementIsSelectedOptions_StructSize;

	public FTypedElementIsSelectedOptions Copy()
	{
		return this;
	}

	public static FTypedElementIsSelectedOptions FromNative(IntPtr nativeBuffer)
	{
		return new FTypedElementIsSelectedOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTypedElementIsSelectedOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTypedElementIsSelectedOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTypedElementIsSelectedOptions(nativeBuffer + arrayIndex * FTypedElementIsSelectedOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTypedElementIsSelectedOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTypedElementIsSelectedOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTypedElementIsSelectedOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementRuntime.TypedElementIsSelectedOptions");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowIndirect_Offset), 0, AllowIndirect_PropertyAddress.Address, AllowIndirect);
		}
	}

	public FTypedElementIsSelectedOptions(IntPtr nativeStruct)
	{
		if (!FTypedElementIsSelectedOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementRuntime.TypedElementIsSelectedOptions");
			AllowIndirect = false;
		}
		else
		{
			AllowIndirect = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowIndirect_Offset), 0, AllowIndirect_PropertyAddress.Address);
		}
	}

	static FTypedElementIsSelectedOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTypedElementIsSelectedOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTypedElementIsSelectedOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TypedElementRuntime.TypedElementIsSelectedOptions");
		FTypedElementIsSelectedOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AllowIndirect_PropertyAddress, intPtr, "bAllowIndirect");
		AllowIndirect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowIndirect");
		AllowIndirect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowIndirect", Classes.FBoolProperty);
		FTypedElementIsSelectedOptions_IsValid = intPtr != IntPtr.Zero && AllowIndirect_IsValid;
		NativeReflection.LogStructIsValid("/Script/TypedElementRuntime.TypedElementIsSelectedOptions", FTypedElementIsSelectedOptions_IsValid);
	}
}
