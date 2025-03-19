using UnityEngine;
using YVR.Core;

namespace YVR.Samples
{
    public class SampleControl : MonoBehaviour
    {
        private void Start()
        {
            YVRManager.instance.hmdManager.SetPassthrough(true);
        }
    }
}