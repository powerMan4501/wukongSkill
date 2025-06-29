namespace b1;

public struct GACData<EACDataType>
{
	public EACDataType baseVal;

	public EACDataType mulVal;

	public EACDataType finalVal;

	public GACData(EACDataType _finalVal, EACDataType _mulVal, EACDataType _baseVal)
	{
		baseVal = _baseVal;
		mulVal = _mulVal;
		finalVal = _finalVal;
	}
}
