using System;
using System.Collections.Generic;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Attach DropItem To Socket")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket")]
internal class BANS_GSAttachDropItemToSocket : BANS_GSBase
{
	private static bool ActorTag_IsValid;

	private static int ActorTag_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool AttachmentLocationRule_IsValid;

	private static int AttachmentLocationRule_Offset;

	private static FFieldAddress AttachmentLocationRule_PropertyAddress;

	private static bool AttachmentRotationRule_IsValid;

	private static int AttachmentRotationRule_Offset;

	private static FFieldAddress AttachmentRotationRule_PropertyAddress;

	private static bool AttachmentScaleRule_IsValid;

	private static int AttachmentScaleRule_Offset;

	private static FFieldAddress AttachmentScaleRule_PropertyAddress;

	private static bool ScaleUseCurve_IsValid;

	private static int ScaleUseCurve_Offset;

	private static FFieldAddress ScaleUseCurve_PropertyAddress;

	private static bool ScaleCurve_IsValid;

	private static int ScaleCurve_Offset;

	private static bool CallBPFunc_IsValid;

	private static int CallBPFunc_Offset;

	private static FFieldAddress CallBPFunc_PropertyAddress;

	private static bool CallBPFloatParam_IsValid;

	private static int CallBPFloatParam_Offset;

	private static bool TriggerEffect_IsValid;

	private static int TriggerEffect_Offset;

	private static FFieldAddress TriggerEffect_PropertyAddress;

	private static bool TriggerEffectDelay_IsValid;

	private static int TriggerEffectDelay_Offset;

	private static bool InteractItem_IsValid;

