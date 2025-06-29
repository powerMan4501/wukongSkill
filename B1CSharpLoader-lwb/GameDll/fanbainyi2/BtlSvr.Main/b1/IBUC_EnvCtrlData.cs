using System.Collections.Generic;
using b1.Plugins.CustomLightSystem;

namespace b1;

internal interface IBUC_EnvCtrlData
{
	ACLSCommandManager CLSCmdMng { get; }

	bool bCLSCmdOpen { get; }

	Dictionary<int, FEnvChangeConfig> LeveleSequenceMap { get; }

	float GetEnvSwitchSchedule(int EntityHash);
}
