using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Trigger Effect")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSTriggerEffect")]
public class BANS_GSTriggerEffect : BANS_GSBase
{
	private static bool EffectID_IsValid;

	private static int EffectID_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GSValidateInputCS_IsValid;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static int GSValidateInputCS_actor_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSTriggerEffect:EffectID")]
	public int EffectID
	{
		get
		{
			CheckDestroyed();
			if (!EffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTriggerEffect:EffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTriggerEffect:EffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EffectID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTriggerEffect:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (!(aActor != null))
		{
			return;
		}
		ABGUCharacter aBGUCharacter = aActor as ABGUCharacter;
		if (aBGUCharacter != null && aActor.World != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection != null)
			{
				FEffectInstReq fEffectInstReq = new FEffectInstReq(aBGUCharacter);
				fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
				fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor);
				fEffectInstReq.HitActionDir = EHitActionDir.Default;
				FEffectInstReq effectInstReq = fEffectInstReq;
				bUS_GSEventCollection.Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTriggerEffect:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTriggerEffect:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTriggerEffect:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor actor)
	{
		BGW_ValiDateMgr bGW_ValiDateMgr = BGW_ValiDateMgr.Get(actor.World);
		string pathName = GetOuter().GetPathName();
		string name = GetName();
		if (BGW_GameDB.GetSkillEffectDesc(EffectID, actor) == null)
		{
			string logStr = $"Montage（{pathName}）中的Notify（{name}）的EffectID（{EffectID}）未在SkillEffect表中找到索引";
			bGW_ValiDateMgr.ShowValidateWindow(logStr);
		}
		else
		{
			if (EffectID < 10100)
			{
				return;
			}
			BGUCharacterCS bGUCharacterCS = actor as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				int resID = bGUCharacterCS.GetResID();
				int num = ((resID >= 100) ? (EffectID / 10000) : (EffectID / 100000));
				if (num != resID)
				{
					string logStr2 = $"Montage（{pathName}）中的Notify（{name}）的EffectID（{EffectID}）未对应单位的ResID（{resID}）";
					bGW_ValiDateMgr.ShowValidateWindow(logStr2);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTriggerEffect:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSTriggerEffect bANS_GSTriggerEffect = GCHelper.Find<BANS_GSTriggerEffect>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSTriggerEffect.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTriggerEffect:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSTriggerEffect bANS_GSTriggerEffect = GCHelper.Find<BANS_GSTriggerEffect>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSTriggerEffect.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTriggerEffect:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSTriggerEffect bANS_GSTriggerEffect = GCHelper.Find<BANS_GSTriggerEffect>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSTriggerEffect.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTriggerEffect:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSTriggerEffect bANS_GSTriggerEffect = GCHelper.Find<BANS_GSTriggerEffect>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_actor_Offset));
		bANS_GSTriggerEffect.GSValidateInputCS_Implementation(actor);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSTriggerEffect");
		EffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectID");
		EffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectID", Classes.FIntProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTriggerEffect:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTriggerEffect:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTriggerEffect:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_actor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTriggerEffect:GSValidateInputCS", GSValidateInputCS_IsValid);
	}

	static BANS_GSTriggerEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSTriggerEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSTriggerEffect));
	}
}
