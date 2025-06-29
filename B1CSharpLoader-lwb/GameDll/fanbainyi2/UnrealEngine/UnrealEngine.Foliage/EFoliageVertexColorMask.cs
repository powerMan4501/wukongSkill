using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UEnum]
[UMetaPath("/Script/Foliage.FoliageVertexColorMask", "Foliage", UnrealModuleType.Engine)]
public enum EFoliageVertexColorMask
{
	FOLIAGEVERTEXCOLORMASK_Disabled,
	FOLIAGEVERTEXCOLORMASK_Red,
	FOLIAGEVERTEXCOLORMASK_Green,
	FOLIAGEVERTEXCOLORMASK_Blue,
	FOLIAGEVERTEXCOLORMASK_Alpha
}
