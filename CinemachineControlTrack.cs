using UnityEngine.Timeline;

namespace neo.CinemachineTimelineExtension
{
    [TrackClipType(typeof(CinemachineControlAsset))]
    [TrackBindingType(typeof(Cinemachine.CinemachineVirtualCamera))]
    class CinemachineControlTrack: TrackAsset
    {
    }
}
