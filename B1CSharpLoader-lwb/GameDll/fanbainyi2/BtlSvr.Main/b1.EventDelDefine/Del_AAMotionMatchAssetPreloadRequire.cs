using System;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_AAMotionMatchAssetPreloadRequire(FSoftObjectPath Path, Action<int, UObject> CB);
