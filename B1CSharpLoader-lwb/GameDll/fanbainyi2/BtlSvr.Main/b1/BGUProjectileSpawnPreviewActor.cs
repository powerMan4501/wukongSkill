using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor")]
internal class BGUProjectileSpawnPreviewActor : ABGUPlacedEditorUtilityBase
{
	private List<FVector> PointSetCacheMap_RangeSpawnOffset;

	private List<FVector> PointSetCacheMap_RangeTargetOffset;

	private static bool CharacterMesh_IsValid;

	private static int CharacterMesh_Offset;

	private static bool DefaultSpawnPos_IsValid;

	private static int DefaultSpawnPos_Offset;

	private static bool TargetPos_IsValid;

	private static int TargetPos_Offset;

	private static bool ProjectileSpawnConfig_IsValid;

	private static int ProjectileSpawnConfig_Offset;

	private static bool DrawOnce_IsValid;

	private static int DrawOnce_Offset;

	private static FFieldAddress DrawOnce_PropertyAddress;

	private static bool EnableDebugTick_IsValid;

	private static int EnableDebugTick_Offset;

	private static FFieldAddress EnableDebugTick_PropertyAddress;

	private static bool DrawDebugLength_IsValid;

	private static int DrawDebugLength_Offset;

	private static bool DrawDebugDuration_IsValid;

	private static int DrawDebugDuration_Offset;

	private static bool DrawDebugTickness_IsValid;

	private static int DrawDebugTickness_Offset;

	private static bool ArrowSize_IsValid;

	private static int ArrowSize_Offset;

	private static bool ProjectileSize_IsValid;

	private static int ProjectileSize_Offset;

	private static bool SphereSegment_IsValid;

	private static int SphereSegment_Offset;

	private static bool SphereColor_IsValid;

