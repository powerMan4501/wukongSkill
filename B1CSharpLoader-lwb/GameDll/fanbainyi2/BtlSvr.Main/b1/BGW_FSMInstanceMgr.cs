using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlSvr.Main;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_FSMInstanceMgr")]
public class BGW_FSMInstanceMgr : GameInstanceSystemBaseUObj
{
	protected List<FSMRuntimeInstanceBase> ActiveInstances = new List<FSMRuntimeInstanceBase>();

	private static int sGraphIdAlloc;

	public override bool bTickEnabled => true;

	public string GetFSMGName(string FSMInstancePath)
	{
		return FSMInstancePath.Split('/').Last().Split('.')[0];
	}

	public string GetFSMGTypeName(string FSMGName)
	{
		string[] array = FSMGName.Split('_');
		return array[1] + "_" + array[2];
	}

	public override void OnInit()
	{
		CFSMGReg.Init(BGW_ECSWorld.Get(this).GetEntityMgrIdx());
		object[] paramList = new object[1] { BGW_ECSWorld.Get(this).GetEntityMgrIdx() };
		BGW_ILRuntimeMgr.ILRuntimeInvoke(this, "B1UI.Script.CFSMGReg", "Init", null, paramList);
		BGW_ILRuntimeMgr.ILRuntimeInvoke(this, "B1UI.Script.LevelTravelTemplateFactoryScript", "Init", null);
		BGW_ILRuntimeMgr.ILRuntimeInvoke(this, "BtlSvr.Script.CFSMGReg", "Init", null, paramList);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_BGW_AbortFSMInstance = (BGW_EventCollection.Del_BGW_AbortFSMInstance)Delegate.Combine(bGW_EventCollection.Evt_BGW_AbortFSMInstance, new BGW_EventCollection.Del_BGW_AbortFSMInstance(AbortFSMInstance));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(this);
		bGW_EventCollection2.Evt_BGW_AbortAllFSMInstances = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_BGW_AbortAllFSMInstances, new Del_Void(AbortAllFSMInstances));
		BGW_EventCollection bGW_EventCollection3 = BGW_EventCollection.Get(this);
		bGW_EventCollection3.Evt_BGW_CFSMGStart = (BGW_EventCollection.Del_BGW_CFSMGStart)Delegate.Combine(bGW_EventCollection3.Evt_BGW_CFSMGStart, (BGW_EventCollection.Del_BGW_CFSMGStart)delegate(string FSMInstancePath, FSMContextBase ContextBase, UObject OwnerUObj, FSMRuntimeInstanceBase ParentRuntimeInstance, Action OnGraphFinish, Action<FSMException> OnGraphExcetion, object InputParams, bool IsStart)
		{
			ContextBase.OwnerUObj = OwnerUObj;
			BED_FSMAsset calliopeAsset = null;
			FCalliopeGraph calliopeGraph = BGW_FlowUtils.LoadGraph(FSMInstancePath, GetFSMGName(FSMInstancePath));
			FSMRuntimeInstanceBase arg = null;
			switch (GetFSMGTypeName(GetFSMGName(FSMInstancePath)))
			{
			case "GI_Loading":
				arg = new FSMRuntimeInstance_GI_Loading(calliopeGraph, ContextBase as FSMContext_GI_Loading, calliopeAsset);
				break;
			case "GI_Global":
				arg = new FSMRuntimeInstance_GI_Global(calliopeGraph, ContextBase as FSMContext_GI_Global, calliopeAsset);
				break;
			case "PS_Transaction":
				arg = new FSMRuntimeInstance_PS_Transaction(calliopeGraph, ContextBase as FSMContext_PS_Transaction, calliopeAsset);
				break;
			default:
				BGW_LogUtil.LogError($"BGW_FSMInstanceMgr Trying To Start UnKnow FSM FSMRuntimeInstance:{arg}");
				return (FSMRuntimeInstanceBase)null;
			}
			if (arg != null)
			{
				if (ParentRuntimeInstance != null)
				{
					arg.FSMInstanceName = ParentRuntimeInstance.FSMInstanceName + "/" + GetFSMGName(FSMInstancePath) + sGraphIdAlloc;
				}
				else
				{
					arg.FSMInstanceName = GetFSMGName(FSMInstancePath) + sGraphIdAlloc;
				}
				sGraphIdAlloc++;
				ActiveInstances.Add(arg);
			}
			arg.OnException += OnGraphExcetion;
			arg.OnFinish += OnGraphFinish;
			if (IsStart)
			{
				arg.Start(InputParams, ContextBase);
			}
			return arg;
		});
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
	}

	public void AbortAllFSMInstances()
	{
		for (int num = ActiveInstances.Count - 1; num >= 0; num--)
		{
			_ = ActiveInstances[0];
			ActiveInstances.RemoveAt(0);
		}
	}

	public void AbortFSMInstance(FSMRuntimeInstanceBase InstanceToAbort)
	{
		for (int num = ActiveInstances.Count - 1; num >= 0; num--)
		{
			if (ActiveInstances[num] == InstanceToAbort)
			{
				ActiveInstances.RemoveAt(num);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		for (int num = ActiveInstances.Count - 1; num >= 0; num--)
		{
			FSMRuntimeInstanceBase fSMRuntimeInstanceBase = ActiveInstances[num];
			if (fSMRuntimeInstanceBase.ActiveNode == null || fSMRuntimeInstanceBase.ActiveNode.NodeClass == "FSM.BED_FSMNode_End")
			{
				ActiveInstances.RemoveAt(num);
			}
			else
			{
				fSMRuntimeInstanceBase.OnTick(DeltaTime);
				if (fSMRuntimeInstanceBase is FSMRuntimeInstance_GI_Loading fSMRuntimeInstance_GI_Loading)
				{
					fSMRuntimeInstance_GI_Loading?.Context?.TravelLevelTemplate?.OnTick(DeltaTime);
				}
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_FSMInstanceMgr");
	}

	static BGW_FSMInstanceMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_FSMInstanceMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_FSMInstanceMgr));
	}
}
