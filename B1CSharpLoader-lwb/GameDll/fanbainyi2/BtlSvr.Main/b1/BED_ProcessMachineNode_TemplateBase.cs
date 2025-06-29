using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_TemplateBase")]
public class BED_ProcessMachineNode_TemplateBase : BED_ProcessMachineNode
{
	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Template;
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "基础";
		base.NodeStyle = ECalliopeNodeStyle.SubGraph;
		base.SupportsContextPins = true;
	}

	public List<CalliopeCustom_ManagedSceneObj> MakeManagedSceneObjCustomData()
	{
		List<CalliopeCustom_ManagedSceneObj> list = new List<CalliopeCustom_ManagedSceneObj>();
		foreach (FGsDynamicObstaclePoliceConfig item in base.SceneObjPoliceConfig.DynamicObstacleCollection)
		{
			CalliopeCustom_ManagedSceneObj obj = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.DynamicObstacle
			};
			Guid configGuid = item.ConfigGuid;
			obj.ObjGuid = configGuid.ToString();
			obj.DefaultState = (int)item.DefaultState;
			obj.ManagePolice = (int)item.ActualManagePolice;
			list.Add(obj);
		}
		foreach (FGsOverlapPoliceConfig item2 in base.SceneObjPoliceConfig.OverlapCollection)
		{
			CalliopeCustom_ManagedSceneObj obj2 = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.Overlap
			};
			Guid configGuid = item2.ConfigGuid;
			obj2.ObjGuid = configGuid.ToString();
			obj2.DefaultState = (int)item2.DefaultState;
			obj2.ManagePolice = (int)item2.ActualManagePolice;
			list.Add(obj2);
		}
		foreach (FGsSpawnerPoliceConfig item3 in base.SceneObjPoliceConfig.SpawnerCollection)
		{
			CalliopeCustom_ManagedSceneObj obj3 = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.Spawner
			};
			Guid configGuid = item3.ConfigGuid;
			obj3.ObjGuid = configGuid.ToString();
			obj3.DefaultState = (int)item3.DefaultState;
			obj3.ManagePolice = (int)item3.ActualManagePolice;
			list.Add(obj3);
		}
		foreach (FGsUnitPoliceConfig item4 in base.SceneObjPoliceConfig.UnitCollection)
		{
			CalliopeCustom_ManagedSceneObj obj4 = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.Unit
			};
			Guid configGuid = item4.ConfigGuid;
			obj4.ObjGuid = configGuid.ToString();
			obj4.DefaultState = (int)item4.DefaultState;
			obj4.ManagePolice = (int)item4.ActualManagePolice;
			list.Add(obj4);
		}
		foreach (FGsStreamingLevelPoliceConfig item5 in base.SceneObjPoliceConfig.StreamingLevelCollection)
		{
			CalliopeCustom_ManagedSceneObj obj5 = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.StreamingLevel
			};
			Guid configGuid = item5.ConfigGuid;
			obj5.ObjGuid = configGuid.ToString();
			obj5.DefaultState = (int)item5.DefaultState;
			obj5.ManagePolice = (int)item5.ActualManagePolice;
			list.Add(obj5);
		}
		return list;
	}

	public List<CalliopeCustom_ManagedNPCUnit> MakeManagedNPCUnitCustomData()
	{
		List<CalliopeCustom_ManagedNPCUnit> list = new List<CalliopeCustom_ManagedNPCUnit>();
		foreach (FGsNPCUnitPoliceConfig NPCUnit in base.SceneObjPoliceConfig.NPCUnitCollection)
		{
			CalliopeCustom_ManagedNPCUnit calliopeCustom_ManagedNPCUnit = new CalliopeCustom_ManagedNPCUnit();
			Guid configGuid = NPCUnit.ConfigGuid;
			calliopeCustom_ManagedNPCUnit.NpcGuid = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.TeamIdValue = new ManagedNPCUnitParam
			{
				DefaultValue = NPCUnit.ManagedTeamID.DefaultParam,
				ManagedValue = NPCUnit.ManagedTeamID.ActualParam
			};
			ManagedSmartParam managedSmartParam = new ManagedSmartParam();
			configGuid = NPCUnit.ManagedTeamIDParam.DefaultParam.ConfigGuid;
			managedSmartParam.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedTeamIDParam.ActualParam.ConfigGuid;
			managedSmartParam.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.TeamIdParamValue = managedSmartParam;
			calliopeCustom_ManagedNPCUnit.IdleAmIdxValue = new ManagedNPCUnitParam
			{
				DefaultValue = NPCUnit.ManagedIdleAMIdx.DefaultParam,
				ManagedValue = NPCUnit.ManagedIdleAMIdx.ActualParam
			};
			ManagedSmartParam managedSmartParam2 = new ManagedSmartParam();
			configGuid = NPCUnit.ManagedIdleAMIdxParam.DefaultParam.ConfigGuid;
			managedSmartParam2.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedIdleAMIdxParam.ActualParam.ConfigGuid;
			managedSmartParam2.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.IdleAmIdxParamValue = managedSmartParam2;
			calliopeCustom_ManagedNPCUnit.LeisureAnimIndexValue = new ManagedNPCUnitParam
			{
				DefaultValue = NPCUnit.ManagedLeisureAnimIndex.DefaultParam,
				ManagedValue = NPCUnit.ManagedLeisureAnimIndex.ActualParam
			};
			ManagedSmartParam managedSmartParam3 = new ManagedSmartParam();
			configGuid = NPCUnit.ManagedLeisureAnimIndexParam.DefaultParam.ConfigGuid;
			managedSmartParam3.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedLeisureAnimIndexParam.ActualParam.ConfigGuid;
			managedSmartParam3.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.LeisureAnimIndexParamValue = managedSmartParam3;
			calliopeCustom_ManagedNPCUnit.InteractGroupIdValue = new ManagedNPCUnitParam
			{
				DefaultValue = NPCUnit.ManagedInteractGroupID.DefaultParam,
				ManagedValue = NPCUnit.ManagedInteractGroupID.ActualParam
			};
			ManagedSmartParam managedSmartParam4 = new ManagedSmartParam();
			configGuid = NPCUnit.ManagedInteractGroupIDParam.DefaultParam.ConfigGuid;
			managedSmartParam4.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedInteractGroupIDParam.ActualParam.ConfigGuid;
			managedSmartParam4.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.InteractGroupIdParamValue = managedSmartParam4;
			calliopeCustom_ManagedNPCUnit.ShowStateValue = new ManagedNPCUnitParam
			{
				DefaultValue = (int)NPCUnit.ManagedShowState.DefaultParam,
				ManagedValue = (int)NPCUnit.ManagedShowState.ActualParam
			};
			ManagedNPCUnitActiveInstanceParam managedNPCUnitActiveInstanceParam = new ManagedNPCUnitActiveInstanceParam();
			configGuid = NPCUnit.ManagedActiveInstance.ActualParam;
			managedNPCUnitActiveInstanceParam.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedActiveInstance.ActualParam;
			managedNPCUnitActiveInstanceParam.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.ActiveInstanceValue = managedNPCUnitActiveInstanceParam;
			CalliopeCustom_ManagedNPCUnit calliopeCustom_ManagedNPCUnit2 = calliopeCustom_ManagedNPCUnit;
			foreach (FGsNPCUnitBuffParamConfig BuffIDInfo in NPCUnit.ManagedBuffIDList)
			{
				if (GetCalliopeAsset().CalliopeParameters.BuffIDCollection.FindIndex((FGsManagedBuffID r) => r.ConfigGuid == BuffIDInfo.ConfigGuid && r.NPCUnit.ConfigGuides.Contains(NPCUnit.ConfigGuid)) != -1)
				{
					RepeatedField<ManagedNPCUnitBuffParam> buffInfoList = calliopeCustom_ManagedNPCUnit2.BuffInfoList;
					ManagedNPCUnitBuffParam managedNPCUnitBuffParam = new ManagedNPCUnitBuffParam();
					configGuid = BuffIDInfo.ConfigGuid;
					managedNPCUnitBuffParam.BuffParamId = configGuid.ToString();
					managedNPCUnitBuffParam.DefaultValue = (int)BuffIDInfo.DefaultParam;
					managedNPCUnitBuffParam.ManagedValue = (int)BuffIDInfo.ActualParam;
					buffInfoList.Add(managedNPCUnitBuffParam);
				}
			}
			list.Add(calliopeCustom_ManagedNPCUnit2);
		}
		return list;
	}

	public List<CalliopeCustom_ManagedGroupUnit> MakeManagedGroupUnitCustomData()
	{
		List<CalliopeCustom_ManagedGroupUnit> list = new List<CalliopeCustom_ManagedGroupUnit>();
		foreach (FGsUnitPoliceConfig item in base.SceneObjPoliceConfig.GroupUnitCollection)
		{
			CalliopeCustom_ManagedGroupUnit calliopeCustom_ManagedGroupUnit = new CalliopeCustom_ManagedGroupUnit();
			Guid configGuid = item.ConfigGuid;
			calliopeCustom_ManagedGroupUnit.ObjGuid = configGuid.ToString();
			calliopeCustom_ManagedGroupUnit.DefaultState = (int)item.DefaultState;
			calliopeCustom_ManagedGroupUnit.ManagePolice = (int)item.ActualManagePolice;
			list.Add(calliopeCustom_ManagedGroupUnit);
		}
		return list;
	}

	public List<CalliopeCustom_ManagedStreamingLevelStateConfig> MakeManagedStreamingLevelStateConfigCustomData()
	{
		List<CalliopeCustom_ManagedStreamingLevelStateConfig> list = new List<CalliopeCustom_ManagedStreamingLevelStateConfig>();
		foreach (FGsStreamingLevelStateConfigPoliceConfig item2 in base.SceneObjPoliceConfig.StreamingLevelStateConfigCollection)
		{
			CalliopeCustom_ManagedStreamingLevelStateConfig calliopeCustom_ManagedStreamingLevelStateConfig = new CalliopeCustom_ManagedStreamingLevelStateConfig();
			Guid configGuid = item2.ConfigGuid;
			calliopeCustom_ManagedStreamingLevelStateConfig.ConfigGuid = configGuid.ToString();
			calliopeCustom_ManagedStreamingLevelStateConfig.DataAssetIdValue = new ManagedStreamingLevelStateConfigParam
			{
				DefaultValue = item2.ManagedDataAssetID.DefaultParam,
				ManagedValue = item2.ManagedDataAssetID.ActualParam
			};
			CalliopeCustom_ManagedStreamingLevelStateConfig item = calliopeCustom_ManagedStreamingLevelStateConfig;
			list.Add(item);
		}
		return list;
	}

	public List<CalliopeCustom_ManagedInteractor> MakeManagedInteractorCustomData()
	{
		List<CalliopeCustom_ManagedInteractor> list = new List<CalliopeCustom_ManagedInteractor>();
		foreach (FGsInteractorPoliceConfig item in base.SceneObjPoliceConfig.InteractorCollection)
		{
			CalliopeCustom_ManagedInteractor calliopeCustom_ManagedInteractor = new CalliopeCustom_ManagedInteractor();
			Guid configGuid = item.ConfigGuid;
			calliopeCustom_ManagedInteractor.ObjGuid = configGuid.ToString();
			calliopeCustom_ManagedInteractor.GroupId = item.ActualValue.ConfigGuid.ToString();
			list.Add(calliopeCustom_ManagedInteractor);
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_TemplateBase:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		return new List<FName>();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_TemplateBase:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_TemplateBase bED_ProcessMachineNode_TemplateBase = GCHelper.Find<BED_ProcessMachineNode_TemplateBase>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ProcessMachineNode_TemplateBase.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_TemplateBase");
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_TemplateBase:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
	}

	static BED_ProcessMachineNode_TemplateBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_TemplateBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_TemplateBase));
	}
}
