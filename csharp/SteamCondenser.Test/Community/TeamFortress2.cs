using System;
using NUnit.Framework;
using SteamCondenser.Steam.Community;

namespace SteamCondenser.Test
{
	[TestFixture]
	public class TeamFortress2
	{
		[Test]
		public void CustomUrl()
		{
			TF2Stats stats = new TF2Stats("koraktor");
			
			Assert.AreNotEqual(stats.AppID, 0);
			Assert.Greater(stats.AppID, 0);
						
			Assert.Greater(stats.ClassStats.Length, 0);
			Assert.AreEqual(stats.ClassStats.Length, 9);
			
			Assert.Greater(stats.Achievments.Length, 0);
			
			stats = (SteamID.Create("koraktor")).TF2Stats;
			
			Assert.AreNotEqual(stats.AppID, 0);
			Assert.Greater(stats.AppID, 0);
			Assert.Greater(stats.ClassStats.Length, 0);
			Assert.AreEqual(stats.ClassStats.Length, 9);
			Assert.Greater(stats.Achievments.Length, 0);
		}
		
		[Test]
		public void SteamID64()
		{
			TF2Stats stats = new TF2Stats(76561197961384956);
			
			Assert.AreNotEqual(stats.AppID, 0);
			Assert.Greater(stats.AppID, 0);
			Assert.Greater(stats.ClassStats.Length, 0);
			Assert.AreEqual(stats.ClassStats.Length, 9);
			Assert.Greater(stats.Achievments.Length, 0);
			
			stats = SteamID.Create(76561197961384956).TF2Stats;
			
			Assert.AreNotEqual(stats.AppID, 0);
			Assert.Greater(stats.AppID, 0);
			Assert.Greater(stats.ClassStats.Length, 0);
			Assert.AreEqual(stats.ClassStats.Length, 9);
			Assert.Greater(stats.Achievments.Length, 0);
		}
	}
}

