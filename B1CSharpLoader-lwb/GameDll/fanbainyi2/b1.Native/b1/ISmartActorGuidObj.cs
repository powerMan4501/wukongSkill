using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/b1.SmartActorGuidObj", "b1", UnrealModuleType.Game, InterfaceImpl = typeof(ISmartActorGuidObjImpl))]
public interface ISmartActorGuidObj : IInterface
{
	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/b1.SmartActorGuidObj:GetActorGuidOptions")]
	int GetActorGuidOptions(string PropertyName, out List<FActorGuidOption> OutOptions);

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/b1.SmartActorGuidObj:GetActorGuid")]
	bool GetActorGuid(AActor InActor, out string OutActorGuid);

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/b1.SmartActorGuidObj:CanManageStates")]
	bool CanManageStates();
}
