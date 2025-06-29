using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MovieConditionQueryConfig")]
public struct FMovieConditionQueryConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Config")]
	[DisplayName("条件类型")]
	[USharpPath("/Script/b1-Managed.MovieConditionQueryConfig:ConditionQueryType")]
	public EMovieConditionQueryType ConditionQueryType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[DisplayName("群体单位Guid")]
	[USharpPath("/Script/b1-Managed.MovieConditionQueryConfig:GroupUnitGuid")]
	public FGameplayTag GroupUnitGuid;

	private static int MovieConditionQueryConfig_StructSize;

	private static int MovieConditionQueryConfig_IsValid;

	private static bool ConditionQueryType_IsValid;

	private static int ConditionQueryType_Offset;

	private static FFieldAddress ConditionQueryType_PropertyAddress;

	private static bool GroupUnitGuid_IsValid;

	private static int GroupUnitGuid_Offset;

	public FMovieConditionQueryConfig Copy()
	{
		return this;
	}

	public static FMovieConditionQueryConfig FromNative(IntPtr nativeBuffer)
	{
		return new FMovieConditionQueryConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieConditionQueryConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieConditionQueryConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieConditionQueryConfig(IntPtr.Add(nativeBuffer, arrayIndex * MovieConditionQueryConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieConditionQueryConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MovieConditionQueryConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MovieConditionQueryConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieConditionQueryConfig");
			return;
		}
		EnumMarshaler<EMovieConditionQueryType>.ToNative(IntPtr.Add(nativeStruct, ConditionQueryType_Offset), 0, ConditionQueryType_PropertyAddress.Address, ConditionQueryType);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, GroupUnitGuid_Offset), GroupUnitGuid);
	}

	public FMovieConditionQueryConfig(IntPtr nativeStruct)
	{
		if (MovieConditionQueryConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieConditionQueryConfig");
			ConditionQueryType = EMovieConditionQueryType.AllLevelSwitchStateFinish;
			GroupUnitGuid = default(FGameplayTag);
		}
		else
		{
			ConditionQueryType = EnumMarshaler<EMovieConditionQueryType>.FromNative(IntPtr.Add(nativeStruct, ConditionQueryType_Offset), 0, ConditionQueryType_PropertyAddress.Address);
			GroupUnitGuid = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, GroupUnitGuid_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MovieConditionQueryConfig");
		MovieConditionQueryConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionQueryType_PropertyAddress, intPtr, "ConditionQueryType");
		ConditionQueryType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionQueryType");
		ConditionQueryType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionQueryType", Classes.FEnumProperty);
		GroupUnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupUnitGuid");
		GroupUnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupUnitGuid", Classes.FStructProperty);
		MovieConditionQueryConfig_IsValid = ((intPtr != IntPtr.Zero && ConditionQueryType_IsValid && GroupUnitGuid_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MovieConditionQueryConfig", (byte)MovieConditionQueryConfig_IsValid != 0);
	}

	static FMovieConditionQueryConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMovieConditionQueryConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieConditionQueryConfig));
	}
}
