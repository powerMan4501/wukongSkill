using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ModelOperateType")]
public enum EModelOperateType : byte
{
	[DisplayName("无法操作")]
	UnableOperate,
	[DisplayName("只能水平旋转")]
	OnlyYaw,
	[DisplayName("缩放+水平旋转")]
	ZoomYaw,
	[DisplayName("缩放+水平/竖直旋转")]
	ZoomYawPitch
}
