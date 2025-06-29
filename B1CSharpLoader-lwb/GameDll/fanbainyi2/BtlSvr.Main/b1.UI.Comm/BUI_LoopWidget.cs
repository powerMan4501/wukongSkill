using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_LoopWidget")]
public class BUI_LoopWidget : BUI_Widget
{
	private bool IsInit;

	private UWidget ContentSlot;

	private USizeBox ContentSizeBox;

	private static bool ActiveLoop_IsValid;

	private static int ActiveLoop_Offset;

	private static FFieldAddress ActiveLoop_PropertyAddress;

	private static bool NeedAdaptive_IsValid;

	private static int NeedAdaptive_Offset;

	private static FFieldAddress NeedAdaptive_PropertyAddress;

	private static bool LoopDirection_IsValid;

	private static int LoopDirection_Offset;

	private static FFieldAddress LoopDirection_PropertyAddress;

	private static bool Wait_IsValid;

	private static int Wait_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool ScrollSpeed_IsValid;

	private static int ScrollSpeed_Offset;

	private static bool Content_IsValid;

	private static int Content_Offset;

	private static bool MaxDesiredWidget_IsValid;

	private static int MaxDesiredWidget_Offset;

	private static bool CurLoopDirection_IsValid;

	private static int CurLoopDirection_Offset;

	private static FFieldAddress CurLoopDirection_PropertyAddress;

	private static bool Time_IsValid;

	private static int Time_Offset;

	private static bool Distance_IsValid;

	private static int Distance_Offset;

	private static bool Reset_IsValid;

	private static IntPtr Reset_FunctionAddress;

	private static int Reset_ParamsSize;

	private static bool Reset_ReturnValue_IsValid;

	private static int Reset_ReturnValue_Offset;

	private static FFieldAddress Reset_ReturnValue_PropertyAddress;

	private static bool GetActiveLoop_IsValid;

	private static IntPtr GetActiveLoop_FunctionAddress;

	private static int GetActiveLoop_ParamsSize;

	private static bool GetActiveLoop_ReturnValue_IsValid;

	private static int GetActiveLoop_ReturnValue_Offset;

	private static FFieldAddress GetActiveLoop_ReturnValue_PropertyAddress;

	private static bool SetActiveLoop_IsValid;

	private static IntPtr SetActiveLoop_FunctionAddress;

	private static int SetActiveLoop_ParamsSize;

	private static bool SetActiveLoop_InActiveLoop_IsValid;

	private static int SetActiveLoop_InActiveLoop_Offset;

