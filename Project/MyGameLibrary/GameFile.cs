using System;
using System.IO;
using System.Linq;

namespace Fall2020_CSC403_Project.code
{
	public class GameFile
	{
		string inventoryFilePath = Path.Combine(Environment.CurrentDirectory, @"Data\Save Data\", "Inventory Contents.txt");
		string levelFilePath = Path.Combine(Environment.CurrentDirectory, @"Data\Save Data\", "Level Progress.txt");
		string playerFilePath = Path.Combine(Environment.CurrentDirectory, @"Data\Save Data\", "Player Status.txt");

		public GameFile()
		{

		}
		/*
		public void SaveGame(Player player)
		{
			string[] playerInventoryString = player.Inventory.Select(x => x.ToString()).ToArray();
			string levelProgressString = player.levelProgress.ToString();
			string[] playerStatus = { player.Health.ToString(), player.MaxHealth.ToString() };
			player.EquippedItems.CopyTo(playerStatus, 2);
			File.WriteAllLines(inventoryFilePath, playerInventoryString);
			File.WriteAllText(levelFilePath, levelProgressString);
			File.WriteAllLines(playerFilePath, playerStatus);
		}

		public void LoadGame(Player player)
		{
			player.Inventory = File.ReadAllLines(inventoryFilePath).Select(x => int.Parse(x)).ToArray();
			player.levelProgress = int.Parse(File.ReadAllText(levelFilePath));
			string[] tempPlayerStatus = File.ReadAllLines(playerFilePath);
			player.MaxHealth = int.Parse(tempPlayerStatus[0]);
			player.Health = int.Parse(tempPlayerStatus[1]);
			for (int x = 2; x < tempPlayerStatus.Length; x++)
				player.Equip(int.Parse(tempPlayerStatus[x]));
		}

		public void DeleteSave()
		{
			File.WriteAllText(inventoryFilePath, string.Empty);
			File.WriteAllText(levelFilePath, string.Empty);
			File.WriteAllText(playerFilePath, string.Empty);
		}

		*/
	}
}