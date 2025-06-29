using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.BGW;

public delegate void ObjectsLoadedCallBack(List<FSoftObjectPath> RequestPaths, List<UObject> Loadedobjects, object UserData = null);
