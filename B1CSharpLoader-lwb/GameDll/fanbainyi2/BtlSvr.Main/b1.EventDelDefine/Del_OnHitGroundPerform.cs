using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_OnHitGroundPerform(UObject World, List<EAtkFXOnGroundType> AtkFXTypeList, FVector PreLocation, float LineTraceHeight, float SamplingRadius, int SkillEffectID, float SurfaceSamplingRadius, bool EnableCheckThroughWall, float HitFXRadiusMin, float HitFXRadiusMax, float HitFXRadiusExpandTime);
