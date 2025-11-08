using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using b1;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace BlackMythWukong_Game_Helper;

public static class MyUtils
{
	public enum ETrackType
	{
		MyField,
		Shoot2Target,
		TargetField,
		TargetFieldRandom,
		FieldAim,
		AirStrike
	}

	private static UWorld world;

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleOutputCP(uint wCodePageID);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetConsoleCP(uint wCodePageID);

	public static void EnableCNInConsole()
	{
		SetConsoleCP(65001u);
		SetConsoleOutputCP(65001u);
	}

	public static UWorld GetWorld()
	{
		if (world == null)
		{
			world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
		}
		return world;
	}

	public static APawn GetControlledPawn()
	{
		return UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)GetWorld()).GetControlledPawn();
	}

	public static BGUPlayerCharacterCS GetBGUPlayerCharacterCS()
	{
		return GetControlledPawn() as BGUPlayerCharacterCS;
	}

	public static BGP_PlayerControllerB1 GetPlayerController()
	{
		return (BGP_PlayerControllerB1)(object)UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)GetWorld());
	}

	public static BUS_GSEventCollection GetBUS_GSEventCollection()
	{
		return BUS_EventCollectionCS.Get((AActor)GetControlledPawn());
	}

	public static T LoadAsset<T>(string asset) where T : UObject
	{
		return BGW_PreloadAssetMgr.Get((UObject)GetWorld()).TryGetCachedResourceObj<T>(asset, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Default, (Action<int, UObject>)null, -1, -1);
	}

	public static UClass LoadClass(string asset)
	{
		return LoadAsset<UClass>(asset);
	}

	public static AActor SpawnActor(string classAsset)
	{
		APawn controlledPawn = GetControlledPawn();
		FVector actorLocation = controlledPawn.GetActorLocation();
		FVector fVector = controlledPawn.GetActorForwardVector() * 1000.0;
		FVector fVector2 = actorLocation + fVector;
		FRotator rotation = UMathLibrary.FindLookAtRotation(fVector2, actorLocation);
		UClass uClass = LoadClass("PrefabricatorAsset'" + classAsset + "'");
		if (uClass == null)
		{
			return null;
		}
		return BGUFunctionLibraryCS.BGUSpawnActor(controlledPawn.World, uClass, fVector2, rotation);
	}

	public static AActor GetActorOfClass(string classAsset)
	{
		return UGameplayStatics.GetActorOfClass(GetWorld(), LoadAsset<UClass>(classAsset));
	}

	public static FieldType GetFieldOrProperty<FieldType>(this object obj, string field_name) where FieldType : class
	{
		Type type = obj.GetType();
		FieldInfo field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)field != null)
		{
			return field.GetValue(obj) as FieldType;
		}
		PropertyInfo property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)property != null)
		{
			return property.GetValue(obj) as FieldType;
		}
		return null;
	}

	public static void SetFieldOrProperty(this object obj, string field_name, object value)
	{
		Type type = obj.GetType();
		FieldInfo field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)field == null)
		{
			field = type.GetField(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)field != null)
		{
			if (field.FieldType.Name != value.GetType().Name && value.GetType() == typeof(string))
			{
				if (field.FieldType == typeof(float))
				{
					field.SetValue(obj, float.Parse(value as string));
				}
				else if (field.FieldType == typeof(double))
				{
					field.SetValue(obj, double.Parse(value as string));
				}
				else if (field.FieldType == typeof(int))
				{
					field.SetValue(obj, int.Parse(value as string));
				}
				else if (field.FieldType == typeof(short))
				{
					field.SetValue(obj, short.Parse(value as string));
				}
				else if (field.FieldType == typeof(long))
				{
					field.SetValue(obj, long.Parse(value as string));
				}
				else
				{
					field.SetValue(obj, value);
				}
			}
			else
			{
				field.SetValue(obj, value);
			}
			return;
		}
		PropertyInfo property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.NonPublic);
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Instance | BindingFlags.Public);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.NonPublic);
		}
		if ((object)property == null)
		{
			property = type.GetProperty(field_name, BindingFlags.Static | BindingFlags.Public);
		}
		if ((object)property == null)
		{
			return;
		}
		if (property.PropertyType.Name != value.GetType().Name && value.GetType() == typeof(string))
		{
			if (property.PropertyType == typeof(float))
			{
				property.SetValue(obj, float.Parse(value as string));
			}
			else if (property.PropertyType == typeof(double))
			{
				property.SetValue(obj, double.Parse(value as string));
			}
			else if (property.PropertyType == typeof(int))
			{
				property.SetValue(obj, int.Parse(value as string));
			}
			else if (property.PropertyType == typeof(short))
			{
				property.SetValue(obj, short.Parse(value as string));
			}
			else if (property.PropertyType == typeof(long))
			{
				property.SetValue(obj, long.Parse(value as string));
			}
			else
			{
				property.SetValue(obj, value);
			}
		}
		else
		{
			property.SetValue(obj, value);
		}
	}

	public static object CallPrivateFunc(this object obj, string method_name, object[] paras)
	{
		Type type = obj.GetType();
		return type.GetMethod(method_name, BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(obj, paras);
	}

	public static void SpwanProjectileByTracker3(int ProjectileID, ETrackType trackType, int BulletNum, FVector fVector, FVector aimConstraintAxis, FSpawnBulletMinMaxValue x, FSpawnBulletMinMaxValue y, FSpawnBulletMinMaxValue z, float Duration = 0f, float Xoffset = 0f, float Yoffset = 0f, float Zoffset = 0f, bool isSpeedUp = true)
	{
		if (ProjectileID == 0)
		{
			return;
		}
		AActor controlledPawn = GetControlledPawn();
		AActor aActor = controlledPawn;
		string text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_90_hfm_leiwa_Atk_41_Lv6_change.BGW_90_hfm_leiwa_Atk_41_Lv6_change'";
		ACharacter projectileSpawner = controlledPawn as ACharacter;
		switch (trackType)
		{
		case ETrackType.MyField:
			text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/Online/SL/SZLC_shujing_02/BGW_szlc_shujing_02_mf_5003.BGW_szlc_shujing_02_mf_5003'";
			break;
		case ETrackType.FieldAim:
			text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
			break;
		case ETrackType.Shoot2Target:
			text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_90_hfm_leiwa_Atk_41_Lv6_change.BGW_90_hfm_leiwa_Atk_41_Lv6_change'";
			break;
		case ETrackType.AirStrike:
			text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/LYS/LYS_KJLWoman/DA/BGW_LYS_KJLWoman_StarLaser.BGW_LYS_KJLWoman_StarLaser'";
			break;
		case ETrackType.TargetField:
			text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
			aActor = (projectileSpawner = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn) as ACharacter);
			break;
		case ETrackType.TargetFieldRandom:
			text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
			aActor = (projectileSpawner = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn) as ACharacter);
			break;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(aActor, EBGUUnitState.Dead))
		{
			return;
		}
		BGWDataAsset_ProjectileSpawnConfig bGWDataAsset_ProjectileSpawnConfig = BGW_PreloadAssetMgr.Get((UObject)GetControlledPawn()).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(text, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Default, (Action<int, UObject>)null, -1, -1);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
		if (!((UObject)(object)bUS_GSEventCollection != null))
		{
			return;
		}
		FEffectInstReq EffectInstReq = default(FEffectInstReq);
		FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
		ProjectileSpawnNSInfo.ProjectileType = EProjectileType.Bullet;
		ProjectileSpawnNSInfo.BuffIDList = new List<int>();
		ProjectileSpawnNSInfo.ProjectileID = ProjectileID;
		ProjectileSpawnNSInfo.SpawnWave = bGWDataAsset_ProjectileSpawnConfig.ProjectileWave;
		ProjectileSpawnNSInfo.SpawnNumPerWave = BulletNum;
		ProjectileSpawnNSInfo.AttachToSpawnBase = bGWDataAsset_ProjectileSpawnConfig.AttachToSpawnBase;
		ProjectilePosOffsetStruct spawnPosOffsetInfo = new ProjectilePosOffsetStruct
		{
			PosOffsetType = ProjectilePosOffsetType.Normal,
			OffsetSpace = ProjectilePosOffsetSpace.SocketLocalSpace,
			BaseType = ProjectileBaseType.LocalPlayer,
			VerticalOffset_World = 0f,
			UseSocket = true,
			PosOffset = fVector
		};
		ProjectileBornDirOffsetStruct bornDirOffset = new ProjectileBornDirOffsetStruct
		{
			AimConstraintAxis = aimConstraintAxis,
			BornDirOffsetX = x,
			BornDirOffsetY = y,
			BornDirOffsetZ = z
		};
		FSpawnBulletSpeed projectileRotSpd = new FSpawnBulletSpeed
		{
			AccelerationTime = 5000f,
			Spd = 
			{
				LeftValue = 20f,
				RightValue = 30f,
				IsEquidistance = true
			}
		};
		FSpawnBulletSpeed projectileFlySpd = new FSpawnBulletSpeed
		{
			Spd = 
			{
				LeftValue = 20f,
				RightValue = 30f
			}
		};
		projectileRotSpd.Spd.IsEquidistance = false;
		switch (trackType)
		{
		case ETrackType.TargetFieldRandom:
			spawnPosOffsetInfo.PosOffsetType = ProjectilePosOffsetType.RandomOffset;
			spawnPosOffsetInfo.PosOffset = new FVector(0.0, 300.0, 125.0);
			spawnPosOffsetInfo.VerticalOffset_World = 250f;
			bornDirOffset.BornDirOffsetX.LeftValue = -60f;
			bornDirOffset.BornDirOffsetX.RightValue = 60f;
			bornDirOffset.BornDirOffsetY.LeftValue = -60f;
			bornDirOffset.BornDirOffsetY.RightValue = 60f;
			bornDirOffset.BornDirOffsetZ.LeftValue = 0f;
			bornDirOffset.BornDirOffsetZ.RightValue = 360f;
			break;
		case ETrackType.AirStrike:
			spawnPosOffsetInfo.PosOffsetType = ProjectilePosOffsetType.RandomOffset;
			spawnPosOffsetInfo.PosOffset = new FVector(0.0, 500.0, 125.0);
			spawnPosOffsetInfo.VerticalOffset_World = 0f;
			if (isSpeedUp)
			{
				projectileRotSpd.Spd.LeftValue += projectileRotSpd.Spd.LeftValue * 100f;
				projectileRotSpd.Spd.RightValue += projectileRotSpd.Spd.RightValue * 100f;
			}
			break;
		case ETrackType.Shoot2Target:
			if (isSpeedUp)
			{
				projectileRotSpd.Spd.LeftValue += projectileRotSpd.Spd.LeftValue * 100f;
				projectileRotSpd.Spd.RightValue += projectileRotSpd.Spd.RightValue * 100f;
				projectileFlySpd.Spd.LeftValue += projectileFlySpd.Spd.LeftValue * 2f;
				projectileFlySpd.Spd.RightValue += projectileFlySpd.Spd.RightValue * 2f;
				spawnPosOffsetInfo.VerticalOffset_World = 0f;
			}
			break;
		}
		int num = ProjectileID;
		if ((uint)(num - 50051095) <= 2u)
		{
			spawnPosOffsetInfo.PosOffsetType = ProjectilePosOffsetType.RangeOffset;
			spawnPosOffsetInfo.OffsetSpace = ProjectilePosOffsetSpace.BaseActorLocalSpace;
			spawnPosOffsetInfo.RangeOffsetInfo.RangePointSetType = ERangePointSetType.CircleRandom;
			spawnPosOffsetInfo.RangeOffsetInfo.CircleRadius = 500f;
		}
		ProjectileSpawnNSInfo.InitSpawnInfo(bGWDataAsset_ProjectileSpawnConfig.SpawnBase, spawnPosOffsetInfo, bGWDataAsset_ProjectileSpawnConfig.bEnableSpawnBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.SpawnBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.SpawnPosOffsetInfo_NoneTarget, controlledPawn, projectileSpawner, aActor, null, in EffectInstReq);
		ProjectileSpawnNSInfo.AttachRule_Rot = bGWDataAsset_ProjectileSpawnConfig.AttachRule_Rot;
		ProjectileSpawnNSInfo.InitTargetInfo(bGWDataAsset_ProjectileSpawnConfig.TargetBase, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo, bGWDataAsset_ProjectileSpawnConfig.bEnableTargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo_NoneTarget, controlledPawn, projectileSpawner, aActor, null, in EffectInstReq);
		ProjectileSpawnNSInfo.BornDirBaseInfo = bGWDataAsset_ProjectileSpawnConfig.BornDirBaseInfo;
		if (Xoffset != 0f)
		{
			bornDirOffset.BornDirOffsetX.LeftValue = (bornDirOffset.BornDirOffsetX.RightValue = Xoffset);
		}
		if (Yoffset != 0f)
		{
			bornDirOffset.BornDirOffsetY.LeftValue = (bornDirOffset.BornDirOffsetY.RightValue = Yoffset);
		}
		if (Zoffset != 0f)
		{
			bornDirOffset.BornDirOffsetZ.LeftValue = (bornDirOffset.BornDirOffsetZ.RightValue = Zoffset);
		}
		switch (ProjectileSpawnNSInfo.BornDirBaseInfo.BornDirType)
		{
		case ProjectileBornDirType.UseEffectNormal:
			ProjectileSpawnNSInfo.BornDirBaseInfo.HitPointNormalDir = EffectInstReq.HitPointNormalDir;
			break;
		case ProjectileBornDirType.UseEffectCasterRot:
			ProjectileSpawnNSInfo.BornDirBaseInfo.ExtraRotBaseActor = controlledPawn;
			break;
		}
		ProjectileSpawnNSInfo.BornDirOffset = bornDirOffset;
		ProjectileSpawnNSInfo.ProjectileFlySpd = projectileFlySpd;
		ProjectileSpawnNSInfo.ProjectileRotSpd = projectileRotSpd;
		ProjectileSpawnNSInfo.MontageID = -1;
		ProjectileSpawnNSInfo.ANSTotalTime = 0f;
		ProjectileSpawnNSInfo.SpawnWaveDuration = (ProjectileSpawnNSInfo.SpawnWaveDuration = ((ProjectileSpawnNSInfo.SpawnWave > 1) ? (ProjectileSpawnNSInfo.ANSTotalTime / (float)(ProjectileSpawnNSInfo.SpawnWave - 1)) : 0f));
		ProjectileSpawnNSInfo.SpawnCounter = 0;
		ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
		ProjectileSpawnNSInfo.bEnableMultiTargetMode = bGWDataAsset_ProjectileSpawnConfig.bEnableMultiTargetMode;
		ProjectileSpawnNSInfo.MutilTargetRule = bGWDataAsset_ProjectileSpawnConfig.MutilTargetRule;
		bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo);
		if (!(Duration > 0f))
		{
			return;
		}
		Task.Run(async delegate
		{
			await Task.Delay((int)Duration);
			if ((UObject)(object)GetBUS_GSEventCollection() != null)
			{
				GetBUS_GSEventCollection().Evt_DestroyProjectileByID.Invoke(new List<int> { ProjectileID });
			}
		});
	}
}
