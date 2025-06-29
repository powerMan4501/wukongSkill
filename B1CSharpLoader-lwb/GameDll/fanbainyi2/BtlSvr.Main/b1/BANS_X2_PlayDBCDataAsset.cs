using System;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS X2 Play DBC")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset")]
internal class BANS_X2_PlayDBCDataAsset : BANS_GSBase
{
	private static bool Play_IsValid;

	private static int Play_Offset;

	private static FFieldAddress Play_PropertyAddress;

	private static bool DataAsset_IsValid;

	private static int DataAsset_Offset;

	private static bool PlayByDispWorld_IsValid;

	private static int PlayByDispWorld_Offset;

	private static FFieldAddress PlayByDispWorld_PropertyAddress;

	private static bool MainSockNameIfDW_IsValid;

	private static int MainSockNameIfDW_Offset;

	private static bool DBC_Main_IsValid;

	private static int DBC_Main_Offset;

	private static FFieldAddress DBC_Main_PropertyAddress;

	private static bool DBC_Minor_IsValid;

	private static int DBC_Minor_Offset;

	private static FFieldAddress DBC_Minor_PropertyAddress;

	private static bool StopIfTargetNull_IsValid;

	private static int StopIfTargetNull_Offset;

	private static FFieldAddress StopIfTargetNull_PropertyAddress;

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

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:Play")]
	public bool Play
	{
		get
		{
			CheckDestroyed();
			if (!Play_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:Play");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Play_Offset), 0, Play_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Play_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:Play");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Play_Offset), 0, Play_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:DataAsset")]
	public BUC_DispLibDispBaseConfigDataAsset DataAsset
	{
		get
		{
			CheckDestroyed();
			if (!DataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:DataAsset");
				return null;
			}
			return UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(base.Address, DataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:DataAsset");
			}
			else
			{
				UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.ToNative(IntPtr.Add(base.Address, DataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("由 DispWorld 执行")]
	[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:PlayByDispWorld")]
	public bool PlayByDispWorld
	{
		get
		{
			CheckDestroyed();
			if (!PlayByDispWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:PlayByDispWorld");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PlayByDispWorld_Offset), 0, PlayByDispWorld_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PlayByDispWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:PlayByDispWorld");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PlayByDispWorld_Offset), 0, PlayByDispWorld_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "PlayByDispWorld")]
	[DisplayName("DispWorld 执行时锚定主Actor插槽")]
	[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:MainSockNameIfDW")]
	public FName MainSockNameIfDW
	{
		get
		{
			CheckDestroyed();
			if (!MainSockNameIfDW_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:MainSockNameIfDW");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MainSockNameIfDW_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainSockNameIfDW_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:MainSockNameIfDW");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MainSockNameIfDW_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("DBC 主要 Actor")]
	[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:DBC_Main")]
	public DispLibDBCAnimNotifyTarget DBC_Main
	{
		get
		{
			CheckDestroyed();
			if (!DBC_Main_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:DBC_Main");
				return DispLibDBCAnimNotifyTarget.None;
			}
			return EnumMarshaler<DispLibDBCAnimNotifyTarget>.FromNative(IntPtr.Add(base.Address, DBC_Main_Offset), 0, DBC_Main_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DBC_Main_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:DBC_Main");
			}
			else
			{
				EnumMarshaler<DispLibDBCAnimNotifyTarget>.ToNative(IntPtr.Add(base.Address, DBC_Main_Offset), 0, DBC_Main_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("DBC 次要 Actor")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:DBC_Minor")]
	public DispLibDBCAnimNotifyTarget DBC_Minor
	{
		get
		{
			CheckDestroyed();
			if (!DBC_Minor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:DBC_Minor");
				return DispLibDBCAnimNotifyTarget.None;
			}
			return EnumMarshaler<DispLibDBCAnimNotifyTarget>.FromNative(IntPtr.Add(base.Address, DBC_Minor_Offset), 0, DBC_Minor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DBC_Minor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:DBC_Minor");
			}
			else
			{
				EnumMarshaler<DispLibDBCAnimNotifyTarget>.ToNative(IntPtr.Add(base.Address, DBC_Minor_Offset), 0, DBC_Minor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("次要Actor无效时不执行")]
	[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:StopIfTargetNull")]
	public bool StopIfTargetNull
	{
		get
		{
			CheckDestroyed();
			if (!StopIfTargetNull_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:StopIfTargetNull");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StopIfTargetNull_Offset), 0, StopIfTargetNull_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StopIfTargetNull_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:StopIfTargetNull");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StopIfTargetNull_Offset), 0, StopIfTargetNull_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.CanBePlacedInASCS = true;
		base.CanUseQueuedType = true;
		Play = true;
		StopIfTargetNull = true;
		PlayByDispWorld = false;
		DBC_Main = DispLibDBCAnimNotifyTarget.Self;
		DBC_Minor = DispLibDBCAnimNotifyTarget.EnemyTarget;
	}

	protected virtual bool ValidateParameters(USkeletalMeshComponent MeshComp)
	{
		if (DataAsset == null || MeshComp == null)
		{
			return false;
		}
		if (DBC_Main == DispLibDBCAnimNotifyTarget.None)
		{
			return false;
		}
		return true;
	}

	private AActor GetMainActor(USkeletalMeshComponent MeshComp)
	{
		return DBC_Main switch
		{
			DispLibDBCAnimNotifyTarget.None => null, 
			DispLibDBCAnimNotifyTarget.Self => MeshComp.GetOwner(), 
			DispLibDBCAnimNotifyTarget.EnemyTarget => BGUFunctionLibraryCS.BGUGetTarget(MeshComp.GetOwner()), 
			_ => null, 
		};
	}

	private AActor GetMinorActor(USkeletalMeshComponent MeshComp)
	{
		return DBC_Minor switch
		{
			DispLibDBCAnimNotifyTarget.None => null, 
			DispLibDBCAnimNotifyTarget.Self => MeshComp.GetOwner(), 
			DispLibDBCAnimNotifyTarget.EnemyTarget => BGUFunctionLibraryCS.BGUGetTarget(MeshComp.GetOwner()), 
			_ => null, 
		};
	}

	private USceneComponent GetMinorActorDispOwnerComp(USkeletalMeshComponent NotifySourceMeshComp)
	{
		AActor aActor;
		switch (DBC_Minor)
		{
		case DispLibDBCAnimNotifyTarget.None:
			return null;
		case DispLibDBCAnimNotifyTarget.Self:
			aActor = NotifySourceMeshComp.GetOwner();
			break;
		case DispLibDBCAnimNotifyTarget.EnemyTarget:
			aActor = BGUFunctionLibraryCS.BGUGetTarget(NotifySourceMeshComp.GetOwner());
			break;
		default:
			return null;
		}
		if (aActor.IsNullOrDestroyed())
		{
			return null;
		}
		USceneComponent uSceneComponent = aActor.GetComponentByClass<USkeletalMeshComponent>();
		if (uSceneComponent.IsNullOrDestroyed())
		{
			uSceneComponent = aActor.GetRootComponent();
		}
		return uSceneComponent;
	}

	private USceneComponent GetMainActorDispOwnerComp(USkeletalMeshComponent NotifySourceMeshComp)
	{
		switch (DBC_Main)
		{
		case DispLibDBCAnimNotifyTarget.None:
			return null;
		case DispLibDBCAnimNotifyTarget.Self:
			return NotifySourceMeshComp;
		case DispLibDBCAnimNotifyTarget.EnemyTarget:
		{
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(NotifySourceMeshComp.GetOwner());
			if (aActor.IsNullOrDestroyed())
			{
				return null;
			}
			USceneComponent uSceneComponent = aActor.GetComponentByClass<USkeletalMeshComponent>();
			if (uSceneComponent.IsNullOrDestroyed())
			{
				uSceneComponent = aActor.GetRootComponent();
			}
			return uSceneComponent;
		}
		default:
			return null;
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		if (!Play || !ValidateParameters(meshComp))
		{
			return;
		}
		USceneComponent minorActorDispOwnerComp = GetMinorActorDispOwnerComp(meshComp);
		if (StopIfTargetNull && minorActorDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		USceneComponent mainActorDispOwnerComp = GetMainActorDispOwnerComp(meshComp);
		if (!mainActorDispOwnerComp.IsNullOrDestroyed())
		{
			if (PlayByDispWorld)
			{
				BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(mainActorDispOwnerComp.GetOwner()))?.Evt_DLDWorld_RequestApplyOneDBCDataAsset(DataAsset, out var _, new DBCTransformParam(mainActorDispOwnerComp.GetSocketTransform(MainSockNameIfDW)), minorActorDispOwnerComp, FVector.ZeroVector, DBCSetCallbackParams.Default, GetUniqueID());
			}
			else
			{
				BUS_DispLibEventCollection.Get(mainActorDispOwnerComp.GetOwner())?.Evt_RequestApplyOneDBCDataAsset(DataAsset, out var _, minorActorDispOwnerComp, FVector.ZeroVector, DBCTransformParam.Default, DBCSetCallbackParams.Default, GetUniqueID());
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		if (Play && BGU_DispLibDataUtil.GetCurActiveMontageeUniqueID(meshComp, animation, out var MontageeUniqueID))
		{
			if (PlayByDispWorld)
			{
				BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(meshComp.GetOwner()))?.Evt_DLDWorld_RequestEndDBCEffectsByANID(GetUniqueID(), MontageeUniqueID);
			}
			else
			{
				BUS_DispLibEventCollection.Get(GetMainActorDispOwnerComp(meshComp).GetOwner())?.Evt_RequestEndDBCEffectsByAnimNotifyUniqueID(GetUniqueID(), MontageeUniqueID);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_X2_PlayDBCDataAsset bANS_X2_PlayDBCDataAsset = GCHelper.Find<b1.BANS_X2_PlayDBCDataAsset>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_X2_PlayDBCDataAsset.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_X2_PlayDBCDataAsset bANS_X2_PlayDBCDataAsset = GCHelper.Find<b1.BANS_X2_PlayDBCDataAsset>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_X2_PlayDBCDataAsset.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset");
		NativeReflection.GetPropertyRef(ref Play_PropertyAddress, intPtr, "Play");
		Play_Offset = NativeReflection.GetPropertyOffset(intPtr, "Play");
		Play_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Play", Classes.FBoolProperty);
		DataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataAsset");
		DataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref PlayByDispWorld_PropertyAddress, intPtr, "PlayByDispWorld");
		PlayByDispWorld_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayByDispWorld");
		PlayByDispWorld_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayByDispWorld", Classes.FBoolProperty);
		MainSockNameIfDW_Offset = NativeReflection.GetPropertyOffset(intPtr, "MainSockNameIfDW");
		MainSockNameIfDW_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MainSockNameIfDW", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref DBC_Main_PropertyAddress, intPtr, "DBC_Main");
		DBC_Main_Offset = NativeReflection.GetPropertyOffset(intPtr, "DBC_Main");
		DBC_Main_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DBC_Main", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DBC_Minor_PropertyAddress, intPtr, "DBC_Minor");
		DBC_Minor_Offset = NativeReflection.GetPropertyOffset(intPtr, "DBC_Minor");
		DBC_Minor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DBC_Minor", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref StopIfTargetNull_PropertyAddress, intPtr, "StopIfTargetNull");
		StopIfTargetNull_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopIfTargetNull");
		StopIfTargetNull_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopIfTargetNull", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_X2_PlayDBCDataAsset:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_X2_PlayDBCDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_X2_PlayDBCDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_X2_PlayDBCDataAsset));
	}
}
