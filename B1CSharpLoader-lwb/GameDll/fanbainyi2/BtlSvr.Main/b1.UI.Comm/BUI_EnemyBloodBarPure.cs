using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_EnemyBloodBarPure")]
public abstract class BUI_EnemyBloodBarPure : BUI_Widget
{
	private static bool DoShowIn_IsValid;

	private static IntPtr DoShowIn_FunctionAddress;

	private static int DoShowIn_ParamsSize;

	private static bool DoShowIn_Owner_IsValid;

	private static int DoShowIn_Owner_Offset;

	private static bool DoGSInit_IsValid;

	private static IntPtr DoGSInit_FunctionAddress;

	private static int DoGSInit_ParamsSize;

	private static bool DoGSInit_OwnerCharacter_IsValid;

	private static int DoGSInit_OwnerCharacter_Offset;

	private static bool DoShowOut_IsValid;

	private static IntPtr DoShowOut_FunctionAddress;

	private static int DoShowOut_ParamsSize;

	private static bool DoFreeOwner_IsValid;

	private static IntPtr DoFreeOwner_FunctionAddress;

	private static int DoFreeOwner_ParamsSize;

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoShowOut")]
	public abstract void DoShowOut();

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoShowIn")]
	public abstract void DoShowIn(AActor Owner);

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoGSInit")]
	public abstract void DoGSInit(AActor OwnerCharacter);

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoFreeOwner")]
	public abstract void DoFreeOwner();

	[UFunctionInvoker("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoShowIn")]
	private static void DoShowIn__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_EnemyBloodBarPure bUI_EnemyBloodBarPure = GCHelper.Find<BUI_EnemyBloodBarPure>(obj);
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, DoShowIn_Owner_Offset));
		bUI_EnemyBloodBarPure.DoShowIn(owner);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoGSInit")]
	private static void DoGSInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_EnemyBloodBarPure bUI_EnemyBloodBarPure = GCHelper.Find<BUI_EnemyBloodBarPure>(obj);
		AActor ownerCharacter = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, DoGSInit_OwnerCharacter_Offset));
		bUI_EnemyBloodBarPure.DoGSInit(ownerCharacter);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoShowOut")]
	private static void DoShowOut__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_EnemyBloodBarPure bUI_EnemyBloodBarPure = GCHelper.Find<BUI_EnemyBloodBarPure>(obj);
		bUI_EnemyBloodBarPure.DoShowOut();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoFreeOwner")]
	private static void DoFreeOwner__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_EnemyBloodBarPure bUI_EnemyBloodBarPure = GCHelper.Find<BUI_EnemyBloodBarPure>(obj);
		bUI_EnemyBloodBarPure.DoFreeOwner();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_EnemyBloodBarPure");
		DoShowIn_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DoShowIn");
		DoShowIn_ParamsSize = NativeReflection.GetFunctionParamsSize(DoShowIn_FunctionAddress);
		DoShowIn_Owner_Offset = NativeReflection.GetPropertyOffset(DoShowIn_FunctionAddress, "Owner");
		DoShowIn_Owner_IsValid = NativeReflection.ValidatePropertyClass(DoShowIn_FunctionAddress, "Owner", Classes.FObjectProperty);
		DoShowIn_IsValid = DoShowIn_FunctionAddress != IntPtr.Zero && DoShowIn_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoShowIn", DoShowIn_IsValid);
		DoGSInit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DoGSInit");
		DoGSInit_ParamsSize = NativeReflection.GetFunctionParamsSize(DoGSInit_FunctionAddress);
		DoGSInit_OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(DoGSInit_FunctionAddress, "OwnerCharacter");
		DoGSInit_OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(DoGSInit_FunctionAddress, "OwnerCharacter", Classes.FObjectProperty);
		DoGSInit_IsValid = DoGSInit_FunctionAddress != IntPtr.Zero && DoGSInit_OwnerCharacter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoGSInit", DoGSInit_IsValid);
		DoShowOut_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DoShowOut");
		DoShowOut_ParamsSize = NativeReflection.GetFunctionParamsSize(DoShowOut_FunctionAddress);
		DoShowOut_IsValid = DoShowOut_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoShowOut", DoShowOut_IsValid);
		DoFreeOwner_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DoFreeOwner");
		DoFreeOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(DoFreeOwner_FunctionAddress);
		DoFreeOwner_IsValid = DoFreeOwner_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_EnemyBloodBarPure:DoFreeOwner", DoFreeOwner_IsValid);
	}

	static BUI_EnemyBloodBarPure()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_EnemyBloodBarPure)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_EnemyBloodBarPure));
	}
}
