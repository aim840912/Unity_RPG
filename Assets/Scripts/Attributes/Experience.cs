using UnityEngine;

namespace RPG.Attribute
{
    public class Experience : MonoBehaviour
    {
        [SerializeField] float experiencePoints = 0;

        public void GainExperience(float experience)
        {
            experiencePoints += experience;
        }
    }
}