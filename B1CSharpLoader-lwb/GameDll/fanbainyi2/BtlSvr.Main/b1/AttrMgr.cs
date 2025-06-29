using System.Collections.Generic;

namespace b1;

public class AttrMgr<EBGUAttrType, ValueType>
{
	public Dictionary<EBGUAttrType, EBGUAttrType> _attr2FinalVals;

	public Dictionary<EBGUAttrType, AttrCalcGroup<EBGUAttrType>> _calcGrps;

	public Dictionary<EBGUAttrType, AttrMinMaxGroup<EBGUAttrType, ValueType>> _minMaxGrps;

	public Dictionary<EBGUAttrType, EBGUAttrType> _attr2MaxVals { get; set; }

	public static AttrMgr<EBGUAttrType, ValueType> inst { get; set; }

	public AttrMgr()
	{
		_attr2FinalVals = new Dictionary<EBGUAttrType, EBGUAttrType>();
		_attr2MaxVals = new Dictionary<EBGUAttrType, EBGUAttrType>();
		_calcGrps = new Dictionary<EBGUAttrType, AttrCalcGroup<EBGUAttrType>>();
		_minMaxGrps = new Dictionary<EBGUAttrType, AttrMinMaxGroup<EBGUAttrType, ValueType>>();
	}

	public static AttrMgr<EBGUAttrType, ValueType> getInstance()
	{
		if (inst == null)
		{
			inst = new AttrMgr<EBGUAttrType, ValueType>();
		}
		return inst;
	}

	public AttrCalcGroup<EBGUAttrType> GetCalc(EBGUAttrType changedAttr, out bool IsVaild)
	{
		IsVaild = _attr2FinalVals.TryGetValue(changedAttr, out var value);
		if (!IsVaild)
		{
			return default(AttrCalcGroup<EBGUAttrType>);
		}
		IsVaild = _calcGrps.TryGetValue(value, out var value2);
		return value2;
	}

	public AttrMinMaxGroup<EBGUAttrType, ValueType> GetMinMax(EBGUAttrType changedAttr, out bool IsVaild)
	{
		IsVaild = _attr2MaxVals.TryGetValue(changedAttr, out var value);
		if (!IsVaild)
		{
			return default(AttrMinMaxGroup<EBGUAttrType, ValueType>);
		}
		IsVaild = _minMaxGrps.TryGetValue(value, out var value2);
		return value2;
	}

	public void InitCalcGroup(EBGUAttrType finalVal, EBGUAttrType mulVal, EBGUAttrType baseVal)
	{
		_calcGrps[finalVal] = new AttrCalcGroup<EBGUAttrType>(finalVal, mulVal, baseVal);
		_attr2FinalVals[baseVal] = finalVal;
		_attr2FinalVals[mulVal] = finalVal;
		_attr2FinalVals[finalVal] = finalVal;
	}

	public void InitMinmaxGroup(EBGUAttrType finalVal, EBGUAttrType maxVal, ValueType minVal)
	{
		_minMaxGrps[maxVal] = new AttrMinMaxGroup<EBGUAttrType, ValueType>(finalVal, maxVal, minVal);
		_attr2MaxVals[finalVal] = maxVal;
		_attr2MaxVals[maxVal] = maxVal;
	}

	public void CloneToExportAttrGroupInfos(out ExportAttrGroupInfos<EBGUAttrType, ValueType> ExportData)
	{
		ExportData = new ExportAttrGroupInfos<EBGUAttrType, ValueType>();
		ExportData._attr2FinalVals = new Dictionary<EBGUAttrType, EBGUAttrType>(_attr2FinalVals);
		ExportData._attr2MaxVals = new Dictionary<EBGUAttrType, EBGUAttrType>(_attr2MaxVals);
		ExportData._calcGrps = new Dictionary<EBGUAttrType, AttrCalcGroup<EBGUAttrType>>(_calcGrps);
		ExportData._minMaxGrps = new Dictionary<EBGUAttrType, AttrMinMaxGroup<EBGUAttrType, ValueType>>(_minMaxGrps);
	}
}