	private static int InteractItem_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:ActorTag")]
	public FName ActorTag
	{
		get
		{
			CheckDestroyed();
			if (!ActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:ActorTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ActorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:ActorTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ActorTag_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:AttachmentLocationRule")]
	public EAttachmentRule AttachmentLocationRule
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:AttachmentLocationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachmentLocationRule_Offset), 0, AttachmentLocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:AttachmentLocationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachmentLocationRule_Offset), 0, AttachmentLocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:AttachmentRotationRule")]
	public EAttachmentRule AttachmentRotationRule
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:AttachmentRotationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachmentRotationRule_Offset), 0, AttachmentRotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:AttachmentRotationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachmentRotationRule_Offset), 0, AttachmentRotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:AttachmentScaleRule")]
	public EAttachmentRule AttachmentScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:AttachmentScaleRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachmentScaleRule_Offset), 0, AttachmentScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:AttachmentScaleRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachmentScaleRule_Offset), 0, AttachmentScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("需要曲线控制形变")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:ScaleUseCurve")]
	public bool ScaleUseCurve
	{
		get
		{
			CheckDestroyed();
			if (!ScaleUseCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:ScaleUseCurve");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ScaleUseCurve_Offset), 0, ScaleUseCurve_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScaleUseCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:ScaleUseCurve");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ScaleUseCurve_Offset), 0, ScaleUseCurve_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "ScaleUseCurve")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:ScaleCurve")]
	public UCurveVector ScaleCurve
	{
		get
		{
			CheckDestroyed();
			if (!ScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:ScaleCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, ScaleCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:ScaleCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, ScaleCurve_Offset), value);
			}
		}
	}

	[DisplayName("需要调用蓝图方法")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:CallBPFunc")]
	public bool CallBPFunc
	{
		get
		{
			CheckDestroyed();
			if (!CallBPFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:CallBPFunc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CallBPFunc_Offset), 0, CallBPFunc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CallBPFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:CallBPFunc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CallBPFunc_Offset), 0, CallBPFunc_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "WeaponNeedDoCallBP")]
	[DisplayName("蓝图方法参数")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:CallBPFloatParam")]
	public float CallBPFloatParam
	{
		get
		{
			CheckDestroyed();
			if (!CallBPFloatParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:CallBPFloatParam");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CallBPFloatParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CallBPFloatParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:CallBPFloatParam");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CallBPFloatParam_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("触发拾取效果")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:TriggerEffect")]
	public bool TriggerEffect
	{
		get
		{
			CheckDestroyed();
			if (!TriggerEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:TriggerEffect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TriggerEffect_Offset), 0, TriggerEffect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:TriggerEffect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TriggerEffect_Offset), 0, TriggerEffect_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "TriggerEffect")]
	[DisplayName("触发拾取效果延迟")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:TriggerEffectDelay")]
	public float TriggerEffectDelay
	{
		get
		{
			CheckDestroyed();
			if (!TriggerEffectDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:TriggerEffectDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerEffectDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerEffectDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:TriggerEffectDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerEffectDelay_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:InteractItem")]
	private BGUDropItemActorCS InteractItem
	{
		get
		{
			CheckDestroyed();
			if (!InteractItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:InteractItem");
				return null;
			}
			return UObjectMarshaler<BGUDropItemActorCS>.FromNative(IntPtr.Add(base.Address, InteractItem_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:InteractItem");
			}
			else
			{
				UObjectMarshaler<BGUDropItemActorCS>.ToNative(IntPtr.Add(base.Address, InteractItem_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		AttachmentLocationRule = EAttachmentRule.SnapToTarget;
		AttachmentRotationRule = EAttachmentRule.SnapToTarget;
		AttachmentScaleRule = EAttachmentRule.KeepRelative;
		CallBPFunc = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (!(aActor != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = aActor as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		List<AActor> OutActors = new List<AActor>();
		UGameplayStatics.GetAllActorsOfClassWithTag(bGUCharacterCS, UClass.GetClass<BGUDropItemActorCS>(), ActorTag, out OutActors);
		if (OutActors.Count <= 0)
		{
			return;
		}
		foreach (AActor item in OutActors)
		{
			InteractItem = item as BGUDropItemActorCS;
			if (!(item != null))
			{
				continue;
			}
			foreach (UActorComponent item2 in bGUCharacterCS.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
			{
				USkeletalMeshComponent uSkeletalMeshComponent = item2 as USkeletalMeshComponent;
				if (uSkeletalMeshComponent != null && uSkeletalMeshComponent.GetAllSocketNames().Contains(SocketName))
				{
					item.SetActorEnableCollision(bNewActorEnableCollision: false);
					item.AttachToComponent(bGUCharacterCS.Mesh, SocketName, AttachmentLocationRule, AttachmentRotationRule, AttachmentScaleRule, bWeldSimulatedBodies: true);
					break;
				}
			}
			if (ScaleUseCurve)
			{
				BUS_EventCollectionCS.Get(InteractItem).Evt_ScaleDropItemByCurve.Invoke(ScaleCurve);
			}
			if (CallBPFunc)
			{
				InteractItem.DropItemBPFunc(CallBPFloatParam);
			}
			break;
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (aActor != null && aActor.World != null && !InteractItem.IsNullOrDestroyed())
		{
			InteractItem.GetRootComponent().DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			BUS_DispLibEventCollection.Get(aActor)?.Evt_RemoveChildActorMeshCompsFromManager?.Invoke(InteractItem);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttachDropItemToSocket bANS_GSAttachDropItemToSocket = GCHelper.Find<b1.BANS_GSAttachDropItemToSocket>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAttachDropItemToSocket.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttachDropItemToSocket bANS_GSAttachDropItemToSocket = GCHelper.Find<b1.BANS_GSAttachDropItemToSocket>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAttachDropItemToSocket.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAttachDropItemToSocket");
		ActorTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorTag");
		ActorTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorTag", Classes.FNameProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref AttachmentLocationRule_PropertyAddress, intPtr, "AttachmentLocationRule");
		AttachmentLocationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachmentLocationRule");
		AttachmentLocationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachmentLocationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AttachmentRotationRule_PropertyAddress, intPtr, "AttachmentRotationRule");
		AttachmentRotationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachmentRotationRule");
		AttachmentRotationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachmentRotationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AttachmentScaleRule_PropertyAddress, intPtr, "AttachmentScaleRule");
		AttachmentScaleRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachmentScaleRule");
		AttachmentScaleRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachmentScaleRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ScaleUseCurve_PropertyAddress, intPtr, "ScaleUseCurve");
		ScaleUseCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleUseCurve");
		ScaleUseCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleUseCurve", Classes.FBoolProperty);
		ScaleCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleCurve");
		ScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CallBPFunc_PropertyAddress, intPtr, "CallBPFunc");
		CallBPFunc_Offset = NativeReflection.GetPropertyOffset(intPtr, "CallBPFunc");
		CallBPFunc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CallBPFunc", Classes.FBoolProperty);
		CallBPFloatParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "CallBPFloatParam");
		CallBPFloatParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CallBPFloatParam", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TriggerEffect_PropertyAddress, intPtr, "TriggerEffect");
		TriggerEffect_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerEffect");
		TriggerEffect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerEffect", Classes.FBoolProperty);
		TriggerEffectDelay_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerEffectDelay");
		TriggerEffectDelay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerEffectDelay", Classes.FFloatProperty);
		InteractItem_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractItem");
		InteractItem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractItem", Classes.FObjectProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttachDropItemToSocket:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAttachDropItemToSocket()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAttachDropItemToSocket)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAttachDropItemToSocket));
	}
}
