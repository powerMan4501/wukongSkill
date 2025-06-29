using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_OnSweepHitWorldItemForProceduralFX(AActor HitActor, FVector2D Position, float Size, ESceneItemSurfaceType OverrideSurfaceType, float OverrideSurfacePersistTime, int EntityID);
