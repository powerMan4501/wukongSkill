using System;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Blueprintable]
[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK")]
public class BUAnimHumanoidCS_AttackIK : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPAttackIKData AttackIKData;

	private static bool AttackIKAlpha_IsValid;

	private static int AttackIKAlpha_Offset;

	private static bool AttackIKRollList_IsValid;

	private static int AttackIKRollList_Offset;

	private static FFieldAddress AttackIKRollList_PropertyAddress;

	private TArrayReadWriteMarshaler<float> AttackIKRollList_Marshaler;

	private static bool AttackIKPitchList_IsValid;

	private static int AttackIKPitchList_Offset;

	private static FFieldAddress AttackIKPitchList_PropertyAddress;

	private TArrayReadWriteMarshaler<float> AttackIKPitchList_Marshaler;

	private static bool SolverRootBoneNameList_IsValid;

	private static int SolverRootBoneNameList_Offset;

	private static FFieldAddress SolverRootBoneNameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SolverRootBoneNameList_Marshaler;

	private static bool SolverEffectorBoneNameList_IsValid;

	private static int SolverEffectorBoneNameList_Offset;

	private static FFieldAddress SolverEffectorBoneNameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SolverEffectorBoneNameList_Marshaler;

	private static bool BoneScaleEnable_IsValid;

	private static int BoneScaleEnable_Offset;

	private static FFieldAddress BoneScaleEnable_PropertyAddress;

	private static bool BoneScaleName_IsValid;

	private static int BoneScaleName_Offset;

	private static bool BonePosition_IsValid;

	private static int BonePosition_Offset;

	private static bool BoneScaleAlpha_IsValid;

	private static int BoneScaleAlpha_Offset;

	[BlueprintReadOnly]
	[UProperty]
	[Category("AttackIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:AttackIKAlpha")]
	public float AttackIKAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AttackIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:AttackIKAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttackIKAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackIKAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:AttackIKAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttackIKAlpha_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AttackIK")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:AttackIKRollList")]
	public TArrayReadWrite<float> AttackIKRollList
	{
		get
		{
			CheckDestroyed();
			if (!AttackIKRollList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:AttackIKRollList");
				return null;
			}
			if (AttackIKRollList_Marshaler == null)
			{
				AttackIKRollList_Marshaler = new TArrayReadWriteMarshaler<float>(1, AttackIKRollList_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return AttackIKRollList_Marshaler.FromNative(IntPtr.Add(base.Address, AttackIKRollList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AttackIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:AttackIKPitchList")]
	public TArrayReadWrite<float> AttackIKPitchList
	{
		get
		{
			CheckDestroyed();
			if (!AttackIKPitchList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:AttackIKPitchList");
				return null;
			}
			if (AttackIKPitchList_Marshaler == null)
			{
				AttackIKPitchList_Marshaler = new TArrayReadWriteMarshaler<float>(1, AttackIKPitchList_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return AttackIKPitchList_Marshaler.FromNative(IntPtr.Add(base.Address, AttackIKPitchList_Offset));
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AttackIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:SolverRootBoneNameList")]
	public TArrayReadWrite<FName> SolverRootBoneNameList
	{
		get
		{
			CheckDestroyed();
			if (!SolverRootBoneNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:SolverRootBoneNameList");
				return null;
			}
			if (SolverRootBoneNameList_Marshaler == null)
			{
				SolverRootBoneNameList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SolverRootBoneNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SolverRootBoneNameList_Marshaler.FromNative(IntPtr.Add(base.Address, SolverRootBoneNameList_Offset));
		}
	}

	[BlueprintReadOnly]
	[Category("AttackIK")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:SolverEffectorBoneNameList")]
	public TArrayReadWrite<FName> SolverEffectorBoneNameList
	{
		get
		{
			CheckDestroyed();
			if (!SolverEffectorBoneNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:SolverEffectorBoneNameList");
				return null;
			}
			if (SolverEffectorBoneNameList_Marshaler == null)
			{
				SolverEffectorBoneNameList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SolverEffectorBoneNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SolverEffectorBoneNameList_Marshaler.FromNative(IntPtr.Add(base.Address, SolverEffectorBoneNameList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AttackIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BoneScaleEnable")]
	public bool BoneScaleEnable
	{
		get
		{
			CheckDestroyed();
			if (!BoneScaleEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BoneScaleEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BoneScaleEnable_Offset), 0, BoneScaleEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BoneScaleEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BoneScaleEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BoneScaleEnable_Offset), 0, BoneScaleEnable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("AttackIK")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BoneScaleName")]
	public FName BoneScaleName
	{
		get
		{
			CheckDestroyed();
			if (!BoneScaleName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BoneScaleName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BoneScaleName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoneScaleName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BoneScaleName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BoneScaleName_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AttackIK")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BonePosition")]
	public FVector BonePosition
	{
		get
		{
			CheckDestroyed();
			if (!BonePosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BonePosition");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, BonePosition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BonePosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BonePosition");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, BonePosition_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AttackIK")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BoneScaleAlpha")]
	public float BoneScaleAlpha
	{
		get
		{
			CheckDestroyed();
			if (!BoneScaleAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BoneScaleAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BoneScaleAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoneScaleAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK:BoneScaleAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BoneScaleAlpha_Offset), value);
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
			AttackIKData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAttackIKData, BUC_ABPAttackIKData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		SyncAttackIKData();
	}

	private void UpdateData()
	{
		SyncAttackIKData();
	}

	private void SyncAttackIKData()
	{
		if (AttackIKData == null)
		{
			return;
		}
		AttackIKRollList.Clear();
		AttackIKPitchList.Clear();
		SolverRootBoneNameList.Clear();
		SolverEffectorBoneNameList.Clear();
		AttackIKAlpha = AttackIKData.AttackIKAlpha;
		if (AttackIKData.EnableAttackIK)
		{
			if (AttackIKData.AttackIKBonePairList != null)
			{
				for (int i = 0; i < AttackIKData.AttackIKBonePairList.Count; i++)
				{
					SolverRootBoneNameList.Add(AttackIKData.AttackIKBonePairList[i].AttackIKRootBoneName);
					SolverEffectorBoneNameList.Add(AttackIKData.AttackIKBonePairList[i].AttackIKLimbBoneName);
				}
			}
			if (AttackIKData.AttackIKPitchList != null)
			{
				for (int j = 0; j < AttackIKData.AttackIKPitchList.Count; j++)
				{
					AttackIKRollList.Add(AttackIKData.AttackIKRollList[j]);
					AttackIKPitchList.Add(AttackIKData.AttackIKPitchList[j]);
				}
			}
		}
		if (AttackIKData.BoneScaleEnable)
		{
			BoneScaleEnable = AttackIKData.BoneScaleEnable;
			BoneScaleName = AttackIKData.BoneScaleData.TargetBoneScaleName;
			BonePosition = AttackIKData.BonePosition;
			BoneScaleAlpha = AttackIKData.BoneScaleAlpha;
		}
		else
		{
			BoneScaleEnable = false;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_AttackIK");
		AttackIKAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttackIKAlpha");
		AttackIKAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttackIKAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AttackIKRollList_PropertyAddress, unrealStruct, "AttackIKRollList");
		AttackIKRollList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttackIKRollList");
		AttackIKRollList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttackIKRollList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AttackIKPitchList_PropertyAddress, unrealStruct, "AttackIKPitchList");
		AttackIKPitchList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttackIKPitchList");
		AttackIKPitchList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttackIKPitchList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SolverRootBoneNameList_PropertyAddress, unrealStruct, "SolverRootBoneNameList");
		SolverRootBoneNameList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SolverRootBoneNameList");
		SolverRootBoneNameList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SolverRootBoneNameList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SolverEffectorBoneNameList_PropertyAddress, unrealStruct, "SolverEffectorBoneNameList");
		SolverEffectorBoneNameList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SolverEffectorBoneNameList");
		SolverEffectorBoneNameList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SolverEffectorBoneNameList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BoneScaleEnable_PropertyAddress, unrealStruct, "BoneScaleEnable");
		BoneScaleEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneScaleEnable");
		BoneScaleEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneScaleEnable", Classes.FBoolProperty);
		BoneScaleName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneScaleName");
		BoneScaleName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneScaleName", Classes.FNameProperty);
		BonePosition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BonePosition");
		BonePosition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BonePosition", Classes.FStructProperty);
		BoneScaleAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneScaleAlpha");
		BoneScaleAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneScaleAlpha", Classes.FFloatProperty);
	}

	static BUAnimHumanoidCS_AttackIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_AttackIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_AttackIK));
	}
}
