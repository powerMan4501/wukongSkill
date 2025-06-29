using System;
using System.Collections.Generic;
using BtlU3;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ILRuntime.Runtime.CLRBinding;
using ILRuntime.Runtime.Intepreter;
using UnrealEngine.Engine;

namespace b1;

public static class GenerateCLRBinding
{
	public static void Generate(string Path = null)
	{
		if (Path == null)
		{
			Path = USystemLibrary.GetProjectDirectory().Replace("/", "\\") + "\\Managed\\b1.Managed\\AutoGenClrBinding";
		}
		BindingCodeGenerator.GenerateBindingCode(new List<Type>
		{
			typeof(CodedOutputStream),
			typeof(CodedInputStream),
			typeof(RepeatedField<long>),
			typeof(RepeatedField<int>),
			typeof(RepeatedField<string>),
			typeof(RepeatedField<ILTypeInstance>),
			typeof(IMessage),
			typeof(MessageExtensions),
			typeof(WireFormat),
			typeof(TBFUStB2DUnitCommDesc),
			typeof(FUStB2DUnitCommDesc),
			typeof(RepeatedField<FUStB2DUnitCommDesc>)
		}, Path);
	}
}
