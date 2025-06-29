using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPlatformInterfaceDataType", "Engine", UnrealModuleType.Engine)]
public enum EPlatformInterfaceDataType
{
	PIDT_None,
	PIDT_Int,
	PIDT_Float,
	PIDT_String,
	PIDT_Object,
	PIDT_Custom
}
