using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_BGS_RegisterSceneInactiveActor(AActor Actor, List<FSceneActorActivationInfo> SceneInactiveInfo, BUS_SceneInactiveActorComp RegisterComp);
