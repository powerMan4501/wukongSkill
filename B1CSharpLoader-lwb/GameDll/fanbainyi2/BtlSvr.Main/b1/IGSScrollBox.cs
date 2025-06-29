using UnrealEngine.Slate;
using UnrealEngine.UMG;

namespace b1;

public interface IGSScrollBox : IInputWidget
{
	float TopSpacerLength { get; set; }

	float BottomSpacerLength { get; set; }

	void SetTopSpacerLength(float InTopSpacerLength);

	void SetBottomSpacerLength(float InBottomSpacerLength);

	float GetScrollOffset();

	float GetScrollSize();

	float GetScrollContent();

	float GetScrollOffsetOfEnd();

	bool GetIsOverConent();

	void SetIsForceSpacer(bool InIsForceSpacer);

	void SetScrollOffset(float TargetScrollOffset, bool Force = false, bool WithAnim = false);

	void ScrollWidgetIntoView(UWidget WidgetToFind, bool AnimateScroll = true, EDescendantScrollDestination ScrollDestination = EDescendantScrollDestination.IntoView, float Padding = 0f);
}
