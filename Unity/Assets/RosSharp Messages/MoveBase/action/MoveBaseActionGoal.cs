/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.MoveBase
{
    public class MoveBaseActionGoal : ActionGoal<MoveBaseGoal>
    {
        [JsonIgnore]
        public const string RosMessageName = "move_base_msgs/MoveBaseActionGoal";

        public MoveBaseActionGoal() : base()
        {
            this.goal = new MoveBaseGoal();
        }

        public MoveBaseActionGoal(Header header, GoalID goal_id, MoveBaseGoal goal) : base(header, goal_id)
        {
            this.goal = goal;
        }
    }
}
