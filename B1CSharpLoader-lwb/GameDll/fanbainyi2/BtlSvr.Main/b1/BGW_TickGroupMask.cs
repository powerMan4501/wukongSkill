using System;

namespace b1;

[Flags]
public enum BGW_TickGroupMask
{
	TG_None = 0,
	TG_PreTick = 1,
	TG_LateTick = 2,
	TG_AfterAnim = 8,
	TG_ThreadTick = 0x10,
	TG_PostPhysics = 0x20,
	TG_PreAnim = 0x40,
	TG_BeforeStartPhsic = 0x80,
	TG_BeforePostUpdateWork = 0x100,
	TG_ThreadTick_AfterAnimBegin = 0x200,
	TG_OnTick = 0x400,
	TG_PostUpdateWork = 0x800,
	TG_BeforePostPhsic = 0x1000,
	TG_Max = 0x1001
}
