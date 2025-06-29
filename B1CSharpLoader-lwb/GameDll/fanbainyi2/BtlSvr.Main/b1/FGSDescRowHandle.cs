using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSDescRowHandle")]
public struct FGSDescRowHandle
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSDescRowHandle:DescID")]
	public int DescID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSDescRowHandle:RowName")]
	public FName RowName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSDescRowHandle:DescCustomizationHelperClass")]
	public TSubclassOf<UGSDescPropertyDetailCustomizationHelper> DescCustomizationHelperClass;

	private static int FGSDescRowHandle_StructSize;

	private static int FGSDescRowHandle_IsValid;

	private static bool DescID_IsValid;

	private static int DescID_Offset;

	private static bool RowName_IsValid;

	private static int RowName_Offset;

	private static bool DescCustomizationHelperClass_IsValid;

	private static int DescCustomizationHelperClass_Offset;

	public FGSDescRowHandle(TSubclassOf<UGSDescPropertyDetailCustomizationHelper> _DescCustomizationHelperClass)
	{
		DescID = -1;
		RowName = new FName("");
		DescCustomizationHelperClass = _DescCustomizationHelperClass;
	}

	public FGSDescRowHandle(int _DescID, FName _RowName, TSubclassOf<UGSDescPropertyDetailCustomizationHelper> _DescCustomizationHelperClass)
	{
		DescID = _DescID;
		RowName = _RowName;
		DescCustomizationHelperClass = _DescCustomizationHelperClass;
	}

	public FGSDescRowHandle Copy()
	{
		return this;
	}

	public static FGSDescRowHandle FromNative(IntPtr nativeBuffer)
	{
		return new FGSDescRowHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSDescRowHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSDescRowHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSDescRowHandle(IntPtr.Add(nativeBuffer, arrayIndex * FGSDescRowHandle_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSDescRowHandle value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSDescRowHandle_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSDescRowHandle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSDescRowHandle");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DescID_Offset), DescID);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, RowName_Offset), RowName);
		TSubclassOfMarshaler<UGSDescPropertyDetailCustomizationHelper>.ToNative(IntPtr.Add(nativeStruct, DescCustomizationHelperClass_Offset), DescCustomizationHelperClass);
	}

	public FGSDescRowHandle(IntPtr nativeStruct)
	{
		if (FGSDescRowHandle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSDescRowHandle");
			DescID = 0;
			RowName = default(FName);
			DescCustomizationHelperClass = default(TSubclassOf<UGSDescPropertyDetailCustomizationHelper>);
		}
		else
		{
			DescID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DescID_Offset));
			RowName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, RowName_Offset));
			DescCustomizationHelperClass = TSubclassOfMarshaler<UGSDescPropertyDetailCustomizationHelper>.FromNative(IntPtr.Add(nativeStruct, DescCustomizationHelperClass_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSDescRowHandle");
		FGSDescRowHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		DescID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DescID");
		DescID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DescID", Classes.FIntProperty);
		RowName_Offset = NativeReflection.GetPropertyOffset(intPtr, "RowName");
		RowName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RowName", Classes.FNameProperty);
		DescCustomizationHelperClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "DescCustomizationHelperClass");
		DescCustomizationHelperClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DescCustomizationHelperClass", Classes.FClassProperty);
		FGSDescRowHandle_IsValid = ((intPtr != IntPtr.Zero && DescID_IsValid && RowName_IsValid && DescCustomizationHelperClass_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSDescRowHandle", (byte)FGSDescRowHandle_IsValid != 0);
	}

	static FGSDescRowHandle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSDescRowHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSDescRowHandle));
	}
}