	private static int SphereColor_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:CharacterMesh")]
	public USkeletalMeshComponent CharacterMesh
	{
		get
		{
			CheckDestroyed();
			if (!CharacterMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:CharacterMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, CharacterMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:CharacterMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, CharacterMesh_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DefaultSpawnPos")]
	public USceneComponent DefaultSpawnPos
	{
		get
		{
			CheckDestroyed();
			if (!DefaultSpawnPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DefaultSpawnPos");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultSpawnPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultSpawnPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DefaultSpawnPos");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultSpawnPos_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:TargetPos")]
	public USceneComponent TargetPos
	{
		get
		{
			CheckDestroyed();
			if (!TargetPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:TargetPos");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, TargetPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:TargetPos");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, TargetPos_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ProjectileSpawnConfig")]
	public BGWDataAsset_ProjectileSpawnConfig ProjectileSpawnConfig
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileSpawnConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ProjectileSpawnConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_ProjectileSpawnConfig>.FromNative(IntPtr.Add(base.Address, ProjectileSpawnConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileSpawnConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ProjectileSpawnConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_ProjectileSpawnConfig>.ToNative(IntPtr.Add(base.Address, ProjectileSpawnConfig_Offset), value);
			}
		}
	}

	[DisplayName("绘制一次")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawOnce")]
	public bool DrawOnce
	{
		get
		{
			CheckDestroyed();
			if (!DrawOnce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawOnce");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawOnce_Offset), 0, DrawOnce_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawOnce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawOnce");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawOnce_Offset), 0, DrawOnce_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("持续绘制")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:EnableDebugTick")]
	public bool EnableDebugTick
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebugTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:EnableDebugTick");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebugTick_Offset), 0, EnableDebugTick_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebugTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:EnableDebugTick");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebugTick_Offset), 0, EnableDebugTick_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("Debug线长度")]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawDebugLength")]
	public float DrawDebugLength
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebugLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawDebugLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DrawDebugLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebugLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawDebugLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DrawDebugLength_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Debug显示时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawDebugDuration")]
	public float DrawDebugDuration
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebugDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawDebugDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DrawDebugDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebugDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawDebugDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DrawDebugDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Debug线粗细")]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawDebugTickness")]
	public float DrawDebugTickness
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebugTickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawDebugTickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DrawDebugTickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebugTickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:DrawDebugTickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DrawDebugTickness_Offset), value);
			}
		}
	}

	[DisplayName("Debug箭头大小")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ArrowSize")]
	public float ArrowSize
	{
		get
		{
			CheckDestroyed();
			if (!ArrowSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ArrowSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ArrowSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArrowSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ArrowSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ArrowSize_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("抛射物大小")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ProjectileSize")]
	public float ProjectileSize
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ProjectileSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProjectileSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ProjectileSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProjectileSize_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("SphereSegment")]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:SphereSegment")]
	public int SphereSegment
	{
		get
		{
			CheckDestroyed();
			if (!SphereSegment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:SphereSegment");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SphereSegment_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SphereSegment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:SphereSegment");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SphereSegment_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("球体颜色")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:SphereColor")]
	public FLinearColor SphereColor
	{
		get
		{
			CheckDestroyed();
			if (!SphereColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:SphereColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SphereColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SphereColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:SphereColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SphereColor_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TargetPos = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.TargetPos);
		TargetPos.AttachToComponent(GetRootComponent(), FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		CharacterMesh = initializer.CreateDefaultSubobject<USkeletalMeshComponent>(this, B1GlobalFNames.CharacterMesh);
		CharacterMesh.AttachToComponent(GetRootComponent(), FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		DefaultSpawnPos = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.DefaultSpawnPoint);
		DefaultSpawnPos.AttachToComponent(GetRootComponent(), FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		DrawOnce = false;
		EnableDebugTick = false;
		DrawDebugLength = 1000f;
		DrawDebugTickness = 2f;
		DrawDebugDuration = 2f;
		ArrowSize = 100f;
		ProjectileSize = 50f;
		SphereSegment = 16;
		SphereColor = FLinearColor.Red;
	}

	[USharpPath("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
		if (EnableDebugTick)
		{
			DrawDebug(0f);
		}
		else if (DrawOnce)
		{
			DrawDebug(DrawDebugDuration);
			DrawOnce = false;
		}
	}

	private void DrawDebug(float Duration)
	{
		if (!(ProjectileSpawnConfig == null) && ProjectileSpawnConfig.ProjectileNumInOneWave >= 1 && ProjectileSpawnConfig.ProjectileWave >= 1 && GetSpawnDir(out var SpawnPosList, out var SpawnDirList, out var _) && SpawnPosList.Count == SpawnDirList.Count)
		{
			int num = 255 / ProjectileSpawnConfig.ProjectileWave;
			for (int i = 0; i < SpawnPosList.Count; i++)
			{
				int num2 = (i / ProjectileSpawnConfig.ProjectileWave + 1) * num;
				USystemLibrary.DrawDebugArrow(LineColor: new FLinearColor(num2, num2, num2), WorldContextObject: this, LineStart: SpawnPosList[i], LineEnd: SpawnPosList[i] + SpawnDirList[i].Conv_RotatorToVector() * DrawDebugLength, ArrowSize: ArrowSize, Duration: Duration, Thickness: DrawDebugTickness);
				USystemLibrary.DrawDebugSphere(this, SpawnPosList[i], ProjectileSize, SphereSegment, SphereColor, Duration, DrawDebugTickness);
			}
		}
	}

	public bool GetSpawnDir(out List<FVector> SpawnPosList, out List<FRotator> SpawnDirList, out string Log)
	{
		SpawnDirList = new List<FRotator>();
		SpawnPosList = new List<FVector>();
		Log = string.Empty;
		if (ProjectileSpawnConfig == null)
		{
			Log = "没有配置DA";
			return false;
		}
		USceneComponent uSceneComponent = GetBaseComp(ProjectileSpawnConfig.SpawnBase.BaseType);
		if (uSceneComponent == null)
		{
			uSceneComponent = DefaultSpawnPos;
		}
		USceneComponent uSceneComponent2 = GetBaseComp(ProjectileSpawnConfig.TargetBase.BaseType);
		if (uSceneComponent2 == null)
		{
			uSceneComponent2 = TargetPos;
		}
		List<FVector> spawnPositions_BasePrepare = PrepareSpawnPositions(ProjectileSpawnConfig.SpawnBase.BaseType, uSceneComponent);
		List<FVector> targetPositions_BasePrepare = PrepareSpawnPositions(ProjectileSpawnConfig.TargetBase.BaseType, uSceneComponent2);
		new List<FVector>();
		new List<FVector>();
		for (int i = 0; i < ProjectileSpawnConfig.ProjectileWave; i++)
		{
			int waveIndex = i;
			GetSpawnDirPerWave(waveIndex, spawnPositions_BasePrepare, targetPositions_BasePrepare, out var SpawnPosList2, out var SpawnDirList2, out var _);
			SpawnPosList.AddRange(SpawnPosList2);
			SpawnDirList.AddRange(SpawnDirList2);
		}
		return true;
	}

	public USceneComponent GetBaseComp(ProjectileBaseType BaseType)
	{
		USceneComponent result = null;
		switch (BaseType)
		{
		case ProjectileBaseType.ProjectileSpawner:
		case ProjectileBaseType.EffectCaster:
		case ProjectileBaseType.SceneItemCached:
		case ProjectileBaseType.EffectRootCaster:
		case ProjectileBaseType.LocalPlayer:
			result = DefaultSpawnPos;
			break;
		case ProjectileBaseType.EffectTarget:
		case ProjectileBaseType.CurTarget_ProjectileSpawner:
		case ProjectileBaseType.UseSkillBaseTarget:
			result = TargetPos;
			break;
		}
		return result;
	}

	public void GetSpawnDirPerWave(int WaveIndex, List<FVector> SpawnPositions_BasePrepare, List<FVector> TargetPositions_BasePrepare, out List<FVector> SpawnPosList, out List<FRotator> SpawnDirList, out string Log)
	{
		SpawnDirList = new List<FRotator>();
		SpawnPosList = new List<FVector>();
		Log = string.Empty;
		PointSetCacheMap_RangeTargetOffset = new List<FVector>();
		PointSetCacheMap_RangeSpawnOffset = new List<FVector>();
		USceneComponent baseComp = GetBaseComp(ProjectileSpawnConfig.SpawnPosOffsetInfo.BaseType);
		USceneComponent baseComp2 = GetBaseComp(ProjectileSpawnConfig.TargetPosOffsetInfo.BaseType);
		for (int i = 0; i < ProjectileSpawnConfig.ProjectileNumInOneWave; i++)
		{
			int num = i;
			int num2 = WaveIndex * ProjectileSpawnConfig.ProjectileNumInOneWave + num;
			FGSTargetOffsetInfo offsetInfo = new FGSTargetOffsetInfo(ProjectileSpawnConfig.SpawnPosOffsetInfo);
			FGSTargetOffsetInfo offsetInfo2 = new FGSTargetOffsetInfo(ProjectileSpawnConfig.TargetPosOffsetInfo);
			FVector basePos = GetBasePos(TargetPositions_BasePrepare, ref PointSetCacheMap_RangeTargetOffset, offsetInfo2, baseComp2, num2);
			FVector basePos2 = GetBasePos(SpawnPositions_BasePrepare, ref PointSetCacheMap_RangeSpawnOffset, offsetInfo, baseComp, num2);
			FRotator projectileBornDir = GetProjectileBornDir(basePos2, basePos, num2);
			SpawnPosList.Add(basePos2);
			SpawnDirList.Add(projectileBornDir);
		}
	}

	public List<FVector> PrepareSpawnPositions(ProjectileBaseType BaseType, USceneComponent BaseComp)
	{
		List<FVector> list = new List<FVector>();
		if (BaseComp != null && BaseType != ProjectileBaseType.UsePointSetCached && BaseType != ProjectileBaseType.UseEQSPoint)
		{
			BaseComp.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
			if (Children.Count > 0)
			{
				foreach (USceneComponent item in Children)
				{
					list.Add(item.GetWorldLocation());
				}
			}
			else
			{
				list.Add(BaseComp.GetWorldLocation());
			}
		}
		return list;
	}

	public FVector GetBasePos(List<FVector> Positions_BasePrepare, ref List<FVector> RangeOffsetList, FGSTargetOffsetInfo OffsetInfo, USceneComponent OffsetBaseComp, int Index)
	{
		FVector fVector = FVector.ZeroVector;
		if (Positions_BasePrepare != null && Positions_BasePrepare.Count > 0)
		{
			fVector = ((Positions_BasePrepare.Count > Index) ? Positions_BasePrepare[Index] : Positions_BasePrepare[Positions_BasePrepare.Count - 1]);
		}
		return fVector + GetOffset(OffsetInfo, ref RangeOffsetList, OffsetBaseComp);
	}

	public FVector GetOffset(FGSTargetOffsetInfo OffsetInfo, ref List<FVector> RangeOffsetList, USceneComponent OffsetBaseComp)
	{
		FVector fVector = FVector.ZeroVector;
		switch (OffsetInfo.PosOffsetType)
		{
		case ProjectilePosOffsetType.Normal:
			fVector = OffsetInfo.PosOffset;
			break;
		case ProjectilePosOffsetType.RandomOffset:
			fVector.X = MathLib.RandomFloatInRange(0f - OffsetInfo.PosOffset.X, OffsetInfo.PosOffset.X);
			fVector.Y = MathLib.RandomFloatInRange(0f - OffsetInfo.PosOffset.Y, OffsetInfo.PosOffset.Y);
			fVector.Z = MathLib.RandomFloatInRange(0f - OffsetInfo.PosOffset.Z, OffsetInfo.PosOffset.Z);
			break;
		case ProjectilePosOffsetType.RangeOffset:
		{
			if (OffsetInfo.HasCachedRangeOffset)
			{
				fVector = OffsetInfo.CachedRangeOffset;
				break;
			}
			List<FVector> list = new List<FVector>();
			if (RangeOffsetList == null)
			{
				RangeOffsetList = new List<FVector>();
			}
			list = ((RangeOffsetList.Count >= 1) ? RangeOffsetList : b1.BGUProjectileFuncLib.GetPointsInRangeArea(OffsetInfo.RangeOffsetInfo, FVector.ZeroVector));
			if (list.Count > 0)
			{
				int index = MathLib.RandomIntInRange(0, list.Count - 1);
				fVector = list[index];
				OffsetInfo.HasCachedRangeOffset = true;
				OffsetInfo.CachedRangeOffset = fVector;
				list.RemoveAt(index);
				RangeOffsetList = list;
			}
			break;
		}
		}
		FVector result = fVector;
		AActor obj = OffsetInfo.BaseActor.Get();
		ProjectilePosOffsetSpace offsetSpace = OffsetInfo.OffsetSpace;
		if (offsetSpace != ProjectilePosOffsetSpace.WorldSpace && offsetSpace - 1 <= ProjectilePosOffsetSpace.BaseActorLocalSpace)
		{
			if (!obj.IsNullOrDestroyed())
			{
				FTransform worldTransform = OffsetBaseComp.GetWorldTransform();
				result = worldTransform.TransformPositionNoScale(fVector) - worldTransform.GetLocation();
			}
			else
			{
				result = FVector.ZeroVector;
			}
		}
		result.Z += OffsetInfo.VerticalOffset_World;
		return result;
	}

	private FRotator GetProjectileBornDir(FVector BornPos, FVector CurTargetPos, int BornIndex)
	{
		FRotator result = default(FRotator);
		switch (ProjectileSpawnConfig.BornDirBaseInfo.BornDirType)
		{
		case ProjectileBornDirType.UseSlotDir:
		case ProjectileBornDirType.BaseActorRot:
		{
			USceneComponent uSceneComponent = GetBaseComp(ProjectileSpawnConfig.SpawnBase.BaseType);
			if (uSceneComponent == null)
			{
				uSceneComponent = DefaultSpawnPos;
			}
			result = uSceneComponent.GetWorldRotation();
			break;
		}
		case ProjectileBornDirType.LookAtTargetPos:
			result = UMathLibrary.FindLookAtRotation(BornPos, CurTargetPos);
			break;
		}
		ProjectileBornDirOffsetStruct bornDirOffset = ProjectileSpawnConfig.BornDirOffset;
		int projectileNumInOneWave = ProjectileSpawnConfig.ProjectileNumInOneWave;
		if (bornDirOffset.AimConstraintAxis.X == 0f)
		{
			float num = CalcRotOffsetValue(BornIndex + 1, projectileNumInOneWave, bornDirOffset.BornDirOffsetX.IsEquidistance, bornDirOffset.BornDirOffsetX.LeftValue, bornDirOffset.BornDirOffsetX.RightValue);
			result.Roll += num;
		}
		if (bornDirOffset.AimConstraintAxis.Y == 0f)
		{
			float num2 = CalcRotOffsetValue(BornIndex + 1, projectileNumInOneWave, bornDirOffset.BornDirOffsetY.IsEquidistance, bornDirOffset.BornDirOffsetY.LeftValue, bornDirOffset.BornDirOffsetY.RightValue);
			result.Pitch += num2;
		}
		if (bornDirOffset.AimConstraintAxis.Z == 0f)
		{
			float num3 = CalcRotOffsetValue(BornIndex + 1, projectileNumInOneWave, bornDirOffset.BornDirOffsetZ.IsEquidistance, bornDirOffset.BornDirOffsetZ.LeftValue, bornDirOffset.BornDirOffsetZ.RightValue);
			result.Yaw += num3;
		}
		return result;
	}

	private float CalcRotOffsetValue(int SpawnBulletCounter, int BulletNumInOneWave, bool IsEquidDis, float LeftValue, float RightValue)
	{
		if (!IsEquidDis)
		{
			return UB1Util.GetRandomNumberFloat(LeftValue, RightValue);
		}
		int num = SpawnBulletCounter - 1;
		int num2 = BulletNumInOneWave - 1;
		if (BulletNumInOneWave == 1)
		{
			num = 0;
			num2 = 2;
		}
		return LeftValue + (float)num * (RightValue - LeftValue) / (float)num2;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUProjectileSpawnPreviewActor bGUProjectileSpawnPreviewActor = GCHelper.Find<b1.BGUProjectileSpawnPreviewActor>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGUProjectileSpawnPreviewActor.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUProjectileSpawnPreviewActor");
		CharacterMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "CharacterMesh");
		CharacterMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CharacterMesh", Classes.FObjectProperty);
		DefaultSpawnPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultSpawnPos");
		DefaultSpawnPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultSpawnPos", Classes.FObjectProperty);
		TargetPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetPos");
		TargetPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetPos", Classes.FObjectProperty);
		ProjectileSpawnConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileSpawnConfig");
		ProjectileSpawnConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileSpawnConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DrawOnce_PropertyAddress, intPtr, "DrawOnce");
		DrawOnce_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrawOnce");
		DrawOnce_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrawOnce", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableDebugTick_PropertyAddress, intPtr, "EnableDebugTick");
		EnableDebugTick_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDebugTick");
		EnableDebugTick_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDebugTick", Classes.FBoolProperty);
		DrawDebugLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrawDebugLength");
		DrawDebugLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrawDebugLength", Classes.FFloatProperty);
		DrawDebugDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrawDebugDuration");
		DrawDebugDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrawDebugDuration", Classes.FFloatProperty);
		DrawDebugTickness_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrawDebugTickness");
		DrawDebugTickness_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrawDebugTickness", Classes.FFloatProperty);
		ArrowSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArrowSize");
		ArrowSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArrowSize", Classes.FFloatProperty);
		ProjectileSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileSize");
		ProjectileSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileSize", Classes.FFloatProperty);
		SphereSegment_Offset = NativeReflection.GetPropertyOffset(intPtr, "SphereSegment");
		SphereSegment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SphereSegment", Classes.FIntProperty);
		SphereColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SphereColor");
		SphereColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SphereColor", Classes.FStructProperty);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProjectileSpawnPreviewActor:ReceiveTick", ReceiveTick_IsValid);
	}

	static BGUProjectileSpawnPreviewActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUProjectileSpawnPreviewActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUProjectileSpawnPreviewActor));
	}
}
