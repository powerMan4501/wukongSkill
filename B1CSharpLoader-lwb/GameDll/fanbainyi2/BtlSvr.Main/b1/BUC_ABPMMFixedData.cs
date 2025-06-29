using UnrealEngine.Engine;

namespace b1;

public class BUC_ABPMMFixedData : IBUC_ABPMMFixedData
{
	private IBUC_SimpleStateData SimpleStateData;

	public float MMKeepAlpha { get; set; }

	public void Init(IBUC_SimpleStateData InSimpleStateData)
	{
		MMKeepAlpha = 0f;
		SimpleStateData = InSimpleStateData;
	}

	public void Update(AActor Owner, IBUC_ABPCommonSettingData CommonData)
	{
		if (CommonData.FinalABPMoveMode == EABPMoveMode.MotionMatching && Owner as BGUCharacterCS != null)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.KeepMMRunning))
			{
				MMKeepAlpha = 0.01f;
			}
			else
			{
				MMKeepAlpha = 0f;
			}
		}
	}
}
