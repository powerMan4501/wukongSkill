using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("演员: 设置HiddenInGame")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerHiddenInGame")]
internal class BED_MovieNode_PerformerHiddenInGame : b1.BED_MovieNode_PerformerAction
{
	private static bool bHiddenInGame_IsValid;

	private static int bHiddenInGame_Offset;

	private static FFieldAddress bHiddenInGame_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[DisplayName("设置隐藏")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.DisplayAfter, "Performer")]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerHiddenInGame:bHiddenInGame")]
	public bool bHiddenInGame
	{
		get
		{
			CheckDestroyed();
			if (!bHiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerHiddenInGame:bHiddenInGame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHiddenInGame_Offset), 0, bHiddenInGame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerHiddenInGame:bHiddenInGame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHiddenInGame_Offset), 0, bHiddenInGame_PropertyAddress.Address, value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PerformerSetHiddenInGame;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerHiddenInGame:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("演员： " + base.Performer.TagName.PlainName);
		stringBuilder.Append($"设置HiddenInGame: {bHiddenInGame}");
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PerformerSetHiddenInGame
		{
			PerformerGuid = base.Performer.TagName.PlainName,
			HiddenInGame = bHiddenInGame
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PerformerHiddenInGame:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PerformerHiddenInGame bED_MovieNode_PerformerHiddenInGame = GCHelper.Find<b1.BED_MovieNode_PerformerHiddenInGame>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PerformerHiddenInGame.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PerformerHiddenInGame");
		NativeReflection.GetPropertyRef(ref bHiddenInGame_PropertyAddress, intPtr, "bHiddenInGame");
		bHiddenInGame_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHiddenInGame");
		bHiddenInGame_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHiddenInGame", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PerformerHiddenInGame:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PerformerHiddenInGame()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PerformerHiddenInGame)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PerformerHiddenInGame));
	}
}
