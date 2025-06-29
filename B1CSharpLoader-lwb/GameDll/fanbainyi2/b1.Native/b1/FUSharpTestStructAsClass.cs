using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.USharpTestStructAsClass", "b1", UnrealModuleType.Game)]
public class FUSharpTestStructAsClass : StructAsClass
{
	private static bool Haha_IsValid;

	private static int Haha_Offset;

	private static bool FUSharpTestStructAsClass_IsValid;

	private static IntPtr FUSharpTestStructAsClass_StructAddress;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.USharpTestStructAsClass:Haha")]
	public FName Haha
	{
		get
		{
			CheckDestroyed();
			if (!Haha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.USharpTestStructAsClass:Haha");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, Haha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Haha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.USharpTestStructAsClass:Haha");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, Haha_Offset), value);
			}
		}
	}

	protected override IntPtr GetStructAddress()
	{
		return FUSharpTestStructAsClass_StructAddress;
	}

	static FUSharpTestStructAsClass()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUSharpTestStructAsClass)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUSharpTestStructAsClass));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = (FUSharpTestStructAsClass_StructAddress = NativeReflection.GetStruct("/Script/b1.USharpTestStructAsClass"));
		Haha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Haha");
		Haha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Haha", Classes.FNameProperty);
		FUSharpTestStructAsClass_IsValid = intPtr != IntPtr.Zero && Haha_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.USharpTestStructAsClass", FUSharpTestStructAsClass_IsValid);
	}
}
