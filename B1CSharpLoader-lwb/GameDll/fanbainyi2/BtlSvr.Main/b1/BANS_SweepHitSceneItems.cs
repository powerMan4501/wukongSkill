using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS SweepHit SceneItems")]
[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems")]
internal class BANS_SweepHitSceneItems : BANS_GSBase
{
	private static bool SweepCheckShape_IsValid;

	private static int SweepCheckShape_Offset;

	private static FFieldAddress SweepCheckShape_PropertyAddress;

	private TArrayReadWriteMarshaler<FUStCheckShape> SweepCheckShape_Marshaler;

	private static bool BulletID_IsValid;

	private static int BulletID_Offset;

	private static bool AimType_IsValid;

	private static int AimType_Offset;

	private static FFieldAddress AimType_PropertyAddress;

	private static bool BulletFlySpd_IsValid;

	private static int BulletFlySpd_Offset;

	private static bool AimConstraintAxis_IsValid;

	private static int AimConstraintAxis_Offset;

	private static bool BornDirOffsetX_IsValid;

	private static int BornDirOffsetX_Offset;

	private static bool BornDirOffsetY_IsValid;

	private static int BornDirOffsetY_Offset;

	private static bool BornDirOffsetZ_IsValid;

	private static int BornDirOffsetZ_Offset;

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

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:SweepCheckShape")]
	public TArrayReadWrite<FUStCheckShape> SweepCheckShape
	{
		get
		{
			CheckDestroyed();
			if (!SweepCheckShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:SweepCheckShape");
				return null;
			}
			if (SweepCheckShape_Marshaler == null)
			{
				SweepCheckShape_Marshaler = new TArrayReadWriteMarshaler<FUStCheckShape>(1, SweepCheckShape_PropertyAddress, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.FromNative, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.ToNative);
			}
			return SweepCheckShape_Marshaler.FromNative(IntPtr.Add(base.Address, SweepCheckShape_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnBullet")]
	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:BulletID")]
	public int BulletID
	{
		get
		{
			CheckDestroyed();
			if (!BulletID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BulletID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BulletID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BulletID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BulletID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnBullet")]
	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:AimType")]
	public EAimType AimType
	{
		get
		{
			CheckDestroyed();
			if (!AimType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:AimType");
				return EAimType.NONE;
			}
			return EnumMarshaler<EAimType>.FromNative(IntPtr.Add(base.Address, AimType_Offset), 0, AimType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AimType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:AimType");
			}
			else
			{
				EnumMarshaler<EAimType>.ToNative(IntPtr.Add(base.Address, AimType_Offset), 0, AimType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("SpawnBullet")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:BulletFlySpd")]
	public FSpawnBulletSpeed BulletFlySpd
	{
		get
		{
			CheckDestroyed();
			if (!BulletFlySpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BulletFlySpd");
				return default(FSpawnBulletSpeed);
			}
			return FSpawnBulletSpeed.FromNative(IntPtr.Add(base.Address, BulletFlySpd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletFlySpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BulletFlySpd");
			}
			else
			{
				FSpawnBulletSpeed.ToNative(IntPtr.Add(base.Address, BulletFlySpd_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnBullet")]
	[Tooltip("轴向约束,非0值表示 锁定绕该轴向上的旋转，填0值则可打开对应的偏移旋转")]
	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:AimConstraintAxis")]
	public FVector AimConstraintAxis
	{
		get
		{
			CheckDestroyed();
			if (!AimConstraintAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:AimConstraintAxis");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, AimConstraintAxis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AimConstraintAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:AimConstraintAxis");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, AimConstraintAxis_Offset), value);
			}
		}
	}

	[Category("SpawnBullet")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("绕X轴旋转角度")]
	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:BornDirOffsetX")]
	public FSpawnBulletMinMaxValue BornDirOffsetX
	{
		get
		{
			CheckDestroyed();
			if (!BornDirOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BornDirOffsetX");
				return default(FSpawnBulletMinMaxValue);
			}
			return FSpawnBulletMinMaxValue.FromNative(IntPtr.Add(base.Address, BornDirOffsetX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BornDirOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BornDirOffsetX");
			}
			else
			{
				FSpawnBulletMinMaxValue.ToNative(IntPtr.Add(base.Address, BornDirOffsetX_Offset), value);
			}
		}
	}

	[DisplayName("绕Y轴旋转角度")]
	[Category("SpawnBullet")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:BornDirOffsetY")]
	public FSpawnBulletMinMaxValue BornDirOffsetY
	{
		get
		{
			CheckDestroyed();
			if (!BornDirOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BornDirOffsetY");
				return default(FSpawnBulletMinMaxValue);
			}
			return FSpawnBulletMinMaxValue.FromNative(IntPtr.Add(base.Address, BornDirOffsetY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BornDirOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BornDirOffsetY");
			}
			else
			{
				FSpawnBulletMinMaxValue.ToNative(IntPtr.Add(base.Address, BornDirOffsetY_Offset), value);
			}
		}
	}

	[Category("SpawnBullet")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("绕Z轴旋转角度")]
	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:BornDirOffsetZ")]
	public FSpawnBulletMinMaxValue BornDirOffsetZ
	{
		get
		{
			CheckDestroyed();
			if (!BornDirOffsetZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BornDirOffsetZ");
				return default(FSpawnBulletMinMaxValue);
			}
			return FSpawnBulletMinMaxValue.FromNative(IntPtr.Add(base.Address, BornDirOffsetZ_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BornDirOffsetZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SweepHitSceneItems:BornDirOffsetZ");
			}
			else
			{
				FSpawnBulletMinMaxValue.ToNative(IntPtr.Add(base.Address, BornDirOffsetZ_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner != null))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (!(bUS_GSEventCollection == null))
		{
			List<AActor> list = bUS_GSEventCollection.Evt_OverlapSceneItems.Invoke(SweepCheckShape.ToList());
			if (list != null && list.Count > 0)
			{
				int uniqueID = (int)GetUniqueID();
				FGSProjecttileObjSpawnNSInfo SpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
				WrapSimpleSceneItemBullet(uniqueID, ref SpawnNSInfo, list);
				bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref SpawnNSInfo);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_SweepHitSceneItems:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
	}

	private void WrapSimpleSceneItemBullet(int MontageID, ref FGSProjecttileObjSpawnNSInfo SpawnNSInfo, List<AActor> SceneItems)
	{
		SpawnNSInfo.ProjectileType = EProjectileType.Bullet;
		SpawnNSInfo.BuffIDList = new List<int>();
		SpawnNSInfo.ProjectileID = BulletID;
		SpawnNSInfo.SpawnWave = 1;
		SpawnNSInfo.SpawnNumPerWave = SceneItems.Count;
		SpawnNSInfo.MontageID = MontageID;
		SpawnNSInfo.SpawnWaveDuration = 0f;
		SpawnNSInfo.SpawnCounter = 0;
		SpawnNSInfo.SpawnWaveCounter = 0;
		SpawnNSInfo.ANSTotalTime = 0f;
		SpawnNSInfo.bEnableMultiTargetMode = false;
		SpawnNSInfo.MutilTargetRule = default(FProjectileMulTargetRule);
		SpawnNSInfo.SceneItems = SceneItems;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_SweepHitSceneItems:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_SweepHitSceneItems bANS_SweepHitSceneItems = GCHelper.Find<b1.BANS_SweepHitSceneItems>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_SweepHitSceneItems.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_SweepHitSceneItems:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_SweepHitSceneItems bANS_SweepHitSceneItems = GCHelper.Find<b1.BANS_SweepHitSceneItems>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_SweepHitSceneItems.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_SweepHitSceneItems:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_SweepHitSceneItems bANS_SweepHitSceneItems = GCHelper.Find<b1.BANS_SweepHitSceneItems>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_SweepHitSceneItems.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_SweepHitSceneItems");
		NativeReflection.GetPropertyRef(ref SweepCheckShape_PropertyAddress, intPtr, "SweepCheckShape");
		SweepCheckShape_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepCheckShape");
		SweepCheckShape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepCheckShape", Classes.FArrayProperty);
		BulletID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BulletID");
		BulletID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BulletID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AimType_PropertyAddress, intPtr, "AimType");
		AimType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimType");
		AimType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimType", Classes.FEnumProperty);
		BulletFlySpd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BulletFlySpd");
		BulletFlySpd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BulletFlySpd", Classes.FStructProperty);
		AimConstraintAxis_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimConstraintAxis");
		AimConstraintAxis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimConstraintAxis", Classes.FStructProperty);
		BornDirOffsetX_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDirOffsetX");
		BornDirOffsetX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDirOffsetX", Classes.FStructProperty);
		BornDirOffsetY_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDirOffsetY");
		BornDirOffsetY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDirOffsetY", Classes.FStructProperty);
		BornDirOffsetZ_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDirOffsetZ");
		BornDirOffsetZ_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDirOffsetZ", Classes.FStructProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_SweepHitSceneItems:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_SweepHitSceneItems:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_SweepHitSceneItems:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_SweepHitSceneItems()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_SweepHitSceneItems)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_SweepHitSceneItems));
	}
}
