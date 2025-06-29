using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 25089)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.Geometry", "SlateCore", UnrealModuleType.Engine)]
public class FGeometry : StructAsClass
{
	private static bool FGeometry_IsValid;

	private static IntPtr FGeometry_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FGeometry_StructAddress;
	}

	static FGeometry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometry));
	}

	private static void LoadNativeType()
	{
		FGeometry_IsValid = (FGeometry_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.Geometry")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.Geometry", FGeometry_IsValid);
	}
}
