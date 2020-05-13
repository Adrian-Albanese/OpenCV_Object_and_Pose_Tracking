using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;

namespace OpenCV_Object_and_Pose_Tracking
{
    class SelectedCamera
    {
        public string SelectedCameraName { get; set; }
        public string SelectedCamera_MonikerString { get; set; }
        public int SelectedCameraIndex { get; set; }
        public VideoCaptureDevice videoSource { get; set; }

    }

}
