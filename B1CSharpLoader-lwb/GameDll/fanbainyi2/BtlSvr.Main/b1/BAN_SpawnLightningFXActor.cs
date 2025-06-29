using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

[DisplayName("BAN SpawnLightningFXActor")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor")]
internal class BAN_SpawnLightningFXActor : BAN_GSBase
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

	private static bool GetPointsType_IsValid;

	private static int GetPointsType_Offset;

	private static FFieldAddress GetPointsType_PropertyAddress;

	private static bool EQSReqID_IsValid;

	private static int EQSReqID_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor:Template")]
	public TSoftClass<BGULightningFXActorBase> Template
	{
		get
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:Template");
				return default(TSoftClass<BGULightningFXActorBase>);
			}
			return TSoftClassMarshaler<BGULightningFXActorBase>.FromNative(IntPtr.Add(base.Address, Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:Template");
			}
			else
			{
				TSoftClassMarshaler<BGULightningFXActorBase>.ToNative(IntPtr.Add(base.Address, Template_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor:SocketNameList")]
	public TArrayReadWrite<FName> SocketNameList
	{
		get
		{
			CheckDestroyed();
			if (!SocketNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:SocketNameList");
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
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor:LocationRule")]
	public EAttachmentRule LocationRule
	{
		get
		{
			CheckDestroyed();
			if (!LocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:LocationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, LocationRule_Offset), 0, LocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:LocationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, LocationRule_Offset), 0, LocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor:RotationRule")]
	public EAttachmentRule RotationRule
	{
		get
		{
			CheckDestroyed();
			if (!RotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:RotationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, RotationRule_Offset), 0, RotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:RotationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, RotationRule_Offset), 0, RotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor:ScaleRule")]
	public EAttachmentRule ScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!ScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:ScaleRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, ScaleRule_Offset), 0, ScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:ScaleRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, ScaleRule_Offset), 0, ScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor:GetPointsType")]
	public PointsGenType GetPointsType
	{
		get
		{
			CheckDestroyed();
			if (!GetPointsType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:GetPointsType");
				return PointsGenType.ByEQS_Async;
			}
			return EnumMarshaler<PointsGenType>.FromNative(IntPtr.Add(base.Address, GetPointsType_Offset), 0, GetPointsType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GetPointsType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:GetPointsType");
			}
			else
			{
				EnumMarshaler<PointsGenType>.ToNative(IntPtr.Add(base.Address, GetPointsType_Offset), 0, GetPointsType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor:EQSReqID")]
	public int EQSReqID
	{
		get
		{
			CheckDestroyed();
			if (!EQSReqID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:EQSReqID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EQSReqID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSReqID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_SpawnLightningFXActor:EQSReqID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EQSReqID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		GetPointsType = PointsGenType.ByEQS_Async;
		LocationRule = EAttachmentRule.SnapToTarget;
		RotationRule = EAttachmentRule.SnapToTarget;
		ScaleRule = EAttachmentRule.KeepRelative;
	}

	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		if (!Template.IsNull)
		{
			return new List<FSoftObjectPath> { Template.ObjectPath };
		}
		return new List<FSoftObjectPath>();
	}

	public override void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
		if (SoftPathSet == null)
		{
			SoftPathSet = new HashSet<FSoftObjectPath>();
		}
		if (!Template.IsNull)
		{
			SoftPathSet.Add(Template.ObjectPath);
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_SpawnLightningFXActor:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
		if (actorStreamingLevelWorld == null || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld) || Template.IsNull)
		{
			return;
		}
		UClass uClass = Template.Value;
		if (uClass == null)
		{
			if (base.isPreload)
			{
				return;
			}
			uClass = SyncLoadSoftPathObjAndAddPreloadedAsset<UClass>(Template.ObjectPath.Path);
		}
		if (uClass == null)
		{
			return;
		}
		foreach (FName socketName in SocketNameList)
		{
			FTransform socketTransform = NotifyParam.MeshComp.GetSocketTransform(socketName);
			FVector location = socketTransform.GetLocation();
			FRotator rotation = socketTransform.Rotator();
			FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
			{
				SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
			};
			BGULightningFXActorBase bGULightningFXActorBase = actorStreamingLevelWorld.SpawnActor(uClass, ref location, ref rotation, ref parameters) as BGULightningFXActorBase;
			if (bGULightningFXActorBase == null)
			{
				break;
			}
			bGULightningFXActorBase.AttachToComponent(NotifyParam.MeshComp, socketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies: true);
			List<FVector> targetPoints = BGUFunctionLibraryCS.BGUGetCachedPointSet(owner, EQSReqID);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGULightningFXActorBase);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnReqLightningSpawnPos.Invoke(targetPoints);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_SpawnLightningFXActor:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_SpawnLightningFXActor bAN_SpawnLightningFXActor = GCHelper.Find<b1.BAN_SpawnLightningFXActor>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_SpawnLightningFXActor.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_SpawnLightningFXActor:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_SpawnLightningFXActor bAN_SpawnLightningFXActor = GCHelper.Find<b1.BAN_SpawnLightningFXActor>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bAN_SpawnLightningFXActor.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_SpawnLightningFXActor");
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FSoftClassProperty);
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
		NativeReflection.GetPropertyRef(ref GetPointsType_PropertyAddress, intPtr, "GetPointsType");
		GetPointsType_Offset = NativeReflection.GetPropertyOffset(intPtr, "GetPointsType");
		GetPointsType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GetPointsType", Classes.FEnumProperty);
		EQSReqID_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSReqID");
		EQSReqID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSReqID", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_SpawnLightningFXActor:GSNotifyCS", GSNotifyCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_SpawnLightningFXActor:GetSoftReferences", GetSoftReferences_IsValid);
	}

	static BAN_SpawnLightningFXActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_SpawnLightningFXActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_SpawnLightningFXActor));
	}
}
