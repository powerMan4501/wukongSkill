using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetailLevelInfo")]
public struct FDetailLevelInfo
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("主菜单关卡Id")]
	[USharpPath("/Script/b1-Managed.DetailLevelInfo:MainMenuLevelId")]
	public int MainMenuLevelId;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("设置关卡Id")]
	[USharpPath("/Script/b1-Managed.DetailLevelInfo:SetConfigLevelId")]
	public int SetConfigLevelId;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("序章关卡Id")]
	[USharpPath("/Script/b1-Managed.DetailLevelInfo:PrologueLevelId")]
	public int PrologueLevelId;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("序章之后的关卡Id")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetailLevelInfo:AfterPrologueLevelId")]
	public int AfterPrologueLevelId;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("单机浮屠塔关卡Id")]
	[USharpPath("/Script/b1-Managed.DetailLevelInfo:StandAlonePartyId")]
	public int StandAlonePartyId;

	[EditAnywhere]
	[UProperty]
	[DisplayName("联机浮屠塔关卡Id")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DetailLevelInfo:OnlinePartyId")]
	public int OnlinePartyId;

	private static int DetailLevelInfo_StructSize;

	public FDetailLevelInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DetailLevelInfo");
		DetailLevelInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDetailLevelInfo));
	}

	static FDetailLevelInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetailLevelInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetailLevelInfo));
	}
}
