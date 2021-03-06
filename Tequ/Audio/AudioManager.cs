﻿namespace Tequ.Audio
{
    public static class AudioManager
    {
        // Sound directories.
        public static readonly string AudioDir = Game.StartupPath + "audio\\";
        public static readonly string MusicDir = AudioDir + "music\\";
        public static readonly string SoundDir = AudioDir + "sounds\\";

        // The class object containing the audio system.

        public static IPlayer Player { private set; get; }

        public static void Initialize() {
            // Set and initialize the audio system.
            AudioManager.Player = new Sfml.AudioPlayer();
        }
    }
}
