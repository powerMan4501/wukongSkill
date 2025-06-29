using System;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Abstract]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK")]
public class BUAnimHumanoidCS_HandIK : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPFootIKData FootIKData;

	private static bool bRHandUseFBIK_IsValid;

	private static int bRHandUseFBIK_Offset;

	private static FFieldAddress bRHandUseFBIK_PropertyAddress;

	private static bool bLHandUseFBIK_IsValid;

	private static int bLHandUseFBIK_Offset;

	private static FFieldAddress bLHandUseFBIK_PropertyAddress;

	private static bool IKEffectorLHand_MeshSpace_IsValid;

	private static int IKEffectorLHand_MeshSpace_Offset;

	private static bool IKEffectorRHand_MeshSpace_IsValid;

	private static int IKEffectorRHand_MeshSpace_Offset;

	private static bool IKEffectorLeftHand_IsValid;

	private static int IKEffectorLeftHand_Offset;

	private static bool IKEffectorRightHand_IsValid;

	private static int IKEffectorRightHand_Offset;

	private static bool IKJointLeftHand_IsValid;

	private static int IKJointLeftHand_Offset;

	private static bool IKJointRightHand_IsValid;

	private static int IKJointRightHand_Offset;

	private static bool IKAlphaLeftHand_IsValid;

	private static int IKAlphaLeftHand_Offset;

	private static bool IKAlphaRightHand_IsValid;

	private static int IKAlphaRightHand_Offset;

	[UProperty]
	[Category("IKHand")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:bRHandUseFBIK")]
	public bool bRHandUseFBIK
	{
		get
		{
			CheckDestroyed();
			if (!bRHandUseFBIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:bRHandUseFBIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRHandUseFBIK_Offset), 0, bRHandUseFBIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRHandUseFBIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:bRHandUseFBIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRHandUseFBIK_Offset), 0, bRHandUseFBIK_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("IKHand")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:bLHandUseFBIK")]
	public bool bLHandUseFBIK
	{
		get
		{
			CheckDestroyed();
			if (!bLHandUseFBIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:bLHandUseFBIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLHandUseFBIK_Offset), 0, bLHandUseFBIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLHandUseFBIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:bLHandUseFBIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLHandUseFBIK_Offset), 0, bLHandUseFBIK_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("IKHand")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorLHand_MeshSpace")]
	public FVector IKEffectorLHand_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorLHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorLHand_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorLHand_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorLHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorLHand_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorLHand_MeshSpace_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("IKHand")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorRHand_MeshSpace")]
	public FVector IKEffectorRHand_MeshSpace
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorRHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorRHand_MeshSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorRHand_MeshSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorRHand_MeshSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorRHand_MeshSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorRHand_MeshSpace_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("IKHand")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorLeftHand")]
	public FVector IKEffectorLeftHand
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorLeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorLeftHand");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorLeftHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorLeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorLeftHand");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorLeftHand_Offset), value);
			}
		}
	}

	[Category("IKHand")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorRightHand")]
	public FVector IKEffectorRightHand
	{
		get
		{
			CheckDestroyed();
			if (!IKEffectorRightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorRightHand");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKEffectorRightHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKEffectorRightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKEffectorRightHand");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKEffectorRightHand_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("IKHand")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKJointLeftHand")]
	public FVector IKJointLeftHand
	{
		get
		{
			CheckDestroyed();
			if (!IKJointLeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKJointLeftHand");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJointLeftHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJointLeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKJointLeftHand");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJointLeftHand_Offset), value);
			}
		}
	}

	[Category("IKHand")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKJointRightHand")]
	public FVector IKJointRightHand
	{
		get
		{
			CheckDestroyed();
			if (!IKJointRightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKJointRightHand");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, IKJointRightHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKJointRightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKJointRightHand");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, IKJointRightHand_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("IKHand")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKAlphaLeftHand")]
	public float IKAlphaLeftHand
	{
		get
		{
			CheckDestroyed();
			if (!IKAlphaLeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKAlphaLeftHand");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKAlphaLeftHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKAlphaLeftHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKAlphaLeftHand");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKAlphaLeftHand_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("IKHand")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKAlphaRightHand")]
	public float IKAlphaRightHand
	{
		get
		{
			CheckDestroyed();
			if (!IKAlphaRightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKAlphaRightHand");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IKAlphaRightHand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKAlphaRightHand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_HandIK:IKAlphaRightHand");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IKAlphaRightHand_Offset), value);
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
	}

	private void UpdateData()
	{
		if (FootIKData != null)
		{
			bRHandUseFBIK = FootIKData.bRHandUseFBIK;
			bLHandUseFBIK = FootIKData.bLHandUseFBIK;
			IKEffectorLeftHand = FootIKData.IKEffectorLeftHand;
			IKEffectorRightHand = FootIKData.IKEffectorRightHand;
			IKAlphaLeftHand = FootIKData.IKAlphaLeftHand;
			IKAlphaRightHand = FootIKData.IKAlphaRightHand;
			IKJointLeftHand = FootIKData.IKJointLeftHand;
			IKJointRightHand = FootIKData.IKJointRightHand;
			IKEffectorLHand_MeshSpace = FootIKData.IKEffectorLHand_MeshSpace;
			IKEffectorRHand_MeshSpace = FootIKData.IKEffectorRHand_MeshSpace;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_HandIK");
		NativeReflection.GetPropertyRef(ref bRHandUseFBIK_PropertyAddress, unrealStruct, "bRHandUseFBIK");
		bRHandUseFBIK_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bRHandUseFBIK");
		bRHandUseFBIK_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bRHandUseFBIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLHandUseFBIK_PropertyAddress, unrealStruct, "bLHandUseFBIK");
		bLHandUseFBIK_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLHandUseFBIK");
		bLHandUseFBIK_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLHandUseFBIK", Classes.FBoolProperty);
		IKEffectorLHand_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorLHand_MeshSpace");
		IKEffectorLHand_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorLHand_MeshSpace", Classes.FStructProperty);
		IKEffectorRHand_MeshSpace_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorRHand_MeshSpace");
		IKEffectorRHand_MeshSpace_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorRHand_MeshSpace", Classes.FStructProperty);
		IKEffectorLeftHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorLeftHand");
		IKEffectorLeftHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorLeftHand", Classes.FStructProperty);
		IKEffectorRightHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKEffectorRightHand");
		IKEffectorRightHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKEffectorRightHand", Classes.FStructProperty);
		IKJointLeftHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJointLeftHand");
		IKJointLeftHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJointLeftHand", Classes.FStructProperty);
		IKJointRightHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKJointRightHand");
		IKJointRightHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKJointRightHand", Classes.FStructProperty);
		IKAlphaLeftHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKAlphaLeftHand");
		IKAlphaLeftHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKAlphaLeftHand", Classes.FFloatProperty);
		IKAlphaRightHand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IKAlphaRightHand");
		IKAlphaRightHand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IKAlphaRightHand", Classes.FFloatProperty);
	}

	static BUAnimHumanoidCS_HandIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_HandIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_HandIK));
	}
}
