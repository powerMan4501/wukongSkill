using System;
using System.Collections.Generic;
using b1;

public class BUC_PerformerControlData
{
	public List<UPerformerParamBase> Params { get; set; } = new List<UPerformerParamBase>();

	public List<UPerformerPhase> Phases { get; set; } = new List<UPerformerPhase>();

	public Dictionary<Guid, string> ParamGuidDictionary { get; } = new Dictionary<Guid, string>();

	public int CurrentPhaseIndex { get; set; }

	public bool bEnableControlPhase { get; set; }

	public bool bAllPerformerReady { get; set; }
}
