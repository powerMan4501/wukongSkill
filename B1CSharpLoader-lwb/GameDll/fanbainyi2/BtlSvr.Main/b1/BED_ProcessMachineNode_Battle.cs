using System;
using System.Collections.Generic;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("战斗（Battle）")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Battle")]
public class BED_ProcessMachineNode_Battle : BED_ProcessMachineNode_TemplateBase
{
	private static bool StartCondition_IsValid;

	private static int StartCondition_Offset;

	private static bool BattleStartActiveList_IsValid;

	private static int BattleStartActiveList_Offset;

	private static bool TransitionConditions_IsValid;

	private static int TransitionConditions_Offset;

	private static FFieldAddress TransitionConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FCompositeTransitionCondition_Battle> TransitionConditions_Marshaler;

	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	[DisplayName("战斗开始条件")]
	[Category("开始结束")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Battle:StartCondition")]
	public FBattleStartCondition StartCondition
	{
		get
		{
			CheckDestroyed();
			if (!StartCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Battle:StartCondition");
				return default(FBattleStartCondition);
			}
			return FBattleStartCondition.FromNative(IntPtr.Add(base.Address, StartCondition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Battle:StartCondition");
			}
			else
			{
				FBattleStartCondition.ToNative(IntPtr.Add(base.Address, StartCondition_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("战斗开始时自动激活列表")]
	[UProperty]
	[Category("开始结束")]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Battle:BattleStartActiveList")]
	public FUnitsAndSpawners BattleStartActiveList
	{
		get
		{
			CheckDestroyed();
			if (!BattleStartActiveList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Battle:BattleStartActiveList");
				return default(FUnitsAndSpawners);
			}
			return FUnitsAndSpawners.FromNative(IntPtr.Add(base.Address, BattleStartActiveList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleStartActiveList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Battle:BattleStartActiveList");
			}
			else
			{
				FUnitsAndSpawners.ToNative(IntPtr.Add(base.Address, BattleStartActiveList_Offset), value);
			}
		}
	}

	[DisplayName("战斗结束条件")]
	[Category("开始结束")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Battle:TransitionConditions")]
	public TArrayReadWrite<FCompositeTransitionCondition_Battle> TransitionConditions
	{
		get
		{
			CheckDestroyed();
			if (!TransitionConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Battle:TransitionConditions");
				return null;
			}
			if (TransitionConditions_Marshaler == null)
			{
				TransitionConditions_Marshaler = new TArrayReadWriteMarshaler<FCompositeTransitionCondition_Battle>(1, TransitionConditions_PropertyAddress, CachedMarshalingDelegates<FCompositeTransitionCondition_Battle, FCompositeTransitionCondition_Battle>.FromNative, CachedMarshalingDelegates<FCompositeTransitionCondition_Battle, FCompositeTransitionCondition_Battle>.ToNative);
			}
			return TransitionConditions_Marshaler.FromNative(IntPtr.Add(base.Address, TransitionConditions_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Battle;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Battle:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> contextOutputsInCS_Implementation = base.GetContextOutputsInCS_Implementation();
		if (TransitionConditions.Count > 0)
		{
			int num = 1;
			foreach (FCompositeTransitionCondition_Battle transitionCondition in TransitionConditions)
			{
				string name = $"跳转条件{num++}";
				if (!string.IsNullOrEmpty(transitionCondition.Comment))
				{
					name = transitionCondition.Comment;
				}
				contextOutputsInCS_Implementation.Add(new FName(name));
			}
		}
		return contextOutputsInCS_Implementation;
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		bool flag = base.CorrectnessCheck(out OutErrorMessage);
		StringBuilder stringBuilder = new StringBuilder(OutErrorMessage);
		bool flag2 = true;
		foreach (FCompositeTransitionCondition_Battle transitionCondition in TransitionConditions)
		{
			if (transitionCondition.bUseCompositeCondition)
			{
				foreach (FTransitionCondition_Battle condition in transitionCondition.Conditions)
				{
					if (condition.ConditionType == ETransitionConditionType_Battle.None)
					{
						flag2 = false;
					}
				}
			}
			else if (transitionCondition.Single.ConditionType == ETransitionConditionType_Battle.None)
			{
				flag2 = false;
			}
		}
		if (!flag2)
		{
			stringBuilder.AppendLine("不可以有类型为None的跳转条件");
		}
		OutErrorMessage = stringBuilder.ToString();
		return flag && flag2;
	}

	public override byte[] GetCustomData()
	{
		ProcessCustom_Battle processCustom_Battle = new ProcessCustom_Battle();
		CalliopeCustom_BattleStartCondition calliopeCustom_BattleStartCondition = new CalliopeCustom_BattleStartCondition();
		calliopeCustom_BattleStartCondition.StartConditionType = (int)StartCondition.StartConditionType;
		calliopeCustom_BattleStartCondition.UnitGuid = StartCondition.Unit.ConfigGuid.ToString();
		calliopeCustom_BattleStartCondition.SpawnerGuid = StartCondition.Spawner.ConfigGuid.ToString();
		calliopeCustom_BattleStartCondition.OverlapGuid = StartCondition.Overlap.ConfigGuid.ToString();
		processCustom_Battle.StartCondition = calliopeCustom_BattleStartCondition;
		foreach (Guid configGuide in BattleStartActiveList.UnitList.ConfigGuides)
		{
			processCustom_Battle.BattleStartActiveList.Add(configGuide.ToString());
		}
		foreach (Guid configGuide2 in BattleStartActiveList.SpawnerList.ConfigGuides)
		{
			processCustom_Battle.BattleStartActiveList.Add(configGuide2.ToString());
		}
		foreach (Guid configGuide3 in BattleStartActiveList.GroupUnitList.ConfigGuides)
		{
			processCustom_Battle.BattleStartActiveGroupUnitList.Add(configGuide3.ToString());
		}
		int num = 1;
		foreach (FCompositeTransitionCondition_Battle transitionCondition in TransitionConditions)
		{
			CalliopeCustom_CompositeTransitionCondition_Battle calliopeCustom_CompositeTransitionCondition_Battle = new CalliopeCustom_CompositeTransitionCondition_Battle();
			calliopeCustom_CompositeTransitionCondition_Battle.IsUseCompositeCondition = transitionCondition.bUseCompositeCondition;
			if (transitionCondition.bUseCompositeCondition)
			{
				calliopeCustom_CompositeTransitionCondition_Battle.ConditionalRelation = (int)transitionCondition.ConditionalRelation;
				foreach (FTransitionCondition_Battle condition in transitionCondition.Conditions)
				{
					CalliopeCustom_TransitionCondition_Battle calliopeCustom_TransitionCondition_Battle = new CalliopeCustom_TransitionCondition_Battle();
					calliopeCustom_TransitionCondition_Battle.ConditionType = (int)condition.ConditionType;
					foreach (Guid configGuide4 in condition.UnitList.ConfigGuides)
					{
						calliopeCustom_TransitionCondition_Battle.Units.Add(configGuide4.ToString());
					}
					calliopeCustom_TransitionCondition_Battle.Spawner = condition.UnitSpawner.ConfigGuid.ToString();
					if (condition.Unit.ConfigGuid == Guid.Empty)
					{
						calliopeCustom_TransitionCondition_Battle.UnitGuid = B1GlobalFNames.Player_Wukong.PlainName;
					}
					else
					{
						calliopeCustom_TransitionCondition_Battle.UnitGuid = condition.Unit.ConfigGuid.ToString();
					}
					calliopeCustom_TransitionCondition_Battle.BuffId = condition.Buff.ConfigGuid.ToString();
					foreach (Guid configGuide5 in condition.UnitKillOrder.ConfigGuides)
					{
						calliopeCustom_TransitionCondition_Battle.KillOrder.Add(configGuide5.ToString());
					}
					calliopeCustom_TransitionCondition_Battle.GroupUnit = condition.GroupUnit.ConfigGuid.ToString();
					calliopeCustom_TransitionCondition_Battle.UnitDeadNum = condition.UnitDeadNum;
					calliopeCustom_TransitionCondition_Battle.CountdownTime = condition.CountdownTime;
					calliopeCustom_TransitionCondition_Battle.IsReverseCondition = condition.bReverseCondition;
					calliopeCustom_CompositeTransitionCondition_Battle.Conditions.Add(calliopeCustom_TransitionCondition_Battle);
				}
			}
			else
			{
				FTransitionCondition_Battle single = transitionCondition.Single;
				CalliopeCustom_TransitionCondition_Battle calliopeCustom_TransitionCondition_Battle2 = new CalliopeCustom_TransitionCondition_Battle();
				calliopeCustom_TransitionCondition_Battle2.ConditionType = (int)single.ConditionType;
				foreach (Guid configGuide6 in single.UnitList.ConfigGuides)
				{
					calliopeCustom_TransitionCondition_Battle2.Units.Add(configGuide6.ToString());
				}
				calliopeCustom_TransitionCondition_Battle2.Spawner = single.UnitSpawner.ConfigGuid.ToString();
				if (single.Unit.ConfigGuid == Guid.Empty)
				{
					calliopeCustom_TransitionCondition_Battle2.UnitGuid = B1GlobalFNames.Player_Wukong.PlainName;
				}
				else
				{
					calliopeCustom_TransitionCondition_Battle2.UnitGuid = single.Unit.ConfigGuid.ToString();
				}
				calliopeCustom_TransitionCondition_Battle2.BuffId = single.Buff.ConfigGuid.ToString();
				foreach (Guid configGuide7 in single.UnitKillOrder.ConfigGuides)
				{
					calliopeCustom_TransitionCondition_Battle2.KillOrder.Add(configGuide7.ToString());
				}
				calliopeCustom_TransitionCondition_Battle2.GroupUnit = single.GroupUnit.ConfigGuid.ToString();
				calliopeCustom_TransitionCondition_Battle2.OverlapGuid = single.Overlap.ConfigGuid.ToString();
				calliopeCustom_TransitionCondition_Battle2.UnitDeadNum = single.UnitDeadNum;
				calliopeCustom_TransitionCondition_Battle2.CountdownTime = calliopeCustom_TransitionCondition_Battle2.CountdownTime;
				calliopeCustom_TransitionCondition_Battle2.IsReverseCondition = single.bReverseCondition;
				calliopeCustom_CompositeTransitionCondition_Battle.Single = calliopeCustom_TransitionCondition_Battle2;
			}
			calliopeCustom_CompositeTransitionCondition_Battle.IsReverseCondition = transitionCondition.bReverseCondition;
			string pinName = $"跳转条件{num++}";
			if (!string.IsNullOrEmpty(transitionCondition.Comment))
			{
				pinName = transitionCondition.Comment;
			}
			calliopeCustom_CompositeTransitionCondition_Battle.PinName = pinName;
			processCustom_Battle.TransitionConditions.Add(calliopeCustom_CompositeTransitionCondition_Battle);
		}
		processCustom_Battle.ManagedObjs.AddRange(MakeManagedSceneObjCustomData());
		processCustom_Battle.ManagedNpcUnits.AddRange(MakeManagedNPCUnitCustomData());
		processCustom_Battle.ManagedInteractors.AddRange(MakeManagedInteractorCustomData());
		processCustom_Battle.ManagedStreamingLevelStateConfigs.AddRange(MakeManagedStreamingLevelStateConfigCustomData());
		processCustom_Battle.ManagedGroupUnits.AddRange(MakeManagedGroupUnitCustomData());
		return processCustom_Battle.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_Battle:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_Battle bED_ProcessMachineNode_Battle = GCHelper.Find<BED_ProcessMachineNode_Battle>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ProcessMachineNode_Battle.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_Battle");
		StartCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartCondition");
		StartCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartCondition", Classes.FStructProperty);
		BattleStartActiveList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleStartActiveList");
		BattleStartActiveList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleStartActiveList", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TransitionConditions_PropertyAddress, intPtr, "TransitionConditions");
		TransitionConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransitionConditions");
		TransitionConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransitionConditions", Classes.FArrayProperty);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_Battle:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
	}

	static BED_ProcessMachineNode_Battle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_Battle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_Battle));
	}
}
