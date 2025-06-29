using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PerformerInfo")]
public struct FPerformerInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerInfo:PerformerActorFixedGuid")]
	public FGameplayTag PerformerActorFixedGuid;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerInfo:Comment")]
	public string Comment;

	private static int PerformerInfo_StructSize;

	private static int PerformerInfo_IsValid;

	private static bool PerformerActorFixedGuid_IsValid;

	private static int PerformerActorFixedGuid_Offset;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FPerformerInfo Copy()
	{
		return this;
	}

	public static FPerformerInfo FromNative(IntPtr nativeBuffer)
	{
		return new FPerformerInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPerformerInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPerformerInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPerformerInfo(IntPtr.Add(nativeBuffer, arrayIndex * PerformerInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPerformerInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PerformerInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PerformerInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PerformerInfo");
			return;
		}
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, PerformerActorFixedGuid_Offset), PerformerActorFixedGuid);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FPerformerInfo(IntPtr nativeStruct)
	{
		if (PerformerInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PerformerInfo");
			PerformerActorFixedGuid = default(FGameplayTag);
			Comment = null;
		}
		else
		{
			PerformerActorFixedGuid = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, PerformerActorFixedGuid_Offset));
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PerformerInfo");
		PerformerInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		PerformerActorFixedGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerformerActorFixedGuid");
		PerformerActorFixedGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerformerActorFixedGuid", Classes.FStructProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		PerformerInfo_IsValid = ((intPtr != IntPtr.Zero && PerformerActorFixedGuid_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PerformerInfo", (byte)PerformerInfo_IsValid != 0);
	}

	static FPerformerInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPerformerInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPerformerInfo));
	}
}
