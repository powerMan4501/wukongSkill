using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[Abstract]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl")]
public class BUAnimHumanoidCS_FlyControl : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPFlyControlData FlyControlData;

	private IBUC_ABPCommonSettingData CommonData;

	private static bool bUseComplexFlyControl_IsValid;

	private static int bUseComplexFlyControl_Offset;

	private static FFieldAddress bUseComplexFlyControl_PropertyAddress;

	private static bool BSFly_IsValid;

	private static int BSFly_Offset;

	private static bool BSFlyX_IsValid;

	private static int BSFlyX_Offset;

	private static bool BSFlyY_IsValid;

	private static int BSFlyY_Offset;

	private static bool ASFlyUpward_IsValid;

	private static int ASFlyUpward_Offset;

	private static bool ASFlyDownward_IsValid;

	private static int ASFlyDownward_Offset;

	private static bool ASFlyUpToDown_IsValid;

	private static int ASFlyUpToDown_Offset;

	private static bool ASFlyDownToUp_IsValid;

	private static int ASFlyDownToUp_Offset;

	private static bool BSFlyLean_IsValid;

	private static int BSFlyLean_Offset;

	private static bool BSFlyLeanX_IsValid;

	private static int BSFlyLeanX_Offset;

	private static bool BSFlyLeanY_IsValid;

	private static int BSFlyLeanY_Offset;

	private static bool bFlyUpToDown_IsValid;

	private static int bFlyUpToDown_Offset;

	private static FFieldAddress bFlyUpToDown_PropertyAddress;

	private static bool bFlyDownToUp_IsValid;

	private static int bFlyDownToUp_Offset;

	private static FFieldAddress bFlyDownToUp_PropertyAddress;

	[UProperty]
	[BlueprintReadOnly]
	[Category("FlyControl")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:bUseComplexFlyControl")]
	public bool bUseComplexFlyControl
	{
		get
		{
			CheckDestroyed();
			if (!bUseComplexFlyControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:bUseComplexFlyControl");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseComplexFlyControl_Offset), 0, bUseComplexFlyControl_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseComplexFlyControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:bUseComplexFlyControl");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseComplexFlyControl_Offset), 0, bUseComplexFlyControl_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("SimpleFlyControl")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFly")]
	public UBlendSpace BSFly
	{
		get
		{
			CheckDestroyed();
			if (!BSFly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFly");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSFly_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFly");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSFly_Offset), value);
			}
		}
	}

	[Category("SimpleFlyControl")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyX")]
	public float BSFlyX
	{
		get
		{
			CheckDestroyed();
			if (!BSFlyX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSFlyX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFlyX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSFlyX_Offset), value);
			}
		}
	}

	[Category("SimpleFlyControl")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyY")]
	public float BSFlyY
	{
		get
		{
			CheckDestroyed();
			if (!BSFlyY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSFlyY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFlyY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSFlyY_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("ComplexFlyControl")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyUpward")]
	public UAnimSequence ASFlyUpward
	{
		get
		{
			CheckDestroyed();
			if (!ASFlyUpward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyUpward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFlyUpward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFlyUpward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyUpward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFlyUpward_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("ComplexFlyControl")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyDownward")]
	public UAnimSequence ASFlyDownward
	{
		get
		{
			CheckDestroyed();
			if (!ASFlyDownward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyDownward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFlyDownward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFlyDownward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyDownward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFlyDownward_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("ComplexFlyControl")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyUpToDown")]
	public UAnimSequence ASFlyUpToDown
	{
		get
		{
			CheckDestroyed();
			if (!ASFlyUpToDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyUpToDown");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFlyUpToDown_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFlyUpToDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyUpToDown");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFlyUpToDown_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("ComplexFlyControl")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyDownToUp")]
	public UAnimSequence ASFlyDownToUp
	{
		get
		{
			CheckDestroyed();
			if (!ASFlyDownToUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyDownToUp");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFlyDownToUp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFlyDownToUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:ASFlyDownToUp");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFlyDownToUp_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("ComplexFlyControl")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyLean")]
	public UBlendSpace BSFlyLean
	{
		get
		{
			CheckDestroyed();
			if (!BSFlyLean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyLean");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSFlyLean_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFlyLean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyLean");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSFlyLean_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("ComplexFlyControl")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyLeanX")]
	public float BSFlyLeanX
	{
		get
		{
			CheckDestroyed();
			if (!BSFlyLeanX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyLeanX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSFlyLeanX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFlyLeanX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyLeanX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSFlyLeanX_Offset), value);
			}
		}
	}

	[Category("ComplexFlyControl")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyLeanY")]
	public float BSFlyLeanY
	{
		get
		{
			CheckDestroyed();
			if (!BSFlyLeanY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyLeanY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSFlyLeanY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFlyLeanY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:BSFlyLeanY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSFlyLeanY_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:bFlyUpToDown")]
	public bool bFlyUpToDown
	{
		get
		{
			CheckDestroyed();
			if (!bFlyUpToDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:bFlyUpToDown");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFlyUpToDown_Offset), 0, bFlyUpToDown_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFlyUpToDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:bFlyUpToDown");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFlyUpToDown_Offset), 0, bFlyUpToDown_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:bFlyDownToUp")]
	public bool bFlyDownToUp
	{
		get
		{
			CheckDestroyed();
			if (!bFlyDownToUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:bFlyDownToUp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFlyDownToUp_Offset), 0, bFlyDownToUp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFlyDownToUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl:bFlyDownToUp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFlyDownToUp_Offset), 0, bFlyDownToUp_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnInitABPSetting()
	{
		if (this.IsNullOrDestroyed())
		{
			return;
		}
		BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
		if (aBPSettingData != null)
		{
			BUABPCommonSettingData commonSetting = aBPSettingData.CommonSetting;
			if (commonSetting.ABPMoveMode == EABPMoveMode.SimpleFlyControl || commonSetting.ABPMoveMode == EABPMoveMode.ComplexFlyControl)
			{
				BUABPFlyControlSettingData flyControlSetting = aBPSettingData.FlyControlSetting;
				BSFly = flyControlSetting.BSFly;
				ASFlyUpward = flyControlSetting.ASFlyUpward;
				ASFlyDownward = flyControlSetting.ASFlyDownward;
				ASFlyUpToDown = flyControlSetting.ASFlyUpToDown;
				ASFlyDownToUp = flyControlSetting.ASFlyDownToUp;
				BSFlyLean = flyControlSetting.BSFlyLean;
				InitData();
			}
		}
	}

	protected override void LinkedGraphInitializeAnimation()
	{
		if (TopAnimInst != null && TopAnimInst.ABPSettingData != null)
		{
			BSFly = TopAnimInst.ABPSettingData.FlyControlSetting.BSFly;
		}
	}

	protected override void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
		UpdateData(DeltaTimeX);
	}

	private void InitBUCData()
	{
		if (!(Owner == null) && ECSExtension.IsECSActor(Owner))
		{
			FlyControlData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPFlyControlData, BUC_ABPFlyControlData>(Owner);
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
	}

	private void UpdateData(float DeltaTime)
	{
		if (CommonData != null && (CommonData.FinalABPMoveMode == EABPMoveMode.SimpleFlyControl || CommonData.FinalABPMoveMode == EABPMoveMode.ComplexFlyControl))
		{
			if (CommonData != null)
			{
				bUseComplexFlyControl = CommonData.FinalABPMoveMode == EABPMoveMode.ComplexFlyControl;
			}
			if (FlyControlData != null)
			{
				BSFlyX = FlyControlData.BSFlyX;
				BSFlyY = FlyControlData.BSFlyY;
				BSFlyLeanX = FlyControlData.BSFlyLeanX;
				BSFlyLeanY = FlyControlData.BSFlyLeanY;
				bFlyUpToDown = !FlyControlData.bFlyUpward;
				bFlyDownToUp = FlyControlData.bFlyUpward;
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_FlyControl");
		NativeReflection.GetPropertyRef(ref bUseComplexFlyControl_PropertyAddress, unrealStruct, "bUseComplexFlyControl");
		bUseComplexFlyControl_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseComplexFlyControl");
		bUseComplexFlyControl_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseComplexFlyControl", Classes.FBoolProperty);
		BSFly_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFly");
		BSFly_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFly", Classes.FObjectProperty);
		BSFlyX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFlyX");
		BSFlyX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFlyX", Classes.FFloatProperty);
		BSFlyY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFlyY");
		BSFlyY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFlyY", Classes.FFloatProperty);
		ASFlyUpward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFlyUpward");
		ASFlyUpward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFlyUpward", Classes.FObjectProperty);
		ASFlyDownward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFlyDownward");
		ASFlyDownward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFlyDownward", Classes.FObjectProperty);
		ASFlyUpToDown_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFlyUpToDown");
		ASFlyUpToDown_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFlyUpToDown", Classes.FObjectProperty);
		ASFlyDownToUp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASFlyDownToUp");
		ASFlyDownToUp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASFlyDownToUp", Classes.FObjectProperty);
		BSFlyLean_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFlyLean");
		BSFlyLean_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFlyLean", Classes.FObjectProperty);
		BSFlyLeanX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFlyLeanX");
		BSFlyLeanX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFlyLeanX", Classes.FFloatProperty);
		BSFlyLeanY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSFlyLeanY");
		BSFlyLeanY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSFlyLeanY", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bFlyUpToDown_PropertyAddress, unrealStruct, "bFlyUpToDown");
		bFlyUpToDown_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFlyUpToDown");
		bFlyUpToDown_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFlyUpToDown", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFlyDownToUp_PropertyAddress, unrealStruct, "bFlyDownToUp");
		bFlyDownToUp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bFlyDownToUp");
		bFlyDownToUp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bFlyDownToUp", Classes.FBoolProperty);
	}

	static BUAnimHumanoidCS_FlyControl()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_FlyControl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_FlyControl));
	}
}
