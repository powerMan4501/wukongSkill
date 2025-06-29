using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.InteractInfoTemplateWithLOD")]
public struct FInteractInfoTemplateWithLOD
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.InteractInfoTemplateWithLOD:InfoTemplateWithLOD")]
	public Dictionary<int, FInteractInfoTemplateNameList> InfoTemplateWithLOD;

	private static int InteractInfoTemplateWithLOD_StructSize;

	private static int InteractInfoTemplateWithLOD_IsValid;

	private static bool InfoTemplateWithLOD_IsValid;

	private static int InfoTemplateWithLOD_Offset;

	private static FFieldAddress InfoTemplateWithLOD_PropertyAddress;

	public FInteractInfoTemplateWithLOD Copy()
	{
		FInteractInfoTemplateWithLOD result = this;
		if (InfoTemplateWithLOD != null)
		{
			result.InfoTemplateWithLOD = new Dictionary<int, FInteractInfoTemplateNameList>(InfoTemplateWithLOD);
		}
		return result;
	}

	public static FInteractInfoTemplateWithLOD FromNative(IntPtr nativeBuffer)
	{
		return new FInteractInfoTemplateWithLOD(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInteractInfoTemplateWithLOD value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInteractInfoTemplateWithLOD FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInteractInfoTemplateWithLOD(IntPtr.Add(nativeBuffer, arrayIndex * InteractInfoTemplateWithLOD_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInteractInfoTemplateWithLOD value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InteractInfoTemplateWithLOD_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InteractInfoTemplateWithLOD_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InteractInfoTemplateWithLOD");
		}
		else
		{
			new TMapCopyMarshaler<int, FInteractInfoTemplateNameList>(1, InfoTemplateWithLOD_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FInteractInfoTemplateNameList, FInteractInfoTemplateNameList>.FromNative, CachedMarshalingDelegates<FInteractInfoTemplateNameList, FInteractInfoTemplateNameList>.ToNative).ToNative(IntPtr.Add(nativeStruct, InfoTemplateWithLOD_Offset), InfoTemplateWithLOD);
		}
	}

	public FInteractInfoTemplateWithLOD(IntPtr nativeStruct)
	{
		if (InteractInfoTemplateWithLOD_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InteractInfoTemplateWithLOD");
			InfoTemplateWithLOD = null;
		}
		else
		{
			InfoTemplateWithLOD = new TMapCopyMarshaler<int, FInteractInfoTemplateNameList>(1, InfoTemplateWithLOD_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FInteractInfoTemplateNameList, FInteractInfoTemplateNameList>.FromNative, CachedMarshalingDelegates<FInteractInfoTemplateNameList, FInteractInfoTemplateNameList>.ToNative).FromNative(IntPtr.Add(nativeStruct, InfoTemplateWithLOD_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InteractInfoTemplateWithLOD");
		InteractInfoTemplateWithLOD_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref InfoTemplateWithLOD_PropertyAddress, intPtr, "InfoTemplateWithLOD");
		InfoTemplateWithLOD_Offset = NativeReflection.GetPropertyOffset(intPtr, "InfoTemplateWithLOD");
		InfoTemplateWithLOD_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InfoTemplateWithLOD", Classes.FMapProperty);
		InteractInfoTemplateWithLOD_IsValid = ((intPtr != IntPtr.Zero && InfoTemplateWithLOD_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InteractInfoTemplateWithLOD", (byte)InteractInfoTemplateWithLOD_IsValid != 0);
	}

	static FInteractInfoTemplateWithLOD()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInteractInfoTemplateWithLOD)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInteractInfoTemplateWithLOD));
	}
}
