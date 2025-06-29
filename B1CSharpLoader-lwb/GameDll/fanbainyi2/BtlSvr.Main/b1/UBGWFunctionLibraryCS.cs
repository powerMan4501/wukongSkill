using System;
using System.Collections.Generic;
using b1.BGU.BUActor;
using b1.GameMode;
using b1.Util;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.MediaAssets;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.UBGWFunctionLibraryCS")]
public class UBGWFunctionLibraryCS : UBlueprintFunctionLibrary
{
	private static bool TestPlayMedia_IsValid;

	private static IntPtr TestPlayMedia_FunctionAddress;

	private static int TestPlayMedia_ParamsSize;

	private static bool TestPlayMedia_MediaPlayerStop_IsValid;

	private static int TestPlayMedia_MediaPlayerStop_Offset;

	private static bool TestPlayMedia_MediaPlayerOpen_IsValid;

	private static int TestPlayMedia_MediaPlayerOpen_Offset;

	private static bool TestPlayMedia_MediaSource_IsValid;

	private static int TestPlayMedia_MediaSource_Offset;

	private static bool WoodTmpTestGC_IsValid;

	private static IntPtr WoodTmpTestGC_FunctionAddress;

	private static int WoodTmpTestGC_ParamsSize;

	private static bool TestCalcPosToMapAreaID_IsValid;

	private static IntPtr TestCalcPosToMapAreaID_FunctionAddress;

	private static int TestCalcPosToMapAreaID_ParamsSize;

	private static bool TestCalcPosToMapAreaID_Pos_IsValid;

	private static int TestCalcPosToMapAreaID_Pos_Offset;

	private static FFieldAddress TestCalcPosToMapAreaID_Pos_PropertyAddress;

	private static bool TestCalcPosToMapAreaID_MapAreaBaseData_IsValid;

	private static int TestCalcPosToMapAreaID_MapAreaBaseData_Offset;

	private static bool TestCalcPosToMapAreaID_MapAreaDetailData_IsValid;

	private static int TestCalcPosToMapAreaID_MapAreaDetailData_Offset;

	private static bool TestCalcPosToMapAreaID_ReturnValue_IsValid;

	private static int TestCalcPosToMapAreaID_ReturnValue_Offset;

	private static bool HasSequenceAlreadyPlayed_IsValid;

	private static IntPtr HasSequenceAlreadyPlayed_FunctionAddress;

	private static int HasSequenceAlreadyPlayed_ParamsSize;

	private static bool HasSequenceAlreadyPlayed_WorldCtx_IsValid;

	private static int HasSequenceAlreadyPlayed_WorldCtx_Offset;

	private static bool HasSequenceAlreadyPlayed_SeqID_IsValid;

	private static int HasSequenceAlreadyPlayed_SeqID_Offset;

	private static bool HasSequenceAlreadyPlayed_ReturnValue_IsValid;

	private static int HasSequenceAlreadyPlayed_ReturnValue_Offset;

	private static FFieldAddress HasSequenceAlreadyPlayed_ReturnValue_PropertyAddress;

	private static bool TestCalcPosToMapAreaIDInGame_IsValid;

	private static IntPtr TestCalcPosToMapAreaIDInGame_FunctionAddress;

	private static int TestCalcPosToMapAreaIDInGame_ParamsSize;

	private static bool TestCalcPosToMapAreaIDInGame_mapID_IsValid;

	private static int TestCalcPosToMapAreaIDInGame_mapID_Offset;

	private static bool TestCalcPosToMapAreaIDInGame_Pos_IsValid;

	private static int TestCalcPosToMapAreaIDInGame_Pos_Offset;

	private static FFieldAddress TestCalcPosToMapAreaIDInGame_Pos_PropertyAddress;

	private static bool TestCalcPosToMapAreaIDInGame_WorldContext_IsValid;

	private static int TestCalcPosToMapAreaIDInGame_WorldContext_Offset;

