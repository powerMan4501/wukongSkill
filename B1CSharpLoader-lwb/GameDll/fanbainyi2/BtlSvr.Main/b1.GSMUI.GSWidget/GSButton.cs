using System;
using b1.Plugins.AkAudio;
using b1.UI.Comm;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.GSMUI.GSWidget;

[UClass]
[USharpPath("/Script/b1-Managed.GSButton")]
public class GSButton : UButton, IGSMUITickable
{
	private static int GID;

	private int GSID;

	protected bool IsNeedTickUpdate;

	protected float PressedLiveTime;

	protected float PressedTotalTime;

	protected GSMUITickMgr GSTickMgr;

	private float OneTime = 0.2f;

	private float SpeedUpTime = 2f;

	private int SpeedUpMaxCount = 20;

	private float Speed;

	private float ChangeTime;

	private static bool PressedMask_IsValid;

	private static int PressedMask_Offset;

	private static bool HoveredWidget_IsValid;

	private static int HoveredWidget_Offset;

	private static bool FocusedWidget_IsValid;

	private static int FocusedWidget_Offset;

	private static bool RootCon_IsValid;

	private static int RootCon_Offset;

	private static bool DurationTime_IsValid;

	private static int DurationTime_Offset;

	private static bool PressedScale_IsValid;

	private static int PressedScale_Offset;

	private static bool ClickAudioEvent_IsValid;

	private static int ClickAudioEvent_Offset;

	private static bool FocusAudioEvent_IsValid;

	private static int FocusAudioEvent_Offset;

	private static bool HoveredAudioEvent_IsValid;

	private static int HoveredAudioEvent_Offset;

	private static bool GSOnPressed_IsValid;

	private static IntPtr GSOnPressed_FunctionAddress;

	private static int GSOnPressed_ParamsSize;

	private static bool GSOnClicked_IsValid;

	private static IntPtr GSOnClicked_FunctionAddress;

	private static int GSOnClicked_ParamsSize;

	private static bool GSOnHovered_IsValid;

	private static IntPtr GSOnHovered_FunctionAddress;

	private static int GSOnHovered_ParamsSize;

	private static bool GSOnFocused_IsValid;

	private static IntPtr GSOnFocused_FunctionAddress;

	private static int GSOnFocused_ParamsSize;

	private static bool GSOnFocused_FocusEvent_IsValid;

	private static int GSOnFocused_FocusEvent_Offset;

	private static FFieldAddress GSOnFocused_FocusEvent_PropertyAddress;

	private static bool GSOnReleased_IsValid;

	private static IntPtr GSOnReleased_FunctionAddress;

	private static int GSOnReleased_ParamsSize;

	private static bool GSOnUnhovered_IsValid;

	private static IntPtr GSOnUnhovered_FunctionAddress;

	private static int GSOnUnhovered_ParamsSize;

	private static bool GSOnConstruct_IsValid;

	private static IntPtr GSOnConstruct_FunctionAddress;

	private static int GSOnConstruct_ParamsSize;

	private static bool GSOnLostFocused_IsValid;

	private static IntPtr GSOnLostFocused_FunctionAddress;

	private static int GSOnLostFocused_ParamsSize;

	private static bool GSOnLostFocused_FocusEvent_IsValid;

	private static int GSOnLostFocused_FocusEvent_Offset;

	private static FFieldAddress GSOnLostFocused_FocusEvent_PropertyAddress;

