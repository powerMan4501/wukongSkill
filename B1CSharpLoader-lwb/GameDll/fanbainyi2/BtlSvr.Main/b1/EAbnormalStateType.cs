using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AbnormalStateType")]
public enum EAbnormalStateType : byte
{
	[DisplayName("无")]
	None,
	[DisplayName("冰异常")]
	Abnormal_Freeze,
	[DisplayName("火异常")]
	Abnormal_Burn,
	[DisplayName("毒异常")]
	Abnormal_Poison,
	[DisplayName("雷异常")]
	Abnormal_Thunder,
	[DisplayName("阴异常")]
	Abnormal_Yin,
	[DisplayName("阳异常")]
	Abnormal_Yang,
	EnumMax
}
