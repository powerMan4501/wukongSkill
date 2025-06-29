using UnrealEngine.Engine;

namespace b1.GSMUI.GSWidget;

public interface IProcBar : IGSMUITickable
{
	void GSOnConstruct();

	UMaterialInstanceDynamic GetMainMat();

	void SetValue(float NewValue, bool IsImmediately = false);

	float GetRealValue();

	void SetMaxValue(float InMaxValue, bool IsImmediately = false);

	float GetMaxValue();

	void PlayScaleAnim();

	void StopScaleAnim();

	bool GetInScaleAnim();
}
