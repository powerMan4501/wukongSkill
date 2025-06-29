using UnrealEngine.Runtime;

namespace UnrealEngine.BehaviorTreeEditor;

[UEnum]
[UMetaPath("/Script/BehaviorTreeEditor.EDecoratorLogicMode", "BehaviorTreeEditor", UnrealModuleType.Engine)]
public enum EDecoratorLogicMode
{
	Sink,
	And,
	Or,
	Not
}
