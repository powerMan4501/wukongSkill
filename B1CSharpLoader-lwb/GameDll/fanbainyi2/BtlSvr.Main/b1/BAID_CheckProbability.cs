using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckProbability")]
internal class BAID_CheckProbability : BAID_Base
{
	private static bool Probability_IsValid;

	private static int Probability_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[Tooltip("百分比，填1~100以内的数")]
	[UMeta(MDProp.ClampMax, 100)]
	[USharpPath("/Script/b1-Managed.BAID_CheckProbability:Probability")]
	public float Probability
	{
		get
		{
			CheckDestroyed();
			if (!Probability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckProbability:Probability");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Probability_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Probability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckProbability:Probability");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Probability_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor as BGUCharacterCS == null)
		{
			return false;
		}
		if (UB1Util.GetRandomNumberFloat(0f, 100f) <= Probability)
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckProbability");
		Probability_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Probability");
		Probability_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Probability", Classes.FFloatProperty);
	}

	static BAID_CheckProbability()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckProbability)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckProbability));
	}
}
