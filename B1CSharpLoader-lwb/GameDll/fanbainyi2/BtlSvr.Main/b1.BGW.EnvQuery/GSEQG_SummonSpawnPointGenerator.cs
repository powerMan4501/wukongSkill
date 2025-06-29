using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UClass]
[DisplayName("GS EQG Summon Spawn Point")]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator")]
public class GSEQG_SummonSpawnPointGenerator : UGSEQGBase_ProjectedPoint
{
	private FVector ContextTemp;

	private static bool GeneratedVectorOffset_IsValid;

	private static int GeneratedVectorOffset_Offset;

	private static bool IsRandomOPSpawn_IsValid;

	private static int IsRandomOPSpawn_Offset;

	private static FFieldAddress IsRandomOPSpawn_PropertyAddress;

	private static bool IsForwardOPSpawn_IsValid;

	private static int IsForwardOPSpawn_Offset;

	private static FFieldAddress IsForwardOPSpawn_PropertyAddress;

	private static bool SpawnPointNum_IsValid;

	private static int SpawnPointNum_Offset;

	private static bool MinFaceToBlockDis_IsValid;

	private static int MinFaceToBlockDis_Offset;

	private static bool IsRandomSpawnPointInHorizontal_IsValid;

	private static int IsRandomSpawnPointInHorizontal_Offset;

	private static FFieldAddress IsRandomSpawnPointInHorizontal_PropertyAddress;

	private static bool IsRandomSpawnPointInVertical_IsValid;

	private static int IsRandomSpawnPointInVertical_Offset;

	private static FFieldAddress IsRandomSpawnPointInVertical_PropertyAddress;

	private static bool EnableDebug_IsValid;

	private static int EnableDebug_Offset;

	private static FFieldAddress EnableDebug_PropertyAddress;

	private static bool ForwardSpawnOuterRadius_IsValid;

	private static int ForwardSpawnOuterRadius_Offset;

	private static bool ForwardSpawnInnerRadius_IsValid;

	private static int ForwardSpawnInnerRadius_Offset;

	private static bool ForwardSpawnAngle_IsValid;

	private static int ForwardSpawnAngle_Offset;

	private static bool CircleSpawnOuterRadius_IsValid;

	private static int CircleSpawnOuterRadius_Offset;

	private static bool CircleSpawnInnerRadius_IsValid;

