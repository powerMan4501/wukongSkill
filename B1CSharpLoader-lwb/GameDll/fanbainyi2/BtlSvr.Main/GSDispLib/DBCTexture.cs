using System;

namespace GSDispLib;

public class DBCTexture
{
	public BUC_DispLibUtil_DBCTexture SourceStruct;

	public float Age { get; protected set; }

	public bool EventRealEnd { get; protected set; }

	public DBCTexture(BUC_DispLibUtil_DBCTexture _SourceStruct, float StartAge)
	{
		SourceStruct = _SourceStruct;
		Age = Math.Max(0f, StartAge);
		EventRealEnd = false;
	}

	public virtual void UpdateValue(float DeltaTime, float VelocityLength)
	{
		Age += DeltaTime;
		if (SourceStruct.Duration > 0f && Age >= SourceStruct.Duration)
		{
			EventRealEnd = true;
		}
	}
}
