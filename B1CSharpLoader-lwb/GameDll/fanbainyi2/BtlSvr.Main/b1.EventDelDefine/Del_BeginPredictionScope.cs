using System;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_BeginPredictionScope(EPredictionState ScopeState, IntPtr UFunctionAddr, int RelatedKeyId = -1, APlayerState PridictOriginator = null);
