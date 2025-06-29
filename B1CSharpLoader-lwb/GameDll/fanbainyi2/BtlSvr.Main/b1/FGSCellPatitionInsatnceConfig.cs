using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FGSCellPatitionInsatnceConfig")]
public struct FGSCellPatitionInsatnceConfig
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionInsatnceConfig:WorldCellPatitionSize")]
	public FVector2D WorldCellPatitionSize;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionInsatnceConfig:WorldCellPatitionBias")]
	public FVector2D WorldCellPatitionBias;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionInsatnceConfig:CellXCount")]
	public int CellXCount;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionInsatnceConfig:CellYCount")]
	public int CellYCount;

	private static int FGSCellPatitionInsatnceConfig_StructSize;

	public FGSCellPatitionInsatnceConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.FGSCellPatitionInsatnceConfig");
		FGSCellPatitionInsatnceConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSCellPatitionInsatnceConfig));
	}

	static FGSCellPatitionInsatnceConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSCellPatitionInsatnceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSCellPatitionInsatnceConfig));
	}
}
