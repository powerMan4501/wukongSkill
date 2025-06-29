using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("GS EQG SyncAnimation Guest Point")]
[USharpPath("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator")]
internal class GSEQG_SyncAnimationGuestPointGenerator : UGSEQGBase_ProjectedPoint
{
	private static bool StartSyncGuestDistance_IsValid;

	private static int StartSyncGuestDistance_Offset;

	private static bool BeforeSyncGuestMoveDistance_IsValid;

	private static int BeforeSyncGuestMoveDistance_Offset;

	private static bool CirclePointsCount_IsValid;

	private static int CirclePointsCount_Offset;

	private static bool GuestUnitGuid_IsValid;

	private static int GuestUnitGuid_Offset;

	private static bool AngleCostWeight_IsValid;

	private static int AngleCostWeight_Offset;

	private static bool DistanceCostWeight_IsValid;

	private static int DistanceCostWeight_Offset;

	private static bool bDrawDebug_IsValid;

	private static int bDrawDebug_Offset;

	private static FFieldAddress bDrawDebug_PropertyAddress;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[EditAnywhere]
	[Category("Common")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:StartSyncGuestDistance")]
	public float StartSyncGuestDistance
	{
		get
		{
			CheckDestroyed();
			if (!StartSyncGuestDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:StartSyncGuestDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartSyncGuestDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartSyncGuestDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:StartSyncGuestDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartSyncGuestDistance_Offset), value);
			}
		}
	}

	[Category("Common")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:BeforeSyncGuestMoveDistance")]
	public float BeforeSyncGuestMoveDistance
	{
		get
		{
			CheckDestroyed();
			if (!BeforeSyncGuestMoveDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:BeforeSyncGuestMoveDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeforeSyncGuestMoveDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeforeSyncGuestMoveDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:BeforeSyncGuestMoveDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeforeSyncGuestMoveDistance_Offset), value);
			}
		}
	}

	[Category("Common")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:CirclePointsCount")]
	public int CirclePointsCount
	{
		get
		{
			CheckDestroyed();
			if (!CirclePointsCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:CirclePointsCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CirclePointsCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CirclePointsCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:CirclePointsCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CirclePointsCount_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:GuestUnitGuid")]
	public string GuestUnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!GuestUnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:GuestUnitGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, GuestUnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GuestUnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:GuestUnitGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, GuestUnitGuid_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Common")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:AngleCostWeight")]
	public float AngleCostWeight
	{
		get
		{
			CheckDestroyed();
			if (!AngleCostWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:AngleCostWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngleCostWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleCostWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:AngleCostWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngleCostWeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:DistanceCostWeight")]
	public float DistanceCostWeight
	{
		get
		{
			CheckDestroyed();
			if (!DistanceCostWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:DistanceCostWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceCostWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceCostWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:DistanceCostWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceCostWeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Debug")]
	[USharpPath("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:bDrawDebug")]
	public bool bDrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:bDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:bDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		StartSyncGuestDistance = 1000f;
		BeforeSyncGuestMoveDistance = 1000f;
		CirclePointsCount = 36;
		AngleCostWeight = 1f;
		DistanceCostWeight = 1f;
		bDrawDebug = false;
	}

	[USharpPath("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		AActor aActor = GetQuerier() as AActor;
		if (aActor == null)
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(aActor, GuestUnitGuid);
		if (actorByGuid == null)
		{
			return;
		}
		base.GenerateItemList.Clear();
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
		if (StartSyncGuestDistance <= 5f)
		{
			base.GenerateItemList.Add(fVector);
			return;
		}
		FVector actorForwardVector = aActor.GetActorForwardVector();
		float num = 360f / (float)CirclePointsCount;
		float num2 = float.MaxValue;
		FVector fVector2 = actorForwardVector * StartSyncGuestDistance;
		FVector fVector3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByGuid);
		FVector fVector4 = actorForwardVector;
		for (int i = 0; i < CirclePointsCount; i++)
		{
			FVector PointLocation = fVector + fVector4 * StartSyncGuestDistance;
			fVector4 = fVector4.RotateAngleAxis(num, FVector.UpVector);
			if (!RunTraceTest(aActor, in PointLocation) && !(GetNavProjectionDistance(aActor, in PointLocation) > 200f))
			{
				float num3 = (fVector3 - PointLocation).Size();
				float num4 = MathLib.DegAcos(FVector.DotProduct((fVector3 - PointLocation).GetSafeNormal(), (fVector - PointLocation).GetSafeNormal()));
				float num5 = (180f - num4) / 180f;
				float num6 = ((num3 >= BeforeSyncGuestMoveDistance) ? ((num3 - BeforeSyncGuestMoveDistance) / BeforeSyncGuestMoveDistance) : ((BeforeSyncGuestMoveDistance - num3) / BeforeSyncGuestMoveDistance * 3f));
				float num7 = num5 * AngleCostWeight + num6 * DistanceCostWeight;
				if (num7 < num2)
				{
					num2 = num7;
					fVector2 = PointLocation;
				}
				if (bDrawDebug)
				{
					USystemLibrary.DrawDebugSphere(aActor, PointLocation, 20f, 8, FLinearColor.Red, 30f, 2f);
					USystemLibrary.DrawDebugString(aActor, PointLocation, $"Dis: {num3}, Angle: {num4}, AngleCost: {num5}, DisCost: {num6}, Cost: {num7}", null, FLinearColor.Green, 30f);
				}
			}
		}
		if (bDrawDebug)
		{
			USystemLibrary.DrawDebugSphere(aActor, fVector2, 40f, 8, FLinearColor.Green, 30f, 2f);
		}
		base.GenerateItemList.Add(fVector2);
	}

	private bool RunTraceTest(AActor Querier, in FVector PointLocation)
	{
		FHitResultSimple HitResult;
		return UBGUSelectUtil.LineTraceSimple(Querier, BGUFuncLibActorTransformCS.BGUGetActorLocation(Querier), PointLocation, ETraceTypeQuery.TraceTypeQuery1, bDebug: false, out HitResult, new List<AActor>()) == 1;
	}

	private float GetNavProjectionDistance(AActor Querier, in FVector PointLocation)
	{
		float result = float.MaxValue;
		if (UBGUFunctionLibrary.BGUProjectPointToNavigation(Querier, PointLocation, out var ProjectedLocation, null, null, new FVector(50.0, 50.0, 200.0)))
		{
			result = FMath.Abs(ProjectedLocation.Z - PointLocation.Z);
		}
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.GSEQG_SyncAnimationGuestPointGenerator gSEQG_SyncAnimationGuestPointGenerator = GCHelper.Find<b1.GSEQG_SyncAnimationGuestPointGenerator>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_SyncAnimationGuestPointGenerator.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator");
		StartSyncGuestDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartSyncGuestDistance");
		StartSyncGuestDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartSyncGuestDistance", Classes.FFloatProperty);
		BeforeSyncGuestMoveDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeforeSyncGuestMoveDistance");
		BeforeSyncGuestMoveDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeforeSyncGuestMoveDistance", Classes.FFloatProperty);
		CirclePointsCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "CirclePointsCount");
		CirclePointsCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CirclePointsCount", Classes.FIntProperty);
		GuestUnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "GuestUnitGuid");
		GuestUnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GuestUnitGuid", Classes.FStrProperty);
		AngleCostWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "AngleCostWeight");
		AngleCostWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AngleCostWeight", Classes.FFloatProperty);
		DistanceCostWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceCostWeight");
		DistanceCostWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceCostWeight", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bDrawDebug_PropertyAddress, intPtr, "bDrawDebug");
		bDrawDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDrawDebug");
		bDrawDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDrawDebug", Classes.FBoolProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_SyncAnimationGuestPointGenerator:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_SyncAnimationGuestPointGenerator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.GSEQG_SyncAnimationGuestPointGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.GSEQG_SyncAnimationGuestPointGenerator));
	}
}
