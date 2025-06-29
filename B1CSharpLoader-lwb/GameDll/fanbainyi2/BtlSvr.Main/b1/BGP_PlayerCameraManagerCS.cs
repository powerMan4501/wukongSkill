using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGP_PlayerCameraManagerCS")]
public class BGP_PlayerCameraManagerCS : ABGPPlayerCameraManager
{
	private bool EffectTypeManagerCullModePaused;

	private int EffectTypeManagerCullModeResumeCountDown;

	private IBGC_MovieData _MovieData;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool UpdateCameraCS_IsValid;

	private static IntPtr UpdateCameraCS_FunctionAddress;

	private static int UpdateCameraCS_ParamsSize;

	private static bool UpdateCameraCS_DeltaTime_IsValid;

	private static int UpdateCameraCS_DeltaTime_Offset;

	private static bool SetViewTargetCS_IsValid;

	private static IntPtr SetViewTargetCS_FunctionAddress;

	private static int SetViewTargetCS_ParamsSize;

	private static bool SetViewTargetCS_NewViewTarget_IsValid;

	private static int SetViewTargetCS_NewViewTarget_Offset;

	private static bool SetViewTargetCS_TransitionParams_IsValid;

	private static int SetViewTargetCS_TransitionParams_Offset;

	private static FFieldAddress SetViewTargetCS_TransitionParams_PropertyAddress;

	private static bool OnBlendCompleteCS_IsValid;

	private static IntPtr OnBlendCompleteCS_FunctionAddress;

	private static int OnBlendCompleteCS_ParamsSize;

	private static bool OnViewTargetChangedCS_IsValid;

	private static IntPtr OnViewTargetChangedCS_FunctionAddress;

	private static int OnViewTargetChangedCS_ParamsSize;

	private static bool OnViewTargetChangedCS_PC_IsValid;

	private static int OnViewTargetChangedCS_PC_Offset;

	private static bool OnViewTargetChangedCS_OldViewTarget_IsValid;

	private static int OnViewTargetChangedCS_OldViewTarget_Offset;

	private static bool OnViewTargetChangedCS_NewViewTarget_IsValid;

	private static int OnViewTargetChangedCS_NewViewTarget_Offset;

