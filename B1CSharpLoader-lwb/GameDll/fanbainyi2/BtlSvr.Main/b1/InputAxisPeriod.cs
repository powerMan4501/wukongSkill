using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class InputAxisPeriod
{
	private const float MinRecordPeriod = 0.3f;

	private readonly float MaxPeriod;

	private readonly float MinRecordValue;

	private readonly List<InputAxisPeriodData> RecordData = new List<InputAxisPeriodData>();

	private readonly List<InputAxisPeriodData> DataList = new List<InputAxisPeriodData>();

	public InputAxisPeriod(float InMaxPeriod, float InMinRecordValue = 1f)
	{
		MaxPeriod = FMath.Max(0.3f, InMaxPeriod);
		MinRecordValue = InMinRecordValue;
	}

	public void AddInputAxis(float DeltaTime, FVector2D InputAxis)
	{
		if (InputAxis.Size() <= 0f)
		{
			RecordData.Clear();
			return;
		}
		RecordData.Add(new InputAxisPeriodData(DeltaTime, InputAxis));
		float num = 0f;
		int num2 = 0;
		for (int num3 = RecordData.Count - 1; num3 >= 0; num3--)
		{
			num += RecordData[num3].DeltaTime;
			if (num >= MaxPeriod)
			{
				num2 = num3 - 1;
				break;
			}
		}
		for (int i = 0; i < num2; i++)
		{
			RecordData.RemoveAt(0);
		}
	}

	public List<InputAxisPeriodData> GetAPeriodTimeDataList(float PeriodTime)
	{
		DataList.Clear();
		float num = 0f;
		for (int num2 = RecordData.Count - 1; num2 >= 0; num2--)
		{
			DataList.Add(RecordData[num2]);
			num += RecordData[num2].DeltaTime;
			if (PeriodTime > 0f && num >= PeriodTime)
			{
				break;
			}
		}
		return DataList;
	}

	public List<InputAxisPeriodData> GetAPeriodTimeDataListWithCurFrame(float PeriodTime)
	{
		List<InputAxisPeriodData> aPeriodTimeDataList = GetAPeriodTimeDataList(PeriodTime);
		aPeriodTimeDataList.Insert(0, new InputAxisPeriodData(0f, UWidgetLayoutLibrary.GetMousePositionOnPlatform()));
		return aPeriodTimeDataList;
	}

	public bool GetLastFrameHasValue()
	{
		return GetPeriodValue(0.3f) > MinRecordValue;
	}

	private float GetPeriodValue(float PeriodTime)
	{
		float num = 0f;
		bool flag = false;
		FVector2D v = FVector2D.ZeroVector;
		foreach (InputAxisPeriodData item in GetAPeriodTimeDataListWithCurFrame(PeriodTime))
		{
			if (!flag)
			{
				v = item.InputAxis;
				flag = true;
			}
			FVector2D inputAxis = item.InputAxis;
			num += FVector2D.Distance(inputAxis, v);
			v = inputAxis;
		}
		return num;
	}
}
