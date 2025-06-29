using System;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieScene3DAttachSection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieScene3DAttachSection : UMovieScene3DConstraintSection, IMovieSceneEntityProvider, IInterface
{
	private static bool AttachSocketName_IsValid;

	private static int AttachSocketName_Offset;

	private static bool AttachComponentName_IsValid;

	private static int AttachComponentName_Offset;

	private static bool AttachmentLocationRule_IsValid;

	private static FFieldAddress AttachmentLocationRule_PropertyAddress;

	private static int AttachmentLocationRule_Offset;

	private static bool AttachmentRotationRule_IsValid;

	private static FFieldAddress AttachmentRotationRule_PropertyAddress;

	private static int AttachmentRotationRule_Offset;

	private static bool AttachmentScaleRule_IsValid;

	private static FFieldAddress AttachmentScaleRule_PropertyAddress;

	private static int AttachmentScaleRule_Offset;

	private static bool DetachmentLocationRule_IsValid;

	private static FFieldAddress DetachmentLocationRule_PropertyAddress;

	private static int DetachmentLocationRule_Offset;

	private static bool DetachmentRotationRule_IsValid;

	private static FFieldAddress DetachmentRotationRule_PropertyAddress;

	private static int DetachmentRotationRule_Offset;

	private static bool DetachmentScaleRule_IsValid;

	private static FFieldAddress DetachmentScaleRule_PropertyAddress;

	private static int DetachmentScaleRule_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachSocketName")]
	public FName AttachSocketName
	{
		get
		{
			CheckDestroyed();
			if (!AttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachSocketName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachComponentName")]
	public FName AttachComponentName
	{
		get
		{
			CheckDestroyed();
			if (!AttachComponentName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachComponentName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachComponentName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachComponentName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachComponentName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachComponentName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachmentLocationRule")]
	public EAttachmentRule AttachmentLocationRule
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachmentLocationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachmentLocationRule_Offset), 0, AttachmentLocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachmentLocationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachmentLocationRule_Offset), 0, AttachmentLocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachmentRotationRule")]
	public EAttachmentRule AttachmentRotationRule
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachmentRotationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachmentRotationRule_Offset), 0, AttachmentRotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachmentRotationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachmentRotationRule_Offset), 0, AttachmentRotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachmentScaleRule")]
	public EAttachmentRule AttachmentScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachmentScaleRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachmentScaleRule_Offset), 0, AttachmentScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:AttachmentScaleRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachmentScaleRule_Offset), 0, AttachmentScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DAttachSection:DetachmentLocationRule")]
	public EDetachmentRule DetachmentLocationRule
	{
		get
		{
			CheckDestroyed();
			if (!DetachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:DetachmentLocationRule");
				return EDetachmentRule.KeepRelative;
			}
			return EnumMarshaler<EDetachmentRule>.FromNative(IntPtr.Add(base.Address, DetachmentLocationRule_Offset), 0, DetachmentLocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:DetachmentLocationRule");
			}
			else
			{
				EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(base.Address, DetachmentLocationRule_Offset), 0, DetachmentLocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DAttachSection:DetachmentRotationRule")]
	public EDetachmentRule DetachmentRotationRule
	{
		get
		{
			CheckDestroyed();
			if (!DetachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:DetachmentRotationRule");
				return EDetachmentRule.KeepRelative;
			}
			return EnumMarshaler<EDetachmentRule>.FromNative(IntPtr.Add(base.Address, DetachmentRotationRule_Offset), 0, DetachmentRotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:DetachmentRotationRule");
			}
			else
			{
				EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(base.Address, DetachmentRotationRule_Offset), 0, DetachmentRotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieScene3DAttachSection:DetachmentScaleRule")]
	public EDetachmentRule DetachmentScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!DetachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:DetachmentScaleRule");
				return EDetachmentRule.KeepRelative;
			}
			return EnumMarshaler<EDetachmentRule>.FromNative(IntPtr.Add(base.Address, DetachmentScaleRule_Offset), 0, DetachmentScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieScene3DAttachSection:DetachmentScaleRule");
			}
			else
			{
				EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(base.Address, DetachmentScaleRule_Offset), 0, DetachmentScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	static UMovieScene3DAttachSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieScene3DAttachSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieScene3DAttachSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieScene3DAttachSection");
		AttachSocketName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachSocketName");
		AttachSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachSocketName", Classes.FNameProperty);
		AttachComponentName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachComponentName");
		AttachComponentName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachComponentName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachmentLocationRule_PropertyAddress, unrealStruct, "AttachmentLocationRule");
		AttachmentLocationRule_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachmentLocationRule");
		AttachmentLocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachmentLocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachmentRotationRule_PropertyAddress, unrealStruct, "AttachmentRotationRule");
		AttachmentRotationRule_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachmentRotationRule");
		AttachmentRotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachmentRotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachmentScaleRule_PropertyAddress, unrealStruct, "AttachmentScaleRule");
		AttachmentScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachmentScaleRule");
		AttachmentScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachmentScaleRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DetachmentLocationRule_PropertyAddress, unrealStruct, "DetachmentLocationRule");
		DetachmentLocationRule_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DetachmentLocationRule");
		DetachmentLocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DetachmentLocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DetachmentRotationRule_PropertyAddress, unrealStruct, "DetachmentRotationRule");
		DetachmentRotationRule_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DetachmentRotationRule");
		DetachmentRotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DetachmentRotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DetachmentScaleRule_PropertyAddress, unrealStruct, "DetachmentScaleRule");
		DetachmentScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DetachmentScaleRule");
		DetachmentScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DetachmentScaleRule", Classes.FEnumProperty);
	}
}
