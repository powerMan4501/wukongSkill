using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PCG.EPropertyBagPropertyType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPropertyBagPropertyType : byte
{
	None,
	Bool,
	Byte,
	Int32,
	Int64,
	Float,
	Double,
	Name,
	String,
	Text,
	Enum,
	Struct,
	Object,
	SoftObject,
	Class,
	SoftClass,
	Count
}
