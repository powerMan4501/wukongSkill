using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("玩家：锁定单位目标")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget")]
internal class BED_MovieNode_PlayerLockTarget : BED_MovieNode
{
	private static bool Target_IsValid;

	private static int Target_Offset;

	private static bool bUnlock_IsValid;

	private static int bUnlock_Offset;

	private static FFieldAddress bUnlock_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Movie")]
	[DisplayName("目标")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget:Target")]
	public FGameplayTag Target
	{
		get
		{
			CheckDestroyed();
			if (!Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget:Target");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, Target_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget:Target");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, Target_Offset), value);
			}
		}
	}

	[DisplayName("解除锁定")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget:bUnlock")]
	public bool bUnlock
	{
		get
		{
			CheckDestroyed();
			if (!bUnlock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget:bUnlock");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUnlock_Offset), 0, bUnlock_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUnlock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget:bUnlock");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUnlock_Offset), 0, bUnlock_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		bUnlock = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PlayerLockTarget;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PlayerLockTarget
		{
			TargetGuid = Target.TagName.PlainName,
			IsUnlock = bUnlock
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(bUnlock ? "解除锁定" : "锁定");
		stringBuilder.AppendLine();
		stringBuilder.Append("目标： " + GameplayTagExtension.ToDebugString(Target));
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PlayerLockTarget bED_MovieNode_PlayerLockTarget = GCHelper.Find<b1.BED_MovieNode_PlayerLockTarget>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PlayerLockTarget.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget");
		Target_Offset = NativeReflection.GetPropertyOffset(intPtr, "Target");
		Target_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Target", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bUnlock_PropertyAddress, intPtr, "bUnlock");
		bUnlock_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUnlock");
		bUnlock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUnlock", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PlayerLockTarget:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PlayerLockTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PlayerLockTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PlayerLockTarget));
	}
}
