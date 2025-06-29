using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;

namespace System.CodeDom.Compiler;

[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class CodeCompiler : CodeGenerator, ICodeCompiler
{
	protected abstract string FileExtension { get; }

	protected abstract string CompilerName { get; }

	CompilerResults ICodeCompiler.CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit e)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromDom(options, e);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromFile(CompilerParameters options, string fileName)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromFile(options, fileName);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromSource(CompilerParameters options, string source)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromSource(options, source);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromSourceBatch(options, sources);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileNames == null)
		{
			throw new ArgumentNullException("fileNames");
		}
		try
		{
			foreach (string path in fileNames)
			{
				using (File.OpenRead(path))
				{
				}
			}
			return FromFileBatch(options, fileNames);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] ea)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromDomBatch(options, ea);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	internal void Compile(CompilerParameters options, string compilerDirectory, string compilerExe, string arguments, ref string outputFile, ref int nativeReturnValue, string trueArgs)
	{
		string errorName = null;
		outputFile = options.TempFiles.AddExtension("out");
		string text = Path.Combine(compilerDirectory, compilerExe);
		if (File.Exists(text))
		{
			string trueCmdLine = null;
			if (trueArgs != null)
			{
				trueCmdLine = "\"" + text + "\" " + trueArgs;
			}
			nativeReturnValue = Executor.ExecWaitWithCapture(options.SafeUserToken, "\"" + text + "\" " + arguments, Environment.CurrentDirectory, options.TempFiles, ref outputFile, ref errorName, trueCmdLine);
			return;
		}
		throw new InvalidOperationException(SR.GetString("CompilerNotFound", text));
	}

	protected virtual CompilerResults FromDom(CompilerParameters options, CodeCompileUnit e)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		return FromDomBatch(options, new CodeCompileUnit[1] { e });
	}

	protected virtual CompilerResults FromFile(CompilerParameters options, string fileName)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		using (File.OpenRead(fileName))
		{
		}
		return FromFileBatch(options, new string[1] { fileName });
	}

	protected virtual CompilerResults FromSource(CompilerParameters options, string source)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		return FromSourceBatch(options, new string[1] { source });
	}

	protected virtual CompilerResults FromDomBatch(CompilerParameters options, CodeCompileUnit[] ea)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (ea == null)
		{
			throw new ArgumentNullException("ea");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		string[] array = new string[ea.Length];
		CompilerResults compilerResults = null;
		try
		{
			WindowsImpersonationContext impersonation = Executor.RevertImpersonation();
			try
			{
				for (int i = 0; i < ea.Length; i++)
				{
					if (ea[i] == null)
					{
						continue;
					}
					ResolveReferencedAssemblies(options, ea[i]);
					array[i] = options.TempFiles.AddExtension(i + FileExtension);
					Stream stream = new FileStream(array[i], FileMode.Create, FileAccess.Write, FileShare.Read);
					try
					{
						using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
						((ICodeGenerator)this).GenerateCodeFromCompileUnit(ea[i], (TextWriter)streamWriter, base.Options);
						streamWriter.Flush();
					}
					finally
					{
						stream.Close();
					}
				}
				return FromFileBatch(options, array);
			}
			finally
			{
				Executor.ReImpersonate(impersonation);
			}
		}
		catch
		{
			throw;
		}
	}

	private void ResolveReferencedAssemblies(CompilerParameters options, CodeCompileUnit e)
	{
		if (e.ReferencedAssemblies.Count <= 0)
		{
			return;
		}
		StringEnumerator enumerator = e.ReferencedAssemblies.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (!options.ReferencedAssemblies.Contains(current))
				{
					options.ReferencedAssemblies.Add(current);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}

	protected virtual CompilerResults FromFileBatch(CompilerParameters options, string[] fileNames)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileNames == null)
		{
			throw new ArgumentNullException("fileNames");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		string outputFile = null;
		int nativeReturnValue = 0;
		CompilerResults compilerResults = new CompilerResults(options.TempFiles);
		SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.ControlEvidence);
		securityPermission.Assert();
		try
		{
			compilerResults.Evidence = options.Evidence;
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		bool flag = false;
		if (options.OutputAssembly == null || options.OutputAssembly.Length == 0)
		{
			string fileExtension = (options.GenerateExecutable ? "exe" : "dll");
			options.OutputAssembly = compilerResults.TempFiles.AddExtension(fileExtension, !options.GenerateInMemory);
			new FileStream(options.OutputAssembly, FileMode.Create, FileAccess.ReadWrite).Close();
			flag = true;
		}
		compilerResults.TempFiles.AddExtension("pdb");
		string text = CmdArgsFromParameters(options) + " " + JoinStringArray(fileNames, " ");
		string responseFileCmdArgs = GetResponseFileCmdArgs(options, text);
		string trueArgs = null;
		if (responseFileCmdArgs != null)
		{
			trueArgs = text;
			text = responseFileCmdArgs;
		}
		Compile(options, Executor.GetRuntimeInstallDirectory(), CompilerName, text, ref outputFile, ref nativeReturnValue, trueArgs);
		compilerResults.NativeCompilerReturnValue = nativeReturnValue;
		if (nativeReturnValue != 0 || options.WarningLevel > 0)
		{
			FileStream fileStream = new FileStream(outputFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			try
			{
				if (fileStream.Length > 0)
				{
					StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);
					string text2;
					do
					{
						text2 = streamReader.ReadLine();
						if (text2 != null)
						{
							compilerResults.Output.Add(text2);
							ProcessCompilerOutputLine(compilerResults, text2);
						}
					}
					while (text2 != null);
				}
			}
			finally
			{
				fileStream.Close();
			}
			if (nativeReturnValue != 0 && flag)
			{
				File.Delete(options.OutputAssembly);
			}
		}
		if (!compilerResults.Errors.HasErrors && options.GenerateInMemory)
		{
			FileStream fileStream2 = new FileStream(options.OutputAssembly, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				int num = (int)fileStream2.Length;
				byte[] array = new byte[num];
				fileStream2.Read(array, 0, num);
				SecurityPermission securityPermission2 = new SecurityPermission(SecurityPermissionFlag.ControlEvidence);
				securityPermission2.Assert();
				try
				{
					if (!FileIntegrity.IsEnabled)
					{
						compilerResults.CompiledAssembly = Assembly.Load(array, null, options.Evidence);
					}
					else
					{
						if (!FileIntegrity.IsTrusted(fileStream2.SafeFileHandle))
						{
							throw new IOException(SR.GetString("FileIntegrityCheckFailed", options.OutputAssembly));
						}
						compilerResults.CompiledAssembly = LoadImageSkipIntegrityCheck(array, null, options.Evidence);
					}
				}
				finally
				{
					CodeAccessPermission.RevertAssert();
				}
			}
			finally
			{
				fileStream2.Close();
			}
		}
		else
		{
			compilerResults.PathToAssembly = options.OutputAssembly;
		}
		return compilerResults;
	}

	protected abstract void ProcessCompilerOutputLine(CompilerResults results, string line);

	protected abstract string CmdArgsFromParameters(CompilerParameters options);

	protected virtual string GetResponseFileCmdArgs(CompilerParameters options, string cmdArgs)
	{
		string text = options.TempFiles.AddExtension("cmdline");
		Stream stream = new FileStream(text, FileMode.Create, FileAccess.Write, FileShare.Read);
		try
		{
			using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
			streamWriter.Write(cmdArgs);
			streamWriter.Flush();
		}
		finally
		{
			stream.Close();
		}
		return "@\"" + text + "\"";
	}

	protected virtual CompilerResults FromSourceBatch(CompilerParameters options, string[] sources)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (sources == null)
		{
			throw new ArgumentNullException("sources");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		string[] array = new string[sources.Length];
		FileStream[] array2 = new FileStream[sources.Length];
		CompilerResults compilerResults = null;
		try
		{
			WindowsImpersonationContext impersonation = Executor.RevertImpersonation();
			try
			{
				try
				{
					bool isEnabled = FileIntegrity.IsEnabled;
					for (int i = 0; i < sources.Length; i++)
					{
						string text = options.TempFiles.AddExtension(i + FileExtension);
						FileStream fileStream = (array2[i] = new FileStream(text, FileMode.Create, FileAccess.ReadWrite, FileShare.Read));
						using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
						{
							streamWriter.Write(sources[i]);
							streamWriter.Flush();
							if (isEnabled)
							{
								FileIntegrity.MarkAsTrusted(fileStream.SafeFileHandle);
							}
						}
						array[i] = text;
					}
					return FromFileBatch(options, array);
				}
				finally
				{
					for (int j = 0; j < array2.Length && array2[j] != null; j++)
					{
						array2[j].Close();
					}
				}
			}
			finally
			{
				Executor.ReImpersonate(impersonation);
			}
		}
		catch
		{
			throw;
		}
	}

	protected static string JoinStringArray(string[] sa, string separator)
	{
		if (sa == null || sa.Length == 0)
		{
			return string.Empty;
		}
		if (sa.Length == 1)
		{
			return "\"" + sa[0] + "\"";
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < sa.Length - 1; i++)
		{
			stringBuilder.Append("\"");
			stringBuilder.Append(sa[i]);
			stringBuilder.Append("\"");
			stringBuilder.Append(separator);
		}
		stringBuilder.Append("\"");
		stringBuilder.Append(sa[sa.Length - 1]);
		stringBuilder.Append("\"");
		return stringBuilder.ToString();
	}

	internal static Assembly LoadImageSkipIntegrityCheck(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence)
	{
		MethodInfo method = typeof(Assembly).GetMethod("LoadImageSkipIntegrityCheck", BindingFlags.Static | BindingFlags.NonPublic);
		return (method != null) ? ((Assembly)method.Invoke(null, new object[3] { rawAssembly, rawSymbolStore, securityEvidence })) : Assembly.Load(rawAssembly, rawSymbolStore, securityEvidence);
	}
}
