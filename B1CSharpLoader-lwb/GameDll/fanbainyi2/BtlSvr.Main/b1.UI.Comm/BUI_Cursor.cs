using System;
using b1.Plugins.GSInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_Cursor")]
public class BUI_Cursor : BUI_CursorBase
{
	protected UWidget ScrollContent;

	protected GSScrollUtil ScrollUtil;

	protected float ScrollOffset;

	private static bool ScrollInputParams_IsValid;

	private static int ScrollInputParams_Offset;

	private static bool ScrollParams_IsValid;

	private static int ScrollParams_Offset;

	private static bool NeedUpdateParams_IsValid;

	private static int NeedUpdateParams_Offset;

	private static FFieldAddress NeedUpdateParams_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|Scroll")]
	[Tooltip("滚动输入参数")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Cursor:ScrollInputParams")]
	public ScrollInputData ScrollInputParams
	{
		get
		{
			CheckDestroyed();
			if (!ScrollInputParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Cursor:ScrollInputParams");
				return default(ScrollInputData);
			}
			return BlittableTypeMarshaler<ScrollInputData>.FromNative(IntPtr.Add(base.Address, ScrollInputParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollInputParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Cursor:ScrollInputParams");
			}
			else
			{
				BlittableTypeMarshaler<ScrollInputData>.ToNative(IntPtr.Add(base.Address, ScrollInputParams_Offset), value);
			}
		}
	}

	[Category("GSProperty|Scroll")]
	[Tooltip("滚动参数")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_Cursor:ScrollParams")]
	public ScrollData ScrollParams
	{
		get
		{
			CheckDestroyed();
			if (!ScrollParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Cursor:ScrollParams");
				return default(ScrollData);
			}
			return ScrollData.FromNative(IntPtr.Add(base.Address, ScrollParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Cursor:ScrollParams");
			}
			else
			{
				ScrollData.ToNative(IntPtr.Add(base.Address, ScrollParams_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("GSProperty|Scroll")]
	[Tooltip("是否刷新参数")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_Cursor:NeedUpdateParams")]
	public bool NeedUpdateParams
	{
		get
		{
			CheckDestroyed();
			if (!NeedUpdateParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Cursor:NeedUpdateParams");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedUpdateParams_Offset), 0, NeedUpdateParams_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedUpdateParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Cursor:NeedUpdateParams");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedUpdateParams_Offset), 0, NeedUpdateParams_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ScrollContent = FindChildWidget("ScrollContent");
		InitScroll();
		BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSUIActionEn.Scroll, this, OnScorllTrigger);
	}

	private void InitScroll()
	{
		ScrollUtil = new GSScrollUtil();
		ScrollUtil.InitParam(ScrollInputParams, ScrollParams);
	}

	protected virtual bool OnScorllTrigger(FInputActionValue Value)
	{
		float inInputValue = ((BGW_EnhancedInputMgrV2.GetCurrentInputType() != EGSInputType.Gamepad) ? Value.GetAxis1D() : Value.GetAxis2D().X);
		float inInputTick = 0f;
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse)
		{
			inInputTick = ScrollInputParams.KeyboardInputTime;
		}
		else if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad)
		{
			inInputTick = ScrollInputParams.GamepadInputTime;
		}
		ScrollUtil.SetInput(inInputTick, inInputValue);
		return false;
	}

	public float GetScrollOffset()
	{
		return ScrollOffset;
	}

	public void SetScrollOffset(float TargetScrollOffset)
	{
		float scrollOffset = FMath.Clamp(TargetScrollOffset, 0f, GetScrollOffsetOfEnd());
		ScrollOffset = scrollOffset;
	}

	protected float GetScrollOffsetOfEnd()
	{
		FVector2D desiredSize = ScrollContent.GetDesiredSize();
		FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(this);
		return desiredSize.X - widgetLocalSize.X;
	}

	protected float GetContentSize()
	{
		return UGSE_UMGFuncLib.GetWidgetLocalSize(ScrollContent).X;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		if (!IsInit)
		{
			IsInit = true;
		}
		else if (NeedInput)
		{
			float num = ((InDeltaTime < 0.02f) ? InDeltaTime : 0.02f);
			ScrollUtil.UpdateInput(num);
			UpdateScroll(num);
			UpdateToWidget(InDeltaTime);
			UpdateCursor(InDeltaTime);
			CheckFocusWidget(InDeltaTime);
		}
	}

	protected virtual void UpdateScroll(float InDeltaTime)
	{
		float scrollOffset = ScrollOffset;
		if (FMath.IsNearlyEqual(ScrollOffset = FMath.Clamp(ScrollUtil.UpdateScroll(ScrollOffset, InDeltaTime), 0f, GetScrollOffsetOfEnd()), scrollOffset, 0.01f))
		{
			ScrollUtil.SetSpeed(0f);
		}
		ScrollContent.SetRenderTranslation(new FVector2D(0f - ScrollOffset, 0.0));
	}

	protected void UpdateParams()
	{
		if (NeedUpdateParams)
		{
			InitScroll();
			NeedUpdateParams = false;
		}
	}

	public void ScrollToWidget(UWidget Widget)
	{
		if (!(CurTargetWidget == Widget))
		{
			ToWidget = Widget;
			StartToWidget = true;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_Cursor");
		ScrollInputParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScrollInputParams");
		ScrollInputParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScrollInputParams", Classes.FStructProperty);
		ScrollParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScrollParams");
		ScrollParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScrollParams", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref NeedUpdateParams_PropertyAddress, unrealStruct, "NeedUpdateParams");
		NeedUpdateParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedUpdateParams");
		NeedUpdateParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedUpdateParams", Classes.FBoolProperty);
	}

	static BUI_Cursor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_Cursor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_Cursor));
	}
}
