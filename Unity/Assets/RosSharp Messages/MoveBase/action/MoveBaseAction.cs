/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.MoveBase
{
    public class MoveBaseAction : Action<MoveBaseActionGoal, MoveBaseActionResult, MoveBaseActionFeedback, MoveBaseGoal, MoveBaseResult, MoveBaseFeedback>
    {
        [JsonIgnore]
        public const string RosMessageName = "move_base_msgs/MoveBaseAction";

        public MoveBaseAction() : base()
        {
            this.action_goal = new MoveBaseActionGoal();
            this.action_result = new MoveBaseActionResult();
            this.action_feedback = new MoveBaseActionFeedback();
        }

    }
}
