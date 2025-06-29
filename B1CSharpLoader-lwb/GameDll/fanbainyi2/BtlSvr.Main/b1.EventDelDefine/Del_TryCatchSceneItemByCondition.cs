using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_TryCatchSceneItemByCondition(List<FName> SceneActorTags, QueryBestLocationCondition Condition, bool NeedRemoveCurrentCatch);