	private static int CircleSpawnInnerRadius_Offset;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成点偏移值")]
	[Category("Common")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:GeneratedVectorOffset")]
	public FVector GeneratedVectorOffset
	{
		get
		{
			CheckDestroyed();
			if (!GeneratedVectorOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:GeneratedVectorOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, GeneratedVectorOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GeneratedVectorOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:GeneratedVectorOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, GeneratedVectorOffset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Common")]
	[DisplayName("选择随机生成方式")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsRandomOPSpawn")]
	public bool IsRandomOPSpawn
	{
		get
		{
			CheckDestroyed();
			if (!IsRandomOPSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsRandomOPSpawn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRandomOPSpawn_Offset), 0, IsRandomOPSpawn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRandomOPSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsRandomOPSpawn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRandomOPSpawn_Offset), 0, IsRandomOPSpawn_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!IsRandomOPSpawn")]
	[Category("Common")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("选择前向生成方式")]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsForwardOPSpawn")]
	public bool IsForwardOPSpawn
	{
		get
		{
			CheckDestroyed();
			if (!IsForwardOPSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsForwardOPSpawn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsForwardOPSpawn_Offset), 0, IsForwardOPSpawn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsForwardOPSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsForwardOPSpawn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsForwardOPSpawn_Offset), 0, IsForwardOPSpawn_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("生成点数量")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:SpawnPointNum")]
	public int SpawnPointNum
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:SpawnPointNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpawnPointNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:SpawnPointNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpawnPointNum_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Common")]
	[DisplayName("面向阻挡最短距离")]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:MinFaceToBlockDis")]
	public float MinFaceToBlockDis
	{
		get
		{
			CheckDestroyed();
			if (!MinFaceToBlockDis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:MinFaceToBlockDis");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinFaceToBlockDis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinFaceToBlockDis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:MinFaceToBlockDis");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinFaceToBlockDis_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("是否横向随机生成点")]
	[Category("Common")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsRandomSpawnPointInHorizontal")]
	public bool IsRandomSpawnPointInHorizontal
	{
		get
		{
			CheckDestroyed();
			if (!IsRandomSpawnPointInHorizontal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsRandomSpawnPointInHorizontal");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRandomSpawnPointInHorizontal_Offset), 0, IsRandomSpawnPointInHorizontal_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRandomSpawnPointInHorizontal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsRandomSpawnPointInHorizontal");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRandomSpawnPointInHorizontal_Offset), 0, IsRandomSpawnPointInHorizontal_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Common")]
	[DisplayName("是否纵向随机生成点")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsRandomSpawnPointInVertical")]
	public bool IsRandomSpawnPointInVertical
	{
		get
		{
			CheckDestroyed();
			if (!IsRandomSpawnPointInVertical_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsRandomSpawnPointInVertical");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRandomSpawnPointInVertical_Offset), 0, IsRandomSpawnPointInVertical_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRandomSpawnPointInVertical_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:IsRandomSpawnPointInVertical");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRandomSpawnPointInVertical_Offset), 0, IsRandomSpawnPointInVertical_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Common")]
	[UProperty]
	[DisplayName("是否打开Debug")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:EnableDebug")]
	public bool EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:EnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("ForwardSpawn")]
	[DisplayName("前向生成外半径")]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "IsRandomOPSpawn || IsForwardOPSpawn")]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:ForwardSpawnOuterRadius")]
	public float ForwardSpawnOuterRadius
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSpawnOuterRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:ForwardSpawnOuterRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ForwardSpawnOuterRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSpawnOuterRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:ForwardSpawnOuterRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ForwardSpawnOuterRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "IsRandomOPSpawn || IsForwardOPSpawn")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("ForwardSpawn")]
	[DisplayName("前向生成内半径")]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:ForwardSpawnInnerRadius")]
	public float ForwardSpawnInnerRadius
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSpawnInnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:ForwardSpawnInnerRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ForwardSpawnInnerRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSpawnInnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:ForwardSpawnInnerRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ForwardSpawnInnerRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("前向生成角度")]
	[Category("ForwardSpawn")]
	[UMeta(MDProp.EditCondition, "IsRandomOPSpawn || IsForwardOPSpawn")]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:ForwardSpawnAngle")]
	public float ForwardSpawnAngle
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSpawnAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:ForwardSpawnAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ForwardSpawnAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSpawnAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:ForwardSpawnAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ForwardSpawnAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "IsRandomOPSpawn || !IsForwardOPSpawn")]
	[EditAnywhere]
	[Category("CircleSpawn")]
	[DisplayName("圆形生成外半径")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:CircleSpawnOuterRadius")]
	public float CircleSpawnOuterRadius
	{
		get
		{
			CheckDestroyed();
			if (!CircleSpawnOuterRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:CircleSpawnOuterRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CircleSpawnOuterRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircleSpawnOuterRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:CircleSpawnOuterRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CircleSpawnOuterRadius_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "IsRandomOPSpawn || !IsForwardOPSpawn")]
	[UProperty]
	[DisplayName("圆形生成内半径")]
	[Category("CircleSpawn")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:CircleSpawnInnerRadius")]
	public float CircleSpawnInnerRadius
	{
		get
		{
			CheckDestroyed();
			if (!CircleSpawnInnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:CircleSpawnInnerRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CircleSpawnInnerRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircleSpawnInnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:CircleSpawnInnerRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CircleSpawnInnerRadius_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		AActor aActor = GetQuerier() as AActor;
		if (aActor == null || SpawnPointNum <= 0)
		{
			return;
		}
		FVector fVector = ContextLocations[0];
		FVector actorForwardVector = aActor.GetActorForwardVector();
		FVector startTrace = fVector;
		FVector endTrace = fVector + actorForwardVector * MinFaceToBlockDis;
		bool flag = false;
		if (UBGUSelectUtil.LineTraceSimple(aActor, startTrace, endTrace, ETraceTypeQuery.TraceTypeQuery1, EnableDebug, out var HitResult, null) > 0)
		{
			AActor hitActor = HitResult.HitActor;
			BGUCharacterCS bGUCharacterCS = hitActor as BGUCharacterCS;
			BGUActorBaseCS bGUActorBaseCS = hitActor as BGUActorBaseCS;
			if (bGUCharacterCS == null && bGUActorBaseCS == null)
			{
				flag = true;
				CalcForwardPoint(IsFront: false, fVector);
			}
		}
		if (!flag)
		{
			CalcSpawnPoints(fVector);
		}
	}

	private void CalcSpawnPoints(FVector QuerierActorLocation)
	{
		if (IsRandomOPSpawn ? (UB1Util.GetRandomNumberInt(1, 2) % 2 == 0) : IsForwardOPSpawn)
		{
			CalcForwardPoint(IsFront: true, QuerierActorLocation);
		}
		else
		{
			CalcCirclePoint(QuerierActorLocation);
		}
	}

	private void CalcCirclePoint(FVector QuerierLocation)
	{
		AActor aActor = GetQuerier() as AActor;
		if (aActor == null)
		{
			return;
		}
		FVector actorForwardVector = aActor.GetActorForwardVector();
		float eachChunkAngle = 360 / SpawnPointNum;
		List<FVector> list = new List<FVector>();
		for (int i = 1; i <= SpawnPointNum; i++)
		{
			if (GetLocatedPosition(QuerierLocation, eachChunkAngle, i, actorForwardVector, CircleSpawnInnerRadius, CircleSpawnOuterRadius, out var LocatedPosition))
			{
				list.Add(LocatedPosition);
			}
		}
		CalcResultPoint(list);
	}

	private void CalcForwardPoint(bool IsFront, FVector QuerierLocation)
	{
		AActor aActor = GetQuerier() as AActor;
		if (aActor == null)
		{
			return;
		}
		FVector actorForwardVector = aActor.GetActorForwardVector();
		FVector fVector = MathLib.RotateAngleAxis(actorForwardVector, ForwardSpawnAngle / 2f, -1.0 * FVector.UpVector);
		float eachChunkAngle = ForwardSpawnAngle / (float)(SpawnPointNum - 1);
		List<FVector> list = new List<FVector>();
		for (int i = 1; i <= SpawnPointNum; i++)
		{
			if (GetLocatedPosition(QuerierLocation, eachChunkAngle, i - 1, IsFront ? fVector : (fVector * -1.0), ForwardSpawnInnerRadius, ForwardSpawnOuterRadius, out var LocatedPosition))
			{
				list.Add(LocatedPosition);
			}
		}
		CalcResultPoint(list);
	}

	private void CalcResultPoint(List<FVector> FirstGenPoints)
	{
		AActor aActor = GetQuerier() as AActor;
		if (aActor == null)
		{
			return;
		}
		List<FVector> points = FirstGenPoints;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
		List<FVector> list = ProjectAndFilterNavPointsInCS(new List<FVector> { fVector });
		FirstGenPoints = RunNavRaycastsInCS(points, (list.Count > 0) ? list[0] : fVector);
		foreach (FVector FirstGenPoint in FirstGenPoints)
		{
			base.GenerateItemList.Add(FirstGenPoint + GeneratedVectorOffset);
		}
	}

	private bool GetLocatedPosition(FVector QuerierLocation, float EachChunkAngle, int Index, FVector DirVec, float InnerRadius, float OuterRadius, out FVector LocatedPosition)
	{
		LocatedPosition = FVector.ZeroVector;
		if (GetQuerier() as AActor == null)
		{
			return false;
		}
		float num = EachChunkAngle / 2f;
		float num2 = (IsRandomSpawnPointInVertical ? UB1Util.GetRandomNumberFloat(InnerRadius, OuterRadius) : ((InnerRadius + OuterRadius) / 2f));
		float angleDeg = (IsRandomSpawnPointInHorizontal ? UB1Util.GetRandomNumberFloat(EachChunkAngle - num, EachChunkAngle + num) : EachChunkAngle) * (float)Index;
		FVector fVector = MathLib.RotateAngleAxis(DirVec, angleDeg, FVector.UpVector);
		LocatedPosition = fVector * num2 + QuerierLocation;
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQG_SummonSpawnPointGenerator gSEQG_SummonSpawnPointGenerator = GCHelper.Find<GSEQG_SummonSpawnPointGenerator>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_SummonSpawnPointGenerator.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator");
		GeneratedVectorOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "GeneratedVectorOffset");
		GeneratedVectorOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GeneratedVectorOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IsRandomOPSpawn_PropertyAddress, intPtr, "IsRandomOPSpawn");
		IsRandomOPSpawn_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRandomOPSpawn");
		IsRandomOPSpawn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRandomOPSpawn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsForwardOPSpawn_PropertyAddress, intPtr, "IsForwardOPSpawn");
		IsForwardOPSpawn_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsForwardOPSpawn");
		IsForwardOPSpawn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsForwardOPSpawn", Classes.FBoolProperty);
		SpawnPointNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPointNum");
		SpawnPointNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPointNum", Classes.FIntProperty);
		MinFaceToBlockDis_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinFaceToBlockDis");
		MinFaceToBlockDis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinFaceToBlockDis", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsRandomSpawnPointInHorizontal_PropertyAddress, intPtr, "IsRandomSpawnPointInHorizontal");
		IsRandomSpawnPointInHorizontal_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRandomSpawnPointInHorizontal");
		IsRandomSpawnPointInHorizontal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRandomSpawnPointInHorizontal", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsRandomSpawnPointInVertical_PropertyAddress, intPtr, "IsRandomSpawnPointInVertical");
		IsRandomSpawnPointInVertical_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRandomSpawnPointInVertical");
		IsRandomSpawnPointInVertical_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRandomSpawnPointInVertical", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, intPtr, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDebug", Classes.FBoolProperty);
		ForwardSpawnOuterRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardSpawnOuterRadius");
		ForwardSpawnOuterRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardSpawnOuterRadius", Classes.FFloatProperty);
		ForwardSpawnInnerRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardSpawnInnerRadius");
		ForwardSpawnInnerRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardSpawnInnerRadius", Classes.FFloatProperty);
		ForwardSpawnAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardSpawnAngle");
		ForwardSpawnAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardSpawnAngle", Classes.FFloatProperty);
		CircleSpawnOuterRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "CircleSpawnOuterRadius");
		CircleSpawnOuterRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CircleSpawnOuterRadius", Classes.FFloatProperty);
		CircleSpawnInnerRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "CircleSpawnInnerRadius");
		CircleSpawnInnerRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CircleSpawnInnerRadius", Classes.FFloatProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_SummonSpawnPointGenerator:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_SummonSpawnPointGenerator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQG_SummonSpawnPointGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQG_SummonSpawnPointGenerator));
	}
}
