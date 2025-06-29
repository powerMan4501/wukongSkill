using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimInstanceBase")]
public abstract class BUAnimInstanceBase : UAnimInstance, b1.BGU.BUAnim.IBUEnityAnim
{
	private static bool ABPSetting_IsValid;

	private static int ABPSetting_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[EditAnywhere]
	[UProperty]
	[Category("ABP Setting")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimInstanceBase:ABPSetting")]
	public BGWDataAsset_AbpHumanoidSetting ABPSetting
	{
		get
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimInstanceBase:ABPSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.FromNative(IntPtr.Add(base.Address, ABPSetting_Offset));
		}
	}

	public BUABPSettingData ABPSettingData { get; private set; }

	protected BUABPSettingData DefaultABPSettingData { get; private set; }

	protected BUC_ABPEventCollection BAE { get; private set; }

	[USharpPath("/Script/b1-Managed.BUAnimInstanceBase:BlueprintInitializeAnimation")]
	protected sealed override void BlueprintInitializeAnimation_Implementation()
	{
		base.BlueprintInitializeAnimation_Implementation();
		if (ABPSetting != null)
		{
			ABPSettingData = new BUABPSettingData(ABPSetting);
			DefaultABPSettingData = ABPSettingData;
		}
		BlueprintInitializeAnimationImpl();
	}

	protected virtual void BlueprintInitializeAnimationImpl()
	{
	}

	protected virtual void AttachEvent()
	{
		if (BAE == null)
		{
			BAE = BUC_ABPEventCollection.Get(this);
		}
		if (BAE != null)
		{
			BUC_ABPEventCollection bAE = BAE;
			bAE.Evt_ChangeABPSetting = (BUC_ABPEventCollection.Del_ChangeABPSetting)Delegate.Combine(bAE.Evt_ChangeABPSetting, new BUC_ABPEventCollection.Del_ChangeABPSetting(OnChangeABPSetting));
			BUC_ABPEventCollection bAE2 = BAE;
			bAE2.Evt_InitABPSetting = (BUC_ABPEventCollection.Del_Void)Delegate.Combine(bAE2.Evt_InitABPSetting, new BUC_ABPEventCollection.Del_Void(OnInitABPSetting));
			BUC_ABPEventCollection bAE3 = BAE;
			bAE3.Evt_ResetABPSetting = (BUC_ABPEventCollection.Del_Void)Delegate.Combine(bAE3.Evt_ResetABPSetting, new BUC_ABPEventCollection.Del_Void(OnResetABPSetting));
		}
	}

	protected virtual void UnAttachEvent()
	{
		if (BAE == null)
		{
			BAE = BUC_ABPEventCollection.Get(this);
		}
		if (BAE != null)
		{
			BUC_ABPEventCollection bAE = BAE;
			bAE.Evt_ChangeABPSetting = (BUC_ABPEventCollection.Del_ChangeABPSetting)Delegate.Remove(bAE.Evt_ChangeABPSetting, new BUC_ABPEventCollection.Del_ChangeABPSetting(OnChangeABPSetting));
			BUC_ABPEventCollection bAE2 = BAE;
			bAE2.Evt_InitABPSetting = (BUC_ABPEventCollection.Del_Void)Delegate.Remove(bAE2.Evt_InitABPSetting, new BUC_ABPEventCollection.Del_Void(OnInitABPSetting));
			BUC_ABPEventCollection bAE3 = BAE;
			bAE3.Evt_ResetABPSetting = (BUC_ABPEventCollection.Del_Void)Delegate.Remove(bAE3.Evt_ResetABPSetting, new BUC_ABPEventCollection.Del_Void(OnResetABPSetting));
		}
	}

	protected void OnChangeABPSetting(BGWDataAsset_AbpHumanoidSetting Setting)
	{
		if (!(Setting == null))
		{
			if (Setting == ABPSetting)
			{
				ABPSettingData = DefaultABPSettingData;
			}
			else
			{
				ABPSettingData = new BUABPSettingData(in Setting);
			}
		}
	}

	protected virtual void OnInitABPSetting()
	{
	}

	protected void OnResetABPSetting()
	{
		BUS_EventCollectionCS.Get(GetOwningActor()).Evt_ChangeABPSetting.Invoke(ABPSetting);
	}

	public void OnEntityInitFinish()
	{
		if (ABPSetting != null && DefaultABPSettingData == null)
		{
			ABPSettingData = new BUABPSettingData(ABPSetting);
			DefaultABPSettingData = ABPSettingData;
		}
		AttachEvent();
	}

	public void OnEntityEndPlay(EEndPlayReason EndPlayReason)
	{
		BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(this);
		if (bGS_GSEventCollection != null && bGS_GSEventCollection.HasBeginPlay)
		{
			bGS_GSEventCollection.Evt_BGS_CleanBGUPlayMontageCallbackProxy.Invoke(ECSExtension.ToEntity(GetOwningActor()));
		}
		UnAttachEvent();
		ABPSettingData?.Clear();
		DefaultABPSettingData?.Clear();
		ABPSettingData = null;
		DefaultABPSettingData = null;
	}

	public UAnimationAsset GetIdleAnimationAsset()
	{
		return ABPSetting?.CommonSetting.AnimSeqIdle;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimInstanceBase:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimInstanceBase bUAnimInstanceBase = GCHelper.Find<BUAnimInstanceBase>(obj);
		bUAnimInstanceBase.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimInstanceBase");
		ABPSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "ABPSetting");
		ABPSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ABPSetting", Classes.FObjectProperty);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimInstanceBase:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}

	static BUAnimInstanceBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimInstanceBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimInstanceBase));
	}
}
