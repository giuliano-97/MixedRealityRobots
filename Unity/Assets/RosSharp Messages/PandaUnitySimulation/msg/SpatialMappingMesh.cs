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
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.PandaUnitySimulation
{
    public class SpatialMappingMesh : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "panda_unity_simulation/SpatialMappingMesh";

        public Header header;
        public string name;
        public Pose pose;
        public byte[] mesh;

        public SpatialMappingMesh()
        {
            this.header = new Header();
            this.name = "";
            this.pose = new Pose();
            this.mesh = new byte[0];
        }

        public SpatialMappingMesh(Header header, string name, Pose pose, byte[] mesh)
        {
            this.header = header;
            this.name = name;
            this.pose = pose;
            this.mesh = mesh;
        }
    }
}