using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Rebirth Point Interact Perform")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract")]
public class BANS_GSRebirthPointInteract : BANS_GSBase
{
	private AActor SpActor;

	private static bool bAttachToOwner_IsValid;

	private static int bAttachToOwner_Offset;

	private static FFieldAddress bAttachToOwner_PropertyAddress;

	private static bool AttachToSocket_IsValid;

	private static int AttachToSocket_Offset;

	private static bool Actor_IsValid;

	private static int Actor_Offset;

	private static bool bAttachOtherOnFinish_IsValid;

	private static int bAttachOtherOnFinish_Offset;

	private static FFieldAddress bAttachOtherOnFinish_PropertyAddress;

	private static bool AttachToOtherSocket_IsValid;

	private static int AttachToOtherSocket_Offset;

	private static bool AttachToOtherActorTag_IsValid;

	private static int AttachToOtherActorTag_Offset;

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

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnSettings")]
	[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract:bAttachToOwner")]
	public bool bAttachToOwner
	{
		get
		{
			CheckDestroyed();
			if (!bAttachToOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:bAttachToOwner");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAttachToOwner_Offset), 0, bAttachToOwner_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAttachToOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:bAttachToOwner");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAttachToOwner_Offset), 0, bAttachToOwner_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("SpawnSettings")]
	[UMeta(MDProp.EditCondition, "bAttachToOwner")]
	[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract:AttachToSocket")]
	public FName AttachToSocket
	{
		get
		{
			CheckDestroyed();
			if (!AttachToSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:AttachToSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachToSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachToSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:AttachToSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachToSocket_Offset), value);
			}
		}
	}

	[Category("SpawnSettings")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract:Actor")]
	public TSubclassOf<AActor> Actor
	{
		get
		{
			CheckDestroyed();
			if (!Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:Actor");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, Actor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:Actor");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, Actor_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("EndSettings")]
	[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract:bAttachOtherOnFinish")]
	public bool bAttachOtherOnFinish
	{
		get
		{
			CheckDestroyed();
			if (!bAttachOtherOnFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:bAttachOtherOnFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAttachOtherOnFinish_Offset), 0, bAttachOtherOnFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAttachOtherOnFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:bAttachOtherOnFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAttachOtherOnFinish_Offset), 0, bAttachOtherOnFinish_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bAttachOtherOnFinish")]
	[BlueprintReadWrite]
	[Category("EndSettings")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract:AttachToOtherSocket")]
	public FName AttachToOtherSocket
	{
		get
		{
			CheckDestroyed();
			if (!AttachToOtherSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:AttachToOtherSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachToOtherSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachToOtherSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:AttachToOtherSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachToOtherSocket_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bAttachOtherOnFinish")]
	[EditAnywhere]
	[UProperty]
	[Category("EndSettings")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract:AttachToOtherActorTag")]
	public FName AttachToOtherActorTag
	{
		get
		{
			CheckDestroyed();
			if (!AttachToOtherActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:AttachToOtherActorTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachToOtherActorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachToOtherActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRebirthPointInteract:AttachToOtherActorTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachToOtherActorTag_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		SpActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(bGUCharacterCS.World, Actor.Value);
		if (!bAttachToOwner)
		{
			return;
		}
		foreach (UActorComponent item in bGUCharacterCS.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
			if (uSkeletalMeshComponent != null && uSkeletalMeshComponent.GetAllSocketNames().Contains(AttachToSocket))
			{
				SpActor.AttachToComponent(bGUCharacterCS.Mesh, AttachToSocket, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: true);
				break;
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSRebirthPointInteract:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS == null || SpActor.IsNullOrDestroyed())
		{
			return;
		}
		SpActor.DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		UGameplayStatics.GetAllActorsOfClassWithTag(bGUCharacterCS, UClass.GetClass<BGUInteractiveActorBase>(), AttachToOtherActorTag, out var OutActors);
		if (OutActors.Count <= 0)
		{
			return;
		}
		foreach (AActor item in OutActors)
		{
			_ = item;
			foreach (UActorComponent item2 in bGUCharacterCS.GetComponentsByClass(UClass.GetClass<UMeshComponent>()))
			{
				UMeshComponent uMeshComponent = item2 as UMeshComponent;
				if (uMeshComponent != null && uMeshComponent.GetAllSocketNames().Contains(AttachToOtherSocket))
				{
					SpActor.AttachToComponent(uMeshComponent, AttachToOtherSocket, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: true);
					break;
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSRebirthPointInteract:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSRebirthPointInteract bANS_GSRebirthPointInteract = GCHelper.Find<BANS_GSRebirthPointInteract>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSRebirthPointInteract.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSRebirthPointInteract:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSRebirthPointInteract bANS_GSRebirthPointInteract = GCHelper.Find<BANS_GSRebirthPointInteract>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSRebirthPointInteract.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSRebirthPointInteract:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSRebirthPointInteract bANS_GSRebirthPointInteract = GCHelper.Find<BANS_GSRebirthPointInteract>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSRebirthPointInteract.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSRebirthPointInteract");
		NativeReflection.GetPropertyRef(ref bAttachToOwner_PropertyAddress, intPtr, "bAttachToOwner");
		bAttachToOwner_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAttachToOwner");
		bAttachToOwner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAttachToOwner", Classes.FBoolProperty);
		AttachToSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachToSocket");
		AttachToSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachToSocket", Classes.FNameProperty);
		Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Actor", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref bAttachOtherOnFinish_PropertyAddress, intPtr, "bAttachOtherOnFinish");
		bAttachOtherOnFinish_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAttachOtherOnFinish");
		bAttachOtherOnFinish_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAttachOtherOnFinish", Classes.FBoolProperty);
		AttachToOtherSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachToOtherSocket");
		AttachToOtherSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachToOtherSocket", Classes.FNameProperty);
		AttachToOtherActorTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachToOtherActorTag");
		AttachToOtherActorTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachToOtherActorTag", Classes.FNameProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSRebirthPointInteract:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSRebirthPointInteract:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSRebirthPointInteract:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSRebirthPointInteract()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSRebirthPointInteract)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSRebirthPointInteract));
	}
}
