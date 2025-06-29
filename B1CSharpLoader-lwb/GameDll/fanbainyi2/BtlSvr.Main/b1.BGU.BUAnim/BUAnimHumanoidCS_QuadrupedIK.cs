using System;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Abstract]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK")]
public class BUAnimHumanoidCS_QuadrupedIK : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPFootIKData FootIKData;

	private static bool IKEffectorLeftFoot_IsValid;

	private static int IKEffectorLeftFoot_Offset;

	private static bool IKEffectorRightFoot_IsValid;

	private static int IKEffectorRightFoot_Offset;

	private static bool IKEffectorLFoot_MeshSpace_IsValid;

	private static int IKEffectorLFoot_MeshSpace_Offset;

	private static bool IKEffectorRFoot_MeshSpace_IsValid;

	private static int IKEffectorRFoot_MeshSpace_Offset;

	private static bool IKEffectorLeftHand_IsValid;

	private static int IKEffectorLeftHand_Offset;

	private static bool IKEffectorRightHand_IsValid;

	private static int IKEffectorRightHand_Offset;

	private static bool IKEffectorLHand_MeshSpace_IsValid;

	private static int IKEffectorLHand_MeshSpace_Offset;

	private static bool IKEffectorRHand_MeshSpace_IsValid;

	private static int IKEffectorRHand_MeshSpace_Offset;

	private static bool IKJoint_LeftFoot_IsValid;

	private static int IKJoint_LeftFoot_Offset;

	private static bool IKJoint_RightFoot_IsValid;

	private static int IKJoint_RightFoot_Offset;

	private static bool IKJointLFoot_MeshSpace_IsValid;

	private static int IKJointLFoot_MeshSpace_Offset;

	private static bool IKJointRFoot_MeshSpace_IsValid;

	private static int IKJointRFoot_MeshSpace_Offset;

	private static bool IKJoint_LeftHand_IsValid;

	private static int IKJoint_LeftHand_Offset;

	private static bool IKJoint_RightHand_IsValid;

	private static int IKJoint_RightHand_Offset;

	private static bool IKJointLHand_MeshSpace_IsValid;

	private static int IKJointLHand_MeshSpace_Offset;

	private static bool IKJointRHand_MeshSpace_IsValid;

	private static int IKJointRHand_MeshSpace_Offset;

	private static bool IKLeftFootAlpha_IsValid;

	private static int IKLeftFootAlpha_Offset;

	private static bool IKRightFootAlpha_IsValid;

	private static int IKRightFootAlpha_Offset;

	private static bool IKLeftHandAlpha_IsValid;

	private static int IKLeftHandAlpha_Offset;

	private static bool IKRightHandAlpha_IsValid;

	private static int IKRightHandAlpha_Offset;

	private static bool IKScale_IsValid;

	private static int IKScale_Offset;

	private static bool IKPelvisOffset_IsValid;

	private static int IKPelvisOffset_Offset;

	private static bool IKNeckOffset_IsValid;

	private static int IKNeckOffset_Offset;

	private static bool bFootUseFBIK_IsValid;

	private static int bFootUseFBIK_Offset;

	private static FFieldAddress bFootUseFBIK_PropertyAddress;

	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLeftFoot")]
	public FVector IKEffectorLeftFoot
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorLeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLeftFoot");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorLeftFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorLeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLeftFoot");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorLeftFoot_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRightFoot")]
	public FVector IKEffectorRightFoot
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorRightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRightFoot");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorRightFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorRightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRightFoot");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorRightFoot_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLFoot_MeshSpace")]
	public FVector IKEffectorLFoot_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorLFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLFoot_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorLFoot_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorLFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLFoot_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorLFoot_MeshSpace_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRFoot_MeshSpace")]
	public FVector IKEffectorRFoot_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorRFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRFoot_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorRFoot_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorRFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRFoot_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorRFoot_MeshSpace_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLeftHand")]
	public FVector IKEffectorLeftHand
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorLeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLeftHand");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorLeftHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorLeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLeftHand");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorLeftHand_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRightHand")]
	public FVector IKEffectorRightHand
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorRightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRightHand");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorRightHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorRightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRightHand");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorRightHand_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLHand_MeshSpace")]
	public FVector IKEffectorLHand_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorLHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLHand_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorLHand_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorLHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorLHand_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorLHand_MeshSpace_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRHand_MeshSpace")]
	public FVector IKEffectorRHand_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorRHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRHand_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorRHand_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorRHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKEffectorRHand_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorRHand_MeshSpace_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_LeftFoot")]
	public FVector IKJoint_LeftFoot
	{
		get
		{
			CheckDestroyed();
			if (!IKJoint_LeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_LeftFoot");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJoint_LeftFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJoint_LeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_LeftFoot");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJoint_LeftFoot_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_RightFoot")]
	public FVector IKJoint_RightFoot
	{
		get
		{
			CheckDestroyed();
			if (!IKJoint_RightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_RightFoot");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJoint_RightFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJoint_RightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_RightFoot");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJoint_RightFoot_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointLFoot_MeshSpace")]
	public FVector IKJointLFoot_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKJointLFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointLFoot_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJointLFoot_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJointLFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointLFoot_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJointLFoot_MeshSpace_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointRFoot_MeshSpace")]
	public FVector IKJointRFoot_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKJointRFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointRFoot_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJointRFoot_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJointRFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointRFoot_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJointRFoot_MeshSpace_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_LeftHand")]
	public FVector IKJoint_LeftHand
	{
		get
		{
			CheckDestroyed();
			if (!IKJoint_LeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_LeftHand");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJoint_LeftHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJoint_LeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_LeftHand");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJoint_LeftHand_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_RightHand")]
	public FVector IKJoint_RightHand
	{
		get
		{
			CheckDestroyed();
			if (!IKJoint_RightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_RightHand");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJoint_RightHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJoint_RightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJoint_RightHand");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJoint_RightHand_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointLHand_MeshSpace")]
	public FVector IKJointLHand_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKJointLHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointLHand_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJointLHand_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJointLHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointLHand_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJointLHand_MeshSpace_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointRHand_MeshSpace")]
	public FVector IKJointRHand_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKJointRHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointRHand_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJointRHand_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJointRHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKJointRHand_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJointRHand_MeshSpace_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKLeftFootAlpha")]
	public float IKLeftFootAlpha
	{
		get
		{
			CheckDestroyed();
			if (!IKLeftFootAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKLeftFootAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKLeftFootAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKLeftFootAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKLeftFootAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKLeftFootAlpha_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKRightFootAlpha")]
	public float IKRightFootAlpha
	{
		get
		{
			CheckDestroyed();
			if (!IKRightFootAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKRightFootAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKRightFootAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKRightFootAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKRightFootAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKRightFootAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKLeftHandAlpha")]
	public float IKLeftHandAlpha
	{
		get
		{
			CheckDestroyed();
			if (!IKLeftHandAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKLeftHandAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKLeftHandAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKLeftHandAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKLeftHandAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKLeftHandAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKRightHandAlpha")]
	public float IKRightHandAlpha
	{
		get
		{
			CheckDestroyed();
			if (!IKRightHandAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKRightHandAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKRightHandAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKRightHandAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKRightHandAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKRightHandAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKScale")]
	public float IKScale
	{
		get
		{
			CheckDestroyed();
			if (!IKScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKScale_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKPelvisOffset")]
	public float IKPelvisOffset
	{
		get
		{
			CheckDestroyed();
			if (!IKPelvisOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKPelvisOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKPelvisOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKPelvisOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKPelvisOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKPelvisOffset_Offset), value);
			}
		}
	}

	[Category("QuadrupedIK")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKNeckOffset")]
	public float IKNeckOffset
	{
		get
		{
			CheckDestroyed();
			if (!IKNeckOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKNeckOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKNeckOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKNeckOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:IKNeckOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKNeckOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("QuadrupedIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:bFootUseFBIK")]
	public bool bFootUseFBIK
	{
		get
		{
			CheckDestroyed();
			if (!bFootUseFBIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:bFootUseFBIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFootUseFBIK_Offset), 0, bFootUseFBIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFootUseFBIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK:bFootUseFBIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFootUseFBIK_Offset), 0, bFootUseFBIK_PropertyAddress.Address, value);
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
			FootIKData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPFootIKData, BUC_ABPFootIKData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		if (FootIKData != null)
		{
			bFootUseFBIK = FootIKData.bFootUseFBIK;
		}
	}

	private void UpdateData()
	{
		if (FootIKData != null)
		{
			IKEffectorLeftFoot = FootIKData.IKEffectorLeftFoot;
			IKEffectorRightFoot = FootIKData.IKEffectorRightFoot;
			IKEffectorLFoot_MeshSpace = FootIKData.IKEffectorLFoot_MeshSpace;
			IKEffectorRFoot_MeshSpace = FootIKData.IKEffectorRFoot_MeshSpace;
			IKEffectorLeftHand = FootIKData.IKEffectorLeftHand;
			IKEffectorRightHand = FootIKData.IKEffectorRightHand;
			IKEffectorLHand_MeshSpace = FootIKData.IKEffectorLHand_MeshSpace;
			IKEffectorRHand_MeshSpace = FootIKData.IKEffectorRHand_MeshSpace;
			IKLeftFootAlpha = FootIKData.IKLeftFootAlpha;
			IKRightFootAlpha = FootIKData.IKRightFootAlpha;
			IKLeftHandAlpha = FootIKData.IKAlphaLeftHand;
			IKRightHandAlpha = FootIKData.IKAlphaRightHand;
			IKJoint_LeftFoot = FootIKData.IKJoint_LeftFoot;
			IKJoint_RightFoot = FootIKData.IKJoint_RightFoot;
			IKJointLFoot_MeshSpace = FootIKData.IKJointLFoot_MeshSpace;
			IKJointRFoot_MeshSpace = FootIKData.IKJointRFoot_MeshSpace;
			IKJoint_LeftHand = FootIKData.IKJointLeftHand;
			IKJoint_RightHand = FootIKData.IKJointRightHand;
			IKPelvisOffset = FootIKData.IKPelvisOffsetScaled;
			IKNeckOffset = FootIKData.IKNeckOffsetScaled;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_QuadrupedIK");
		IKEffectorLeftFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorLeftFoot");
		IKEffectorLeftFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorLeftFoot", Classes.FStructProperty);
		IKEffectorRightFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorRightFoot");
		IKEffectorRightFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorRightFoot", Classes.FStructProperty);
		IKEffectorLFoot_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorLFoot_MeshSpace");
		IKEffectorLFoot_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorLFoot_MeshSpace", Classes.FStructProperty);
		IKEffectorRFoot_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorRFoot_MeshSpace");
		IKEffectorRFoot_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorRFoot_MeshSpace", Classes.FStructProperty);
		IKEffectorLeftHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorLeftHand");
		IKEffectorLeftHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorLeftHand", Classes.FStructProperty);
		IKEffectorRightHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorRightHand");
		IKEffectorRightHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorRightHand", Classes.FStructProperty);
		IKEffectorLHand_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorLHand_MeshSpace");
		IKEffectorLHand_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorLHand_MeshSpace", Classes.FStructProperty);
		IKEffectorRHand_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorRHand_MeshSpace");
		IKEffectorRHand_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorRHand_MeshSpace", Classes.FStructProperty);
		IKJoint_LeftFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJoint_LeftFoot");
		IKJoint_LeftFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJoint_LeftFoot", Classes.FStructProperty);
		IKJoint_RightFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJoint_RightFoot");
		IKJoint_RightFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJoint_RightFoot", Classes.FStructProperty);
		IKJointLFoot_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJointLFoot_MeshSpace");
		IKJointLFoot_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJointLFoot_MeshSpace", Classes.FStructProperty);
		IKJointRFoot_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJointRFoot_MeshSpace");
		IKJointRFoot_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJointRFoot_MeshSpace", Classes.FStructProperty);
		IKJoint_LeftHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJoint_LeftHand");
		IKJoint_LeftHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJoint_LeftHand", Classes.FStructProperty);
		IKJoint_RightHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJoint_RightHand");
		IKJoint_RightHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJoint_RightHand", Classes.FStructProperty);
		IKJointLHand_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJointLHand_MeshSpace");
		IKJointLHand_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJointLHand_MeshSpace", Classes.FStructProperty);
		IKJointRHand_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJointRHand_MeshSpace");
		IKJointRHand_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJointRHand_MeshSpace", Classes.FStructProperty);
		IKLeftFootAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKLeftFootAlpha");
		IKLeftFootAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKLeftFootAlpha", Classes.FFloatProperty);
		IKRightFootAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKRightFootAlpha");
		IKRightFootAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKRightFootAlpha", Classes.FFloatProperty);
		IKLeftHandAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKLeftHandAlpha");
		IKLeftHandAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKLeftHandAlpha", Classes.FFloatProperty);
		IKRightHandAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKRightHandAlpha");
		IKRightHandAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKRightHandAlpha", Classes.FFloatProperty);
		IKScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKScale");
		IKScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKScale", Classes.FFloatProperty);
		IKPelvisOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKPelvisOffset");
		IKPelvisOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKPelvisOffset", Classes.FFloatProperty);
		IKNeckOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKNeckOffset");
		IKNeckOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKNeckOffset", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bFootUseFBIK_PropertyAddress, unrealStruct, "bFootUseFBIK");
		bFootUseFBIK_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFootUseFBIK");
		bFootUseFBIK_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFootUseFBIK", Classes.FBoolProperty);
	}

	static BUAnimHumanoidCS_QuadrupedIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_QuadrupedIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_QuadrupedIK));
	}
}
