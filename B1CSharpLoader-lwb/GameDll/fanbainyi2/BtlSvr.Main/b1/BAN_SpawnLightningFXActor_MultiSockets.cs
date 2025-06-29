using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN SpawnLightningFXActor MultiSockets")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets")]
internal class BAN_SpawnLightningFXActor_MultiSockets : BAN_GSBase
{
	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool SocketNameList_IsValid;

	private static int SocketNameList_Offset;

	private static FFieldAddress SocketNameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SocketNameList_Marshaler;

	private static bool LocationRule_IsValid;

	private static int LocationRule_Offset;

	private static FFieldAddress LocationRule_PropertyAddress;

	private static bool RotationRule_IsValid;

	private static int RotationRule_Offset;

	private static FFieldAddress RotationRule_PropertyAddress;

	private static bool ScaleRule_IsValid;

	private static int ScaleRule_Offset;

	private static FFieldAddress ScaleRule_PropertyAddress;

	private static bool EQSReqID_IsValid;

	private static int EQSReqID_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:Template")]
	public TSubclassOf<BGULightningFXActorBase> Template
	{
		get
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:Template");
				return default(TSubclassOf<BGULightningFXActorBase>);
			}
			return TSubclassOfMarshaler<BGULightningFXActorBase>.FromNative(IntPtr.Add(base.Address, Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:Template");
			}
			else
			{
				TSubclassOfMarshaler<BGULightningFXActorBase>.ToNative(IntPtr.Add(base.Address, Template_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:SocketNameList")]
	public TArrayReadWrite<FName> SocketNameList
	{
		get
		{
			CheckDestroyed();
			if (!SocketNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:SocketNameList");
				return null;
			}
			if (SocketNameList_Marshaler == null)
			{
				SocketNameList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SocketNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SocketNameList_Marshaler.FromNative(IntPtr.Add(base.Address, SocketNameList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:LocationRule")]
	public EAttachmentRule LocationRule
	{
		get
		{
			CheckDestroyed();
			if (!LocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:LocationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, LocationRule_Offset), 0, LocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:LocationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, LocationRule_Offset), 0, LocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:RotationRule")]
	public EAttachmentRule RotationRule
	{
		get
		{
			CheckDestroyed();
			if (!RotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:RotationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, RotationRule_Offset), 0, RotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:RotationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, RotationRule_Offset), 0, RotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:ScaleRule")]
	public EAttachmentRule ScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!ScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:ScaleRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, ScaleRule_Offset), 0, ScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:ScaleRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, ScaleRule_Offset), 0, ScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:EQSReqID")]
	public int EQSReqID
	{
		get
		{
			CheckDestroyed();
			if (!EQSReqID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:EQSReqID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EQSReqID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSReqID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:EQSReqID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EQSReqID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		LocationRule = EAttachmentRule.SnapToTarget;
		RotationRule = EAttachmentRule.SnapToTarget;
		ScaleRule = EAttachmentRule.KeepRelative;
	}

	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
		if (actorStreamingLevelWorld == null || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld) || Template == null)
		{
			return;
		}
		FTransform worldTransform = NotifyParam.MeshComp.GetWorldTransform();
		FVector Location = worldTransform.GetLocation();
		FRotator Rotation = worldTransform.Rotator();
		FActorSpawnParameters parameters = new FActorSpawnParameters
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
		};
		BGULightningFXActorBase bGULightningFXActorBase = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(actorStreamingLevelWorld, Template.Value, ref Location, ref Rotation, ref parameters) as BGULightningFXActorBase;
		if (!(bGULightningFXActorBase == null))
		{
			bGULightningFXActorBase.AttachToComponent(NotifyParam.MeshComp, FName.None, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies: true);
			List<FVector> targetPoints = BGUFunctionLibraryCS.BGUGetCachedPointSet(owner, EQSReqID);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGULightningFXActorBase);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnReqLightningSpawnPos.Invoke(targetPoints, NotifyParam.MeshComp, SocketNameList.ToList());
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_SpawnLightningFXActor_MultiSockets bAN_SpawnLightningFXActor_MultiSockets = GCHelper.Find<b1.BAN_SpawnLightningFXActor_MultiSockets>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_SpawnLightningFXActor_MultiSockets.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets");
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref SocketNameList_PropertyAddress, intPtr, "SocketNameList");
		SocketNameList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketNameList");
		SocketNameList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketNameList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LocationRule_PropertyAddress, intPtr, "LocationRule");
		LocationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocationRule");
		LocationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref RotationRule_PropertyAddress, intPtr, "RotationRule");
		RotationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationRule");
		RotationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ScaleRule_PropertyAddress, intPtr, "ScaleRule");
		ScaleRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleRule");
		ScaleRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleRule", Classes.FEnumProperty);
		EQSReqID_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSReqID");
		EQSReqID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSReqID", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_SpawnLightningFXActor_MultiSockets:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_SpawnLightningFXActor_MultiSockets()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_SpawnLightningFXActor_MultiSockets)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_SpawnLightningFXActor_MultiSockets));
	}
}
