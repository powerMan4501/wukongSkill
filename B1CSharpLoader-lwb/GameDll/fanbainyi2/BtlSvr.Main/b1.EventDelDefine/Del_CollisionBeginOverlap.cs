using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_CollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult);
