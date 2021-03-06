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
    public class MoveBaseActionResult : ActionResult<MoveBaseResult>
    {
        [JsonIgnore]
        public const string RosMessageName = "move_base_msgs/MoveBaseActionResult";

        public MoveBaseActionResult() : base()
        {
            this.result = new MoveBaseResult();
        }

        public MoveBaseActionResult(Header header, GoalStatus status, MoveBaseResult result) : base(header, status)
        {
            this.result = result;
        }
    }
}
