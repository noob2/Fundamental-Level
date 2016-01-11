using System.IO;
using WrokingCalendar.Attributes;

namespace WrokingCalendar.Engine.Commands
{
    [Command]
    public class ControlsInfoCommand : Command
    {
        private const string controlsInfoPath = "../../controlsInfo.txt";

        public ControlsInfoCommand(WorkCalerndarEngine engine) : base(engine)
        {
        }

        public override void Execute(string[] command)
        {
            using (StreamReader sr = File.OpenText(controlsInfoPath))
            {
                string content;
                while ((content = sr.ReadLine()) != null)
                {
                    WorkCalerndarEngine.Renderer.WriteLine(content);
                }
            }
        }
    }
}
