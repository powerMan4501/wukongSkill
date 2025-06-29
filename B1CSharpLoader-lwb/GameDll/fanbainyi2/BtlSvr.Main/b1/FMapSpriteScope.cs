using System;
using System.Collections.Generic;

namespace b1;

internal class FMapSpriteScope : IDisposable
{
	private static readonly List<b1.FMapSpriteScope> Scopes = new List<b1.FMapSpriteScope>();

	public FMapSpriteScope()
	{
		Scopes.Add(this);
	}

	public void Dispose()
	{
		if (GSEUtil.Ensure(Scopes.Count > 0 && Scopes.Contains(this)))
		{
			Scopes.Remove(this);
		}
	}

	public static bool IsInScope()
	{
		return Scopes.Count > 0;
	}
}
