using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)812122272uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieScene3DPathSection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieScene3DPathSection : UMovieScene3DConstraintSection
{
	private static bool FrontAxisEnum_IsValid;

	private static FFieldAddress FrontAxisEnum_PropertyAddress;

	private static int FrontAxisEnum_Offset;

	private static bool UpAxisEnum_IsValid;

	private static FFieldAddress UpAxisEnum_PropertyAddress;

	private static int UpAxisEnum_Offset;

	private static bool Follow_IsValid;

	private static FFieldAddress Follow_PropertyAddress;

	private static int Follow_Offset;

	private static bool Reverse_IsValid;

	private static FFieldAddress Reverse_PropertyAddress;

	private static int Reverse_Offset;

	private static bool ForceUpright_IsValid;

	private static FFieldAddress ForceUpright_PropertyAddress;

	private static int ForceUpright_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DPathSection:FrontAxisEnum")]
	public EMovieScene3DPathSection_Axis FrontAxisEnum
	{
		get
		{
			CheckDestroyed();
			if (!FrontAxisEnum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:FrontAxisEnum");
				return EMovieScene3DPathSection_Axis.X;
			}
			return EnumMarshaler<EMovieScene3DPathSection_Axis>.FromNative(IntPtr.Add(base.Address, FrontAxisEnum_Offset), 0, FrontAxisEnum_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FrontAxisEnum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:FrontAxisEnum");
			}
			else
			{
				EnumMarshaler<EMovieScene3DPathSection_Axis>.ToNative(IntPtr.Add(base.Address, FrontAxisEnum_Offset), 0, FrontAxisEnum_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DPathSection:UpAxisEnum")]
	public EMovieScene3DPathSection_Axis UpAxisEnum
	{
		get
		{
			CheckDestroyed();
			if (!UpAxisEnum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:UpAxisEnum");
				return EMovieScene3DPathSection_Axis.X;
			}
			return EnumMarshaler<EMovieScene3DPathSection_Axis>.FromNative(IntPtr.Add(base.Address, UpAxisEnum_Offset), 0, UpAxisEnum_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UpAxisEnum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:UpAxisEnum");
			}
			else
			{
				EnumMarshaler<EMovieScene3DPathSection_Axis>.ToNative(IntPtr.Add(base.Address, UpAxisEnum_Offset), 0, UpAxisEnum_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DPathSection:bFollow")]
	public bool Follow
	{
		get
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:bFollow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:bFollow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DPathSection:bReverse")]
	public bool Reverse
	{
		get
		{
			CheckDestroyed();
			if (!Reverse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:bReverse");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Reverse_Offset), 0, Reverse_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Reverse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:bReverse");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Reverse_Offset), 0, Reverse_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DPathSection:bForceUpright")]
	public bool ForceUpright
	{
		get
		{
			CheckDestroyed();
			if (!ForceUpright_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:bForceUpright");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceUpright_Offset), 0, ForceUpright_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceUpright_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DPathSection:bForceUpright");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceUpright_Offset), 0, ForceUpright_PropertyAddress.Address, value);
			}
		}
	}

	static UMovieScene3DPathSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieScene3DPathSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieScene3DPathSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieScene3DPathSection");
		NativeReflectionCached.GetPropertyRef(ref FrontAxisEnum_PropertyAddress, unrealStruct, "FrontAxisEnum");
		FrontAxisEnum_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FrontAxisEnum");
		FrontAxisEnum_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FrontAxisEnum", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UpAxisEnum_PropertyAddress, unrealStruct, "UpAxisEnum");
		UpAxisEnum_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UpAxisEnum");
		UpAxisEnum_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UpAxisEnum", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Follow_PropertyAddress, unrealStruct, "bFollow");
		Follow_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bFollow");
		Follow_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bFollow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Reverse_PropertyAddress, unrealStruct, "bReverse");
		Reverse_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReverse");
		Reverse_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReverse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceUpright_PropertyAddress, unrealStruct, "bForceUpright");
		ForceUpright_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bForceUpright");
		ForceUpright_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bForceUpright", Classes.FBoolProperty);
	}
}
