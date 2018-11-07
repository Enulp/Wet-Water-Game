using System.Collections.Generic;
using UnityEngine;

public class GameManagerMulti : MonoBehaviour
{
	private const string PLAYER_IDPREFIX = "Player";
	
	private static Dictionary<string, PlayerComponentMulti> players = new Dictionary<string, PlayerComponentMulti>() ;

	public static void ResgisterPlayer(string _netID, PlayerComponentMulti _player)
	{
		string _playerID = PLAYER_IDPREFIX + _netID;
		players.Add(_playerID, _player);
		_player.transform.name = _playerID;
	}

	public static void UnRegisterPlayer(string _playerID)
	{
		players.Remove(_playerID);
	}

	public static PlayerComponentMulti GetPlayer(string _playerID)
	{
		return players[_playerID];
	}

	/*private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(200, 200, 200, 500));
		GUILayout.BeginHorizontal();

		foreach (string _playerID in players.Keys)
		{
			GUILayout.Label(_playerID + "  -  " + players[_playerID].transform.name );
		}
		
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}*/
}
