using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PushRenderTargetValuesToGroup(RenderTargetType RTType, int GroupIndex, List<FLinearColor> ColorValues, List<float> FloatValues);
