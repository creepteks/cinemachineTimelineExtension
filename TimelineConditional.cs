using UnityEngine;

namespace neo.CinemachineTimelineExtension
{
    public interface ITimelineConditional
    {
        bool timelineConditionMet { get; }
        bool IsConditionMet(TimeMachineCondition condition);
    }

    public enum TimeMachineCondition
    {
        Always,
        Never,
        ConditionalNotMet,
        ConditionalMet
    }

    public class TimelineConditional : MonoBehaviour, ITimelineConditional
    {
        public bool timelineConditionMet { get; protected set; } = false;

        public bool IsConditionMet(TimeMachineCondition condition)
        {
            switch (condition)
            {
                case TimeMachineCondition.Always:
                    return true;

                case TimeMachineCondition.ConditionalNotMet:
                    return !timelineConditionMet;

                case TimeMachineCondition.ConditionalMet:
                    return timelineConditionMet;

                case TimeMachineCondition.Never:
                default:
                    return false;
            }
        }
    }

}