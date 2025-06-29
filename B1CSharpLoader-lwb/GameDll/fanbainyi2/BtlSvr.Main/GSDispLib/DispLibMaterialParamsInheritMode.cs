using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibMaterialParamsInheritMode")]
public enum DispLibMaterialParamsInheritMode : byte
{
	[DisplayName("不继承")]
	NoInherit,
	[DisplayName("继承初始材质同名参数")]
	InheritAllSameNameParams,
	[DisplayName("继承初始材质同名Override参数")]
	InheritOverrideSameNameParams,
	[DisplayName("自定义")]
	CustomInheritParamsNameArray
}
