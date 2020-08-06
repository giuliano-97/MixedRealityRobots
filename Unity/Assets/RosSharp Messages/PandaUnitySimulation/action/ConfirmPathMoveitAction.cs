/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.PandaUnitySimulation
{
    public class ConfirmPathMoveitAction : Action<ConfirmPathMoveitActionGoal, ConfirmPathMoveitActionResult, ConfirmPathMoveitActionFeedback, ConfirmPathMoveitGoal, ConfirmPathMoveitResult, ConfirmPathMoveitFeedback>
    {
        [JsonIgnore]
        public const string RosMessageName = "panda_unity_simulation/ConfirmPathMoveitAction";

        public ConfirmPathMoveitAction() : base()
        {
            this.action_goal = new ConfirmPathMoveitActionGoal();
            this.action_result = new ConfirmPathMoveitActionResult();
            this.action_feedback = new ConfirmPathMoveitActionFeedback();
        }

    }
}
