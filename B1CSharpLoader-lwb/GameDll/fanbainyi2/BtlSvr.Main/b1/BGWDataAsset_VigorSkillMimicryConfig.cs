using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig")]
public class BGWDataAsset_VigorSkillMimicryConfig : UBGWDataAsset
{
	private static bool CapsuleHalfHeight_IsValid;

	private static int CapsuleHalfHeight_Offset;

	private static bool CapsuleRadius_IsValid;

	private static int CapsuleRadius_Offset;

	private static bool SKMesh_IsValid;

	private static int SKMesh_Offset;

	private static bool Materials_IsValid;

	private static int Materials_Offset;

	private static FFieldAddress Materials_PropertyAddress;

	private TArrayReadWriteMarshaler<UMaterialInterface> Materials_Marshaler;

	private static bool ABPClass_IsValid;

	private static int ABPClass_Offset;

	private static bool PhysicsAsset_IsValid;

	private static int PhysicsAsset_Offset;

	private static bool AnimMimicryStart_IsValid;

	private static int AnimMimicryStart_Offset;

	private static bool Override_AbnormalDispID_Attacker_IsValid;

	private static int Override_AbnormalDispID_Attacker_Offset;

	private static bool Override_AbnormalDispID_Victim_IsValid;

	private static int Override_AbnormalDispID_Victim_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:CapsuleHalfHeight")]
	public float CapsuleHalfHeight
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:CapsuleHalfHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapsuleHalfHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleHalfHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:CapsuleHalfHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapsuleHalfHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:CapsuleRadius")]
	public float CapsuleRadius
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:CapsuleRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapsuleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:CapsuleRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapsuleRadius_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:SKMesh")]
	public USkeletalMesh SKMesh
	{
		get
		{
			CheckDestroyed();
			if (!SKMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:SKMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, SKMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SKMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:SKMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, SKMesh_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:Materials")]
	public TArrayReadWrite<UMaterialInterface> Materials
	{
		get
		{
			CheckDestroyed();
			if (!Materials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:Materials");
				return null;
			}
			if (Materials_Marshaler == null)
			{
				Materials_Marshaler = new TArrayReadWriteMarshaler<UMaterialInterface>(1, Materials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative);
			}
			return Materials_Marshaler.FromNative(IntPtr.Add(base.Address, Materials_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:ABPClass")]
	public TSubclassOf<UAnimInstance> ABPClass
	{
		get
		{
			CheckDestroyed();
			if (!ABPClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:ABPClass");
				return default(TSubclassOf<UAnimInstance>);
			}
			return TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(base.Address, ABPClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ABPClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:ABPClass");
			}
			else
			{
				TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(base.Address, ABPClass_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:PhysicsAsset")]
	public UPhysicsAsset PhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:PhysicsAsset");
				return null;
			}
			return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(base.Address, PhysicsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:PhysicsAsset");
			}
			else
			{
				UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(base.Address, PhysicsAsset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:AnimMimicryStart")]
	public UAnimMontage AnimMimicryStart
	{
		get
		{
			CheckDestroyed();
			if (!AnimMimicryStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:AnimMimicryStart");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AnimMimicryStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimMimicryStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:AnimMimicryStart");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AnimMimicryStart_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:Override_AbnormalDispID_Attacker")]
	public int Override_AbnormalDispID_Attacker
	{
		get
		{
			CheckDestroyed();
			if (!Override_AbnormalDispID_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:Override_AbnormalDispID_Attacker");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Override_AbnormalDispID_Attacker_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Override_AbnormalDispID_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:Override_AbnormalDispID_Attacker");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Override_AbnormalDispID_Attacker_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:Override_AbnormalDispID_Victim")]
	public int Override_AbnormalDispID_Victim
	{
		get
		{
			CheckDestroyed();
			if (!Override_AbnormalDispID_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:Override_AbnormalDispID_Victim");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Override_AbnormalDispID_Victim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Override_AbnormalDispID_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig:Override_AbnormalDispID_Victim");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Override_AbnormalDispID_Victim_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Override_AbnormalDispID_Attacker = -1;
		Override_AbnormalDispID_Victim = -1;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_VigorSkillMimicryConfig");
		CapsuleHalfHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CapsuleHalfHeight");
		CapsuleHalfHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CapsuleHalfHeight", Classes.FFloatProperty);
		CapsuleRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CapsuleRadius");
		CapsuleRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CapsuleRadius", Classes.FFloatProperty);
		SKMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SKMesh");
		SKMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SKMesh", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Materials_PropertyAddress, unrealStruct, "Materials");
		Materials_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Materials");
		Materials_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Materials", Classes.FArrayProperty);
		ABPClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ABPClass");
		ABPClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ABPClass", Classes.FClassProperty);
		PhysicsAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PhysicsAsset");
		PhysicsAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PhysicsAsset", Classes.FObjectProperty);
		AnimMimicryStart_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimMimicryStart");
		AnimMimicryStart_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimMimicryStart", Classes.FObjectProperty);
		Override_AbnormalDispID_Attacker_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Override_AbnormalDispID_Attacker");
		Override_AbnormalDispID_Attacker_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Override_AbnormalDispID_Attacker", Classes.FIntProperty);
		Override_AbnormalDispID_Victim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Override_AbnormalDispID_Victim");
		Override_AbnormalDispID_Victim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Override_AbnormalDispID_Victim", Classes.FIntProperty);
	}

	static BGWDataAsset_VigorSkillMimicryConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_VigorSkillMimicryConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_VigorSkillMimicryConfig));
	}
}