	private static bool TestCalcPosToMapAreaIDInGame_ReturnValue_IsValid;

	private static int TestCalcPosToMapAreaIDInGame_ReturnValue_Offset;

	private static bool SetMapAreaColorDataForEditorUtil_IsValid;

	private static IntPtr SetMapAreaColorDataForEditorUtil_FunctionAddress;

	private static int SetMapAreaColorDataForEditorUtil_ParamsSize;

	private static bool SetMapAreaColorDataForEditorUtil_MapID_IsValid;

	private static int SetMapAreaColorDataForEditorUtil_MapID_Offset;

	private static bool SetMapAreaColorDataForEditorUtil_TargetBaseData_IsValid;

	private static int SetMapAreaColorDataForEditorUtil_TargetBaseData_Offset;

	private static bool SetMapAreaColorDataForEditorUtil_ErrMsg_IsValid;

	private static int SetMapAreaColorDataForEditorUtil_ErrMsg_Offset;

	private static FFieldAddress SetMapAreaColorDataForEditorUtil_ErrMsg_PropertyAddress;

	private static bool SetMapAreaColorDataForEditorUtil_ReturnValue_IsValid;

	private static int SetMapAreaColorDataForEditorUtil_ReturnValue_Offset;

	public static bool GetBirthPointTransform(UObject WorldCtx, int BirthPointId, out FTransform Transform)
	{
		b1.BUBirthPoint[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<b1.BUBirthPoint>(WorldCtx);
		if (allActorsOfClass != null)
		{
			b1.BUBirthPoint[] array = allActorsOfClass;
			foreach (b1.BUBirthPoint bUBirthPoint in array)
			{
				if (bUBirthPoint.BirthPointID == BirthPointId)
				{
					Transform = bUBirthPoint.GetActorTransform();
					return true;
				}
			}
		}
		Transform = default(FTransform);
		return false;
	}

	public static bool GetRebirthPointTransform(UObject WorldCtx, int RebirthPointId, out FTransform Transform)
	{
		BGURebirthPointBase[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGURebirthPointBase>(WorldCtx);
		foreach (BGURebirthPointBase bGURebirthPointBase in allActorsOfClass)
		{
			if (bGURebirthPointBase.RebirthPointConfigComp.RebirthPointConfig.RebirthPointID == RebirthPointId)
			{
				Transform = UGSE_CharacterFuncLib.GetSceneComponentTransformByName(bGURebirthPointBase, BGW_GameDB.GetRebirthPointDesc(RebirthPointId).SceneComponentName);
				return true;
			}
		}
		Transform = default(FTransform);
		return false;
	}

	public static bool GetRebirthPointTransform(UObject WorldCtx, int RebirthPointId, out FTransform Transform, out BGURebirthPointBase RebirthPointActor)
	{
		RebirthPointActor = null;
		BGURebirthPointBase[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGURebirthPointBase>(WorldCtx);
		foreach (BGURebirthPointBase bGURebirthPointBase in allActorsOfClass)
		{
			if (bGURebirthPointBase.RebirthPointConfigComp.RebirthPointConfig.RebirthPointID == RebirthPointId)
			{
				RebirthPointActor = bGURebirthPointBase;
				Transform = UGSE_CharacterFuncLib.GetSceneComponentTransformByName(bGURebirthPointBase, BGW_GameDB.GetRebirthPointDesc(RebirthPointId).SceneComponentName);
				return true;
			}
		}
		Transform = default(FTransform);
		return false;
	}

	[Category("BGW|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.UBGWFunctionLibraryCS:TestCalcPosToMapAreaID")]
	public static int TestCalcPosToMapAreaID(FVector2D Pos, GSMapAreaBaseData MapAreaBaseData, GSMapAreaDetailData MapAreaDetailData)
	{
		return -1;
	}

	[Category("BGW|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.UBGWFunctionLibraryCS:TestCalcPosToMapAreaIDInGame")]
	public static int TestCalcPosToMapAreaIDInGame(int mapID, FVector2D Pos, UObject WorldContext)
	{
		return -1;
	}

	public static bool CanCharacterTriggerMotion(AActor Actor)
	{
		if (Actor is BGU_CharacterAI bGU_CharacterAI)
		{
			IBUC_ConfigInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>(Actor);
			if (readOnlyData != null && readOnlyData.ResID == 24010)
			{
				return false;
			}
			if (bGU_CharacterAI.ConfigInfoComp.FlagConfig.UnitTemplateType != EUnitTagType.ClonedWukong)
			{
				return true;
			}
		}
		if (Actor is BGUPlayerCharacterCS bGUPlayerCharacterCS && bGUPlayerCharacterCS.GetController() is APlayerController)
		{
			return true;
		}
		return false;
	}

	[Category("BGW|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.UBGWFunctionLibraryCS:TestPlayMedia")]
	public static void TestPlayMedia(UMediaPlayer MediaPlayerStop, UMediaPlayer MediaPlayerOpen, UMediaSource MediaSource)
	{
		GSEPerfTimeUtil.Start("TestPlayMedia MediaSource:" + MediaSource.GetFullName(), out var PERFID);
		MediaPlayerStop.Close();
		MediaPlayerOpen.OpenSource(MediaSource);
		GSEPerfTimeUtil.End(PERFID);
	}

	[Category("BGW|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.UBGWFunctionLibraryCS:WoodTmpTestGC")]
	public static void WoodTmpTestGC()
	{
		UObject.CollectGarbage();
		GC.Collect();
		UObject.CollectGarbage();
		GC.Collect();
	}

	[Category("BGW|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.UBGWFunctionLibraryCS:SetMapAreaColorDataForEditorUtil")]
	public static int SetMapAreaColorDataForEditorUtil(int MapID, GSMapAreaBaseData TargetBaseData, out string ErrMsg)
	{
		ErrMsg = "";
		GameDBRuntime.InitLoadMapAreaDataForEditorUtil();
		TargetBaseData.AreaColorData.Clear();
		List<MapAreaConfigDesc> mapAreaColorList = GameDBRuntime.GetMapAreaColorList(MapID);
		for (int i = 0; i < mapAreaColorList.Count; i++)
		{
			FColor key = FColor.FromHex(mapAreaColorList[i].AreaColor);
			if (TargetBaseData.AreaColorData.ContainsKey(key) && TargetBaseData.AreaColorData[key] != mapAreaColorList[i].AreaId)
			{
				ErrMsg = $"Duplicate AreaColor In DB. MapID:{MapID} AreaID:{mapAreaColorList[i].AreaId}";
				return 1;
			}
			TargetBaseData.AreaColorData.Add(key, mapAreaColorList[i].AreaId);
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int j = 0; j < mapAreaColorList.Count; j++)
		{
			if (dictionary.ContainsKey(mapAreaColorList[j].AreaId))
			{
				ErrMsg = $"Duplicate AreaID In DB. MapID:{MapID} AreaID:{mapAreaColorList[j].AreaId}";
				return 2;
			}
			dictionary.Add(mapAreaColorList[j].AreaId, 0);
			if (mapAreaColorList[j].AreaId <= 0 || mapAreaColorList[j].AreaId > 255)
			{
				ErrMsg = $"Invalid AreaID In DB. it must be 1 - 255 MapID:{MapID} AreaID:{mapAreaColorList[j].AreaId}";
				return 3;
			}
		}
		return 0;
	}

	[BlueprintCallable]
	[Category("BGW|Util")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.UBGWFunctionLibraryCS:HasSequenceAlreadyPlayed")]
	public static bool HasSequenceAlreadyPlayed(AActor WorldCtx, int SeqID)
	{
		IBIC_MovieData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_MovieData, BIC_MovieData>(WorldCtx);
		if (gameInstanceReadonlyData == null)
		{
			return false;
		}
		gameInstanceReadonlyData.GetPlayedSequenceList(out var OutPlayedSequenceList);
		return OutPlayedSequenceList.Contains(SeqID);
	}

	public static void GetMapInfoFromPlayer(AActor Player, out string MapName, out int MapAreaId, out string MapAreaName, out FVector PlayerPos)
	{
		MapAreaId = BGUFuncLibMap.GetAreaId(Player);
		MapAreaName = BGUFuncLibMap.GetAreaName(Player);
		PlayerPos = (Player.IsNullOrDestroyed() ? new FVector(0.0, 0.0, 0.0) : Player.GetActorLocation());
		MapName = BGUFuncLibMap.GetMapName(Player);
	}

	public static int GetLevelIdByLevelName(string LevelName)
	{
		foreach (LevelDesc item in GameDBRuntime.GetTBLevelDesc().List)
		{
			if (item.Path.Equals(LevelName))
			{
				return item.Id;
			}
		}
		return 0;
	}

	public static string GenerateRandomGuid(string InObjName)
	{
		long num = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds);
		string text = USystemLibrary.GetDeviceId();
		if (text.Equals(""))
		{
			text = UGSE_EngineFuncLib.GetLoginId();
		}
		return $"{num}-{text}-{InObjName}";
	}

	public static bool IsInStartUpGameMode(UObject WorldCtx)
	{
		return UGameplayStatics.GetGameMode(WorldCtx) as BGG_GameModeStartUp != null;
	}

	public static bool IsShowSettingUiOnly(UObject WorldCtx)
	{
		bool result = false;
		BGUCharacterCS bGUCharacterCS = UGameplayStatics.GetPlayerCharacter(WorldCtx, 0) as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = GameDBRuntime.GetFUStPlayerTransUnitConfDesc(bGUCharacterCS.GetResID() * 100);
			if (fUStPlayerTransUnitConfDesc != null && fUStPlayerTransUnitConfDesc.ShowSettingUiOnly > 0)
			{
				return true;
			}
		}
		return result;
	}

	public static bool IsInBattleGameMode(UObject WorldCtx)
	{
		return UGameplayStatics.GetGameMode(WorldCtx) as BGG_GameModeB1 != null;
	}

	public static ulong GetUTCTimeStamp()
	{
		return (ulong)new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
	}

	public static ulong SinglePlayerDefaultRoleId()
	{
		return 10000uL;
	}

	public static APlayerController GetPlayerControllerByRoleId(UObject WorldCtx, ulong RoleId)
	{
		APlayerController[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<APlayerController>(WorldCtx);
		foreach (APlayerController aPlayerController in allActorsOfClass)
		{
			IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(aPlayerController.PlayerState);
			if (readOnlyData != null && readOnlyData.RoleId == RoleId)
			{
				return aPlayerController;
			}
		}
		return null;
	}

	public static void GetAllTeleportPointsName(UObject WorldCtx, ref List<FName> ActorNames, ref List<FName> DisplayNames, ref List<FVector> Positions)
	{
		ActorNames.Clear();
		DisplayNames.Clear();
		BGWTeleportNamedPoint[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGWTeleportNamedPoint>(WorldCtx);
		foreach (BGWTeleportNamedPoint bGWTeleportNamedPoint in allActorsOfClass)
		{
			Positions.Add(bGWTeleportNamedPoint.GetActorLocation());
			ActorNames.Add(new FName(bGWTeleportNamedPoint.GetGSActorLablel()));
			DisplayNames.Add(bGWTeleportNamedPoint.TeleportID);
		}
	}

	public static float GetLeaveActivableDistance(float ActivableDistance)
	{
		return ActivableDistance + 200f;
	}

	[UFunctionInvoker("/Script/b1-Managed.UBGWFunctionLibraryCS:TestPlayMedia")]
	private static void TestPlayMedia__Invoker(IntPtr buffer, IntPtr obj)
	{
		UMediaPlayer mediaPlayerStop = UObjectMarshaler<UMediaPlayer>.FromNative(IntPtr.Add(buffer, TestPlayMedia_MediaPlayerStop_Offset));
		UMediaPlayer mediaPlayerOpen = UObjectMarshaler<UMediaPlayer>.FromNative(IntPtr.Add(buffer, TestPlayMedia_MediaPlayerOpen_Offset));
		UMediaSource mediaSource = UObjectMarshaler<UMediaSource>.FromNative(IntPtr.Add(buffer, TestPlayMedia_MediaSource_Offset));
		TestPlayMedia(mediaPlayerStop, mediaPlayerOpen, mediaSource);
	}

	[UFunctionInvoker("/Script/b1-Managed.UBGWFunctionLibraryCS:WoodTmpTestGC")]
	private static void WoodTmpTestGC__Invoker(IntPtr buffer, IntPtr obj)
	{
		WoodTmpTestGC();
	}

	[UFunctionInvoker("/Script/b1-Managed.UBGWFunctionLibraryCS:TestCalcPosToMapAreaID")]
	private static void TestCalcPosToMapAreaID__Invoker(IntPtr buffer, IntPtr obj)
	{
		FVector2D pos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, TestCalcPosToMapAreaID_Pos_Offset));
		GSMapAreaBaseData mapAreaBaseData = UObjectMarshaler<GSMapAreaBaseData>.FromNative(IntPtr.Add(buffer, TestCalcPosToMapAreaID_MapAreaBaseData_Offset));
		GSMapAreaDetailData mapAreaDetailData = UObjectMarshaler<GSMapAreaDetailData>.FromNative(IntPtr.Add(buffer, TestCalcPosToMapAreaID_MapAreaDetailData_Offset));
		int value = TestCalcPosToMapAreaID(pos, mapAreaBaseData, mapAreaDetailData);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, TestCalcPosToMapAreaID_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.UBGWFunctionLibraryCS:HasSequenceAlreadyPlayed")]
	private static void HasSequenceAlreadyPlayed__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor worldCtx = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, HasSequenceAlreadyPlayed_WorldCtx_Offset));
		int seqID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, HasSequenceAlreadyPlayed_SeqID_Offset));
		bool value = HasSequenceAlreadyPlayed(worldCtx, seqID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, HasSequenceAlreadyPlayed_ReturnValue_Offset), 0, HasSequenceAlreadyPlayed_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.UBGWFunctionLibraryCS:TestCalcPosToMapAreaIDInGame")]
	private static void TestCalcPosToMapAreaIDInGame__Invoker(IntPtr buffer, IntPtr obj)
	{
		int mapID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, TestCalcPosToMapAreaIDInGame_mapID_Offset));
		FVector2D pos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, TestCalcPosToMapAreaIDInGame_Pos_Offset));
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, TestCalcPosToMapAreaIDInGame_WorldContext_Offset));
		int value = TestCalcPosToMapAreaIDInGame(mapID, pos, worldContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, TestCalcPosToMapAreaIDInGame_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.UBGWFunctionLibraryCS:SetMapAreaColorDataForEditorUtil")]
	private static void SetMapAreaColorDataForEditorUtil__Invoker(IntPtr buffer, IntPtr obj)
	{
		int mapID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, SetMapAreaColorDataForEditorUtil_MapID_Offset));
		GSMapAreaBaseData targetBaseData = UObjectMarshaler<GSMapAreaBaseData>.FromNative(IntPtr.Add(buffer, SetMapAreaColorDataForEditorUtil_TargetBaseData_Offset));
		string ErrMsg;
		int value = SetMapAreaColorDataForEditorUtil(mapID, targetBaseData, out ErrMsg);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, SetMapAreaColorDataForEditorUtil_ReturnValue_Offset), value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, SetMapAreaColorDataForEditorUtil_ErrMsg_Offset), ErrMsg);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.UBGWFunctionLibraryCS");
		TestPlayMedia_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestPlayMedia");
		TestPlayMedia_ParamsSize = NativeReflection.GetFunctionParamsSize(TestPlayMedia_FunctionAddress);
		TestPlayMedia_MediaPlayerStop_Offset = NativeReflection.GetPropertyOffset(TestPlayMedia_FunctionAddress, "MediaPlayerStop");
		TestPlayMedia_MediaPlayerStop_IsValid = NativeReflection.ValidatePropertyClass(TestPlayMedia_FunctionAddress, "MediaPlayerStop", Classes.FObjectProperty);
		TestPlayMedia_MediaPlayerOpen_Offset = NativeReflection.GetPropertyOffset(TestPlayMedia_FunctionAddress, "MediaPlayerOpen");
		TestPlayMedia_MediaPlayerOpen_IsValid = NativeReflection.ValidatePropertyClass(TestPlayMedia_FunctionAddress, "MediaPlayerOpen", Classes.FObjectProperty);
		TestPlayMedia_MediaSource_Offset = NativeReflection.GetPropertyOffset(TestPlayMedia_FunctionAddress, "MediaSource");
		TestPlayMedia_MediaSource_IsValid = NativeReflection.ValidatePropertyClass(TestPlayMedia_FunctionAddress, "MediaSource", Classes.FObjectProperty);
		TestPlayMedia_IsValid = TestPlayMedia_FunctionAddress != IntPtr.Zero && TestPlayMedia_MediaPlayerStop_IsValid && TestPlayMedia_MediaPlayerOpen_IsValid && TestPlayMedia_MediaSource_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UBGWFunctionLibraryCS:TestPlayMedia", TestPlayMedia_IsValid);
		WoodTmpTestGC_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WoodTmpTestGC");
		WoodTmpTestGC_ParamsSize = NativeReflection.GetFunctionParamsSize(WoodTmpTestGC_FunctionAddress);
		WoodTmpTestGC_IsValid = WoodTmpTestGC_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UBGWFunctionLibraryCS:WoodTmpTestGC", WoodTmpTestGC_IsValid);
		TestCalcPosToMapAreaID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestCalcPosToMapAreaID");
		TestCalcPosToMapAreaID_ParamsSize = NativeReflection.GetFunctionParamsSize(TestCalcPosToMapAreaID_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TestCalcPosToMapAreaID_Pos_PropertyAddress, TestCalcPosToMapAreaID_FunctionAddress, "Pos");
		TestCalcPosToMapAreaID_Pos_Offset = NativeReflection.GetPropertyOffset(TestCalcPosToMapAreaID_FunctionAddress, "Pos");
		TestCalcPosToMapAreaID_Pos_IsValid = NativeReflection.ValidatePropertyClass(TestCalcPosToMapAreaID_FunctionAddress, "Pos", Classes.FStructProperty);
		TestCalcPosToMapAreaID_MapAreaBaseData_Offset = NativeReflection.GetPropertyOffset(TestCalcPosToMapAreaID_FunctionAddress, "MapAreaBaseData");
		TestCalcPosToMapAreaID_MapAreaBaseData_IsValid = NativeReflection.ValidatePropertyClass(TestCalcPosToMapAreaID_FunctionAddress, "MapAreaBaseData", Classes.FObjectProperty);
		TestCalcPosToMapAreaID_MapAreaDetailData_Offset = NativeReflection.GetPropertyOffset(TestCalcPosToMapAreaID_FunctionAddress, "MapAreaDetailData");
		TestCalcPosToMapAreaID_MapAreaDetailData_IsValid = NativeReflection.ValidatePropertyClass(TestCalcPosToMapAreaID_FunctionAddress, "MapAreaDetailData", Classes.FObjectProperty);
		TestCalcPosToMapAreaID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TestCalcPosToMapAreaID_FunctionAddress, "ReturnValue");
		TestCalcPosToMapAreaID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TestCalcPosToMapAreaID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		TestCalcPosToMapAreaID_IsValid = TestCalcPosToMapAreaID_FunctionAddress != IntPtr.Zero && TestCalcPosToMapAreaID_Pos_IsValid && TestCalcPosToMapAreaID_MapAreaBaseData_IsValid && TestCalcPosToMapAreaID_MapAreaDetailData_IsValid && TestCalcPosToMapAreaID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UBGWFunctionLibraryCS:TestCalcPosToMapAreaID", TestCalcPosToMapAreaID_IsValid);
		HasSequenceAlreadyPlayed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasSequenceAlreadyPlayed");
		HasSequenceAlreadyPlayed_ParamsSize = NativeReflection.GetFunctionParamsSize(HasSequenceAlreadyPlayed_FunctionAddress);
		HasSequenceAlreadyPlayed_WorldCtx_Offset = NativeReflection.GetPropertyOffset(HasSequenceAlreadyPlayed_FunctionAddress, "WorldCtx");
		HasSequenceAlreadyPlayed_WorldCtx_IsValid = NativeReflection.ValidatePropertyClass(HasSequenceAlreadyPlayed_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		HasSequenceAlreadyPlayed_SeqID_Offset = NativeReflection.GetPropertyOffset(HasSequenceAlreadyPlayed_FunctionAddress, "SeqID");
		HasSequenceAlreadyPlayed_SeqID_IsValid = NativeReflection.ValidatePropertyClass(HasSequenceAlreadyPlayed_FunctionAddress, "SeqID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref HasSequenceAlreadyPlayed_ReturnValue_PropertyAddress, HasSequenceAlreadyPlayed_FunctionAddress, "ReturnValue");
		HasSequenceAlreadyPlayed_ReturnValue_Offset = NativeReflection.GetPropertyOffset(HasSequenceAlreadyPlayed_FunctionAddress, "ReturnValue");
		HasSequenceAlreadyPlayed_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(HasSequenceAlreadyPlayed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasSequenceAlreadyPlayed_IsValid = HasSequenceAlreadyPlayed_FunctionAddress != IntPtr.Zero && HasSequenceAlreadyPlayed_WorldCtx_IsValid && HasSequenceAlreadyPlayed_SeqID_IsValid && HasSequenceAlreadyPlayed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UBGWFunctionLibraryCS:HasSequenceAlreadyPlayed", HasSequenceAlreadyPlayed_IsValid);
		TestCalcPosToMapAreaIDInGame_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestCalcPosToMapAreaIDInGame");
		TestCalcPosToMapAreaIDInGame_ParamsSize = NativeReflection.GetFunctionParamsSize(TestCalcPosToMapAreaIDInGame_FunctionAddress);
		TestCalcPosToMapAreaIDInGame_mapID_Offset = NativeReflection.GetPropertyOffset(TestCalcPosToMapAreaIDInGame_FunctionAddress, "mapID");
		TestCalcPosToMapAreaIDInGame_mapID_IsValid = NativeReflection.ValidatePropertyClass(TestCalcPosToMapAreaIDInGame_FunctionAddress, "mapID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TestCalcPosToMapAreaIDInGame_Pos_PropertyAddress, TestCalcPosToMapAreaIDInGame_FunctionAddress, "Pos");
		TestCalcPosToMapAreaIDInGame_Pos_Offset = NativeReflection.GetPropertyOffset(TestCalcPosToMapAreaIDInGame_FunctionAddress, "Pos");
		TestCalcPosToMapAreaIDInGame_Pos_IsValid = NativeReflection.ValidatePropertyClass(TestCalcPosToMapAreaIDInGame_FunctionAddress, "Pos", Classes.FStructProperty);
		TestCalcPosToMapAreaIDInGame_WorldContext_Offset = NativeReflection.GetPropertyOffset(TestCalcPosToMapAreaIDInGame_FunctionAddress, "WorldContext");
		TestCalcPosToMapAreaIDInGame_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(TestCalcPosToMapAreaIDInGame_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		TestCalcPosToMapAreaIDInGame_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TestCalcPosToMapAreaIDInGame_FunctionAddress, "ReturnValue");
		TestCalcPosToMapAreaIDInGame_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TestCalcPosToMapAreaIDInGame_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		TestCalcPosToMapAreaIDInGame_IsValid = TestCalcPosToMapAreaIDInGame_FunctionAddress != IntPtr.Zero && TestCalcPosToMapAreaIDInGame_mapID_IsValid && TestCalcPosToMapAreaIDInGame_Pos_IsValid && TestCalcPosToMapAreaIDInGame_WorldContext_IsValid && TestCalcPosToMapAreaIDInGame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UBGWFunctionLibraryCS:TestCalcPosToMapAreaIDInGame", TestCalcPosToMapAreaIDInGame_IsValid);
		SetMapAreaColorDataForEditorUtil_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMapAreaColorDataForEditorUtil");
		SetMapAreaColorDataForEditorUtil_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMapAreaColorDataForEditorUtil_FunctionAddress);
		SetMapAreaColorDataForEditorUtil_MapID_Offset = NativeReflection.GetPropertyOffset(SetMapAreaColorDataForEditorUtil_FunctionAddress, "MapID");
		SetMapAreaColorDataForEditorUtil_MapID_IsValid = NativeReflection.ValidatePropertyClass(SetMapAreaColorDataForEditorUtil_FunctionAddress, "MapID", Classes.FIntProperty);
		SetMapAreaColorDataForEditorUtil_TargetBaseData_Offset = NativeReflection.GetPropertyOffset(SetMapAreaColorDataForEditorUtil_FunctionAddress, "TargetBaseData");
		SetMapAreaColorDataForEditorUtil_TargetBaseData_IsValid = NativeReflection.ValidatePropertyClass(SetMapAreaColorDataForEditorUtil_FunctionAddress, "TargetBaseData", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SetMapAreaColorDataForEditorUtil_ErrMsg_PropertyAddress, SetMapAreaColorDataForEditorUtil_FunctionAddress, "ErrMsg");
		SetMapAreaColorDataForEditorUtil_ErrMsg_Offset = NativeReflection.GetPropertyOffset(SetMapAreaColorDataForEditorUtil_FunctionAddress, "ErrMsg");
		SetMapAreaColorDataForEditorUtil_ErrMsg_IsValid = NativeReflection.ValidatePropertyClass(SetMapAreaColorDataForEditorUtil_FunctionAddress, "ErrMsg", Classes.FStrProperty);
		SetMapAreaColorDataForEditorUtil_ReturnValue_Offset = NativeReflection.GetPropertyOffset(SetMapAreaColorDataForEditorUtil_FunctionAddress, "ReturnValue");
		SetMapAreaColorDataForEditorUtil_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(SetMapAreaColorDataForEditorUtil_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SetMapAreaColorDataForEditorUtil_IsValid = SetMapAreaColorDataForEditorUtil_FunctionAddress != IntPtr.Zero && SetMapAreaColorDataForEditorUtil_MapID_IsValid && SetMapAreaColorDataForEditorUtil_TargetBaseData_IsValid && SetMapAreaColorDataForEditorUtil_ErrMsg_IsValid && SetMapAreaColorDataForEditorUtil_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UBGWFunctionLibraryCS:SetMapAreaColorDataForEditorUtil", SetMapAreaColorDataForEditorUtil_IsValid);
	}

	static UBGWFunctionLibraryCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UBGWFunctionLibraryCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWFunctionLibraryCS));
	}
}
