using System.Collections.Generic;

namespace b1;

public class ExportAttrGroupInfos<EBGUAttrType, ValueType>
{
	public Dictionary<EBGUAttrType, EBGUAttrType> _attr2FinalVals;

	public Dictionary<EBGUAttrType, AttrCalcGroup<EBGUAttrType>> _calcGrps;

	public Dictionary<EBGUAttrType, AttrMinMaxGroup<EBGUAttrType, ValueType>> _minMaxGrps;

	public Dictionary<EBGUAttrType, EBGUAttrType> _attr2MaxVals { get; set; }
}
