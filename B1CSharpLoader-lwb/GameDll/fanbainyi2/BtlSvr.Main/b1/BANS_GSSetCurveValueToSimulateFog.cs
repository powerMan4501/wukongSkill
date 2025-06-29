using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Set CurveValue To SimulateFog")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToSimulateFog")]
internal class BANS_GSSetCurveValueToSimulateFog : BANS_GSBase
{
	private static bool FloatCurveParamList_IsValid;

	private static int FloatCurveParamList_Offset;

	private static FFieldAddress FloatCurveParamList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSFloatCurveToParam> FloatCurveParamList_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCurveValueToSimulateFog:FloatCurveParamList")]
	public TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList
	{
		get
		{
			CheckDestroyed();
			if (!FloatCurveParamList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCurveValueToSimulateFog:FloatCurveParamList");
				return null;
			}
			if (FloatCurveParamList_Marshaler == null)
			{
				FloatCurveParamList_Marshaler = new TArrayReadWriteMarshaler<FGSFloatCurveToParam>(1, FloatCurveParamList_PropertyAddress, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.FromNative, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.ToNative);
			}
			return FloatCurveParamList_Marshaler.FromNative(IntPtr.Add(base.Address, FloatCurveParamList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetCurveValueToSimulateFog");
		NativeReflection.GetPropertyRef(ref FloatCurveParamList_PropertyAddress, unrealStruct, "FloatCurveParamList");
		FloatCurveParamList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FloatCurveParamList");
		FloatCurveParamList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FloatCurveParamList", Classes.FArrayProperty);
	}

	static BANS_GSSetCurveValueToSimulateFog()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSetCurveValueToSimulateFog)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSetCurveValueToSimulateFog));
	}
}
