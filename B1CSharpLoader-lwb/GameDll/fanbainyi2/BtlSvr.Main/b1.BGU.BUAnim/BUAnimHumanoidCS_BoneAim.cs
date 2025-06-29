using System;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Blueprintable]
[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim")]
public class BUAnimHumanoidCS_BoneAim : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPWeaponAimData WeaponAimData;

	private static bool WeaponAimAlpha_IsValid;

	private static int WeaponAimAlpha_Offset;

	private static bool bEnableWeaponAim_IsValid;

	private static int bEnableWeaponAim_Offset;

	private static FFieldAddress bEnableWeaponAim_PropertyAddress;

	private static bool WeaponBoneName_IsValid;

	private static int WeaponBoneName_Offset;

	private static bool WeaponAimPos_IsValid;

	private static int WeaponAimPos_Offset;

	private static bool WeaponAimAxis_IsValid;

	private static int WeaponAimAxis_Offset;

	private static bool WeaponDegreesConstraint_IsValid;

	private static int WeaponDegreesConstraint_Offset;

	[BlueprintReadWrite]
	[Category("Weapon Aim")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponAimAlpha")]
	public float WeaponAimAlpha
	{
		get
		{
			CheckDestroyed();
			if (!WeaponAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponAimAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WeaponAimAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponAimAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WeaponAimAlpha_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Weapon Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:bEnableWeaponAim")]
	public bool bEnableWeaponAim
	{
		get
		{
			CheckDestroyed();
			if (!bEnableWeaponAim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:bEnableWeaponAim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableWeaponAim_Offset), 0, bEnableWeaponAim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableWeaponAim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:bEnableWeaponAim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableWeaponAim_Offset), 0, bEnableWeaponAim_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Weapon Aim")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponBoneName")]
	public FName WeaponBoneName
	{
		get
		{
			CheckDestroyed();
			if (!WeaponBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponBoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WeaponBoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponBoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WeaponBoneName_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Weapon Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponAimPos")]
	public FVector WeaponAimPos
	{
		get
		{
			CheckDestroyed();
			if (!WeaponAimPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponAimPos");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, WeaponAimPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponAimPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponAimPos");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, WeaponAimPos_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Weapon Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponAimAxis")]
	public FVector WeaponAimAxis
	{
		get
		{
			CheckDestroyed();
			if (!WeaponAimAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponAimAxis");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, WeaponAimAxis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponAimAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponAimAxis");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, WeaponAimAxis_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Weapon Aim")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponDegreesConstraint")]
	public float WeaponDegreesConstraint
	{
		get
		{
			CheckDestroyed();
			if (!WeaponDegreesConstraint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponDegreesConstraint");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WeaponDegreesConstraint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponDegreesConstraint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim:WeaponDegreesConstraint");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WeaponDegreesConstraint_Offset), value);
			}
		}
	}

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			InitData();
		}
	}

	protected override void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
		UpdateData();
	}

	private void InitBUCData()
	{
		if (!(Owner == null) && ECSExtension.IsECSActor(Owner))
		{
			WeaponAimData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPWeaponAimData, BUC_ABPWeaponAimData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		if (WeaponAimData != null)
		{
			WeaponAimAlpha = WeaponAimData.WeaponAimAlpha;
			bEnableWeaponAim = WeaponAimData.bEnableWeaponAim;
			WeaponBoneName = WeaponAimData.WeaponBoneName;
			WeaponAimPos = WeaponAimData.WeaponAimPos;
			WeaponAimAxis = WeaponAimData.WeaponAimAxis;
			WeaponDegreesConstraint = WeaponAimData.DegreesConstraint;
		}
	}

	private void UpdateData()
	{
		if (WeaponAimData != null)
		{
			WeaponAimAlpha = WeaponAimData.WeaponAimAlpha;
			bEnableWeaponAim = WeaponAimData.bEnableWeaponAim;
			WeaponBoneName = WeaponAimData.WeaponBoneName;
			WeaponAimPos = WeaponAimData.WeaponAimPos;
			WeaponAimAxis = WeaponAimData.WeaponAimAxis;
			WeaponDegreesConstraint = WeaponAimData.DegreesConstraint;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_BoneAim");
		WeaponAimAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponAimAlpha");
		WeaponAimAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponAimAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableWeaponAim_PropertyAddress, unrealStruct, "bEnableWeaponAim");
		bEnableWeaponAim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableWeaponAim");
		bEnableWeaponAim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableWeaponAim", Classes.FBoolProperty);
		WeaponBoneName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponBoneName");
		WeaponBoneName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponBoneName", Classes.FNameProperty);
		WeaponAimPos_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponAimPos");
		WeaponAimPos_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponAimPos", Classes.FStructProperty);
		WeaponAimAxis_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponAimAxis");
		WeaponAimAxis_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponAimAxis", Classes.FStructProperty);
		WeaponDegreesConstraint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponDegreesConstraint");
		WeaponDegreesConstraint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponDegreesConstraint", Classes.FFloatProperty);
	}

	static BUAnimHumanoidCS_BoneAim()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_BoneAim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_BoneAim));
	}
}
