using System.Collections.Generic;
using b1.Plugins.AkAudio;

namespace b1.EventDelDefine;

public delegate void Del_SetUnitBattleBGM(UAkAudioEvent AkEventBegin, UAkAudioEvent AkEventStop, float BGMEventStopTimer, Dictionary<EBGMStopCondition, BGMStopEventInfo> ConditionStopEvents);
