using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[Blueprintable]
[Abstract]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move")]
public class BUAnimHumanoidCS_Move : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPBasicData BasicData;

	private IBUC_ABPCharacterData ChrData;

	private static bool FinalABPMoveMode_IsValid;

	private static int FinalABPMoveMode_Offset;

	private static FFieldAddress FinalABPMoveMode_PropertyAddress;

	private static bool AnimTurnInPlaceLeft_IsValid;

	private static int AnimTurnInPlaceLeft_Offset;

	private static bool AnimTurnInPlaceRight_IsValid;

	private static int AnimTurnInPlaceRight_Offset;

	private static bool AnimTurnInPlaceLeft180_IsValid;

	private static int AnimTurnInPlaceLeft180_Offset;

	private static bool AnimTurnInPlaceRight180_IsValid;

	private static int AnimTurnInPlaceRight180_Offset;

	private static bool IsStandRotateStart_IsValid;

	private static int IsStandRotateStart_Offset;

	private static FFieldAddress IsStandRotateStart_PropertyAddress;

	private static bool IsMoveAccelerating_IsValid;

	private static int IsMoveAccelerating_Offset;

	private static FFieldAddress IsMoveAccelerating_PropertyAddress;

	private static bool StandRotateType_IsValid;

	private static int StandRotateType_Offset;

	private static FFieldAddress StandRotateType_PropertyAddress;

	private static bool RotateAngle_IsValid;

	private static int RotateAngle_Offset;

	private static bool bCanMMRetarget_IsValid;

	private static int bCanMMRetarget_Offset;

	private static FFieldAddress bCanMMRetarget_PropertyAddress;

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:FinalABPMoveMode")]
	public EABPMoveMode FinalABPMoveMode
	{
		get
		{
			CheckDestroyed();
			if (!FinalABPMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:FinalABPMoveMode");
				return EABPMoveMode.None;
			}
			return EnumMarshaler<EABPMoveMode>.FromNative(IntPtr.Add(base.Address, FinalABPMoveMode_Offset), 0, FinalABPMoveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FinalABPMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:FinalABPMoveMode");
			}
			else
			{
				EnumMarshaler<EABPMoveMode>.ToNative(IntPtr.Add(base.Address, FinalABPMoveMode_Offset), 0, FinalABPMoveMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("StandRotate")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceLeft")]
	public UAnimSequence AnimTurnInPlaceLeft
	{
		get
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceLeft");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimTurnInPlaceLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceLeft");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimTurnInPlaceLeft_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("StandRotate")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceRight")]
	public UAnimSequence AnimTurnInPlaceRight
	{
		get
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceRight");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimTurnInPlaceRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceRight");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimTurnInPlaceRight_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("StandRotate")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceLeft180")]
	public UAnimSequence AnimTurnInPlaceLeft180
	{
		get
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceLeft180_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceLeft180");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimTurnInPlaceLeft180_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceLeft180_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceLeft180");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimTurnInPlaceLeft180_Offset), value);
			}
		}
	}

	[Category("StandRotate")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceRight180")]
	public UAnimSequence AnimTurnInPlaceRight180
	{
		get
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceRight180_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceRight180");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimTurnInPlaceRight180_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimTurnInPlaceRight180_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:AnimTurnInPlaceRight180");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimTurnInPlaceRight180_Offset), value);
			}
		}
	}

	[Category("StandRotate")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:IsStandRotateStart")]
	public bool IsStandRotateStart
	{
		get
		{
			CheckDestroyed();
			if (!IsStandRotateStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:IsStandRotateStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsStandRotateStart_Offset), 0, IsStandRotateStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsStandRotateStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:IsStandRotateStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsStandRotateStart_Offset), 0, IsStandRotateStart_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("StandRotate")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:IsMoveAccelerating")]
	public bool IsMoveAccelerating
	{
		get
		{
			CheckDestroyed();
			if (!IsMoveAccelerating_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:IsMoveAccelerating");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsMoveAccelerating_Offset), 0, IsMoveAccelerating_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsMoveAccelerating_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:IsMoveAccelerating");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsMoveAccelerating_Offset), 0, IsMoveAccelerating_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("StandRotate")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:StandRotateType")]
	public EStandRotateType StandRotateType
	{
		get
		{
			CheckDestroyed();
			if (!StandRotateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:StandRotateType");
				return EStandRotateType.Left90;
			}
			return EnumMarshaler<EStandRotateType>.FromNative(IntPtr.Add(base.Address, StandRotateType_Offset), 0, StandRotateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StandRotateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:StandRotateType");
			}
			else
			{
				EnumMarshaler<EStandRotateType>.ToNative(IntPtr.Add(base.Address, StandRotateType_Offset), 0, StandRotateType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("StandRotate")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:RotateAngle")]
	public float RotateAngle
	{
		get
		{
			CheckDestroyed();
			if (!RotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:RotateAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotateAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:RotateAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotateAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("MMRetarget")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_Move:bCanMMRetarget")]
	public bool bCanMMRetarget
	{
		get
		{
			CheckDestroyed();
			if (!bCanMMRetarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:bCanMMRetarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanMMRetarget_Offset), 0, bCanMMRetarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanMMRetarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_Move:bCanMMRetarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanMMRetarget_Offset), 0, bCanMMRetarget_PropertyAddress.Address, value);
			}
		}
	}

	private bool bTurnAnimValid { get; set; }

	public override void AttachEvent()
	{
		base.AttachEvent();
		BUAnimHumanoidCS_MotionMatching bUAnimHumanoidCS_MotionMatching = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.MotionMatching) as BUAnimHumanoidCS_MotionMatching;
		if (bUAnimHumanoidCS_MotionMatching != null)
		{
			bUAnimHumanoidCS_MotionMatching.AttachEvent();
		}
		BUAnimHumanoidCS_Simple4Dir bUAnimHumanoidCS_Simple4Dir = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.Simple4Dir) as BUAnimHumanoidCS_Simple4Dir;
		if (bUAnimHumanoidCS_Simple4Dir != null)
		{
			bUAnimHumanoidCS_Simple4Dir.AttachEvent();
		}
		BUAnimHumanoidCS_FlyControl bUAnimHumanoidCS_FlyControl = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.FlyControl) as BUAnimHumanoidCS_FlyControl;
		if (bUAnimHumanoidCS_FlyControl != null)
		{
			bUAnimHumanoidCS_FlyControl.AttachEvent();
		}
		BUAnimHumanoidCS_PlayerLocomotion bUAnimHumanoidCS_PlayerLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.PlayerLocomotion) as BUAnimHumanoidCS_PlayerLocomotion;
		if (bUAnimHumanoidCS_PlayerLocomotion != null)
		{
			bUAnimHumanoidCS_PlayerLocomotion.AttachEvent();
		}
		BUAnimHumanoidCS_MonsterLocomotion bUAnimHumanoidCS_MonsterLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.MonsterLocomotion) as BUAnimHumanoidCS_MonsterLocomotion;
		if (bUAnimHumanoidCS_MonsterLocomotion != null)
		{
			bUAnimHumanoidCS_MonsterLocomotion.AttachEvent();
		}
		BUAnimHumanoidCS_MMRetarget bUAnimHumanoidCS_MMRetarget = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.MMRetarget) as BUAnimHumanoidCS_MMRetarget;
		if (bUAnimHumanoidCS_MMRetarget != null)
		{
			bUAnimHumanoidCS_MMRetarget.AttachEvent();
		}
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.AdvancedMonsterLocomotion) as BUAnimHumanoidCS_AdvancedMonsterLocomotion;
		if (bUAnimHumanoidCS_AdvancedMonsterLocomotion != null)
		{
			bUAnimHumanoidCS_AdvancedMonsterLocomotion.AttachEvent();
		}
		BUAnimHumanoidCS_CloudLocomotion bUAnimHumanoidCS_CloudLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.CloudLocomotion) as BUAnimHumanoidCS_CloudLocomotion;
		if (bUAnimHumanoidCS_CloudLocomotion != null)
		{
			bUAnimHumanoidCS_CloudLocomotion.AttachEvent();
		}
	}

	public override void UnAttachEvent()
	{
		base.UnAttachEvent();
		BUAnimHumanoidCS_MotionMatching bUAnimHumanoidCS_MotionMatching = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.MotionMatching) as BUAnimHumanoidCS_MotionMatching;
		if (bUAnimHumanoidCS_MotionMatching != null)
		{
			bUAnimHumanoidCS_MotionMatching.UnAttachEvent();
		}
		BUAnimHumanoidCS_Simple4Dir bUAnimHumanoidCS_Simple4Dir = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.Simple4Dir) as BUAnimHumanoidCS_Simple4Dir;
		if (bUAnimHumanoidCS_Simple4Dir != null)
		{
			bUAnimHumanoidCS_Simple4Dir.UnAttachEvent();
		}
		BUAnimHumanoidCS_FlyControl bUAnimHumanoidCS_FlyControl = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.FlyControl) as BUAnimHumanoidCS_FlyControl;
		if (bUAnimHumanoidCS_FlyControl != null)
		{
			bUAnimHumanoidCS_FlyControl.UnAttachEvent();
		}
		BUAnimHumanoidCS_PlayerLocomotion bUAnimHumanoidCS_PlayerLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.PlayerLocomotion) as BUAnimHumanoidCS_PlayerLocomotion;
		if (bUAnimHumanoidCS_PlayerLocomotion != null)
		{
			bUAnimHumanoidCS_PlayerLocomotion.UnAttachEvent();
		}
		BUAnimHumanoidCS_MonsterLocomotion bUAnimHumanoidCS_MonsterLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.MonsterLocomotion) as BUAnimHumanoidCS_MonsterLocomotion;
		if (bUAnimHumanoidCS_MonsterLocomotion != null)
		{
			bUAnimHumanoidCS_MonsterLocomotion.UnAttachEvent();
		}
		BUAnimHumanoidCS_MMRetarget bUAnimHumanoidCS_MMRetarget = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.MMRetarget) as BUAnimHumanoidCS_MMRetarget;
		if (bUAnimHumanoidCS_MMRetarget != null)
		{
			bUAnimHumanoidCS_MMRetarget.UnAttachEvent();
		}
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.AdvancedMonsterLocomotion) as BUAnimHumanoidCS_AdvancedMonsterLocomotion;
		if (bUAnimHumanoidCS_AdvancedMonsterLocomotion != null)
		{
			bUAnimHumanoidCS_AdvancedMonsterLocomotion.UnAttachEvent();
		}
		BUAnimHumanoidCS_CloudLocomotion bUAnimHumanoidCS_CloudLocomotion = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.CloudLocomotion) as BUAnimHumanoidCS_CloudLocomotion;
		if (bUAnimHumanoidCS_CloudLocomotion != null)
		{
			bUAnimHumanoidCS_CloudLocomotion.UnAttachEvent();
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
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
			BasicData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(Owner);
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		if (CommonData != null)
		{
			FinalABPMoveMode = CommonData.FinalABPMoveMode;
			AnimTurnInPlaceLeft = CommonData.AnimTurnInPlaceLeft;
			AnimTurnInPlaceRight = CommonData.AnimTurnInPlaceRight;
			AnimTurnInPlaceLeft180 = CommonData.AnimTurnInPlaceLeft180;
			AnimTurnInPlaceRight180 = CommonData.AnimTurnInPlaceRight180;
			bTurnAnimValid = CommonData.bTurnAnimValid;
		}
		bCanMMRetarget = false;
	}

	private void UpdateData()
	{
		if (CommonData != null)
		{
			FinalABPMoveMode = CommonData.FinalABPMoveMode;
		}
		if (BasicData != null)
		{
			StandRotateType = BasicData.StandRotateType;
			RotateAngle = BasicData.StandRotateAngle;
			IsStandRotateStart = BasicData.IsStandRotateStart && bTurnAnimValid && FMath.Abs(RotateAngle) > CommonData.AnimTurnMinAngle;
		}
		if (ChrData != null)
		{
			IsMoveAccelerating = ChrData.MoveAcceleration.Size() > 1E-08f;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_Move");
		NativeReflection.GetPropertyRef(ref FinalABPMoveMode_PropertyAddress, unrealStruct, "FinalABPMoveMode");
		FinalABPMoveMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FinalABPMoveMode");
		FinalABPMoveMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FinalABPMoveMode", Classes.FEnumProperty);
		AnimTurnInPlaceLeft_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimTurnInPlaceLeft");
		AnimTurnInPlaceLeft_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimTurnInPlaceLeft", Classes.FObjectProperty);
		AnimTurnInPlaceRight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimTurnInPlaceRight");
		AnimTurnInPlaceRight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimTurnInPlaceRight", Classes.FObjectProperty);
		AnimTurnInPlaceLeft180_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimTurnInPlaceLeft180");
		AnimTurnInPlaceLeft180_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimTurnInPlaceLeft180", Classes.FObjectProperty);
		AnimTurnInPlaceRight180_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimTurnInPlaceRight180");
		AnimTurnInPlaceRight180_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimTurnInPlaceRight180", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsStandRotateStart_PropertyAddress, unrealStruct, "IsStandRotateStart");
		IsStandRotateStart_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsStandRotateStart");
		IsStandRotateStart_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsStandRotateStart", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsMoveAccelerating_PropertyAddress, unrealStruct, "IsMoveAccelerating");
		IsMoveAccelerating_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsMoveAccelerating");
		IsMoveAccelerating_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsMoveAccelerating", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref StandRotateType_PropertyAddress, unrealStruct, "StandRotateType");
		StandRotateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StandRotateType");
		StandRotateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StandRotateType", Classes.FEnumProperty);
		RotateAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RotateAngle");
		RotateAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RotateAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bCanMMRetarget_PropertyAddress, unrealStruct, "bCanMMRetarget");
		bCanMMRetarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCanMMRetarget");
		bCanMMRetarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCanMMRetarget", Classes.FBoolProperty);
	}

	static BUAnimHumanoidCS_Move()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_Move)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_Move));
	}
}