	[Category("GSProperty")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSButton:PressedMask")]
	public UWidget PressedMask
	{
		get
		{
			CheckDestroyed();
			if (!PressedMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:PressedMask");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, PressedMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressedMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:PressedMask");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, PressedMask_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSButton:HoveredWidget")]
	public UWidget HoveredWidget
	{
		get
		{
			CheckDestroyed();
			if (!HoveredWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:HoveredWidget");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, HoveredWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoveredWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:HoveredWidget");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, HoveredWidget_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSButton:FocusedWidget")]
	public UWidget FocusedWidget
	{
		get
		{
			CheckDestroyed();
			if (!FocusedWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:FocusedWidget");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, FocusedWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FocusedWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:FocusedWidget");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, FocusedWidget_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSButton:RootCon")]
	public UWidget RootCon
	{
		get
		{
			CheckDestroyed();
			if (!RootCon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:RootCon");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, RootCon_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootCon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:RootCon");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, RootCon_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.GSButton:DurationTime")]
	public float DurationTime
	{
		get
		{
			CheckDestroyed();
			if (!DurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:DurationTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DurationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:DurationTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DurationTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSButton:PressedScale")]
	public float PressedScale
	{
		get
		{
			CheckDestroyed();
			if (!PressedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:PressedScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PressedScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:PressedScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PressedScale_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[Tooltip("点击音效")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSButton:ClickAudioEvent")]
	public UAkAudioEvent ClickAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!ClickAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:ClickAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, ClickAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ClickAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:ClickAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, ClickAudioEvent_Offset), value);
			}
		}
	}

	[Tooltip("键盘/手柄导航选中时的音效")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.GSButton:FocusAudioEvent")]
	public UAkAudioEvent FocusAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!FocusAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:FocusAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, FocusAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FocusAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:FocusAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, FocusAudioEvent_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[Tooltip("鼠标浮动在上面时的音效")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSButton:HoveredAudioEvent")]
	public UAkAudioEvent HoveredAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!HoveredAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:HoveredAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, HoveredAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoveredAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButton:HoveredAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, HoveredAudioEvent_Offset), value);
			}
		}
	}

	public int ChangeCount { get; private set; }

	public event DelButtonClicked OnGSButtonClicked;

	public event DelButtonPressed OnGSButtonPressed;

	public event DelButtonPressing OnGSButtonPressing;

	public event DelButtonReleased OnGSButtonReleased;

	public event DelButtonHovered OnGSButtonHovered;

	public event DelButtonUnhovered OnGSButtonUnhovered;

	public event DelButtonFocused OnGSButtonFocused;

	public event DelButtonUnfocused OnGSButtonLostFocused;

	public bool IsGSNeedTick()
	{
		return IsNeedTickUpdate;
	}

	public bool IsUObjectDestroyed()
	{
		return this.IsNullOrDestroyed();
	}

	public int GetGSID()
	{
		return GSID;
	}

	public void DoGSTick(float DeltaTime)
	{
		UpdatePressedTime(DeltaTime);
		if (IsPressed())
		{
			SpeedUp(PressedTotalTime);
			this.OnGSButtonPressing?.Invoke(GSID, DeltaTime, PressedTotalTime);
		}
		float alpha = PressedLiveTime / DurationTime;
		if (RootCon != null)
		{
			float num = GSEaseFuncInUE.GSMathEase(1f, PressedScale, alpha, EEasingFunc.EaseOut);
			FVector2D renderScale = new FVector2D(num, num);
			RootCon.SetRenderScale(renderScale);
		}
		if (PressedLiveTime == 0f)
		{
			IsNeedTickUpdate = false;
		}
		if (PressedMask != null)
		{
			float renderOpacity = GSEaseFuncInUE.GSMathEase(0f, 1f, alpha, EEasingFunc.EaseOut);
			PressedMask.SetRenderOpacity(renderOpacity);
			if (PressedLiveTime == 0f)
			{
				PressedMask.SetVisibility(ESlateVisibility.Collapsed);
			}
			else
			{
				PressedMask.SetVisibility(ESlateVisibility.HitTestInvisible);
			}
		}
	}

	public void SetSpeedMax(int SpeedUpMaxCount, float SpeedUpTime)
	{
		this.SpeedUpTime = SpeedUpTime;
		this.SpeedUpMaxCount = SpeedUpMaxCount;
	}

	private void InitPressingParam()
	{
		ChangeTime = 0f;
		Speed = 0f;
		ChangeCount = 0;
	}

	private void SpeedUp(float PressedTime)
	{
		if (PressedTime < OneTime)
		{
			ChangeCount = 0;
		}
		else if (PressedTime <= SpeedUpTime)
		{
			float x = (PressedTime + OneTime) / SpeedUpTime;
			x = MathLib.Clamp(x, 0f, 1f);
			int num = (int)(GSEaseFunc.Ease(ENGSEasingFunc.EaseInQuart, 0f, 1f, x) * (float)SpeedUpMaxCount + 1f);
			if (num != ChangeCount)
			{
				Speed = PressedTime - ChangeTime;
				ChangeTime = PressedTime;
			}
			ChangeCount = num;
		}
		else
		{
			ChangeCount = (int)((PressedTime - SpeedUpTime) / Speed) + SpeedUpMaxCount + 1;
		}
	}

	private void UpdatePressedTime(float DeltaTime)
	{
		if (IsPressed())
		{
			PressedTotalTime += DeltaTime;
		}
		else
		{
			PressedTotalTime = 0f;
			PressedLiveTime -= DeltaTime;
		}
		PressedLiveTime = MathLib.Clamp(PressedTotalTime, 0f, DurationTime);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.GSButton:GSOnPressed")]
	public void GSOnPressed()
	{
		InitPressingParam();
		IsNeedTickUpdate = true;
		GSTickMgr?.SetTickingQueue(this);
		this.OnGSButtonPressed?.Invoke(GetGSID());
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.GSButton:GSOnReleased")]
	public void GSOnReleased()
	{
		this.OnGSButtonReleased?.Invoke(GetGSID());
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.GSButton:GSOnClicked")]
	public void GSOnClicked()
	{
		if (ChangeCount == 0)
		{
			ChangeCount++;
		}
		this.OnGSButtonClicked?.Invoke(GetGSID());
		if (ClickAudioEvent != null)
		{
			UAkGameplayStatics.PostEventOnDummyObj(ClickAudioEvent, string.Empty);
		}
		InitPressingParam();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.GSButton:GSOnHovered")]
	public void GSOnHovered()
	{
		HoveredWidget?.SetVisibility(ESlateVisibility.HitTestInvisible);
		if (HoveredAudioEvent != null)
		{
			UAkGameplayStatics.PostEventOnDummyObj(HoveredAudioEvent, string.Empty);
		}
		this.OnGSButtonHovered?.Invoke(GetGSID());
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.GSButton:GSOnUnhovered")]
	public void GSOnUnhovered()
	{
		HoveredWidget?.SetVisibility(ESlateVisibility.Collapsed);
		this.OnGSButtonUnhovered?.Invoke(GetGSID());
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSButton:GSOnFocused")]
	public void GSOnFocused(FFocusEvent FocusEvent)
	{
		FocusedWidget?.SetVisibility(ESlateVisibility.HitTestInvisible);
		this.OnGSButtonFocused?.Invoke(GetGSID());
		EFocusCause focusEventCause = UGSE_UMGFuncLib.GetFocusEventCause(FocusEvent);
		if ((focusEventCause == EFocusCause.Navigation || focusEventCause == EFocusCause.Mouse) && FocusAudioEvent != null)
		{
			UAkGameplayStatics.PostEventOnDummyObj(FocusAudioEvent, string.Empty);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSButton:GSOnLostFocused")]
	public void GSOnLostFocused(FFocusEvent FocusEvent)
	{
		FocusedWidget?.SetVisibility(ESlateVisibility.Collapsed);
		this.OnGSButtonLostFocused?.Invoke(GetGSID());
	}

	public void BindTickMgr(GSMUITickMgr _TickMgr)
	{
		GSTickMgr = _TickMgr;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		DurationTime = 0.07f;
		PressedScale = 0.97f;
		base.IsFocusable = false;
		base.ClickMethod = EButtonClickMethod.PreciseClick;
		base.TouchMethod = EButtonTouchMethod.PreciseTap;
		base.PressMethod = EButtonPressMethod.ButtonRelease;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.GSButton:GSOnConstruct")]
	public virtual void GSOnConstruct()
	{
		GID++;
		GSID = GID;
		PressedMask?.SetVisibility(ESlateVisibility.Collapsed);
		FocusedWidget?.SetVisibility(ESlateVisibility.Collapsed);
		HoveredWidget?.SetVisibility(ESlateVisibility.Collapsed);
		RootCon?.SetRenderScale(new FVector2D(1.0, 1.0));
		base.OnPressed.Bind(GSOnPressed);
		base.OnReleased.Bind(GSOnReleased);
		base.OnClicked.Bind(GSOnClicked);
		base.OnHovered.Bind(GSOnHovered);
		base.OnUnhovered.Bind(GSOnUnhovered);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSButton:GSOnPressed")]
	private static void GSOnPressed__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSButton gSButton = GCHelper.Find<GSButton>(obj);
		gSButton.GSOnPressed();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSButton:GSOnClicked")]
	private static void GSOnClicked__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSButton gSButton = GCHelper.Find<GSButton>(obj);
		gSButton.GSOnClicked();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSButton:GSOnHovered")]
	private static void GSOnHovered__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSButton gSButton = GCHelper.Find<GSButton>(obj);
		gSButton.GSOnHovered();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSButton:GSOnFocused")]
	private static void GSOnFocused__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSButton gSButton = GCHelper.Find<GSButton>(obj);
		FFocusEvent focusEvent = StructAsClassMarshaler<FFocusEvent>.FromNative(IntPtr.Add(buffer, GSOnFocused_FocusEvent_Offset));
		gSButton.GSOnFocused(focusEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSButton:GSOnReleased")]
	private static void GSOnReleased__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSButton gSButton = GCHelper.Find<GSButton>(obj);
		gSButton.GSOnReleased();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSButton:GSOnUnhovered")]
	private static void GSOnUnhovered__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSButton gSButton = GCHelper.Find<GSButton>(obj);
		gSButton.GSOnUnhovered();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSButton:GSOnConstruct")]
	private static void GSOnConstruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSButton gSButton = GCHelper.Find<GSButton>(obj);
		gSButton.GSOnConstruct();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSButton:GSOnLostFocused")]
	private static void GSOnLostFocused__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSButton gSButton = GCHelper.Find<GSButton>(obj);
		FFocusEvent focusEvent = StructAsClassMarshaler<FFocusEvent>.FromNative(IntPtr.Add(buffer, GSOnLostFocused_FocusEvent_Offset));
		gSButton.GSOnLostFocused(focusEvent);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSButton");
		PressedMask_Offset = NativeReflection.GetPropertyOffset(intPtr, "PressedMask");
		PressedMask_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PressedMask", Classes.FObjectProperty);
		HoveredWidget_Offset = NativeReflection.GetPropertyOffset(intPtr, "HoveredWidget");
		HoveredWidget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HoveredWidget", Classes.FObjectProperty);
		FocusedWidget_Offset = NativeReflection.GetPropertyOffset(intPtr, "FocusedWidget");
		FocusedWidget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FocusedWidget", Classes.FObjectProperty);
		RootCon_Offset = NativeReflection.GetPropertyOffset(intPtr, "RootCon");
		RootCon_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RootCon", Classes.FObjectProperty);
		DurationTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DurationTime");
		DurationTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DurationTime", Classes.FFloatProperty);
		PressedScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "PressedScale");
		PressedScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PressedScale", Classes.FFloatProperty);
		ClickAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "ClickAudioEvent");
		ClickAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ClickAudioEvent", Classes.FObjectProperty);
		FocusAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "FocusAudioEvent");
		FocusAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FocusAudioEvent", Classes.FObjectProperty);
		HoveredAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "HoveredAudioEvent");
		HoveredAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HoveredAudioEvent", Classes.FObjectProperty);
		GSOnPressed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnPressed");
		GSOnPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnPressed_FunctionAddress);
		GSOnPressed_IsValid = GSOnPressed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSButton:GSOnPressed", GSOnPressed_IsValid);
		GSOnClicked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnClicked");
		GSOnClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnClicked_FunctionAddress);
		GSOnClicked_IsValid = GSOnClicked_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSButton:GSOnClicked", GSOnClicked_IsValid);
		GSOnHovered_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnHovered");
		GSOnHovered_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnHovered_FunctionAddress);
		GSOnHovered_IsValid = GSOnHovered_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSButton:GSOnHovered", GSOnHovered_IsValid);
		GSOnFocused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnFocused");
		GSOnFocused_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnFocused_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSOnFocused_FocusEvent_PropertyAddress, GSOnFocused_FunctionAddress, "FocusEvent");
		GSOnFocused_FocusEvent_Offset = NativeReflection.GetPropertyOffset(GSOnFocused_FunctionAddress, "FocusEvent");
		GSOnFocused_FocusEvent_IsValid = NativeReflection.ValidatePropertyClass(GSOnFocused_FunctionAddress, "FocusEvent", Classes.FStructProperty);
		GSOnFocused_IsValid = GSOnFocused_FunctionAddress != IntPtr.Zero && GSOnFocused_FocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSButton:GSOnFocused", GSOnFocused_IsValid);
		GSOnReleased_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnReleased");
		GSOnReleased_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnReleased_FunctionAddress);
		GSOnReleased_IsValid = GSOnReleased_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSButton:GSOnReleased", GSOnReleased_IsValid);
		GSOnUnhovered_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnUnhovered");
		GSOnUnhovered_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnUnhovered_FunctionAddress);
		GSOnUnhovered_IsValid = GSOnUnhovered_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSButton:GSOnUnhovered", GSOnUnhovered_IsValid);
		GSOnConstruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnConstruct");
		GSOnConstruct_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnConstruct_FunctionAddress);
		GSOnConstruct_IsValid = GSOnConstruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSButton:GSOnConstruct", GSOnConstruct_IsValid);
		GSOnLostFocused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnLostFocused");
		GSOnLostFocused_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnLostFocused_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSOnLostFocused_FocusEvent_PropertyAddress, GSOnLostFocused_FunctionAddress, "FocusEvent");
		GSOnLostFocused_FocusEvent_Offset = NativeReflection.GetPropertyOffset(GSOnLostFocused_FunctionAddress, "FocusEvent");
		GSOnLostFocused_FocusEvent_IsValid = NativeReflection.ValidatePropertyClass(GSOnLostFocused_FunctionAddress, "FocusEvent", Classes.FStructProperty);
		GSOnLostFocused_IsValid = GSOnLostFocused_FunctionAddress != IntPtr.Zero && GSOnLostFocused_FocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSButton:GSOnLostFocused", GSOnLostFocused_IsValid);
	}

	static GSButton()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSButton)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSButton));
	}
}
