using System;
using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_PlayMontageProxyMgr : GameStateSystemBase
{
	private class ProxyKeyWapper
	{
		public int ReqIdx;

		public EMontageBindReason Reason;

		public Entity Ent;

		public ProxyKeyWapper(int _ReqIdx, EMontageBindReason _Reason, Entity _Ent)
		{
			ReqIdx = _ReqIdx;
			Reason = _Reason;
			Ent = _Ent;
		}

		public bool IsEqual(EMontageBindReason _Reason, Entity _Ent)
		{
			if (Ent == _Ent)
			{
				return Reason == _Reason;
			}
			return false;
		}
	}

	private class ProxyWapper
	{
		private EMontageCallbackState State;

		private TStrongObjectPtr<UBGUPlayMontageCallbackProxy> mProxyPtr = new TStrongObjectPtr<UBGUPlayMontageCallbackProxy>();

		public UBGUPlayMontageCallbackProxy ProxyPtr
		{
			get
			{
				return mProxyPtr.Get();
			}
			private set
			{
				mProxyPtr.Set(value);
			}
		}

		public ProxyWapper(UBGUPlayMontageCallbackProxy Proxy)
		{
			ProxyPtr = Proxy;
			State = EMontageCallbackState.Default;
		}

		public void UpdateState(EMontageCallbackState InState)
		{
			State = InState;
		}

		public EMontageCallbackState GetState()
		{
			return State;
		}

		public void Clean()
		{
			mProxyPtr.Delete();
		}
	}

	[UClass]
	[USharpPath("/Script/b1-Managed.BGUPlayMontageBinder")]
	private class BGUPlayMontageBinder : BGS_EQSFunctionBinderMgr.BGUFunctionBinder
	{
		private static bool OnBlendOut_IsValid;

		private static IntPtr OnBlendOut_FunctionAddress;

		private static int OnBlendOut_ParamsSize;

		private static bool OnBlendOut__ReqIdx_IsValid;

		private static int OnBlendOut__ReqIdx_Offset;

		private static bool OnBlendOut_AnimInstance_IsValid;

		private static int OnBlendOut_AnimInstance_Offset;

		private static bool OnBlendOut_Montage_IsValid;

		private static int OnBlendOut_Montage_Offset;

		private static bool OnCompleted_IsValid;

		private static IntPtr OnCompleted_FunctionAddress;

		private static int OnCompleted_ParamsSize;

		private static bool OnCompleted__ReqIdx_IsValid;

		private static int OnCompleted__ReqIdx_Offset;

		private static bool OnCompleted_AnimInstance_IsValid;

		private static int OnCompleted_AnimInstance_Offset;

		private static bool OnCompleted_Montage_IsValid;

		private static int OnCompleted_Montage_Offset;

		private static bool OnInterrupted_IsValid;

		private static IntPtr OnInterrupted_FunctionAddress;

		private static int OnInterrupted_ParamsSize;

		private static bool OnInterrupted__ReqIdx_IsValid;

		private static int OnInterrupted__ReqIdx_Offset;

		private static bool OnInterrupted_AnimInstance_IsValid;

		private static int OnInterrupted_AnimInstance_Offset;

		private static bool OnInterrupted_Montage_IsValid;

		private static int OnInterrupted_Montage_Offset;

		[UFunction]
		[USharpPath("/Script/b1-Managed.BGUPlayMontageBinder:OnCompleted")]
		private void OnCompleted(int _ReqIdx, UAnimInstance AnimInstance, UAnimMontage Montage)
		{
			if (!(OwnerComp is BGS_PlayMontageProxyMgr bGS_PlayMontageProxyMgr))
			{
				return;
			}
			EMontageBindReason callbackReason = bGS_PlayMontageProxyMgr.GetCallbackReason(_ReqIdx);
			AActor aActor = AnimInstance?.GetOwningActor();
			if (!aActor.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
				if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
				{
					bUS_GSEventCollection.Evt_PlayMontageCallback.Invoke(callbackReason, Montage, EMontageCallbackState.OnCompleted);
				}
			}
			bGS_PlayMontageProxyMgr.UpdateProxyState(_ReqIdx, EMontageCallbackState.OnCompleted);
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.BGUPlayMontageBinder:OnBlendOut")]
		private void OnBlendOut(int _ReqIdx, UAnimInstance AnimInstance, UAnimMontage Montage)
		{
			if (!(OwnerComp is BGS_PlayMontageProxyMgr bGS_PlayMontageProxyMgr))
			{
				return;
			}
			EMontageBindReason callbackReason = bGS_PlayMontageProxyMgr.GetCallbackReason(_ReqIdx);
			AActor aActor = AnimInstance?.GetOwningActor();
			if (!aActor.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
				if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
				{
					bUS_GSEventCollection.Evt_PlayMontageCallback.Invoke(callbackReason, Montage, EMontageCallbackState.OnBlendOut);
				}
			}
			bGS_PlayMontageProxyMgr.UpdateProxyState(_ReqIdx, EMontageCallbackState.OnBlendOut);
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.BGUPlayMontageBinder:OnInterrupted")]
		public void OnInterrupted(int _ReqIdx, UAnimInstance AnimInstance, UAnimMontage Montage)
		{
			if (!(OwnerComp is BGS_PlayMontageProxyMgr bGS_PlayMontageProxyMgr))
			{
				return;
			}
			EMontageBindReason callbackReason = bGS_PlayMontageProxyMgr.GetCallbackReason(_ReqIdx);
			AActor aActor = AnimInstance?.GetOwningActor();
			if (!aActor.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
				if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
				{
					BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(aActor);
					if (bUS_GSEventCollection2 != null && bUS_GSEventCollection2.HasBeginPlay)
					{
						bUS_GSEventCollection2.Evt_PlayMontageCallback.Invoke(callbackReason, Montage, EMontageCallbackState.OnInterrupted);
					}
				}
			}
			bGS_PlayMontageProxyMgr.UpdateProxyState(_ReqIdx, EMontageCallbackState.OnInterrupted);
		}

		public void OnStarted(int _ReqIdx, AActor OwnerActor, UAnimMontage Montage)
		{
			if (!(OwnerComp is BGS_PlayMontageProxyMgr bGS_PlayMontageProxyMgr))
			{
				return;
			}
			EMontageBindReason callbackReason = bGS_PlayMontageProxyMgr.GetCallbackReason(_ReqIdx);
			if (!OwnerActor.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerActor);
				if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
				{
					bUS_GSEventCollection.Evt_PlayMontageCallback.Invoke(callbackReason, Montage, EMontageCallbackState.OnStarted);
				}
			}
			bGS_PlayMontageProxyMgr.UpdateProxyState(_ReqIdx, EMontageCallbackState.OnStarted);
		}

		public void OnPlayFailed(int _ReqIdx, AActor OwnerActor, UAnimMontage Montage)
		{
			if (!(OwnerComp is BGS_PlayMontageProxyMgr bGS_PlayMontageProxyMgr))
			{
				return;
			}
			EMontageBindReason callbackReason = bGS_PlayMontageProxyMgr.GetCallbackReason(_ReqIdx);
			if (!OwnerActor.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerActor);
				if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
				{
					bUS_GSEventCollection.Evt_PlayMontageCallback.Invoke(callbackReason, Montage, EMontageCallbackState.OnPlayFailed);
				}
			}
			bGS_PlayMontageProxyMgr.UpdateProxyState(_ReqIdx, EMontageCallbackState.OnPlayFailed);
		}

		[UFunctionInvoker("/Script/b1-Managed.BGUPlayMontageBinder:OnBlendOut")]
		private static void OnBlendOut__Invoker(IntPtr buffer, IntPtr obj)
		{
			BGUPlayMontageBinder bGUPlayMontageBinder = GCHelper.Find<BGUPlayMontageBinder>(obj);
			int reqIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnBlendOut__ReqIdx_Offset));
			UAnimInstance animInstance = UObjectMarshaler<UAnimInstance>.FromNative(IntPtr.Add(buffer, OnBlendOut_AnimInstance_Offset));
			UAnimMontage montage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, OnBlendOut_Montage_Offset));
			bGUPlayMontageBinder.OnBlendOut(reqIdx, animInstance, montage);
		}

		[UFunctionInvoker("/Script/b1-Managed.BGUPlayMontageBinder:OnCompleted")]
		private static void OnCompleted__Invoker(IntPtr buffer, IntPtr obj)
		{
			BGUPlayMontageBinder bGUPlayMontageBinder = GCHelper.Find<BGUPlayMontageBinder>(obj);
			int reqIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCompleted__ReqIdx_Offset));
			UAnimInstance animInstance = UObjectMarshaler<UAnimInstance>.FromNative(IntPtr.Add(buffer, OnCompleted_AnimInstance_Offset));
			UAnimMontage montage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, OnCompleted_Montage_Offset));
			bGUPlayMontageBinder.OnCompleted(reqIdx, animInstance, montage);
		}

		[UFunctionInvoker("/Script/b1-Managed.BGUPlayMontageBinder:OnInterrupted")]
		private static void OnInterrupted__Invoker(IntPtr buffer, IntPtr obj)
		{
			BGUPlayMontageBinder bGUPlayMontageBinder = GCHelper.Find<BGUPlayMontageBinder>(obj);
			int reqIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnInterrupted__ReqIdx_Offset));
			UAnimInstance animInstance = UObjectMarshaler<UAnimInstance>.FromNative(IntPtr.Add(buffer, OnInterrupted_AnimInstance_Offset));
			UAnimMontage montage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, OnInterrupted_Montage_Offset));
			bGUPlayMontageBinder.OnInterrupted(reqIdx, animInstance, montage);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUPlayMontageBinder");
			OnBlendOut_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnBlendOut");
			OnBlendOut_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBlendOut_FunctionAddress);
			OnBlendOut__ReqIdx_Offset = NativeReflection.GetPropertyOffset(OnBlendOut_FunctionAddress, "_ReqIdx");
			OnBlendOut__ReqIdx_IsValid = NativeReflection.ValidatePropertyClass(OnBlendOut_FunctionAddress, "_ReqIdx", Classes.FIntProperty);
			OnBlendOut_AnimInstance_Offset = NativeReflection.GetPropertyOffset(OnBlendOut_FunctionAddress, "AnimInstance");
			OnBlendOut_AnimInstance_IsValid = NativeReflection.ValidatePropertyClass(OnBlendOut_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
			OnBlendOut_Montage_Offset = NativeReflection.GetPropertyOffset(OnBlendOut_FunctionAddress, "Montage");
			OnBlendOut_Montage_IsValid = NativeReflection.ValidatePropertyClass(OnBlendOut_FunctionAddress, "Montage", Classes.FObjectProperty);
			OnBlendOut_IsValid = OnBlendOut_FunctionAddress != IntPtr.Zero && OnBlendOut__ReqIdx_IsValid && OnBlendOut_AnimInstance_IsValid && OnBlendOut_Montage_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayMontageBinder:OnBlendOut", OnBlendOut_IsValid);
			OnCompleted_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCompleted");
			OnCompleted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCompleted_FunctionAddress);
			OnCompleted__ReqIdx_Offset = NativeReflection.GetPropertyOffset(OnCompleted_FunctionAddress, "_ReqIdx");
			OnCompleted__ReqIdx_IsValid = NativeReflection.ValidatePropertyClass(OnCompleted_FunctionAddress, "_ReqIdx", Classes.FIntProperty);
			OnCompleted_AnimInstance_Offset = NativeReflection.GetPropertyOffset(OnCompleted_FunctionAddress, "AnimInstance");
			OnCompleted_AnimInstance_IsValid = NativeReflection.ValidatePropertyClass(OnCompleted_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
			OnCompleted_Montage_Offset = NativeReflection.GetPropertyOffset(OnCompleted_FunctionAddress, "Montage");
			OnCompleted_Montage_IsValid = NativeReflection.ValidatePropertyClass(OnCompleted_FunctionAddress, "Montage", Classes.FObjectProperty);
			OnCompleted_IsValid = OnCompleted_FunctionAddress != IntPtr.Zero && OnCompleted__ReqIdx_IsValid && OnCompleted_AnimInstance_IsValid && OnCompleted_Montage_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayMontageBinder:OnCompleted", OnCompleted_IsValid);
			OnInterrupted_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnInterrupted");
			OnInterrupted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInterrupted_FunctionAddress);
			OnInterrupted__ReqIdx_Offset = NativeReflection.GetPropertyOffset(OnInterrupted_FunctionAddress, "_ReqIdx");
			OnInterrupted__ReqIdx_IsValid = NativeReflection.ValidatePropertyClass(OnInterrupted_FunctionAddress, "_ReqIdx", Classes.FIntProperty);
			OnInterrupted_AnimInstance_Offset = NativeReflection.GetPropertyOffset(OnInterrupted_FunctionAddress, "AnimInstance");
			OnInterrupted_AnimInstance_IsValid = NativeReflection.ValidatePropertyClass(OnInterrupted_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
			OnInterrupted_Montage_Offset = NativeReflection.GetPropertyOffset(OnInterrupted_FunctionAddress, "Montage");
			OnInterrupted_Montage_IsValid = NativeReflection.ValidatePropertyClass(OnInterrupted_FunctionAddress, "Montage", Classes.FObjectProperty);
			OnInterrupted_IsValid = OnInterrupted_FunctionAddress != IntPtr.Zero && OnInterrupted__ReqIdx_IsValid && OnInterrupted_AnimInstance_IsValid && OnInterrupted_Montage_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPlayMontageBinder:OnInterrupted", OnInterrupted_IsValid);
		}

		static BGUPlayMontageBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPlayMontageBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(BGUPlayMontageBinder));
		}
	}

	private static readonly FName ADDITIVE_AM_AFTERSNAPSHOT = new FName("AdditiveAMAfterSnapshot");

	private static readonly FName ON_COMLETED = new FName("OnCompleted");

	private static readonly FName ON_BLENDOUT = new FName("OnBlendOut");

	private static readonly FName ON_INTERRUPTED = new FName("OnInterrupted");

	private static readonly FName ON_STARTED = new FName("OnStarted");

	private TStrongObjectPtr<BGUPlayMontageBinder> mProxyBinder = new TStrongObjectPtr<BGUPlayMontageBinder>();

	private static Dictionary<ProxyKeyWapper, ProxyWapper> PlayMontageProxyDic = new Dictionary<ProxyKeyWapper, ProxyWapper>();

	private static int GeneratorIdx = 0;

	private BGUPlayMontageBinder ProxyBinder
	{
		get
		{
			return mProxyBinder.Get();
		}
		set
		{
			mProxyBinder.Set(value);
		}
	}

	private BGS_GSEventCollection EventCollection { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		ProxyBinder = UObject.NewObject<BGUPlayMontageBinder>(Owner);
		ProxyBinder.OwnerComp = this;
		EventCollection = BGS_GSEventCollection.Get(this);
		if (EventCollection != null)
		{
			EventCollection.Evt_BGS_CreateBGUPlayMontageCallbackProxy += new Del_CreatePlayMontageProxy(CreateBGUPlayMontageCallbackProxy);
			EventCollection.Evt_BGS_CleanBGUPlayMontageCallbackProxy += new Del_CleanPlayMontageCallbackProxy(CleanBGUPlayMontageCallbackProxy);
		}
	}

	private bool CreateBGUPlayMontageCallbackProxy(EMontageBindReason Reason, USkeletalMeshComponent InSkeletalMeshComponent, UAnimMontage MontageToPaly, float PlayRate, float StartingPosition, FName StartingSection)
	{
		int reqIdx = GenReqIdx();
		bool bSnapShot = false;
		BGUCharacterCS bGUCharacterCS = InSkeletalMeshComponent.GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(bGUCharacterCS);
			bSnapShot = readOnlyData.HasSimpleState(EBGUSimpleState.Frozen) || readOnlyData.HasSimpleState(EBGUSimpleState.Immobilizing);
		}
		UBGUPlayMontageCallbackProxy uBGUPlayMontageCallbackProxy = UBGUPlayMontageCallbackProxy.CreateProxyObjectForPlayMontage(reqIdx, MontageToPaly);
		PlayMontageProxyDic.Add(new ProxyKeyWapper(reqIdx, Reason, ECSExtension.ToEntity(bGUCharacterCS)), new ProxyWapper(uBGUPlayMontageCallbackProxy));
		uBGUPlayMontageCallbackProxy.OnCompleted.Bind(ProxyBinder, ON_COMLETED);
		uBGUPlayMontageCallbackProxy.OnBlendOut.Bind(ProxyBinder, ON_BLENDOUT);
		uBGUPlayMontageCallbackProxy.OnInterrupted.Bind(ProxyBinder, ON_INTERRUPTED);
		bool num = uBGUPlayMontageCallbackProxy.PlayMontage(InSkeletalMeshComponent, MontageToPaly, PlayRate, StartingPosition, bSnapShot, StartingSection, ADDITIVE_AM_AFTERSNAPSHOT);
		if (num)
		{
			ProxyBinder.OnStarted(reqIdx, bGUCharacterCS, MontageToPaly);
			return num;
		}
		ProxyBinder.OnPlayFailed(reqIdx, bGUCharacterCS, MontageToPaly);
		return num;
	}

	private void CleanBGUPlayMontageCallbackProxy(Entity Ent)
	{
		foreach (KeyValuePair<ProxyKeyWapper, ProxyWapper> item in PlayMontageProxyDic)
		{
			ProxyKeyWapper key = item.Key;
			if (!(key.Ent == Ent))
			{
				continue;
			}
			if (ECSExtension.ToActor(Ent) is BGUCharacterCS bGUCharacterCS)
			{
				UAnimInstance animInstance = bGUCharacterCS.Mesh.GetAnimInstance();
				if (animInstance != null && animInstance.GetCurrentActiveMontage() != null)
				{
					ProxyBinder.OnInterrupted(key.ReqIdx, animInstance, null);
					break;
				}
			}
			PlayMontageProxyDic.Remove(key);
			break;
		}
	}

	public void CleanBGUPlayMontageCallbackProxy(EMontageBindReason Reason, Entity Ent)
	{
		foreach (KeyValuePair<ProxyKeyWapper, ProxyWapper> item in PlayMontageProxyDic)
		{
			if (item.Key.IsEqual(Reason, Ent))
			{
				PlayMontageProxyDic.Remove(item.Key);
				break;
			}
		}
	}

	private static int GenReqIdx()
	{
		GeneratorIdx++;
		if (GeneratorIdx < 0)
		{
			GeneratorIdx = 0;
		}
		return GeneratorIdx;
	}

	public EMontageCallbackState GetProxtState(Entity Ent, EMontageBindReason Reason)
	{
		foreach (KeyValuePair<ProxyKeyWapper, ProxyWapper> item in PlayMontageProxyDic)
		{
			if (item.Key.IsEqual(Reason, Ent))
			{
				return item.Value.GetState();
			}
		}
		return EMontageCallbackState.Default;
	}

	private void UpdateProxyState(int ReqIdx, EMontageCallbackState NewState)
	{
		foreach (KeyValuePair<ProxyKeyWapper, ProxyWapper> item in PlayMontageProxyDic)
		{
			if (item.Key.ReqIdx == ReqIdx)
			{
				item.Value.UpdateState(NewState);
				if (NewState == EMontageCallbackState.OnCompleted || NewState == EMontageCallbackState.OnInterrupted || NewState == EMontageCallbackState.OnPlayFailed)
				{
					item.Value.Clean();
					PlayMontageProxyDic.Remove(item.Key);
				}
				break;
			}
		}
	}

	private EMontageBindReason GetCallbackReason(int ReqIdx)
	{
		foreach (KeyValuePair<ProxyKeyWapper, ProxyWapper> item in PlayMontageProxyDic)
		{
			if (item.Key.ReqIdx == ReqIdx)
			{
				return item.Key.Reason;
			}
		}
		return EMontageBindReason.Default;
	}
}
