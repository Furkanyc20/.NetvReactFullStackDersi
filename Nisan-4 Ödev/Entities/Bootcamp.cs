using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bootcamp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public BootcampState BootcampState { get; set; }
    }
    public enum BootcampState
    {
        PREPARING,
        OPEN_FOR_APPLICATION,
        IN_PROGRESS,
        FINISHED,
        CANCELLED
    }
}
