using System.Media;
namespace Web2geter
{
    public class Sound
    {
        private SoundPlayer _player;
        string SoundFile = @"A:\効果音\snake.wav";

        public void StopSound()
        {
            if (_player == null) return;
            _player.Stop();
            _player.Dispose();
            _player = null;
        }

        public void PlaySound()
        {
            _player = new SoundPlayer(SoundFile);
            _player.PlaySync();
        }
    }
}