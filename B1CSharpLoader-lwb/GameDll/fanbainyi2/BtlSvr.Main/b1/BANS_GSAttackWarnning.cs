using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS GS Attack Warnning")]
[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning")]
internal class BANS_GSAttackWarnning : BANS_GSBase
{
	private Dictionary<int, FUStCheckTransformArray> AttackWarnningCheckPreTransformMap;

	private static bool HitActionDir_IsValid;

	private static int HitActionDir_Offset;

	private static FFieldAddress HitActionDir_PropertyAddress;

	private static bool HitLevel_IsValid;

	private static int HitLevel_Offset;

	private static bool WeaponIndex_IsValid;

	private static int WeaponIndex_Offset;

	private static bool AttackWarnningCheckShape_IsValid;

	private static int AttackWarnningCheckShape_Offset;

	private static FFieldAddress AttackWarnningCheckShape_PropertyAddress;

	private TArrayReadWriteMarshaler<FUStCheckShape> AttackWarnningCheckShape_Marshaler;

	private static bool IsRenderDebugShape_IsValid;

	private static int IsRenderDebugShape_Offset;

	private static FFieldAddress IsRenderDebugShape_PropertyAddress;

	private static bool AttackWarnningFixedLocalOffset_IsValid;

	private static int AttackWarnningFixedLocalOffset_Offset;

	private static bool ResultFilterType_IsValid;

	private static int ResultFilterType_Offset;

	private static FFieldAddress ResultFilterType_PropertyAddress;

	private static bool Tags_IsValid;

	private static int Tags_Offset;

	private static FFieldAddress Tags_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> Tags_Marshaler;

	private static bool AttackWarningGroupID_IsValid;

	private static int AttackWarningGroupID_Offset;

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

	[DisplayName("打击方向")]
	[Category("AttackWarnning")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:HitActionDir")]
	public EHitActionDir HitActionDir
	{
		get
		{
			CheckDestroyed();
			if (!HitActionDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:HitActionDir");
				return EHitActionDir.Default;
			}
			return EnumMarshaler<EHitActionDir>.FromNative(IntPtr.Add(base.Address, HitActionDir_Offset), 0, HitActionDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HitActionDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:HitActionDir");
			}
			else
			{
				EnumMarshaler<EHitActionDir>.ToNative(IntPtr.Add(base.Address, HitActionDir_Offset), 0, HitActionDir_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AttackWarnning")]
	[DisplayName("打击力度")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:HitLevel")]
	public int HitLevel
	{
		get
		{
			CheckDestroyed();
			if (!HitLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:HitLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HitLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:HitLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HitLevel_Offset), value);
			}
		}
	}

	[Tooltip("-1 is Body")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("AttackWarnning")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:WeaponIndex")]
	public int WeaponIndex
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:WeaponIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WeaponIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:WeaponIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WeaponIndex_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("AttackWarnning")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:AttackWarnningCheckShape")]
	public TArrayReadWrite<FUStCheckShape> AttackWarnningCheckShape
	{
		get
		{
			CheckDestroyed();
			if (!AttackWarnningCheckShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:AttackWarnningCheckShape");
				return null;
			}
			if (AttackWarnningCheckShape_Marshaler == null)
			{
				AttackWarnningCheckShape_Marshaler = new TArrayReadWriteMarshaler<FUStCheckShape>(1, AttackWarnningCheckShape_PropertyAddress, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.FromNative, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.ToNative);
			}
			return AttackWarnningCheckShape_Marshaler.FromNative(IntPtr.Add(base.Address, AttackWarnningCheckShape_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AttackWarnning")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:IsRenderDebugShape")]
	public bool IsRenderDebugShape
	{
		get
		{
			CheckDestroyed();
			if (!IsRenderDebugShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:IsRenderDebugShape");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRenderDebugShape_Offset), 0, IsRenderDebugShape_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRenderDebugShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:IsRenderDebugShape");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRenderDebugShape_Offset), 0, IsRenderDebugShape_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("AttackWarnning第一帧基于单位本地坐标系的预偏移量")]
	[Category("AttackWarnning")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:AttackWarnningFixedLocalOffset")]
	public FVector AttackWarnningFixedLocalOffset
	{
		get
		{
			CheckDestroyed();
			if (!AttackWarnningFixedLocalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:AttackWarnningFixedLocalOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, AttackWarnningFixedLocalOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackWarnningFixedLocalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:AttackWarnningFixedLocalOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, AttackWarnningFixedLocalOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AttackWarnning")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:ResultFilterType")]
	public ESweepCheckHitFilterType ResultFilterType
	{
		get
		{
			CheckDestroyed();
			if (!ResultFilterType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:ResultFilterType");
				return ESweepCheckHitFilterType.Zero;
			}
			return EnumMarshaler<ESweepCheckHitFilterType>.FromNative(IntPtr.Add(base.Address, ResultFilterType_Offset), 0, ResultFilterType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ResultFilterType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:ResultFilterType");
			}
			else
			{
				EnumMarshaler<ESweepCheckHitFilterType>.ToNative(IntPtr.Add(base.Address, ResultFilterType_Offset), 0, ResultFilterType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("AttackWarnning")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:Tags")]
	public TArrayReadWrite<FName> Tags
	{
		get
		{
			CheckDestroyed();
			if (!Tags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:Tags");
				return null;
			}
			if (Tags_Marshaler == null)
			{
				Tags_Marshaler = new TArrayReadWriteMarshaler<FName>(1, Tags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return Tags_Marshaler.FromNative(IntPtr.Add(base.Address, Tags_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AttackWarnning")]
	[DisplayName("AttackWarnning编组ID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:AttackWarningGroupID")]
	public int AttackWarningGroupID
	{
		get
		{
			CheckDestroyed();
			if (!AttackWarningGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:AttackWarningGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AttackWarningGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackWarningGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackWarnning:AttackWarningGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AttackWarningGroupID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		WeaponIndex = -1;
		AttackWarningGroupID = -1;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		int fromInstanceID = NotifyParam.FromInstanceID;
		int uniqueID = (int)GetUniqueID();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_AttackWarnningCheckBegin.Invoke(fromInstanceID, AttackWarningGroupID, uniqueID, WeaponIndex, WrapCheckShapeList(NotifyParam.owner), AttackWarnningFixedLocalOffset, ResultFilterType, HitLevel, HitActionDir, TotalDuration, NotifyParam.Animation, NotifyParam.NotifyBeginTime);
		}
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			AttackWarnningCheckPreTransformMap = new Dictionary<int, FUStCheckTransformArray>();
			if (!AttackWarnningCheckPreTransformMap.ContainsKey(fromInstanceID))
			{
				FUStCheckTransformArray value = new FUStCheckTransformArray
				{
					TransformList = new List<FTransform>()
				};
				AttackWarnningCheckPreTransformMap.Add(fromInstanceID, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World) && IsRenderDebugShape)
		{
			AttackWarnningCheckShowDebugInfo(NotifyParam.World, NotifyParam.owner, NotifyParam.FromInstanceID, NotifyParam.MeshComp);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackWarnning:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		int fromInstanceID = NotifyParam.FromInstanceID;
		int uniqueID = (int)GetUniqueID();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_AttackWarnningCheckEnd.Invoke(fromInstanceID, uniqueID);
		}
	}

	private List<FUStCheckShape> WrapCheckShapeList(AActor Owner)
	{
		List<FUStCheckShape> list = new List<FUStCheckShape>();
		if (WeaponIndex < 0)
		{
			foreach (FUStCheckShape item in AttackWarnningCheckShape)
			{
				FUStCheckShape fUStCheckShape = default(FUStCheckShape);
				fUStCheckShape = item;
				fUStCheckShape.SKComp = BGU_ObjActorUtil.GetSocketBelongToSKComp(Owner as ACharacter, item.SocketName);
				list.Add(fUStCheckShape);
			}
		}
		else
		{
			BGUWeaponBase bGUWeaponBase = BGUFunctionLibraryCS.BGUGetWeaponByIndex(Owner, WeaponIndex) as BGUWeaponBase;
			if (bGUWeaponBase != null)
			{
				if (!BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_WeaponCommData, BUC_WeaponCommData>(bGUWeaponBase).bIsActive)
				{
					BGW_LogUtil.LogError("ERROR: Current sweep check will not work as weapon with index " + WeaponIndex + " is not active! Please verify sweep check notifystate!");
					return list;
				}
				foreach (FUStCheckShape item2 in AttackWarnningCheckShape)
				{
					FUStCheckShape fUStCheckShape2 = default(FUStCheckShape);
					fUStCheckShape2 = item2;
					fUStCheckShape2.SKComp = bGUWeaponBase.SkeletalMeshComp;
					list.Add(fUStCheckShape2);
				}
			}
		}
		return list;
	}

	private AActor GSGetActorByTag(UWorld World, FName TagName)
	{
		UGameplayStatics.GetAllActorsOfClass(World, UClass.GetClass<AActor>(), out var OutActors);
		foreach (AActor item in OutActors)
		{
			if (item.ActorHasTag(TagName))
			{
				return item;
			}
		}
		return null;
	}

	private FTransform GetSocketWorldTransform(USkeletalMeshComponent MeshComp, FName SocketName)
	{
		FTransform result = default(FTransform);
		result.SetTranslation(MeshComp.GetSocketLocation(SocketName));
		return result;
	}

	private void InitSetPreCheckTransform(USkeletalMeshComponent MeshComp, List<FTransform> AttackWarnningCheckPreTransform)
	{
		for (int i = 0; i < AttackWarnningCheckShape.Count; i++)
		{
			AttackWarnningCheckPreTransform.Add(GetSocketWorldTransform(MeshComp, AttackWarnningCheckShape[i].SocketName));
		}
	}

	private void AttackWarnningCheckShowDebugInfo(UWorld World, AActor Owner, int FromInstanceID, USkeletalMeshComponent MeshComp)
	{
		if (World == null || Owner == null || !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(World) || !AttackWarnningCheckPreTransformMap.ContainsKey(FromInstanceID))
		{
			return;
		}
		FUStCheckTransformArray fUStCheckTransformArray = new FUStCheckTransformArray
		{
			TransformList = new List<FTransform>()
		};
		fUStCheckTransformArray = AttackWarnningCheckPreTransformMap[FromInstanceID];
		if (fUStCheckTransformArray.TransformList == null)
		{
			return;
		}
		USkeletalMeshComponent uSkeletalMeshComponent = MeshComp;
		if (WeaponIndex == -1)
		{
			uSkeletalMeshComponent = MeshComp;
		}
		else
		{
			FName weapon_ = B1GlobalFNames.weapon_;
			AActor aActor = GSGetActorByTag(World, weapon_);
			if (aActor != null)
			{
				uSkeletalMeshComponent = aActor.GetComponentByClass<USkeletalMeshComponent>();
			}
		}
		if (uSkeletalMeshComponent == null)
		{
			return;
		}
		List<FTransform> list = new List<FTransform>();
		list = fUStCheckTransformArray.TransformList;
		if (list != null && list.Count < 1)
		{
			InitSetPreCheckTransform(uSkeletalMeshComponent, list);
		}
		new List<FUStGSHitResult>();
		for (int i = 0; i < AttackWarnningCheckShape.Count; i++)
		{
			FUStCheckShape fUStCheckShape = AttackWarnningCheckShape[i];
			FTransform fTransform = list[i];
			FTransform socketWorldTransform = GetSocketWorldTransform(uSkeletalMeshComponent, fUStCheckShape.SocketName);
			FTransform fTransform2 = socketWorldTransform;
			if ((socketWorldTransform.GetLocation() - fTransform.GetLocation()).Size() == 0f)
			{
				fTransform2.SetLocation(socketWorldTransform.GetLocation() + FVector.OneVector);
			}
			FGSSweepCheckShapeInfo fGSSweepCheckShapeInfo = new FGSSweepCheckShapeInfo
			{
				SweepCheckShapeType = (fUStCheckShape.IsCapsuleShape ? EGSSweepCheckShapeType.CapsuleShape : EGSSweepCheckShapeType.SphereShape),
				ShapeParamFloat = fUStCheckShape.Radius * Owner.GetActorScale3D().X,
				ShapeParamVector = fUStCheckShape.Scale
			};
			FRotator fRotator = FRotator.MakeFromEuler(fUStCheckShape.Rotation);
			FRotator fRotator2 = socketWorldTransform.Rotation.Rotator();
			FQuat.MakeFromEuler((fRotator + fRotator2).Euler());
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackWarnning:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackWarnning bANS_GSAttackWarnning = GCHelper.Find<b1.BANS_GSAttackWarnning>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAttackWarnning.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackWarnning:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackWarnning bANS_GSAttackWarnning = GCHelper.Find<b1.BANS_GSAttackWarnning>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSAttackWarnning.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackWarnning:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackWarnning bANS_GSAttackWarnning = GCHelper.Find<b1.BANS_GSAttackWarnning>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAttackWarnning.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAttackWarnning");
		NativeReflection.GetPropertyRef(ref HitActionDir_PropertyAddress, intPtr, "HitActionDir");
		HitActionDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitActionDir");
		HitActionDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitActionDir", Classes.FEnumProperty);
		HitLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitLevel");
		HitLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitLevel", Classes.FIntProperty);
		WeaponIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndex");
		WeaponIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AttackWarnningCheckShape_PropertyAddress, intPtr, "AttackWarnningCheckShape");
		AttackWarnningCheckShape_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackWarnningCheckShape");
		AttackWarnningCheckShape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackWarnningCheckShape", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IsRenderDebugShape_PropertyAddress, intPtr, "IsRenderDebugShape");
		IsRenderDebugShape_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRenderDebugShape");
		IsRenderDebugShape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRenderDebugShape", Classes.FBoolProperty);
		AttackWarnningFixedLocalOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackWarnningFixedLocalOffset");
		AttackWarnningFixedLocalOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackWarnningFixedLocalOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ResultFilterType_PropertyAddress, intPtr, "ResultFilterType");
		ResultFilterType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResultFilterType");
		ResultFilterType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResultFilterType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Tags_PropertyAddress, intPtr, "Tags");
		Tags_Offset = NativeReflection.GetPropertyOffset(intPtr, "Tags");
		Tags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Tags", Classes.FArrayProperty);
		AttackWarningGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackWarningGroupID");
		AttackWarningGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackWarningGroupID", Classes.FIntProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackWarnning:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackWarnning:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackWarnning:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAttackWarnning()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAttackWarnning)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAttackWarnning));
	}
}
