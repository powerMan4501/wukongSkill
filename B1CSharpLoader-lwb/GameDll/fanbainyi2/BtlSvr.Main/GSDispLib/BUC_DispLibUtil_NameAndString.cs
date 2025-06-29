using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndString")]
public struct BUC_DispLibUtil_NameAndString
{
	[DisplayName("String参数名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndString:ParamName")]
	public FName ParamName;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("值")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndString:Value")]
	public string Value;

	private static int BUC_DispLibUtil_NameAndString_StructSize;

	private static int BUC_DispLibUtil_NameAndString_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool Value_IsValid;

	private static int Value_Offset;

	public BUC_DispLibUtil_NameAndString Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_NameAndString FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_NameAndString(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_NameAndString value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_NameAndString FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_NameAndString(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndString_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_NameAndString value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndString_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndString_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndString");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public BUC_DispLibUtil_NameAndString(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndString_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndString");
			ParamName = default(FName);
			Value = null;
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Value = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndString");
		BUC_DispLibUtil_NameAndString_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FStrProperty);
		BUC_DispLibUtil_NameAndString_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && Value_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_NameAndString", (byte)BUC_DispLibUtil_NameAndString_IsValid != 0);
	}

	static BUC_DispLibUtil_NameAndString()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndString)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndString));
	}
}