	private static FFieldAddress SetActiveLoop_InActiveLoop_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("GSLoopWidget")]
	[DisplayName("激活滚动")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:ActiveLoop")]
	public bool ActiveLoop
	{
		get
		{
			CheckDestroyed();
			if (!ActiveLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:ActiveLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ActiveLoop_Offset), 0, ActiveLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ActiveLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:ActiveLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ActiveLoop_Offset), 0, ActiveLoop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSLoopWidget")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("是否需要自适应")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:NeedAdaptive")]
	public bool NeedAdaptive
	{
		get
		{
			CheckDestroyed();
			if (!NeedAdaptive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:NeedAdaptive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedAdaptive_Offset), 0, NeedAdaptive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedAdaptive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:NeedAdaptive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedAdaptive_Offset), 0, NeedAdaptive_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSLoopWidget")]
	[DisplayName("默认方向")]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:LoopDirection")]
	public ELoopDirection LoopDirection
	{
		get
		{
			CheckDestroyed();
			if (!LoopDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:LoopDirection");
				return ELoopDirection.LeftToRight;
			}
			return EnumMarshaler<ELoopDirection>.FromNative(IntPtr.Add(base.Address, LoopDirection_Offset), 0, LoopDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LoopDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:LoopDirection");
			}
			else
			{
				EnumMarshaler<ELoopDirection>.ToNative(IntPtr.Add(base.Address, LoopDirection_Offset), 0, LoopDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSLoopWidget")]
	[DisplayName("初始延迟")]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:Wait")]
	public float Wait
	{
		get
		{
			CheckDestroyed();
			if (!Wait_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Wait");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Wait_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Wait_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Wait");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Wait_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("GSLoopWidget")]
	[EditAnywhere]
	[DisplayName("等待延迟")]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:Delay")]
	public float Delay
	{
		get
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Delay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Delay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Delay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Delay_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSLoopWidget")]
	[DisplayName("滚动速度")]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:ScrollSpeed")]
	public float ScrollSpeed
	{
		get
		{
			CheckDestroyed();
			if (!ScrollSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:ScrollSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScrollSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:ScrollSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScrollSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("滚动内容")]
	[Category("GSLoopWidget")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:Content")]
	public UWidget Content
	{
		get
		{
			CheckDestroyed();
			if (!Content_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Content");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, Content_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Content_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Content");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, Content_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("GSLoopWidget")]
	[BlueprintReadWrite]
	[DisplayName("滚动内容最大宽度")]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:MaxDesiredWidget")]
	public float MaxDesiredWidget
	{
		get
		{
			CheckDestroyed();
			if (!MaxDesiredWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:MaxDesiredWidget");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDesiredWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDesiredWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:MaxDesiredWidget");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDesiredWidget_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[Category("GSLoopWidget")]
	[DisplayName("当前状态")]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:CurLoopDirection")]
	public ELoopDirection CurLoopDirection
	{
		get
		{
			CheckDestroyed();
			if (!CurLoopDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:CurLoopDirection");
				return ELoopDirection.LeftToRight;
			}
			return EnumMarshaler<ELoopDirection>.FromNative(IntPtr.Add(base.Address, CurLoopDirection_Offset), 0, CurLoopDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurLoopDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:CurLoopDirection");
			}
			else
			{
				EnumMarshaler<ELoopDirection>.ToNative(IntPtr.Add(base.Address, CurLoopDirection_Offset), 0, CurLoopDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("当前时间")]
	[Category("GSLoopWidget")]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty]
	[Category("GSLoopWidget")]
	[DisplayName("路程")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:Distance")]
	public float Distance
	{
		get
		{
			CheckDestroyed();
			if (!Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Distance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Distance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Distance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_LoopWidget:Distance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Distance_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ActiveLoop = true;
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		CurLoopDirection = LoopDirection;
		Time = Wait;
		ScrollSpeed = FMath.Abs(ScrollSpeed);
		IsInit = false;
		ContentSlot = FindChildWidget("ContentSlot");
		ContentSlot.SetRenderOpacity(0f);
		ContentSizeBox = FindChildWidget("ContentSizeBox") as USizeBox;
		if (!FMath.IsNearlyZero(MaxDesiredWidget))
		{
			ContentSizeBox?.SetMaxDesiredWidth(MaxDesiredWidget);
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (Content == null)
		{
			return;
		}
		if (!ActiveLoop || !IsInit)
		{
			float maxDistance = GetMaxDistance();
			if (maxDistance <= 0f)
			{
				ContentSlot.SetRenderOpacity(1f);
				SetContentTranslation(0f);
				return;
			}
			if (LoopDirection == ELoopDirection.LeftToRight)
			{
				Distance = 0f;
			}
			else
			{
				Distance = maxDistance;
			}
			SetContentTranslation(0f - Distance);
			ContentSlot.SetRenderOpacity(1f);
			IsInit = true;
			Time = Wait;
			return;
		}
		if (Time > 0f)
		{
			Time -= InDeltaTime;
			return;
		}
		float maxDistance2 = GetMaxDistance();
		if (!(maxDistance2 <= 0f))
		{
			if (CurLoopDirection == ELoopDirection.LeftToRight)
			{
				Distance += ScrollSpeed * InDeltaTime;
			}
			else if (CurLoopDirection == ELoopDirection.RightToLeft)
			{
				Distance -= ScrollSpeed * InDeltaTime;
			}
			FMath.Clamp(Distance, 0f, maxDistance2);
			SetContentTranslation(0f - Distance);
			if (Distance >= maxDistance2)
			{
				Distance = maxDistance2;
				Time = Delay;
				CurLoopDirection = ELoopDirection.RightToLeft;
			}
			else if (Distance <= 0f)
			{
				Distance = 0f;
				Time = Delay;
				CurLoopDirection = ELoopDirection.LeftToRight;
			}
		}
	}

	private void SetContentTranslation(float Position)
	{
		Content.SetRenderTranslation(new FVector2D(Position, 0.0));
	}

	private float GetMaxDistance()
	{
		float x = Content.GetDesiredSize().X;
		if (x <= 0f)
		{
			x = UGSE_UMGFuncLib.GetWidgetLocalSize(Content).X;
		}
		float x2;
		if (NeedAdaptive)
		{
			x2 = UGSE_UMGFuncLib.GetWidgetLocalSize(this).X;
		}
		else
		{
			x2 = GetDesiredSize().X;
			if (x2 <= 0f)
			{
				x2 = UGSE_UMGFuncLib.GetWidgetLocalSize(this).X;
			}
		}
		float result = x - x2;
		if (x2 <= 1f)
		{
			return 0f;
		}
		return result;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:GetActiveLoop")]
	public bool GetActiveLoop()
	{
		return ActiveLoop;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:SetActiveLoop")]
	public void SetActiveLoop(bool InActiveLoop)
	{
		if (ActiveLoop != InActiveLoop)
		{
			ActiveLoop = InActiveLoop;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_LoopWidget:Reset")]
	public bool Reset()
	{
		return IsInit = false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_LoopWidget:Reset")]
	private static void Reset__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_LoopWidget bUI_LoopWidget = GCHelper.Find<BUI_LoopWidget>(obj);
		bool value = bUI_LoopWidget.Reset();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, Reset_ReturnValue_Offset), 0, Reset_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_LoopWidget:GetActiveLoop")]
	private static void GetActiveLoop__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_LoopWidget bUI_LoopWidget = GCHelper.Find<BUI_LoopWidget>(obj);
		bool activeLoop = bUI_LoopWidget.GetActiveLoop();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetActiveLoop_ReturnValue_Offset), 0, GetActiveLoop_ReturnValue_PropertyAddress.Address, activeLoop);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_LoopWidget:SetActiveLoop")]
	private static void SetActiveLoop__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_LoopWidget bUI_LoopWidget = GCHelper.Find<BUI_LoopWidget>(obj);
		bool activeLoop = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetActiveLoop_InActiveLoop_Offset), 0, SetActiveLoop_InActiveLoop_PropertyAddress.Address);
		bUI_LoopWidget.SetActiveLoop(activeLoop);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_LoopWidget");
		NativeReflection.GetPropertyRef(ref ActiveLoop_PropertyAddress, intPtr, "ActiveLoop");
		ActiveLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActiveLoop");
		ActiveLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActiveLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedAdaptive_PropertyAddress, intPtr, "NeedAdaptive");
		NeedAdaptive_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedAdaptive");
		NeedAdaptive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedAdaptive", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LoopDirection_PropertyAddress, intPtr, "LoopDirection");
		LoopDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoopDirection");
		LoopDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoopDirection", Classes.FEnumProperty);
		Wait_Offset = NativeReflection.GetPropertyOffset(intPtr, "Wait");
		Wait_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Wait", Classes.FFloatProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		ScrollSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScrollSpeed");
		ScrollSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScrollSpeed", Classes.FFloatProperty);
		Content_Offset = NativeReflection.GetPropertyOffset(intPtr, "Content");
		Content_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Content", Classes.FObjectProperty);
		MaxDesiredWidget_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDesiredWidget");
		MaxDesiredWidget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDesiredWidget", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CurLoopDirection_PropertyAddress, intPtr, "CurLoopDirection");
		CurLoopDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurLoopDirection");
		CurLoopDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurLoopDirection", Classes.FEnumProperty);
		Time_Offset = NativeReflection.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		Distance_Offset = NativeReflection.GetPropertyOffset(intPtr, "Distance");
		Distance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Distance", Classes.FFloatProperty);
		Reset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Reset");
		Reset_ParamsSize = NativeReflection.GetFunctionParamsSize(Reset_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Reset_ReturnValue_PropertyAddress, Reset_FunctionAddress, "ReturnValue");
		Reset_ReturnValue_Offset = NativeReflection.GetPropertyOffset(Reset_FunctionAddress, "ReturnValue");
		Reset_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(Reset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Reset_IsValid = Reset_FunctionAddress != IntPtr.Zero && Reset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_LoopWidget:Reset", Reset_IsValid);
		GetActiveLoop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActiveLoop");
		GetActiveLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActiveLoop_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetActiveLoop_ReturnValue_PropertyAddress, GetActiveLoop_FunctionAddress, "ReturnValue");
		GetActiveLoop_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActiveLoop_FunctionAddress, "ReturnValue");
		GetActiveLoop_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActiveLoop_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActiveLoop_IsValid = GetActiveLoop_FunctionAddress != IntPtr.Zero && GetActiveLoop_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_LoopWidget:GetActiveLoop", GetActiveLoop_IsValid);
		SetActiveLoop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActiveLoop");
		SetActiveLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActiveLoop_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetActiveLoop_InActiveLoop_PropertyAddress, SetActiveLoop_FunctionAddress, "InActiveLoop");
		SetActiveLoop_InActiveLoop_Offset = NativeReflection.GetPropertyOffset(SetActiveLoop_FunctionAddress, "InActiveLoop");
		SetActiveLoop_InActiveLoop_IsValid = NativeReflection.ValidatePropertyClass(SetActiveLoop_FunctionAddress, "InActiveLoop", Classes.FBoolProperty);
		SetActiveLoop_IsValid = SetActiveLoop_FunctionAddress != IntPtr.Zero && SetActiveLoop_InActiveLoop_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_LoopWidget:SetActiveLoop", SetActiveLoop_IsValid);
	}

	static BUI_LoopWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_LoopWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_LoopWidget));
	}
}
