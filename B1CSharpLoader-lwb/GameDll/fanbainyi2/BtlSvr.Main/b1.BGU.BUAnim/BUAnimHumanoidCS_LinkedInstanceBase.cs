using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[NotBlueprintable]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase")]
public abstract class BUAnimHumanoidCS_LinkedInstanceBase : UAnimInstance
{
	protected AActor Owner;

	protected BUAnimInstanceBase TopAnimInst;

	private IBUC_ABPHelperData HelperData;

	private bool bHasInited;

	private static bool BlueprintUpdateAnimation_IsValid;

	private static IntPtr BlueprintUpdateAnimation_FunctionAddress;

	private static int BlueprintUpdateAnimation_ParamsSize;

	private static bool BlueprintUpdateAnimation_DeltaTimeX_IsValid;

	private static int BlueprintUpdateAnimation_DeltaTimeX_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	private static bool BlueprintThreadSafeUpdateAnimation_IsValid;

	private static IntPtr BlueprintThreadSafeUpdateAnimation_FunctionAddress;

	private static int BlueprintThreadSafeUpdateAnimation_ParamsSize;

	private static bool BlueprintThreadSafeUpdateAnimation_DeltaTime_IsValid;

	private static int BlueprintThreadSafeUpdateAnimation_DeltaTime_Offset;

	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase:BlueprintInitializeAnimation")]
	protected sealed override void BlueprintInitializeAnimation_Implementation()
	{
		Owner = GetOwningActor();
		if (Owner is ACharacter aCharacter && aCharacter.Mesh != null)
		{
			TopAnimInst = aCharacter.Mesh.GetAnimInstance() as BUAnimInstanceBase;
		}
		LinkedGraphInitializeAnimation();
	}

	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase:BlueprintThreadSafeUpdateAnimation")]
	protected sealed override void BlueprintThreadSafeUpdateAnimation_Implementation(float DeltaTime)
	{
		if (bHasInited)
		{
			LinkedGraphThreadUpdateAnimation(DeltaTime);
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase:BlueprintUpdateAnimation")]
	protected sealed override void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
	{
		if (!bHasInited)
		{
			Owner = GetOwningActor();
			if (Owner == null || !ECSExtension.IsECSActor(Owner))
			{
				return;
			}
			if (Owner is ACharacter aCharacter && aCharacter.Mesh != null)
			{
				TopAnimInst = aCharacter.Mesh.GetAnimInstance() as BUAnimInstanceBase;
			}
			if (HelperData == null)
			{
				HelperData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>(Owner);
			}
			if (HelperData == null)
			{
				return;
			}
			AttachEvent();
			if (TopAnimInst != null)
			{
				OnInitABPSetting();
			}
		}
		if (bHasInited && ShouldSkipBlueprintUpdateAnimation())
		{
			base.SkipBlueprintUpdateAnimation = 1;
		}
	}

	protected virtual bool ShouldSkipBlueprintUpdateAnimation()
	{
		return true;
	}

	protected virtual void LinkedGraphInitializeAnimation()
	{
	}

	protected virtual void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
	}

	public virtual void AttachEvent()
	{
		bHasInited = true;
		BUC_ABPEventCollection bUC_ABPEventCollection = BUC_ABPEventCollection.Get(this);
		bUC_ABPEventCollection.Evt_InitABPSetting = (BUC_ABPEventCollection.Del_Void)Delegate.Combine(bUC_ABPEventCollection.Evt_InitABPSetting, new BUC_ABPEventCollection.Del_Void(OnInitABPSetting));
		bUC_ABPEventCollection.Evt_RefreshABP = (BUC_ABPEventCollection.Del_Void)Delegate.Combine(bUC_ABPEventCollection.Evt_RefreshABP, new BUC_ABPEventCollection.Del_Void(RefreshABP));
	}

	public virtual void UnAttachEvent()
	{
		BUC_ABPEventCollection bUC_ABPEventCollection = BUC_ABPEventCollection.Get(this);
		if (bUC_ABPEventCollection != null)
		{
			bUC_ABPEventCollection.Evt_InitABPSetting = (BUC_ABPEventCollection.Del_Void)Delegate.Remove(bUC_ABPEventCollection.Evt_InitABPSetting, new BUC_ABPEventCollection.Del_Void(OnInitABPSetting));
			bUC_ABPEventCollection.Evt_RefreshABP = (BUC_ABPEventCollection.Del_Void)Delegate.Remove(bUC_ABPEventCollection.Evt_RefreshABP, new BUC_ABPEventCollection.Del_Void(RefreshABP));
		}
	}

	protected virtual void OnInitABPSetting()
	{
	}

	private void RefreshABP()
	{
		if (!this.IsNullOrDestroyed())
		{
			LinkedGraphThreadUpdateAnimation(0f);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase:BlueprintUpdateAnimation")]
	private static void BlueprintUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_LinkedInstanceBase bUAnimHumanoidCS_LinkedInstanceBase = GCHelper.Find<BUAnimHumanoidCS_LinkedInstanceBase>(obj);
		float deltaTimeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateAnimation_DeltaTimeX_Offset));
		bUAnimHumanoidCS_LinkedInstanceBase.BlueprintUpdateAnimation_Implementation(deltaTimeX);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_LinkedInstanceBase bUAnimHumanoidCS_LinkedInstanceBase = GCHelper.Find<BUAnimHumanoidCS_LinkedInstanceBase>(obj);
		bUAnimHumanoidCS_LinkedInstanceBase.BlueprintInitializeAnimation_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase:BlueprintThreadSafeUpdateAnimation")]
	private static void BlueprintThreadSafeUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_LinkedInstanceBase bUAnimHumanoidCS_LinkedInstanceBase = GCHelper.Find<BUAnimHumanoidCS_LinkedInstanceBase>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintThreadSafeUpdateAnimation_DeltaTime_Offset));
		bUAnimHumanoidCS_LinkedInstanceBase.BlueprintThreadSafeUpdateAnimation_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase");
		BlueprintUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BlueprintUpdateAnimation");
		BlueprintUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateAnimation_FunctionAddress);
		BlueprintUpdateAnimation_DeltaTimeX_Offset = NativeReflection.GetPropertyOffset(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX");
		BlueprintUpdateAnimation_DeltaTimeX_IsValid = NativeReflection.ValidatePropertyClass(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX", Classes.FFloatProperty);
		BlueprintUpdateAnimation_IsValid = BlueprintUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintUpdateAnimation_DeltaTimeX_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase:BlueprintUpdateAnimation", BlueprintUpdateAnimation_IsValid);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
		BlueprintThreadSafeUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BlueprintThreadSafeUpdateAnimation");
		BlueprintThreadSafeUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintThreadSafeUpdateAnimation_FunctionAddress);
		BlueprintThreadSafeUpdateAnimation_DeltaTime_Offset = NativeReflection.GetPropertyOffset(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaTime");
		BlueprintThreadSafeUpdateAnimation_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		BlueprintThreadSafeUpdateAnimation_IsValid = BlueprintThreadSafeUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintThreadSafeUpdateAnimation_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_LinkedInstanceBase:BlueprintThreadSafeUpdateAnimation", BlueprintThreadSafeUpdateAnimation_IsValid);
	}

	static BUAnimHumanoidCS_LinkedInstanceBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_LinkedInstanceBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_LinkedInstanceBase));
	}
}
