using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

[UClass]
[DisplayName("B1 Spawn DecalActor")]
[USharpPath("/Script/b1-Managed.BAN_GSB1SpawnDecalActor")]
internal class BAN_GSB1SpawnDecalActor : BAN_GSBase
{
	private static bool DecalActorClass_IsValid;

	private static int DecalActorClass_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool SpawnPosOffset_IsValid;

	private static int SpawnPosOffset_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:DecalActorClass")]
	public TSubclassOf<BGUDecalActor> DecalActorClass
	{
		get
		{
			CheckDestroyed();
			if (!DecalActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:DecalActorClass");
				return default(TSubclassOf<BGUDecalActor>);
			}
			return TSubclassOfMarshaler<BGUDecalActor>.FromNative(IntPtr.Add(base.Address, DecalActorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DecalActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:DecalActorClass");
			}
			else
			{
				TSubclassOfMarshaler<BGUDecalActor>.ToNative(IntPtr.Add(base.Address, DecalActorClass_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:SpawnPosOffset")]
	public FVector SpawnPosOffset
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPosOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:SpawnPosOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, SpawnPosOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnPosOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:SpawnPosOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, SpawnPosOffset_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!NotifyParam.owner.IsNullOrDestroyed())
		{
			UWorld world = NotifyParam.owner.World;
			if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(world))
			{
				FTransform socketTransform = NotifyParam.MeshComp.GetSocketTransform(SocketName);
				FVector location = socketTransform.TransformLocation(SpawnPosOffset);
				FRotator rotation = socketTransform.GetRotation().Rotator();
				FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
				{
					SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
				};
				world.SpawnActor(DecalActorClass.Value, ref location, ref rotation, ref parameters);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSB1SpawnDecalActor bAN_GSB1SpawnDecalActor = GCHelper.Find<b1.BAN_GSB1SpawnDecalActor>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSB1SpawnDecalActor.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSB1SpawnDecalActor");
		DecalActorClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "DecalActorClass");
		DecalActorClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DecalActorClass", Classes.FClassProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		SpawnPosOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPosOffset");
		SpawnPosOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPosOffset", Classes.FStructProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSB1SpawnDecalActor:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSB1SpawnDecalActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSB1SpawnDecalActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSB1SpawnDecalActor));
	}
}
