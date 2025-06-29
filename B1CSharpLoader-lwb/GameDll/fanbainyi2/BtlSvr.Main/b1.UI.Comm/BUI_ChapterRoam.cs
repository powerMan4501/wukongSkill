using System;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ChapterRoam")]
public class BUI_ChapterRoam : BUI_Widget
{
	private BGW_ChapterViewMgr ChapterViewMgr;

	private BGW_ChapterViewMgrV2 ChapterViewMgrV2;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ChapterViewMgr = BGW_ChapterViewMgr.Get(this);
		ChapterViewMgrV2 = BGW_ChapterViewMgrV2.Get(this);
		GSBindProp<bool> isCanCameraRoam = ChapterViewMgr.IsCanCameraRoam;
		isCanCameraRoam.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isCanCameraRoam.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnIsCanCameraRoamChange));
		BGW_EnhancedInputMgrV2 bGW_EnhancedInputMgrV = BGW_EnhancedInputMgrV2.Get(this);
		if (bGW_EnhancedInputMgrV != null)
		{
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.CameraRoam, this, OnCameraRoamGamepad);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.CameraRoam, this, OnCameraRoamGamepadCompleted, ETriggerEvent.Completed);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.RoamScale, this, OnCameraRoamScale);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.RoamScaleUp, this, OnCameraRoamScaleUp);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.RoamScaleDown, this, OnCameraRoamScaleDown);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.MousePress, this, OnMousePress);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.MouseRelease, this, OnMouseRelease);
		}
	}

	private void OnIsCanCameraRoamChange(EChangeReason ChangeRaon, bool OldValue, bool NewValue)
	{
		BlockAllInputAction(!NewValue);
	}

	private bool OnCameraRoamGamepadCompleted(FInputActionValue Value)
	{
		if (DebugConfig.EnableChapterRoamV2)
		{
			ChapterViewMgrV2.OnCameraRoamGamepad(Value.GetAxis2D());
		}
		else
		{
			ChapterViewMgr.OnCameraRoamGamepad(Value.GetAxis2D());
		}
		return true;
	}

	private bool OnCameraRoamGamepad(FInputActionValue Value)
	{
		if (DebugConfig.EnableChapterRoamV2)
		{
			ChapterViewMgrV2.OnCameraRoamGamepad(Value.GetAxis2D());
		}
		else
		{
			ChapterViewMgr.OnCameraRoamGamepad(Value.GetAxis2D());
		}
		return true;
	}

	private bool OnCameraRoamScale(FInputActionValue Value)
	{
		if (DebugConfig.EnableChapterRoamV2)
		{
			ChapterViewMgrV2.OnCameraRoamScale(Value.GetAxis1D());
		}
		else
		{
			ChapterViewMgr.OnCameraRoamScale(Value.GetAxis1D());
		}
		return true;
	}

	private bool OnCameraRoamScaleUp(FInputActionValue Value)
	{
		if (DebugConfig.EnableChapterRoamV2)
		{
			ChapterViewMgrV2.OnCameraRoamScale(Value.GetAxis1D());
		}
		else
		{
			ChapterViewMgr.OnCameraRoamScale(Value.GetAxis1D());
		}
		return true;
	}

	private bool OnCameraRoamScaleDown(FInputActionValue Value)
	{
		if (DebugConfig.EnableChapterRoamV2)
		{
			ChapterViewMgrV2.OnCameraRoamScale(0f - Value.GetAxis1D());
		}
		else
		{
			ChapterViewMgr.OnCameraRoamScale(0f - Value.GetAxis1D());
		}
		return true;
	}

	private bool OnMousePress(FInputActionValue Value)
	{
		if (DebugConfig.EnableChapterRoamV2)
		{
			ChapterViewMgrV2.OnMouseDown();
		}
		else
		{
			ChapterViewMgr.OnMouseDown();
		}
		return true;
	}

	private bool OnMouseRelease(FInputActionValue Value)
	{
		if (DebugConfig.EnableChapterRoamV2)
		{
			ChapterViewMgrV2.OnMouseUp();
		}
		else
		{
			ChapterViewMgr.OnMouseUp();
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_ChapterRoam");
	}

	static BUI_ChapterRoam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ChapterRoam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ChapterRoam));
	}
}
