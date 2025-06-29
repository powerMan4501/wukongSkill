using System;
using b1.GSMUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSBackgroundBlurCS")]
public class GSBackgroundBlurCS : UBackgroundBlur, IGSSetCommParams, IGSMUITickable, IInputWidget, IGSMUIDestruct
{
	private bool StartTick;

	protected GSMUITickMgr GSTickMgr;

	protected BlockInputHelper BlockData;

	protected MatCommParamsHelper CommParamsHelper;

	protected Action OnDestructEvent;

	private static bool CommParams_IsValid;

	private static int CommParams_Offset;

	private static bool GSOnConstruct_IsValid;

	private static IntPtr GSOnConstruct_FunctionAddress;

	private static int GSOnConstruct_ParamsSize;

	private static bool SetCommParams_IsValid;

	private static IntPtr SetCommParams_FunctionAddress;

	private static int SetCommParams_ParamsSize;

	private static bool SetCommParams_InCommParams_IsValid;

	private static int SetCommParams_InCommParams_Offset;

	private static FFieldAddress SetCommParams_InCommParams_PropertyAddress;

	[Tooltip("通用材质参数")]
	[Category("CommParam")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSBackgroundBlurCS:CommParams")]
	public MatCommParams CommParams
	{
		get
		{
			CheckDestroyed();
			if (!CommParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackgroundBlurCS:CommParams");
				return default(MatCommParams);
			}
			return MatCommParams.FromNative(IntPtr.Add(base.Address, CommParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CommParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackgroundBlurCS:CommParams");
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

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSBackgroundBlurCS:GSOnConstruct")]
	public virtual void GSOnConstruct()
	{
		BlockData = new BlockInputHelper();
		CommParamsHelper = new MatCommParamsHelper(this, CommParams);
		IsInit = true;
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
		UObject resourceObject = base.GSBlurMaskBrush.ResourceObject;
		if (resourceObject is UMaterialInstanceDynamic result)
		{
			return result;
		}
		if (resourceObject is UMaterialInstance parent)
		{
			UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(this, parent, FName.None, EMIDCreationFlags.None);
			FSlateBrush gSBlurMaskBrush = base.GSBlurMaskBrush;
			gSBlurMaskBrush.ResourceObject = uMaterialInstanceDynamic;
			SetGSBlurMaskBrush(gSBlurMaskBrush);
			return uMaterialInstanceDynamic;
		}
		return null;
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
		if (CommParamsHelper == null)
		{
			return this.IsNullOrDestroyed();
		}
		if (CommParamsHelper != null)
		{
			return CommParamsHelper.IsUObjectDestroyed();
		}
		return false;
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
	[USharpPath("/Script/b1-Managed.GSBackgroundBlurCS:SetCommParams")]
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

	[UFunctionInvoker("/Script/b1-Managed.GSBackgroundBlurCS:GSOnConstruct")]
	private static void GSOnConstruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSBackgroundBlurCS gSBackgroundBlurCS = GCHelper.Find<GSBackgroundBlurCS>(obj);
		gSBackgroundBlurCS.GSOnConstruct();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSBackgroundBlurCS:SetCommParams")]
	private static void SetCommParams__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSBackgroundBlurCS gSBackgroundBlurCS = GCHelper.Find<GSBackgroundBlurCS>(obj);
		MatCommParams commParams = MatCommParams.FromNative(IntPtr.Add(buffer, SetCommParams_InCommParams_Offset));
		gSBackgroundBlurCS.SetCommParams(commParams);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSBackgroundBlurCS");
		CommParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "CommParams");
		CommParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CommParams", Classes.FStructProperty);
		GSOnConstruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnConstruct");
		GSOnConstruct_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnConstruct_FunctionAddress);
		GSOnConstruct_IsValid = GSOnConstruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSBackgroundBlurCS:GSOnConstruct", GSOnConstruct_IsValid);
		SetCommParams_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCommParams");
		SetCommParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCommParams_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetCommParams_InCommParams_PropertyAddress, SetCommParams_FunctionAddress, "InCommParams");
		SetCommParams_InCommParams_Offset = NativeReflection.GetPropertyOffset(SetCommParams_FunctionAddress, "InCommParams");
		SetCommParams_InCommParams_IsValid = NativeReflection.ValidatePropertyClass(SetCommParams_FunctionAddress, "InCommParams", Classes.FStructProperty);
		SetCommParams_IsValid = SetCommParams_FunctionAddress != IntPtr.Zero && SetCommParams_InCommParams_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSBackgroundBlurCS:SetCommParams", SetCommParams_IsValid);
	}

	static GSBackgroundBlurCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSBackgroundBlurCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSBackgroundBlurCS));
	}
}
