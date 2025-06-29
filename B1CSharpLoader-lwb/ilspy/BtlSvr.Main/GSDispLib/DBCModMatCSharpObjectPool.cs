using System.Collections.Generic;

namespace GSDispLib;

public class DBCModMatCSharpObjectPool
{
	private int ScalarParamMaxPoolCount = 30;

	private int FLinearColorParamMaxPoolCount = 20;

	public Stack<DBCAdvProcessScalarMatLayerParam> ScalarParamFreePool = new Stack<DBCAdvProcessScalarMatLayerParam>(30);

	public Stack<DBCAdvProcessFLinearColorMatLayerParam> FLinearColorParamFreePool = new Stack<DBCAdvProcessFLinearColorMatLayerParam>(20);

	public DBCAdvProcessScalarMatLayerParam GetOneDBCAdvProcessScalarMatLayerParam()
	{
		if (ScalarParamFreePool.Count == 0)
		{
			return new DBCAdvProcessScalarMatLayerParam();
		}
		DBCAdvProcessScalarMatLayerParam dBCAdvProcessScalarMatLayerParam = ScalarParamFreePool.Pop();
		if (dBCAdvProcessScalarMatLayerParam == null)
		{
			return new DBCAdvProcessScalarMatLayerParam();
		}
		return dBCAdvProcessScalarMatLayerParam;
	}

	public DBCAdvProcessFLinearColorMatLayerParam GetOneDBCAdvProcessFLinearColorMatLayerParam()
	{
		if (FLinearColorParamFreePool.Count == 0)
		{
			return new DBCAdvProcessFLinearColorMatLayerParam();
		}
		DBCAdvProcessFLinearColorMatLayerParam dBCAdvProcessFLinearColorMatLayerParam = FLinearColorParamFreePool.Pop();
		if (dBCAdvProcessFLinearColorMatLayerParam == null)
		{
			return new DBCAdvProcessFLinearColorMatLayerParam();
		}
		return dBCAdvProcessFLinearColorMatLayerParam;
	}

	public void ReleaseToPoolDBCAdvProcessScalarMatLayerParam(DBCAdvProcessScalarMatLayerParam Object)
	{
		if (Object != null && ScalarParamFreePool.Count <= ScalarParamMaxPoolCount)
		{
			Object.CleanData();
			ScalarParamFreePool.Push(Object);
		}
	}

	public void ReleaseToPoolDBCAdvProcessFLinearColorMatLayerParam(DBCAdvProcessFLinearColorMatLayerParam Object)
	{
		if (Object != null && FLinearColorParamFreePool.Count <= FLinearColorParamMaxPoolCount)
		{
			Object.CleanData();
			FLinearColorParamFreePool.Push(Object);
		}
	}
}
