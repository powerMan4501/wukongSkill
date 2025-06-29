using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCLightMode")]
public enum DispLibDBCLightMode : byte
{
	[DisplayName("Point")]
	[UMeta(MDProp.DisplayPriority, 1)]
	[UMeta(MD.ToolTip, "")]
	PointLight,
	[UMeta(MDProp.DisplayPriority, 2)]
	[UMeta(MD.ToolTip, "")]
	[DisplayName("Spot")]
	SpotLight
}
