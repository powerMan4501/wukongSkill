using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper", "AIModule", UnrealModuleType.Engine)]
public class UEnvQueryInstanceBlueprintWrapper : UObject, IEQSQueryResultSourceInterface, IInterface
{
	[UDelegate]
	[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:EQSQueryDoneSignature__DelegateSignature")]
	public class FEQSQueryDoneSignature : FMulticastDelegate<FEQSQueryDoneSignature.Signature>
	{
		public delegate void Signature(UEnvQueryInstanceBlueprintWrapper QueryInstance, EEnvQueryStatus QueryStatus);

		private static bool EQSQueryDoneSignature__DelegateSignature_IsValid;

		private static IntPtr EQSQueryDoneSignature__DelegateSignature_FunctionAddress;

		private static int EQSQueryDoneSignature__DelegateSignature_ParamsSize;

		private static bool EQSQueryDoneSignature__DelegateSignature_QueryInstance_IsValid;

		private static FFieldAddress EQSQueryDoneSignature__DelegateSignature_QueryInstance_PropertyAddress;

		private static int EQSQueryDoneSignature__DelegateSignature_QueryInstance_Offset;

		private static bool EQSQueryDoneSignature__DelegateSignature_QueryStatus_IsValid;

		private static FFieldAddress EQSQueryDoneSignature__DelegateSignature_QueryStatus_PropertyAddress;

		private static int EQSQueryDoneSignature__DelegateSignature_QueryStatus_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FEQSQueryDoneSignature()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			EQSQueryDoneSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:EQSQueryDoneSignature__DelegateSignature");
			EQSQueryDoneSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(EQSQueryDoneSignature__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref EQSQueryDoneSignature__DelegateSignature_QueryInstance_PropertyAddress, EQSQueryDoneSignature__DelegateSignature_FunctionAddress, "QueryInstance");
			EQSQueryDoneSignature__DelegateSignature_QueryInstance_Offset = NativeReflectionCached.GetPropertyOffset(EQSQueryDoneSignature__DelegateSignature_FunctionAddress, "QueryInstance");
			EQSQueryDoneSignature__DelegateSignature_QueryInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSQueryDoneSignature__DelegateSignature_FunctionAddress, "QueryInstance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref EQSQueryDoneSignature__DelegateSignature_QueryStatus_PropertyAddress, EQSQueryDoneSignature__DelegateSignature_FunctionAddress, "QueryStatus");
			EQSQueryDoneSignature__DelegateSignature_QueryStatus_Offset = NativeReflectionCached.GetPropertyOffset(EQSQueryDoneSignature__DelegateSignature_FunctionAddress, "QueryStatus");
			EQSQueryDoneSignature__DelegateSignature_QueryStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(EQSQueryDoneSignature__DelegateSignature_FunctionAddress, "QueryStatus", Classes.FByteProperty);
			EQSQueryDoneSignature__DelegateSignature_IsValid = EQSQueryDoneSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && EQSQueryDoneSignature__DelegateSignature_QueryInstance_IsValid && EQSQueryDoneSignature__DelegateSignature_QueryStatus_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:EQSQueryDoneSignature__DelegateSignature", EQSQueryDoneSignature__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UEnvQueryInstanceBlueprintWrapper QueryInstance, EEnvQueryStatus QueryStatus)
		{
			if (!EQSQueryDoneSignature__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:EQSQueryDoneSignature__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(EQSQueryDoneSignature__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EQSQueryDoneSignature__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UEnvQueryInstanceBlueprintWrapper>.ToNative(IntPtr.Add(intPtr, EQSQueryDoneSignature__DelegateSignature_QueryInstance_Offset), 0, EQSQueryDoneSignature__DelegateSignature_QueryInstance_PropertyAddress.Address, QueryInstance);
				EnumMarshaler<EEnvQueryStatus>.ToNative(IntPtr.Add(intPtr, EQSQueryDoneSignature__DelegateSignature_QueryStatus_Offset), 0, EQSQueryDoneSignature__DelegateSignature_QueryStatus_PropertyAddress.Address, QueryStatus);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool QueryID_IsValid;

	private static int QueryID_Offset;

	private static bool ItemType_IsValid;

	private static int ItemType_Offset;

	private static bool OptionIndex_IsValid;

	private static int OptionIndex_Offset;

	private static bool OnQueryFinishedEvent_IsValid;

	private static int OnQueryFinishedEvent_Offset;

	private FEQSQueryDoneSignature OnQueryFinishedEvent_DelegateCached;

	private static bool SetNamedParam_IsValid;

	private static IntPtr SetNamedParam_FunctionAddress;

	private static int SetNamedParam_ParamsSize;

	private static bool SetNamedParam_ParamName_IsValid;

	private static FFieldAddress SetNamedParam_ParamName_PropertyAddress;

	private static int SetNamedParam_ParamName_Offset;

	private static bool SetNamedParam_Value_IsValid;

	private static FFieldAddress SetNamedParam_Value_PropertyAddress;

	private static int SetNamedParam_Value_Offset;

	private static bool GetQueryResultsAsLocations_IsValid;

	private static IntPtr GetQueryResultsAsLocations_FunctionAddress;

	private static int GetQueryResultsAsLocations_ParamsSize;

	private static bool GetQueryResultsAsLocations_ResultLocations_IsValid;

	private static FFieldAddress GetQueryResultsAsLocations_ResultLocations_PropertyAddress;

	private static int GetQueryResultsAsLocations_ResultLocations_Offset;

	private static bool GetQueryResultsAsLocations_ReturnValue_IsValid;

	private static FFieldAddress GetQueryResultsAsLocations_ReturnValue_PropertyAddress;

	private static int GetQueryResultsAsLocations_ReturnValue_Offset;

	private static bool GetQueryResultsAsActors_IsValid;

	private static IntPtr GetQueryResultsAsActors_FunctionAddress;

	private static int GetQueryResultsAsActors_ParamsSize;

	private static bool GetQueryResultsAsActors_ResultActors_IsValid;

	private static FFieldAddress GetQueryResultsAsActors_ResultActors_PropertyAddress;

	private static int GetQueryResultsAsActors_ResultActors_Offset;

	private static bool GetQueryResultsAsActors_ReturnValue_IsValid;

	private static FFieldAddress GetQueryResultsAsActors_ReturnValue_PropertyAddress;

	private static int GetQueryResultsAsActors_ReturnValue_Offset;

	private static bool GetItemScore_IsValid;

	private static IntPtr GetItemScore_FunctionAddress;

	private static int GetItemScore_ParamsSize;

	private static bool GetItemScore_ItemIndex_IsValid;

	private static FFieldAddress GetItemScore_ItemIndex_PropertyAddress;

	private static int GetItemScore_ItemIndex_Offset;

	private static bool GetItemScore_ReturnValue_IsValid;

	private static FFieldAddress GetItemScore_ReturnValue_PropertyAddress;

	private static int GetItemScore_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:QueryID")]
	protected int QueryID
	{
		get
		{
			CheckDestroyed();
			if (!QueryID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:QueryID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, QueryID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QueryID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:QueryID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, QueryID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510164uL)]
	[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:ItemType")]
	protected TSubclassOf<UEnvQueryItemType> ItemType
	{
		get
		{
			CheckDestroyed();
			if (!ItemType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:ItemType");
				return default(TSubclassOf<UEnvQueryItemType>);
			}
			return TSubclassOfMarshaler<UEnvQueryItemType>.FromNative(IntPtr.Add(base.Address, ItemType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:ItemType");
			}
			else
			{
				TSubclassOfMarshaler<UEnvQueryItemType>.ToNative(IntPtr.Add(base.Address, ItemType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:OptionIndex")]
	protected int OptionIndex
	{
		get
		{
			CheckDestroyed();
			if (!OptionIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:OptionIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OptionIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OptionIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:OptionIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OptionIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:OnQueryFinishedEvent")]
	protected FEQSQueryDoneSignature OnQueryFinishedEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnQueryFinishedEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:OnQueryFinishedEvent");
				return new FEQSQueryDoneSignature();
			}
			if (OnQueryFinishedEvent_DelegateCached == null)
			{
				OnQueryFinishedEvent_DelegateCached = new FEQSQueryDoneSignature();
				OnQueryFinishedEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnQueryFinishedEvent_Offset));
			}
			return OnQueryFinishedEvent_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:SetNamedParam")]
	public unsafe void SetNamedParam(FName ParamName, float Value)
	{
		CheckDestroyed();
		if (!SetNamedParam_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:SetNamedParam");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNamedParam_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNamedParam_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNamedParam_ParamName_Offset), 0, SetNamedParam_ParamName_PropertyAddress.Address, ParamName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNamedParam_Value_Offset), 0, SetNamedParam_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNamedParam_FunctionAddress, intPtr, SetNamedParam_ParamsSize);
	}

	[UFunction(Flags = 1145177089u)]
	[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:GetQueryResultsAsLocations")]
	public unsafe bool GetQueryResultsAsLocations(out List<FVector> ResultLocations)
	{
		CheckDestroyed();
		if (!GetQueryResultsAsLocations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:GetQueryResultsAsLocations");
			ResultLocations = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQueryResultsAsLocations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQueryResultsAsLocations_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetQueryResultsAsLocations_FunctionAddress, intPtr, GetQueryResultsAsLocations_ParamsSize);
		ResultLocations = new TArrayCopyMarshaler<FVector>(1, GetQueryResultsAsLocations_ResultLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetQueryResultsAsLocations_ResultLocations_Offset));
		NativeReflection.DestroyValue_InContainer(GetQueryResultsAsLocations_ResultLocations_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetQueryResultsAsLocations_ReturnValue_Offset), 0, GetQueryResultsAsLocations_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145177089u)]
	[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:GetQueryResultsAsActors")]
	public unsafe bool GetQueryResultsAsActors(out List<AActor> ResultActors)
	{
		CheckDestroyed();
		if (!GetQueryResultsAsActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:GetQueryResultsAsActors");
			ResultActors = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQueryResultsAsActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQueryResultsAsActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetQueryResultsAsActors_FunctionAddress, intPtr, GetQueryResultsAsActors_ParamsSize);
		ResultActors = new TArrayCopyMarshaler<AActor>(1, GetQueryResultsAsActors_ResultActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetQueryResultsAsActors_ResultActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetQueryResultsAsActors_ResultActors_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetQueryResultsAsActors_ReturnValue_Offset), 0, GetQueryResultsAsActors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:GetItemScore")]
	public unsafe float GetItemScore(int ItemIndex)
	{
		CheckDestroyed();
		if (!GetItemScore_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:GetItemScore");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetItemScore_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetItemScore_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetItemScore_ItemIndex_Offset), 0, GetItemScore_ItemIndex_PropertyAddress.Address, ItemIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetItemScore_FunctionAddress, intPtr, GetItemScore_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetItemScore_ReturnValue_Offset), 0, GetItemScore_ReturnValue_PropertyAddress.Address);
	}

	static UEnvQueryInstanceBlueprintWrapper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEnvQueryInstanceBlueprintWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEnvQueryInstanceBlueprintWrapper));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.EnvQueryInstanceBlueprintWrapper");
		QueryID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QueryID");
		QueryID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QueryID", Classes.FIntProperty);
		ItemType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemType");
		ItemType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemType", Classes.FClassProperty);
		OptionIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OptionIndex");
		OptionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OptionIndex", Classes.FIntProperty);
		OnQueryFinishedEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnQueryFinishedEvent");
		OnQueryFinishedEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnQueryFinishedEvent", Classes.FMulticastDelegateProperty);
		SetNamedParam_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNamedParam");
		SetNamedParam_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNamedParam_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNamedParam_ParamName_PropertyAddress, SetNamedParam_FunctionAddress, "ParamName");
		SetNamedParam_ParamName_Offset = NativeReflectionCached.GetPropertyOffset(SetNamedParam_FunctionAddress, "ParamName");
		SetNamedParam_ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNamedParam_FunctionAddress, "ParamName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNamedParam_Value_PropertyAddress, SetNamedParam_FunctionAddress, "Value");
		SetNamedParam_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNamedParam_FunctionAddress, "Value");
		SetNamedParam_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNamedParam_FunctionAddress, "Value", Classes.FFloatProperty);
		SetNamedParam_IsValid = SetNamedParam_FunctionAddress != IntPtr.Zero && SetNamedParam_ParamName_IsValid && SetNamedParam_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:SetNamedParam", SetNamedParam_IsValid);
		GetQueryResultsAsLocations_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetQueryResultsAsLocations");
		GetQueryResultsAsLocations_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQueryResultsAsLocations_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQueryResultsAsLocations_ResultLocations_PropertyAddress, GetQueryResultsAsLocations_FunctionAddress, "ResultLocations");
		GetQueryResultsAsLocations_ResultLocations_Offset = NativeReflectionCached.GetPropertyOffset(GetQueryResultsAsLocations_FunctionAddress, "ResultLocations");
		GetQueryResultsAsLocations_ResultLocations_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueryResultsAsLocations_FunctionAddress, "ResultLocations", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQueryResultsAsLocations_ReturnValue_PropertyAddress, GetQueryResultsAsLocations_FunctionAddress, "ReturnValue");
		GetQueryResultsAsLocations_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQueryResultsAsLocations_FunctionAddress, "ReturnValue");
		GetQueryResultsAsLocations_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueryResultsAsLocations_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetQueryResultsAsLocations_IsValid = GetQueryResultsAsLocations_FunctionAddress != IntPtr.Zero && GetQueryResultsAsLocations_ResultLocations_IsValid && GetQueryResultsAsLocations_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:GetQueryResultsAsLocations", GetQueryResultsAsLocations_IsValid);
		GetQueryResultsAsActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetQueryResultsAsActors");
		GetQueryResultsAsActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQueryResultsAsActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQueryResultsAsActors_ResultActors_PropertyAddress, GetQueryResultsAsActors_FunctionAddress, "ResultActors");
		GetQueryResultsAsActors_ResultActors_Offset = NativeReflectionCached.GetPropertyOffset(GetQueryResultsAsActors_FunctionAddress, "ResultActors");
		GetQueryResultsAsActors_ResultActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueryResultsAsActors_FunctionAddress, "ResultActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQueryResultsAsActors_ReturnValue_PropertyAddress, GetQueryResultsAsActors_FunctionAddress, "ReturnValue");
		GetQueryResultsAsActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQueryResultsAsActors_FunctionAddress, "ReturnValue");
		GetQueryResultsAsActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueryResultsAsActors_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetQueryResultsAsActors_IsValid = GetQueryResultsAsActors_FunctionAddress != IntPtr.Zero && GetQueryResultsAsActors_ResultActors_IsValid && GetQueryResultsAsActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:GetQueryResultsAsActors", GetQueryResultsAsActors_IsValid);
		GetItemScore_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetItemScore");
		GetItemScore_ParamsSize = NativeReflection.GetFunctionParamsSize(GetItemScore_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetItemScore_ItemIndex_PropertyAddress, GetItemScore_FunctionAddress, "ItemIndex");
		GetItemScore_ItemIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetItemScore_FunctionAddress, "ItemIndex");
		GetItemScore_ItemIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetItemScore_FunctionAddress, "ItemIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetItemScore_ReturnValue_PropertyAddress, GetItemScore_FunctionAddress, "ReturnValue");
		GetItemScore_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetItemScore_FunctionAddress, "ReturnValue");
		GetItemScore_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetItemScore_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetItemScore_IsValid = GetItemScore_FunctionAddress != IntPtr.Zero && GetItemScore_ItemIndex_IsValid && GetItemScore_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.EnvQueryInstanceBlueprintWrapper:GetItemScore", GetItemScore_IsValid);
	}
}
