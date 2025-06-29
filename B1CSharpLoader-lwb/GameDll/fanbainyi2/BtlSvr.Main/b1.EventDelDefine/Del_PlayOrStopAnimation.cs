using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_PlayOrStopAnimation(bool IsPlay, bool IsLoop = false, UAnimationAsset NewAnimToPlay = null);
