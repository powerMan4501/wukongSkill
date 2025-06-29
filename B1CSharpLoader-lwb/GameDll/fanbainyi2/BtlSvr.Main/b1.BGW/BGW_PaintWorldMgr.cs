using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PaintWorldMgr")]
public class BGW_PaintWorldMgr : GameInstanceSystemBaseUObj
{
	protected static readonly FName PaintWorldLevelPath;

	protected static readonly FName PaintWorldViewLevelName;

	protected static readonly FName PaintWorldPosTag;

	protected static readonly FName PaintWorldStartTag;

	protected FVector LevelLoc = new FVector(39999.0, 39999.0, 39999.0);

	public bool IsSceneLoaded { get; private set; }

	public static BGW_PaintWorldMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_PaintWorldMgr>(Context);
	}

	public void LoadLevel()
	{
		if (!UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).IsNullOrDestroyed())
		{
			UGameplayStatics.GetAllActorsWithTag(this, PaintWorldPosTag, out var OutActors);
			if (OutActors.Count > 0)
			{
				LevelLoc = OutActors[0].GetActorLocation();
			}
			BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(this);
			FName levelPackageName = bGW_LevelStreamingManger.AddLevelStreaming(PaintWorldLevelPath, LevelLoc, new FRotator(0.0, 0.0, 0.0), bShouldBlockOnLoad: true);
			bGW_LevelStreamingManger.LoadLevelStreaming(levelPackageName, OnLevelLoaded, bMakeVisibleAfterLoad: true, bShouldBlockOnLoad: true);
			UBGUFunctionLibrary.BGUUpdateLevelStreaming(UGSE_EngineFuncLib.GetWorldFromObj(this));
			UBGUFunctionLibrary.BGUProcessLatentActions(this, bGW_LevelStreamingManger, 0f);
		}
	}

	private void OnLevelLoaded(FName LevelName, int State)
	{
		IsSceneLoaded = true;
	}

	public void UnloadLevel()
	{
		BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(this);
		if (bGW_LevelStreamingManger != null)
		{
			bGW_LevelStreamingManger.ResumeAllLevelDistanceStreaming();
			bGW_LevelStreamingManger.RemoveLevelStreaming(PaintWorldLevelPath);
			IsSceneLoaded = false;
		}
	}

	public bool GetPlayerStart(out FTransform Transform)
	{
		Transform = FTransform.Default;
		UGameplayStatics.GetAllActorsWithTag(this, PaintWorldStartTag, out var OutActors);
		if (OutActors.Count > 0)
		{
			Transform = OutActors[0].GetActorTransform();
			return true;
		}
		APlayerStart[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<APlayerStart>(this);
		if (allActorsOfClass != null && allActorsOfClass.Length != 0)
		{
			for (int i = 0; i < allActorsOfClass.Length; i++)
			{
				if (allActorsOfClass[i].PlayerStartTag == PaintWorldStartTag)
				{
					Transform = allActorsOfClass[i].GetActorTransform();
					return true;
				}
			}
		}
		return false;
	}

	public override void OnPostLoadMap()
	{
		base.OnPostLoadMap();
		UnloadLevel();
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
	}

	static BGW_PaintWorldMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_PaintWorldMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_PaintWorldMgr));
		PaintWorldLevelPath = new FName("/Game/00Main/Maps/Degenerator_map/LYS_Transmit/LYS_paintingworld_01");
		PaintWorldViewLevelName = new FName("LYS_paintingworld_01");
		PaintWorldPosTag = new FName("PaintingWorldPos");
		PaintWorldStartTag = new FName("PaintingWorldStart");
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_PaintWorldMgr");
	}
}
