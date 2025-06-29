using OssB1;

namespace b1.EventDelDefine;

public delegate void Del_OnTaskStageChange(ulong RoleId, int TaskLineID, int TaskStageID, TaskStageState StageState, string StageNote);
