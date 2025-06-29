using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibSocketSearchMode")]
public enum DispLibSocketSearchMode : byte
{
	[DisplayName("仅原始挂点")]
	OnlyOriginSocket,
	[DisplayName("仅接口挂点")]
	OnlyInterfaceSocket,
	[DisplayName("原始挂点优先")]
	OriginSocketPrecedence,
	[DisplayName("接口挂点优先")]
	InterfaceSocketPrecedence
}
