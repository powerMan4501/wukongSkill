using System;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[Blueprintable]
[Abstract]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK")]
public class BUAnimHumanoidCS_FootIK : BUAnimHumanoidCS_LinkedInstanceBase
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

	private static bool IKJoint_LeftFoot_IsValid;

	private static int IKJoint_LeftFoot_Offset;

	private static bool IKJoint_RightFoot_IsValid;

	private static int IKJoint_RightFoot_Offset;

	private static bool IKJointLFoot_MeshSpace_IsValid;

	private static int IKJointLFoot_MeshSpace_Offset;

	private static bool IKJointRFoot_MeshSpace_IsValid;

	private static int IKJointRFoot_MeshSpace_Offset;

	private static bool IKLeftFootAlpha_IsValid;

	private static int IKLeftFootAlpha_Offset;

	private static bool IKRightFootAlpha_IsValid;

	private static int IKRightFootAlpha_Offset;

	private static bool IKScale_IsValid;

	private static int IKScale_Offset;

	private static bool IKPelvisOffset_IsValid;

	private static int IKPelvisOffset_Offset;

	private static bool bFootUseFBIK_IsValid;

	private static int bFootUseFBIK_Offset;

	private static FFieldAddress bFootUseFBIK_PropertyAddress;

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("IKFoot")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorLeftFoot")]
	public FVector IKEffectorLeftFoot
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorLeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorLeftFoot");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorLeftFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorLeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorLeftFoot");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorLeftFoot_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("IKFoot")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorRightFoot")]
	public FVector IKEffectorRightFoot
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorRightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorRightFoot");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorRightFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorRightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorRightFoot");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorRightFoot_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[Category("IKFoot")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorLFoot_MeshSpace")]
	public FVector IKEffectorLFoot_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorLFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorLFoot_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorLFoot_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorLFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorLFoot_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorLFoot_MeshSpace_Offset), value);
			}
		}
	}

	[Category("IKFoot")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorRFoot_MeshSpace")]
	public FVector IKEffectorRFoot_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorRFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorRFoot_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorRFoot_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorRFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKEffectorRFoot_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorRFoot_MeshSpace_Offset), value);
			}
		}
	}

	[Category("IKFoot")]
	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJoint_LeftFoot")]
	public FVector IKJoint_LeftFoot
	{
		get
		{
			CheckDestroyed();
			if (!IKJoint_LeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJoint_LeftFoot");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJoint_LeftFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJoint_LeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJoint_LeftFoot");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJoint_LeftFoot_Offset), value);
			}
		}
	}

	[Category("IKFoot")]
	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJoint_RightFoot")]
	public FVector IKJoint_RightFoot
	{
		get
		{
			CheckDestroyed();
			if (!IKJoint_RightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJoint_RightFoot");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJoint_RightFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJoint_RightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJoint_RightFoot");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJoint_RightFoot_Offset), value);
			}
		}
	}

	[Category("IKFoot")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJointLFoot_MeshSpace")]
	public FVector IKJointLFoot_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKJointLFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJointLFoot_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJointLFoot_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJointLFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJointLFoot_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJointLFoot_MeshSpace_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[Category("IKFoot")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJointRFoot_MeshSpace")]
	public FVector IKJointRFoot_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKJointRFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJointRFoot_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJointRFoot_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJointRFoot_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKJointRFoot_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJointRFoot_MeshSpace_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[Category("IKFoot")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKLeftFootAlpha")]
	public float IKLeftFootAlpha
	{
		get
		{
			CheckDestroyed();
			if (!IKLeftFootAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKLeftFootAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKLeftFootAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKLeftFootAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKLeftFootAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKLeftFootAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("IKFoot")]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKRightFootAlpha")]
	public float IKRightFootAlpha
	{
		get
		{
			CheckDestroyed();
			if (!IKRightFootAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKRightFootAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKRightFootAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKRightFootAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKRightFootAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKRightFootAlpha_Offset), value);
			}
		}
	}

	[Category("IKFoot")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKScale")]
	public float IKScale
	{
		get
		{
			CheckDestroyed();
			if (!IKScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKScale_Offset), value);
			}
		}
	}

	[Category("IKFoot")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKPelvisOffset")]
	public float IKPelvisOffset
	{
		get
		{
			CheckDestroyed();
			if (!IKPelvisOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKPelvisOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKPelvisOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKPelvisOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:IKPelvisOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKPelvisOffset_Offset), value);
			}
		}
	}

	[Category("IKFoot")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:bFootUseFBIK")]
	public bool bFootUseFBIK
	{
		get
		{
			CheckDestroyed();
			if (!bFootUseFBIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:bFootUseFBIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFootUseFBIK_Offset), 0, bFootUseFBIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFootUseFBIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FootIK:bFootUseFBIK");
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
			if (FootIKData.bEnableDebug)
			{
				Owner.GetName();
			}
			IKEffectorLFoot_MeshSpace = FootIKData.IKEffectorLFoot_MeshSpace;
			IKEffectorRFoot_MeshSpace = FootIKData.IKEffectorRFoot_MeshSpace;
			IKLeftFootAlpha = FootIKData.IKLeftFootAlpha;
			IKRightFootAlpha = FootIKData.IKRightFootAlpha;
			IKJoint_LeftFoot = FootIKData.IKJoint_LeftFoot;
			IKJoint_RightFoot = FootIKData.IKJoint_RightFoot;
			IKJointLFoot_MeshSpace = FootIKData.IKJointLFoot_MeshSpace;
			IKJointRFoot_MeshSpace = FootIKData.IKJointRFoot_MeshSpace;
			IKPelvisOffset = FootIKData.IKPelvisOffsetScaled;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_FootIK");
		IKEffectorLeftFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorLeftFoot");
		IKEffectorLeftFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorLeftFoot", Classes.FStructProperty);
		IKEffectorRightFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorRightFoot");
		IKEffectorRightFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorRightFoot", Classes.FStructProperty);
		IKEffectorLFoot_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorLFoot_MeshSpace");
		IKEffectorLFoot_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorLFoot_MeshSpace", Classes.FStructProperty);
		IKEffectorRFoot_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorRFoot_MeshSpace");
		IKEffectorRFoot_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorRFoot_MeshSpace", Classes.FStructProperty);
		IKJoint_LeftFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJoint_LeftFoot");
		IKJoint_LeftFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJoint_LeftFoot", Classes.FStructProperty);
		IKJoint_RightFoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJoint_RightFoot");
		IKJoint_RightFoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJoint_RightFoot", Classes.FStructProperty);
		IKJointLFoot_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJointLFoot_MeshSpace");
		IKJointLFoot_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJointLFoot_MeshSpace", Classes.FStructProperty);
		IKJointRFoot_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJointRFoot_MeshSpace");
		IKJointRFoot_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJointRFoot_MeshSpace", Classes.FStructProperty);
		IKLeftFootAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKLeftFootAlpha");
		IKLeftFootAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKLeftFootAlpha", Classes.FFloatProperty);
		IKRightFootAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKRightFootAlpha");
		IKRightFootAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKRightFootAlpha", Classes.FFloatProperty);
		IKScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKScale");
		IKScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKScale", Classes.FFloatProperty);
		IKPelvisOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKPelvisOffset");
		IKPelvisOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKPelvisOffset", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bFootUseFBIK_PropertyAddress, unrealStruct, "bFootUseFBIK");
		bFootUseFBIK_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFootUseFBIK");
		bFootUseFBIK_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFootUseFBIK", Classes.FBoolProperty);
	}

	static BUAnimHumanoidCS_FootIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_FootIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_FootIK));
	}
}
