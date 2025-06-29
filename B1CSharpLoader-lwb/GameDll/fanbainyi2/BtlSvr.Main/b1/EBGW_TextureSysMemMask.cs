using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EBGW_TextureSysMemMask")]
public enum EBGW_TextureSysMemMask : byte
{
	None = 0,
	SystemUI = 1,
	Vfx_NonStreamed = 2,
	LandScape = 4,
	GrayBox_HeightMap = 8,
	Vfx_Atlas = 0x10
}
