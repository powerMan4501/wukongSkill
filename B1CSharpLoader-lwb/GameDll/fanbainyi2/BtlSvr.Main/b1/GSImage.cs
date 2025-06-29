using System;
using b1.GSMUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSImage")]
public class GSImage : UImage, IGSSetCommParams, IGSMUITickable, IInputWidget, IGSMUIDestruct
{
	private bool StartTick;

	protected GSMUITickMgr GSTickMgr;

	protected BlockInputHelper BlockData;

	protected MatCommParamsHelper CommParamsHelper;

	protected Action OnDestructEvent;

	private static bool UseTimer_IsValid;

	private static int UseTimer_Offset;

	private static FFieldAddress UseTimer_PropertyAddress;

	private static bool CommParams_IsValid;

	private static int CommParams_Offset;

	private static bool SetUseTimer_IsValid;

	private static IntPtr SetUseTimer_FunctionAddress;

	private static int SetUseTimer_ParamsSize;

	private static bool SetUseTimer_InUseTimer_IsValid;

	private static int SetUseTimer_InUseTimer_Offset;

	private static FFieldAddress SetUseTimer_InUseTimer_PropertyAddress;

	private static bool GSOnConstruct_IsValid;

	private static IntPtr GSOnConstruct_FunctionAddress;

	private static int GSOnConstruct_ParamsSize;

	private static bool SetCommParams_IsValid;

	private static IntPtr SetCommParams_FunctionAddress;

	private static int SetCommParams_ParamsSize;

	private static bool SetCommParams_InCommParams_IsValid;

	private static int SetCommParams_InCommParams_Offset;

