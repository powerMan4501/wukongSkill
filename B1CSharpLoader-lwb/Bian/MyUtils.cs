using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using b1;
using b1.BGW;
using ResB1;
using BtlB1;
using BtlShare;
using Google.Protobuf.Collections;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using b1.Plugins.TressFX;

namespace bian;

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

	public static float AirHight = 0f;

	private static UWorld world;

	public static Dictionary<int, string> ListBuff = new Dictionary<int, string>();

	public static string sm;

	public static UWorld GetWorld()
	{
		if ((UObject)(object)world == (UObject)null)
		{
			UObject obj = GCHelper.FindRef(FGlobals.GWorld)?.Managed;
			world = (UWorld)(object)((obj is UWorld) ? obj : null);
		}
		return world;
	}

	public static APawn GetControlledPawn()
	{
		return ((AController)UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)(object)GetWorld())).GetControlledPawn();
	}

	public static BGUPlayerCharacterCS GetBGUPlayerCharacterCS()
	{
		APawn controlledPawn = GetControlledPawn();
		return (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
	}

	public static BGP_PlayerControllerB1 GetPlayerController()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		return (BGP_PlayerControllerB1)UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)(object)GetWorld());
	}

	public static BUS_GSEventCollection GetBUS_GSEventCollection()
	{
		return BUS_EventCollectionCS.Get((AActor)(object)GetControlledPawn());
	}

	public static T LoadAsset<T>(string asset) where T : UObject
	{
		return BGW_PreloadAssetMgr.Get((UObject)(object)GetWorld()).TryGetCachedResourceObj<T>(asset, (ELoadResourceType)1, (EAssetPriority)0, (Action<int, UObject>)null, -1, -1);
	}

	public static UClass LoadClass(string asset)
	{
		return MyUtils.LoadAsset<UClass>(asset);
	}

	public static AActor SpawnActor(string classAsset)
	{

		APawn controlledPawn = GetControlledPawn();
		FVector actorLocation = ((AActor)controlledPawn).GetActorLocation();
		FVector val = ((AActor)controlledPawn).GetActorForwardVector() * 1000.0;
		FVector val2 = actorLocation + val;
		FRotator val3 = UMathLibrary.FindLookAtRotation(val2, actorLocation);
		UClass val4 = LoadClass("PrefabricatorAsset'" + classAsset + "'");
		if ((UObject)(object)val4 == (UObject)null)
		{
			return null;
		}
		return BGUFunctionLibraryCS.BGUSpawnActor(((AActor)controlledPawn).World, (TSubclassOf<AActor>)val4, val2, val3);
	}

	public static AActor GetActorOfClass(string classAsset)
	{
		return UGameplayStatics.GetActorOfClass((UObject)(object)GetWorld(), (TSubclassOf<AActor>)(MyUtils.LoadAsset<UClass>(classAsset)));
	}

	public static void PrintF_(string message)
	{
		Console.WriteLine(message);
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
		return obj.GetType().GetMethod(method_name, BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(obj, paras);
	}

	public static void SkillMapping(AActor wukong, int Skillmap, int skills)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		FUStSkillSMappingDesc skillSMappingDesc = BGW_GameDB.GetSkillSMappingDesc(Skillmap);
		if (skillSMappingDesc == null)
		{
			FUStSkillSMappingDesc val = new FUStSkillSMappingDesc();
			SkillMappingConfig val2 = new SkillMappingConfig();
			List<SkillMappingConfig> list = new List<SkillMappingConfig>();
			val.CanCyclicMapping = (EGSYesNo)0;
			val2.SkillMappingConditionType = (ESkillMappingConditionType)0;
			val2.SkillIDs.Add((IEnumerable<int>)new int[1] { skills });
			list.Add(val2);
			val.MappingConfigList.Add((IEnumerable<SkillMappingConfig>)list);
			BGW_GameDB.GetAllSkillSMappingDesc().Add(Skillmap, val);
		}
		else if ((UObject)(object)wukong != (UObject)null)
		{
			SkillMappingConfig val3 = new SkillMappingConfig();
			skillSMappingDesc.ResultRull = (ESkillMappingResultRull)2;
			val3.SkillMappingConditionType = (ESkillMappingConditionType)0;
			val3.SkillIDs.Add((IEnumerable<int>)new int[1] { skills });
			if (skillSMappingDesc.MappingConfigList.Count > 0)
			{
				skillSMappingDesc.MappingConfigList.Add(val3);
				return;
			}
			skillSMappingDesc.MappingConfigList.Add((IEnumerable<SkillMappingConfig>)(object)new SkillMappingConfig[1] { val3 });
		}
	}

	public static void SkillMapping(AActor wukong, int buff, int Skillmap, int skills)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		FUStSkillSMappingDesc skillSMappingDesc = BGW_GameDB.GetSkillSMappingDesc(Skillmap);
		if (skillSMappingDesc == null)
		{
			FUStSkillSMappingDesc val = new FUStSkillSMappingDesc();
			SkillMappingConfig val2 = new SkillMappingConfig();
			List<SkillMappingConfig> list = new List<SkillMappingConfig>();
			val.CanCyclicMapping = (EGSYesNo)0;
			val2.SkillMappingConditionType = (ESkillMappingConditionType)1;
			val2.IntParams.Add((IEnumerable<int>)new int[1] { buff });
			val2.SkillIDs.Add((IEnumerable<int>)new int[1] { skills });
			list.Add(val2);
			val.MappingConfigList.Add((IEnumerable<SkillMappingConfig>)list);
			BGW_GameDB.GetAllSkillSMappingDesc().Add(Skillmap, val);
		}
		else if ((UObject)(object)wukong != (UObject)null)
		{
			SkillMappingConfig val3 = new SkillMappingConfig();
			skillSMappingDesc.ResultRull = (ESkillMappingResultRull)2;
			val3.SkillMappingConditionType = (ESkillMappingConditionType)1;
			val3.IntParams.Add((IEnumerable<int>)new int[1] { buff });
			val3.SkillIDs.Add((IEnumerable<int>)new int[1] { skills });
			if (skillSMappingDesc.MappingConfigList.Count > 0)
			{
				skillSMappingDesc.MappingConfigList.Add(val3);
				return;
			}
			skillSMappingDesc.MappingConfigList.Add((IEnumerable<SkillMappingConfig>)(object)new SkillMappingConfig[1] { val3 });
		}
	}

	public static void SkillMapping1(AActor wukong, int SkillId_Old, int SkillId_New, ESkillMappingConditionType Type, int BuffID)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0029: Expected O, but got Unknown
		if ((UObject)(object)wukong == (UObject)null)
		{
			return;
		}
		Dictionary<int, FUStSkillSMappingDesc> allSkillSMappingDesc = BGW_GameDB.GetAllSkillSMappingDesc();
		if (!allSkillSMappingDesc.TryGetValue(SkillId_Old, out var value))
		{
			FUStSkillSMappingDesc val = new FUStSkillSMappingDesc();
			value = val;
			allSkillSMappingDesc.Add(SkillId_Old, val);
		}
		allSkillSMappingDesc.TryGetValue(SkillId_Old, out var value2);
		value2.ResultRull = (ESkillMappingResultRull)2;
		RepeatedField<SkillMappingConfig> mappingConfigList = value2.MappingConfigList;
		Dictionary<SkillMappingConfig, int> dictionary = new Dictionary<SkillMappingConfig, int>();
		SkillMappingConfig val2 = new SkillMappingConfig();
		val2.SkillMappingConditionType = Type;
		if ((int)Type == 1 && BuffID > 0)
		{
			val2.IntParams.Add((IEnumerable<int>)new int[1] { BuffID });
		}
		val2.SkillIDs.Add((IEnumerable<int>)new int[1] { SkillId_New });
		dictionary.Add(val2, SkillId_Old);
		foreach (KeyValuePair<SkillMappingConfig, int> item in dictionary)
		{
			if (item.Value == SkillId_Old)
			{
				mappingConfigList.Add(item.Key);
			}
		}
	}

	public static FUStBuffDesc AddNewBuff_cpoy(int NewBuffID, int CopybuffID)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		FUStBuffDesc fUStBuffDesc = GameDBRuntime.GetFUStBuffDesc(NewBuffID);
		if (fUStBuffDesc != null)
		{
			return fUStBuffDesc;
		}
		if (BGW_GameDB.GetAllBuffDesc().TryGetValue(CopybuffID, out var value))
		{
			FUStBuffDesc val = new FUStBuffDesc();
			val.MergeFrom(value);
			val.ID = NewBuffID;
			BGW_GameDB.GetAllBuffDesc().Add(val.ID, val);
		}
		return value;
	}

	public static void SpwanProjectileByTracker(int ProjectileID, ETrackType trackType, int BulletNum, float Duration = 0f, float Xoffset = 0f, float Yoffset = 0f, float Zoffset = 0f, bool isSpeedUp = true)
	{

		if (ProjectileID == 0)
		{
			return;
		}
		AActor controlledPawn = (AActor)(object)GetControlledPawn();
		AActor val = controlledPawn;
		string text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_90_hfm_leiwa_Atk_41_Lv6_change.BGW_90_hfm_leiwa_Atk_41_Lv6_change'";
		ACharacter val2 = (ACharacter)(object)((controlledPawn is ACharacter) ? controlledPawn : null);
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
				{
					text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
					AActor unitLockTargetActor2 = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn);
					val = (AActor)(object)(val2 = (ACharacter)(object)((unitLockTargetActor2 is ACharacter) ? unitLockTargetActor2 : null));
					break;
				}
			case ETrackType.TargetFieldRandom:
				{
					text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
					AActor unitLockTargetActor = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn);
					val = (AActor)(object)(val2 = (ACharacter)(object)((unitLockTargetActor is ACharacter) ? unitLockTargetActor : null));
					break;
				}
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(val, (EBGUUnitState)6))
		{
			return;
		}
		BGWDataAsset_ProjectileSpawnConfig val3 = BGW_PreloadAssetMgr.Get((UObject)(object)GetControlledPawn()).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(text, (ELoadResourceType)1, (EAssetPriority)0, (Action<int, UObject>)null, -1, -1);
		BUS_GSEventCollection val4 = BUS_EventCollectionCS.Get(controlledPawn);
		if (!((UObject)(object)val4 != (UObject)null))
		{
			return;
		}
		FEffectInstReq val5 = default(FEffectInstReq);
		FGSProjecttileObjSpawnNSInfo val6 = new FGSProjecttileObjSpawnNSInfo();
		val6.ProjectileType = (EProjectileType)1;
		val6.BuffIDList = new List<int>();
		val6.ProjectileID = ProjectileID;
		val6.SpawnWave = val3.ProjectileWave;
		val6.SpawnNumPerWave = BulletNum;
		val6.AttachToSpawnBase = val3.AttachToSpawnBase;
		ProjectilePosOffsetStruct val7 = new ProjectilePosOffsetStruct
		{
			PosOffsetType = (ProjectilePosOffsetType)1,
			OffsetSpace = (ProjectilePosOffsetSpace)1,
			BaseType = (ProjectileBaseType)12,
			VerticalOffset_World = 0f,
			UseSocket = true,
			PosOffset = new FVector(200.0, 0.0, 200.0)
		};
		ProjectileBornDirOffsetStruct bornDirOffset = new ProjectileBornDirOffsetStruct
		{
			AimConstraintAxis = new FVector(1.0, 0.0, 0.0)
		};
		FSpawnBulletMinMaxValue val8 = new FSpawnBulletMinMaxValue
		{
			RightValue = 0f,
			LeftValue = 0f,
			IsEquidistance = true
		};
		bornDirOffset.BornDirOffsetZ = val8;
		bornDirOffset.BornDirOffsetX = val8;
		FSpawnBulletSpeed bulletRotSpd = val3.BulletRotSpd;
		FSpawnBulletSpeed bulletFlySpd = val3.BulletFlySpd;
		switch (trackType)
		{
			case ETrackType.TargetFieldRandom:
				val7.PosOffsetType = (ProjectilePosOffsetType)3;
				val7.PosOffset = new FVector(600.0, 600.0, 125.0);
				val7.VerticalOffset_World = 250f;
				bornDirOffset.BornDirOffsetX.LeftValue = -60f;
				bornDirOffset.BornDirOffsetX.RightValue = 60f;
				bornDirOffset.BornDirOffsetY.LeftValue = -60f;
				bornDirOffset.BornDirOffsetY.RightValue = 60f;
				bornDirOffset.BornDirOffsetZ.LeftValue = 0f;
				bornDirOffset.BornDirOffsetZ.RightValue = 360f;
				break;
			case ETrackType.AirStrike:
				val7.PosOffsetType = (ProjectilePosOffsetType)3;
				val7.PosOffset = new FVector(0.0, 500.0, 125.0);
				val7.VerticalOffset_World = AirHight;
				if (isSpeedUp)
				{
					bulletRotSpd.Spd.LeftValue += bulletRotSpd.Spd.LeftValue * 100f;
					bulletRotSpd.Spd.RightValue += bulletRotSpd.Spd.RightValue * 100f;
				}
				break;
			case ETrackType.Shoot2Target:
				if (isSpeedUp)
				{
					bulletRotSpd.Spd.LeftValue += bulletRotSpd.Spd.LeftValue * 100f;
					bulletRotSpd.Spd.RightValue += bulletRotSpd.Spd.RightValue * 100f;
					bulletFlySpd.Spd.LeftValue += bulletFlySpd.Spd.LeftValue * 2f;
					bulletFlySpd.Spd.RightValue += bulletFlySpd.Spd.RightValue * 2f;
					val7.VerticalOffset_World = AirHight;
				}
				break;
		}
		if ((uint)(ProjectileID - 50051095) <= 2u)
		{
			val7.PosOffsetType = (ProjectilePosOffsetType)2;
			val7.OffsetSpace = (ProjectilePosOffsetSpace)1;
			val7.RangeOffsetInfo.RangePointSetType = (ERangePointSetType)0;
			val7.RangeOffsetInfo.CircleRadius = 500f;
		}
		val6.InitSpawnInfo(val3.SpawnBase, val7, val3.bEnableSpawnBase_NoneTarget, val3.SpawnBase_NoneTarget, val3.SpawnPosOffsetInfo_NoneTarget, controlledPawn, (AActor)(object)val2, val, (AActor)null, ref val5);
		val6.AttachRule_Rot = val3.AttachRule_Rot;
		val6.InitTargetInfo(val3.TargetBase, val3.TargetPosOffsetInfo, val3.bEnableTargetBase_NoneTarget, val3.TargetBase_NoneTarget, val3.TargetPosOffsetInfo_NoneTarget, controlledPawn, (AActor)(object)val2, val, (AActor)null, ref val5);
		val6.BornDirBaseInfo = val3.BornDirBaseInfo;
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
		ProjectileBornDirType bornDirType = val6.BornDirBaseInfo.BornDirType;
		if ((int)bornDirType != 4)
		{
			if ((int)bornDirType == 7)
			{
				val6.BornDirBaseInfo.ExtraRotBaseActor = controlledPawn;
			}
		}
		else
		{
			val6.BornDirBaseInfo.HitPointNormalDir = val5.HitPointNormalDir;
		}
		val6.BornDirOffset = bornDirOffset;
		val6.ProjectileFlySpd = bulletFlySpd;
		val6.ProjectileRotSpd = bulletRotSpd;
		val6.MontageID = -1;
		val6.ANSTotalTime = 0f;
		val6.SpawnWaveDuration = (val6.SpawnWaveDuration = ((val6.SpawnWave > 1) ? (val6.ANSTotalTime / (float)(val6.SpawnWave - 1)) : 0f));
		val6.SpawnCounter = 0;
		val6.SpawnWaveCounter = 0;
		val6.bEnableMultiTargetMode = val3.bEnableMultiTargetMode;
		val6.MutilTargetRule = val3.MutilTargetRule;
		val4.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref val6, false, (EProjectileSpawnMethod)0, -1);
		if (!(Duration > 0f))
		{
			return;
		}
		Task.Run(async delegate
		{
			await Task.Delay((int)Duration);
			if ((UObject)(object)GetBUS_GSEventCollection() != (UObject)null)
			{
				GetBUS_GSEventCollection().Evt_DestroyProjectileByID.Invoke(new List<int> { ProjectileID });
			}
		});
	}

	public static void SpwanProjectileByTracker1(int ProjectileID, ETrackType trackType, int BulletNum, int n, FVector FVector1, float Duration = 0f, float Xoffset = 0f, float Yoffset = 0f, float Zoffset = 0f, bool isSpeedUp = true)
	{

		if (ProjectileID == 0)
		{
			return;
		}
		AActor controlledPawn = (AActor)(object)GetControlledPawn();
		AActor val = controlledPawn;
		string text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_90_hfm_leiwa_Atk_41_Lv6_change.BGW_90_hfm_leiwa_Atk_41_Lv6_change'";
		ACharacter val2 = (ACharacter)(object)((controlledPawn is ACharacter) ? controlledPawn : null);
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
				{
					text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
					AActor unitLockTargetActor2 = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn);
					val = (AActor)(object)(val2 = (ACharacter)(object)((unitLockTargetActor2 is ACharacter) ? unitLockTargetActor2 : null));
					break;
				}
			case ETrackType.TargetFieldRandom:
				{
					text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
					AActor unitLockTargetActor = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn);
					val = (AActor)(object)(val2 = (ACharacter)(object)((unitLockTargetActor is ACharacter) ? unitLockTargetActor : null));
					break;
				}
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(val, (EBGUUnitState)6))
		{
			return;
		}
		BGWDataAsset_ProjectileSpawnConfig val3 = BGW_PreloadAssetMgr.Get((UObject)(object)GetControlledPawn()).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(text, (ELoadResourceType)1, (EAssetPriority)0, (Action<int, UObject>)null, -1, -1);
		BUS_GSEventCollection val4 = BUS_EventCollectionCS.Get(controlledPawn);
		if (!((UObject)(object)val4 != (UObject)null))
		{
			return;
		}
		FEffectInstReq val5 = default(FEffectInstReq);
		FGSProjecttileObjSpawnNSInfo val6 = new FGSProjecttileObjSpawnNSInfo();
		val6.ProjectileType = (EProjectileType)1;
		val6.BuffIDList = new List<int>();
		val6.ProjectileID = ProjectileID;
		val6.SpawnWave = val3.ProjectileWave;
		val6.SpawnNumPerWave = BulletNum;
		val6.AttachToSpawnBase = val3.AttachToSpawnBase;
		ProjectilePosOffsetStruct val7 = new ProjectilePosOffsetStruct
		{
			PosOffsetType = (ProjectilePosOffsetType)1,
			OffsetSpace = (ProjectilePosOffsetSpace)1,
			BaseType = (ProjectileBaseType)12,
			VerticalOffset_World = 0f,
			UseSocket = true,
			PosOffset = FVector1
		};
		ProjectileBornDirOffsetStruct bornDirOffset = new ProjectileBornDirOffsetStruct
		{
			AimConstraintAxis = new FVector(1.0, 0.0, 0.0)
		};
		FSpawnBulletMinMaxValue val8 = new FSpawnBulletMinMaxValue
		{
			RightValue = 0f,
			LeftValue = n,
			IsEquidistance = true
		};
		bornDirOffset.BornDirOffsetZ = val8;
		bornDirOffset.BornDirOffsetX = val8;
		FSpawnBulletSpeed bulletRotSpd = val3.BulletRotSpd;
		FSpawnBulletSpeed bulletFlySpd = val3.BulletFlySpd;
		switch (trackType)
		{
			case ETrackType.TargetFieldRandom:
				val7.PosOffsetType = (ProjectilePosOffsetType)3;
				val7.PosOffset = new FVector(600.0, 600.0, 125.0);
				val7.VerticalOffset_World = 250f;
				bornDirOffset.BornDirOffsetX.LeftValue = -60f;
				bornDirOffset.BornDirOffsetX.RightValue = 60f;
				bornDirOffset.BornDirOffsetY.LeftValue = -60f;
				bornDirOffset.BornDirOffsetY.RightValue = 60f;
				bornDirOffset.BornDirOffsetZ.LeftValue = 0f;
				bornDirOffset.BornDirOffsetZ.RightValue = 360f;
				break;
			case ETrackType.AirStrike:
				val7.PosOffsetType = (ProjectilePosOffsetType)3;
				val7.PosOffset = new FVector(0.0, 500.0, 125.0);
				val7.VerticalOffset_World = AirHight;
				if (isSpeedUp)
				{
					bulletRotSpd.Spd.LeftValue += bulletRotSpd.Spd.LeftValue * 100f;
					bulletRotSpd.Spd.RightValue += bulletRotSpd.Spd.RightValue * 100f;
				}
				break;
			case ETrackType.Shoot2Target:
				if (isSpeedUp)
				{
					bulletRotSpd.Spd.LeftValue += bulletRotSpd.Spd.LeftValue * 100f;
					bulletRotSpd.Spd.RightValue += bulletRotSpd.Spd.RightValue * 100f;
					bulletFlySpd.Spd.LeftValue += bulletFlySpd.Spd.LeftValue * 2f;
					bulletFlySpd.Spd.RightValue += bulletFlySpd.Spd.RightValue * 2f;
					val7.VerticalOffset_World = AirHight;
				}

				break;
		}
		if ((uint)(ProjectileID - 50051095) <= 2u)
		{
			val7.PosOffsetType = (ProjectilePosOffsetType)2;
			val7.OffsetSpace = (ProjectilePosOffsetSpace)1;
			val7.RangeOffsetInfo.RangePointSetType = (ERangePointSetType)0;
			val7.RangeOffsetInfo.CircleRadius = 500f;
		}
		val6.InitSpawnInfo(val3.SpawnBase, val7, val3.bEnableSpawnBase_NoneTarget, val3.SpawnBase_NoneTarget, val3.SpawnPosOffsetInfo_NoneTarget, controlledPawn, (AActor)(object)val2, val, (AActor)null, ref val5);
		val6.AttachRule_Rot = val3.AttachRule_Rot;
		val6.InitTargetInfo(val3.TargetBase, val3.TargetPosOffsetInfo, val3.bEnableTargetBase_NoneTarget, val3.TargetBase_NoneTarget, val3.TargetPosOffsetInfo_NoneTarget, controlledPawn, (AActor)(object)val2, val, (AActor)null, ref val5);
		val6.BornDirBaseInfo = val3.BornDirBaseInfo;
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
		ProjectileBornDirType bornDirType = val6.BornDirBaseInfo.BornDirType;
		if ((int)bornDirType != 4)
		{
			if ((int)bornDirType == 7)
			{
				val6.BornDirBaseInfo.ExtraRotBaseActor = controlledPawn;
			}
		}
		else
		{
			val6.BornDirBaseInfo.HitPointNormalDir = val5.HitPointNormalDir;
		}
		val6.BornDirOffset = bornDirOffset;
		val6.ProjectileFlySpd = bulletFlySpd;
		val6.ProjectileRotSpd = bulletRotSpd;
		val6.MontageID = -1;
		val6.ANSTotalTime = 0f;
		val6.SpawnWaveDuration = (val6.SpawnWaveDuration = ((val6.SpawnWave > 1) ? (val6.ANSTotalTime / (float)(val6.SpawnWave - 1)) : 0f));
		val6.SpawnCounter = 0;
		val6.SpawnWaveCounter = 0;
		val6.bEnableMultiTargetMode = val3.bEnableMultiTargetMode;
		val6.MutilTargetRule = val3.MutilTargetRule;
		val4.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref val6, false, (EProjectileSpawnMethod)0, -1);
		if (!(Duration > 0f))
		{
			return;
		}
		Task.Run(async delegate
		{
			await Task.Delay((int)Duration);
			if ((UObject)(object)GetBUS_GSEventCollection() != (UObject)null)
			{
				GetBUS_GSEventCollection().Evt_DestroyProjectileByID.Invoke(new List<int> { ProjectileID });
			}
		});
	}

	public static void SpwanProjectileByTracker2(int ProjectileID, ETrackType trackType, int BulletNum, FVector pos, float Duration = 0f, float Xoffset = 0f, float Yoffset = 0f, float Zoffset = 0f, bool isSpeedUp = true)
	{

		if (ProjectileID == 0)
		{
			return;
		}
		AActor controlledPawn = (AActor)(object)GetControlledPawn();
		AActor val = controlledPawn;
		string text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_90_hfm_leiwa_Atk_41_Lv6_change.BGW_90_hfm_leiwa_Atk_41_Lv6_change'";
		ACharacter val2 = (ACharacter)(object)((controlledPawn is ACharacter) ? controlledPawn : null);
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
				{
					text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
					AActor unitLockTargetActor2 = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn);
					val = (AActor)(object)(val2 = (ACharacter)(object)((unitLockTargetActor2 is ACharacter) ? unitLockTargetActor2 : null));
					break;
				}
			case ETrackType.TargetFieldRandom:
				{
					text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
					AActor unitLockTargetActor = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn);
					val = (AActor)(object)(val2 = (ACharacter)(object)((unitLockTargetActor is ACharacter) ? unitLockTargetActor : null));
					break;
				}
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(val, (EBGUUnitState)6))
		{
			return;
		}
		BGWDataAsset_ProjectileSpawnConfig val3 = BGW_PreloadAssetMgr.Get((UObject)(object)GetControlledPawn()).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(text, (ELoadResourceType)1, (EAssetPriority)0, (Action<int, UObject>)null, -1, -1);
		BUS_GSEventCollection val4 = BUS_EventCollectionCS.Get(controlledPawn);
		if (!((UObject)(object)val4 != (UObject)null))
		{
			return;
		}
		FEffectInstReq val5 = default(FEffectInstReq);
		FGSProjecttileObjSpawnNSInfo val6 = new FGSProjecttileObjSpawnNSInfo();
		val6.ProjectileType = (EProjectileType)1;
		val6.BuffIDList = new List<int>();
		val6.ProjectileID = ProjectileID;
		val6.SpawnWave = val3.ProjectileWave;
		val6.SpawnNumPerWave = BulletNum;
		val6.AttachToSpawnBase = val3.AttachToSpawnBase;
		ProjectilePosOffsetStruct val7 = new ProjectilePosOffsetStruct
		{
			PosOffsetType = (ProjectilePosOffsetType)1,
			OffsetSpace = (ProjectilePosOffsetSpace)1,
			BaseType = (ProjectileBaseType)12,
			VerticalOffset_World = 0f,
			UseSocket = true,
			PosOffset = pos
		};
		ProjectileBornDirOffsetStruct bornDirOffset = new ProjectileBornDirOffsetStruct
		{
			AimConstraintAxis = new FVector(1.0, 1.0, 0.0)
		};
		FSpawnBulletMinMaxValue val8 = new FSpawnBulletMinMaxValue
		{
			RightValue = 0f,
			LeftValue = 360f,
			IsEquidistance = true
		};
		bornDirOffset.BornDirOffsetY = val8;
		bornDirOffset.BornDirOffsetZ = val8;
		bornDirOffset.BornDirOffsetX = val8;
		FSpawnBulletSpeed bulletRotSpd = val3.BulletRotSpd;
		FSpawnBulletSpeed bulletFlySpd = val3.BulletFlySpd;
		switch (trackType)
		{
			case ETrackType.TargetFieldRandom:
				val7.PosOffsetType = (ProjectilePosOffsetType)3;
				val7.PosOffset = new FVector(600.0, 600.0, 125.0);
				val7.VerticalOffset_World = 250f;
				bornDirOffset.BornDirOffsetX.LeftValue = -60f;
				bornDirOffset.BornDirOffsetX.RightValue = 60f;
				bornDirOffset.BornDirOffsetY.LeftValue = -60f;
				bornDirOffset.BornDirOffsetY.RightValue = 60f;
				bornDirOffset.BornDirOffsetZ.LeftValue = 0f;
				bornDirOffset.BornDirOffsetZ.RightValue = 360f;
				break;
			case ETrackType.AirStrike:
				val7.PosOffsetType = (ProjectilePosOffsetType)3;
				val7.PosOffset = new FVector(0.0, 500.0, 125.0);
				val7.VerticalOffset_World = AirHight;
				if (isSpeedUp)
				{
					bulletRotSpd.Spd.LeftValue += bulletRotSpd.Spd.LeftValue * 100f;
					bulletRotSpd.Spd.RightValue += bulletRotSpd.Spd.RightValue * 100f;
				}
				break;
			case ETrackType.Shoot2Target:
				if (isSpeedUp)
				{
					bulletRotSpd.Spd.LeftValue += bulletRotSpd.Spd.LeftValue * 100f;
					bulletRotSpd.Spd.RightValue += bulletRotSpd.Spd.RightValue * 100f;
					bulletFlySpd.Spd.LeftValue += bulletFlySpd.Spd.LeftValue * 2f;
					bulletFlySpd.Spd.RightValue += bulletFlySpd.Spd.RightValue * 2f;
					val7.VerticalOffset_World = AirHight;
				}
				break;
		}
		if ((uint)(ProjectileID - 50051095) <= 2u)
		{
			val7.PosOffsetType = (ProjectilePosOffsetType)2;
			val7.OffsetSpace = (ProjectilePosOffsetSpace)1;
			val7.RangeOffsetInfo.RangePointSetType = (ERangePointSetType)0;
			val7.RangeOffsetInfo.CircleRadius = 500f;
		}
		val6.InitSpawnInfo(val3.SpawnBase, val7, val3.bEnableSpawnBase_NoneTarget, val3.SpawnBase_NoneTarget, val3.SpawnPosOffsetInfo_NoneTarget, controlledPawn, (AActor)(object)val2, val, (AActor)null, ref val5);
		val6.AttachRule_Rot = val3.AttachRule_Rot;
		val6.InitTargetInfo(val3.TargetBase, val3.TargetPosOffsetInfo, val3.bEnableTargetBase_NoneTarget, val3.TargetBase_NoneTarget, val3.TargetPosOffsetInfo_NoneTarget, controlledPawn, (AActor)(object)val2, val, (AActor)null, ref val5);
		val6.BornDirBaseInfo = val3.BornDirBaseInfo;
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
		ProjectileBornDirType bornDirType = val6.BornDirBaseInfo.BornDirType;
		if ((int)bornDirType != 4)
		{
			if ((int)bornDirType == 7)
			{
				val6.BornDirBaseInfo.ExtraRotBaseActor = controlledPawn;
			}
		}
		else
		{
			val6.BornDirBaseInfo.HitPointNormalDir = val5.HitPointNormalDir;
		}
		val6.BornDirOffset = bornDirOffset;
		val6.ProjectileFlySpd = bulletFlySpd;
		val6.ProjectileRotSpd = bulletRotSpd;
		val6.MontageID = -1;
		val6.ANSTotalTime = 0f;
		val6.SpawnWaveDuration = (val6.SpawnWaveDuration = ((val6.SpawnWave > 1) ? (val6.ANSTotalTime / (float)(val6.SpawnWave - 1)) : 0f));
		val6.SpawnCounter = 0;
		val6.SpawnWaveCounter = 0;
		val6.bEnableMultiTargetMode = val3.bEnableMultiTargetMode;
		val6.MutilTargetRule = val3.MutilTargetRule;
		val4.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref val6, false, (EProjectileSpawnMethod)0, -1);
		if (!(Duration > 0f))
		{
			return;
		}
		Task.Run(async delegate
		{
			await Task.Delay((int)Duration);
			if ((UObject)(object)GetBUS_GSEventCollection() != (UObject)null)
			{
				GetBUS_GSEventCollection().Evt_DestroyProjectileByID.Invoke(new List<int> { ProjectileID });
			}
		});
	}

	public static void SpwanProjectileByTracker3(int ProjectileID, ETrackType trackType, int BulletNum, FVector fVector, FVector aimConstraintAxis, FSpawnBulletMinMaxValue x, FSpawnBulletMinMaxValue y, FSpawnBulletMinMaxValue z, float Duration = 0f, float Xoffset = 0f, float Yoffset = 0f, float Zoffset = 0f, bool isSpeedUp = true)
	{

		if (ProjectileID == 0 || !sm.Contains("纷羽"))
		{
			return;
		}
		AActor controlledPawn = (AActor)(object)GetControlledPawn();
		AActor val = controlledPawn;
		string text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_90_hfm_leiwa_Atk_41_Lv6_change.BGW_90_hfm_leiwa_Atk_41_Lv6_change'";
		ACharacter val2 = (ACharacter)(object)((controlledPawn is ACharacter) ? controlledPawn : null);
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
				{
					text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
					AActor unitLockTargetActor2 = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn);
					val = (AActor)(object)(val2 = (ACharacter)(object)((unitLockTargetActor2 is ACharacter) ? unitLockTargetActor2 : null));
					break;
				}
			case ETrackType.TargetFieldRandom:
				{
					text = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/PlayerBullets/Transform/VigorSkill/BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3.BGW_50_hys_lingzhijing_03a_SpawnBullet_Lv3'";
					AActor unitLockTargetActor = BGUFunctionLibraryCS.GetUnitLockTargetActor(controlledPawn);
					val = (AActor)(object)(val2 = (ACharacter)(object)((unitLockTargetActor is ACharacter) ? unitLockTargetActor : null));
					break;
				}
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(val, (EBGUUnitState)6))
		{
			return;
		}
		BGWDataAsset_ProjectileSpawnConfig val3 = BGW_PreloadAssetMgr.Get((UObject)(object)GetControlledPawn()).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(text, (ELoadResourceType)1, (EAssetPriority)0, (Action<int, UObject>)null, -1, -1);
		BUS_GSEventCollection val4 = BUS_EventCollectionCS.Get(controlledPawn);
		if (!((UObject)(object)val4 != (UObject)null))
		{
			return;
		}
		FEffectInstReq val5 = default(FEffectInstReq);
		FGSProjecttileObjSpawnNSInfo val6 = new FGSProjecttileObjSpawnNSInfo();
		val6.ProjectileType = (EProjectileType)1;
		val6.BuffIDList = new List<int>();
		val6.ProjectileID = ProjectileID;
		val6.SpawnWave = val3.ProjectileWave;
		val6.SpawnNumPerWave = BulletNum;
		val6.AttachToSpawnBase = val3.AttachToSpawnBase;
		ProjectilePosOffsetStruct val7 = new ProjectilePosOffsetStruct
		{
			PosOffsetType = (ProjectilePosOffsetType)1,
			OffsetSpace = (ProjectilePosOffsetSpace)1,
			BaseType = (ProjectileBaseType)3,
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
		FSpawnBulletSpeed bulletRotSpd = val3.BulletRotSpd;
		FSpawnBulletSpeed bulletFlySpd = val3.BulletFlySpd;
		switch (trackType)
		{
			case ETrackType.TargetFieldRandom:
				val7.PosOffsetType = (ProjectilePosOffsetType)3;
				val7.PosOffset = new FVector(600.0, 600.0, 150.0);
				val7.VerticalOffset_World = 250f;
				bornDirOffset.BornDirOffsetX.LeftValue = -60f;
				bornDirOffset.BornDirOffsetX.RightValue = 40f;
				bornDirOffset.BornDirOffsetY.LeftValue = -90f;
				bornDirOffset.BornDirOffsetY.RightValue = 30f;
				bornDirOffset.BornDirOffsetZ.LeftValue = 0f;
				bornDirOffset.BornDirOffsetZ.RightValue = 360f;
				bulletFlySpd.Spd.LeftValue = 5000f;
				bulletFlySpd.Spd.RightValue = 10000f;
				bulletRotSpd.Spd.IsEquidistance = false;
				break;
			case ETrackType.AirStrike:
				val7.PosOffsetType = (ProjectilePosOffsetType)3;
				val7.PosOffset = new FVector(0.0, 500.0, 125.0);
				val7.VerticalOffset_World = 0f;
				if (isSpeedUp)
				{
					bulletRotSpd.Spd.LeftValue += bulletRotSpd.Spd.LeftValue * 100f;
					bulletRotSpd.Spd.RightValue += bulletRotSpd.Spd.RightValue * 100f;
				}
				break;
			case ETrackType.Shoot2Target:
				var character = Helper.GetBGUPlayerCharacterCS();
				var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;
				if (isSpeedUp)
				{

					bulletRotSpd.Spd.LeftValue += bulletRotSpd.Spd.LeftValue * 100f;
					bulletRotSpd.Spd.RightValue += bulletRotSpd.Spd.RightValue * 100f;
					bulletFlySpd.Spd.LeftValue += bulletFlySpd.Spd.LeftValue * 2f;
					bulletFlySpd.Spd.RightValue += bulletFlySpd.Spd.RightValue * 2f;
					val7.VerticalOffset_World = 0f;
				}

				if (target != null)
				{
					val6.TargetBase.BaseType = ProjectileBaseType.CurTarget_ProjectileSpawner;
					val6.TargetBase.UseSocket = true;
					val6.TargetBase.SocketName = (FName)"CAMERA_LOCK";
					val6.SpawnBase.BaseType = ProjectileBaseType.ProjectileSpawner;
				}
				break;
		}
		if ((uint)(ProjectileID - 50051095) <= 2u)
		{
			val7.PosOffsetType = (ProjectilePosOffsetType)2;
			val7.OffsetSpace = (ProjectilePosOffsetSpace)1;
			val7.RangeOffsetInfo.RangePointSetType = (ERangePointSetType)0;
			val7.RangeOffsetInfo.CircleRadius = 500f;
		}
		val6.InitSpawnInfo(val3.SpawnBase, val7, val3.bEnableSpawnBase_NoneTarget, val3.SpawnBase_NoneTarget, val3.SpawnPosOffsetInfo_NoneTarget, controlledPawn, (AActor)(object)val2, val, (AActor)null, ref val5);
		val6.AttachRule_Rot = val3.AttachRule_Rot;
		val6.InitTargetInfo(val3.TargetBase, val3.TargetPosOffsetInfo, val3.bEnableTargetBase_NoneTarget, val3.TargetBase_NoneTarget, val3.TargetPosOffsetInfo_NoneTarget, controlledPawn, (AActor)(object)val2, val, (AActor)null, ref val5);
		val6.BornDirBaseInfo = val3.BornDirBaseInfo;
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
		ProjectileBornDirType bornDirType = val6.BornDirBaseInfo.BornDirType;
		if ((int)bornDirType != 4)
		{
			if ((int)bornDirType == 7)
			{
				val6.BornDirBaseInfo.ExtraRotBaseActor = controlledPawn;
			}
		}
		else
		{
			val6.BornDirBaseInfo.HitPointNormalDir = val5.HitPointNormalDir;
		}
		val6.BornDirOffset = bornDirOffset;
		val6.ProjectileFlySpd = bulletFlySpd;
		val6.ProjectileRotSpd = bulletRotSpd;
		val6.MontageID = -1;
		val6.ANSTotalTime = 0f;
		val6.SpawnWaveDuration = (val6.SpawnWaveDuration = ((val6.SpawnWave > 1) ? (val6.ANSTotalTime / (float)(val6.SpawnWave - 1)) : 0f));
		val6.SpawnCounter = 0;
		val6.SpawnWaveCounter = 0;
		val6.bEnableMultiTargetMode = val3.bEnableMultiTargetMode;
		val6.MutilTargetRule = val3.MutilTargetRule;
		val4.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref val6, false, (EProjectileSpawnMethod)0, -1);
		if (!(Duration > 0f))
		{
			return;
		}
		Task.Run(async delegate
		{
			await Task.Delay((int)Duration);
			if ((UObject)(object)GetBUS_GSEventCollection() != (UObject)null)
			{
				GetBUS_GSEventCollection().Evt_DestroyProjectileByID.Invoke(new List<int> { ProjectileID });
			}
		});
	}

	public static void AddBuff(int BuffID, string ParamsString)
	{
		ListBuff.Add(BuffID, ParamsString);
	}

	public static void CallBuff(AActor Caster, int BuffID, float BuffDurationTimer)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (ListBuff.TryGetValue(BuffID, out var value))
		{
			new FUStBuffDesc();
			FUStBuffDesc fUStBuffDesc = GameDBRuntime.GetFUStBuffDesc(591101);
			fUStBuffDesc.TargetFilter = 4;
			fUStBuffDesc.Duration = 5000;
			fUStBuffDesc.CanRemoveWhenAttackHit = (EGSYesNo)1;
			((IEnumerable<FUStBuffEffectAttr>)fUStBuffDesc.BuffEffects).First().EffectTrigger = (EBuffEffectTriggerType)14;
			((IEnumerable<FUStBuffEffectAttr>)fUStBuffDesc.BuffEffects).First().EffectParamsString.Clear();
			((IEnumerable<FUStBuffEffectAttr>)fUStBuffDesc.BuffEffects).First().EffectParamsString.Add((IEnumerable<string>)new string[1] { value });
			BGUFunctionLibraryCS.BGUAddBuff(Caster, Caster, 591101, (EBuffSourceType)0, (BuffDurationTimer != 0f) ? BuffDurationTimer : 5000f);
		}
	}

	public static void CallBuff(AActor Caster, int BuffID, float BuffDurationTimer, bool IsOnSkillDamage)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		if (ListBuff.TryGetValue(BuffID, out var value))
		{
			FUStBuffDesc val = new FUStBuffDesc();
			val = GameDBRuntime.GetFUStBuffDesc(591101);
			val.TargetFilter = 4;
			val.Duration = 1000;
			val.CanRemoveWhenAttackHit = (EGSYesNo)1;
			if (IsOnSkillDamage)
			{
				((IEnumerable<FUStBuffEffectAttr>)val.BuffEffects).First().EffectTrigger = (EBuffEffectTriggerType)14;
			}
			else
			{
				((IEnumerable<FUStBuffEffectAttr>)val.BuffEffects).First().EffectTrigger = (EBuffEffectTriggerType)1;
			}
			((IEnumerable<FUStBuffEffectAttr>)val.BuffEffects).First().EffectParamsString.Clear();
			((IEnumerable<FUStBuffEffectAttr>)val.BuffEffects).First().EffectParamsString.Add((IEnumerable<string>)new string[1] { value });
			BGUFunctionLibraryCS.BGUAddBuff(Caster, Caster, 591101, (EBuffSourceType)0, (BuffDurationTimer != 0f) ? BuffDurationTimer : 1000f);
		}
	}

	public static USpringArmComponent GetComponent(BGUPlayerCharacterCS PlayerCharacter)
	{
		foreach (UActorComponent item in ((AActor)(object)PlayerCharacter).GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USpringArmComponent>()))
		{
			if (item != (UObject)(object)PlayerCharacter.CameraBoom1)
			{
				return item as USpringArmComponent;
			}
		}
		return UGSE_ActorFuncLib.AddComponentByClass((AActor)(object)PlayerCharacter, (TSubclassOf<UActorComponent>)UClass.GetClass<USpringArmComponent>(), true, default(FTransform), false) as USpringArmComponent;
	}
	public static void SetCamera()
	{
		APawn controlledPawn = GetControlledPawn();
		BGUPlayerCharacterCS val = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		if ((UObject)(object)val != null)
		{
			BUS_EventCollectionCS.Get((AActor)(object)val).Evt_EnableCustomFOV.Invoke(true);
			val.FollowCamera.FieldOfView = 90f;
			USpringArmComponent component = GetComponent(val);
			component.AttachTo(((ACharacter)(object)val).Mesh, new FName("CAMERA_LOCK"), EAttachLocation.SnapToTarget, bWeldSimulatedBodies: false);
			component.SetRelativeScale3D(new FVector(1f));
			component.TargetArmLength = 900f;
			component.DoCollisionTest = false;
			component.UsePawnControlRotation = true;
			component.EnableCameraRotationLag = true;
			val.FollowCamera.AttachTo(component, FName.None, EAttachLocation.SnapToTarget, bWeldSimulatedBodies: false);
			val.FollowCamera.SetRelativeLocation(default(FVector), bSweep: false, out var _, bTeleport: true);
		}
	}


	public static void MagicallyChangeConfigA(BGWDataAsset_MagicallyChangeConfig config, BUTamerActor bUTamerActor)
	{
		if (((UObject)(object)config == null) | ((UObject)(object)bUTamerActor == null))
		{
			return;
		}
		config.TamerAssetPath = ((UObject)(object)bUTamerActor).PathName;
		ACharacter monster = (ACharacter)(object)bUTamerActor.GetMonster();
		config.CapsuleHalfHeight = monster.CapsuleComponent.GetUnscaledCapsuleHalfHeight();
		config.CapsuleRadius = monster.CapsuleComponent.GetUnscaledCapsuleRadius();
		config.SKMesh = monster.Mesh.SkeletalMesh;
		config.ABPClass = monster.Mesh.AnimClass;
		USkeletalMesh sKMesh = config.SKMesh;
		config.PhysicsAsset = ((sKMesh != null) ? sKMesh.PhysicsAsset : null);
		config.TFXConfig.Clear();
		foreach (UActorComponent item2 in monster.GetComponentsByClass(MyUtils.LoadAsset<UClass>("/Script/TressFX.TressFXComponent")))
		{
			UTressFXComponent val = (UTressFXComponent)(object)((item2 is UTressFXComponent) ? item2 : null);
			if ((UObject)(object)val != null)
			{
				FMagicallyChangeConfig_TFXConfig item = new FMagicallyChangeConfig_TFXConfig
				{
					TFXAsset = val.Asset,
					HairMaterial = val.HairMaterial,
					ShadeSettings = val.ShadeSettings,
					LodScreenSize = val.LodScreenSize,
					bEnableSimulation = val.EnableSimulation
				};
				config.TFXConfig.Add(item);
			}
		}
		config.Weapons.SetValues(bUTamerActor.ConfigInfoComp.UnitCDesc.Weapons);
		config.InteractBones.Clear();
		foreach (KeyValuePair<FName, FBoneUseForDispMap> item3 in bUTamerActor.ConfigInfoComp.DispInteractBoneMap)
		{
			config.InteractBones.Add(item3.Value);
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bUTamerActor.ConfigInfoComp.UnitCDesc.ResID);
		if (unitCommDesc != null)
		{
			int defaultBattleInfoExtendID = unitCommDesc.DefaultBattleInfoExtendID;
			int overrideID = bUTamerActor.ConfigInfoComp.UnitCDesc.OverrideID;
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((overrideID > 0) ? overrideID : defaultBattleInfoExtendID);
			if (unitBattleInfoExtendDesc != null)
			{
				config.Override_AbnormalDispID_Attacker = unitBattleInfoExtendDesc.AbnormalDispAttackerID;
				config.Override_AbnormalDispID_Victim = unitBattleInfoExtendDesc.AbnormalDispVictimID;
			}
		}
	}
}
