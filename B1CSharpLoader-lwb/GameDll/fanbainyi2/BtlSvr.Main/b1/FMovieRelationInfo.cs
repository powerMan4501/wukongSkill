using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MovieRelationInfo")]
public struct FMovieRelationInfo
{
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "MovieRelationType == MovieRelationType::None || MovieRelationType == MovieRelationType::ManualLocation")]
	[USharpPath("/Script/b1-Managed.MovieRelationInfo:MovieRelationType")]
	public EMovieRelationType MovieRelationType;

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieRelationInfo:ActorGuid")]
	public string ActorGuid;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "MovieRelationType == MovieRelationType::ManualLocation")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieRelationInfo:Location")]
	public FVector Location;

	private static int MovieRelationInfo_StructSize;

	private static int MovieRelationInfo_IsValid;

	private static bool MovieRelationType_IsValid;

	private static int MovieRelationType_Offset;

	private static FFieldAddress MovieRelationType_PropertyAddress;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	private static bool Location_IsValid;

	private static int Location_Offset;

	public bool Equals(FMovieRelationInfo obj)
	{
		if (MovieRelationType == obj.MovieRelationType && ActorGuid == obj.ActorGuid)
		{
			return Location == obj.Location;
		}
		return false;
	}

	public FMovieRelationInfo Copy()
	{
		return this;
	}

	public static FMovieRelationInfo FromNative(IntPtr nativeBuffer)
	{
		return new FMovieRelationInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieRelationInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieRelationInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieRelationInfo(IntPtr.Add(nativeBuffer, arrayIndex * MovieRelationInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieRelationInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MovieRelationInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MovieRelationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieRelationInfo");
			return;
		}
		EnumMarshaler<EMovieRelationType>.ToNative(IntPtr.Add(nativeStruct, MovieRelationType_Offset), 0, MovieRelationType_PropertyAddress.Address, MovieRelationType);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
	}

	public FMovieRelationInfo(IntPtr nativeStruct)
	{
		if (MovieRelationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieRelationInfo");
			MovieRelationType = EMovieRelationType.None;
			ActorGuid = null;
			Location = default(FVector);
		}
		else
		{
			MovieRelationType = EnumMarshaler<EMovieRelationType>.FromNative(IntPtr.Add(nativeStruct, MovieRelationType_Offset), 0, MovieRelationType_PropertyAddress.Address);
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MovieRelationInfo");
		MovieRelationInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref MovieRelationType_PropertyAddress, intPtr, "MovieRelationType");
		MovieRelationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MovieRelationType");
		MovieRelationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MovieRelationType", Classes.FEnumProperty);
		ActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		Location_Offset = NativeReflection.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		MovieRelationInfo_IsValid = ((intPtr != IntPtr.Zero && MovieRelationType_IsValid && ActorGuid_IsValid && Location_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MovieRelationInfo", (byte)MovieRelationInfo_IsValid != 0);
	}

	static FMovieRelationInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMovieRelationInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieRelationInfo));
	}
}