	private static FFieldAddress SetCommParams_InCommParams_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("GSProperty")]
	[Tooltip("是否计时，关闭时重置")]
	[USharpPath("/Script/b1-Managed.GSImage:UseTimer")]
	public bool UseTimer
	{
		get
		{
			CheckDestroyed();
			if (!UseTimer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSImage:UseTimer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseTimer_Offset), 0, UseTimer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseTimer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSImage:UseTimer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseTimer_Offset), 0, UseTimer_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("通用材质参数")]
	[UProperty]
	[EditAnywhere]
	[Category("CommParam")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSImage:CommParams")]
	public MatCommParams CommParams
	{
		get
		{
			CheckDestroyed();
			if (!CommParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSImage:CommParams");
				return default(MatCommParams);
			}
			return MatCommParams.FromNative(IntPtr.Add(base.Address, CommParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CommParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSImage:CommParams");
			}
			else
			{
				MatCommParams.ToNative(IntPtr.Add(base.Address, CommParams_Offset), value);
			}
		}
	}

	public bool IsInit { get; protected set; }

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		CommParams = new MatCommParams
		{
			UseTimerParam = false,
			UseRandomParam = false,
			UseMouseParam = true,
			IsShowFocusPosInGamepad = true,
			UseWidgetParam = true,
			IsDynamic = true
		};
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSImage:GSOnConstruct")]
	public virtual void GSOnConstruct()
	{
		GSUIMiscUtil.GSUpdateABSMatSrcPosSizeForImg(this);
		BlockData = new BlockInputHelper();
		CommParamsHelper = new MatCommParamsHelper(this, CommParams);
		CommParamsHelper?.SetUseTimer(UseTimer);
		IsInit = true;
	}

	public void GSOnDestruct()
	{
		OnDestructEvent?.Invoke();
		IsInit = false;
	}

	public void BindTickMgr(GSMUITickMgr _TickMgr)
	{
		GSTickMgr = _TickMgr;
		UpdateTick();
	}

	public void ResetTick()
	{
		if (!IsGSNeedTick())
		{
			StartTick = false;
		}
	}

	public void UpdateTick()
	{
		if (!StartTick && IsGSNeedTick())
		{
			GSTickMgr?.SetTickingQueue(this);
			StartTick = true;
		}
	}

	public virtual void DoGSTick(float DeltaTime)
	{
		CommParamsHelper?.DoGSTick(DeltaTime);
		CommParams = CommParamsHelper.GetParams();
	}

	public virtual bool IsGSNeedTick()
	{
		if (GetIsCanInput() && CommParamsHelper != null)
		{
			return CommParamsHelper.IsGSNeedTick();
		}
		return false;
	}

	public virtual bool IsUObjectDestroyed()
	{
		return this.IsNullOrDestroyed();
	}

	public UWidget GetWidget()
	{
		return this;
	}

	public UObject GetWorldContext()
	{
		return this;
	}

	public virtual UMaterialInstanceDynamic GetMaterial()
	{
		return GetDynamicMaterial();
	}

	protected bool GetIsCanInput()
	{
		if (BlockData != null)
		{
			return !BlockData.BlockInput.Value;
		}
		return false;
	}

	public void SetBlockInput(EBlockInputReason Reason, bool InIsBlock)
	{
		ResetTick();
		BlockData?.SetBlockInput(Reason, InIsBlock);
		UpdateTick();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSImage:SetUseTimer")]
	public void SetUseTimer(bool InUseTimer)
	{
		if (!IsInit)
		{
			UseTimer = InUseTimer;
			CommParamsHelper?.SetUseTimer(InUseTimer);
			return;
		}
		ResetTick();
		UseTimer = InUseTimer;
		CommParamsHelper?.SetUseTimer(InUseTimer);
		UpdateTick();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSImage:SetCommParams")]
	public void SetCommParams(MatCommParams InCommParams)
	{
		if (!IsInit)
		{
			CommParams = InCommParams;
			return;
		}
		ResetTick();
		CommParams = InCommParams;
		CommParamsHelper?.SetParams(InCommParams);
		UpdateTick();
	}

	public void UpdateRandomParams()
	{
		if (CommParamsHelper != null)
		{
			CommParamsHelper.UpdateRandomParams();
			CommParams = CommParamsHelper.GetParams();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSImage:SetUseTimer")]
	private static void SetUseTimer__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSImage gSImage = GCHelper.Find<GSImage>(obj);
		bool useTimer = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetUseTimer_InUseTimer_Offset), 0, SetUseTimer_InUseTimer_PropertyAddress.Address);
		gSImage.SetUseTimer(useTimer);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSImage:GSOnConstruct")]
	private static void GSOnConstruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSImage gSImage = GCHelper.Find<GSImage>(obj);
		gSImage.GSOnConstruct();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSImage:SetCommParams")]
	private static void SetCommParams__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSImage gSImage = GCHelper.Find<GSImage>(obj);
		MatCommParams commParams = MatCommParams.FromNative(IntPtr.Add(buffer, SetCommParams_InCommParams_Offset));
		gSImage.SetCommParams(commParams);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSImage");
		NativeReflection.GetPropertyRef(ref UseTimer_PropertyAddress, intPtr, "UseTimer");
		UseTimer_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseTimer");
		UseTimer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseTimer", Classes.FBoolProperty);
		CommParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "CommParams");
		CommParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CommParams", Classes.FStructProperty);
		SetUseTimer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUseTimer");
		SetUseTimer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseTimer_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetUseTimer_InUseTimer_PropertyAddress, SetUseTimer_FunctionAddress, "InUseTimer");
		SetUseTimer_InUseTimer_Offset = NativeReflection.GetPropertyOffset(SetUseTimer_FunctionAddress, "InUseTimer");
		SetUseTimer_InUseTimer_IsValid = NativeReflection.ValidatePropertyClass(SetUseTimer_FunctionAddress, "InUseTimer", Classes.FBoolProperty);
		SetUseTimer_IsValid = SetUseTimer_FunctionAddress != IntPtr.Zero && SetUseTimer_InUseTimer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSImage:SetUseTimer", SetUseTimer_IsValid);
		GSOnConstruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnConstruct");
		GSOnConstruct_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnConstruct_FunctionAddress);
		GSOnConstruct_IsValid = GSOnConstruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSImage:GSOnConstruct", GSOnConstruct_IsValid);
		SetCommParams_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCommParams");
		SetCommParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCommParams_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetCommParams_InCommParams_PropertyAddress, SetCommParams_FunctionAddress, "InCommParams");
		SetCommParams_InCommParams_Offset = NativeReflection.GetPropertyOffset(SetCommParams_FunctionAddress, "InCommParams");
		SetCommParams_InCommParams_IsValid = NativeReflection.ValidatePropertyClass(SetCommParams_FunctionAddress, "InCommParams", Classes.FStructProperty);
		SetCommParams_IsValid = SetCommParams_FunctionAddress != IntPtr.Zero && SetCommParams_InCommParams_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSImage:SetCommParams", SetCommParams_IsValid);
	}

	static GSImage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSImage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSImage));
	}
}
