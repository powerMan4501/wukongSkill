using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BUC_ACharacterComponent", "b1", UnrealModuleType.Game)]
public class UBUC_ACharacterComponent : UObject
{
	private static bool OwnerCharacter_IsValid;

	private static int OwnerCharacter_Offset;

	private static bool OwnerMovement_IsValid;

	private static int OwnerMovement_Offset;

	private static bool OwnerShapeComponent_IsValid;

	private static int OwnerShapeComponent_Offset;

	private static bool MainSkinMesh_IsValid;

	private static int MainSkinMesh_Offset;

	private static bool OwnerController_IsValid;

	private static int OwnerController_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.BUC_ACharacterComponent:OwnerCharacter")]
	public ACharacter OwnerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:OwnerCharacter");
				return null;
			}
			return UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(base.Address, OwnerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:OwnerCharacter");
			}
			else
			{
				UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(base.Address, OwnerCharacter_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799132uL)]
	[UMetaPath("/Script/b1.BUC_ACharacterComponent:OwnerMovement")]
	public UBGUCharacterMovementComponent OwnerMovement
	{
		get
		{
			CheckDestroyed();
			if (!OwnerMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:OwnerMovement");
				return null;
			}
			return UObjectMarshaler<UBGUCharacterMovementComponent>.FromNative(IntPtr.Add(base.Address, OwnerMovement_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:OwnerMovement");
			}
			else
			{
				UObjectMarshaler<UBGUCharacterMovementComponent>.ToNative(IntPtr.Add(base.Address, OwnerMovement_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799132uL)]
	[UMetaPath("/Script/b1.BUC_ACharacterComponent:OwnerShapeComponent")]
	public UShapeComponent OwnerShapeComponent
	{
		get
		{
			CheckDestroyed();
			if (!OwnerShapeComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:OwnerShapeComponent");
				return null;
			}
			return UObjectMarshaler<UShapeComponent>.FromNative(IntPtr.Add(base.Address, OwnerShapeComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerShapeComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:OwnerShapeComponent");
			}
			else
			{
				UObjectMarshaler<UShapeComponent>.ToNative(IntPtr.Add(base.Address, OwnerShapeComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799132uL)]
	[UMetaPath("/Script/b1.BUC_ACharacterComponent:MainSkinMesh")]
	public USkeletalMeshComponent MainSkinMesh
	{
		get
		{
			CheckDestroyed();
			if (!MainSkinMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:MainSkinMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, MainSkinMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainSkinMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:MainSkinMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, MainSkinMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.BUC_ACharacterComponent:OwnerController")]
	public AController OwnerController
	{
		get
		{
			CheckDestroyed();
			if (!OwnerController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:OwnerController");
				return null;
			}
			return UObjectMarshaler<AController>.FromNative(IntPtr.Add(base.Address, OwnerController_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_ACharacterComponent:OwnerController");
			}
			else
			{
				UObjectMarshaler<AController>.ToNative(IntPtr.Add(base.Address, OwnerController_Offset), value);
			}
		}
	}

	static UBUC_ACharacterComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBUC_ACharacterComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBUC_ACharacterComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BUC_ACharacterComponent");
		OwnerCharacter_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OwnerCharacter");
		OwnerCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OwnerCharacter", Classes.FObjectProperty);
		OwnerMovement_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OwnerMovement");
		OwnerMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OwnerMovement", Classes.FObjectProperty);
		OwnerShapeComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OwnerShapeComponent");
		OwnerShapeComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OwnerShapeComponent", Classes.FObjectProperty);
		MainSkinMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MainSkinMesh");
		MainSkinMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MainSkinMesh", Classes.FObjectProperty);
		OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OwnerController");
		OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OwnerController", Classes.FObjectProperty);
	}
}
