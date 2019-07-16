using UnityEngine;

namespace MiniGames.TrainEscape.Scripts
{
	public class GameManager : MonoBehaviour
	{
		[SerializeField] private float _gameTime;

		private float _gameStartTime;

		public float GamePercentage => (Time.time - _gameStartTime) / _gameTime;

		private void Start()
		{
			
		}

		private void StartTheGame()
		{
			Invoke(nameof(GameOver), _gameTime);
			_gameStartTime = Time.time;
		}

		private void GameOver()
		{
			// todo - if needed - check that game is not done
			Debug.Log("Game Over");
		}
		
		
	}
}
