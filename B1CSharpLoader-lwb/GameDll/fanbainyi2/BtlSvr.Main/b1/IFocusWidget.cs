namespace b1;

public interface IFocusWidget
{
	void OnAddToFocus(EFocusReason Reason = EFocusReason.Init);

	void OnRemovedFromFocus(EFocusReason Reason = EFocusReason.Init);

	bool SetFocusOn(EFocusReason Reason = EFocusReason.Init);
}
