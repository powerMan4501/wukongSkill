using System;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnimInsect")]
internal class BUAnimInsect : BUAnimInstanceBase
{
	private static bool FinalABPMoveMode_IsValid;

	private static int FinalABPMoveMode_Offset;

	private static FFieldAddress FinalABPMoveMode_PropertyAddress;

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimInsect:FinalABPMoveMode")]
	public EABPMoveMode FinalABPMoveMode
	{
		get
		{
			CheckDestroyed();
			if (!FinalABPMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimInsect:FinalABPMoveMode");
				return EABPMoveMode.None;
			}
			return EnumMarshaler<EABPMoveMode>.FromNative(IntPtr.Add(base.Address, FinalABPMoveMode_Offset), 0, FinalABPMoveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FinalABPMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimInsect:FinalABPMoveMode");
			}
			else
			{
				EnumMarshaler<EABPMoveMode>.ToNative(IntPtr.Add(base.Address, FinalABPMoveMode_Offset), 0, FinalABPMoveMode_PropertyAddress.Address, value);
			}
		}
	}

	protected override void BlueprintInitializeAnimationImpl()
	{
		base.SkipBlueprintUpdateAnimation = 1;
	}

	protected override void OnInitABPSetting()
	{
		if (base.ABPSettingData != null)
		{
			InitData();
		}
	}

	protected override void AttachEvent()
	{
		base.AttachEvent();
		BUAnimHumanoidCS_FlyControl bUAnimHumanoidCS_FlyControl = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.FlyControl) as BUAnimHumanoidCS_FlyControl;
		if (bUAnimHumanoidCS_FlyControl != null)
		{
			bUAnimHumanoidCS_FlyControl.AttachEvent();
		}
	}

	protected override void UnAttachEvent()
	{
		base.UnAttachEvent();
		BUAnimHumanoidCS_FlyControl bUAnimHumanoidCS_FlyControl = GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.FlyControl) as BUAnimHumanoidCS_FlyControl;
		if (bUAnimHumanoidCS_FlyControl != null)
		{
			bUAnimHumanoidCS_FlyControl.UnAttachEvent();
		}
	}

	public void InitData()
	{
		IBUC_ABPCommonSettingData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPCommonSettingData>(GetOwningActor());
		if (unPersistentReadOnlyData != null)
		{
			FinalABPMoveMode = unPersistentReadOnlyData.FinalABPMoveMode;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimInsect");
		NativeReflection.GetPropertyRef(ref FinalABPMoveMode_PropertyAddress, unrealStruct, "FinalABPMoveMode");
		FinalABPMoveMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FinalABPMoveMode");
		FinalABPMoveMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FinalABPMoveMode", Classes.FEnumProperty);
	}

	static BUAnimInsect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGU.BUAnim.BUAnimInsect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGU.BUAnim.BUAnimInsect));
	}
}
