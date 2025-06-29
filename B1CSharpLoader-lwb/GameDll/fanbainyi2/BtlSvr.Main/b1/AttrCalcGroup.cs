namespace b1;

public struct AttrCalcGroup<EBGUAttrType>
{
	public EBGUAttrType baseVal;

	public EBGUAttrType mulVal;

	public EBGUAttrType finalVal;

	public AttrCalcGroup(EBGUAttrType _finalVal, EBGUAttrType _mulVal, EBGUAttrType _baseVal)
	{
		baseVal = _baseVal;
		mulVal = _mulVal;
		finalVal = _finalVal;
	}
}
