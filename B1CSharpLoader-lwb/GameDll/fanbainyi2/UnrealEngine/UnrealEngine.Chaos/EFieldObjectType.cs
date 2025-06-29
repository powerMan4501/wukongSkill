using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldObjectType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldObjectType : byte
{
	Field_Object_Rigid,
	Field_Object_Cloth,
	Field_Object_Destruction,
	Field_Object_Character,
	Field_Object_All,
	Field_Object_Max
}
