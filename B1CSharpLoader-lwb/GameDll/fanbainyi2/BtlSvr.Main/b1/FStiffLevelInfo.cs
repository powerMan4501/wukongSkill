using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.StiffLevelInfo")]
public struct FStiffLevelInfo
{
	[Tooltip("大于这个值时在这个挡位")]
	[DisplayName("受击挡位值")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.StiffLevelInfo:StiffLevelValue")]
	public float StiffLevelValue;

	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("方便策划阅读")]
	[EditAnywhere]
	[DisplayName("受击挡位描述")]
	[USharpPath("/Script/b1-Managed.StiffLevelInfo:StiffLevelName")]
	public string StiffLevelName;

	private static int StiffLevelInfo_StructSize;

	private static int StiffLevelInfo_IsValid;

	private static bool StiffLevelValue_IsValid;

	private static int StiffLevelValue_Offset;

	private static bool StiffLevelName_IsValid;

	private static int StiffLevelName_Offset;

	public FStiffLevelInfo Copy()
	{
		return this;
	}

	public static FStiffLevelInfo FromNative(IntPtr nativeBuffer)
	{
		return new FStiffLevelInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStiffLevelInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStiffLevelInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStiffLevelInfo(IntPtr.Add(nativeBuffer, arrayIndex * StiffLevelInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStiffLevelInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * StiffLevelInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (StiffLevelInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StiffLevelInfo");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StiffLevelValue_Offset), StiffLevelValue);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, StiffLevelName_Offset), StiffLevelName);
	}

	public FStiffLevelInfo(IntPtr nativeStruct)
	{
		if (StiffLevelInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StiffLevelInfo");
			StiffLevelValue = 0f;
			StiffLevelName = null;
		}
		else
		{
			StiffLevelValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StiffLevelValue_Offset));
			StiffLevelName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, StiffLevelName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.StiffLevelInfo");
		StiffLevelInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		StiffLevelValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "StiffLevelValue");
		StiffLevelValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StiffLevelValue", Classes.FFloatProperty);
		StiffLevelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "StiffLevelName");
		StiffLevelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StiffLevelName", Classes.FStrProperty);
		StiffLevelInfo_IsValid = ((intPtr != IntPtr.Zero && StiffLevelValue_IsValid && StiffLevelName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.StiffLevelInfo", (byte)StiffLevelInfo_IsValid != 0);
	}

	static FStiffLevelInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FStiffLevelInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStiffLevelInfo));
	}
}
