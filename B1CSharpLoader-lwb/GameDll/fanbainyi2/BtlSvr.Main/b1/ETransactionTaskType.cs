using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransactionTaskType")]
public enum ETransactionTaskType : byte
{
	[Category("Interact")]
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\ufffd\ufffd\ufffd\udbb7\udefb\ufffd\ufffd\ufffd\ufffd\ufffd")]
	Interact_RequestInteractObjLock,
	[Category("Interact")]
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\u0368\u05aa\ufffd\ufffd\ufffd\ufffd\ufffdﱾ\ufffd\ufffd\ufffd\ufffd\u05fc\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd")]
	Interact_TriggerPreInteract,
	[Category("Interact")]
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\ufffd\ufffd\ufffd\ufffd")]
	Interact_Input,
	[Category("Interact")]
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\ufffd\ufffdλ")]
	Interact_MatchPos,
	[Category("Interact")]
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd")]
	Interact_PlaySound,
	[Category("Interact")]
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffdͷ")]
	Interact_HandleInteractCamera,
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd϶\ufffdӦ\ufffd\ufffd\ufffd\ufffd\ufffdƼ\ufffd״\u032c")]
	[Category("Interact")]
	Interact_ProcessActionLock,
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\u05b4\ufffdн\ufffd\ufffd\ufffd\ufffd\ufffdΪ(\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd)\ufffd\ufffd\ufffdȴ\ufffd\ufffd\ufffd\ufffd\ufffd")]
	[Category("Interact")]
	Interact_DoInteractActionAndWait,
	[Category("Interact")]
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\u0368\u05aa\ufffd\ufffd\ufffd\ufffd\ufffdﱾ\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd")]
	Interact_TriggerBeInteract,
	[Category("Interact")]
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffdӦ\ufffd\ufffd\ufffd\ufffd\ufffdƼ\ufffd״\u032c")]
	Interact_ProcessActionUnLock,
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\ufffd\ufffd\ufffdý\ufffd\ufffd\ufffd\ufffd\ufffdҾ\ufffdͷ")]
	[Category("Interact")]
	Interact_ResetCamera,
	[DisplayName("\ufffd\ufffd\ufffd\ufffd_\ufffd\ufffd\ufffd\udbb7\udefb\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd")]
	[Category("Interact")]
	Interact_RequestInteractObjUnLock
}
