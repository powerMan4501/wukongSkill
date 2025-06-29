namespace b1;

public struct AttrMinMaxGroup<EBGUAttrType, ValueType>
{
	public EBGUAttrType maxVal;

	public EBGUAttrType finalVal;

	public ValueType minVal;

	public AttrMinMaxGroup(EBGUAttrType _finalVal, EBGUAttrType _maxVal, ValueType _minVal)
	{
		finalVal = _finalVal;
		maxVal = _maxVal;
		minVal = _minVal;
	}
}
