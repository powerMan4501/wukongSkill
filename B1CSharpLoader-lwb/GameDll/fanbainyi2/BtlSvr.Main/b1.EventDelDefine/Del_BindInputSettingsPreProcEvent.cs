using System;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BindInputSettingsPreProcEvent(Action<FName> PressFunc, Action<FName> ReleaseAction);
