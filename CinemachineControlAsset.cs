using UnityEngine;
using UnityEngine.Playables;

namespace neo.CinemachineTimelineExtension
{
    class CinemachineControlAsset : PlayableAsset
    {
        [Tooltip("the priority of the cinemachine vcam")]
        public int m_priority;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<CinemachineControlBehaviour>.Create(graph);

            var controlBehavior = playable.GetBehaviour();
            controlBehavior.m_vcamPriority = m_priority;

            return playable;
        }
    }
}
