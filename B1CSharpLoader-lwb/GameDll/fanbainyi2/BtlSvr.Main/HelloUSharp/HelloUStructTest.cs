using System;
using UnrealEngine.Runtime;

namespace HelloUSharp;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.HelloUStructTest")]
public struct HelloUStructTest
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HelloUStructTest:TestValue")]
	public float TestValue;

	private static int HelloUStructTest_StructSize;

	public HelloUStructTest Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.HelloUStructTest");
		HelloUStructTest_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(HelloUStructTest));
	}

	static HelloUStructTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(HelloUStructTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(HelloUStructTest));
	}
}
