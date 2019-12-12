using UnityEngine.Playables;

namespace neo.CinemachineTimelineExtension
{
    class CinemachineControlBehaviour: PlayableBehaviour
    {
        public int m_vcamPriority;

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            Cinemachine.CinemachineVirtualCamera _vcam = playerData as Cinemachine.CinemachineVirtualCamera;
            if (_vcam != null)
            {
               _vcam.m_Priority = m_vcamPriority;
            }
        }
    }
}
