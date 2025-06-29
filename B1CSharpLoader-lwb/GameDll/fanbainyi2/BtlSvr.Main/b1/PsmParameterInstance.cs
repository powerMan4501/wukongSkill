using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;

namespace b1;

public class PsmParameterInstance
{
	public EGsManagedParamType ParamType { get; set; }

	public Guid ParamGuid { get; set; }

	public string ParamValueStr { get; set; }

	public int ParamValueInt { get; set; }

	public List<int> ParamValueArrayInt { get; set; }

	public Guid ParamLinkInt { get; set; }

	public Guid ParamLinkString { get; set; }

	public string ParamAliasName { get; set; }

	public Dictionary<Guid, PsmParameterSubInstance> ParamSubInstances { get; set; }

	public string OverrideComment { get; set; }

	public bool bOverride { get; set; }
}
