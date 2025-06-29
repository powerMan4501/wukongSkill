using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_TryCatchSceneItemByTag(List<FName> ActorTags, EFindSceneItemWay FindSceneItemWay, bool NeedRemoveCurrentCatch, float MinDistance = -1f, float MaxDistance = -1f, int FromAMInstanceID = -1, float RequiredMaxAngle = -1f, float Angle = -1f, bool EnableDrawDebug = false);
