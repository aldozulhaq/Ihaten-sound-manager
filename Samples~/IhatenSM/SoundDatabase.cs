using UnityEngine;

namespace Ihaten.soundmanager
{
    public enum SFX
    {
    }

    public enum BGM
    {
    }

    [System.Serializable]
    public struct BackgrundMusic
    {
        public BGM type;
        public AudioClip audioClip;
    }

    [System.Serializable]
    public struct Soundeffect
    {
        public SFX type;
        public AudioClip audioClip;
    }

    [CreateAssetMenu(fileName = "SoundDB", menuName = "Audio/Database")]
    public class SoundDatabase : ScriptableObject
    {
        [Header("Background Music")]
        public BackgrundMusic[] bgm;

        [Header("Sound Effect")]
        public Soundeffect[] sfx;

        public AudioClip GetClip(SFX sfxType)
        {
            AudioClip temp = null;
            foreach (var i in sfx)
            {
                if (i.type == sfxType)
                    temp = i.audioClip;
            }

            return temp;
        }

        public AudioClip GetClip(BGM bgmType)
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