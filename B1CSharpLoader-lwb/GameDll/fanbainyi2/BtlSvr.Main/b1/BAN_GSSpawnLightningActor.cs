using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

[UClass]
[DisplayName("GSSpawnLightningActor")]
[USharpPath("/Script/b1-Managed.BAN_GSSpawnLightningActor")]
internal class BAN_GSSpawnLightningActor : BAN_GSBase
{
	private static bool LightningFXActorClass_IsValid;

	private static int LightningFXActorClass_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool NeedAttach_IsValid;

	private static int NeedAttach_Offset;

	private static FFieldAddress NeedAttach_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSSpawnLightningActor:LightningFXActorClass")]
	public TSubclassOf<BGULightningFXActorBase> LightningFXActorClass
	{
		get
		{
			CheckDestroyed();
			if (!LightningFXActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnLightningActor:LightningFXActorClass");
				return default(TSubclassOf<BGULightningFXActorBase>);
			}
			return TSubclassOfMarshaler<BGULightningFXActorBase>.FromNative(IntPtr.Add(base.Address, LightningFXActorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightningFXActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnLightningActor:LightningFXActorClass");
			}
			else
			{
				TSubclassOfMarshaler<BGULightningFXActorBase>.ToNative(IntPtr.Add(base.Address, LightningFXActorClass_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSSpawnLightningActor:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnLightningActor:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnLightningActor:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSSpawnLightningActor:NeedAttach")]
	public bool NeedAttach
	{
		get
		{
			CheckDestroyed();
			if (!NeedAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnLightningActor:NeedAttach");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedAttach_Offset), 0, NeedAttach_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnLightningActor:NeedAttach");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedAttach_Offset), 0, NeedAttach_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSpawnLightningActor:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!NotifyParam.owner.IsNullOrDestroyed())
		{
			UWorld world = NotifyParam.owner.World;
			if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(world))
			{
				FTransform socketTransform = NotifyParam.MeshComp.GetSocketTransform(SocketName);
				FVector location = socketTransform.Translation;
				FRotator rotation = socketTransform.GetRotation().Rotator();
				FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
				{
					SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
				};
				(world.SpawnActor(LightningFXActorClass.Value, ref location, ref rotation, ref parameters) as BGULightningFXActorBase).AttachToComponent(NotifyParam.MeshComp, SocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: true);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSpawnLightningActor:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSSpawnLightningActor bAN_GSSpawnLightningActor = GCHelper.Find<b1.BAN_GSSpawnLightningActor>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSpawnLightningActor.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSpawnLightningActor");
		LightningFXActorClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "LightningFXActorClass");
		LightningFXActorClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LightningFXActorClass", Classes.FClassProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref NeedAttach_PropertyAddress, intPtr, "NeedAttach");
		NeedAttach_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedAttach");
		NeedAttach_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedAttach", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSpawnLightningActor:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSSpawnLightningActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSSpawnLightningActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSSpawnLightningActor));
	}
}
