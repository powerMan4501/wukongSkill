using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UMG.EventReply", "UMG", UnrealModuleType.Engine)]
public class FEventReply : StructAsClass
{
	private static bool FEventReply_IsValid;

	private static IntPtr FEventReply_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FEventReply_StructAddress;
	}

	static FEventReply()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEventReply)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEventReply));
	}

	private static void LoadNativeType()
	{
		FEventReply_IsValid = (FEventReply_StructAddress = NativeReflection.GetStruct("/Script/UMG.EventReply")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/UMG.EventReply", FEventReply_IsValid);
	}
}
