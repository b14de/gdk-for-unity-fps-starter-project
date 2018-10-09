using Fps.GameLogic.Audio;
using Improbable.Gdk.GameObjectRepresentation;
using Improbable.Gdk.Guns;
using UnityEngine;

namespace Fps.GameLogic.Audio
{
    /// <summary>
    /// Attached to NonAuth player, listens to shot events and plays relevant shot sounds
    /// </summary>
    [RequireComponent(typeof(AudioRandomiser))]
    public class ShotListener : MonoBehaviour
    {
        [Require] ShootingComponent.Requirable.Reader shotReader;

        private AudioRandomiser shotRandomiser;

        private void Start()
        {
            shotRandomiser.GetComponent<AudioRandomiser>();
        }

        private void OnEnable()
        {
            shotReader.OnShots += ShotReaderOnShots;
        }

        private void ShotReaderOnShots(ShotInfo shotInfo)
        {
            shotRandomiser.Play();
        }
    }
}
