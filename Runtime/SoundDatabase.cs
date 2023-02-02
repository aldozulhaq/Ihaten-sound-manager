using UnityEngine;

namespace Ihaten.SoundManager
{
    [System.Serializable]
    public struct BackgroundMusic
    {
        public SoundType.BGM type;
        public AudioClip audioClip;
    }

    [System.Serializable]
    public struct SoundEffect
    {
        public SoundType.SFX type;
        public AudioClip audioClip;
    }

    [CreateAssetMenu(fileName = "SoundDB", menuName = "Audio/Database")]
    public class SoundDatabase : ScriptableObject
    {

        [Header("Background Music")]
        public BackgroundMusic[] bgm;

        [Header("Sound Effect")]
        public SoundEffect[] sfx;

        public AudioClip GetClip(SoundType.SFX sfxType)
        {
            AudioClip temp = null;
            foreach (var i in sfx)
            {
                if (i.type == sfxType)
                    temp = i.audioClip;
            }

            return temp;
        }

        public AudioClip GetClip(SoundType.BGM bgmType)
        {
            AudioClip temp = null;
            foreach (var i in bgm)
            {
                if (i.type == bgmType)
                    temp = i.audioClip;
            }

            return temp;
        }
    }

}