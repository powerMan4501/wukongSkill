using b1.UI.Comm;

namespace b1;

public interface IAutoSizeItem
{
	BUI_Button GetBUIButton();

	void SetSizeMultiple(float SizeMultiple);

	void SetScaleMultiple(float ScaleMultiple);

	float GetSizeMultiple();

	float GetScaleMultiple();

	void SetPosition(float Position);

	float GetPosition();

	void SetBasePosition(float BasePosition);

	float GetBasePosition();

	void SetOrder(int Order);

	int GetOrder();

	void SetIsActive(EChangeReason Reason, bool IsActive);

	bool GetIsActive();

	bool IsVisable();
}
