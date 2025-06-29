using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/IKRig.IKGoalCreatorInterface", "IKRig", UnrealModuleType.EnginePlugin, InterfaceImpl = typeof(IKGoalCreatorInterfaceImpl))]
public interface IKGoalCreatorInterface : IInterface
{
	[UFunction(Flags = 205655040u)]
	[UMetaPath("/Script/IKRig.IKGoalCreatorInterface:AddIKGoals")]
	void AddIKGoals(out Dictionary<FName, FIKRigGoal> OutGoals);
}
