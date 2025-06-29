using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineAchievementTag", "b1", UnrealModuleType.Game)]
public struct FBGWOnlineAchievementTag
{
	private static bool Id_IsValid;

	private static int Id_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/b1.BGWOnlineAchievementTag:Id")]
	public string Id;

	private static bool Progress_IsValid;

	private static int Progress_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineAchievementTag:Progress")]
	public double Progress;

	private static bool FBGWOnlineAchievementTag_IsValid;

	private static int FBGWOnlineAchievementTag_StructSize;

	public FBGWOnlineAchievementTag Copy()
	{
		return this;
	}

	public static FBGWOnlineAchievementTag FromNative(IntPtr nativeBuffer)
	{
		return new FBGWOnlineAchievementTag(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGWOnlineAchievementTag value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGWOnlineAchievementTag FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGWOnlineAchievementTag(nativeBuffer + arrayIndex * FBGWOnlineAchievementTag_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGWOnlineAchievementTag value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBGWOnlineAchievementTag_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBGWOnlineAchievementTag_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWOnlineAchievementTag");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Id_Offset), Id);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, Progress_Offset), Progress);
	}

	public FBGWOnlineAchievementTag(IntPtr nativeStruct)
	{
		if (!FBGWOnlineAchievementTag_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWOnlineAchievementTag");
			Id = FStringMarshaler.DefaultString;
			Progress = 0.0;
		}
		else
		{
			Id = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Id_Offset));
			Progress = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(nativeStruct, Progress_Offset));
		}
	}

	static FBGWOnlineAchievementTag()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBGWOnlineAchievementTag)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGWOnlineAchievementTag));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.BGWOnlineAchievementTag");
		FBGWOnlineAchievementTag_StructSize = NativeReflection.GetStructSize(intPtr);
		Id_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Id");
		Id_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Id", Classes.FStrProperty);
		Progress_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Progress");
		Progress_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Progress", Classes.FDoubleProperty);
		FBGWOnlineAchievementTag_IsValid = intPtr != IntPtr.Zero && Id_IsValid && Progress_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.BGWOnlineAchievementTag", FBGWOnlineAchievementTag_IsValid);
	}
}
