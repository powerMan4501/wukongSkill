using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_EndPreMontageSectionJumpDetection(bool bReversePreDetectionResult, FName JumpToSectionName, bool bJumpImmediately, List<int> BuffsToAddWhenSectionJumpApproved);