	private IBGC_MovieData MovieData
	{
		get
		{
			if (_MovieData == null)
			{
				_MovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(this);
			}
			return _MovieData;
		}
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerCameraManagerCS:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		if (EffectTypeManagerCullModePaused)
		{
			UGSE_NiagaraFuncLib.SetEffectTypeManagerState(EEffectTypeManagerCullMode.Enabled);
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		EffectTypeManagerCullModePaused = false;
		EffectTypeManagerCullModeResumeCountDown = 0;
	}

	protected bool ViewOnPlayerPawnAndBlendFinish(AActor ViewTarget)
	{
		APlayerController owningPlayerController = GetOwningPlayerController();
		if (!owningPlayerController.IsNullOrDestroyed() && owningPlayerController.IsLocalPlayerController())
		{
			return ViewTarget == owningPlayerController.GetControlledPawn();
		}
		return false;
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerCameraManagerCS:SetViewTargetCS")]
	protected override void SetViewTargetCS_Implementation(AActor NewViewTarget, FViewTargetTransitionParams TransitionParams)
	{
		base.SetViewTargetCS_Implementation(NewViewTarget, TransitionParams);
		if (!ViewOnPlayerPawnAndBlendFinish(NewViewTarget) && MovieData != null && !MovieData.IsPlaying() && !EffectTypeManagerCullModePaused)
		{
			EffectTypeManagerCullModeResumeCountDown = 1;
			EffectTypeManagerCullModePaused = true;
			UGSE_NiagaraFuncLib.SetEffectTypeManagerState(EEffectTypeManagerCullMode.Paused);
		}
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerCameraManagerCS:UpdateCameraCS")]
	protected override void UpdateCameraCS_Implementation(float DeltaTime)
	{
		base.UpdateCameraCS_Implementation(DeltaTime);
		if (EffectTypeManagerCullModePaused && ((ViewOnPlayerPawnAndBlendFinish(GetViewTargetCS()) && GetPendingViewTargetCS() == null) || (MovieData != null && MovieData.IsPlaying())))
		{
			if (EffectTypeManagerCullModeResumeCountDown > 0)
			{
				EffectTypeManagerCullModeResumeCountDown--;
				return;
			}
			EffectTypeManagerCullModePaused = false;
			UGSE_NiagaraFuncLib.SetEffectTypeManagerState(EEffectTypeManagerCullMode.Enabled);
		}
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerCameraManagerCS:OnBlendCompleteCS")]
	protected override void OnBlendCompleteCS_Implementation()
	{
		BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(GetOwningPlayerController());
		if (bPS_GSEventCollection != null && bPS_GSEventCollection.HasBeginPlay)
		{
			bPS_GSEventCollection.Evt_ViewTargetBlendComplete.Invoke();
		}
		BGU_CameraAdapterUtilV2.TryFixCameraRatio(GetOwningPlayerController(), null);
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerCameraManagerCS:OnViewTargetChangedCS")]
	protected override void OnViewTargetChangedCS_Implementation(APlayerController PC, AActor OldViewTarget, AActor NewViewTarget)
	{
		BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(GetOwningPlayerController());
		if (bPS_GSEventCollection != null && bPS_GSEventCollection.HasBeginPlay)
		{
			bPS_GSEventCollection.Evt_ViewTargetBlendComplete.Invoke();
		}
		BGU_CameraAdapterUtilV2.TryFixCameraRatio(PC, NewViewTarget);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerCameraManagerCS:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerCameraManagerCS bGP_PlayerCameraManagerCS = GCHelper.Find<BGP_PlayerCameraManagerCS>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGP_PlayerCameraManagerCS.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerCameraManagerCS:UpdateCameraCS")]
	private static void UpdateCameraCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerCameraManagerCS bGP_PlayerCameraManagerCS = GCHelper.Find<BGP_PlayerCameraManagerCS>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, UpdateCameraCS_DeltaTime_Offset));
		bGP_PlayerCameraManagerCS.UpdateCameraCS_Implementation(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerCameraManagerCS:SetViewTargetCS")]
	private static void SetViewTargetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerCameraManagerCS bGP_PlayerCameraManagerCS = GCHelper.Find<BGP_PlayerCameraManagerCS>(obj);
		AActor newViewTarget = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SetViewTargetCS_NewViewTarget_Offset));
		FViewTargetTransitionParams transitionParams = FViewTargetTransitionParams.FromNative(IntPtr.Add(buffer, SetViewTargetCS_TransitionParams_Offset));
		bGP_PlayerCameraManagerCS.SetViewTargetCS_Implementation(newViewTarget, transitionParams);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerCameraManagerCS:OnBlendCompleteCS")]
	private static void OnBlendCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerCameraManagerCS bGP_PlayerCameraManagerCS = GCHelper.Find<BGP_PlayerCameraManagerCS>(obj);
		bGP_PlayerCameraManagerCS.OnBlendCompleteCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerCameraManagerCS:OnViewTargetChangedCS")]
	private static void OnViewTargetChangedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerCameraManagerCS bGP_PlayerCameraManagerCS = GCHelper.Find<BGP_PlayerCameraManagerCS>(obj);
		APlayerController pC = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, OnViewTargetChangedCS_PC_Offset));
		AActor oldViewTarget = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnViewTargetChangedCS_OldViewTarget_Offset));
		AActor newViewTarget = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnViewTargetChangedCS_NewViewTarget_Offset));
		bGP_PlayerCameraManagerCS.OnViewTargetChangedCS_Implementation(pC, oldViewTarget, newViewTarget);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGP_PlayerCameraManagerCS");
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerCameraManagerCS:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		UpdateCameraCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateCameraCS");
		UpdateCameraCS_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateCameraCS_FunctionAddress);
		UpdateCameraCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(UpdateCameraCS_FunctionAddress, "DeltaTime");
		UpdateCameraCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(UpdateCameraCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		UpdateCameraCS_IsValid = UpdateCameraCS_FunctionAddress != IntPtr.Zero && UpdateCameraCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerCameraManagerCS:UpdateCameraCS", UpdateCameraCS_IsValid);
		SetViewTargetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetViewTargetCS");
		SetViewTargetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewTargetCS_FunctionAddress);
		SetViewTargetCS_NewViewTarget_Offset = NativeReflection.GetPropertyOffset(SetViewTargetCS_FunctionAddress, "NewViewTarget");
		SetViewTargetCS_NewViewTarget_IsValid = NativeReflection.ValidatePropertyClass(SetViewTargetCS_FunctionAddress, "NewViewTarget", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SetViewTargetCS_TransitionParams_PropertyAddress, SetViewTargetCS_FunctionAddress, "TransitionParams");
		SetViewTargetCS_TransitionParams_Offset = NativeReflection.GetPropertyOffset(SetViewTargetCS_FunctionAddress, "TransitionParams");
		SetViewTargetCS_TransitionParams_IsValid = NativeReflection.ValidatePropertyClass(SetViewTargetCS_FunctionAddress, "TransitionParams", Classes.FStructProperty);
		SetViewTargetCS_IsValid = SetViewTargetCS_FunctionAddress != IntPtr.Zero && SetViewTargetCS_NewViewTarget_IsValid && SetViewTargetCS_TransitionParams_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerCameraManagerCS:SetViewTargetCS", SetViewTargetCS_IsValid);
		OnBlendCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnBlendCompleteCS");
		OnBlendCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBlendCompleteCS_FunctionAddress);
		OnBlendCompleteCS_IsValid = OnBlendCompleteCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerCameraManagerCS:OnBlendCompleteCS", OnBlendCompleteCS_IsValid);
		OnViewTargetChangedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnViewTargetChangedCS");
		OnViewTargetChangedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewTargetChangedCS_FunctionAddress);
		OnViewTargetChangedCS_PC_Offset = NativeReflection.GetPropertyOffset(OnViewTargetChangedCS_FunctionAddress, "PC");
		OnViewTargetChangedCS_PC_IsValid = NativeReflection.ValidatePropertyClass(OnViewTargetChangedCS_FunctionAddress, "PC", Classes.FObjectProperty);
		OnViewTargetChangedCS_OldViewTarget_Offset = NativeReflection.GetPropertyOffset(OnViewTargetChangedCS_FunctionAddress, "OldViewTarget");
		OnViewTargetChangedCS_OldViewTarget_IsValid = NativeReflection.ValidatePropertyClass(OnViewTargetChangedCS_FunctionAddress, "OldViewTarget", Classes.FObjectProperty);
		OnViewTargetChangedCS_NewViewTarget_Offset = NativeReflection.GetPropertyOffset(OnViewTargetChangedCS_FunctionAddress, "NewViewTarget");
		OnViewTargetChangedCS_NewViewTarget_IsValid = NativeReflection.ValidatePropertyClass(OnViewTargetChangedCS_FunctionAddress, "NewViewTarget", Classes.FObjectProperty);
		OnViewTargetChangedCS_IsValid = OnViewTargetChangedCS_FunctionAddress != IntPtr.Zero && OnViewTargetChangedCS_PC_IsValid && OnViewTargetChangedCS_OldViewTarget_IsValid && OnViewTargetChangedCS_NewViewTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerCameraManagerCS:OnViewTargetChangedCS", OnViewTargetChangedCS_IsValid);
	}

	static BGP_PlayerCameraManagerCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGP_PlayerCameraManagerCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGP_PlayerCameraManagerCS));
	}
}
