using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GameplayTags.GameplayTagTableRow", "GameplayTags", UnrealModuleType.Engine)]
public struct FGameplayTagTableRow
{
	private static bool Tag_IsValid;

	private static int Tag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GameplayTags.GameplayTagTableRow:Tag")]
	public FName Tag;

	private static bool DevComment_IsValid;

	private static int DevComment_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/GameplayTags.GameplayTagTableRow:DevComment")]
	public string DevComment;

	private static bool FGameplayTagTableRow_IsValid;

	private static int FGameplayTagTableRow_StructSize;

	public FGameplayTagTableRow Copy()
	{
		return this;
	}

	public static FGameplayTagTableRow FromNative(IntPtr nativeBuffer)
	{
		return new FGameplayTagTableRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGameplayTagTableRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGameplayTagTableRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGameplayTagTableRow(nativeBuffer + arrayIndex * FGameplayTagTableRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGameplayTagTableRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGameplayTagTableRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGameplayTagTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTags.GameplayTagTableRow");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Tag_Offset), Tag);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DevComment_Offset), DevComment);
	}

	public FGameplayTagTableRow(IntPtr nativeStruct)
	{
		if (!FGameplayTagTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayTags.GameplayTagTableRow");
			Tag = default(FName);
			DevComment = FStringMarshaler.DefaultString;
		}
		else
		{
			Tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Tag_Offset));
			DevComment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DevComment_Offset));
		}
	}

	static FGameplayTagTableRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGameplayTagTableRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGameplayTagTableRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayTags.GameplayTagTableRow");
		FGameplayTagTableRow_StructSize = NativeReflection.GetStructSize(intPtr);
		Tag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tag");
		Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tag", Classes.FNameProperty);
		DevComment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DevComment");
		DevComment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DevComment", Classes.FStrProperty);
		FGameplayTagTableRow_IsValid = intPtr != IntPtr.Zero && Tag_IsValid && DevComment_IsValid;
		NativeReflection.LogStructIsValid("/Script/GameplayTags.GameplayTagTableRow", FGameplayTagTableRow_IsValid);
	}
}
