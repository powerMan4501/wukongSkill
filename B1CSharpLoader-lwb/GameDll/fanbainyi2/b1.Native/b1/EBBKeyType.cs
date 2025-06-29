using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBBKeyType", "b1", UnrealModuleType.Game)]
public enum EBBKeyType : byte
{
	BOOL_TYPE,
	CLASS_TYPE,
	ENUM_TYPE,
	FLOAT_TYPE,
	INT_TYPE,
	NAME_TYPE,
	NATIVE_ENUM_TYPE,
	OBJECT_TYPE,
	ROTATOR_TYPE,
	STRING_TYPE,
	VECTOR_TYPE
}
