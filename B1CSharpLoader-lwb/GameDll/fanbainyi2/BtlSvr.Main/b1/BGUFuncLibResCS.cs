using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using b1.AutoQA;
using b1.Plugins.Calliope;
using b1.Protobuf.DataAPI;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.AnimationBlueprintLibrary;
using UnrealEngine.AssetRegistry;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibResCS")]
public class BGUFuncLibResCS : UBlueprintFunctionLibrary
{
	public class FCpgUniqueControlResult
	{
		public Dictionary<string, List<string>> DynamicObstacleResult;

		public Dictionary<string, List<string>> OverlapResult;

		public Dictionary<string, List<string>> InteractorResult;

		public Dictionary<string, List<string>> SpawnerResult;

		public Dictionary<string, List<string>> UnitResult;

		public Dictionary<string, List<string>> NPCUnitResult;

		public FCalliopeControlledLevelsInfo CalliopeControlledLevelsInfo;

		public FCpgUniqueControlResult()
		{
			DynamicObstacleResult = new Dictionary<string, List<string>>();
			OverlapResult = new Dictionary<string, List<string>>();
			InteractorResult = new Dictionary<string, List<string>>();
			SpawnerResult = new Dictionary<string, List<string>>();
			UnitResult = new Dictionary<string, List<string>>();
			NPCUnitResult = new Dictionary<string, List<string>>();
			CalliopeControlledLevelsInfo = new FCalliopeControlledLevelsInfo();
		}

		public void RemoveAllUniqueItems()
		{
			RemoveUniqueItems(DynamicObstacleResult);
			RemoveUniqueItems(OverlapResult);
			RemoveUniqueItems(InteractorResult);
			RemoveUniqueItems(SpawnerResult);
			RemoveUniqueItems(UnitResult);
			RemoveUniqueItems(NPCUnitResult);
		}

		private void RemoveUniqueItems(Dictionary<string, List<string>> Dict)
		{
			foreach (string item in new List<string>(Dict.Keys))
			{
				if (Dict[item].Count <= 1)
				{
					Dict.Remove(item);
				}
			}
		}

		public bool IsAllResultEmpty()
		{
			if (DynamicObstacleResult.Count == 0 && OverlapResult.Count == 0 && InteractorResult.Count == 0 && SpawnerResult.Count == 0 && UnitResult.Count == 0)
			{
				return NPCUnitResult.Count == 0;
			}
			return false;
		}

