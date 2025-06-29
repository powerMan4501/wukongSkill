using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BUBirthPoint")]
internal class BUBirthPoint : ABGUBirthPoint
{
	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[USharpPath("/Script/b1-Managed.BUBirthPoint:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
	}

	[USharpPath("/Script/b1-Managed.BUBirthPoint:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BUBirthPoint:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUBirthPoint bUBirthPoint = GCHelper.Find<b1.BUBirthPoint>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bUBirthPoint.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUBirthPoint:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUBirthPoint bUBirthPoint = GCHelper.Find<b1.BUBirthPoint>(obj);
		bUBirthPoint.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUBirthPoint");
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUBirthPoint:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUBirthPoint:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BUBirthPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUBirthPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUBirthPoint));
	}
}