		public void AddItem(ref Dictionary<string, List<string>> Dict, string GuidKey, string ValuePath)
		{
			if (Dict.ContainsKey(GuidKey))
			{
				Dict[GuidKey].Add(ValuePath);
				return;
			}
			Dict.Add(GuidKey, new List<string> { ValuePath });
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (DynamicObstacleResult.Count > 0)
			{
				stringBuilder.AppendLine("/*************** 动态阻挡重复控制 ***************/");
				foreach (KeyValuePair<string, List<string>> item in DynamicObstacleResult)
				{
					stringBuilder.AppendLine($"存在{item.Value.Count}个重复控制动态阻挡(Guid:{item.Key})的CPG");
					foreach (string item2 in item.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item2);
					}
				}
				stringBuilder.AppendLine("/************************************************/");
			}
			if (OverlapResult.Count > 0)
			{
				stringBuilder.AppendLine("/*************** 触发盒重复控制 ***************/");
				foreach (KeyValuePair<string, List<string>> item3 in OverlapResult)
				{
					stringBuilder.AppendLine($"存在{item3.Value.Count}个重复控制触发盒(Guid:{item3.Key})的CPG");
					foreach (string item4 in item3.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item4);
					}
				}
				stringBuilder.AppendLine("/**********************************************/");
			}
			if (InteractorResult.Count > 0)
			{
				stringBuilder.AppendLine("/*************** 交互物重复控制 ***************/");
				foreach (KeyValuePair<string, List<string>> item5 in InteractorResult)
				{
					stringBuilder.AppendLine($"存在{item5.Value.Count}个重复控制交互物(Guid:{item5.Key})的CPG");
					foreach (string item6 in item5.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item6);
					}
				}
				stringBuilder.AppendLine("/**********************************************/");
			}
			if (SpawnerResult.Count > 0)
			{
				stringBuilder.AppendLine("/*************** 刷怪器重复控制 ***************/");
				foreach (KeyValuePair<string, List<string>> item7 in SpawnerResult)
				{
					stringBuilder.AppendLine($"存在{item7.Value.Count}个重复控制刷怪器(Guid:{item7.Key})的CPG");
					foreach (string item8 in item7.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item8);
					}
				}
				stringBuilder.AppendLine("/**********************************************/");
			}
			if (UnitResult.Count > 0)
			{
				stringBuilder.AppendLine("/*************** 单位重复控制 ***************/");
				foreach (KeyValuePair<string, List<string>> item9 in UnitResult)
				{
					stringBuilder.AppendLine($"存在{item9.Value.Count}个重复控制单位(Guid:{item9.Key})的CPG");
					foreach (string item10 in item9.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item10);
					}
				}
				stringBuilder.AppendLine("/********************************************/");
			}
			if (NPCUnitResult.Count > 0)
			{
				stringBuilder.AppendLine("/*************** NPC重复控制 ***************/");
				foreach (KeyValuePair<string, List<string>> item11 in NPCUnitResult)
				{
					stringBuilder.AppendLine($"存在{item11.Value.Count}个重复控制NPC单位(Guid:{item11.Key})的CPG");
					foreach (string item12 in item11.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item12);
					}
				}
				stringBuilder.AppendLine("/*******************************************/");
			}
			return stringBuilder.ToString();
		}

		public string ToString(UCalliopeAsset InCalliopeAsset)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, List<string>> item in DynamicObstacleResult)
			{
				foreach (FGsManagedDynamicObstacle item2 in InCalliopeAsset.CalliopeParameters.DynamicObstacleCollection)
				{
					if (!(item2.ActorGuid == item.Key))
					{
						continue;
					}
					stringBuilder.AppendLine($"存在{item.Value.Count}个重复控制动态阻挡({item2.AliasName})的CPG");
					foreach (string item3 in item.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item3);
					}
					break;
				}
			}
			foreach (KeyValuePair<string, List<string>> item4 in OverlapResult)
			{
				foreach (FGsManagedOverlap item5 in InCalliopeAsset.CalliopeParameters.OverlapCollection)
				{
					if (!(item5.ActorGuid == item4.Key))
					{
						continue;
					}
					stringBuilder.AppendLine($"存在{item4.Value.Count}个重复控制触发盒({item5.AliasName})的CPG");
					foreach (string item6 in item4.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item6);
					}
					break;
				}
			}
			foreach (KeyValuePair<string, List<string>> item7 in InteractorResult)
			{
				foreach (FGsManagedInteractor item8 in InCalliopeAsset.CalliopeParameters.InteractorCollection)
				{
					if (!(item8.ActorGuid == item7.Key))
					{
						continue;
					}
					stringBuilder.AppendLine($"存在{item7.Value.Count}个重复控制交互物({item8.AliasName})的CPG");
					foreach (string item9 in item7.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item9);
					}
					break;
				}
			}
			foreach (KeyValuePair<string, List<string>> item10 in SpawnerResult)
			{
				foreach (FGsManagedSpawner item11 in InCalliopeAsset.CalliopeParameters.SpawnerCollection)
				{
					if (!(item11.ActorGuid == item10.Key))
					{
						continue;
					}
					stringBuilder.AppendLine($"存在{item10.Value.Count}个重复控制刷怪器({item11.AliasName})的CPG");
					foreach (string item12 in item10.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item12);
					}
					break;
				}
			}
			foreach (KeyValuePair<string, List<string>> item13 in UnitResult)
			{
				foreach (FGsManagedUnit item14 in InCalliopeAsset.CalliopeParameters.UnitCollection)
				{
					if (!(item14.ActorGuid == item13.Key))
					{
						continue;
					}
					stringBuilder.AppendLine($"存在{item13.Value.Count}个重复控制单位({item14.AliasName})的CPG");
					foreach (string item15 in item13.Value)
					{
						stringBuilder.AppendLine("CPG路径: " + item15);
					}
					break;
				}
			}
			foreach (KeyValuePair<string, List<string>> item16 in NPCUnitResult)
			{
				foreach (FGsManagedNPCUnit item17 in InCalliopeAsset.CalliopeParameters.NPCUnitCollection)
				{
					if (item17.NPCInstanceGroup.Count == 0)
					{
						if (!(item17.ActorGuid == item16.Key))
						{
							continue;
						}
						stringBuilder.AppendLine($"存在{item16.Value.Count}个重复控制NPC单位({item17.AliasName})的CPG");
						foreach (string item18 in item16.Value)
						{
							stringBuilder.AppendLine("CPG路径: " + item18);
						}
						break;
					}
					foreach (FGsNPCReferenceInfo item19 in item17.NPCInstanceGroup)
					{
						if (!(item19.ActorGuid == item16.Key))
						{
							continue;
						}
						stringBuilder.AppendLine($"存在{item16.Value.Count}个重复控制NPC单位({item19.AliasName})的CPG");
						foreach (string item20 in item16.Value)
						{
							stringBuilder.AppendLine("CPG路径: " + item20);
						}
						break;
					}
				}
			}
			return stringBuilder.ToString();
		}
	}

	public class FCalliopeControlledLevelsInfo
	{
		public Dictionary<int, Dictionary<string, Dictionary<string, List<int>>>> Info = new Dictionary<int, Dictionary<string, Dictionary<string, List<int>>>>();

		public string GetLevelRepeatControlInfo()
		{
			bool flag = false;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("检测到关卡被多个CPG重复控制，请修正以下内容（暂时不影响导出成功）：");
			foreach (KeyValuePair<int, Dictionary<string, Dictionary<string, List<int>>>> item in Info)
			{
				bool flag2 = true;
				foreach (KeyValuePair<string, Dictionary<string, List<int>>> item2 in item.Value)
				{
					if (item2.Value.Count <= 1)
					{
						continue;
					}
					flag = true;
					if (flag2)
					{
						flag2 = false;
						stringBuilder.AppendLine(GameDBRuntime.GetLevelDesc(item.Key)?.Path ?? "");
					}
					stringBuilder.AppendLine("    " + item2.Key);
					foreach (KeyValuePair<string, List<int>> item3 in item2.Value)
					{
						stringBuilder.AppendLine("        CPG: " + item3.Key + " |  DataAssetID: [ " + string.Join(", ", item3.Value) + " ]");
					}
				}
			}
			if (flag)
			{
				return stringBuilder.ToString();
			}
			return "";
		}

		public string GetDataAssetLevelRepeatControlInfo(int DataAssetID)
		{
			bool flag = false;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine($"DataAssetID: {DataAssetID}");
			stringBuilder.AppendLine("检测到DA中的关卡被多个CPG重复控制，请修正以下内容：");
			foreach (KeyValuePair<int, Dictionary<string, Dictionary<string, List<int>>>> item in Info)
			{
				bool flag2 = true;
				foreach (KeyValuePair<string, Dictionary<string, List<int>>> item2 in item.Value)
				{
					if (item2.Value.Count <= 1 || item2.Value.FirstOrDefault((KeyValuePair<string, List<int>> r) => r.Value.Contains(DataAssetID)).Equals(default(KeyValuePair<string, List<int>>)))
					{
						continue;
					}
					flag = true;
					if (flag2)
					{
						flag2 = false;
						stringBuilder.AppendLine(GameDBRuntime.GetLevelDesc(item.Key)?.Path ?? "");
					}
					stringBuilder.AppendLine("    " + item2.Key);
					foreach (KeyValuePair<string, List<int>> item3 in item2.Value)
					{
						stringBuilder.AppendLine("        CPG: " + item3.Key + " |  DataAssetID: [ " + string.Join(", ", item3.Value) + " ]");
					}
				}
			}
			if (flag)
			{
				return stringBuilder.ToString();
			}
			return "";
		}

		public string GetLevelAllConfigInfo(int LevelID)
		{
			if (!Info.ContainsKey(LevelID))
			{
				return "";
			}
			BGUFuncLibNonRuntime.LoadProtobufData<FUStStreamingLevelStateDesc>();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("=======================================================================");
			stringBuilder.AppendLine($"LevelID: {LevelID}");
			int num = 0;
			foreach (KeyValuePair<string, Dictionary<string, List<int>>> item in Info[LevelID])
			{
				if (item.Key.Contains("_WCTile"))
				{
					continue;
				}
				stringBuilder.AppendLine($"({num})  关卡：{item.Key}");
				foreach (KeyValuePair<string, List<int>> item2 in item.Value)
				{
					stringBuilder.AppendLine("        CPG: " + item2.Key + "  |  DataAsset: " + string.Join(", ", item2.Value));
					foreach (int item3 in item2.Value)
					{
						stringBuilder.AppendLine($"            DA: {item3}");
						foreach (KeyValuePair<string, List<EGSLevelState>> item4 in UObject.LoadObject<BGWDataAsset_StreamingLevelStateConfig>(null, BGW_GameDB.GetStreamingLevelStateDesc(item3)?.DataAssetPath).GetConfiguredConditionsOfLevel(item.Key))
						{
							stringBuilder.AppendLine("                | 条件: " + item4.Key + "    |    状态: " + string.Join(", ", item4.Value));
						}
					}
				}
				num++;
			}
			stringBuilder.AppendLine("=======================================================================");
			return stringBuilder.ToString();
		}
	}

	public class FCalliopeLevelStreamingStateVolumeInfo
	{
		public class FCalliopeNodeStreamingStateVolumeInfo
		{
			public List<int> DataAssetIDs;

			public FGSSubLevelStates LevelStates;

			public FCalliopeNodeStreamingStateVolumeInfo(List<int> _DataAssetIDs, FGSSubLevelStates _LevelStates)
			{
				DataAssetIDs = new List<int>(_DataAssetIDs);
				LevelStates = new FGSSubLevelStates(_LevelStates);
			}

			public bool IsLevelStatesRepeated(out string RepeatLevel)
			{
				RepeatLevel = "";
				foreach (KeyValuePair<string, FGSLevelStateInfo> managedLevel in LevelStates.ManagedLevels)
				{
					Dictionary<EGSLevelState, List<string>> dictionary = new Dictionary<EGSLevelState, List<string>>();
					foreach (FGSLevelStateRequesterInfo requester in managedLevel.Value.Requesters)
					{
						if (dictionary.ContainsKey(requester.LevelState))
						{
							dictionary[requester.LevelState].Add(requester.Requester);
							continue;
						}
						dictionary.Add(requester.LevelState, new List<string> { requester.Requester });
					}
					if (dictionary.Keys.Count > 1)
					{
						RepeatLevel = managedLevel.Key;
						return true;
					}
				}
				return false;
			}

			public bool IsRepeatWith(FCalliopeNodeStreamingStateVolumeInfo Other, out string RepeatLevel)
			{
				RepeatLevel = "";
				Dictionary<string, Dictionary<EGSLevelState, List<string>>> dictionary = new Dictionary<string, Dictionary<EGSLevelState, List<string>>>();
				foreach (KeyValuePair<string, FGSLevelStateInfo> managedLevel in LevelStates.ManagedLevels)
				{
					dictionary[managedLevel.Key] = new Dictionary<EGSLevelState, List<string>>();
					foreach (FGSLevelStateRequesterInfo requester in managedLevel.Value.Requesters)
					{
						if (dictionary[managedLevel.Key].ContainsKey(requester.LevelState))
						{
							dictionary[managedLevel.Key][requester.LevelState].Add(requester.Requester);
							continue;
						}
						dictionary[managedLevel.Key].Add(requester.LevelState, new List<string> { requester.Requester });
					}
				}
				foreach (KeyValuePair<string, FGSLevelStateInfo> managedLevel2 in Other.LevelStates.ManagedLevels)
				{
					foreach (FGSLevelStateRequesterInfo requester2 in managedLevel2.Value.Requesters)
					{
						if (dictionary.TryGetValue(managedLevel2.Key, out var value) && !value.ContainsKey(requester2.LevelState))
						{
							RepeatLevel = managedLevel2.Key;
							return true;
						}
					}
				}
				return false;
			}
		}

		public Dictionary<int, Dictionary<string, Dictionary<string, List<FCalliopeNodeStreamingStateVolumeInfo>>>> LevelStreamingStateVolumeInfo = new Dictionary<int, Dictionary<string, Dictionary<string, List<FCalliopeNodeStreamingStateVolumeInfo>>>>();

		public bool IsVolumesRepeat(int LevelID, string Volume1, string Volume2, out List<KeyValuePair<string, string>> RepeatedResult)
		{
			RepeatedResult = new List<KeyValuePair<string, string>>();
			if (!LevelStreamingStateVolumeInfo.ContainsKey(LevelID))
			{
				return false;
			}
			Dictionary<string, Dictionary<string, List<FCalliopeNodeStreamingStateVolumeInfo>>> dictionary = LevelStreamingStateVolumeInfo[LevelID];
			if (!dictionary.ContainsKey(Volume1) || !dictionary.ContainsKey(Volume1))
			{
				return false;
			}
			Dictionary<string, List<FCalliopeNodeStreamingStateVolumeInfo>> dictionary2 = dictionary[Volume1];
			Dictionary<string, List<FCalliopeNodeStreamingStateVolumeInfo>> dictionary3 = dictionary[Volume2];
			RepeatedResult = new List<KeyValuePair<string, string>>();
			foreach (KeyValuePair<string, List<FCalliopeNodeStreamingStateVolumeInfo>> item in dictionary2)
			{
				foreach (FCalliopeNodeStreamingStateVolumeInfo item2 in item.Value)
				{
					foreach (KeyValuePair<string, List<FCalliopeNodeStreamingStateVolumeInfo>> item3 in dictionary3)
					{
						foreach (FCalliopeNodeStreamingStateVolumeInfo item4 in item3.Value)
						{
							string RepeatLevel2;
							if (item2 == item4)
							{
								if (item2.IsLevelStatesRepeated(out var RepeatLevel))
								{
									string key = "[SelfRepeated] " + Volume1 + " | CPG: " + item.Key + " | DAConfig " + string.Join(", ", item2.DataAssetIDs) + " | RepeatControlLevel: " + RepeatLevel;
									RepeatedResult.Add(new KeyValuePair<string, string>(key, ""));
								}
							}
							else if ((Volume1 != Volume2 || item.Key != item3.Key) && item2.IsRepeatWith(item4, out RepeatLevel2))
							{
								string key2 = Volume1 + " | CPG: " + item.Key + " | DAConfig " + string.Join(", ", item2.DataAssetIDs) + " | RepeatControlLevel: " + RepeatLevel2;
								string value = Volume2 + " | CPG: " + item3.Key + " | DAConfig " + string.Join(", ", item4.DataAssetIDs) + " | RepeatControlLevel: " + RepeatLevel2;
								RepeatedResult.Add(new KeyValuePair<string, string>(key2, value));
							}
						}
					}
				}
			}
			return RepeatedResult.Count > 0;
		}

		public bool CheckVolumesSelfRepeated(int LevelID, out List<KeyValuePair<string, string>> RepeatedResult)
		{
			RepeatedResult = new List<KeyValuePair<string, string>>();
			if (!LevelStreamingStateVolumeInfo.ContainsKey(LevelID))
			{
				return false;
			}
			List<string> list = LevelStreamingStateVolumeInfo[LevelID].Keys.ToList();
			for (int i = 0; i < list.Count; i++)
			{
				if (IsVolumesRepeat(LevelID, list[i], list[i], out var RepeatedResult2))
				{
					RepeatedResult.AddRange(RepeatedResult2);
				}
			}
			return RepeatedResult.Count > 0;
		}

		public void AppendCalliopeLevelStreamingStateVolumeInfos(UCalliopeAsset InCalliopeAsset, in Dictionary<int, List<string>> SubLevelInfos)
		{
			Dictionary<int, List<List<int>>> NodeDAs = new Dictionary<int, List<List<int>>>();
			List<int> list = new List<int>();
			if (SubLevelInfos == null || SubLevelInfos.Count == 0)
			{
				return;
			}
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (FGsManagedStreamingLevelStateConfig item in InCalliopeAsset.CalliopeParameters.StreamingLevelStateConfigCollection)
			{
				if (dictionary.TryGetValue(item.LevelID, out var value))
				{
					ListExtensions.AddUnique(value, item.DataAssetID);
				}
				else
				{
					dictionary.Add(item.LevelID, new List<int> { item.DataAssetID });
				}
				list.Add(item.LevelID);
			}
			foreach (KeyValuePair<int, List<int>> DAConfig in dictionary)
			{
				DAConfig.Value.Sort();
				if (NodeDAs.TryGetValue(DAConfig.Key, out var value2))
				{
					if (value2.Find((List<int> r1) => r1.FindIndex((int item) => !DAConfig.Value.Contains(item)) >= 0) != null)
					{
						value2.Add(new List<int>(DAConfig.Value));
					}
				}
				else
				{
					NodeDAs.Add(DAConfig.Key, new List<List<int>>
					{
						new List<int>(DAConfig.Value)
					});
				}
			}
			dictionary.Clear();
			foreach (UCalliopeNode value5 in InCalliopeAsset.Nodes.Values)
			{
				if (value5 == null)
				{
					continue;
				}
				for (int num = 0; num < value5.SceneObjPoliceConfig.StreamingLevelStateConfigCollection.Count; num++)
				{
					int key = list[num];
					int actualParam = value5.SceneObjPoliceConfig.StreamingLevelStateConfigCollection[num].ManagedDataAssetID.ActualParam;
					if (dictionary.TryGetValue(key, out var value3))
					{
						ListExtensions.AddUnique(value3, actualParam);
						continue;
					}
					dictionary.Add(key, new List<int> { actualParam });
				}
				foreach (KeyValuePair<int, List<int>> DAConfig2 in dictionary)
				{
					DAConfig2.Value.Sort();
					if (NodeDAs.TryGetValue(DAConfig2.Key, out var value4))
					{
						if (value4.Find((List<int> r1) => r1.Count == DAConfig2.Value.Count && !r1.Except(DAConfig2.Value).Any()) == null)
						{
							value4.Add(new List<int>(DAConfig2.Value));
						}
					}
					else
					{
						NodeDAs.Add(DAConfig2.Key, new List<List<int>>
						{
							new List<int>(DAConfig2.Value)
						});
					}
				}
				dictionary.Clear();
			}
			AppendCalliopeInfo(InCalliopeAsset, in SubLevelInfos, in NodeDAs);
		}

		private void AppendCalliopeInfo(UCalliopeAsset InCalliopeAsset, in Dictionary<int, List<string>> SubLevelInfos, in Dictionary<int, List<List<int>>> NodeDAs)
		{
			BGUFuncLibNonRuntime.LoadProtobufData<FUStStreamingLevelStateDesc>();
			string pathName = InCalliopeAsset.PathName;
			foreach (KeyValuePair<int, List<List<int>>> NodeDA in NodeDAs)
			{
				int key = NodeDA.Key;
				if (!SubLevelInfos.ContainsKey(key))
				{
					continue;
				}
				if (!LevelStreamingStateVolumeInfo.ContainsKey(key))
				{
					LevelStreamingStateVolumeInfo.Add(key, new Dictionary<string, Dictionary<string, List<FCalliopeNodeStreamingStateVolumeInfo>>>());
				}
				foreach (List<int> DAConfigs in NodeDA.Value)
				{
					FGSLevelStateControlInfo fGSLevelStateControlInfo = new FGSLevelStateControlInfo();
					foreach (int item in DAConfigs)
					{
						BGWDataAsset_StreamingLevelStateConfig bGWDataAsset_StreamingLevelStateConfig = UObject.LoadObject<BGWDataAsset_StreamingLevelStateConfig>(null, BGW_GameDB.GetStreamingLevelStateDesc(item)?.DataAssetPath);
						if (bGWDataAsset_StreamingLevelStateConfig == null)
						{
							continue;
						}
						foreach (KeyValuePair<string, FGSSubLevelStates> item2 in bGWDataAsset_StreamingLevelStateConfig.ToConfigInfo(EGSLevelStateInfoLayerType.CPG, $"{pathName} | DA: {bGWDataAsset_StreamingLevelStateConfig}").TriggerLevelManageInfo)
						{
							FGSSubLevelStates fGSSubLevelStates = new FGSSubLevelStates();
							foreach (KeyValuePair<string, FGSLevelStateInfo> DALevelStateInfo in item2.Value.ManagedLevels)
							{
								List<string> list = (DALevelStateInfo.Value.DisableKeyword ? new List<string> { DALevelStateInfo.Key } : SubLevelInfos[key].FindAll((string r) => r.Contains(DALevelStateInfo.Key)));
								FGSLevelStateInfo stateInfo = new FGSLevelStateInfo("Temp", DALevelStateInfo.Value.LevelState, DALevelStateInfo.Value.DisableKeyword, EGSLevelStateInfoLayerType.CPG, $"{pathName} | DA: {item} | Volume: {item2.Key} | Keyword: {DALevelStateInfo.Key}");
								foreach (string item3 in list)
								{
									fGSSubLevelStates.MergeLevelStateInfo(item3, stateInfo);
								}
							}
							if (!fGSLevelStateControlInfo.TriggerLevelManageInfo.ContainsKey(item2.Key))
							{
								fGSLevelStateControlInfo.TriggerLevelManageInfo[item2.Key] = fGSSubLevelStates;
							}
							else
							{
								fGSLevelStateControlInfo.TriggerLevelManageInfo[item2.Key].MergeInfo(fGSSubLevelStates);
							}
						}
					}
					foreach (KeyValuePair<string, FGSSubLevelStates> item4 in fGSLevelStateControlInfo.TriggerLevelManageInfo)
					{
						if (!LevelStreamingStateVolumeInfo[key].ContainsKey(item4.Key))
						{
							LevelStreamingStateVolumeInfo[key].Add(item4.Key, new Dictionary<string, List<FCalliopeNodeStreamingStateVolumeInfo>>());
						}
						Dictionary<string, List<FCalliopeNodeStreamingStateVolumeInfo>> dictionary = LevelStreamingStateVolumeInfo[key][item4.Key];
						FGSSubLevelStates levelStates = new FGSSubLevelStates(item4.Value);
						if (!dictionary.ContainsKey(pathName))
						{
							dictionary[pathName] = new List<FCalliopeNodeStreamingStateVolumeInfo>
							{
								new FCalliopeNodeStreamingStateVolumeInfo(DAConfigs, levelStates)
							};
						}
						else if (dictionary[pathName].FindAll((FCalliopeNodeStreamingStateVolumeInfo r1) => r1.DataAssetIDs.Count == DAConfigs.Count && !r1.DataAssetIDs.Except(DAConfigs).Any()).Count == 0)
						{
							dictionary[pathName].Add(new FCalliopeNodeStreamingStateVolumeInfo(DAConfigs, levelStates));
						}
					}
				}
			}
		}
	}

	public class FGSCalliopeAssetReferenceCheckInfo
	{
		public UCalliopeAsset CalliopeAsset { get; private set; }

		public Dictionary<TSoftObject<AActor>, string> SoftRefGuids { get; private set; }

		public FGSCalliopeAssetReferenceCheckInfo(UCalliopeAsset CalliopeAsset)
		{
			this.CalliopeAsset = CalliopeAsset;
			SoftRefGuids = new Dictionary<TSoftObject<AActor>, string>();
		}
	}

	private static bool BGUCopyAndRenameBHAM_IsValid;

	private static IntPtr BGUCopyAndRenameBHAM_FunctionAddress;

	private static int BGUCopyAndRenameBHAM_ParamsSize;

	private static bool BGUCopyAndRenameBHAM_WorldContext_IsValid;

	private static int BGUCopyAndRenameBHAM_WorldContext_Offset;

	private static bool BGUCopyAndRenameBHAM_IsB1_IsValid;

	private static int BGUCopyAndRenameBHAM_IsB1_Offset;

	private static FFieldAddress BGUCopyAndRenameBHAM_IsB1_PropertyAddress;

	private static bool BGUCopyAndRenameBHAM_BeginResID_IsValid;

	private static int BGUCopyAndRenameBHAM_BeginResID_Offset;

	private static bool BGUCopyAndRenameBHAM_EndResID_IsValid;

	private static int BGUCopyAndRenameBHAM_EndResID_Offset;

	private static bool BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_IsValid;

	private static int BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_Offset;

	private static FFieldAddress BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_PropertyAddress;

	private static bool BGUCopyAndRenameBHAM_Result_IsValid;

	private static int BGUCopyAndRenameBHAM_Result_Offset;

	private static FFieldAddress BGUCopyAndRenameBHAM_Result_PropertyAddress;

	private static bool BGUCopyAndRenameDEADAM_IsValid;

	private static IntPtr BGUCopyAndRenameDEADAM_FunctionAddress;

	private static int BGUCopyAndRenameDEADAM_ParamsSize;

	private static bool BGUCopyAndRenameDEADAM_BeginResID_IsValid;

	private static int BGUCopyAndRenameDEADAM_BeginResID_Offset;

	private static bool BGUCopyAndRenameDEADAM_EndResID_IsValid;

	private static int BGUCopyAndRenameDEADAM_EndResID_Offset;

	private static bool BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_IsValid;

	private static int BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_Offset;

	private static FFieldAddress BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_PropertyAddress;

	private static bool BGUCopyAndRenameDEADAM_Result_IsValid;

	private static int BGUCopyAndRenameDEADAM_Result_Offset;

	private static FFieldAddress BGUCopyAndRenameDEADAM_Result_PropertyAddress;

	private static bool CheckoutAndSavePackage_IsValid;

	private static IntPtr CheckoutAndSavePackage_FunctionAddress;

	private static int CheckoutAndSavePackage_ParamsSize;

	private static bool CheckoutAndSavePackage_Objects_IsValid;

	private static int CheckoutAndSavePackage_Objects_Offset;

	private static FFieldAddress CheckoutAndSavePackage_Objects_PropertyAddress;

	private static bool CheckoutAndSavePackage_FailedPackages_IsValid;

	private static int CheckoutAndSavePackage_FailedPackages_Offset;

	private static FFieldAddress CheckoutAndSavePackage_FailedPackages_PropertyAddress;

	private static bool CheckoutAndSavePackage_bCheckDirty_IsValid;

	private static int CheckoutAndSavePackage_bCheckDirty_Offset;

	private static FFieldAddress CheckoutAndSavePackage_bCheckDirty_PropertyAddress;

	private static bool CheckoutAndSavePackage_bPromptToSave_IsValid;

	private static int CheckoutAndSavePackage_bPromptToSave_Offset;

	private static FFieldAddress CheckoutAndSavePackage_bPromptToSave_PropertyAddress;

	private static bool CheckoutAndSavePackage_bAlreadyCheckedOut_IsValid;

	private static int CheckoutAndSavePackage_bAlreadyCheckedOut_Offset;

	private static FFieldAddress CheckoutAndSavePackage_bAlreadyCheckedOut_PropertyAddress;

	private static bool CheckoutAndSavePackage_bCanBeDeclined_IsValid;

	private static int CheckoutAndSavePackage_bCanBeDeclined_Offset;

	private static FFieldAddress CheckoutAndSavePackage_bCanBeDeclined_PropertyAddress;

	private static bool CheckoutAndSavePackage_ReturnValue_IsValid;

	private static int CheckoutAndSavePackage_ReturnValue_Offset;

	private static FFieldAddress CheckoutAndSavePackage_ReturnValue_PropertyAddress;

	private static bool BGUAddNotifyStateToMontage_IsValid;

	private static IntPtr BGUAddNotifyStateToMontage_FunctionAddress;

	private static int BGUAddNotifyStateToMontage_ParamsSize;

	private static bool BGUAddNotifyStateToMontage_InMontage_IsValid;

	private static int BGUAddNotifyStateToMontage_InMontage_Offset;

	private static bool BGUAddNotifyStateToMontage_TrackName_IsValid;

	private static int BGUAddNotifyStateToMontage_TrackName_Offset;

	private static bool BGUAddNotifyStateToMontage_StartPos_IsValid;

	private static int BGUAddNotifyStateToMontage_StartPos_Offset;

	private static bool BGUAddNotifyStateToMontage_Duration_IsValid;

	private static int BGUAddNotifyStateToMontage_Duration_Offset;

	private static bool BGUAddNotifyStateToMontage_NotifyClass_IsValid;

	private static int BGUAddNotifyStateToMontage_NotifyClass_Offset;

	private static bool BGUAddNotifyStateToMontage_bRemoveOldTrack_IsValid;

	private static int BGUAddNotifyStateToMontage_bRemoveOldTrack_Offset;

	private static FFieldAddress BGUAddNotifyStateToMontage_bRemoveOldTrack_PropertyAddress;

	private static bool BGUSetUnitNameForUDDConfig_IsValid;

	private static IntPtr BGUSetUnitNameForUDDConfig_FunctionAddress;

	private static int BGUSetUnitNameForUDDConfig_ParamsSize;

	private static bool BGUSetUnitNameForUDDConfig_UDDConfig_IsValid;

	private static int BGUSetUnitNameForUDDConfig_UDDConfig_Offset;

	private static bool BGUSetUnitNameForUDDConfig_NormalDeadAMPath_IsValid;

	private static int BGUSetUnitNameForUDDConfig_NormalDeadAMPath_Offset;

	private static FFieldAddress BGUSetUnitNameForUDDConfig_NormalDeadAMPath_PropertyAddress;

	private static bool BGUSetUnitNameForUDDConfig_UnitResName_IsValid;

	private static int BGUSetUnitNameForUDDConfig_UnitResName_Offset;

	private static FFieldAddress BGUSetUnitNameForUDDConfig_UnitResName_PropertyAddress;

	private static bool BGUSetUnitNameForUBAConfig_IsValid;

	private static IntPtr BGUSetUnitNameForUBAConfig_FunctionAddress;

	private static int BGUSetUnitNameForUBAConfig_ParamsSize;

	private static bool BGUSetUnitNameForUBAConfig_UBAConfig_IsValid;

	private static int BGUSetUnitNameForUBAConfig_UBAConfig_Offset;

	private static bool BGUSetUnitNameForUBAConfig_NormalStiffAMPath_IsValid;

	private static int BGUSetUnitNameForUBAConfig_NormalStiffAMPath_Offset;

	private static FFieldAddress BGUSetUnitNameForUBAConfig_NormalStiffAMPath_PropertyAddress;

	private static bool BGUSetUnitNameForUBAConfig_UnitResName_IsValid;

	private static int BGUSetUnitNameForUBAConfig_UnitResName_Offset;

	private static FFieldAddress BGUSetUnitNameForUBAConfig_UnitResName_PropertyAddress;

	private static bool BGUGetNewSweepCheckGroupIdInAM_IsValid;

	private static IntPtr BGUGetNewSweepCheckGroupIdInAM_FunctionAddress;

	private static int BGUGetNewSweepCheckGroupIdInAM_ParamsSize;

	private static bool BGUGetNewSweepCheckGroupIdInAM_InMontage_IsValid;

	private static int BGUGetNewSweepCheckGroupIdInAM_InMontage_Offset;

	private static bool BGUGetNewSweepCheckGroupIdInAM_ReturnValue_IsValid;

	private static int BGUGetNewSweepCheckGroupIdInAM_ReturnValue_Offset;

	private static bool BGUAddBlendPhysicToDeathMontage_IsValid;

	private static IntPtr BGUAddBlendPhysicToDeathMontage_FunctionAddress;

	private static int BGUAddBlendPhysicToDeathMontage_ParamsSize;

	private static bool BGUAddBlendPhysicToDeathMontage_InMontage_IsValid;

	private static int BGUAddBlendPhysicToDeathMontage_InMontage_Offset;

	private static bool BGUAddBlendPhysicToDeathMontage_Thresholds_IsValid;

	private static int BGUAddBlendPhysicToDeathMontage_Thresholds_Offset;

	private static bool BGUAddBlendPhysicToDeathMontage_BoneName_IsValid;

	private static int BGUAddBlendPhysicToDeathMontage_BoneName_Offset;

	private static bool BGUCopyInfoFromUnitComm2UnitDead_IsValid;

	private static IntPtr BGUCopyInfoFromUnitComm2UnitDead_FunctionAddress;

	private static int BGUCopyInfoFromUnitComm2UnitDead_ParamsSize;

	private static bool BGUAddLifeSavingHairWindowToDeathMontage_IsValid;

	private static IntPtr BGUAddLifeSavingHairWindowToDeathMontage_FunctionAddress;

	private static int BGUAddLifeSavingHairWindowToDeathMontage_ParamsSize;

	private static bool BGUAddLifeSavingHairWindowToDeathMontage_InMontage_IsValid;

	private static int BGUAddLifeSavingHairWindowToDeathMontage_InMontage_Offset;

	private static bool GetLevelAllLevelStreamingDataAssetConfigByCPG_IsValid;

	private static IntPtr GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress;

	private static int GetLevelAllLevelStreamingDataAssetConfigByCPG_ParamsSize;

	private static bool GetLevelAllLevelStreamingDataAssetConfigByCPG_LevelName_IsValid;

	private static int GetLevelAllLevelStreamingDataAssetConfigByCPG_LevelName_Offset;

	private static FFieldAddress GetLevelAllLevelStreamingDataAssetConfigByCPG_LevelName_PropertyAddress;

	private static bool GetLevelAllLevelStreamingDataAssetConfigByCPG_ReturnValue_IsValid;

	private static int GetLevelAllLevelStreamingDataAssetConfigByCPG_ReturnValue_Offset;

	private static FFieldAddress GetLevelAllLevelStreamingDataAssetConfigByCPG_ReturnValue_PropertyAddress;

	private static bool GetLevelStreamingStateVolumeControlledLevelInfo_IsValid;

	private static IntPtr GetLevelStreamingStateVolumeControlledLevelInfo_FunctionAddress;

	private static int GetLevelStreamingStateVolumeControlledLevelInfo_ParamsSize;

	private static bool GetLevelStreamingStateVolumeControlledLevelInfo_Volume_IsValid;

	private static int GetLevelStreamingStateVolumeControlledLevelInfo_Volume_Offset;

	private static bool GetLevelStreamingStateVolumeControlledLevelInfo_ReturnValue_IsValid;

	private static int GetLevelStreamingStateVolumeControlledLevelInfo_ReturnValue_Offset;

	private static FFieldAddress GetLevelStreamingStateVolumeControlledLevelInfo_ReturnValue_PropertyAddress;

	public static void LogCpgNpcUsingHiddenBuff()
	{
		UAssetDataArray assetsByClass = UGSEditorContentLibrary.GetAssetsByClass("BED_ProcessAsset", bSearchSubClasses: true);
		if (assetsByClass == null)
		{
			return;
		}
		string text = "";
		foreach (FAssetData item2 in assetsByClass.AssetDataArr)
		{
			UCalliopeAsset uCalliopeAsset = item2.GetAsset() as UCalliopeAsset;
			if (uCalliopeAsset == null || uCalliopeAsset.CalliopeParameters.BuffIDCollection.Count <= 0)
			{
				continue;
			}
			List<UCalliopeNode> list = uCalliopeAsset.GetNodes().Values.ToList();
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
			foreach (UCalliopeNode item3 in list)
			{
				foreach (FGsNPCUnitPoliceConfig NpcInfo in item3.SceneObjPoliceConfig.NPCUnitCollection)
				{
					string item = uCalliopeAsset.CalliopeParameters.NPCUnitCollection.Find((FGsManagedNPCUnit r) => r.ConfigGuid == NpcInfo.ConfigGuid).AliasName.ToString();
					foreach (FGsNPCUnitBuffParamConfig Buff in NpcInfo.ManagedBuffIDList)
					{
						if (!Buff.CanModify)
						{
							continue;
						}
						FGsManagedBuffID fGsManagedBuffID = uCalliopeAsset.CalliopeParameters.BuffIDCollection.Find((FGsManagedBuffID r) => r.ConfigGuid == Buff.ConfigGuid);
						string key = fGsManagedBuffID.AliasName.ToString();
						if (fGsManagedBuffID.NPCUnit.ConfigGuides.Contains(NpcInfo.ConfigGuid))
						{
							continue;
						}
						if (dictionary.ContainsKey(key))
						{
							if (!dictionary[key].Contains(item))
							{
								dictionary[key].Add(item);
							}
						}
						else
						{
							dictionary.Add(key, new List<string> { item });
						}
					}
				}
			}
			if (dictionary.Count <= 0)
			{
				continue;
			}
			string text2 = uCalliopeAsset.PathName + "\n";
			foreach (KeyValuePair<string, List<string>> item4 in dictionary)
			{
				text2 = text2 + "BuffName: " + item4.Key + "  Units: ";
				foreach (string item5 in item4.Value)
				{
					text2 = text2 + " " + item5;
				}
				text2 += "\n";
			}
			text += text2;
		}
		FMessage.OpenDialog(text);
	}

	public static void LogCheckCpgUniqueControl()
	{
		if (CheckCpgUniqueControl(out var CpgUniqueControlResult))
		{
			FMessage.OpenDialog("不存在CPG重复控制的物件");
		}
		else
		{
			FMessage.OpenDialog(CpgUniqueControlResult.ToString());
		}
	}

	public static bool CheckCpgUniqueControl(out FCpgUniqueControlResult CpgUniqueControlResult)
	{
		CpgUniqueControlResult = new FCpgUniqueControlResult();
		UAssetDataArray assetsByClass = UGSEditorContentLibrary.GetAssetsByClass("BED_ProcessAsset", bSearchSubClasses: true);
		if (assetsByClass == null)
		{
			return true;
		}
		foreach (FAssetData item in assetsByClass.AssetDataArr)
		{
			UCalliopeAsset uCalliopeAsset = item.GetAsset() as UCalliopeAsset;
			if (uCalliopeAsset == null)
			{
				continue;
			}
			foreach (FGsManagedDynamicObstacle item2 in uCalliopeAsset.CalliopeParameters.DynamicObstacleCollection)
			{
				CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.DynamicObstacleResult, item2.ActorGuid, uCalliopeAsset.PathName);
			}
			foreach (FGsManagedOverlap item3 in uCalliopeAsset.CalliopeParameters.OverlapCollection)
			{
				CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.OverlapResult, item3.ActorGuid, uCalliopeAsset.PathName);
			}
			foreach (FGsManagedInteractor item4 in uCalliopeAsset.CalliopeParameters.InteractorCollection)
			{
				CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.InteractorResult, item4.ActorGuid, uCalliopeAsset.PathName);
			}
			foreach (FGsManagedSpawner item5 in uCalliopeAsset.CalliopeParameters.SpawnerCollection)
			{
				CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.SpawnerResult, item5.ActorGuid, uCalliopeAsset.PathName);
			}
			foreach (FGsManagedNPCUnit item6 in uCalliopeAsset.CalliopeParameters.NPCUnitCollection)
			{
				if (item6.NPCInstanceGroup.Count == 0)
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.NPCUnitResult, item6.ActorGuid, uCalliopeAsset.PathName);
					continue;
				}
				foreach (FGsNPCReferenceInfo item7 in item6.NPCInstanceGroup)
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.NPCUnitResult, item7.ActorGuid, uCalliopeAsset.PathName);
				}
			}
			foreach (FGsManagedUnit item8 in uCalliopeAsset.CalliopeParameters.UnitCollection)
			{
				CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.UnitResult, item8.ActorGuid, uCalliopeAsset.PathName);
			}
		}
		CpgUniqueControlResult.RemoveAllUniqueItems();
		return CpgUniqueControlResult.IsAllResultEmpty();
	}

	public static bool CheckCalliopeAssetUniqueControl(UCalliopeAsset InCalliopeAsset, out FCpgUniqueControlResult CpgUniqueControlResult)
	{
		CpgUniqueControlResult = new FCpgUniqueControlResult();
		if (InCalliopeAsset == null)
		{
			return true;
		}
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		List<string> list5 = new List<string>();
		List<string> list6 = new List<string>();
		Dictionary<int, List<string>> SubLevelInfos = GetAllLevelsSubLevelInfos();
		AppendCalliopeControlledLevelsInfo(InCalliopeAsset, in SubLevelInfos, CpgUniqueControlResult.CalliopeControlledLevelsInfo);
		foreach (FGsManagedDynamicObstacle item in InCalliopeAsset.CalliopeParameters.DynamicObstacleCollection)
		{
			if (item.NeedStateManaged)
			{
				if (!list.Contains(item.ActorGuid))
				{
					list.Add(item.ActorGuid);
				}
				else
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.DynamicObstacleResult, item.ActorGuid, InCalliopeAsset.PathName);
				}
			}
		}
		foreach (FGsManagedOverlap item2 in InCalliopeAsset.CalliopeParameters.OverlapCollection)
		{
			if (item2.NeedStateManaged)
			{
				if (!list2.Contains(item2.ActorGuid))
				{
					list2.Add(item2.ActorGuid);
				}
				else
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.OverlapResult, item2.ActorGuid, InCalliopeAsset.PathName);
				}
			}
		}
		foreach (FGsManagedInteractor item3 in InCalliopeAsset.CalliopeParameters.InteractorCollection)
		{
			if (item3.NeedStateManaged)
			{
				if (!list3.Contains(item3.ActorGuid))
				{
					list3.Add(item3.ActorGuid);
				}
				else
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.InteractorResult, item3.ActorGuid, InCalliopeAsset.PathName);
				}
			}
		}
		foreach (FGsManagedSpawner item4 in InCalliopeAsset.CalliopeParameters.SpawnerCollection)
		{
			if (item4.NeedStateManaged)
			{
				if (!list4.Contains(item4.ActorGuid))
				{
					list4.Add(item4.ActorGuid);
				}
				else
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.SpawnerResult, item4.ActorGuid, InCalliopeAsset.PathName);
				}
			}
		}
		foreach (FGsManagedNPCUnit item5 in InCalliopeAsset.CalliopeParameters.NPCUnitCollection)
		{
			if (!item5.NeedStateManaged)
			{
				continue;
			}
			if (item5.NPCInstanceGroup.Count == 0)
			{
				if (!list5.Contains(item5.ActorGuid))
				{
					list5.Add(item5.ActorGuid);
				}
				else
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.NPCUnitResult, item5.ActorGuid, InCalliopeAsset.PathName);
				}
				continue;
			}
			foreach (FGsNPCReferenceInfo item6 in item5.NPCInstanceGroup)
			{
				if (!list5.Contains(item6.ActorGuid))
				{
					list5.Add(item6.ActorGuid);
				}
				else
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.NPCUnitResult, item6.ActorGuid, InCalliopeAsset.PathName);
				}
			}
		}
		foreach (FGsManagedUnit item7 in InCalliopeAsset.CalliopeParameters.UnitCollection)
		{
			if (item7.NeedStateManaged)
			{
				if (!list6.Contains(item7.ActorGuid))
				{
					list6.Add(item7.ActorGuid);
				}
				else
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.UnitResult, item7.ActorGuid, InCalliopeAsset.PathName);
				}
			}
		}
		UAssetDataArray assetsByClass = UGSEditorContentLibrary.GetAssetsByClass("BED_ProcessAsset", bSearchSubClasses: true);
		if (assetsByClass == null)
		{
			return true;
		}
		foreach (FAssetData item8 in assetsByClass.AssetDataArr)
		{
			UCalliopeAsset uCalliopeAsset = item8.GetAsset() as UCalliopeAsset;
			if (uCalliopeAsset == null || uCalliopeAsset == InCalliopeAsset)
			{
				continue;
			}
			foreach (FGsManagedDynamicObstacle item9 in uCalliopeAsset.CalliopeParameters.DynamicObstacleCollection)
			{
				if (list.Contains(item9.ActorGuid) && item9.NeedStateManaged)
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.DynamicObstacleResult, item9.ActorGuid, uCalliopeAsset.PathName);
				}
			}
			foreach (FGsManagedOverlap item10 in uCalliopeAsset.CalliopeParameters.OverlapCollection)
			{
				if (list2.Contains(item10.ActorGuid) && item10.NeedStateManaged)
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.OverlapResult, item10.ActorGuid, uCalliopeAsset.PathName);
				}
			}
			foreach (FGsManagedInteractor item11 in uCalliopeAsset.CalliopeParameters.InteractorCollection)
			{
				if (list3.Contains(item11.ActorGuid) && item11.NeedStateManaged)
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.InteractorResult, item11.ActorGuid, uCalliopeAsset.PathName);
				}
			}
			foreach (FGsManagedSpawner item12 in uCalliopeAsset.CalliopeParameters.SpawnerCollection)
			{
				if (list4.Contains(item12.ActorGuid) && item12.NeedStateManaged)
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.SpawnerResult, item12.ActorGuid, uCalliopeAsset.PathName);
				}
			}
			foreach (FGsManagedNPCUnit item13 in uCalliopeAsset.CalliopeParameters.NPCUnitCollection)
			{
				if (!item13.NeedStateManaged)
				{
					continue;
				}
				if (item13.NPCInstanceGroup.Count == 0)
				{
					if (list5.Contains(item13.ActorGuid))
					{
						CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.NPCUnitResult, item13.ActorGuid, uCalliopeAsset.PathName);
					}
					continue;
				}
				foreach (FGsNPCReferenceInfo item14 in item13.NPCInstanceGroup)
				{
					if (list5.Contains(item14.ActorGuid))
					{
						CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.NPCUnitResult, item14.ActorGuid, uCalliopeAsset.PathName);
					}
				}
			}
			foreach (FGsManagedUnit item15 in uCalliopeAsset.CalliopeParameters.UnitCollection)
			{
				if (item15.NeedStateManaged && list6.Contains(item15.ActorGuid))
				{
					CpgUniqueControlResult.AddItem(ref CpgUniqueControlResult.UnitResult, item15.ActorGuid, uCalliopeAsset.PathName);
				}
			}
			AppendCalliopeControlledLevelsInfo(uCalliopeAsset, in SubLevelInfos, CpgUniqueControlResult.CalliopeControlledLevelsInfo, AddNewLevelInfos: false);
		}
		return CpgUniqueControlResult.IsAllResultEmpty();
	}

	public static Dictionary<int, List<string>> GetAllLevelsSubLevelInfos()
	{
		return new Dictionary<int, List<string>>();
	}

	public static void AppendCalliopeControlledLevelsInfo(UCalliopeAsset InCalliopeAsset, in Dictionary<int, List<string>> SubLevelInfos, FCalliopeControlledLevelsInfo CalliopeControlledLevelsInfo, bool AddNewLevelInfos = true)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStStreamingLevelStateDesc>();
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		List<int> list = new List<int>();
		if (SubLevelInfos == null || SubLevelInfos.Count == 0)
		{
			return;
		}
		foreach (FGsManagedStreamingLevelStateConfig item in InCalliopeAsset.CalliopeParameters.StreamingLevelStateConfigCollection)
		{
			if (!dictionary.ContainsKey(item.LevelID))
			{
				dictionary.Add(item.LevelID, new List<int>());
			}
			if (AddNewLevelInfos && !CalliopeControlledLevelsInfo.Info.ContainsKey(item.LevelID))
			{
				CalliopeControlledLevelsInfo.Info.Add(item.LevelID, new Dictionary<string, Dictionary<string, List<int>>>());
			}
			list.Add(item.LevelID);
			ListExtensions.AddUnique(dictionary[item.LevelID], item.LevelID);
		}
		foreach (UCalliopeNode value6 in InCalliopeAsset.Nodes.Values)
		{
			if (!(value6 == null))
			{
				for (int i = 0; i < value6.SceneObjPoliceConfig.StreamingLevelStateConfigCollection.Count; i++)
				{
					ListExtensions.AddUnique(dictionary[list[i]], value6.SceneObjPoliceConfig.StreamingLevelStateConfigCollection[i].ManagedDataAssetID.ActualParam);
				}
			}
		}
		foreach (KeyValuePair<int, List<int>> item2 in dictionary)
		{
			int key = item2.Key;
			List<int> value = item2.Value;
			if (!CalliopeControlledLevelsInfo.Info.TryGetValue(key, out var value2) || !SubLevelInfos.TryGetValue(key, out var value3))
			{
				continue;
			}
			foreach (int item3 in value)
			{
				Dictionary<string, bool> dictionary2 = UObject.LoadObject<BGWDataAsset_StreamingLevelStateConfig>(null, BGW_GameDB.GetStreamingLevelStateDesc(item3)?.DataAssetPath)?.GetAllManagedLevels();
				if (dictionary2 == null)
				{
					continue;
				}
				foreach (KeyValuePair<string, bool> level in dictionary2)
				{
					foreach (string item4 in level.Value ? new List<string> { level.Key } : value3.FindAll((string r) => r.Contains(level.Key)))
					{
						if (value2.TryGetValue(item4, out var value4))
						{
							if (value4.TryGetValue(InCalliopeAsset.PathName, out var value5))
							{
								ListExtensions.AddUnique(value5, item3);
								continue;
							}
							value4.Add(InCalliopeAsset.PathName, new List<int> { item3 });
						}
						else if (AddNewLevelInfos)
						{
							value2.Add(item4, new Dictionary<string, List<int>> { 
							{
								InCalliopeAsset.PathName,
								new List<int> { item3 }
							} });
						}
					}
				}
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:GetLevelAllLevelStreamingDataAssetConfigByCPG")]
	public static string GetLevelAllLevelStreamingDataAssetConfigByCPG(string LevelName)
	{
		return GetLevelIdAllLevelStreamingDataAssetConfigByCPG(BGUFuncLibMap.GetLevelIdByName(LevelName));
	}

	public static string GetLevelIdAllLevelStreamingDataAssetConfigByCPG(int LevelID)
	{
		Dictionary<int, List<string>> SubLevelInfos = GetAllLevelsSubLevelInfos();
		UAssetDataArray assetsByClass = UGSEditorContentLibrary.GetAssetsByClass("BED_ProcessAsset", bSearchSubClasses: true);
		if (assetsByClass == null)
		{
			return "";
		}
		FCalliopeControlledLevelsInfo fCalliopeControlledLevelsInfo = new FCalliopeControlledLevelsInfo();
		foreach (FAssetData item in assetsByClass.AssetDataArr)
		{
			UCalliopeAsset uCalliopeAsset = item.GetAsset() as UCalliopeAsset;
			if (!(uCalliopeAsset == null))
			{
				AppendCalliopeControlledLevelsInfo(uCalliopeAsset, in SubLevelInfos, fCalliopeControlledLevelsInfo);
			}
		}
		return fCalliopeControlledLevelsInfo.GetLevelAllConfigInfo(LevelID);
	}

	public static bool CheckLevelStreamingDataAssetLevelRepeatControl(BGWDataAsset_StreamingLevelStateConfig DataAsset, out string Message)
	{
		Message = "";
		FUStStreamingLevelStateDesc value = BGW_GameDB.GetAllStreamingLevelStateDesc().FirstOrDefault((KeyValuePair<int, FUStStreamingLevelStateDesc> r) => r.Value.DataAssetPath.Contains(DataAsset.PathName)).Value;
		if (value == null)
		{
			return false;
		}
		int iD = value.ID;
		Dictionary<int, List<string>> SubLevelInfos = GetAllLevelsSubLevelInfos();
		UAssetDataArray assetsByClass = UGSEditorContentLibrary.GetAssetsByClass("BED_ProcessAsset", bSearchSubClasses: true);
		if (assetsByClass == null)
		{
			return false;
		}
		FCalliopeControlledLevelsInfo fCalliopeControlledLevelsInfo = new FCalliopeControlledLevelsInfo();
		foreach (FAssetData item in assetsByClass.AssetDataArr)
		{
			UCalliopeAsset uCalliopeAsset = item.GetAsset() as UCalliopeAsset;
			if (!(uCalliopeAsset == null))
			{
				AppendCalliopeControlledLevelsInfo(uCalliopeAsset, in SubLevelInfos, fCalliopeControlledLevelsInfo);
			}
		}
		Message = fCalliopeControlledLevelsInfo.GetDataAssetLevelRepeatControlInfo(iD);
		return Message != "";
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:GetLevelStreamingStateVolumeControlledLevelInfo")]
	public static string GetLevelStreamingStateVolumeControlledLevelInfo(ABGWLevelStreamingStateVolume Volume)
	{
		if (Volume == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		FCalliopeLevelStreamingStateVolumeInfo allCalliopeLevelStreamingStateVolumeInfos = GetAllCalliopeLevelStreamingStateVolumeInfos();
		stringBuilder.AppendLine("■■■■■ 盒子：" + Volume.GetActorLabel() + " ■■■■■");
		foreach (KeyValuePair<int, Dictionary<string, Dictionary<string, List<FCalliopeLevelStreamingStateVolumeInfo.FCalliopeNodeStreamingStateVolumeInfo>>>> item in allCalliopeLevelStreamingStateVolumeInfos.LevelStreamingStateVolumeInfo)
		{
			if (!item.Value.TryGetValue(Volume.PathName, out var value))
			{
				continue;
			}
			stringBuilder.AppendLine("    " + BGUFuncLibMap.GetLevelPathById(item.Key) + ":");
			foreach (KeyValuePair<string, List<FCalliopeLevelStreamingStateVolumeInfo.FCalliopeNodeStreamingStateVolumeInfo>> item2 in value)
			{
				stringBuilder.AppendLine("        " + item2.Key + ":");
				foreach (FCalliopeLevelStreamingStateVolumeInfo.FCalliopeNodeStreamingStateVolumeInfo item3 in item2.Value)
				{
					stringBuilder.AppendLine("            DAConfig: " + string.Join(", ", item3.DataAssetIDs));
					foreach (KeyValuePair<string, FGSLevelStateInfo> managedLevel in item3.LevelStates.ManagedLevels)
					{
						stringBuilder.AppendLine($"                {managedLevel.Key}  |  {managedLevel.Value.LevelState}");
					}
				}
			}
		}
		return stringBuilder.ToString();
	}

	public static FCalliopeLevelStreamingStateVolumeInfo GetAllCalliopeLevelStreamingStateVolumeInfos()
	{
		FCalliopeLevelStreamingStateVolumeInfo fCalliopeLevelStreamingStateVolumeInfo = new FCalliopeLevelStreamingStateVolumeInfo();
		UAssetDataArray assetsByClass = UGSEditorContentLibrary.GetAssetsByClass("BED_ProcessAsset", bSearchSubClasses: true);
		if (assetsByClass == null)
		{
			return fCalliopeLevelStreamingStateVolumeInfo;
		}
		Dictionary<int, List<string>> SubLevelInfos = GetAllLevelsSubLevelInfos();
		foreach (FAssetData item in assetsByClass.AssetDataArr)
		{
			UCalliopeAsset uCalliopeAsset = item.GetAsset() as UCalliopeAsset;
			if (!(uCalliopeAsset == null))
			{
				fCalliopeLevelStreamingStateVolumeInfo.AppendCalliopeLevelStreamingStateVolumeInfos(uCalliopeAsset, in SubLevelInfos);
			}
		}
		return fCalliopeLevelStreamingStateVolumeInfo;
	}

	public static List<FGSCalliopeAssetReferenceCheckInfo> GetAllCalliopeAssetReference()
	{
		List<FGSCalliopeAssetReferenceCheckInfo> list = new List<FGSCalliopeAssetReferenceCheckInfo>();
		foreach (string item in new List<string> { "BED_ProcessAsset", "BED_TaskAsset" })
		{
			UAssetDataArray assetsByClass = UGSEditorContentLibrary.GetAssetsByClass(item, bSearchSubClasses: true);
			if (assetsByClass == null)
			{
				continue;
			}
			foreach (FAssetData item2 in assetsByClass.AssetDataArr)
			{
				UCalliopeAsset uCalliopeAsset = item2.GetAsset() as UCalliopeAsset;
				if (uCalliopeAsset == null)
				{
					continue;
				}
				FGSCalliopeAssetReferenceCheckInfo fGSCalliopeAssetReferenceCheckInfo = new FGSCalliopeAssetReferenceCheckInfo(uCalliopeAsset);
				foreach (FGsManagedDynamicObstacle item3 in uCalliopeAsset.CalliopeParameters.DynamicObstacleCollection)
				{
					fGSCalliopeAssetReferenceCheckInfo.SoftRefGuids[item3.Actor] = item3.ActorGuid;
				}
				foreach (FGsManagedOverlap item4 in uCalliopeAsset.CalliopeParameters.OverlapCollection)
				{
					fGSCalliopeAssetReferenceCheckInfo.SoftRefGuids[item4.Actor] = item4.ActorGuid;
				}
				foreach (FGsManagedInteractor item5 in uCalliopeAsset.CalliopeParameters.InteractorCollection)
				{
					fGSCalliopeAssetReferenceCheckInfo.SoftRefGuids[item5.Actor] = item5.ActorGuid;
				}
				foreach (FGsManagedSpawner item6 in uCalliopeAsset.CalliopeParameters.SpawnerCollection)
				{
					fGSCalliopeAssetReferenceCheckInfo.SoftRefGuids[item6.Actor] = item6.ActorGuid;
				}
				foreach (FGsManagedUnit item7 in uCalliopeAsset.CalliopeParameters.UnitCollection)
				{
					fGSCalliopeAssetReferenceCheckInfo.SoftRefGuids[item7.Tamer] = item7.ActorGuid;
				}
				foreach (FGsManagedNPCUnit item8 in uCalliopeAsset.CalliopeParameters.NPCUnitCollection)
				{
					if (item8.NPCInstanceGroup.Count > 0)
					{
						foreach (FGsNPCReferenceInfo item9 in item8.NPCInstanceGroup)
						{
							_ = item9;
							fGSCalliopeAssetReferenceCheckInfo.SoftRefGuids[item8.Tamer] = item8.ActorGuid;
						}
					}
					else
					{
						fGSCalliopeAssetReferenceCheckInfo.SoftRefGuids[item8.Tamer] = item8.ActorGuid;
					}
				}
				if (fGSCalliopeAssetReferenceCheckInfo.SoftRefGuids.Count > 0)
				{
					list.Add(fGSCalliopeAssetReferenceCheckInfo);
				}
			}
		}
		return list;
	}

	public static void LogCheckInvalidCustomStateMachineDescs()
	{
		List<int> list = CheckInvalidCustomStateMachineDescs();
		if (list.Count == 0)
		{
			FMessage.OpenDialog("CustomStateMachine表所有资源无异常。");
			return;
		}
		string text = "CustomStateMachine表未找到CPG资源ID：";
		foreach (int item in list)
		{
			text = text + " " + item;
		}
		FMessage.OpenDialog(text);
	}

	public static List<int> CheckInvalidCustomStateMachineDescs()
	{
		List<int> list = new List<int>();
		BGUFuncLibNonRuntime.LoadProtobufData<FUStCustomStateMachineDesc>();
		foreach (KeyValuePair<int, FUStCustomStateMachineDesc> item in BG_ProtobufDataAPI<FUStCustomStateMachineDesc>.Get().GetAll())
		{
			UCalliopeAsset uCalliopeAsset = UObject.LoadObject<UCalliopeAsset>(null, item.Value.GraphPath);
			if (uCalliopeAsset == null || GameplayTagExtension.LoadGraph(uCalliopeAsset) != null)
			{
				list.Add(item.Key);
			}
		}
		return list;
	}

	public static void LogCheckCalliopeDataHasValidGraphAsset()
	{
		List<string> list = CheckCalliopeDataHasValidGraphAsset();
		if (list.Count == 0)
		{
			FMessage.OpenDialog("所有Data资源无异常。");
			return;
		}
		string text = "未找到Graph资源的Data路径：";
		foreach (string item in list)
		{
			text = text + "\n" + item;
		}
		FMessage.OpenDialog(text);
	}

	public static List<string> CheckCalliopeDataHasValidGraphAsset()
	{
		List<string> list = new List<string>();
		UGSFileHelper.FindFilesRecursively("/Game/CalliopeData/2.0", out var FoundFiles, "");
		foreach (string item in FoundFiles)
		{
			string assetPathByDataFilePath = BGW_CalliopeDataReader.Get().GetAssetPathByDataFilePath(item);
			if (UObject.LoadObject<UCalliopeAsset>(null, assetPathByDataFilePath) == null)
			{
				list.Add(item);
			}
		}
		return list;
	}

	private static string GetBeAttackedInfoIDStr(int VictimBeAttackedInfoID)
	{
		int num = VictimBeAttackedInfoID % 100;
		if (num < 10)
		{
			return $"0{num.ToString()}";
		}
		return num.ToString();
	}

	public static void GetAMString(UObject WorldContext, bool IsB1, ref List<string> NeedDeletePathList, string OriStr, string DepStr, string SlStr, string dStr, string hStr, out string NewAMPath)
	{
		NewAMPath = "";
		string[] array = OriStr.Split('.');
		string text = ((array.Length != 0) ? array[0] : "");
		string text2 = ((array.Length > 1) ? array[1] : "");
		string[] array2 = text.Substring(0, text.Length - text2.Length).Split('/');
		string arg = ((array2.Length > 4) ? array2[4] : "");
		string text3 = ((array2.Length > 5) ? array2[5] : "");
		string arg2 = ((!IsB1) ? "/Game/02_X2Main/Animation" : "/Game/00Main/Animation");
		string arg3 = $"AM_{text3}_bh_dep{DepStr}_sl{SlStr}_{dStr}_{hStr}";
		string text4 = $"{arg2}/{arg}/{text3}/Montage/behit";
		NewAMPath = string.Format("{0}/{1}.{1}", text4, arg3);
		if (!NeedDeletePathList.Contains(text4))
		{
			NeedDeletePathList.Add(text4);
		}
	}

	[BlueprintCallable]
	[Category("BGU|Res")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:BGUCopyAndRenameBHAM")]
	public static void BGUCopyAndRenameBHAM(UObject WorldContext, bool IsB1, int BeginResID, int EndResID, out List<string> NeedDeleteBHCatalogList, out List<FMoveAMPath> Result)
	{
		NeedDeleteBHCatalogList = new List<string>();
		Result = new List<FMoveAMPath>();
	}

	[Category("BGU|Res")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:BGUSetUnitNameForUBAConfig")]
	public static void BGUSetUnitNameForUBAConfig(BGWDataAsset_UnitBeAttackedConfig UBAConfig, string NormalStiffAMPath, string UnitResName)
	{
		if (UBAConfig != null)
		{
			UBAConfig.NormalStiffAMPath = NormalStiffAMPath;
			UBAConfig.UnitResName = UnitResName;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Res")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:BGUSetUnitNameForUDDConfig")]
	public static void BGUSetUnitNameForUDDConfig(BGWDataAsset_UnitDeathDispConfig UDDConfig, string NormalDeadAMPath, string UnitResName)
	{
		if (UDDConfig != null)
		{
			UDDConfig.NormalDeadAMPath = NormalDeadAMPath;
			UDDConfig.UnitResName = UnitResName;
		}
	}

	private static string GetDeadInfoIDStr(int DeadInfoID)
	{
		int num = DeadInfoID % 100;
		if (num < 10)
		{
			return $"0{num.ToString()}";
		}
		return num.ToString();
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Res")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:BGUCopyAndRenameDEADAM")]
	public static void BGUCopyAndRenameDEADAM(int BeginResID, int EndResID, out List<string> NeedDeleteDeadAMCatalogList, out List<FMoveAMPath> Result)
	{
		NeedDeleteDeadAMCatalogList = new List<string>();
		Result = new List<FMoveAMPath>();
		BGW_GameDB.Init("B1");
		foreach (KeyValuePair<int, FUStUnitDeadOldDesc> item in BGW_GameDB.GetAllUnitDeadOldDesc())
		{
			int unitResID = item.Value.UnitResID;
			if (unitResID < BeginResID || unitResID > EndResID)
			{
				continue;
			}
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(unitResID);
			if (unitCommDesc != null && unitCommDesc.DeadInfoID == item.Key)
			{
				string depStr = "01";
				string deadMontagePathLightFront = item.Value.DeadMontagePathLightFront;
				string deadMontagePathLightLeft = item.Value.DeadMontagePathLightLeft;
				string deadMontagePathLightRight = item.Value.DeadMontagePathLightRight;
				string deadMontagePathLightBehind = item.Value.DeadMontagePathLightBehind;
				string deadMontagePathHeavyFront = item.Value.DeadMontagePathHeavyFront;
				string deadMontagePathHeavyLeft = item.Value.DeadMontagePathHeavyLeft;
				string deadMontagePathHeavyRight = item.Value.DeadMontagePathHeavyRight;
				string deadMontagePathHeavyBehind = item.Value.DeadMontagePathHeavyBehind;
				string deadMontagePathFlyFront = item.Value.DeadMontagePathFlyFront;
				string deadMontagePathFlyLeft = item.Value.DeadMontagePathFlyLeft;
				string deadMontagePathFlyRight = item.Value.DeadMontagePathFlyRight;
				string deadMontagePathFlyBehind = item.Value.DeadMontagePathFlyBehind;
				switch (unitCommDesc.UnitBodyType)
				{
				case EUnitBodyType.Small:
				case EUnitBodyType.Medium:
				case EUnitBodyType.MediumBig:
					Result.AddRange(new List<FMoveAMPath>
					{
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathLightFront, depStr, "1", "df", "hf"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathLightLeft, depStr, "1", "dl", "hl"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathLightRight, depStr, "1", "dr", "hr"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathLightBehind, depStr, "1", "db", "hb"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyFront, depStr, "2", "df", "hf"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyLeft, depStr, "2", "dl", "hl"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyRight, depStr, "2", "dr", "hr"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyBehind, depStr, "2", "db", "hb"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyFront, depStr, "5", "df", "hf"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyLeft, depStr, "5", "dl", "hl"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyRight, depStr, "5", "dr", "hr"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyBehind, depStr, "5", "db", "hb")
					});
					break;
				case EUnitBodyType.Big:
					Result.AddRange(new List<FMoveAMPath>
					{
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyFront, depStr, "1", "df", "hf"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyLeft, depStr, "1", "dl", "hl"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyRight, depStr, "1", "dr", "hr"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyBehind, depStr, "1", "db", "hb"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyFront, depStr, "4", "df", "hf"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyLeft, depStr, "4", "dl", "hl"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyRight, depStr, "4", "dr", "hr"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyBehind, depStr, "4", "db", "hb")
					});
					break;
				case EUnitBodyType.Huge:
					Result.AddRange(new List<FMoveAMPath>
					{
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyFront, depStr, "1", "df", "hf"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyLeft, depStr, "1", "dl", "hl"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyRight, depStr, "1", "dr", "hr"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathHeavyBehind, depStr, "1", "db", "hb"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyFront, depStr, "2", "df", "hf"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyLeft, depStr, "2", "dl", "hl"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyRight, depStr, "2", "dr", "hr"),
						GetMoveDeadAMPath(ref NeedDeleteDeadAMCatalogList, deadMontagePathFlyBehind, depStr, "2", "db", "hb")
					});
					break;
				}
			}
		}
	}

	public static FMoveAMPath GetMoveDeadAMPath(ref List<string> NeedDeletePathList, string OriStr, string DepStr, string SlStr, string dStr, string hStr)
	{
		string[] array = OriStr.Split('.');
		string text = ((array.Length != 0) ? array[0] : "");
		string text2 = ((array.Length > 1) ? array[1] : "");
		string[] array2 = text.Substring(0, text.Length - text2.Length).Split('/');
		string arg = ((array2.Length > 4) ? array2[4] : "");
		string text3 = ((array2.Length > 5) ? array2[5] : "");
		string arg2 = "/Game/00Main/Animation";
		string arg3 = $"AM_{text3}_die_dep{DepStr}_sl{SlStr}_{dStr}_{hStr}_nor";
		string text4 = $"{arg2}/{arg}/{text3}/Montage/dead";
		string newAMName = string.Format("{0}/{1}.{1}", text4, arg3);
		if (!NeedDeletePathList.Contains(text4))
		{
			NeedDeletePathList.Add(text4);
		}
		return new FMoveAMPath(OriStr, newAMName);
	}

	[Category("BGU|Res")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:BGUCopyInfoFromUnitComm2UnitDead")]
	public static void BGUCopyInfoFromUnitComm2UnitDead()
	{
		string path = "D:\\unitcomm2unitdead.csv";
		if (!File.Exists(path))
		{
			File.Delete(path);
		}
	}

	[Category("BGU|Res")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:BGUAddBlendPhysicToDeathMontage")]
	public static void BGUAddBlendPhysicToDeathMontage(UAnimMontage InMontage, float Thresholds, FName BoneName)
	{
		Thresholds = MathLib.Clamp(Thresholds, 0f, 1f);
		if (!(InMontage != null))
		{
			return;
		}
		FName blendPhysicForDeath = B1GlobalFNames.BlendPhysicForDeath;
		bool flag = true;
		UAnimationLibrary.GetAnimationNotifyTrackNames(InMontage, out var TrackNames);
		if (TrackNames != null && TrackNames.Count > 0)
		{
			foreach (FName item in TrackNames)
			{
				if (item.Equals(blendPhysicForDeath))
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			UAnimationLibrary.AddAnimationNotifyTrack(InMontage, blendPhysicForDeath, FLinearColor.Red);
		}
		float num = 0f;
		float num2 = float.MinValue;
		float num3 = 0f;
		float num4 = float.MaxValue;
		float playLength = InMontage.GetPlayLength();
		for (float num5 = 0f; num5 < playLength; num5 += 0.05f)
		{
			FTransform fTransform = UGSE_AnimFuncLib.Montage_GetBoneTransformCS(InMontage, num5, BoneName, FName.None, bExtractRootMotion: true);
			if (fTransform.GetLocation().Z > num2)
			{
				num2 = fTransform.GetLocation().Z;
				num = num5;
			}
			if (fTransform.GetLocation().Z < num4)
			{
				num4 = fTransform.GetLocation().Z;
				num3 = num5;
			}
		}
		if (num3 < num)
		{
			num3 = num;
		}
		num = MathLib.Clamp(num, 0f, playLength);
		if (!(UGSE_AnimFuncLib.AddAnimationNotifyStateEvent(InMontage, blendPhysicForDeath, (num3 - num) * Thresholds + num, 0.5f, UClass.GetClass(typeof(b1.BANS_GSBlendPhysicForDeath))) as b1.BANS_GSBlendPhysicForDeath == null))
		{
			UGSE_AnimFuncLib.CheckoutLoadedAssetAndSave(InMontage);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|Res")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:BGUAddLifeSavingHairWindowToDeathMontage")]
	public static void BGUAddLifeSavingHairWindowToDeathMontage(UAnimMontage InMontage)
	{
		if (!(InMontage != null))
		{
			return;
		}
		FName lifeSavingHair = B1GlobalFNames.LifeSavingHair;
		bool flag = true;
		UAnimationLibrary.GetAnimationNotifyTrackNames(InMontage, out var TrackNames);
		if (TrackNames != null && TrackNames.Count > 0)
		{
			foreach (FName item in TrackNames)
			{
				if (item.Equals(lifeSavingHair))
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			UAnimationLibrary.AddAnimationNotifyTrack(InMontage, lifeSavingHair, FLinearColor.Green);
		}
		float playLength = InMontage.GetPlayLength();
		float startTime = MathLib.Clamp(playLength - 0.2f, 0f, playLength);
		if (!(UGSE_AnimFuncLib.AddAnimationNotifyStateEvent(InMontage, lifeSavingHair, startTime, 0.2f, UClass.GetClass(typeof(b1.BANS_LifeSavingHairWindow))) as b1.BANS_LifeSavingHairWindow == null))
		{
			UGSE_AnimFuncLib.MarkDirtyAM(InMontage);
		}
	}

	[Category("BGU|Res")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:BGUAddNotifyStateToMontage")]
	public static void BGUAddNotifyStateToMontage(UAnimMontage InMontage, FName TrackName, float StartPos, float Duration, TSubclassOf<BANS_GSBase> NotifyClass, bool bRemoveOldTrack = false)
	{
		if (InMontage == null)
		{
			return;
		}
		bool flag = true;
		UAnimationLibrary.GetAnimationNotifyTrackNames(InMontage, out var TrackNames);
		if (TrackNames != null && TrackNames.Count > 0)
		{
			foreach (FName item in TrackNames)
			{
				if (item.Equals(TrackName))
				{
					if (bRemoveOldTrack)
					{
						UAnimationLibrary.RemoveAnimationNotifyTrack(InMontage, TrackName);
					}
					else
					{
						flag = false;
					}
					break;
				}
			}
		}
		if (flag)
		{
			UAnimationLibrary.AddAnimationNotifyTrack(InMontage, TrackName, FLinearColor.Yellow);
		}
		StartPos = FMath.Clamp(StartPos, 0f, InMontage.GetPlayLength());
		if (!(UGSE_AnimFuncLib.AddAnimationNotifyStateEvent(InMontage, TrackName, StartPos, Duration, NotifyClass.Value) == null))
		{
			UGSE_AnimFuncLib.MarkDirtyAM(InMontage);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintPure]
	[Category("BGU|Res")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:BGUGetNewSweepCheckGroupIdInAM")]
	public static int BGUGetNewSweepCheckGroupIdInAM(UAnimMontage InMontage)
	{
		int GroupId = 0;
		if (UGSE_AnimFuncLib.GetAnimationNotifyEvents(InMontage, out var NotifyEvents))
		{
			for (; NotifyEvents.FindIndex((FAnimNotifyEventSimple r) => r.NotifyStateClass is BANS_GSSweepCheck bANS_GSSweepCheck && bANS_GSSweepCheck.SweepCheckGroupID == GroupId) >= 0; GroupId++)
			{
			}
		}
		return GroupId;
	}

	[Category("BGU|Res")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibResCS:CheckoutAndSavePackage")]
	public static bool CheckoutAndSavePackage(List<UObject> Objects, out List<UPackage> FailedPackages, bool bCheckDirty = true, bool bPromptToSave = true, bool bAlreadyCheckedOut = false, bool bCanBeDeclined = true)
	{
		List<UPackage> list = new List<UPackage>();
		FailedPackages = new List<UPackage>();
		foreach (UObject Object in Objects)
		{
			ListExtensions.AddUnique(list, Object.GetOutermost());
		}
		return UGSFuncLibForEditor.CheckoutAndSavePackage(list, bCheckDirty, bPromptToSave, out FailedPackages);
	}

	public static Dictionary<int, List<string>> GetExportedLevelNiagaraAssets()
	{
		Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();
		foreach (LevelDesc item in GameDBRuntime.GetTBLevelDesc().List)
		{
			List<string> list = new List<string>();
			string fullPath = Path.GetFullPath(FPaths.Combine(FPaths.ProjectDir, "GSDataTable\\ZTable_GSExportData\\Export_" + item.Path + ".xlsx"));
			if (!File.Exists(fullPath))
			{
				continue;
			}
			try
			{
				OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fullPath + ";Extended Properties='Excel 12.0 Xml;HDR=YES';");
				oleDbConnection.Open();
				using (OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM [SceneNiagara$]", oleDbConnection))
				{
					using OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					while (oleDbDataReader.Read())
					{
						for (int i = 0; i < oleDbDataReader.FieldCount; i++)
						{
							list.Add(oleDbDataReader.GetValue(i).ToString());
						}
					}
				}
				dictionary.Add(item.Id, list);
			}
			catch
			{
			}
		}
		return dictionary;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:BGUCopyAndRenameBHAM")]
	private static void BGUCopyAndRenameBHAM__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameBHAM_WorldContext_Offset));
		bool isB = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameBHAM_IsB1_Offset), 0, BGUCopyAndRenameBHAM_IsB1_PropertyAddress.Address);
		int beginResID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameBHAM_BeginResID_Offset));
		int endResID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameBHAM_EndResID_Offset));
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> NeedDeleteBHCatalogList = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_Offset));
		TArrayCopyMarshaler<FMoveAMPath> tArrayCopyMarshaler2 = new TArrayCopyMarshaler<FMoveAMPath>(1, BGUCopyAndRenameBHAM_Result_PropertyAddress, CachedMarshalingDelegates<FMoveAMPath, FMoveAMPath>.FromNative, CachedMarshalingDelegates<FMoveAMPath, FMoveAMPath>.ToNative);
		List<FMoveAMPath> Result = tArrayCopyMarshaler2.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameBHAM_Result_Offset));
		BGUCopyAndRenameBHAM(worldContext, isB, beginResID, endResID, out NeedDeleteBHCatalogList, out Result);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_Offset), NeedDeleteBHCatalogList);
		tArrayCopyMarshaler2.ToNative(IntPtr.Add(buffer, BGUCopyAndRenameBHAM_Result_Offset), Result);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:BGUCopyAndRenameDEADAM")]
	private static void BGUCopyAndRenameDEADAM__Invoker(IntPtr buffer, IntPtr obj)
	{
		int beginResID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameDEADAM_BeginResID_Offset));
		int endResID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameDEADAM_EndResID_Offset));
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> NeedDeleteDeadAMCatalogList = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_Offset));
		TArrayCopyMarshaler<FMoveAMPath> tArrayCopyMarshaler2 = new TArrayCopyMarshaler<FMoveAMPath>(1, BGUCopyAndRenameDEADAM_Result_PropertyAddress, CachedMarshalingDelegates<FMoveAMPath, FMoveAMPath>.FromNative, CachedMarshalingDelegates<FMoveAMPath, FMoveAMPath>.ToNative);
		List<FMoveAMPath> Result = tArrayCopyMarshaler2.FromNative(IntPtr.Add(buffer, BGUCopyAndRenameDEADAM_Result_Offset));
		BGUCopyAndRenameDEADAM(beginResID, endResID, out NeedDeleteDeadAMCatalogList, out Result);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_Offset), NeedDeleteDeadAMCatalogList);
		tArrayCopyMarshaler2.ToNative(IntPtr.Add(buffer, BGUCopyAndRenameDEADAM_Result_Offset), Result);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:CheckoutAndSavePackage")]
	private static void CheckoutAndSavePackage__Invoker(IntPtr buffer, IntPtr obj)
	{
		List<UObject> objects = new TArrayCopyMarshaler<UObject>(1, CheckoutAndSavePackage_Objects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(buffer, CheckoutAndSavePackage_Objects_Offset));
		TArrayCopyMarshaler<UPackage> tArrayCopyMarshaler = new TArrayCopyMarshaler<UPackage>(1, CheckoutAndSavePackage_FailedPackages_PropertyAddress, CachedMarshalingDelegates<UPackage, UObjectMarshaler<UPackage>>.FromNative, CachedMarshalingDelegates<UPackage, UObjectMarshaler<UPackage>>.ToNative);
		List<UPackage> FailedPackages = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, CheckoutAndSavePackage_FailedPackages_Offset));
		bool bCheckDirty = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckoutAndSavePackage_bCheckDirty_Offset), 0, CheckoutAndSavePackage_bCheckDirty_PropertyAddress.Address);
		bool bPromptToSave = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckoutAndSavePackage_bPromptToSave_Offset), 0, CheckoutAndSavePackage_bPromptToSave_PropertyAddress.Address);
		bool bAlreadyCheckedOut = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckoutAndSavePackage_bAlreadyCheckedOut_Offset), 0, CheckoutAndSavePackage_bAlreadyCheckedOut_PropertyAddress.Address);
		bool bCanBeDeclined = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckoutAndSavePackage_bCanBeDeclined_Offset), 0, CheckoutAndSavePackage_bCanBeDeclined_PropertyAddress.Address);
		bool value = CheckoutAndSavePackage(objects, out FailedPackages, bCheckDirty, bPromptToSave, bAlreadyCheckedOut, bCanBeDeclined);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckoutAndSavePackage_ReturnValue_Offset), 0, CheckoutAndSavePackage_ReturnValue_PropertyAddress.Address, value);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, CheckoutAndSavePackage_FailedPackages_Offset), FailedPackages);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:BGUAddNotifyStateToMontage")]
	private static void BGUAddNotifyStateToMontage__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimMontage inMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, BGUAddNotifyStateToMontage_InMontage_Offset));
		FName trackName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, BGUAddNotifyStateToMontage_TrackName_Offset));
		float startPos = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAddNotifyStateToMontage_StartPos_Offset));
		float duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAddNotifyStateToMontage_Duration_Offset));
		TSubclassOf<BANS_GSBase> notifyClass = TSubclassOfMarshaler<BANS_GSBase>.FromNative(IntPtr.Add(buffer, BGUAddNotifyStateToMontage_NotifyClass_Offset));
		bool bRemoveOldTrack = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUAddNotifyStateToMontage_bRemoveOldTrack_Offset), 0, BGUAddNotifyStateToMontage_bRemoveOldTrack_PropertyAddress.Address);
		BGUAddNotifyStateToMontage(inMontage, trackName, startPos, duration, notifyClass, bRemoveOldTrack);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:BGUSetUnitNameForUDDConfig")]
	private static void BGUSetUnitNameForUDDConfig__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_UnitDeathDispConfig uDDConfig = UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.FromNative(IntPtr.Add(buffer, BGUSetUnitNameForUDDConfig_UDDConfig_Offset));
		string normalDeadAMPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUSetUnitNameForUDDConfig_NormalDeadAMPath_Offset));
		string unitResName = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUSetUnitNameForUDDConfig_UnitResName_Offset));
		BGUSetUnitNameForUDDConfig(uDDConfig, normalDeadAMPath, unitResName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:BGUSetUnitNameForUBAConfig")]
	private static void BGUSetUnitNameForUBAConfig__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_UnitBeAttackedConfig uBAConfig = UObjectMarshaler<BGWDataAsset_UnitBeAttackedConfig>.FromNative(IntPtr.Add(buffer, BGUSetUnitNameForUBAConfig_UBAConfig_Offset));
		string normalStiffAMPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUSetUnitNameForUBAConfig_NormalStiffAMPath_Offset));
		string unitResName = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUSetUnitNameForUBAConfig_UnitResName_Offset));
		BGUSetUnitNameForUBAConfig(uBAConfig, normalStiffAMPath, unitResName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:BGUGetNewSweepCheckGroupIdInAM")]
	private static void BGUGetNewSweepCheckGroupIdInAM__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimMontage inMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, BGUGetNewSweepCheckGroupIdInAM_InMontage_Offset));
		int value = BGUGetNewSweepCheckGroupIdInAM(inMontage);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUGetNewSweepCheckGroupIdInAM_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:BGUAddBlendPhysicToDeathMontage")]
	private static void BGUAddBlendPhysicToDeathMontage__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimMontage inMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, BGUAddBlendPhysicToDeathMontage_InMontage_Offset));
		float thresholds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAddBlendPhysicToDeathMontage_Thresholds_Offset));
		FName boneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, BGUAddBlendPhysicToDeathMontage_BoneName_Offset));
		BGUAddBlendPhysicToDeathMontage(inMontage, thresholds, boneName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:BGUCopyInfoFromUnitComm2UnitDead")]
	private static void BGUCopyInfoFromUnitComm2UnitDead__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCopyInfoFromUnitComm2UnitDead();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:BGUAddLifeSavingHairWindowToDeathMontage")]
	private static void BGUAddLifeSavingHairWindowToDeathMontage__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimMontage inMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, BGUAddLifeSavingHairWindowToDeathMontage_InMontage_Offset));
		BGUAddLifeSavingHairWindowToDeathMontage(inMontage);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:GetLevelAllLevelStreamingDataAssetConfigByCPG")]
	private static void GetLevelAllLevelStreamingDataAssetConfigByCPG__Invoker(IntPtr buffer, IntPtr obj)
	{
		string levelName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetLevelAllLevelStreamingDataAssetConfigByCPG_LevelName_Offset));
		string levelAllLevelStreamingDataAssetConfigByCPG = GetLevelAllLevelStreamingDataAssetConfigByCPG(levelName);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetLevelAllLevelStreamingDataAssetConfigByCPG_ReturnValue_Offset), levelAllLevelStreamingDataAssetConfigByCPG);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibResCS:GetLevelStreamingStateVolumeControlledLevelInfo")]
	private static void GetLevelStreamingStateVolumeControlledLevelInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		ABGWLevelStreamingStateVolume volume = UObjectMarshaler<ABGWLevelStreamingStateVolume>.FromNative(IntPtr.Add(buffer, GetLevelStreamingStateVolumeControlledLevelInfo_Volume_Offset));
		string levelStreamingStateVolumeControlledLevelInfo = GetLevelStreamingStateVolumeControlledLevelInfo(volume);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetLevelStreamingStateVolumeControlledLevelInfo_ReturnValue_Offset), levelStreamingStateVolumeControlledLevelInfo);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibResCS");
		BGUCopyAndRenameBHAM_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCopyAndRenameBHAM");
		BGUCopyAndRenameBHAM_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCopyAndRenameBHAM_FunctionAddress);
		BGUCopyAndRenameBHAM_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameBHAM_FunctionAddress, "WorldContext");
		BGUCopyAndRenameBHAM_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameBHAM_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUCopyAndRenameBHAM_IsB1_PropertyAddress, BGUCopyAndRenameBHAM_FunctionAddress, "IsB1");
		BGUCopyAndRenameBHAM_IsB1_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameBHAM_FunctionAddress, "IsB1");
		BGUCopyAndRenameBHAM_IsB1_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameBHAM_FunctionAddress, "IsB1", Classes.FBoolProperty);
		BGUCopyAndRenameBHAM_BeginResID_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameBHAM_FunctionAddress, "BeginResID");
		BGUCopyAndRenameBHAM_BeginResID_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameBHAM_FunctionAddress, "BeginResID", Classes.FIntProperty);
		BGUCopyAndRenameBHAM_EndResID_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameBHAM_FunctionAddress, "EndResID");
		BGUCopyAndRenameBHAM_EndResID_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameBHAM_FunctionAddress, "EndResID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_PropertyAddress, BGUCopyAndRenameBHAM_FunctionAddress, "NeedDeleteBHCatalogList");
		BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameBHAM_FunctionAddress, "NeedDeleteBHCatalogList");
		BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameBHAM_FunctionAddress, "NeedDeleteBHCatalogList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BGUCopyAndRenameBHAM_Result_PropertyAddress, BGUCopyAndRenameBHAM_FunctionAddress, "Result");
		BGUCopyAndRenameBHAM_Result_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameBHAM_FunctionAddress, "Result");
		BGUCopyAndRenameBHAM_Result_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameBHAM_FunctionAddress, "Result", Classes.FArrayProperty);
		BGUCopyAndRenameBHAM_IsValid = BGUCopyAndRenameBHAM_FunctionAddress != IntPtr.Zero && BGUCopyAndRenameBHAM_WorldContext_IsValid && BGUCopyAndRenameBHAM_IsB1_IsValid && BGUCopyAndRenameBHAM_BeginResID_IsValid && BGUCopyAndRenameBHAM_EndResID_IsValid && BGUCopyAndRenameBHAM_NeedDeleteBHCatalogList_IsValid && BGUCopyAndRenameBHAM_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:BGUCopyAndRenameBHAM", BGUCopyAndRenameBHAM_IsValid);
		BGUCopyAndRenameDEADAM_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCopyAndRenameDEADAM");
		BGUCopyAndRenameDEADAM_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCopyAndRenameDEADAM_FunctionAddress);
		BGUCopyAndRenameDEADAM_BeginResID_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameDEADAM_FunctionAddress, "BeginResID");
		BGUCopyAndRenameDEADAM_BeginResID_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameDEADAM_FunctionAddress, "BeginResID", Classes.FIntProperty);
		BGUCopyAndRenameDEADAM_EndResID_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameDEADAM_FunctionAddress, "EndResID");
		BGUCopyAndRenameDEADAM_EndResID_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameDEADAM_FunctionAddress, "EndResID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_PropertyAddress, BGUCopyAndRenameDEADAM_FunctionAddress, "NeedDeleteDeadAMCatalogList");
		BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameDEADAM_FunctionAddress, "NeedDeleteDeadAMCatalogList");
		BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameDEADAM_FunctionAddress, "NeedDeleteDeadAMCatalogList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BGUCopyAndRenameDEADAM_Result_PropertyAddress, BGUCopyAndRenameDEADAM_FunctionAddress, "Result");
		BGUCopyAndRenameDEADAM_Result_Offset = NativeReflection.GetPropertyOffset(BGUCopyAndRenameDEADAM_FunctionAddress, "Result");
		BGUCopyAndRenameDEADAM_Result_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyAndRenameDEADAM_FunctionAddress, "Result", Classes.FArrayProperty);
		BGUCopyAndRenameDEADAM_IsValid = BGUCopyAndRenameDEADAM_FunctionAddress != IntPtr.Zero && BGUCopyAndRenameDEADAM_BeginResID_IsValid && BGUCopyAndRenameDEADAM_EndResID_IsValid && BGUCopyAndRenameDEADAM_NeedDeleteDeadAMCatalogList_IsValid && BGUCopyAndRenameDEADAM_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:BGUCopyAndRenameDEADAM", BGUCopyAndRenameDEADAM_IsValid);
		CheckoutAndSavePackage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckoutAndSavePackage");
		CheckoutAndSavePackage_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckoutAndSavePackage_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckoutAndSavePackage_Objects_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "Objects");
		CheckoutAndSavePackage_Objects_Offset = NativeReflection.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "Objects");
		CheckoutAndSavePackage_Objects_IsValid = NativeReflection.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "Objects", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CheckoutAndSavePackage_FailedPackages_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "FailedPackages");
		CheckoutAndSavePackage_FailedPackages_Offset = NativeReflection.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "FailedPackages");
		CheckoutAndSavePackage_FailedPackages_IsValid = NativeReflection.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "FailedPackages", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CheckoutAndSavePackage_bCheckDirty_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "bCheckDirty");
		CheckoutAndSavePackage_bCheckDirty_Offset = NativeReflection.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "bCheckDirty");
		CheckoutAndSavePackage_bCheckDirty_IsValid = NativeReflection.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "bCheckDirty", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CheckoutAndSavePackage_bPromptToSave_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "bPromptToSave");
		CheckoutAndSavePackage_bPromptToSave_Offset = NativeReflection.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "bPromptToSave");
		CheckoutAndSavePackage_bPromptToSave_IsValid = NativeReflection.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "bPromptToSave", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CheckoutAndSavePackage_bAlreadyCheckedOut_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "bAlreadyCheckedOut");
		CheckoutAndSavePackage_bAlreadyCheckedOut_Offset = NativeReflection.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "bAlreadyCheckedOut");
		CheckoutAndSavePackage_bAlreadyCheckedOut_IsValid = NativeReflection.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "bAlreadyCheckedOut", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CheckoutAndSavePackage_bCanBeDeclined_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "bCanBeDeclined");
		CheckoutAndSavePackage_bCanBeDeclined_Offset = NativeReflection.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "bCanBeDeclined");
		CheckoutAndSavePackage_bCanBeDeclined_IsValid = NativeReflection.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "bCanBeDeclined", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CheckoutAndSavePackage_ReturnValue_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "ReturnValue");
		CheckoutAndSavePackage_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "ReturnValue");
		CheckoutAndSavePackage_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckoutAndSavePackage_IsValid = CheckoutAndSavePackage_FunctionAddress != IntPtr.Zero && CheckoutAndSavePackage_Objects_IsValid && CheckoutAndSavePackage_FailedPackages_IsValid && CheckoutAndSavePackage_bCheckDirty_IsValid && CheckoutAndSavePackage_bPromptToSave_IsValid && CheckoutAndSavePackage_bAlreadyCheckedOut_IsValid && CheckoutAndSavePackage_bCanBeDeclined_IsValid && CheckoutAndSavePackage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:CheckoutAndSavePackage", CheckoutAndSavePackage_IsValid);
		BGUAddNotifyStateToMontage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAddNotifyStateToMontage");
		BGUAddNotifyStateToMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAddNotifyStateToMontage_FunctionAddress);
		BGUAddNotifyStateToMontage_InMontage_Offset = NativeReflection.GetPropertyOffset(BGUAddNotifyStateToMontage_FunctionAddress, "InMontage");
		BGUAddNotifyStateToMontage_InMontage_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNotifyStateToMontage_FunctionAddress, "InMontage", Classes.FObjectProperty);
		BGUAddNotifyStateToMontage_TrackName_Offset = NativeReflection.GetPropertyOffset(BGUAddNotifyStateToMontage_FunctionAddress, "TrackName");
		BGUAddNotifyStateToMontage_TrackName_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNotifyStateToMontage_FunctionAddress, "TrackName", Classes.FNameProperty);
		BGUAddNotifyStateToMontage_StartPos_Offset = NativeReflection.GetPropertyOffset(BGUAddNotifyStateToMontage_FunctionAddress, "StartPos");
		BGUAddNotifyStateToMontage_StartPos_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNotifyStateToMontage_FunctionAddress, "StartPos", Classes.FFloatProperty);
		BGUAddNotifyStateToMontage_Duration_Offset = NativeReflection.GetPropertyOffset(BGUAddNotifyStateToMontage_FunctionAddress, "Duration");
		BGUAddNotifyStateToMontage_Duration_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNotifyStateToMontage_FunctionAddress, "Duration", Classes.FFloatProperty);
		BGUAddNotifyStateToMontage_NotifyClass_Offset = NativeReflection.GetPropertyOffset(BGUAddNotifyStateToMontage_FunctionAddress, "NotifyClass");
		BGUAddNotifyStateToMontage_NotifyClass_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNotifyStateToMontage_FunctionAddress, "NotifyClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref BGUAddNotifyStateToMontage_bRemoveOldTrack_PropertyAddress, BGUAddNotifyStateToMontage_FunctionAddress, "bRemoveOldTrack");
		BGUAddNotifyStateToMontage_bRemoveOldTrack_Offset = NativeReflection.GetPropertyOffset(BGUAddNotifyStateToMontage_FunctionAddress, "bRemoveOldTrack");
		BGUAddNotifyStateToMontage_bRemoveOldTrack_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNotifyStateToMontage_FunctionAddress, "bRemoveOldTrack", Classes.FBoolProperty);
		BGUAddNotifyStateToMontage_IsValid = BGUAddNotifyStateToMontage_FunctionAddress != IntPtr.Zero && BGUAddNotifyStateToMontage_InMontage_IsValid && BGUAddNotifyStateToMontage_TrackName_IsValid && BGUAddNotifyStateToMontage_StartPos_IsValid && BGUAddNotifyStateToMontage_Duration_IsValid && BGUAddNotifyStateToMontage_NotifyClass_IsValid && BGUAddNotifyStateToMontage_bRemoveOldTrack_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:BGUAddNotifyStateToMontage", BGUAddNotifyStateToMontage_IsValid);
		BGUSetUnitNameForUDDConfig_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetUnitNameForUDDConfig");
		BGUSetUnitNameForUDDConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetUnitNameForUDDConfig_FunctionAddress);
		BGUSetUnitNameForUDDConfig_UDDConfig_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitNameForUDDConfig_FunctionAddress, "UDDConfig");
		BGUSetUnitNameForUDDConfig_UDDConfig_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitNameForUDDConfig_FunctionAddress, "UDDConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetUnitNameForUDDConfig_NormalDeadAMPath_PropertyAddress, BGUSetUnitNameForUDDConfig_FunctionAddress, "NormalDeadAMPath");
		BGUSetUnitNameForUDDConfig_NormalDeadAMPath_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitNameForUDDConfig_FunctionAddress, "NormalDeadAMPath");
		BGUSetUnitNameForUDDConfig_NormalDeadAMPath_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitNameForUDDConfig_FunctionAddress, "NormalDeadAMPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref BGUSetUnitNameForUDDConfig_UnitResName_PropertyAddress, BGUSetUnitNameForUDDConfig_FunctionAddress, "UnitResName");
		BGUSetUnitNameForUDDConfig_UnitResName_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitNameForUDDConfig_FunctionAddress, "UnitResName");
		BGUSetUnitNameForUDDConfig_UnitResName_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitNameForUDDConfig_FunctionAddress, "UnitResName", Classes.FStrProperty);
		BGUSetUnitNameForUDDConfig_IsValid = BGUSetUnitNameForUDDConfig_FunctionAddress != IntPtr.Zero && BGUSetUnitNameForUDDConfig_UDDConfig_IsValid && BGUSetUnitNameForUDDConfig_NormalDeadAMPath_IsValid && BGUSetUnitNameForUDDConfig_UnitResName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:BGUSetUnitNameForUDDConfig", BGUSetUnitNameForUDDConfig_IsValid);
		BGUSetUnitNameForUBAConfig_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetUnitNameForUBAConfig");
		BGUSetUnitNameForUBAConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetUnitNameForUBAConfig_FunctionAddress);
		BGUSetUnitNameForUBAConfig_UBAConfig_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitNameForUBAConfig_FunctionAddress, "UBAConfig");
		BGUSetUnitNameForUBAConfig_UBAConfig_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitNameForUBAConfig_FunctionAddress, "UBAConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetUnitNameForUBAConfig_NormalStiffAMPath_PropertyAddress, BGUSetUnitNameForUBAConfig_FunctionAddress, "NormalStiffAMPath");
		BGUSetUnitNameForUBAConfig_NormalStiffAMPath_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitNameForUBAConfig_FunctionAddress, "NormalStiffAMPath");
		BGUSetUnitNameForUBAConfig_NormalStiffAMPath_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitNameForUBAConfig_FunctionAddress, "NormalStiffAMPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref BGUSetUnitNameForUBAConfig_UnitResName_PropertyAddress, BGUSetUnitNameForUBAConfig_FunctionAddress, "UnitResName");
		BGUSetUnitNameForUBAConfig_UnitResName_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitNameForUBAConfig_FunctionAddress, "UnitResName");
		BGUSetUnitNameForUBAConfig_UnitResName_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitNameForUBAConfig_FunctionAddress, "UnitResName", Classes.FStrProperty);
		BGUSetUnitNameForUBAConfig_IsValid = BGUSetUnitNameForUBAConfig_FunctionAddress != IntPtr.Zero && BGUSetUnitNameForUBAConfig_UBAConfig_IsValid && BGUSetUnitNameForUBAConfig_NormalStiffAMPath_IsValid && BGUSetUnitNameForUBAConfig_UnitResName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:BGUSetUnitNameForUBAConfig", BGUSetUnitNameForUBAConfig_IsValid);
		BGUGetNewSweepCheckGroupIdInAM_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetNewSweepCheckGroupIdInAM");
		BGUGetNewSweepCheckGroupIdInAM_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetNewSweepCheckGroupIdInAM_FunctionAddress);
		BGUGetNewSweepCheckGroupIdInAM_InMontage_Offset = NativeReflection.GetPropertyOffset(BGUGetNewSweepCheckGroupIdInAM_FunctionAddress, "InMontage");
		BGUGetNewSweepCheckGroupIdInAM_InMontage_IsValid = NativeReflection.ValidatePropertyClass(BGUGetNewSweepCheckGroupIdInAM_FunctionAddress, "InMontage", Classes.FObjectProperty);
		BGUGetNewSweepCheckGroupIdInAM_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetNewSweepCheckGroupIdInAM_FunctionAddress, "ReturnValue");
		BGUGetNewSweepCheckGroupIdInAM_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetNewSweepCheckGroupIdInAM_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetNewSweepCheckGroupIdInAM_IsValid = BGUGetNewSweepCheckGroupIdInAM_FunctionAddress != IntPtr.Zero && BGUGetNewSweepCheckGroupIdInAM_InMontage_IsValid && BGUGetNewSweepCheckGroupIdInAM_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:BGUGetNewSweepCheckGroupIdInAM", BGUGetNewSweepCheckGroupIdInAM_IsValid);
		BGUAddBlendPhysicToDeathMontage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAddBlendPhysicToDeathMontage");
		BGUAddBlendPhysicToDeathMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAddBlendPhysicToDeathMontage_FunctionAddress);
		BGUAddBlendPhysicToDeathMontage_InMontage_Offset = NativeReflection.GetPropertyOffset(BGUAddBlendPhysicToDeathMontage_FunctionAddress, "InMontage");
		BGUAddBlendPhysicToDeathMontage_InMontage_IsValid = NativeReflection.ValidatePropertyClass(BGUAddBlendPhysicToDeathMontage_FunctionAddress, "InMontage", Classes.FObjectProperty);
		BGUAddBlendPhysicToDeathMontage_Thresholds_Offset = NativeReflection.GetPropertyOffset(BGUAddBlendPhysicToDeathMontage_FunctionAddress, "Thresholds");
		BGUAddBlendPhysicToDeathMontage_Thresholds_IsValid = NativeReflection.ValidatePropertyClass(BGUAddBlendPhysicToDeathMontage_FunctionAddress, "Thresholds", Classes.FFloatProperty);
		BGUAddBlendPhysicToDeathMontage_BoneName_Offset = NativeReflection.GetPropertyOffset(BGUAddBlendPhysicToDeathMontage_FunctionAddress, "BoneName");
		BGUAddBlendPhysicToDeathMontage_BoneName_IsValid = NativeReflection.ValidatePropertyClass(BGUAddBlendPhysicToDeathMontage_FunctionAddress, "BoneName", Classes.FNameProperty);
		BGUAddBlendPhysicToDeathMontage_IsValid = BGUAddBlendPhysicToDeathMontage_FunctionAddress != IntPtr.Zero && BGUAddBlendPhysicToDeathMontage_InMontage_IsValid && BGUAddBlendPhysicToDeathMontage_Thresholds_IsValid && BGUAddBlendPhysicToDeathMontage_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:BGUAddBlendPhysicToDeathMontage", BGUAddBlendPhysicToDeathMontage_IsValid);
		BGUCopyInfoFromUnitComm2UnitDead_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCopyInfoFromUnitComm2UnitDead");
		BGUCopyInfoFromUnitComm2UnitDead_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCopyInfoFromUnitComm2UnitDead_FunctionAddress);
		BGUCopyInfoFromUnitComm2UnitDead_IsValid = BGUCopyInfoFromUnitComm2UnitDead_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:BGUCopyInfoFromUnitComm2UnitDead", BGUCopyInfoFromUnitComm2UnitDead_IsValid);
		BGUAddLifeSavingHairWindowToDeathMontage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAddLifeSavingHairWindowToDeathMontage");
		BGUAddLifeSavingHairWindowToDeathMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAddLifeSavingHairWindowToDeathMontage_FunctionAddress);
		BGUAddLifeSavingHairWindowToDeathMontage_InMontage_Offset = NativeReflection.GetPropertyOffset(BGUAddLifeSavingHairWindowToDeathMontage_FunctionAddress, "InMontage");
		BGUAddLifeSavingHairWindowToDeathMontage_InMontage_IsValid = NativeReflection.ValidatePropertyClass(BGUAddLifeSavingHairWindowToDeathMontage_FunctionAddress, "InMontage", Classes.FObjectProperty);
		BGUAddLifeSavingHairWindowToDeathMontage_IsValid = BGUAddLifeSavingHairWindowToDeathMontage_FunctionAddress != IntPtr.Zero && BGUAddLifeSavingHairWindowToDeathMontage_InMontage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:BGUAddLifeSavingHairWindowToDeathMontage", BGUAddLifeSavingHairWindowToDeathMontage_IsValid);
		GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLevelAllLevelStreamingDataAssetConfigByCPG");
		GetLevelAllLevelStreamingDataAssetConfigByCPG_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetLevelAllLevelStreamingDataAssetConfigByCPG_LevelName_PropertyAddress, GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress, "LevelName");
		GetLevelAllLevelStreamingDataAssetConfigByCPG_LevelName_Offset = NativeReflection.GetPropertyOffset(GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress, "LevelName");
		GetLevelAllLevelStreamingDataAssetConfigByCPG_LevelName_IsValid = NativeReflection.ValidatePropertyClass(GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetLevelAllLevelStreamingDataAssetConfigByCPG_ReturnValue_PropertyAddress, GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress, "ReturnValue");
		GetLevelAllLevelStreamingDataAssetConfigByCPG_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress, "ReturnValue");
		GetLevelAllLevelStreamingDataAssetConfigByCPG_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLevelAllLevelStreamingDataAssetConfigByCPG_IsValid = GetLevelAllLevelStreamingDataAssetConfigByCPG_FunctionAddress != IntPtr.Zero && GetLevelAllLevelStreamingDataAssetConfigByCPG_LevelName_IsValid && GetLevelAllLevelStreamingDataAssetConfigByCPG_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:GetLevelAllLevelStreamingDataAssetConfigByCPG", GetLevelAllLevelStreamingDataAssetConfigByCPG_IsValid);
		GetLevelStreamingStateVolumeControlledLevelInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLevelStreamingStateVolumeControlledLevelInfo");
		GetLevelStreamingStateVolumeControlledLevelInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelStreamingStateVolumeControlledLevelInfo_FunctionAddress);
		GetLevelStreamingStateVolumeControlledLevelInfo_Volume_Offset = NativeReflection.GetPropertyOffset(GetLevelStreamingStateVolumeControlledLevelInfo_FunctionAddress, "Volume");
		GetLevelStreamingStateVolumeControlledLevelInfo_Volume_IsValid = NativeReflection.ValidatePropertyClass(GetLevelStreamingStateVolumeControlledLevelInfo_FunctionAddress, "Volume", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetLevelStreamingStateVolumeControlledLevelInfo_ReturnValue_PropertyAddress, GetLevelStreamingStateVolumeControlledLevelInfo_FunctionAddress, "ReturnValue");
		GetLevelStreamingStateVolumeControlledLevelInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetLevelStreamingStateVolumeControlledLevelInfo_FunctionAddress, "ReturnValue");
		GetLevelStreamingStateVolumeControlledLevelInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetLevelStreamingStateVolumeControlledLevelInfo_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLevelStreamingStateVolumeControlledLevelInfo_IsValid = GetLevelStreamingStateVolumeControlledLevelInfo_FunctionAddress != IntPtr.Zero && GetLevelStreamingStateVolumeControlledLevelInfo_Volume_IsValid && GetLevelStreamingStateVolumeControlledLevelInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibResCS:GetLevelStreamingStateVolumeControlledLevelInfo", GetLevelStreamingStateVolumeControlledLevelInfo_IsValid);
	}

	static BGUFuncLibResCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibResCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibResCS));
	}
}
